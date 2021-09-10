// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioMetadata.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("B78E86A2-31D9-4C32-94D2-7DF40FC7EBEC")]
    [NativeTypeName("struct ISpatialAudioMetadataReader : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct ISpatialAudioMetadataReader
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, Guid*, void**, int>)(lpVtbl[0]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, uint>)(lpVtbl[1]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, uint>)(lpVtbl[2]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int Open(ISpatialAudioMetadataItems* metadataItems)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, ISpatialAudioMetadataItems*, int>)(lpVtbl[3]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), metadataItems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int ReadNextItem([NativeTypeName("UINT8 *")] byte* commandCount, [NativeTypeName("UINT16 *")] ushort* frameOffset)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, byte*, ushort*, int>)(lpVtbl[4]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandCount, frameOffset);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int ReadNextItemCommand([NativeTypeName("BYTE *")] byte* commandID, void* valueBuffer, [NativeTypeName("UINT32")] uint maxValueBufferLength, [NativeTypeName("UINT32 *")] uint* valueBufferLength)
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, byte*, void*, uint, uint*, int>)(lpVtbl[5]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this), commandID, valueBuffer, maxValueBufferLength, valueBufferLength);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int Close()
        {
            return ((delegate* unmanaged<ISpatialAudioMetadataReader*, int>)(lpVtbl[6]))((ISpatialAudioMetadataReader*)Unsafe.AsPointer(ref this));
        }
    }
}
