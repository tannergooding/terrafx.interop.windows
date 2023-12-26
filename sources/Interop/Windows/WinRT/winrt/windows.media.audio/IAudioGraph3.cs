// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IAudioGraph3.xml' path='doc/member[@name="IAudioGraph3"]/*' />
[Guid("DDCD25AE-1185-42A7-831D-6A9B0FC86820")]
[NativeTypeName("struct IAudioGraph3 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAudioGraph3 : IAudioGraph3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioGraph3));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, Guid*, void**, int>)(lpVtbl[0]))((IAudioGraph3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, uint>)(lpVtbl[1]))((IAudioGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, uint>)(lpVtbl[2]))((IAudioGraph3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, uint*, Guid**, int>)(lpVtbl[3]))((IAudioGraph3*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, HSTRING*, int>)(lpVtbl[4]))((IAudioGraph3*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, TrustLevel*, int>)(lpVtbl[5]))((IAudioGraph3*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IAudioGraph3.xml' path='doc/member[@name="IAudioGraph3.CreateMediaSourceAudioInputNodeAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateMediaSourceAudioInputNodeAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, IMediaSource2*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[6]))((IAudioGraph3*)Unsafe.AsPointer(ref this), mediaSource, operation);
    }

    /// <include file='IAudioGraph3.xml' path='doc/member[@name="IAudioGraph3.CreateMediaSourceAudioInputNodeWithEmitterAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateMediaSourceAudioInputNodeWithEmitterAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* mediaSource, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **")] IAsyncOperation<IntPtr>** operation)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioGraph3*, IMediaSource2*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int>)(lpVtbl[7]))((IAudioGraph3*)Unsafe.AsPointer(ref this), mediaSource, emitter, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateMediaSourceAudioInputNodeAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* mediaSource, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **")] IAsyncOperation<IntPtr>** operation);

        [VtblIndex(7)]
        HRESULT CreateMediaSourceAudioInputNodeWithEmitterAsync([NativeTypeName("ABI::Windows::Media::Core::IMediaSource2 *")] IMediaSource2* mediaSource, [NativeTypeName("ABI::Windows::Media::Audio::IAudioNodeEmitter *")] IAudioNodeEmitter* emitter, [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **")] IAsyncOperation<IntPtr>** operation);
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

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2*, IAsyncOperation<IntPtr>**, int> CreateMediaSourceAudioInputNodeAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Media::Core::IMediaSource2 *, ABI::Windows::Media::Audio::IAudioNodeEmitter *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CMedia__CAudio__CCreateMediaSourceAudioInputNodeResult_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMediaSource2*, IAudioNodeEmitter*, IAsyncOperation<IntPtr>**, int> CreateMediaSourceAudioInputNodeWithEmitterAsync;
    }
}