namespace Supabase.Gotrue.Mfa
{
    /// <summary>
    ///
    /// </summary>
    public class AmrEntry
    {
        /// <summary>
        /// Authentication method name.
        /// </summary>
        public string Method { get; set; } = string.Empty;

        /// <summary>
        /// Timestamp when the method was successfully used. Represents number of
        /// seconds since 1st January 1970 (UNIX epoch) in UTC.
        /// </summary>
        public long Timestamp { get; set; }
    }
}
