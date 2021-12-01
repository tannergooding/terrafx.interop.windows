// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct SP_REGISTER_CONTROL_STATUSA
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(SP_REGISTER_CONTROL_STATUS32A));
            }
            else
            {
                return (uint)(sizeof(SP_REGISTER_CONTROL_STATUS64A));
            }
        }
    }

    [FieldOffset(0)]
    public SP_REGISTER_CONTROL_STATUS32A _value32;

    [FieldOffset(0)]
    public SP_REGISTER_CONTROL_STATUS64A _value64;

    [NativeTypeName("DWORD")]
    public ref uint cbSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
            }
        }
    }

    [NativeTypeName("PCSTR")]
    public ref sbyte* FileName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).FileName;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).FileName;
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint Win32Error
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.Win32Error, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.Win32Error, 1));
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint FailureCode
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FailureCode, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FailureCode, 1));
            }
        }
    }
}