// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/audiopolicy.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IAudioVolumeDuckNotification.xml' path='doc/member[@name="IAudioVolumeDuckNotification"]/*' />
[Guid("C3B284D4-6D39-4359-B3CF-B56DDB3BB39C")]
[NativeTypeName("struct IAudioVolumeDuckNotification : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAudioVolumeDuckNotification : IAudioVolumeDuckNotification.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAudioVolumeDuckNotification));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioVolumeDuckNotification*, Guid*, void**, int>)(lpVtbl[0]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioVolumeDuckNotification*, uint>)(lpVtbl[1]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioVolumeDuckNotification*, uint>)(lpVtbl[2]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAudioVolumeDuckNotification.xml' path='doc/member[@name="IAudioVolumeDuckNotification.OnVolumeDuckNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT OnVolumeDuckNotification([NativeTypeName("LPCWSTR")] char* sessionID, [NativeTypeName("UINT32")] uint countCommunicationSessions)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioVolumeDuckNotification*, char*, uint, int>)(lpVtbl[3]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID, countCommunicationSessions);
    }

    /// <include file='IAudioVolumeDuckNotification.xml' path='doc/member[@name="IAudioVolumeDuckNotification.OnVolumeUnduckNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] char* sessionID)
    {
        return ((delegate* unmanaged[MemberFunction]<IAudioVolumeDuckNotification*, char*, int>)(lpVtbl[4]))((IAudioVolumeDuckNotification*)Unsafe.AsPointer(ref this), sessionID);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT OnVolumeDuckNotification([NativeTypeName("LPCWSTR")] char* sessionID, [NativeTypeName("UINT32")] uint countCommunicationSessions);

        [VtblIndex(4)]
        HRESULT OnVolumeUnduckNotification([NativeTypeName("LPCWSTR")] char* sessionID);
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

        [NativeTypeName("HRESULT (LPCWSTR, UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, uint, int> OnVolumeDuckNotification;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, int> OnVolumeUnduckNotification;
    }
}
