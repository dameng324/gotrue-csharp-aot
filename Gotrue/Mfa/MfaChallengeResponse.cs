using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class MfaChallengeResponse
    {
        /// ID of the newly created challenge.
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        ///
        /// </summary>
        [JsonPropertyName("expires_at")]
        public long ExpiresAt { get; set; }
    }
}
