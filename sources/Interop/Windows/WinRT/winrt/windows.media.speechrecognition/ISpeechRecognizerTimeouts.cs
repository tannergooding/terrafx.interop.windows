// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.speechrecognition.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts"]/*' />
[Guid("2EF76FCA-6A3C-4DCA-A153-DF1BC88A79AF")]
[NativeTypeName("struct ISpeechRecognizerTimeouts : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpeechRecognizerTimeouts : ISpeechRecognizerTimeouts.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechRecognizerTimeouts));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, Guid*, void**, int>)(lpVtbl[0]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, uint>)(lpVtbl[1]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, uint>)(lpVtbl[2]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, uint*, Guid**, int>)(lpVtbl[3]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, HSTRING*, int>)(lpVtbl[4]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TrustLevel*, int>)(lpVtbl[5]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.get_InitialSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_InitialSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan*, int>)(lpVtbl[6]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.put_InitialSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_InitialSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan, int>)(lpVtbl[7]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.get_EndSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_EndSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan*, int>)(lpVtbl[8]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.put_EndSilenceTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_EndSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan, int>)(lpVtbl[9]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.get_BabbleTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_BabbleTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan*, int>)(lpVtbl[10]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ISpeechRecognizerTimeouts.xml' path='doc/member[@name="ISpeechRecognizerTimeouts.put_BabbleTimeout"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_BabbleTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value)
    {
        return ((delegate* unmanaged[MemberFunction]<ISpeechRecognizerTimeouts*, TimeSpan, int>)(lpVtbl[11]))((ISpeechRecognizerTimeouts*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_InitialSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(7)]
        HRESULT put_InitialSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(8)]
        HRESULT get_EndSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(9)]
        HRESULT put_EndSilenceTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);

        [VtblIndex(10)]
        HRESULT get_BabbleTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value);

        [VtblIndex(11)]
        HRESULT put_BabbleTimeout([NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_InitialSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_InitialSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_EndSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_EndSilenceTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan*, int> get_BabbleTimeout;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, TimeSpan, int> put_BabbleTimeout;
    }
}
