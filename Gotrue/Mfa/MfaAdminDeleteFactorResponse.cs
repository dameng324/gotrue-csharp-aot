using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class MfaAdminDeleteFactorResponse
    {
        /// <summary>
        ///  Id of the factor that was successfully deleted
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;
    }
}
