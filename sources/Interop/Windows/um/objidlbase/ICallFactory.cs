// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("1C733A30-2A1C-11CE-ADE5-00AA0044773D")]
    [NativeTypeName("struct ICallFactory : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ICallFactory
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ICallFactory*, Guid*, void**, int>)(lpVtbl[0]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ICallFactory*, uint>)(lpVtbl[1]))((ICallFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ICallFactory*, uint>)(lpVtbl[2]))((ICallFactory*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int CreateCall([NativeTypeName("const IID &")] Guid* riid, IUnknown* pCtrlUnk, [NativeTypeName("const IID &")] Guid* riid2, IUnknown** ppv)
        {
            return ((delegate* unmanaged<ICallFactory*, Guid*, IUnknown*, Guid*, IUnknown**, int>)(lpVtbl[3]))((ICallFactory*)Unsafe.AsPointer(ref this), riid, pCtrlUnk, riid2, ppv);
        }
    }
}
