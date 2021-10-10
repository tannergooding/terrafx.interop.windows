// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("095C1484-1C0C-4388-9C6D-500E61BF84BD")]
    [NativeTypeName("struct ICredentialProviderSetUserArray : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICredentialProviderSetUserArray
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICredentialProviderSetUserArray*, Guid*, void**, int>)(lpVtbl[0]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICredentialProviderSetUserArray*, uint>)(lpVtbl[1]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICredentialProviderSetUserArray*, uint>)(lpVtbl[2]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int SetUserArray(ICredentialProviderUserArray* users)
        {
            return ((delegate* unmanaged<ICredentialProviderSetUserArray*, ICredentialProviderUserArray*, int>)(lpVtbl[3]))((ICredentialProviderSetUserArray*)Unsafe.AsPointer(ref this), users);
        }
    }
}
