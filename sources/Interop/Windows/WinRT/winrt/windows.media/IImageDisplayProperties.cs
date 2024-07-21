// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IImageDisplayProperties.xml' path='doc/member[@name="IImageDisplayProperties"]/*' />
[Guid("CD0BC7EF-54E7-411F-9933-F0E98B0A96D2")]
[NativeTypeName("struct IImageDisplayProperties : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IImageDisplayProperties : IImageDisplayProperties.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IImageDisplayProperties));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, Guid*, void**, int>)(lpVtbl[0]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, uint>)(lpVtbl[1]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, uint>)(lpVtbl[2]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, uint*, Guid**, int>)(lpVtbl[3]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, HSTRING*, int>)(lpVtbl[4]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, TrustLevel*, int>)(lpVtbl[5]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IImageDisplayProperties.xml' path='doc/member[@name="IImageDisplayProperties.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, HSTRING*, int>)(lpVtbl[6]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageDisplayProperties.xml' path='doc/member[@name="IImageDisplayProperties.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, HSTRING, int>)(lpVtbl[7]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageDisplayProperties.xml' path='doc/member[@name="IImageDisplayProperties.get_Subtitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Subtitle(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, HSTRING*, int>)(lpVtbl[8]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IImageDisplayProperties.xml' path='doc/member[@name="IImageDisplayProperties.put_Subtitle"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Subtitle(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<IImageDisplayProperties*, HSTRING, int>)(lpVtbl[9]))((IImageDisplayProperties*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_Subtitle(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_Subtitle(HSTRING value);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Subtitle;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Subtitle;
    }
}
