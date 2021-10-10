// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("000214F9-0000-0000-C000-000000000046")]
    [NativeTypeName("struct IShellLinkW : IUnknown")]
    [NativeInheritance("IUnknown")]
    public unsafe partial struct IShellLinkW
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IShellLinkW*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkW*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IShellLinkW*, uint>)(lpVtbl[1]))((IShellLinkW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IShellLinkW*, uint>)(lpVtbl[2]))((IShellLinkW*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        [return: NativeTypeName("HRESULT")]
        public int GetPath([NativeTypeName("LPWSTR")] ushort* pszFile, int cch, WIN32_FIND_DATAW* pfd, [NativeTypeName("DWORD")] uint fFlags)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, WIN32_FIND_DATAW*, uint, int>)(lpVtbl[3]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszFile, cch, pfd, fFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        [return: NativeTypeName("HRESULT")]
        public int GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
        {
            return ((delegate* unmanaged<IShellLinkW*, ITEMIDLIST**, int>)(lpVtbl[4]))((IShellLinkW*)Unsafe.AsPointer(ref this), ppidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        [return: NativeTypeName("HRESULT")]
        public int SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
        {
            return ((delegate* unmanaged<IShellLinkW*, ITEMIDLIST*, int>)(lpVtbl[5]))((IShellLinkW*)Unsafe.AsPointer(ref this), pidl);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        [return: NativeTypeName("HRESULT")]
        public int GetDescription([NativeTypeName("LPWSTR")] ushort* pszName, int cch)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, int>)(lpVtbl[6]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszName, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        [return: NativeTypeName("HRESULT")]
        public int SetDescription([NativeTypeName("LPCWSTR")] ushort* pszName)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int>)(lpVtbl[7]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszName);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        [return: NativeTypeName("HRESULT")]
        public int GetWorkingDirectory([NativeTypeName("LPWSTR")] ushort* pszDir, int cch)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, int>)(lpVtbl[8]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszDir, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        [return: NativeTypeName("HRESULT")]
        public int SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* pszDir)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int>)(lpVtbl[9]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszDir);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        [return: NativeTypeName("HRESULT")]
        public int GetArguments([NativeTypeName("LPWSTR")] ushort* pszArgs, int cch)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, int>)(lpVtbl[10]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszArgs, cch);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        [return: NativeTypeName("HRESULT")]
        public int SetArguments([NativeTypeName("LPCWSTR")] ushort* pszArgs)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int>)(lpVtbl[11]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszArgs);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        [return: NativeTypeName("HRESULT")]
        public int GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int>)(lpVtbl[12]))((IShellLinkW*)Unsafe.AsPointer(ref this), pwHotkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        [return: NativeTypeName("HRESULT")]
        public int SetHotkey([NativeTypeName("WORD")] ushort wHotkey)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort, int>)(lpVtbl[13]))((IShellLinkW*)Unsafe.AsPointer(ref this), wHotkey);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        [return: NativeTypeName("HRESULT")]
        public int GetShowCmd(int* piShowCmd)
        {
            return ((delegate* unmanaged<IShellLinkW*, int*, int>)(lpVtbl[14]))((IShellLinkW*)Unsafe.AsPointer(ref this), piShowCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(15)]
        [return: NativeTypeName("HRESULT")]
        public int SetShowCmd(int iShowCmd)
        {
            return ((delegate* unmanaged<IShellLinkW*, int, int>)(lpVtbl[15]))((IShellLinkW*)Unsafe.AsPointer(ref this), iShowCmd);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(16)]
        [return: NativeTypeName("HRESULT")]
        public int GetIconLocation([NativeTypeName("LPWSTR")] ushort* pszIconPath, int cch, int* piIcon)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, int*, int>)(lpVtbl[16]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszIconPath, cch, piIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(17)]
        [return: NativeTypeName("HRESULT")]
        public int SetIconLocation([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIcon)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int, int>)(lpVtbl[17]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszIconPath, iIcon);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(18)]
        [return: NativeTypeName("HRESULT")]
        public int SetRelativePath([NativeTypeName("LPCWSTR")] ushort* pszPathRel, [NativeTypeName("DWORD")] uint dwReserved)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, uint, int>)(lpVtbl[18]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszPathRel, dwReserved);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(19)]
        [return: NativeTypeName("HRESULT")]
        public int Resolve([NativeTypeName("HWND")] IntPtr hwnd, [NativeTypeName("DWORD")] uint fFlags)
        {
            return ((delegate* unmanaged<IShellLinkW*, IntPtr, uint, int>)(lpVtbl[19]))((IShellLinkW*)Unsafe.AsPointer(ref this), hwnd, fFlags);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(20)]
        [return: NativeTypeName("HRESULT")]
        public int SetPath([NativeTypeName("LPCWSTR")] ushort* pszFile)
        {
            return ((delegate* unmanaged<IShellLinkW*, ushort*, int>)(lpVtbl[20]))((IShellLinkW*)Unsafe.AsPointer(ref this), pszFile);
        }
    }
}
