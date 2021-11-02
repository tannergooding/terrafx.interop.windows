// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASERULEHANDLE : IComparable, IComparable<SPPHRASERULEHANDLE>, IEquatable<SPPHRASERULEHANDLE>, IFormattable
    {
        public readonly void* Value;

        public SPPHRASERULEHANDLE(void* value)
        {
            Value = value;
        }

        public static SPPHRASERULEHANDLE INVALID_VALUE => new SPPHRASERULEHANDLE((void*)(-1));

        public static SPPHRASERULEHANDLE NULL => new SPPHRASERULEHANDLE(null);

        public static bool operator ==(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPPHRASERULEHANDLE(void* value) => new SPPHRASERULEHANDLE(value);

        public static implicit operator void*(SPPHRASERULEHANDLE value) => value.Value;

        public static explicit operator SPPHRASERULEHANDLE(HANDLE value) => new SPPHRASERULEHANDLE(value);

        public static implicit operator HANDLE(SPPHRASERULEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(byte value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator byte(SPPHRASERULEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(short value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator short(SPPHRASERULEHANDLE value) => (short)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(int value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator int(SPPHRASERULEHANDLE value) => (int)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(long value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator long(SPPHRASERULEHANDLE value) => (long)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(nint value) => new SPPHRASERULEHANDLE((void*)(value));

        public static implicit operator nint(SPPHRASERULEHANDLE value) => (nint)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(sbyte value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator sbyte(SPPHRASERULEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(ushort value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator ushort(SPPHRASERULEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(uint value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator uint(SPPHRASERULEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(ulong value) => new SPPHRASERULEHANDLE((void*)(value));

        public static explicit operator ulong(SPPHRASERULEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(nuint value) => new SPPHRASERULEHANDLE((void*)(value));

        public static implicit operator nuint(SPPHRASERULEHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPPHRASERULEHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPPHRASERULEHANDLE.");
        }

        public int CompareTo(SPPHRASERULEHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPPHRASERULEHANDLE other) && Equals(other);

        public bool Equals(SPPHRASERULEHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
