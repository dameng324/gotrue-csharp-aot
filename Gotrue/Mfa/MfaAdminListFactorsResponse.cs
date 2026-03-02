using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class MfaAdminListFactorsResponse
    {
        /// <summary>
        ///
        /// </summary>
        public List<Factor> Factors { get; set; } = new List<Factor>();
    }
}
