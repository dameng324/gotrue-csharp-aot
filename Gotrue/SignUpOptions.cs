using System.Collections.Generic;
using System.Text.Json;

namespace Supabase.Gotrue
{
    /// <summary>
    /// Options used for signing up a user.
    /// </summary>
    public class SignUpOptions : SignInOptions
    {
        /// <summary>
        /// Optional user metadata.
        /// </summary>
        public Dictionary<string, JsonElement>? Data { get; set; }
    }
}
