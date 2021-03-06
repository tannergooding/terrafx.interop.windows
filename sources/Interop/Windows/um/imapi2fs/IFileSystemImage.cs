// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2C941FE1-975B-59BE-A960-9A2A262853A5")]
    [NativeTypeName("struct IFileSystemImage : IDispatch")]
    public unsafe partial struct IFileSystemImage
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IFileSystemImage*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemImage*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint>)(lpVtbl[1]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint>)(lpVtbl[2]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint*, int>)(lpVtbl[3]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
        {
            return ((delegate* unmanaged<IFileSystemImage*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFileSystemImage*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* unmanaged<IFileSystemImage*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFileSystemImage*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFileSystemImage*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_Root(IFsiDirectoryItem** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IFsiDirectoryItem**, int>)(lpVtbl[7]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_SessionStartBlock([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[8]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_SessionStartBlock([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[9]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FreeMediaBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[10]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FreeMediaBlocks([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[11]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int SetMaxMediaBlocksFromDevice(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int>)(lpVtbl[12]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UsedBlocks([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[13]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[14]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_VolumeName([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, int>)(lpVtbl[15]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ImportedVolumeName([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[16]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_BootImageOptions(IBootOptions** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IBootOptions**, int>)(lpVtbl[17]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_BootImageOptions(IBootOptions* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IBootOptions*, int>)(lpVtbl[18]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[19]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_DirectoryCount([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[20]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_WorkingDirectory([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[21]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_WorkingDirectory([NativeTypeName("BSTR")] ushort* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, int>)(lpVtbl[22]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ChangePoint([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[23]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[24]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StrictFileSystemCompliance([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[25]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[26]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UseRestrictedCharacterSet([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[27]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsToCreate(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[28]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_FileSystemsToCreate(FsiFileSystems newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int>)(lpVtbl[29]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_FileSystemsSupported(FsiFileSystems* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[30]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_UDFRevision([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[31]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevision([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[32]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_UDFRevisionsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[33]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaults(IDiscRecorder2* discRecorder)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, int>)(lpVtbl[34]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ChooseImageDefaultsForMediaType(IMAPI_MEDIA_PHYSICAL_TYPE value)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IMAPI_MEDIA_PHYSICAL_TYPE, int>)(lpVtbl[35]))((IFileSystemImage*)Unsafe.AsPointer(ref this), value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_ISO9660InterchangeLevel([NativeTypeName("LONG")] int newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[36]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevel([NativeTypeName("LONG *")] int* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int*, int>)(lpVtbl[37]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_ISO9660InterchangeLevelsSupported(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[38]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateResultImage(IFileSystemImageResult** resultStream)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IFileSystemImageResult**, int>)(lpVtbl[39]))((IFileSystemImage*)Unsafe.AsPointer(ref this), resultStream);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Exists([NativeTypeName("BSTR")] ushort* fullPath, FsiItemType* itemType)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, FsiItemType*, int>)(lpVtbl[40]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fullPath, itemType);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CalculateDiscIdentifier([NativeTypeName("BSTR *")] ushort** discIdentifier)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[41]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discIdentifier);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int IdentifyFileSystemsOnDisc(IDiscRecorder2* discRecorder, FsiFileSystems* fileSystems)
        {
            return ((delegate* unmanaged<IFileSystemImage*, IDiscRecorder2*, FsiFileSystems*, int>)(lpVtbl[42]))((IFileSystemImage*)Unsafe.AsPointer(ref this), discRecorder, fileSystems);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int GetDefaultFileSystemForImport(FsiFileSystems fileSystems, FsiFileSystems* importDefault)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, FsiFileSystems*, int>)(lpVtbl[43]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fileSystems, importDefault);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ImportFileSystem(FsiFileSystems* importedFileSystem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems*, int>)(lpVtbl[44]))((IFileSystemImage*)Unsafe.AsPointer(ref this), importedFileSystem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int ImportSpecificFileSystem(FsiFileSystems fileSystemToUse)
        {
            return ((delegate* unmanaged<IFileSystemImage*, FsiFileSystems, int>)(lpVtbl[45]))((IFileSystemImage*)Unsafe.AsPointer(ref this), fileSystemToUse);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int RollbackToChangePoint([NativeTypeName("LONG")] int changePoint)
        {
            return ((delegate* unmanaged<IFileSystemImage*, int, int>)(lpVtbl[46]))((IFileSystemImage*)Unsafe.AsPointer(ref this), changePoint);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int LockInChangePoint()
        {
            return ((delegate* unmanaged<IFileSystemImage*, int>)(lpVtbl[47]))((IFileSystemImage*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateDirectoryItem([NativeTypeName("BSTR")] ushort* name, IFsiDirectoryItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, IFsiDirectoryItem**, int>)(lpVtbl[48]))((IFileSystemImage*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int CreateFileItem([NativeTypeName("BSTR")] ushort* name, IFsiFileItem** newItem)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort*, IFsiFileItem**, int>)(lpVtbl[49]))((IFileSystemImage*)Unsafe.AsPointer(ref this), name, newItem);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameUDF([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[50]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameJoliet([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[51]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_VolumeNameISO9660([NativeTypeName("BSTR *")] ushort** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, ushort**, int>)(lpVtbl[52]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_StageFiles([NativeTypeName("VARIANT_BOOL *")] short* pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short*, int>)(lpVtbl[53]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_StageFiles([NativeTypeName("VARIANT_BOOL")] short newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, short, int>)(lpVtbl[54]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int get_MultisessionInterfaces(SAFEARRAY** pVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY**, int>)(lpVtbl[55]))((IFileSystemImage*)Unsafe.AsPointer(ref this), pVal);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int put_MultisessionInterfaces(SAFEARRAY* newVal)
        {
            return ((delegate* unmanaged<IFileSystemImage*, SAFEARRAY*, int>)(lpVtbl[56]))((IFileSystemImage*)Unsafe.AsPointer(ref this), newVal);
        }
    }
}
