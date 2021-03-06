// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("C26F23A8-EE10-4AD6-B898-2B4D7AEBFE6A")]
    [NativeTypeName("struct IAppxManifestHostRuntimeDependency2 : IUnknown")]
    public unsafe partial struct IAppxManifestHostRuntimeDependency2
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxManifestHostRuntimeDependency2*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency2*, uint>)(lpVtbl[1]))((IAppxManifestHostRuntimeDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency2*, uint>)(lpVtbl[2]))((IAppxManifestHostRuntimeDependency2*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetPackageFamilyName([NativeTypeName("LPWSTR *")] ushort** packageFamilyName)
        {
            return ((delegate* unmanaged<IAppxManifestHostRuntimeDependency2*, ushort**, int>)(lpVtbl[3]))((IAppxManifestHostRuntimeDependency2*)Unsafe.AsPointer(ref this), packageFamilyName);
        }
    }
}
