// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.viewmanagement.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreInputViewOcclusionsChangedEventArgs.xml' path='doc/member[@name="ICoreInputViewOcclusionsChangedEventArgs"]/*' />
[Guid("BE1027E8-B3EE-4DF7-9554-89CDC66082C2")]
[NativeTypeName("struct ICoreInputViewOcclusionsChangedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreInputViewOcclusionsChangedEventArgs : ICoreInputViewOcclusionsChangedEventArgs.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreInputViewOcclusionsChangedEventArgs));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, Guid*, void**, int>)(lpVtbl[0]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, uint>)(lpVtbl[1]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, uint>)(lpVtbl[2]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, HSTRING*, int>)(lpVtbl[4]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, TrustLevel*, int>)(lpVtbl[5]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreInputViewOcclusionsChangedEventArgs.xml' path='doc/member[@name="ICoreInputViewOcclusionsChangedEventArgs.get_Occlusions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Occlusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<Pointer<ICoreInputViewOcclusion>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, IVectorView<Pointer<ICoreInputViewOcclusion>>**, int>)(lpVtbl[6]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewOcclusionsChangedEventArgs.xml' path='doc/member[@name="ICoreInputViewOcclusionsChangedEventArgs.get_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Handled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, byte*, int>)(lpVtbl[7]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreInputViewOcclusionsChangedEventArgs.xml' path='doc/member[@name="ICoreInputViewOcclusionsChangedEventArgs.put_Handled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_Handled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreInputViewOcclusionsChangedEventArgs*, byte, int>)(lpVtbl[8]))((ICoreInputViewOcclusionsChangedEventArgs*)Unsafe.AsPointer(ref this), value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Occlusions([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **")] IVectorView<Pointer<ICoreInputViewOcclusion>>** value);

        [VtblIndex(7)]
        HRESULT get_Handled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT put_Handled([NativeTypeName("boolean")] byte value);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVectorView_1_Windows__CUI__CViewManagement__CCore__CCoreInputViewOcclusion_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVectorView<Pointer<ICoreInputViewOcclusion>>**, int> get_Occlusions;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_Handled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_Handled;
    }
}
