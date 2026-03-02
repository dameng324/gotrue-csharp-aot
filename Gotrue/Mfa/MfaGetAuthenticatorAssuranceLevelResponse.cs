using System;

namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    /// Response from the Get Authenticator Assurance Level endpoint, which returns the current and next AAL levels for the user, as well as the current authentication methods in use.
    /// </summary>
    public class MfaGetAuthenticatorAssuranceLevelResponse
    {
        /// <summary>
        /// The current Authenticator Assurance Level (AAL) for the user. This indicates the level of assurance that the user's identity has been verified with, based on the authentication methods they have used. Possible values include "aal1", "aal2", and "aal3". If the user has not authenticated with any methods, this may be null.
        /// </summary>
        public AuthenticatorAssuranceLevel? CurrentLevel { get; set; }

        /// <summary>
        /// The next Authenticator Assurance Level (AAL) that the user can achieve by adding additional authentication methods. This indicates the next level of assurance that the user can reach by adding more authentication methods. Possible values include "aal1", "aal2", and "aal3". If the user has already achieved the highest AAL or if there are no additional methods to add, this may be null.
        /// </summary>
        public AuthenticatorAssuranceLevel? NextLevel { get; set; }

        /// <summary>
        /// An array of the current authentication methods that the user has used to authenticate. Each method includes details such as the factor type (e.g., "totp", "webauthn"), the friendly name, and the status of the factor. This information can be used to determine which authentication methods the user has already set up and is currently using for authentication.
        /// </summary>
        public AmrEntry[] CurrentAuthenticationMethods { get; set; } = Array.Empty<AmrEntry>();
    }
}
