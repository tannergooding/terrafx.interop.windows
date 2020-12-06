// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26DC4561-A1EE-4AE7-96DA-118A36C0EC95")]
    [NativeTypeName("struct IDirect3DDevice9Video : IUnknown")]
    public unsafe partial struct IDirect3DDevice9Video
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, uint>)(lpVtbl[1]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, uint>)(lpVtbl[2]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetContentProtectionCaps([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, [NativeTypeName("D3DCONTENTPROTECTIONCAPS *")] D3DCONTENTPROTECTIONCAPS* pCaps)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, D3DCONTENTPROTECTIONCAPS*, int>)(lpVtbl[3]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, pCaps);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateAuthenticatedChannel(D3DAUTHENTICATEDCHANNELTYPE ChannelType, [NativeTypeName("IDirect3DAuthenticatedChannel9 **")] IDirect3DAuthenticatedChannel9** ppAuthenticatedChannel, [NativeTypeName("HANDLE *")] IntPtr* pChannelHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, D3DAUTHENTICATEDCHANNELTYPE, IDirect3DAuthenticatedChannel9**, IntPtr*, int>)(lpVtbl[4]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), ChannelType, ppAuthenticatedChannel, pChannelHandle);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCryptoSession([NativeTypeName("const GUID *")] Guid* pCryptoType, [NativeTypeName("const GUID *")] Guid* pDecodeProfile, [NativeTypeName("IDirect3DCryptoSession9 **")] IDirect3DCryptoSession9** ppCryptoSession, [NativeTypeName("HANDLE *")] IntPtr* pCryptoHandle)
        {
            return ((delegate* unmanaged<IDirect3DDevice9Video*, Guid*, Guid*, IDirect3DCryptoSession9**, IntPtr*, int>)(lpVtbl[5]))((IDirect3DDevice9Video*)Unsafe.AsPointer(ref this), pCryptoType, pDecodeProfile, ppCryptoSession, pCryptoHandle);
        }
    }
}
