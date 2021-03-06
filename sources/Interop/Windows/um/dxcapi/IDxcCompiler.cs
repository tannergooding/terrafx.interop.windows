// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dxcapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the University of Illinois Open Source License.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("8C210BF3-011F-4422-8D70-6F9ACB8DB617")]
    [NativeTypeName("struct IDxcCompiler : IUnknown")]
    public unsafe partial struct IDxcCompiler
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDxcCompiler*, Guid*, void**, int>)(lpVtbl[0]))((IDxcCompiler*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDxcCompiler*, uint>)(lpVtbl[1]))((IDxcCompiler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDxcCompiler*, uint>)(lpVtbl[2]))((IDxcCompiler*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Compile(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR")] ushort* pEntryPoint, [NativeTypeName("LPCWSTR")] ushort* pTargetProfile, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcCompiler*, IDxcBlob*, ushort*, ushort*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[3]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, pSourceName, pEntryPoint, pTargetProfile, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Preprocess(IDxcBlob* pSource, [NativeTypeName("LPCWSTR")] ushort* pSourceName, [NativeTypeName("LPCWSTR *")] ushort** pArguments, [NativeTypeName("UINT32")] uint argCount, [NativeTypeName("const DxcDefine *")] DxcDefine* pDefines, [NativeTypeName("UINT32")] uint defineCount, IDxcIncludeHandler* pIncludeHandler, IDxcOperationResult** ppResult)
        {
            return ((delegate* unmanaged<IDxcCompiler*, IDxcBlob*, ushort*, ushort**, uint, DxcDefine*, uint, IDxcIncludeHandler*, IDxcOperationResult**, int>)(lpVtbl[4]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, pSourceName, pArguments, argCount, pDefines, defineCount, pIncludeHandler, ppResult);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [return: NativeTypeName("HRESULT")]
        public int Disassemble(IDxcBlob* pSource, IDxcBlobEncoding** ppDisassembly)
        {
            return ((delegate* unmanaged<IDxcCompiler*, IDxcBlob*, IDxcBlobEncoding**, int>)(lpVtbl[5]))((IDxcCompiler*)Unsafe.AsPointer(ref this), pSource, ppDisassembly);
        }
    }
}
