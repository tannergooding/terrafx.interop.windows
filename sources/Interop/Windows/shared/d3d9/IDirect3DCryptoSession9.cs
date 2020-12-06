// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("FA0AB799-7A9C-48CA-8C5B-237E71A54434")]
    [NativeTypeName("struct IDirect3DCryptoSession9 : IUnknown")]
    public unsafe partial struct IDirect3DCryptoSession9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint>)(lpVtbl[1]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint>)(lpVtbl[2]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificateSize([NativeTypeName("UINT *")] uint* pCertificateSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint*, int>)(lpVtbl[3]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pCertificateSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetCertificate([NativeTypeName("UINT")] uint CertifacteSize, [NativeTypeName("BYTE *")] byte* ppCertificate)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, byte*, int>)(lpVtbl[4]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), CertifacteSize, ppCertificate);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int NegotiateKeyExchange([NativeTypeName("UINT")] uint DataSize, [NativeTypeName("void *")] void* pData)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, uint, void*, int>)(lpVtbl[5]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), DataSize, pData);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int EncryptionBlt([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSrcSurface, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDstSurface, [NativeTypeName("UINT")] uint DstSurfaceSize, [NativeTypeName("void *")] void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, void*, int>)(lpVtbl[6]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, DstSurfaceSize, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int DecryptionBlt([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSrcSurface, [NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pDstSurface, [NativeTypeName("UINT")] uint SrcSurfaceSize, [NativeTypeName("D3DENCRYPTED_BLOCK_INFO *")] D3DENCRYPTED_BLOCK_INFO* pEncryptedBlockInfo, [NativeTypeName("void *")] void* pContentKey, [NativeTypeName("void *")] void* pIV)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, IDirect3DSurface9*, uint, D3DENCRYPTED_BLOCK_INFO*, void*, void*, int>)(lpVtbl[7]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pDstSurface, SrcSurfaceSize, pEncryptedBlockInfo, pContentKey, pIV);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetSurfacePitch([NativeTypeName("IDirect3DSurface9 *")] IDirect3DSurface9* pSrcSurface, [NativeTypeName("UINT *")] uint* pSurfacePitch)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, IDirect3DSurface9*, uint*, int>)(lpVtbl[8]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pSrcSurface, pSurfacePitch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int StartSessionKeyRefresh([NativeTypeName("void *")] void* pRandomNumber, [NativeTypeName("UINT")] uint RandomNumberSize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[9]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pRandomNumber, RandomNumberSize);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int FinishSessionKeyRefresh()
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, int>)(lpVtbl[10]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetEncryptionBltKey([NativeTypeName("void *")] void* pReadbackKey, [NativeTypeName("UINT")] uint KeySize)
        {
            return ((delegate* unmanaged<IDirect3DCryptoSession9*, void*, uint, int>)(lpVtbl[11]))((IDirect3DCryptoSession9*)Unsafe.AsPointer(ref this), pReadbackKey, KeySize);
        }
    }
}
