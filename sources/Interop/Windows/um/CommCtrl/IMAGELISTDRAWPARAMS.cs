// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct IMAGELISTDRAWPARAMS
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("HIMAGELIST")]
        public IntPtr himl;

        public int i;

        [NativeTypeName("HDC")]
        public IntPtr hdcDst;

        public int x;

        public int y;

        public int cx;

        public int cy;

        public int xBitmap;

        public int yBitmap;

        [NativeTypeName("COLORREF")]
        public uint rgbBk;

        [NativeTypeName("COLORREF")]
        public uint rgbFg;

        [NativeTypeName("UINT")]
        public uint fStyle;

        [NativeTypeName("DWORD")]
        public uint dwRop;

        [NativeTypeName("DWORD")]
        public uint fState;

        [NativeTypeName("DWORD")]
        public uint Frame;

        [NativeTypeName("COLORREF")]
        public uint crEffect;
    }
}