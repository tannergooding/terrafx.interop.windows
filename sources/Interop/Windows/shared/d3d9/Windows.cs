// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3D9 = new Guid(0x81bdcbca, 0x64d4, 0x426d, 0xae, 0x8d, 0xad, 0x1, 0x47, 0xf4, 0x27, 0x5c);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DDevice9 = new Guid(0xd0223b96, 0xbf7a, 0x43fd, 0x92, 0xbd, 0xa4, 0x3b, 0xd, 0x82, 0xb9, 0xeb);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DResource9 = new Guid(0x5eec05d, 0x8f7d, 0x4362, 0xb9, 0x99, 0xd1, 0xba, 0xf3, 0x57, 0xc7, 0x4);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DBaseTexture9 = new Guid(0x580ca87e, 0x1d3c, 0x4d54, 0x99, 0x1d, 0xb7, 0xd3, 0xe3, 0xc2, 0x98, 0xce);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DTexture9 = new Guid(0x85c31227, 0x3de5, 0x4f00, 0x9b, 0x3a, 0xf1, 0x1a, 0xc3, 0x8c, 0x18, 0xb5);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DCubeTexture9 = new Guid(0xfff32f81, 0xd953, 0x473a, 0x92, 0x23, 0x93, 0xd6, 0x52, 0xab, 0xa9, 0x3f);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DVolumeTexture9 = new Guid(0x2518526c, 0xe789, 0x4111, 0xa7, 0xb9, 0x47, 0xef, 0x32, 0x8d, 0x13, 0xe6);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DVertexBuffer9 = new Guid(0xb64bb1b5, 0xfd70, 0x4df6, 0xbf, 0x91, 0x19, 0xd0, 0xa1, 0x24, 0x55, 0xe3);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DIndexBuffer9 = new Guid(0x7c9dd65e, 0xd3f7, 0x4529, 0xac, 0xee, 0x78, 0x58, 0x30, 0xac, 0xde, 0x35);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DSurface9 = new Guid(0xcfbaf3a, 0x9ff6, 0x429a, 0x99, 0xb3, 0xa2, 0x79, 0x6a, 0xf8, 0xb8, 0x9b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DVolume9 = new Guid(0x24f416e6, 0x1f67, 0x4aa7, 0xb8, 0x8e, 0xd3, 0x3f, 0x6f, 0x31, 0x28, 0xa1);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DSwapChain9 = new Guid(0x794950f2, 0xadfc, 0x458a, 0x90, 0x5e, 0x10, 0xa1, 0xb, 0xb, 0x50, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DVertexDeclaration9 = new Guid(0xdd13c59c, 0x36fa, 0x4098, 0xa8, 0xfb, 0xc7, 0xed, 0x39, 0xdc, 0x85, 0x46);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DVertexShader9 = new Guid(0xefc5557e, 0x6265, 0x4613, 0x8a, 0x94, 0x43, 0x85, 0x78, 0x89, 0xeb, 0x36);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DPixelShader9 = new Guid(0x6d3bdbdc, 0x5b02, 0x4415, 0xb8, 0x52, 0xce, 0x5e, 0x8b, 0xcc, 0xb2, 0x89);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DStateBlock9 = new Guid(0xb07c4fe5, 0x310d, 0x4ba8, 0xa2, 0x3c, 0x4f, 0xf, 0x20, 0x6f, 0x21, 0x8b);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DQuery9 = new Guid(0xd9771460, 0xa695, 0x4f26, 0xbb, 0xd3, 0x27, 0xb8, 0x40, 0xb5, 0x41, 0xcc);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_HelperName = new Guid(0xe4a36723, 0xfdfe, 0x4b22, 0xb1, 0x46, 0x3c, 0x4, 0xc0, 0x7f, 0x4c, 0xc8);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3D9Ex = new Guid(0x02177241, 0x69FC, 0x400C, 0x8F, 0xF1, 0x93, 0xA4, 0x4D, 0xF6, 0x86, 0x1D);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DDevice9Ex = new Guid(0xb18b10ce, 0x2649, 0x405a, 0x87, 0xf, 0x95, 0xf7, 0x77, 0xd4, 0x31, 0x3a);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DSwapChain9Ex = new Guid(0x91886caf, 0x1c3d, 0x4d2e, 0xa0, 0xab, 0x3e, 0x4c, 0x7d, 0x8d, 0x33, 0x3);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3D9ExOverlayExtension = new Guid(0x187aeb13, 0xaaf5, 0x4c59, 0x87, 0x6d, 0xe0, 0x59, 0x8, 0x8c, 0xd, 0xf8);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DDevice9Video = new Guid(0x26dc4561, 0xa1ee, 0x4ae7, 0x96, 0xda, 0x11, 0x8a, 0x36, 0xc0, 0xec, 0x95);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DAuthenticatedChannel9 = new Guid(0xff24beee, 0xda21, 0x4beb, 0x98, 0xb5, 0xd2, 0xf8, 0x99, 0xf9, 0x8a, 0xf9);

        [NativeTypeName("const GUID")]
        public static readonly Guid IID_IDirect3DCryptoSession9 = new Guid(0xfa0ab799, 0x7a9c, 0x48ca, 0x8c, 0x5b, 0x23, 0x7e, 0x71, 0xa5, 0x44, 0x34);

        [DllImport("d3d9", ExactSpelling = true)]
        [return: NativeTypeName("IDirect3D9 *")]
        public static extern IDirect3D9* Direct3DCreate9([NativeTypeName("UINT")] uint SDKVersion);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern int D3DPERF_BeginEvent([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern int D3DPERF_EndEvent();

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetMarker([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetRegion([NativeTypeName("D3DCOLOR")] uint col, [NativeTypeName("LPCWSTR")] ushort* wszName);

        [DllImport("d3d9", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D3DPERF_QueryRepeatFrame();

        [DllImport("d3d9", ExactSpelling = true)]
        public static extern void D3DPERF_SetOptions([NativeTypeName("DWORD")] uint dwOptions);

        [DllImport("d3d9", ExactSpelling = true)]
        [return: NativeTypeName("DWORD")]
        public static extern uint D3DPERF_GetStatus();

        [DllImport("d3d9", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int Direct3DCreate9Ex([NativeTypeName("UINT")] uint SDKVersion, [NativeTypeName("IDirect3D9Ex **")] IDirect3D9Ex** param1);

        [NativeTypeName("#define D3D_SDK_VERSION 32")]
        public const int D3D_SDK_VERSION = 32;

        [NativeTypeName("#define D3D9b_SDK_VERSION 31")]
        public const int D3D9b_SDK_VERSION = 31;

        [NativeTypeName("#define D3DSPD_IUNKNOWN 0x00000001L")]
        public const int D3DSPD_IUNKNOWN = 0x00000001;

        [NativeTypeName("#define D3DCREATE_FPU_PRESERVE 0x00000002L")]
        public const int D3DCREATE_FPU_PRESERVE = 0x00000002;

        [NativeTypeName("#define D3DCREATE_MULTITHREADED 0x00000004L")]
        public const int D3DCREATE_MULTITHREADED = 0x00000004;

        [NativeTypeName("#define D3DCREATE_PUREDEVICE 0x00000010L")]
        public const int D3DCREATE_PUREDEVICE = 0x00000010;

        [NativeTypeName("#define D3DCREATE_SOFTWARE_VERTEXPROCESSING 0x00000020L")]
        public const int D3DCREATE_SOFTWARE_VERTEXPROCESSING = 0x00000020;

        [NativeTypeName("#define D3DCREATE_HARDWARE_VERTEXPROCESSING 0x00000040L")]
        public const int D3DCREATE_HARDWARE_VERTEXPROCESSING = 0x00000040;

        [NativeTypeName("#define D3DCREATE_MIXED_VERTEXPROCESSING 0x00000080L")]
        public const int D3DCREATE_MIXED_VERTEXPROCESSING = 0x00000080;

        [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT 0x00000100L")]
        public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT = 0x00000100;

        [NativeTypeName("#define D3DCREATE_ADAPTERGROUP_DEVICE 0x00000200L")]
        public const int D3DCREATE_ADAPTERGROUP_DEVICE = 0x00000200;

        [NativeTypeName("#define D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX 0x00000400L")]
        public const int D3DCREATE_DISABLE_DRIVER_MANAGEMENT_EX = 0x00000400;

        [NativeTypeName("#define D3DCREATE_NOWINDOWCHANGES 0x00000800L")]
        public const int D3DCREATE_NOWINDOWCHANGES = 0x00000800;

        [NativeTypeName("#define D3DCREATE_DISABLE_PSGP_THREADING 0x00002000L")]
        public const int D3DCREATE_DISABLE_PSGP_THREADING = 0x00002000;

        [NativeTypeName("#define D3DCREATE_ENABLE_PRESENTSTATS 0x00004000L")]
        public const int D3DCREATE_ENABLE_PRESENTSTATS = 0x00004000;

        [NativeTypeName("#define D3DCREATE_DISABLE_PRINTSCREEN 0x00008000L")]
        public const int D3DCREATE_DISABLE_PRINTSCREEN = 0x00008000;

        [NativeTypeName("#define D3DCREATE_SCREENSAVER 0x10000000L")]
        public const int D3DCREATE_SCREENSAVER = 0x10000000;

        [NativeTypeName("#define D3DADAPTER_DEFAULT 0")]
        public const int D3DADAPTER_DEFAULT = 0;

        [NativeTypeName("#define D3DENUM_WHQL_LEVEL 0x00000002L")]
        public const int D3DENUM_WHQL_LEVEL = 0x00000002;

        [NativeTypeName("#define D3DENUM_NO_DRIVERVERSION 0x00000004L")]
        public const int D3DENUM_NO_DRIVERVERSION = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX 3L")]
        public const int D3DPRESENT_BACK_BUFFERS_MAX = 3;

        [NativeTypeName("#define D3DPRESENT_BACK_BUFFERS_MAX_EX 30L")]
        public const int D3DPRESENT_BACK_BUFFERS_MAX_EX = 30;

        [NativeTypeName("#define D3DSGR_NO_CALIBRATION 0x00000000L")]
        public const int D3DSGR_NO_CALIBRATION = 0x00000000;

        [NativeTypeName("#define D3DSGR_CALIBRATE 0x00000001L")]
        public const int D3DSGR_CALIBRATE = 0x00000001;

        [NativeTypeName("#define D3DCURSOR_IMMEDIATE_UPDATE 0x00000001L")]
        public const int D3DCURSOR_IMMEDIATE_UPDATE = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_DONOTWAIT 0x00000001L")]
        public const int D3DPRESENT_DONOTWAIT = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_LINEAR_CONTENT 0x00000002L")]
        public const int D3DPRESENT_LINEAR_CONTENT = 0x00000002;

        [NativeTypeName("#define D3DPRESENT_DONOTFLIP 0x00000004L")]
        public const int D3DPRESENT_DONOTFLIP = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_FLIPRESTART 0x00000008L")]
        public const int D3DPRESENT_FLIPRESTART = 0x00000008;

        [NativeTypeName("#define D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR 0x00000010L")]
        public const int D3DPRESENT_VIDEO_RESTRICT_TO_MONITOR = 0x00000010;

        [NativeTypeName("#define D3DPRESENT_UPDATEOVERLAYONLY 0x00000020L")]
        public const int D3DPRESENT_UPDATEOVERLAYONLY = 0x00000020;

        [NativeTypeName("#define D3DPRESENT_HIDEOVERLAY 0x00000040L")]
        public const int D3DPRESENT_HIDEOVERLAY = 0x00000040;

        [NativeTypeName("#define D3DPRESENT_UPDATECOLORKEY 0x00000080L")]
        public const int D3DPRESENT_UPDATECOLORKEY = 0x00000080;

        [NativeTypeName("#define D3DPRESENT_FORCEIMMEDIATE 0x00000100L")]
        public const int D3DPRESENT_FORCEIMMEDIATE = 0x00000100;

        [NativeTypeName("#define _FACD3D 0x876")]
        public const int _FACD3D = 0x876;

        [NativeTypeName("#define D3D_OK S_OK")]
        public const int D3D_OK = ((int)(0));

        [NativeTypeName("#define D3DERR_WRONGTEXTUREFORMAT MAKE_D3DHRESULT(2072)")]
        public const int D3DERR_WRONGTEXTUREFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2072))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLOROPERATION MAKE_D3DHRESULT(2073)")]
        public const int D3DERR_UNSUPPORTEDCOLOROPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2073))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCOLORARG MAKE_D3DHRESULT(2074)")]
        public const int D3DERR_UNSUPPORTEDCOLORARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2074))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAOPERATION MAKE_D3DHRESULT(2075)")]
        public const int D3DERR_UNSUPPORTEDALPHAOPERATION = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2075))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDALPHAARG MAKE_D3DHRESULT(2076)")]
        public const int D3DERR_UNSUPPORTEDALPHAARG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2076))));

        [NativeTypeName("#define D3DERR_TOOMANYOPERATIONS MAKE_D3DHRESULT(2077)")]
        public const int D3DERR_TOOMANYOPERATIONS = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2077))));

        [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREFILTER MAKE_D3DHRESULT(2078)")]
        public const int D3DERR_CONFLICTINGTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2078))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDFACTORVALUE MAKE_D3DHRESULT(2079)")]
        public const int D3DERR_UNSUPPORTEDFACTORVALUE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2079))));

        [NativeTypeName("#define D3DERR_CONFLICTINGRENDERSTATE MAKE_D3DHRESULT(2081)")]
        public const int D3DERR_CONFLICTINGRENDERSTATE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2081))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDTEXTUREFILTER MAKE_D3DHRESULT(2082)")]
        public const int D3DERR_UNSUPPORTEDTEXTUREFILTER = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2082))));

        [NativeTypeName("#define D3DERR_CONFLICTINGTEXTUREPALETTE MAKE_D3DHRESULT(2086)")]
        public const int D3DERR_CONFLICTINGTEXTUREPALETTE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2086))));

        [NativeTypeName("#define D3DERR_DRIVERINTERNALERROR MAKE_D3DHRESULT(2087)")]
        public const int D3DERR_DRIVERINTERNALERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2087))));

        [NativeTypeName("#define D3DERR_NOTFOUND MAKE_D3DHRESULT(2150)")]
        public const int D3DERR_NOTFOUND = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2150))));

        [NativeTypeName("#define D3DERR_MOREDATA MAKE_D3DHRESULT(2151)")]
        public const int D3DERR_MOREDATA = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2151))));

        [NativeTypeName("#define D3DERR_DEVICELOST MAKE_D3DHRESULT(2152)")]
        public const int D3DERR_DEVICELOST = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2152))));

        [NativeTypeName("#define D3DERR_DEVICENOTRESET MAKE_D3DHRESULT(2153)")]
        public const int D3DERR_DEVICENOTRESET = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2153))));

        [NativeTypeName("#define D3DERR_NOTAVAILABLE MAKE_D3DHRESULT(2154)")]
        public const int D3DERR_NOTAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2154))));

        [NativeTypeName("#define D3DERR_OUTOFVIDEOMEMORY MAKE_D3DHRESULT(380)")]
        public const int D3DERR_OUTOFVIDEOMEMORY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(380))));

        [NativeTypeName("#define D3DERR_INVALIDDEVICE MAKE_D3DHRESULT(2155)")]
        public const int D3DERR_INVALIDDEVICE = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2155))));

        [NativeTypeName("#define D3DERR_INVALIDCALL MAKE_D3DHRESULT(2156)")]
        public const int D3DERR_INVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2156))));

        [NativeTypeName("#define D3DERR_DRIVERINVALIDCALL MAKE_D3DHRESULT(2157)")]
        public const int D3DERR_DRIVERINVALIDCALL = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2157))));

        [NativeTypeName("#define D3DERR_WASSTILLDRAWING MAKE_D3DHRESULT(540)")]
        public const int D3DERR_WASSTILLDRAWING = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(540))));

        [NativeTypeName("#define D3DOK_NOAUTOGEN MAKE_D3DSTATUS(2159)")]
        public const int D3DOK_NOAUTOGEN = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2159))));

        [NativeTypeName("#define D3DERR_DEVICEREMOVED MAKE_D3DHRESULT(2160)")]
        public const int D3DERR_DEVICEREMOVED = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2160))));

        [NativeTypeName("#define S_NOT_RESIDENT MAKE_D3DSTATUS(2165)")]
        public const int S_NOT_RESIDENT = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2165))));

        [NativeTypeName("#define S_RESIDENT_IN_SHARED_MEMORY MAKE_D3DSTATUS(2166)")]
        public const int S_RESIDENT_IN_SHARED_MEMORY = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2166))));

        [NativeTypeName("#define S_PRESENT_MODE_CHANGED MAKE_D3DSTATUS(2167)")]
        public const int S_PRESENT_MODE_CHANGED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2167))));

        [NativeTypeName("#define S_PRESENT_OCCLUDED MAKE_D3DSTATUS(2168)")]
        public const int S_PRESENT_OCCLUDED = unchecked((int)(((uint)(0) << 31) | ((uint)(0x876) << 16) | ((uint)(2168))));

        [NativeTypeName("#define D3DERR_DEVICEHUNG MAKE_D3DHRESULT(2164)")]
        public const int D3DERR_DEVICEHUNG = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2164))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAY MAKE_D3DHRESULT(2171)")]
        public const int D3DERR_UNSUPPORTEDOVERLAY = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2171))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDOVERLAYFORMAT MAKE_D3DHRESULT(2172)")]
        public const int D3DERR_UNSUPPORTEDOVERLAYFORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2172))));

        [NativeTypeName("#define D3DERR_CANNOTPROTECTCONTENT MAKE_D3DHRESULT(2173)")]
        public const int D3DERR_CANNOTPROTECTCONTENT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2173))));

        [NativeTypeName("#define D3DERR_UNSUPPORTEDCRYPTO MAKE_D3DHRESULT(2174)")]
        public const int D3DERR_UNSUPPORTEDCRYPTO = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2174))));

        [NativeTypeName("#define D3DERR_PRESENT_STATISTICS_DISJOINT MAKE_D3DHRESULT(2180)")]
        public const int D3DERR_PRESENT_STATISTICS_DISJOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(0x876) << 16) | ((uint)(2180))));
    }
}
