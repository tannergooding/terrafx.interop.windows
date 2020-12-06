// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("DD13C59C-36FA-4098-A8FB-C7ED39DC8546")]
    [NativeTypeName("struct IDirect3DVertexDeclaration9 : IUnknown")]
    public unsafe partial struct IDirect3DVertexDeclaration9
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, Guid*, void**, int>)(lpVtbl[0]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, uint>)(lpVtbl[1]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, uint>)(lpVtbl[2]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDevice([NativeTypeName("IDirect3DDevice9 **")] IDirect3DDevice9** ppDevice)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, IDirect3DDevice9**, int>)(lpVtbl[3]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), ppDevice);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDeclaration([NativeTypeName("D3DVERTEXELEMENT9 *")] D3DVERTEXELEMENT9* pElement, [NativeTypeName("UINT *")] uint* pNumElements)
        {
            return ((delegate* unmanaged<IDirect3DVertexDeclaration9*, D3DVERTEXELEMENT9*, uint*, int>)(lpVtbl[4]))((IDirect3DVertexDeclaration9*)Unsafe.AsPointer(ref this), pElement, pNumElements);
        }
    }
}
