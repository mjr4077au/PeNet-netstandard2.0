#if NETSTANDARD
using System;
using System.Security.Cryptography;

/// <summary>
/// Polyfill for the IncrementalHash class to support .NET Standard 2.0 and earlier versions.
/// </summary>
internal static class IncrementalHashPolyfills
{
    /// <summary>
    /// Append data to the incremental hash computation. This method converts the ReadOnlySpan<byte> to a byte array
    /// to maintain compatibility with .NET Standard 2.0 and earlier versions.
    /// </summary>
    /// <param name="incrementalHash">The IncrementalHash object to update.</param>
    /// <param name="data">The data to append to the hash computation.</param>
    internal static void AppendData(this IncrementalHash incrementalHash, ReadOnlySpan<byte> data)
    {
        incrementalHash.AppendData(data.ToArray());
    }
}
#endif
