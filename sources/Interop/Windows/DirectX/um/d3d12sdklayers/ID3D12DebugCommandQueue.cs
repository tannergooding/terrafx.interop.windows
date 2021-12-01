// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

[Guid("09E0BF36-54AC-484F-8847-4BAEEAB6053A")]
[NativeTypeName("struct ID3D12DebugCommandQueue : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ID3D12DebugCommandQueue : ID3D12DebugCommandQueue.Interface
{
    public void** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue*, Guid*, void**, int>)(lpVtbl[0]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue*, uint>)(lpVtbl[1]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue*, uint>)(lpVtbl[2]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this));
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public BOOL AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State)
    {
        return ((delegate* unmanaged<ID3D12DebugCommandQueue*, ID3D12Resource*, uint, uint, int>)(lpVtbl[3]))((ID3D12DebugCommandQueue*)Unsafe.AsPointer(ref this), pResource, Subresource, State);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        BOOL AssertResourceState(ID3D12Resource* pResource, uint Subresource, uint State);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("BOOL (ID3D12Resource *, UINT, UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D12Resource*, uint, uint, int> AssertResourceState;
    }
}