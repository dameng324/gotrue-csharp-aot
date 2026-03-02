namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Parameters for enrolling a new MFA factor. The only required parameter is the factor type, which can be "totp" or "webauthn". The issuer and friendly name are optional and can be used to provide additional information about the factor to the user.
    /// </summary>
    public class MfaEnrollParams
    {
        /// <summary>
        /// The type of MFA factor to enroll. Can be "totp" or "webauthn".
        /// </summary>
        public string FactorType { get; set; } = string.Empty;

        /// <summary>
        /// The issuer of the MFA factor. This is typically the name of the service or application that the factor is associated with, and is used to help the user identify the factor when they are prompted to use it for authentication.
        /// </summary>
        public string? Issuer { get; set; }

        /// <summary>
        /// A user-friendly name for the MFA factor. This can be used to help the user identify the factor when they are prompted to use it for authentication, and can be especially useful if the user has multiple factors enrolled.
        /// </summary>
        public string? FriendlyName { get; set; }
    }
}
