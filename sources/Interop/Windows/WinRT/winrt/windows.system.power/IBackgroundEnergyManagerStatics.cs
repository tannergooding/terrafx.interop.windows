// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.system.power.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics"]/*' />
[Guid("B3161D95-1180-4376-96E1-4095568147CE")]
[NativeTypeName("struct IBackgroundEnergyManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
public unsafe partial struct IBackgroundEnergyManagerStatics : IBackgroundEnergyManagerStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundEnergyManagerStatics));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, Guid*, void**, int>)(lpVtbl[0]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint>)(lpVtbl[1]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint>)(lpVtbl[2]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, Guid**, int>)(lpVtbl[3]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, HSTRING*, int>)(lpVtbl[4]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, TrustLevel*, int>)(lpVtbl[5]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_LowUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_LowUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[6]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_NearMaxAcceptableUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_NearMaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[7]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_MaxAcceptableUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_MaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[8]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_ExcessiveUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_ExcessiveUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[9]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_NearTerminationUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_NearTerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[10]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_TerminationUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_TerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[11]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_RecentEnergyUsage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_RecentEnergyUsage([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[12]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.get_RecentEnergyUsageLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT get_RecentEnergyUsageLevel([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, uint*, int>)(lpVtbl[13]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.add_RecentEnergyUsageIncreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT add_RecentEnergyUsageIncreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[14]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.remove_RecentEnergyUsageIncreased"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT remove_RecentEnergyUsageIncreased(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, EventRegistrationToken, int>)(lpVtbl[15]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.add_RecentEnergyUsageReturnedToLow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT add_RecentEnergyUsageReturnedToLow([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int>)(lpVtbl[16]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), handler, token);
    }

    /// <include file='IBackgroundEnergyManagerStatics.xml' path='doc/member[@name="IBackgroundEnergyManagerStatics.remove_RecentEnergyUsageReturnedToLow"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
    public HRESULT remove_RecentEnergyUsageReturnedToLow(EventRegistrationToken token)
    {
        return ((delegate* unmanaged[MemberFunction]<IBackgroundEnergyManagerStatics*, EventRegistrationToken, int>)(lpVtbl[17]))((IBackgroundEnergyManagerStatics*)Unsafe.AsPointer(ref this), token);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_LowUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(7)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_NearMaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(8)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_MaxAcceptableUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(9)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_ExcessiveUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(10)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_NearTerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_TerminationUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(12)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_RecentEnergyUsage([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(13)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT get_RecentEnergyUsageLevel([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(14)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT add_RecentEnergyUsageIncreased([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(15)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT remove_RecentEnergyUsageIncreased(EventRegistrationToken token);

        [VtblIndex(16)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT add_RecentEnergyUsageReturnedToLow([NativeTypeName("ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *")] IEventHandler<Pointer<IInspectable>>* handler, EventRegistrationToken* token);

        [VtblIndex(17)]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        HRESULT remove_RecentEnergyUsageReturnedToLow(EventRegistrationToken token);
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

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_LowUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_NearMaxAcceptableUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_MaxAcceptableUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_ExcessiveUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_NearTerminationUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_TerminationUsageLevel;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_RecentEnergyUsage;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_RecentEnergyUsageLevel;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_RecentEnergyUsageIncreased;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RecentEnergyUsageIncreased;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIEventHandler_1_IInspectable_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IEventHandler<Pointer<IInspectable>>*, EventRegistrationToken*, int> add_RecentEnergyUsageReturnedToLow;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        [Obsolete("Background Energy Manager has been deprecated. For more info, see MSDN.")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_RecentEnergyUsageReturnedToLow;
    }
}
