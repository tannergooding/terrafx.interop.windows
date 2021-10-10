// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PathCch.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathIsUNCEx([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR *")] ushort** ppszServer);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int PathCchIsRoot([NativeTypeName("PCWSTR")] ushort* pszPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchAddBackslashEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] ushort** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchAddBackslash([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchRemoveBackslashEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PWSTR *")] ushort** ppszEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchRemoveBackslash([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchSkipRoot([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("PCWSTR *")] ushort** ppszRootEnd);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchStripToRoot([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchRemoveFileSpec([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchFindExtension([NativeTypeName("PCWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR *")] ushort** ppszExt);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchAddExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszExt);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchRenameExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszExt);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchRemoveExtension([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchCanonicalizeEx([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchCanonicalize([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchCombineEx([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchCombine([NativeTypeName("PWSTR")] ushort* pszPathOut, [NativeTypeName("size_t")] nuint cchPathOut, [NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchAppendEx([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchAppend([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath, [NativeTypeName("PCWSTR")] ushort* pszMore);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathCchStripPrefix([NativeTypeName("PWSTR")] ushort* pszPath, [NativeTypeName("size_t")] nuint cchPath);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathAllocCombine([NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("PCWSTR")] ushort* pszMore, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppszPathOut);

        [DllImport("KernelBase", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int PathAllocCanonicalize([NativeTypeName("PCWSTR")] ushort* pszPathIn, [NativeTypeName("ULONG")] uint dwFlags, [NativeTypeName("PWSTR *")] ushort** ppszPathOut);

        [NativeTypeName("#define VOLUME_PREFIX L\"\\\\\\\\?\\\\Volume\"")]
        public const string VOLUME_PREFIX = "\\\\?\\Volume";

        [NativeTypeName("#define VOLUME_PREFIX_LEN (ARRAYSIZE(VOLUME_PREFIX) - 1)")]
        public const uint VOLUME_PREFIX_LEN = ((11) - 1);

        [NativeTypeName("#define PATHCCH_MAX_CCH 0x8000")]
        public const int PATHCCH_MAX_CCH = 0x8000;
    }
}
