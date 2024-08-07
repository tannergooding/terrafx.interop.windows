// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.storage.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT;

/// <include file='IStreamedFileDataRequestedHandler.xml' path='doc/member[@name="IStreamedFileDataRequestedHandler"]/*' />
[Guid("FEF6A824-2FE1-4D07-A35B-B77C50B5F4CC")]
[NativeTypeName("struct IStreamedFileDataRequestedHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStreamedFileDataRequestedHandler : IStreamedFileDataRequestedHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamedFileDataRequestedHandler));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamedFileDataRequestedHandler*, Guid*, void**, int>)(lpVtbl[0]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamedFileDataRequestedHandler*, uint>)(lpVtbl[1]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamedFileDataRequestedHandler*, uint>)(lpVtbl[2]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStreamedFileDataRequestedHandler.xml' path='doc/member[@name="IStreamedFileDataRequestedHandler.Invoke"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream)
    {
        return ((delegate* unmanaged[MemberFunction]<IStreamedFileDataRequestedHandler*, IOutputStream*, int>)(lpVtbl[3]))((IStreamedFileDataRequestedHandler*)Unsafe.AsPointer(ref this), stream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Invoke([NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream* stream);
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

        [NativeTypeName("HRESULT (ABI::Windows::Storage::Streams::IOutputStream *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IOutputStream*, int> Invoke;
    }
}
