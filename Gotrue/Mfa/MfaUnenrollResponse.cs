using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Response from the GoTrue server when unenrolling an MFA factor.
    /// </summary>
    public class MfaUnenrollResponse
    {
        /// <summary>
        /// The ID of the unenrolled MFA factor.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
