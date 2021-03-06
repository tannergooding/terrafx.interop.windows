// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("26D709AC-F70B-4421-A96F-D2878FAFB00D")]
    [NativeTypeName("struct IMachineGlobalObjectTable : IUnknown")]
    public unsafe partial struct IMachineGlobalObjectTable
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, void**, int>)(lpVtbl[0]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, uint>)(lpVtbl[1]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, uint>)(lpVtbl[2]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RegisterObject([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, IUnknown* @object, [NativeTypeName("MachineGlobalObjectTableRegistrationToken *")] IntPtr* token)
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, ushort*, IUnknown*, IntPtr*, int>)(lpVtbl[3]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), clsid, identifier, @object, token);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetObjectW([NativeTypeName("const IID &")] Guid* clsid, [NativeTypeName("LPCWSTR")] ushort* identifier, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, Guid*, ushort*, Guid*, void**, int>)(lpVtbl[4]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), clsid, identifier, riid, ppv);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RevokeObject([NativeTypeName("MachineGlobalObjectTableRegistrationToken")] IntPtr token)
        {
            return ((delegate* unmanaged<IMachineGlobalObjectTable*, IntPtr, int>)(lpVtbl[5]))((IMachineGlobalObjectTable*)Unsafe.AsPointer(ref this), token);
        }
    }
}
