using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Response from the GoTrue server after verifying an MFA factor. Contains a new access token and updated user profile.
    /// </summary>
    public class MfaVerifyResponse
    {
        /// New access token (JWT) after successful verification
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; } = string.Empty;

        /// Type of token, typically `Bearer`
        [JsonPropertyName("token_type")]
        public string TokenType { get; set; } = string.Empty;

        /// Number of seconds in which the access token will expire
        [JsonPropertyName("expires_in")]
        public int ExpiresIn { get; set; }

        /// Refresh token you can use to obtain new access tokens when expired
        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; } = string.Empty;

        /// Updated user profile
        [JsonPropertyName("user")]
        public User User { get; set; } = default!;
    }
}
