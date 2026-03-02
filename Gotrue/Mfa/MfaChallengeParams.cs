namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class MfaChallengeParams
    {
        /// <summary>
        /// Id of the factor to be challenged. Returned in enroll().
        /// </summary>
        public string FactorId { get; set; } = string.Empty;
    }
}
