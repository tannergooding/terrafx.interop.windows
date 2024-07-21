// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.capture.frames.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IMediaFrameSourceGroup.xml' path='doc/member[@name="IMediaFrameSourceGroup"]/*' />
[Guid("7F605B87-4832-4B5F-AE3D-412FAAB37D34")]
[NativeTypeName("struct IMediaFrameSourceGroup : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMediaFrameSourceGroup : IMediaFrameSourceGroup.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMediaFrameSourceGroup));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, Guid*, void**, int>)(lpVtbl[0]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, uint>)(lpVtbl[1]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, uint>)(lpVtbl[2]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, uint*, Guid**, int>)(lpVtbl[3]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, HSTRING*, int>)(lpVtbl[4]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, TrustLevel*, int>)(lpVtbl[5]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IMediaFrameSourceGroup.xml' path='doc/member[@name="IMediaFrameSourceGroup.get_Id"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, HSTRING*, int>)(lpVtbl[6]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceGroup.xml' path='doc/member[@name="IMediaFrameSourceGroup.get_DisplayName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, HSTRING*, int>)(lpVtbl[7]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IMediaFrameSourceGroup.xml' path='doc/member[@name="IMediaFrameSourceGroup.get_SourceInfos"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SourceInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceInfo_t **")] IVectorView<Pointer<IMediaFrameSourceInfo>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<IMediaFrameSourceGroup*, IVectorView<Pointer<IMediaFrameSourceInfo>>**, int>)(lpVtbl[8]))((IMediaFrameSourceGroup*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_SourceInfos([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceInfo_t **")] IVectorView<Pointer<IMediaFrameSourceInfo>>** value);
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CMedia__CCapture__CFrames__CMediaFrameSourceInfo_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<IMediaFrameSourceInfo>>**, int> get_SourceInfos;
    }
}
