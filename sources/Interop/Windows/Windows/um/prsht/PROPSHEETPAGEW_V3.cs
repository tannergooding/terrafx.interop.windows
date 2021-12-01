// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/prsht.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3"]/*' />
public unsafe partial struct PROPSHEETPAGEW_V3
{
    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.hInstance"]/*' />
    public HINSTANCE hInstance;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.Anonymous1"]/*' />
    [NativeTypeName("_PROPSHEETPAGEW_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:259:5)")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.Anonymous2"]/*' />
    [NativeTypeName("_PROPSHEETPAGEW_V3::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/prsht.h:259:5)")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pszTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszTitle;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pfnDlgProc"]/*' />
    [NativeTypeName("DLGPROC")]
    public delegate* unmanaged<HWND, uint, WPARAM, LPARAM, nint> pfnDlgProc;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.lParam"]/*' />
    public LPARAM lParam;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pfnCallback"]/*' />
    [NativeTypeName("LPFNPSPCALLBACKW")]
    public delegate* unmanaged<HWND, uint, PROPSHEETPAGEW*, uint> pfnCallback;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pcRefParent"]/*' />
    public uint* pcRefParent;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pszHeaderTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszHeaderTitle;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.pszHeaderSubTitle"]/*' />
    [NativeTypeName("LPCWSTR")]
    public ushort* pszHeaderSubTitle;

    /// <include file='PROPSHEETPAGEW_V3.xml' path='doc/member[@name="PROPSHEETPAGEW_V3.hActCtx"]/*' />
    public HANDLE hActCtx;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
    public ref ushort* pszTemplate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pszTemplate;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
    public ref DLGTEMPLATE* pResource
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous1.pResource;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
    public ref HICON hIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.hIcon;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
    public ref ushort* pszIcon
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref this, 1)).Anonymous2.pszIcon;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszTemplate"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszTemplate;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pResource"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PROPSHEETPAGE_RESOURCE")]
        public DLGTEMPLATE* pResource;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.hIcon"]/*' />
        [FieldOffset(0)]
        public HICON hIcon;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszIcon"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pszIcon;
    }
}