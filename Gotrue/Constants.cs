using System.Collections.Generic;
using Supabase.Core.Attributes;

#pragma warning disable CS1591

namespace Supabase.Gotrue
{
    /// <summary>
    /// Constants used throughout the Gotrue Client
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// URL for the Gotrue server. Defaults to localhost:9999.
        /// </summary>
        public const string GOTRUE_URL = "http://localhost:9999";

        public const string AUDIENCE = "";
        public const int EXPIRY_MARGIN = 60 * 1000;
        public const string STORAGE_KEY = "supabase.auth.token";

        public static readonly Dictionary<string, object> CookieOptions = new Dictionary<
            string,
            object
        >
        {
            { "name", "sb:token" },
            { "lifetime", 60 * 60 * 8 },
            { "domain", "" },
            { "path", "/" },
            { "sameSite", "lax" },
        };

        public enum SortOrder
        {
            Ascending,

            Descending,
        }

        internal static string GetMappedString(this SortOrder sortOrder)
        {
            return sortOrder switch
            {
                SortOrder.Ascending => "asc",
                SortOrder.Descending => "desc",
                _ => string.Empty,
            };
        }

        public enum MobileOtpType
        {
            SMS,

            PhoneChange,
        }

        internal static string GetMappedString(this MobileOtpType mobileOtpType)
        {
            return mobileOtpType switch
            {
                MobileOtpType.SMS => "sms",
                MobileOtpType.PhoneChange => "phone_change",
                _ => string.Empty,
            };
        }

        public enum EmailOtpType
        {
            Signup,

            Invite,

            MagicLink,

            Recovery,

            EmailChange,

            Email,
        }

        internal static string GetMappedString(this EmailOtpType emailOtpType)
        {
            return emailOtpType switch
            {
                EmailOtpType.Signup => "signup",
                EmailOtpType.Invite => "invite",
                EmailOtpType.MagicLink => "magiclink",
                EmailOtpType.Recovery => "recovery",
                EmailOtpType.EmailChange => "email_change",
                EmailOtpType.Email => "email",
                _ => string.Empty,
            };
        }

        /// <summary>
        /// Providers available to Supabase
        /// Ref: https://supabase.github.io/gotrue-js/modules.html#Provider
        /// </summary>
        public enum Provider
        {
            AnonymousUsers,

            Apple,

            Azure,

            Bitbucket,

            Discord,

            Facebook,

            Figma,

            Fly,

            Github,

            Gitlab,

            Google,

            Kakao,

            KeyCloak,

            LinkedIn,

            LinkedInOIDC,

            Notion,

            Slack,

            Spotify,

            Twitch,

            Twitter,

            WorkOS,

            Zoom,
        }

        internal static string GetMappedString(this Provider provider)
        {
            return provider switch
            {
                Provider.AnonymousUsers => "anonymous_users",
                Provider.Apple => "apple",
                Provider.Azure => "azure",
                Provider.Bitbucket => "bitbucket",
                Provider.Discord => "discord",
                Provider.Facebook => "facebook",
                Provider.Figma => "figma",
                Provider.Fly => "fly",
                Provider.Github => "github",
                Provider.Gitlab => "gitlab",
                Provider.Google => "google",
                Provider.Kakao => "kakao",
                Provider.KeyCloak => "keycloak",
                Provider.LinkedIn => "linkedin",
                Provider.LinkedInOIDC => "linkedin_oidc",
                Provider.Notion => "notion",
                Provider.Slack => "slack",
                Provider.Spotify => "spotify",
                Provider.Twitch => "twitch",
                Provider.Twitter => "twitter",
                Provider.WorkOS => "workos",
                Provider.Zoom => "zoom",
                _ => string.Empty,
            };
        }

        /// <summary>
        /// States that the Auth Client will raise events for.
        /// </summary>
        public enum AuthState
        {
            SignedIn,
            SignedOut,
            UserUpdated,
            PasswordRecovery,
            TokenRefreshed,
            Shutdown,
            MfaChallengeVerified,
        }

        /// <summary>
        /// Specifies the functionality expected from the `SignIn` method
        /// </summary>
        public enum SignInType
        {
            Email,
            Phone,
            RefreshToken,
        }

        /// <summary>
        /// Represents an OAuth Flow type
        /// </summary>
        public enum OAuthFlowType
        {
            Implicit,

            PKCE,
        }

        internal static string GetMappedString(this OAuthFlowType oAuthFlowType)
        {
            return oAuthFlowType switch
            {
                OAuthFlowType.Implicit => "implicit",
                OAuthFlowType.PKCE => "pkce",
                _ => string.Empty,
            };
        }

        /// <summary>
        /// Specifies the functionality expected from the `SignUp` method
        /// </summary>
        public enum SignUpType
        {
            Email,
            Phone,
        }

        public enum SignOutScope
        {
            Global,

            Local,

            Others,
        }

        internal static string GetMappedString(this SignOutScope signOutScope)
        {
            return signOutScope switch
            {
                SignOutScope.Global => "global",
                SignOutScope.Local => "local",
                SignOutScope.Others => "others",
                _ => string.Empty,
            };
        }

        internal static string GetMappedString(this GenerateLinkOptions.LinkType linkType)
        {
            return linkType switch
            {
                GenerateLinkOptions.LinkType.SignUp => "signup",
                GenerateLinkOptions.LinkType.Invite => "invite",
                GenerateLinkOptions.LinkType.MagicLink => "magiclink",
                GenerateLinkOptions.LinkType.Recovery => "recovery",
                GenerateLinkOptions.LinkType.EmailChangeCurrent => "email_change_current",
                GenerateLinkOptions.LinkType.EmailChangeNew => "email_change_new",
                _ => string.Empty,
            };
        }

        internal static string ToJson(
            this SignInWithPasswordlessPhoneOptions.MessagingChannel channel
        )
        {
            return channel switch
            {
                SignInWithPasswordlessPhoneOptions.MessagingChannel.SMS => "sms",
                SignInWithPasswordlessPhoneOptions.MessagingChannel.WHATSAPP => "whatsapp",
                _ => string.Empty,
            };
        }
    }
}
