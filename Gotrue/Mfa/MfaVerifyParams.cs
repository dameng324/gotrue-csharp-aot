namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Parameters for verifying a factor. This is used in the VerifyFactor() method after a challenge has been created.
    /// </summary>
    public class MfaVerifyParams
    {
        /// ID of the factor being verified. Returned in enroll()
        public string FactorId { get; set; } = string.Empty;

        /// ID of the challenge being verified. Returned in challenge()
        public string ChallengeId { get; set; } = string.Empty;

        /// Verification code provided by the user
        public string Code { get; set; } = string.Empty;
    }
}
