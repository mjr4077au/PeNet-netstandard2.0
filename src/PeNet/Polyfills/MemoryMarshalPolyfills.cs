#if NETSTANDARD
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

/// <summary>
/// Polyfill for the MemoryMarshal class to support .NET Standard 2.0 and earlier versions.
/// </summary>
internal static class MemoryMarshalPolyfills
{
    /// <summary>
    /// Polyfill for the MemoryMarshal class to support .NET Standard 2.0 and earlier versions.
    /// </summary>
    extension(MemoryMarshal)
    {
        /// <summary>
        /// Writes a value of type <typeparamref name="T"/> to the beginning of a <see cref="Span{Byte}"/>.
        /// </summary>
        /// <typeparam name="T">The type of the value to write.</typeparam>
        /// <param name="destination">The span to write the value to.</param>
        /// <param name="value">The value to write.</param>
        public static void Write<T>(Span<byte> destination, in T value) where T : struct
        {
            MemoryMarshal.Write(destination, ref Unsafe.AsRef(value));
        }
    }
}
#endif
