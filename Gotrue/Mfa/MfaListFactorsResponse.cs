using System.Collections.Generic;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Response from the List Factors endpoint, which returns all MFA factors for a user.
    /// </summary>
    public class MfaListFactorsResponse
    {
        /// All available factors (verified and unverified)
        public List<Factor> All { get; set; } = new List<Factor>();

        /// Only verified TOTP factors. (A subset of `all`.)
        public List<Factor> Totp { get; set; } = new List<Factor>();
    }
}
