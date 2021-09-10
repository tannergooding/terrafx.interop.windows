// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A6B43F84-5C0A-42E8-A44D-B1857A76992F")]
    [NativeTypeName("struct IMFByteStreamProxyClassFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IMFByteStreamProxyClassFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, Guid*, void**, int>)(lpVtbl[0]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[1]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, uint>)(lpVtbl[2]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateByteStreamProxy(IMFByteStream* pByteStream, IMFAttributes* pAttributes, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject)
        {
            return ((delegate* unmanaged<IMFByteStreamProxyClassFactory*, IMFByteStream*, IMFAttributes*, Guid*, void**, int>)(lpVtbl[3]))((IMFByteStreamProxyClassFactory*)Unsafe.AsPointer(ref this), pByteStream, pAttributes, riid, ppvObject);
        }
    }
}
