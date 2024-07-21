// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.data.text.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISelectableWordSegmentsTokenizingHandler.xml' path='doc/member[@name="ISelectableWordSegmentsTokenizingHandler"]/*' />
[Guid("3A3DFC9C-AEDE-4DC7-9E6C-41C044BD3592")]
[NativeTypeName("struct ISelectableWordSegmentsTokenizingHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISelectableWordSegmentsTokenizingHandler : ISelectableWordSegmentsTokenizingHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISelectableWordSegmentsTokenizingHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordSegmentsTokenizingHandler*, Guid*, void**, int>)(lpVtbl[0]))((ISelectableWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordSegmentsTokenizingHandler*, uint>)(lpVtbl[1]))((ISelectableWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordSegmentsTokenizingHandler*, uint>)(lpVtbl[2]))((ISelectableWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISelectableWordSegmentsTokenizingHandler.xml' path='doc/member[@name="ISelectableWordSegmentsTokenizingHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *")] IIterable<Pointer<ISelectableWordSegment>>* precedingWords, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *")] IIterable<Pointer<ISelectableWordSegment>>* words)
    {
        return ((delegate* unmanaged[MemberFunction]<ISelectableWordSegmentsTokenizingHandler*, IIterable<Pointer<ISelectableWordSegment>>*, IIterable<Pointer<ISelectableWordSegment>>*, int>)(lpVtbl[3]))((ISelectableWordSegmentsTokenizingHandler*)Unsafe.AsPointer(ref this), precedingWords, words);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *")] IIterable<Pointer<ISelectableWordSegment>>* precedingWords, [NativeTypeName("ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *")] IIterable<Pointer<ISelectableWordSegment>>* words);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *, ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CData__CText__CSelectableWordSegment_t *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IIterable<Pointer<ISelectableWordSegment>>*, IIterable<Pointer<ISelectableWordSegment>>*, int> Invoke;
    }
}
