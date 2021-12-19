// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct FILE_IN_CABINET_INFO_A
{
    public static uint SizeOf
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return (uint)(sizeof(FILE_IN_CABINET_INFO32_A));
            }
            else
            {
                return (uint)(sizeof(FILE_IN_CABINET_INFO64_A));
            }
        }
    }

    [FieldOffset(0)]
    public FILE_IN_CABINET_INFO32_A _value32;

    [FieldOffset(0)]
    public FILE_IN_CABINET_INFO64_A _value64;

    [NativeTypeName("PCSTR")]
    public ref sbyte* NameInCabinet
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).NameInCabinet;
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).NameInCabinet;
            }
        }
    }

    [NativeTypeName("DWORD")]
    public ref uint FileSize
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.FileSize, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.FileSize, 1));
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

    [NativeTypeName("WORD")]
    public ref ushort DosDate
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DosDate, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DosDate, 1));
            }
        }
    }

    [NativeTypeName("WORD")]
    public ref ushort DosTime
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DosTime, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DosTime, 1));
            }
        }
    }

    [NativeTypeName("WORD")]
    public ref ushort DosAttribs
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.DosAttribs, 1));
            }
            else
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.DosAttribs, 1));
            }
        }
    }

    [NativeTypeName("CHAR [260]")]
    public Span<sbyte> FullTargetName
    {
        get
        {
            if (sizeof(nint) == 4)
            {
                return MemoryMarshal.CreateSpan(ref _value32.FullTargetName[0], 1);
            }
            else
            {
                return MemoryMarshal.CreateSpan(ref _value64.FullTargetName[0], 1);
            }
        }
    }
}
