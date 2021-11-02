// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct LPARAM : IEquatable<LPARAM>
    {
        public readonly nint Value;

        public LPARAM(nint value)
        {
            Value = value;
        }

        public static bool operator ==(LPARAM left, LPARAM right) => left.Value == right.Value;

        public static bool operator !=(LPARAM left, LPARAM right) => left.Value != right.Value;

        public static implicit operator LPARAM(byte value) => new LPARAM((nint)(value));

        public static explicit operator byte(LPARAM value) => (byte)(value.Value);

        public static implicit operator LPARAM(short value) => new LPARAM((nint)(value));

        public static explicit operator short(LPARAM value) => (short)(value.Value);

        public static implicit operator LPARAM(int value) => new LPARAM((nint)(value));

        public static explicit operator int(LPARAM value) => (int)(value.Value);

        public static explicit operator LPARAM(long value) => new LPARAM((nint)(value));

        public static implicit operator long(LPARAM value) => (long)(value.Value);

        public static implicit operator LPARAM(nint value) => new LPARAM((nint)(value));

        public static implicit operator nint(LPARAM value) => (nint)(value.Value);

        public static implicit operator LPARAM(sbyte value) => new LPARAM((nint)(value));

        public static explicit operator sbyte(LPARAM value) => (sbyte)(value.Value);

        public static implicit operator LPARAM(ushort value) => new LPARAM((nint)(value));

        public static explicit operator ushort(LPARAM value) => (ushort)(value.Value);

        public static implicit operator LPARAM(uint value) => new LPARAM((nint)(value));

        public static explicit operator uint(LPARAM value) => (uint)(value.Value);

        public static explicit operator LPARAM(ulong value) => new LPARAM((nint)(value));

        public static explicit operator ulong(LPARAM value) => (ulong)(value.Value);

        public static explicit operator LPARAM(nuint value) => new LPARAM((nint)(value));

        public static explicit operator nuint(LPARAM value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is LPARAM other) && Equals(other);

        public bool Equals(LPARAM other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
