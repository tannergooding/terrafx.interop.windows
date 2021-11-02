// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HANDLE_PTR : IEquatable<HANDLE_PTR>
    {
        public readonly nuint Value;

        public HANDLE_PTR(nuint value)
        {
            Value = value;
        }

        public static HANDLE_PTR NULL => new HANDLE_PTR(0);

        public static bool operator ==(HANDLE_PTR left, HANDLE_PTR right) => left.Value == right.Value;

        public static bool operator !=(HANDLE_PTR left, HANDLE_PTR right) => left.Value != right.Value;

        public static explicit operator HANDLE_PTR(void* value) => new HANDLE_PTR((nuint)(value));

        public static implicit operator void*(HANDLE_PTR value) => (void*)(value.Value);

        public static explicit operator HANDLE_PTR(byte value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator byte(HANDLE_PTR value) => (byte)(value.Value);

        public static explicit operator HANDLE_PTR(short value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator short(HANDLE_PTR value) => (short)(value.Value);

        public static explicit operator HANDLE_PTR(int value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator int(HANDLE_PTR value) => (int)(value.Value);

        public static explicit operator HANDLE_PTR(long value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator long(HANDLE_PTR value) => (long)(value.Value);

        public static explicit operator HANDLE_PTR(nint value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator nint(HANDLE_PTR value) => (nint)(value.Value);

        public static explicit operator HANDLE_PTR(sbyte value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator sbyte(HANDLE_PTR value) => (sbyte)(value.Value);

        public static explicit operator HANDLE_PTR(ushort value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator ushort(HANDLE_PTR value) => (ushort)(value.Value);

        public static explicit operator HANDLE_PTR(uint value) => new HANDLE_PTR((nuint)(value));

        public static explicit operator uint(HANDLE_PTR value) => (uint)(value.Value);

        public static explicit operator HANDLE_PTR(ulong value) => new HANDLE_PTR((nuint)(value));

        public static implicit operator ulong(HANDLE_PTR value) => (ulong)(value.Value);

        public static explicit operator HANDLE_PTR(nuint value) => new HANDLE_PTR((nuint)(value));

        public static implicit operator nuint(HANDLE_PTR value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HANDLE_PTR other) && Equals(other);

        public bool Equals(HANDLE_PTR other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
