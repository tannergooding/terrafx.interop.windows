// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("00000017-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IActivationFilter : IUnknown")]
    public unsafe partial struct IActivationFilter
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IActivationFilter*, Guid*, void**, int>)(lpVtbl[0]))((IActivationFilter*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IActivationFilter*, uint>)(lpVtbl[1]))((IActivationFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IActivationFilter*, uint>)(lpVtbl[2]))((IActivationFilter*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int HandleActivation([NativeTypeName("DWORD")] uint dwActivationType, [NativeTypeName("const IID &")] Guid* rclsid, [NativeTypeName("CLSID *")] Guid* pReplacementClsId)
        {
            return ((delegate* unmanaged<IActivationFilter*, uint, Guid*, Guid*, int>)(lpVtbl[3]))((IActivationFilter*)Unsafe.AsPointer(ref this), dwActivationType, rclsid, pReplacementClsId);
        }
    }
}
