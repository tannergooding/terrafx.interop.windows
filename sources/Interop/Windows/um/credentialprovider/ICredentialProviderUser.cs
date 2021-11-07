// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop
{
    [SupportedOSPlatform("windows8.0")]
    [Guid("13793285-3EA6-40FD-B420-15F47DA41FBB")]
    [NativeTypeName("struct ICredentialProviderUser : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProviderUser : ICredentialProviderUser.Interface
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, uint>)(lpVtbl[1]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, uint>)(lpVtbl[2]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT GetSid([NativeTypeName("LPWSTR *")] ushort** sid)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, ushort**, int>)(lpVtbl[3]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), sid);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HRESULT GetProviderID(Guid* providerID)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, Guid*, int>)(lpVtbl[4]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), providerID);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HRESULT GetStringValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** stringValue)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, ushort**, int>)(lpVtbl[5]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), key, stringValue);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* value)
        {
            return ((delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, PROPVARIANT*, int>)(lpVtbl[6]))((ICredentialProviderUser*)Unsafe.AsPointer(ref this), key, value);
        }

        public interface Interface : IUnknown.Interface
        {
            [VtblIndex(3)]
            HRESULT GetSid([NativeTypeName("LPWSTR *")] ushort** sid);

            [VtblIndex(4)]
            HRESULT GetProviderID(Guid* providerID);

            [VtblIndex(5)]
            HRESULT GetStringValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("LPWSTR *")] ushort** stringValue);

            [VtblIndex(6)]
            HRESULT GetValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* value);
        }

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, uint> Release;

            [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, ushort**, int> GetSid;

            [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, Guid*, int> GetProviderID;

            [NativeTypeName("HRESULT (const PROPERTYKEY &, LPWSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, ushort**, int> GetStringValue;

            [NativeTypeName("HRESULT (const PROPERTYKEY &, PROPVARIANT *) __attribute__((stdcall))")]
            public delegate* unmanaged<ICredentialProviderUser*, PROPERTYKEY*, PROPVARIANT*, int> GetValue;
        }
    }
}
