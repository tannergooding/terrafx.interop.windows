// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IShellItemImageFactory.xml' path='doc/member[@name="IShellItemImageFactory"]/*' />
[Guid("BCC18B79-BA16-442F-80C4-8A59C30C463B")]
[NativeTypeName("struct IShellItemImageFactory : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellItemImageFactory : IShellItemImageFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellItemImageFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellItemImageFactory*, Guid*, void**, int>)(lpVtbl[0]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellItemImageFactory*, uint>)(lpVtbl[1]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IShellItemImageFactory*, uint>)(lpVtbl[2]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellItemImageFactory.xml' path='doc/member[@name="IShellItemImageFactory.GetImage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetImage(SIZE size, [NativeTypeName("SIIGBF")] int flags, HBITMAP* phbm)
    {
        return ((delegate* unmanaged[MemberFunction]<IShellItemImageFactory*, SIZE, int, HBITMAP*, int>)(lpVtbl[3]))((IShellItemImageFactory*)Unsafe.AsPointer(ref this), size, flags, phbm);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetImage(SIZE size, [NativeTypeName("SIIGBF")] int flags, HBITMAP* phbm);
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (SIZE, SIIGBF, HBITMAP *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, SIZE, int, HBITMAP*, int> GetImage;
    }
}
