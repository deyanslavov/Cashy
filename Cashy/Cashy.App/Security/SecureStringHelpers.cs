namespace Cashy.App
{
    using System;
    using System.Security;
    using System.Runtime.InteropServices;

    /// <summary>
    /// Helpers for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelpers
    {
        /// <summary>
        /// Unsecures a <see cref="SecureString"/> to plain text
        /// </summary>
        /// <param name="secureString">The secure string</param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            // Make sure we have a secure string
            if (secureString == null)
                return string.Empty;

            // Get a pointer for an unsecure string in memory
            IntPtr unmanagedString = IntPtr.Zero;

            try
            {
                // Unsecures the password
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                // Clean up any memory allocation
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
