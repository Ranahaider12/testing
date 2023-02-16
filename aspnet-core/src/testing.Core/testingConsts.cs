using testing.Debugging;

namespace testing
{
    public class testingConsts
    {
        public const string LocalizationSourceName = "testing";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "153fbe14b53a457899059c71921be36e";
    }
}
