// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3DPRESENT_PARAMETERS
    {
        [NativeTypeName("UINT")]
        public uint BackBufferWidth;

        [NativeTypeName("UINT")]
        public uint BackBufferHeight;

        public D3DFORMAT BackBufferFormat;

        [NativeTypeName("UINT")]
        public uint BackBufferCount;

        public D3DMULTISAMPLE_TYPE MultiSampleType;

        [NativeTypeName("DWORD")]
        public uint MultiSampleQuality;

        public D3DSWAPEFFECT SwapEffect;

        [NativeTypeName("HWND")]
        public IntPtr hDeviceWindow;

        [NativeTypeName("BOOL")]
        public int Windowed;

        [NativeTypeName("BOOL")]
        public int EnableAutoDepthStencil;

        public D3DFORMAT AutoDepthStencilFormat;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("UINT")]
        public uint FullScreen_RefreshRateInHz;

        [NativeTypeName("UINT")]
        public uint PresentationInterval;
    }
}
