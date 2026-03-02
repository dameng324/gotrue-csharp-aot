using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Response from the server when enrolling a new MFA factor. Contains the ID of the newly enrolled factor (in an unverified state) and the TOTP enrollment information.
    /// </summary>
    public class MfaEnrollResponse
    {
        /// ID of the factor that was just enrolled (in an unverified state).
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// Type of MFA factor. Only `totp` supported for now.
        [JsonPropertyName("type")]
        public string Type { get; set; } = string.Empty;

        /// TOTP enrollment information.
        [JsonPropertyName("totp")]
        public TOTP Totp { get; set; } = default!;

        /// Friendly name of the factor, useful for distinguishing between factors
        [JsonPropertyName("friendly_name")]
        public string FriendlyName { get; set; } = string.Empty;
    }
}
