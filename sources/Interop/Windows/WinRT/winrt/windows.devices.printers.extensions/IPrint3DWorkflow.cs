// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.devices.printers.extensions.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow"]/*' />
[Guid("C56F74BD-3669-4A66-AB42-C8151930CD34")]
[NativeTypeName("struct IPrint3DWorkflow : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrint3DWorkflow : IPrint3DWorkflow.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrint3DWorkflow));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, Guid*, void**, int>)(lpVtbl[0]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, uint>)(lpVtbl[1]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, uint>)(lpVtbl[2]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, uint*, Guid**, int>)(lpVtbl[3]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, HSTRING*, int>)(lpVtbl[4]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, TrustLevel*, int>)(lpVtbl[5]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.get_DeviceID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DeviceID(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, HSTRING*, int>)(lpVtbl[6]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.GetPrintModelPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPrintModelPackage(IInspectable** printModelPackage)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, IInspectable**, int>)(lpVtbl[7]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), printModelPackage);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.get_IsPrintReady"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IsPrintReady([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, byte*, int>)(lpVtbl[8]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.put_IsPrintReady"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IsPrintReady([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, byte, int>)(lpVtbl[9]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.add_PrintRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT add_PrintRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrintRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int>)(lpVtbl[10]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), eventHandler, eventCookie);
    }

    /// <include file='IPrint3DWorkflow.xml' path='doc/member[@name="IPrint3DWorkflow.remove_PrintRequested"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT remove_PrintRequested(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged[MemberFunction]<IPrint3DWorkflow*, EventRegistrationToken, int>)(lpVtbl[11]))((IPrint3DWorkflow*)Unsafe.AsPointer(ref this), eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DeviceID(HSTRING* value);

        [VtblIndex(7)]
        HRESULT GetPrintModelPackage(IInspectable** printModelPackage);

        [VtblIndex(8)]
        HRESULT get_IsPrintReady([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IsPrintReady([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT add_PrintRequested([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrintRequestedEventArgs_t *")] ITypedEventHandler<IntPtr, IntPtr>* eventHandler, EventRegistrationToken* eventCookie);

        [VtblIndex(11)]
        HRESULT remove_PrintRequested(EventRegistrationToken eventCookie);
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
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_DeviceID;

        [NativeTypeName("HRESULT (IInspectable **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IInspectable**, int> GetPrintModelPackage;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte*, int> get_IsPrintReady;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, byte, int> put_IsPrintReady;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflow_Windows__CDevices__CPrinters__CExtensions__CPrint3DWorkflowPrintRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<IntPtr, IntPtr>*, EventRegistrationToken*, int> add_PrintRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_PrintRequested;
    }
}