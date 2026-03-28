#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://docs.speechmatics.com/batch.yaml (Swagger 2.0)

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error -o openapi.yaml https://docs.speechmatics.com/batch.yaml

# Fix the Swagger 2.0 spec:
# 1. Fix basePath (full URL -> path only) and add host/schemes
# 2. Convert apiKey security to type/name suitable for --security-scheme override
# 3. Remove AuthHeader and EARTag parameter refs (handled by security scheme)
python3 -c "
import yaml

with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)

# Fix basePath and add host
spec['host'] = 'asr.api.speechmatics.com'
spec['basePath'] = '/v2'
spec['schemes'] = ['https']

# Replace securityDefinitions with apiKey in header
spec['securityDefinitions'] = {
    'BearerAuth': {
        'type': 'apiKey',
        'in': 'header',
        'name': 'Authorization',
        'description': 'Bearer token authentication'
    }
}

# Add top-level security
spec['security'] = [{'BearerAuth': []}]

# Remove the AuthHeader/EARTag parameter definitions
if 'parameters' in spec:
    for key in ('AuthHeader', 'EARTag'):
        spec['parameters'].pop(key, None)
    if not spec['parameters']:
        del spec['parameters']

# Remove AuthHeader and EARTag references from all path parameters
refs_to_remove = {'#/parameters/AuthHeader', '#/parameters/EARTag'}
for path_val in spec.get('paths', {}).values():
    if 'parameters' in path_val:
        path_val['parameters'] = [
            p for p in path_val['parameters']
            if not (isinstance(p, dict) and p.get('\$ref') in refs_to_remove)
        ]
        if not path_val['parameters']:
            del path_val['parameters']
    for method in ('get', 'post', 'put', 'delete', 'patch'):
        if method in path_val and 'parameters' in path_val[method]:
            path_val[method]['parameters'] = [
                p for p in path_val[method]['parameters']
                if not (isinstance(p, dict) and p.get('\$ref') in refs_to_remove)
            ]
            if not path_val[method]['parameters']:
                del path_val[method]['parameters']

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, allow_unicode=True, sort_keys=False)
"

# Auth: --security-scheme overrides apiKey with standard HTTP bearer.
autosdk generate openapi.yaml \
  --namespace Speechmatics \
  --clientClassName SpeechmaticsClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme Http:Header:Bearer \
  --base-url https://asr.api.speechmatics.com/v2
