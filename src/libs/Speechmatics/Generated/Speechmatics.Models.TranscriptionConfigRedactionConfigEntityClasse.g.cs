
#nullable enable

namespace Speechmatics
{
    /// <summary>
    ///
    /// </summary>
    public enum TranscriptionConfigRedactionConfigEntityClasse
    {
        /// <summary>
        ///
        /// </summary>
        AccountNumber,
        /// <summary>
        ///
        /// </summary>
        Age,
        /// <summary>
        ///
        /// </summary>
        Appi,
        /// <summary>
        ///
        /// </summary>
        AppiSensitive,
        /// <summary>
        ///
        /// </summary>
        BankAccount,
        /// <summary>
        ///
        /// </summary>
        BloodType,
        /// <summary>
        ///
        /// </summary>
        Condition,
        /// <summary>
        ///
        /// </summary>
        Cpra,
        /// <summary>
        ///
        /// </summary>
        CreditCard,
        /// <summary>
        ///
        /// </summary>
        CreditCardExpiration,
        /// <summary>
        ///
        /// </summary>
        Cvv,
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        DateInterval,
        /// <summary>
        ///
        /// </summary>
        Dob,
        /// <summary>
        ///
        /// </summary>
        Dose,
        /// <summary>
        ///
        /// </summary>
        DriverLicense,
        /// <summary>
        ///
        /// </summary>
        Drug,
        /// <summary>
        ///
        /// </summary>
        Duration,
        /// <summary>
        ///
        /// </summary>
        EmailAddress,
        /// <summary>
        ///
        /// </summary>
        Event,
        /// <summary>
        ///
        /// </summary>
        Filename,
        /// <summary>
        ///
        /// </summary>
        Gdpr,
        /// <summary>
        ///
        /// </summary>
        GdprSensitive,
        /// <summary>
        ///
        /// </summary>
        Gender,
        /// <summary>
        ///
        /// </summary>
        Health,
        /// <summary>
        ///
        /// </summary>
        HealthcareNumber,
        /// <summary>
        ///
        /// </summary>
        HipaaSafeHarbor,
        /// <summary>
        ///
        /// </summary>
        Injury,
        /// <summary>
        ///
        /// </summary>
        IpAddress,
        /// <summary>
        ///
        /// </summary>
        Language,
        /// <summary>
        ///
        /// </summary>
        Location,
        /// <summary>
        ///
        /// </summary>
        LocationAddress,
        /// <summary>
        ///
        /// </summary>
        LocationAddressStreet,
        /// <summary>
        ///
        /// </summary>
        LocationCity,
        /// <summary>
        ///
        /// </summary>
        LocationCoordinate,
        /// <summary>
        ///
        /// </summary>
        LocationCountry,
        /// <summary>
        ///
        /// </summary>
        LocationState,
        /// <summary>
        ///
        /// </summary>
        LocationZip,
        /// <summary>
        ///
        /// </summary>
        MaritalStatus,
        /// <summary>
        ///
        /// </summary>
        MedicalProcess,
        /// <summary>
        ///
        /// </summary>
        Money,
        /// <summary>
        ///
        /// </summary>
        Name,
        /// <summary>
        ///
        /// </summary>
        NameFamily,
        /// <summary>
        ///
        /// </summary>
        NameGiven,
        /// <summary>
        ///
        /// </summary>
        NameMedicalProfessional,
        /// <summary>
        ///
        /// </summary>
        NumericalPii,
        /// <summary>
        ///
        /// </summary>
        Occupation,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        OrganizationId,
        /// <summary>
        ///
        /// </summary>
        OrganizationMedicalFacility,
        /// <summary>
        ///
        /// </summary>
        Origin,
        /// <summary>
        ///
        /// </summary>
        PassportNumber,
        /// <summary>
        ///
        /// </summary>
        Password,
        /// <summary>
        ///
        /// </summary>
        Pci,
        /// <summary>
        ///
        /// </summary>
        PhoneNumber,
        /// <summary>
        ///
        /// </summary>
        PhysicalAttribute,
        /// <summary>
        ///
        /// </summary>
        Pii,
        /// <summary>
        ///
        /// </summary>
        PoliticalAffiliation,
        /// <summary>
        ///
        /// </summary>
        QuebecPrivacyAct,
        /// <summary>
        ///
        /// </summary>
        Religion,
        /// <summary>
        ///
        /// </summary>
        RoutingNumber,
        /// <summary>
        ///
        /// </summary>
        Sexuality,
        /// <summary>
        ///
        /// </summary>
        Ssn,
        /// <summary>
        ///
        /// </summary>
        SsnInAadhaar,
        /// <summary>
        ///
        /// </summary>
        Statistics,
        /// <summary>
        ///
        /// </summary>
        Time,
        /// <summary>
        ///
        /// </summary>
        Url,
        /// <summary>
        ///
        /// </summary>
        Username,
        /// <summary>
        ///
        /// </summary>
        VehicleId,
        /// <summary>
        ///
        /// </summary>
        ZodiacSign,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptionConfigRedactionConfigEntityClasseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptionConfigRedactionConfigEntityClasse value)
        {
            return value switch
            {
                TranscriptionConfigRedactionConfigEntityClasse.AccountNumber => "account_number",
                TranscriptionConfigRedactionConfigEntityClasse.Age => "age",
                TranscriptionConfigRedactionConfigEntityClasse.Appi => "appi",
                TranscriptionConfigRedactionConfigEntityClasse.AppiSensitive => "appi_sensitive",
                TranscriptionConfigRedactionConfigEntityClasse.BankAccount => "bank_account",
                TranscriptionConfigRedactionConfigEntityClasse.BloodType => "blood_type",
                TranscriptionConfigRedactionConfigEntityClasse.Condition => "condition",
                TranscriptionConfigRedactionConfigEntityClasse.Cpra => "cpra",
                TranscriptionConfigRedactionConfigEntityClasse.CreditCard => "credit_card",
                TranscriptionConfigRedactionConfigEntityClasse.CreditCardExpiration => "credit_card_expiration",
                TranscriptionConfigRedactionConfigEntityClasse.Cvv => "cvv",
                TranscriptionConfigRedactionConfigEntityClasse.Date => "date",
                TranscriptionConfigRedactionConfigEntityClasse.DateInterval => "date_interval",
                TranscriptionConfigRedactionConfigEntityClasse.Dob => "dob",
                TranscriptionConfigRedactionConfigEntityClasse.Dose => "dose",
                TranscriptionConfigRedactionConfigEntityClasse.DriverLicense => "driver_license",
                TranscriptionConfigRedactionConfigEntityClasse.Drug => "drug",
                TranscriptionConfigRedactionConfigEntityClasse.Duration => "duration",
                TranscriptionConfigRedactionConfigEntityClasse.EmailAddress => "email_address",
                TranscriptionConfigRedactionConfigEntityClasse.Event => "event",
                TranscriptionConfigRedactionConfigEntityClasse.Filename => "filename",
                TranscriptionConfigRedactionConfigEntityClasse.Gdpr => "gdpr",
                TranscriptionConfigRedactionConfigEntityClasse.GdprSensitive => "gdpr_sensitive",
                TranscriptionConfigRedactionConfigEntityClasse.Gender => "gender",
                TranscriptionConfigRedactionConfigEntityClasse.Health => "health",
                TranscriptionConfigRedactionConfigEntityClasse.HealthcareNumber => "healthcare_number",
                TranscriptionConfigRedactionConfigEntityClasse.HipaaSafeHarbor => "hipaa_safe_harbor",
                TranscriptionConfigRedactionConfigEntityClasse.Injury => "injury",
                TranscriptionConfigRedactionConfigEntityClasse.IpAddress => "ip_address",
                TranscriptionConfigRedactionConfigEntityClasse.Language => "language",
                TranscriptionConfigRedactionConfigEntityClasse.Location => "location",
                TranscriptionConfigRedactionConfigEntityClasse.LocationAddress => "location_address",
                TranscriptionConfigRedactionConfigEntityClasse.LocationAddressStreet => "location_address_street",
                TranscriptionConfigRedactionConfigEntityClasse.LocationCity => "location_city",
                TranscriptionConfigRedactionConfigEntityClasse.LocationCoordinate => "location_coordinate",
                TranscriptionConfigRedactionConfigEntityClasse.LocationCountry => "location_country",
                TranscriptionConfigRedactionConfigEntityClasse.LocationState => "location_state",
                TranscriptionConfigRedactionConfigEntityClasse.LocationZip => "location_zip",
                TranscriptionConfigRedactionConfigEntityClasse.MaritalStatus => "marital_status",
                TranscriptionConfigRedactionConfigEntityClasse.MedicalProcess => "medical_process",
                TranscriptionConfigRedactionConfigEntityClasse.Money => "money",
                TranscriptionConfigRedactionConfigEntityClasse.Name => "name",
                TranscriptionConfigRedactionConfigEntityClasse.NameFamily => "name_family",
                TranscriptionConfigRedactionConfigEntityClasse.NameGiven => "name_given",
                TranscriptionConfigRedactionConfigEntityClasse.NameMedicalProfessional => "name_medical_professional",
                TranscriptionConfigRedactionConfigEntityClasse.NumericalPii => "numerical_pii",
                TranscriptionConfigRedactionConfigEntityClasse.Occupation => "occupation",
                TranscriptionConfigRedactionConfigEntityClasse.Organization => "organization",
                TranscriptionConfigRedactionConfigEntityClasse.OrganizationId => "organization_id",
                TranscriptionConfigRedactionConfigEntityClasse.OrganizationMedicalFacility => "organization_medical_facility",
                TranscriptionConfigRedactionConfigEntityClasse.Origin => "origin",
                TranscriptionConfigRedactionConfigEntityClasse.PassportNumber => "passport_number",
                TranscriptionConfigRedactionConfigEntityClasse.Password => "password",
                TranscriptionConfigRedactionConfigEntityClasse.Pci => "pci",
                TranscriptionConfigRedactionConfigEntityClasse.PhoneNumber => "phone_number",
                TranscriptionConfigRedactionConfigEntityClasse.PhysicalAttribute => "physical_attribute",
                TranscriptionConfigRedactionConfigEntityClasse.Pii => "pii",
                TranscriptionConfigRedactionConfigEntityClasse.PoliticalAffiliation => "political_affiliation",
                TranscriptionConfigRedactionConfigEntityClasse.QuebecPrivacyAct => "quebec_privacy_act",
                TranscriptionConfigRedactionConfigEntityClasse.Religion => "religion",
                TranscriptionConfigRedactionConfigEntityClasse.RoutingNumber => "routing_number",
                TranscriptionConfigRedactionConfigEntityClasse.Sexuality => "sexuality",
                TranscriptionConfigRedactionConfigEntityClasse.Ssn => "ssn",
                TranscriptionConfigRedactionConfigEntityClasse.SsnInAadhaar => "ssn_in_aadhaar",
                TranscriptionConfigRedactionConfigEntityClasse.Statistics => "statistics",
                TranscriptionConfigRedactionConfigEntityClasse.Time => "time",
                TranscriptionConfigRedactionConfigEntityClasse.Url => "url",
                TranscriptionConfigRedactionConfigEntityClasse.Username => "username",
                TranscriptionConfigRedactionConfigEntityClasse.VehicleId => "vehicle_id",
                TranscriptionConfigRedactionConfigEntityClasse.ZodiacSign => "zodiac_sign",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptionConfigRedactionConfigEntityClasse? ToEnum(string value)
        {
            return value switch
            {
                "account_number" => TranscriptionConfigRedactionConfigEntityClasse.AccountNumber,
                "age" => TranscriptionConfigRedactionConfigEntityClasse.Age,
                "appi" => TranscriptionConfigRedactionConfigEntityClasse.Appi,
                "appi_sensitive" => TranscriptionConfigRedactionConfigEntityClasse.AppiSensitive,
                "bank_account" => TranscriptionConfigRedactionConfigEntityClasse.BankAccount,
                "blood_type" => TranscriptionConfigRedactionConfigEntityClasse.BloodType,
                "condition" => TranscriptionConfigRedactionConfigEntityClasse.Condition,
                "cpra" => TranscriptionConfigRedactionConfigEntityClasse.Cpra,
                "credit_card" => TranscriptionConfigRedactionConfigEntityClasse.CreditCard,
                "credit_card_expiration" => TranscriptionConfigRedactionConfigEntityClasse.CreditCardExpiration,
                "cvv" => TranscriptionConfigRedactionConfigEntityClasse.Cvv,
                "date" => TranscriptionConfigRedactionConfigEntityClasse.Date,
                "date_interval" => TranscriptionConfigRedactionConfigEntityClasse.DateInterval,
                "dob" => TranscriptionConfigRedactionConfigEntityClasse.Dob,
                "dose" => TranscriptionConfigRedactionConfigEntityClasse.Dose,
                "driver_license" => TranscriptionConfigRedactionConfigEntityClasse.DriverLicense,
                "drug" => TranscriptionConfigRedactionConfigEntityClasse.Drug,
                "duration" => TranscriptionConfigRedactionConfigEntityClasse.Duration,
                "email_address" => TranscriptionConfigRedactionConfigEntityClasse.EmailAddress,
                "event" => TranscriptionConfigRedactionConfigEntityClasse.Event,
                "filename" => TranscriptionConfigRedactionConfigEntityClasse.Filename,
                "gdpr" => TranscriptionConfigRedactionConfigEntityClasse.Gdpr,
                "gdpr_sensitive" => TranscriptionConfigRedactionConfigEntityClasse.GdprSensitive,
                "gender" => TranscriptionConfigRedactionConfigEntityClasse.Gender,
                "health" => TranscriptionConfigRedactionConfigEntityClasse.Health,
                "healthcare_number" => TranscriptionConfigRedactionConfigEntityClasse.HealthcareNumber,
                "hipaa_safe_harbor" => TranscriptionConfigRedactionConfigEntityClasse.HipaaSafeHarbor,
                "injury" => TranscriptionConfigRedactionConfigEntityClasse.Injury,
                "ip_address" => TranscriptionConfigRedactionConfigEntityClasse.IpAddress,
                "language" => TranscriptionConfigRedactionConfigEntityClasse.Language,
                "location" => TranscriptionConfigRedactionConfigEntityClasse.Location,
                "location_address" => TranscriptionConfigRedactionConfigEntityClasse.LocationAddress,
                "location_address_street" => TranscriptionConfigRedactionConfigEntityClasse.LocationAddressStreet,
                "location_city" => TranscriptionConfigRedactionConfigEntityClasse.LocationCity,
                "location_coordinate" => TranscriptionConfigRedactionConfigEntityClasse.LocationCoordinate,
                "location_country" => TranscriptionConfigRedactionConfigEntityClasse.LocationCountry,
                "location_state" => TranscriptionConfigRedactionConfigEntityClasse.LocationState,
                "location_zip" => TranscriptionConfigRedactionConfigEntityClasse.LocationZip,
                "marital_status" => TranscriptionConfigRedactionConfigEntityClasse.MaritalStatus,
                "medical_process" => TranscriptionConfigRedactionConfigEntityClasse.MedicalProcess,
                "money" => TranscriptionConfigRedactionConfigEntityClasse.Money,
                "name" => TranscriptionConfigRedactionConfigEntityClasse.Name,
                "name_family" => TranscriptionConfigRedactionConfigEntityClasse.NameFamily,
                "name_given" => TranscriptionConfigRedactionConfigEntityClasse.NameGiven,
                "name_medical_professional" => TranscriptionConfigRedactionConfigEntityClasse.NameMedicalProfessional,
                "numerical_pii" => TranscriptionConfigRedactionConfigEntityClasse.NumericalPii,
                "occupation" => TranscriptionConfigRedactionConfigEntityClasse.Occupation,
                "organization" => TranscriptionConfigRedactionConfigEntityClasse.Organization,
                "organization_id" => TranscriptionConfigRedactionConfigEntityClasse.OrganizationId,
                "organization_medical_facility" => TranscriptionConfigRedactionConfigEntityClasse.OrganizationMedicalFacility,
                "origin" => TranscriptionConfigRedactionConfigEntityClasse.Origin,
                "passport_number" => TranscriptionConfigRedactionConfigEntityClasse.PassportNumber,
                "password" => TranscriptionConfigRedactionConfigEntityClasse.Password,
                "pci" => TranscriptionConfigRedactionConfigEntityClasse.Pci,
                "phone_number" => TranscriptionConfigRedactionConfigEntityClasse.PhoneNumber,
                "physical_attribute" => TranscriptionConfigRedactionConfigEntityClasse.PhysicalAttribute,
                "pii" => TranscriptionConfigRedactionConfigEntityClasse.Pii,
                "political_affiliation" => TranscriptionConfigRedactionConfigEntityClasse.PoliticalAffiliation,
                "quebec_privacy_act" => TranscriptionConfigRedactionConfigEntityClasse.QuebecPrivacyAct,
                "religion" => TranscriptionConfigRedactionConfigEntityClasse.Religion,
                "routing_number" => TranscriptionConfigRedactionConfigEntityClasse.RoutingNumber,
                "sexuality" => TranscriptionConfigRedactionConfigEntityClasse.Sexuality,
                "ssn" => TranscriptionConfigRedactionConfigEntityClasse.Ssn,
                "ssn_in_aadhaar" => TranscriptionConfigRedactionConfigEntityClasse.SsnInAadhaar,
                "statistics" => TranscriptionConfigRedactionConfigEntityClasse.Statistics,
                "time" => TranscriptionConfigRedactionConfigEntityClasse.Time,
                "url" => TranscriptionConfigRedactionConfigEntityClasse.Url,
                "username" => TranscriptionConfigRedactionConfigEntityClasse.Username,
                "vehicle_id" => TranscriptionConfigRedactionConfigEntityClasse.VehicleId,
                "zodiac_sign" => TranscriptionConfigRedactionConfigEntityClasse.ZodiacSign,
                _ => null,
            };
        }
    }
}