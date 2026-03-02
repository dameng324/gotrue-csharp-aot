namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class MfaAdminDeleteFactorParams
    {
        /// Id of the MFA factor to delete
        public string Id { get; set; } = string.Empty;

        /// Id of the user whose factor is being deleted
        public string UserId { get; set; } = string.Empty;
    }
}
