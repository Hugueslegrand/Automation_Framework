
namespace Automation_Framework.Models
{
    /// <summary>
    /// NativeMobileDriverConfiguration Model
    /// </summary>
    public class NativeMobileDriverConfiguration
    {
        /// <summary>
        /// Wait time in seconds from config file
        /// </summary>
        public int DefaultTimeout { get; set; }
        /// <summary>
        /// Name of the Automation to be used from config file
        /// </summary>
        public string? AutomationName { get; set; }
        /// <summary>
        /// Name of the Platform to run the tests from config file
        /// </summary>
        public string? PlatformName { get; set; }
        /// <summary>
        /// Name of the device to be used from config file
        /// </summary>
        public string? DeviceName { get; set; }
        /// <summary>
        /// path to the apk or ipa files
        /// </summary>
        public string? App { get; set; }

    }
}
