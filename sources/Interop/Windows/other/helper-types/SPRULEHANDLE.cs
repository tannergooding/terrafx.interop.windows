// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPRULEHANDLE : IComparable, IComparable<SPRULEHANDLE>, IEquatable<SPRULEHANDLE>, IFormattable
    {
        public readonly void* Value;

        public SPRULEHANDLE(void* value)
        {
            Value = value;
        }

        public static SPRULEHANDLE INVALID_VALUE => new SPRULEHANDLE((void*)(-1));

        public static SPRULEHANDLE NULL => new SPRULEHANDLE(null);

        public static bool operator ==(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPRULEHANDLE left, SPRULEHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPRULEHANDLE(void* value) => new SPRULEHANDLE(value);

        public static implicit operator void*(SPRULEHANDLE value) => value.Value;

        public static explicit operator SPRULEHANDLE(HANDLE value) => new SPRULEHANDLE(value);

        public static implicit operator HANDLE(SPRULEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPRULEHANDLE(byte value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator byte(SPRULEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPRULEHANDLE(short value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator short(SPRULEHANDLE value) => (short)(value.Value);

        public static explicit operator SPRULEHANDLE(int value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator int(SPRULEHANDLE value) => (int)(value.Value);

        public static explicit operator SPRULEHANDLE(long value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator long(SPRULEHANDLE value) => (long)(value.Value);

        public static explicit operator SPRULEHANDLE(nint value) => new SPRULEHANDLE((void*)(value));

        public static implicit operator nint(SPRULEHANDLE value) => (nint)(value.Value);

        public static explicit operator SPRULEHANDLE(sbyte value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator sbyte(SPRULEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPRULEHANDLE(ushort value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator ushort(SPRULEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPRULEHANDLE(uint value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator uint(SPRULEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPRULEHANDLE(ulong value) => new SPRULEHANDLE((void*)(value));

        public static explicit operator ulong(SPRULEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPRULEHANDLE(nuint value) => new SPRULEHANDLE((void*)(value));

        public static implicit operator nuint(SPRULEHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPRULEHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPRULEHANDLE.");
        }

        public int CompareTo(SPRULEHANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is SPRULEHANDLE other) && Equals(other);

        public bool Equals(SPRULEHANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
