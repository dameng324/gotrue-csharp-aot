using System.Collections.Generic;
using System.Text.Json.Serialization;
using Supabase.Gotrue.Mfa;
using Supabase.Gotrue.Responses;

namespace Supabase.Gotrue
{
    /// <summary>
    ///
    /// </summary>
    [JsonSerializable(typeof(List<Factor>))]
    [JsonSerializable(typeof(GenerateLinkResponse))]
    [JsonSerializable(typeof(GenerateLinkOptions))]
    [JsonSerializable(typeof(Session))]
    [JsonSerializable(typeof(UserList<User>))]
    [JsonSerializable(typeof(MfaEnrollResponse))]
    [JsonSerializable(typeof(MfaChallengeResponse))]
    [JsonSerializable(typeof(MfaVerifyResponse))]
    [JsonSerializable(typeof(MfaUnenrollResponse))]
    [JsonSerializable(typeof(SSOResponse))]
    [JsonSerializable(typeof(UserAttributes))]
    [JsonSerializable(typeof(AdminUserAttributes))]
    [JsonSerializable(typeof(Dictionary<string, string>))]
    [JsonSerializable(typeof(Dictionary<string, object?>))]
    [JsonSerializable(typeof(AmrEntry))]
    [JsonSerializable(typeof(Settings))]
    [JsonSerializable(typeof(MfaAdminDeleteFactorResponse))]
    internal partial class GotrueJsonContext : JsonSerializerContext { }
}
