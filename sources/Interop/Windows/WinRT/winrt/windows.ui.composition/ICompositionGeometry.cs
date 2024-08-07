// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.composition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry"]/*' />
[Guid("E985217C-6A17-4207-ABD8-5FD3DD612A9D")]
[NativeTypeName("struct ICompositionGeometry : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICompositionGeometry : ICompositionGeometry.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGeometry));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, Guid*, void**, int>)(lpVtbl[0]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, uint>)(lpVtbl[1]))((ICompositionGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, uint>)(lpVtbl[2]))((ICompositionGeometry*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, uint*, Guid**, int>)(lpVtbl[3]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, HSTRING*, int>)(lpVtbl[4]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, TrustLevel*, int>)(lpVtbl[5]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.get_TrimEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TrimEnd(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float*, int>)(lpVtbl[6]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.put_TrimEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_TrimEnd(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float, int>)(lpVtbl[7]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.get_TrimOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_TrimOffset(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float*, int>)(lpVtbl[8]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.put_TrimOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_TrimOffset(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float, int>)(lpVtbl[9]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.get_TrimStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_TrimStart(float* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float*, int>)(lpVtbl[10]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICompositionGeometry.xml' path='doc/member[@name="ICompositionGeometry.put_TrimStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_TrimStart(float value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICompositionGeometry*, float, int>)(lpVtbl[11]))((ICompositionGeometry*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TrimEnd(float* value);

        [VtblIndex(7)]
        HRESULT put_TrimEnd(float value);

        [VtblIndex(8)]
        HRESULT get_TrimOffset(float* value);

        [VtblIndex(9)]
        HRESULT put_TrimOffset(float value);

        [VtblIndex(10)]
        HRESULT get_TrimStart(float* value);

        [VtblIndex(11)]
        HRESULT put_TrimStart(float value);
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

        [NativeTypeName("HRESULT (ULONG *, IID **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, Guid**, int> GetIids;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> GetRuntimeClassName;

        [NativeTypeName("HRESULT (TrustLevel *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TrustLevel*, int> GetTrustLevel;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TrimEnd;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TrimEnd;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TrimOffset;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TrimOffset;

        [NativeTypeName("HRESULT (FLOAT *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float*, int> get_TrimStart;

        [NativeTypeName("HRESULT (FLOAT) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, float, int> put_TrimStart;
    }
}
