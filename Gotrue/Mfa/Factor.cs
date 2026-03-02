using System;
using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Represents a multi-factor authentication factor associated with a user in the GoTrue system.
    /// </summary>
    public class Factor
    {
        /// <summary>
        /// The unique identifier for the MFA factor.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        /// <summary>
        /// A user-friendly name for the MFA factor, which may be null if not set.
        /// </summary>
        [JsonPropertyName("friendly_name")]
        public string? FriendlyName { get; set; }

        /// <summary>
        /// The type of MFA factor (e.g., "totp", "sms", etc.).
        /// </summary>
        [JsonPropertyName("factor_type")]
        public string FactorType { get; set; } = string.Empty;

        /// <summary>
        /// The current status of the MFA factor (e.g., "verified", "unverified", etc.).
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; } = string.Empty;

        /// <summary>
        /// The timestamp indicating when the MFA factor was created.
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The timestamp indicating when the MFA factor was last updated.
        /// </summary>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
