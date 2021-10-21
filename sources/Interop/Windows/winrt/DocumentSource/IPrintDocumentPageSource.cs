// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/DocumentSource.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("A96BB1DB-172E-4667-82B5-AD97A252318F")]
    [NativeTypeName("struct IPrintDocumentPageSource : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IPrintDocumentPageSource
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IPrintDocumentPageSource*, Guid*, void**, int>)(lpVtbl[0]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IPrintDocumentPageSource*, uint>)(lpVtbl[1]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IPrintDocumentPageSource*, uint>)(lpVtbl[2]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPreviewPageCollection(IPrintDocumentPackageTarget* docPackageTarget, IPrintPreviewPageCollection** docPageCollection)
        {
            return ((delegate* unmanaged<IPrintDocumentPageSource*, IPrintDocumentPackageTarget*, IPrintPreviewPageCollection**, int>)(lpVtbl[3]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), docPackageTarget, docPageCollection);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int MakeDocument(IInspectable* printTaskOptions, IPrintDocumentPackageTarget* docPackageTarget)
        {
            return ((delegate* unmanaged<IPrintDocumentPageSource*, IInspectable*, IPrintDocumentPackageTarget*, int>)(lpVtbl[4]))((IPrintDocumentPageSource*)Unsafe.AsPointer(ref this), printTaskOptions, docPackageTarget);
        }
    }
}