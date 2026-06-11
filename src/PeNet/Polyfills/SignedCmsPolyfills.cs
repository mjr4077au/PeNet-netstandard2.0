#if NETSTANDARD
using System;
using System.Security.Cryptography.Pkcs;

/// <summary>
/// Polyfill for the SignedCms class to support .NET Standard 2.0 and earlier versions.
/// </summary>
internal static class SignedCmsPolyfills
{
    /// <summary>
    /// Decode the encoded message and populate the SignedCms object with the decoded content.
    /// </summary>
    /// <param name="signedCms">The SignedCms object to populate.</param>
    /// <param name="encodedMessage">The encoded message to decode.</param>
    internal static void Decode(this SignedCms signedCms, ReadOnlySpan<byte> encodedMessage)
    {
        signedCms.Decode(encodedMessage.ToArray());
    }
}
#endif
