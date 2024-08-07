// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog"]/*' />
[Guid("E7392CE0-C78D-427E-8B2C-01FF420C69D5")]
[NativeTypeName("struct ICoreWindowDialog : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICoreWindowDialog : ICoreWindowDialog.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICoreWindowDialog));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, Guid*, void**, int>)(lpVtbl[0]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint>)(lpVtbl[1]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint>)(lpVtbl[2]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IInspectable.GetIids" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids([NativeTypeName("ULONG *")] uint* iidCount, [NativeTypeName("IID **")] Guid** iids)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint*, Guid**, int>)(lpVtbl[3]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), iidCount, iids);
    }

    /// <inheritdoc cref="IInspectable.GetRuntimeClassName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, HSTRING*, int>)(lpVtbl[4]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), className);
    }

    /// <inheritdoc cref="IInspectable.GetTrustLevel" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, TrustLevel*, int>)(lpVtbl[5]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), trustLevel);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.add_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>* handler, EventRegistrationToken* cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>*, EventRegistrationToken*, int>)(lpVtbl[6]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), handler, cookie);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.remove_Showing"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_Showing(EventRegistrationToken cookie)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, EventRegistrationToken, int>)(lpVtbl[7]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), cookie);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_MaxSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, Size*, int>)(lpVtbl[8]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_MinSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, Size*, int>)(lpVtbl[9]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Title(HSTRING* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, HSTRING*, int>)(lpVtbl[10]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.put_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_Title(HSTRING value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, HSTRING, int>)(lpVtbl[11]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_IsInteractionDelayed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, int*, int>)(lpVtbl[12]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.put_IsInteractionDelayed"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, int, int>)(lpVtbl[13]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_Commands"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, IVector<Pointer<IUICommand>>**, int>)(lpVtbl[14]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint*, int>)(lpVtbl[15]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.put_DefaultCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint, int>)(lpVtbl[16]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_CancelCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint*, int>)(lpVtbl[17]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.put_CancelCommandIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, uint, int>)(lpVtbl[18]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.get_BackButtonCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, IUICommandInvokedHandler**, int>)(lpVtbl[19]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.put_BackButtonCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, IUICommandInvokedHandler*, int>)(lpVtbl[20]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), value);
    }

    /// <include file='ICoreWindowDialog.xml' path='doc/member[@name="ICoreWindowDialog.ShowAsync"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncInfo)
    {
        return ((delegate* unmanaged[MemberFunction]<ICoreWindowDialog*, IAsyncOperation<Pointer<IUICommand>>**, int>)(lpVtbl[21]))((ICoreWindowDialog*)Unsafe.AsPointer(ref this), asyncInfo);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_Showing([NativeTypeName("ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *")] ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>* handler, EventRegistrationToken* cookie);

        [VtblIndex(7)]
        HRESULT remove_Showing(EventRegistrationToken cookie);

        [VtblIndex(8)]
        HRESULT get_MaxSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(9)]
        HRESULT get_MinSize([NativeTypeName("ABI::Windows::Foundation::Size *")] Size* value);

        [VtblIndex(10)]
        HRESULT get_Title(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_Title(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_IsInteractionDelayed([NativeTypeName("INT32 *")] int* value);

        [VtblIndex(13)]
        HRESULT put_IsInteractionDelayed([NativeTypeName("INT32")] int value);

        [VtblIndex(14)]
        HRESULT get_Commands([NativeTypeName("ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **")] IVector<Pointer<IUICommand>>** value);

        [VtblIndex(15)]
        HRESULT get_DefaultCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(16)]
        HRESULT put_DefaultCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(17)]
        HRESULT get_CancelCommandIndex([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(18)]
        HRESULT put_CancelCommandIndex([NativeTypeName("UINT32")] uint value);

        [VtblIndex(19)]
        HRESULT get_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler **")] IUICommandInvokedHandler** value);

        [VtblIndex(20)]
        HRESULT put_BackButtonCommand([NativeTypeName("ABI::Windows::UI::Popups::IUICommandInvokedHandler *")] IUICommandInvokedHandler* value);

        [VtblIndex(21)]
        HRESULT ShowAsync([NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **")] IAsyncOperation<Pointer<IUICommand>>** asyncInfo);
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CUI__CCore__CCoreWindow_Windows__CUI__CCore__CCoreWindowPopupShowingEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, ITypedEventHandler<Pointer<ICoreWindow>, Pointer<ICoreWindowPopupShowingEventArgs>>*, EventRegistrationToken*, int> add_Showing;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, EventRegistrationToken, int> remove_Showing;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_MaxSize;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Size *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Size*, int> get_MinSize;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING*, int> get_Title;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, HSTRING, int> put_Title;

        [NativeTypeName("HRESULT (INT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int*, int> get_IsInteractionDelayed;

        [NativeTypeName("HRESULT (INT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int, int> put_IsInteractionDelayed;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IVector<Pointer<IUICommand>>**, int> get_Commands;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_DefaultCommandIndex;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint*, int> get_CancelCommandIndex;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, int> put_CancelCommandIndex;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler**, int> get_BackButtonCommand;

        [NativeTypeName("HRESULT (ABI::Windows::UI::Popups::IUICommandInvokedHandler *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IUICommandInvokedHandler*, int> put_BackButtonCommand;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CUI__CPopups__CIUICommand_t **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IAsyncOperation<Pointer<IUICommand>>**, int> ShowAsync;
    }
}
