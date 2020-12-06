// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FF24BEEE-DA21-4BEB-98B5-D2F899F98AF9")]
    [NativeTypeName("struct IDirect3DAuthenticatedChannel9 : IUnknown")]
    public unsafe partial struct IDirect3DAuthenticatedChannel9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[1]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint>)(lpVtbl[2]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint*, int>)(lpVtbl[3]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertifacteSize, [NativeTypeName("BYTE *")] byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateKeyExchange([NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Query([NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("UINT")] uint OutputSize, [NativeTypeName("void *")] void* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, uint, void*, int>)(lpVtbl[6]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, OutputSize, pOutput);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Configure([NativeTypeName("UINT")] uint InputSize, [NativeTypeName("const void *")] void* pInput, [NativeTypeName("D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT *")] D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT* pOutput)
        {
            return ((delegate* unmanaged<IDirect3DAuthenticatedChannel9*, uint, void*, D3DAUTHENTICATEDCHANNEL_CONFIGURE_OUTPUT*, int>)(lpVtbl[7]))((IDirect3DAuthenticatedChannel9*)Unsafe.AsPointer(ref this), InputSize, pInput, pOutput);
        }
    }
}
