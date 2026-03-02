namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Parameters for unenrolling a factor. Only requires the factor ID, which can be obtained from the list of enrolled factors.
    /// </summary>
    public class MfaUnenrollParams
    {
        /// <summary>
        /// The ID of the factor to unenroll. This can be obtained from the list of enrolled factors.
        /// </summary>
        public string FactorId { get; set; } = string.Empty;
    }
}
