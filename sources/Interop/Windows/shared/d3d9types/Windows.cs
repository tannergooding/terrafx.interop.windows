// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using static TerraFX.Interop.D3DDECLMETHOD;
using static TerraFX.Interop.D3DDECLTYPE;
using static TerraFX.Interop.D3DDECLUSAGE;
using static TerraFX.Interop.D3DRESOURCETYPE;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_PROTECTION = new Guid(0xa84eb584, 0xc495, 0x48aa, 0xb9, 0x4d, 0x8b, 0xd2, 0xd6, 0xfb, 0xce, 0x5);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_CHANNELTYPE = new Guid(0xbc1b18a5, 0xb1fb, 0x42ab, 0xbd, 0x94, 0xb5, 0x82, 0x8b, 0x4b, 0xf7, 0xbe);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_DEVICEHANDLE = new Guid(0xec1c539d, 0x8cff, 0x4e2a, 0xbc, 0xc4, 0xf5, 0x69, 0x2f, 0x99, 0xf4, 0x80);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_CRYPTOSESSION = new Guid(0x2634499e, 0xd018, 0x4d74, 0xac, 0x17, 0x7f, 0x72, 0x40, 0x59, 0x52, 0x8d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESSCOUNT = new Guid(0xdb207b3, 0x9450, 0x46a6, 0x82, 0xde, 0x1b, 0x96, 0xd4, 0x4f, 0x9c, 0xf2);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_RESTRICTEDSHAREDRESOURCEPROCESS = new Guid(0x649bbadb, 0xf0f4, 0x4639, 0xa1, 0x5b, 0x24, 0x39, 0x3f, 0xc3, 0xab, 0xac);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_UNRESTRICTEDPROTECTEDSHAREDRESOURCECOUNT = new Guid(0x12f0bd6, 0xe662, 0x4474, 0xbe, 0xfd, 0xaa, 0x53, 0xe5, 0x14, 0x3c, 0x6d);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_OUTPUTIDCOUNT = new Guid(0x2c042b5e, 0x8c07, 0x46d5, 0xaa, 0xbe, 0x8f, 0x75, 0xcb, 0xad, 0x4c, 0x31);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_OUTPUTID = new Guid(0x839ddca3, 0x9b4e, 0x41e4, 0xb0, 0x53, 0x89, 0x2b, 0xd2, 0xa1, 0x1e, 0xe7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_ACCESSIBILITYATTRIBUTES = new Guid(0x6214d9d2, 0x432c, 0x4abb, 0x9f, 0xce, 0x21, 0x6e, 0xea, 0x26, 0x9e, 0x3b);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUIDCOUNT = new Guid(0xb30f7066, 0x203c, 0x4b07, 0x93, 0xfc, 0xce, 0xaa, 0xfd, 0x61, 0x24, 0x1e);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_ENCRYPTIONWHENACCESSIBLEGUID = new Guid(0xf83a5958, 0xe986, 0x4bda, 0xbe, 0xb0, 0x41, 0x1f, 0x6a, 0x7a, 0x1, 0xb7);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDQUERY_CURRENTENCRYPTIONWHENACCESSIBLE = new Guid(0xec1791c7, 0xdad3, 0x4f15, 0x9e, 0xc3, 0xfa, 0xa9, 0x3d, 0x60, 0xd4, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDCONFIGURE_INITIALIZE = new Guid(0x6114bdb, 0x3523, 0x470a, 0x8d, 0xca, 0xfb, 0xc2, 0x84, 0x51, 0x54, 0xf0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDCONFIGURE_PROTECTION = new Guid(0x50455658, 0x3f47, 0x4362, 0xbf, 0x99, 0xbf, 0xdf, 0xcd, 0xe9, 0xed, 0x29);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDCONFIGURE_CRYPTOSESSION = new Guid(0x6346cc54, 0x2cfc, 0x4ad4, 0x82, 0x24, 0xd1, 0x58, 0x37, 0xde, 0x77, 0x0);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDCONFIGURE_SHAREDRESOURCE = new Guid(0x772d047, 0x1b40, 0x48e8, 0x9c, 0xa6, 0xb5, 0xf5, 0x10, 0xde, 0x9f, 0x1);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DAUTHENTICATEDCONFIGURE_ENCRYPTIONWHENACCESSIBLE = new Guid(0x41fff286, 0x6ae0, 0x4d43, 0x9d, 0x55, 0xa4, 0x6e, 0x9e, 0xfd, 0x15, 0x8a);

        [NativeTypeName("#define DIRECT3D_VERSION 0x0900")]
        public const int DIRECT3D_VERSION = 0x0900;

        [NativeTypeName("#define D3DMAXUSERCLIPPLANES 32")]
        public const int D3DMAXUSERCLIPPLANES = 32;

        [NativeTypeName("#define D3DCLIPPLANE0 (1 << 0)")]
        public const int D3DCLIPPLANE0 = (1 << 0);

        [NativeTypeName("#define D3DCLIPPLANE1 (1 << 1)")]
        public const int D3DCLIPPLANE1 = (1 << 1);

        [NativeTypeName("#define D3DCLIPPLANE2 (1 << 2)")]
        public const int D3DCLIPPLANE2 = (1 << 2);

        [NativeTypeName("#define D3DCLIPPLANE3 (1 << 3)")]
        public const int D3DCLIPPLANE3 = (1 << 3);

        [NativeTypeName("#define D3DCLIPPLANE4 (1 << 4)")]
        public const int D3DCLIPPLANE4 = (1 << 4);

        [NativeTypeName("#define D3DCLIPPLANE5 (1 << 5)")]
        public const int D3DCLIPPLANE5 = (1 << 5);

        [NativeTypeName("#define D3DCS_LEFT 0x00000001L")]
        public const int D3DCS_LEFT = 0x00000001;

        [NativeTypeName("#define D3DCS_RIGHT 0x00000002L")]
        public const int D3DCS_RIGHT = 0x00000002;

        [NativeTypeName("#define D3DCS_TOP 0x00000004L")]
        public const int D3DCS_TOP = 0x00000004;

        [NativeTypeName("#define D3DCS_BOTTOM 0x00000008L")]
        public const int D3DCS_BOTTOM = 0x00000008;

        [NativeTypeName("#define D3DCS_FRONT 0x00000010L")]
        public const int D3DCS_FRONT = 0x00000010;

        [NativeTypeName("#define D3DCS_BACK 0x00000020L")]
        public const int D3DCS_BACK = 0x00000020;

        [NativeTypeName("#define D3DCS_PLANE0 0x00000040L")]
        public const int D3DCS_PLANE0 = 0x00000040;

        [NativeTypeName("#define D3DCS_PLANE1 0x00000080L")]
        public const int D3DCS_PLANE1 = 0x00000080;

        [NativeTypeName("#define D3DCS_PLANE2 0x00000100L")]
        public const int D3DCS_PLANE2 = 0x00000100;

        [NativeTypeName("#define D3DCS_PLANE3 0x00000200L")]
        public const int D3DCS_PLANE3 = 0x00000200;

        [NativeTypeName("#define D3DCS_PLANE4 0x00000400L")]
        public const int D3DCS_PLANE4 = 0x00000400;

        [NativeTypeName("#define D3DCS_PLANE5 0x00000800L")]
        public const int D3DCS_PLANE5 = 0x00000800;

        [NativeTypeName("#define D3DCS_ALL (D3DCS_LEFT   | \\\r\n                   D3DCS_RIGHT  | \\\r\n                   D3DCS_TOP    | \\\r\n                   D3DCS_BOTTOM | \\\r\n                   D3DCS_FRONT  | \\\r\n                   D3DCS_BACK   | \\\r\n                   D3DCS_PLANE0 | \\\r\n                   D3DCS_PLANE1 | \\\r\n                   D3DCS_PLANE2 | \\\r\n                   D3DCS_PLANE3 | \\\r\n                   D3DCS_PLANE4 | \\\r\n                   D3DCS_PLANE5)")]
        public const int D3DCS_ALL = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008 | 0x00000010 | 0x00000020 | 0x00000040 | 0x00000080 | 0x00000100 | 0x00000200 | 0x00000400 | 0x00000800);

        [NativeTypeName("#define D3DCLEAR_TARGET 0x00000001l")]
        public const int D3DCLEAR_TARGET = 0x00000001;

        [NativeTypeName("#define D3DCLEAR_ZBUFFER 0x00000002l")]
        public const int D3DCLEAR_ZBUFFER = 0x00000002;

        [NativeTypeName("#define D3DCLEAR_STENCIL 0x00000004l")]
        public const int D3DCLEAR_STENCIL = 0x00000004;

        [NativeTypeName("#define D3DTS_WORLD D3DTS_WORLDMATRIX(0)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD = (D3DTRANSFORMSTATETYPE)(0 + 256);

        [NativeTypeName("#define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD1 = (D3DTRANSFORMSTATETYPE)(1 + 256);

        [NativeTypeName("#define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD2 = (D3DTRANSFORMSTATETYPE)(2 + 256);

        [NativeTypeName("#define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)")]
        public const D3DTRANSFORMSTATETYPE D3DTS_WORLD3 = (D3DTRANSFORMSTATETYPE)(3 + 256);

        [NativeTypeName("#define D3D_MAX_SIMULTANEOUS_RENDERTARGETS 4")]
        public const int D3D_MAX_SIMULTANEOUS_RENDERTARGETS = 4;

        [NativeTypeName("#define D3DRENDERSTATE_WRAPBIAS 128UL")]
        public const uint D3DRENDERSTATE_WRAPBIAS = 128U;

        [NativeTypeName("#define D3DWRAP_U 0x00000001L")]
        public const int D3DWRAP_U = 0x00000001;

        [NativeTypeName("#define D3DWRAP_V 0x00000002L")]
        public const int D3DWRAP_V = 0x00000002;

        [NativeTypeName("#define D3DWRAP_W 0x00000004L")]
        public const int D3DWRAP_W = 0x00000004;

        [NativeTypeName("#define D3DWRAPCOORD_0 0x00000001L")]
        public const int D3DWRAPCOORD_0 = 0x00000001;

        [NativeTypeName("#define D3DWRAPCOORD_1 0x00000002L")]
        public const int D3DWRAPCOORD_1 = 0x00000002;

        [NativeTypeName("#define D3DWRAPCOORD_2 0x00000004L")]
        public const int D3DWRAPCOORD_2 = 0x00000004;

        [NativeTypeName("#define D3DWRAPCOORD_3 0x00000008L")]
        public const int D3DWRAPCOORD_3 = 0x00000008;

        [NativeTypeName("#define D3DCOLORWRITEENABLE_RED (1L<<0)")]
        public const int D3DCOLORWRITEENABLE_RED = (1 << 0);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_GREEN (1L<<1)")]
        public const int D3DCOLORWRITEENABLE_GREEN = (1 << 1);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_BLUE (1L<<2)")]
        public const int D3DCOLORWRITEENABLE_BLUE = (1 << 2);

        [NativeTypeName("#define D3DCOLORWRITEENABLE_ALPHA (1L<<3)")]
        public const int D3DCOLORWRITEENABLE_ALPHA = (1 << 3);

        [NativeTypeName("#define D3DDMAPSAMPLER 256")]
        public const int D3DDMAPSAMPLER = 256;

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)")]
        public const int D3DVERTEXTEXTURESAMPLER0 = (256 + 1);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)")]
        public const int D3DVERTEXTEXTURESAMPLER1 = (256 + 2);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)")]
        public const int D3DVERTEXTEXTURESAMPLER2 = (256 + 3);

        [NativeTypeName("#define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)")]
        public const int D3DVERTEXTEXTURESAMPLER3 = (256 + 4);

        [NativeTypeName("#define D3DTSS_TCI_PASSTHRU 0x00000000")]
        public const int D3DTSS_TCI_PASSTHRU = 0x00000000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACENORMAL 0x00010000")]
        public const int D3DTSS_TCI_CAMERASPACENORMAL = 0x00010000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEPOSITION 0x00020000")]
        public const int D3DTSS_TCI_CAMERASPACEPOSITION = 0x00020000;

        [NativeTypeName("#define D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR 0x00030000")]
        public const int D3DTSS_TCI_CAMERASPACEREFLECTIONVECTOR = 0x00030000;

        [NativeTypeName("#define D3DTSS_TCI_SPHEREMAP 0x00040000")]
        public const int D3DTSS_TCI_SPHEREMAP = 0x00040000;

        [NativeTypeName("#define D3DTA_SELECTMASK 0x0000000f")]
        public const int D3DTA_SELECTMASK = 0x0000000f;

        [NativeTypeName("#define D3DTA_DIFFUSE 0x00000000")]
        public const int D3DTA_DIFFUSE = 0x00000000;

        [NativeTypeName("#define D3DTA_CURRENT 0x00000001")]
        public const int D3DTA_CURRENT = 0x00000001;

        [NativeTypeName("#define D3DTA_TEXTURE 0x00000002")]
        public const int D3DTA_TEXTURE = 0x00000002;

        [NativeTypeName("#define D3DTA_TFACTOR 0x00000003")]
        public const int D3DTA_TFACTOR = 0x00000003;

        [NativeTypeName("#define D3DTA_SPECULAR 0x00000004")]
        public const int D3DTA_SPECULAR = 0x00000004;

        [NativeTypeName("#define D3DTA_TEMP 0x00000005")]
        public const int D3DTA_TEMP = 0x00000005;

        [NativeTypeName("#define D3DTA_CONSTANT 0x00000006")]
        public const int D3DTA_CONSTANT = 0x00000006;

        [NativeTypeName("#define D3DTA_COMPLEMENT 0x00000010")]
        public const int D3DTA_COMPLEMENT = 0x00000010;

        [NativeTypeName("#define D3DTA_ALPHAREPLICATE 0x00000020")]
        public const int D3DTA_ALPHAREPLICATE = 0x00000020;

        [NativeTypeName("#define D3DPV_DONOTCOPYDATA (1 << 0)")]
        public const int D3DPV_DONOTCOPYDATA = (1 << 0);

        [NativeTypeName("#define D3DFVF_RESERVED0 0x001")]
        public const int D3DFVF_RESERVED0 = 0x001;

        [NativeTypeName("#define D3DFVF_POSITION_MASK 0x400E")]
        public const int D3DFVF_POSITION_MASK = 0x400E;

        [NativeTypeName("#define D3DFVF_XYZ 0x002")]
        public const int D3DFVF_XYZ = 0x002;

        [NativeTypeName("#define D3DFVF_XYZRHW 0x004")]
        public const int D3DFVF_XYZRHW = 0x004;

        [NativeTypeName("#define D3DFVF_XYZB1 0x006")]
        public const int D3DFVF_XYZB1 = 0x006;

        [NativeTypeName("#define D3DFVF_XYZB2 0x008")]
        public const int D3DFVF_XYZB2 = 0x008;

        [NativeTypeName("#define D3DFVF_XYZB3 0x00a")]
        public const int D3DFVF_XYZB3 = 0x00a;

        [NativeTypeName("#define D3DFVF_XYZB4 0x00c")]
        public const int D3DFVF_XYZB4 = 0x00c;

        [NativeTypeName("#define D3DFVF_XYZB5 0x00e")]
        public const int D3DFVF_XYZB5 = 0x00e;

        [NativeTypeName("#define D3DFVF_XYZW 0x4002")]
        public const int D3DFVF_XYZW = 0x4002;

        [NativeTypeName("#define D3DFVF_NORMAL 0x010")]
        public const int D3DFVF_NORMAL = 0x010;

        [NativeTypeName("#define D3DFVF_PSIZE 0x020")]
        public const int D3DFVF_PSIZE = 0x020;

        [NativeTypeName("#define D3DFVF_DIFFUSE 0x040")]
        public const int D3DFVF_DIFFUSE = 0x040;

        [NativeTypeName("#define D3DFVF_SPECULAR 0x080")]
        public const int D3DFVF_SPECULAR = 0x080;

        [NativeTypeName("#define D3DFVF_TEXCOUNT_MASK 0xf00")]
        public const int D3DFVF_TEXCOUNT_MASK = 0xf00;

        [NativeTypeName("#define D3DFVF_TEXCOUNT_SHIFT 8")]
        public const int D3DFVF_TEXCOUNT_SHIFT = 8;

        [NativeTypeName("#define D3DFVF_TEX0 0x000")]
        public const int D3DFVF_TEX0 = 0x000;

        [NativeTypeName("#define D3DFVF_TEX1 0x100")]
        public const int D3DFVF_TEX1 = 0x100;

        [NativeTypeName("#define D3DFVF_TEX2 0x200")]
        public const int D3DFVF_TEX2 = 0x200;

        [NativeTypeName("#define D3DFVF_TEX3 0x300")]
        public const int D3DFVF_TEX3 = 0x300;

        [NativeTypeName("#define D3DFVF_TEX4 0x400")]
        public const int D3DFVF_TEX4 = 0x400;

        [NativeTypeName("#define D3DFVF_TEX5 0x500")]
        public const int D3DFVF_TEX5 = 0x500;

        [NativeTypeName("#define D3DFVF_TEX6 0x600")]
        public const int D3DFVF_TEX6 = 0x600;

        [NativeTypeName("#define D3DFVF_TEX7 0x700")]
        public const int D3DFVF_TEX7 = 0x700;

        [NativeTypeName("#define D3DFVF_TEX8 0x800")]
        public const int D3DFVF_TEX8 = 0x800;

        [NativeTypeName("#define D3DFVF_LASTBETA_UBYTE4 0x1000")]
        public const int D3DFVF_LASTBETA_UBYTE4 = 0x1000;

        [NativeTypeName("#define D3DFVF_LASTBETA_D3DCOLOR 0x8000")]
        public const int D3DFVF_LASTBETA_D3DCOLOR = 0x8000;

        [NativeTypeName("#define D3DFVF_RESERVED2 0x6000")]
        public const int D3DFVF_RESERVED2 = 0x6000;

        [NativeTypeName("#define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE")]
        public const D3DDECLUSAGE MAXD3DDECLUSAGE = D3DDECLUSAGE_SAMPLE;

        [NativeTypeName("#define MAXD3DDECLUSAGEINDEX 15")]
        public const int MAXD3DDECLUSAGEINDEX = 15;

        [NativeTypeName("#define MAXD3DDECLLENGTH 64")]
        public const int MAXD3DDECLLENGTH = 64;

        [NativeTypeName("#define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED")]
        public const D3DDECLMETHOD MAXD3DDECLMETHOD = D3DDECLMETHOD_LOOKUPPRESAMPLED;

        [NativeTypeName("#define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED")]
        public const D3DDECLTYPE MAXD3DDECLTYPE = D3DDECLTYPE_UNUSED;

        [NativeTypeName("#define D3DDP_MAXTEXCOORD 8")]
        public const int D3DDP_MAXTEXCOORD = 8;

        [NativeTypeName("#define D3DSTREAMSOURCE_INDEXEDDATA (1<<30)")]
        public const int D3DSTREAMSOURCE_INDEXEDDATA = (1 << 30);

        [NativeTypeName("#define D3DSTREAMSOURCE_INSTANCEDATA (2<<30)")]
        public const int D3DSTREAMSOURCE_INSTANCEDATA = (2 << 30);

        [NativeTypeName("#define D3DSI_OPCODE_MASK 0x0000FFFF")]
        public const int D3DSI_OPCODE_MASK = 0x0000FFFF;

        [NativeTypeName("#define D3DSI_INSTLENGTH_MASK 0x0F000000")]
        public const int D3DSI_INSTLENGTH_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSI_INSTLENGTH_SHIFT 24")]
        public const int D3DSI_INSTLENGTH_SHIFT = 24;

        [NativeTypeName("#define D3DSINCOSCONST1 -1.5500992e-006f")]
        public const float D3DSINCOSCONST1 = -1.5500992e-006f;

        [NativeTypeName("#define D3DSINCOSCONST2 -0.020833334f")]
        public const float D3DSINCOSCONST2 = -0.020833334f;

        [NativeTypeName("#define D3DSI_COISSUE 0x40000000")]
        public const int D3DSI_COISSUE = 0x40000000;

        [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_MASK 0x00ff0000")]
        public const int D3DSP_OPCODESPECIFICCONTROL_MASK = 0x00ff0000;

        [NativeTypeName("#define D3DSP_OPCODESPECIFICCONTROL_SHIFT 16")]
        public const int D3DSP_OPCODESPECIFICCONTROL_SHIFT = 16;

        [NativeTypeName("#define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
        public const int D3DSI_TEXLD_PROJECT = (0x01 << 16);

        [NativeTypeName("#define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)")]
        public const int D3DSI_TEXLD_BIAS = (0x02 << 16);

        [NativeTypeName("#define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT")]
        public const int D3DSHADER_COMPARISON_SHIFT = 16;

        [NativeTypeName("#define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)")]
        public const int D3DSHADER_COMPARISON_MASK = (0x7 << 16);

        [NativeTypeName("#define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)")]
        public const int D3DSHADER_INSTRUCTION_PREDICATED = (0x1 << 28);

        [NativeTypeName("#define D3DSP_DCL_USAGE_SHIFT 0")]
        public const int D3DSP_DCL_USAGE_SHIFT = 0;

        [NativeTypeName("#define D3DSP_DCL_USAGE_MASK 0x0000000f")]
        public const int D3DSP_DCL_USAGE_MASK = 0x0000000f;

        [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_SHIFT 16")]
        public const int D3DSP_DCL_USAGEINDEX_SHIFT = 16;

        [NativeTypeName("#define D3DSP_DCL_USAGEINDEX_MASK 0x000f0000")]
        public const int D3DSP_DCL_USAGEINDEX_MASK = 0x000f0000;

        [NativeTypeName("#define D3DSP_TEXTURETYPE_SHIFT 27")]
        public const int D3DSP_TEXTURETYPE_SHIFT = 27;

        [NativeTypeName("#define D3DSP_TEXTURETYPE_MASK 0x78000000")]
        public const int D3DSP_TEXTURETYPE_MASK = 0x78000000;

        [NativeTypeName("#define D3DSP_REGNUM_MASK 0x000007FF")]
        public const int D3DSP_REGNUM_MASK = 0x000007FF;

        [NativeTypeName("#define D3DSP_WRITEMASK_0 0x00010000")]
        public const int D3DSP_WRITEMASK_0 = 0x00010000;

        [NativeTypeName("#define D3DSP_WRITEMASK_1 0x00020000")]
        public const int D3DSP_WRITEMASK_1 = 0x00020000;

        [NativeTypeName("#define D3DSP_WRITEMASK_2 0x00040000")]
        public const int D3DSP_WRITEMASK_2 = 0x00040000;

        [NativeTypeName("#define D3DSP_WRITEMASK_3 0x00080000")]
        public const int D3DSP_WRITEMASK_3 = 0x00080000;

        [NativeTypeName("#define D3DSP_WRITEMASK_ALL 0x000F0000")]
        public const int D3DSP_WRITEMASK_ALL = 0x000F0000;

        [NativeTypeName("#define D3DSP_DSTMOD_SHIFT 20")]
        public const int D3DSP_DSTMOD_SHIFT = 20;

        [NativeTypeName("#define D3DSP_DSTMOD_MASK 0x00F00000")]
        public const int D3DSP_DSTMOD_MASK = 0x00F00000;

        [NativeTypeName("#define D3DSPDM_NONE (0<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_NONE = (0 << 20);

        [NativeTypeName("#define D3DSPDM_SATURATE (1<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_SATURATE = (1 << 20);

        [NativeTypeName("#define D3DSPDM_PARTIALPRECISION (2<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_PARTIALPRECISION = (2 << 20);

        [NativeTypeName("#define D3DSPDM_MSAMPCENTROID (4<<D3DSP_DSTMOD_SHIFT)")]
        public const int D3DSPDM_MSAMPCENTROID = (4 << 20);

        [NativeTypeName("#define D3DSP_DSTSHIFT_SHIFT 24")]
        public const int D3DSP_DSTSHIFT_SHIFT = 24;

        [NativeTypeName("#define D3DSP_DSTSHIFT_MASK 0x0F000000")]
        public const int D3DSP_DSTSHIFT_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSP_REGTYPE_SHIFT 28")]
        public const int D3DSP_REGTYPE_SHIFT = 28;

        [NativeTypeName("#define D3DSP_REGTYPE_SHIFT2 8")]
        public const int D3DSP_REGTYPE_SHIFT2 = 8;

        [NativeTypeName("#define D3DSP_REGTYPE_MASK 0x70000000")]
        public const int D3DSP_REGTYPE_MASK = 0x70000000;

        [NativeTypeName("#define D3DSP_REGTYPE_MASK2 0x00001800")]
        public const int D3DSP_REGTYPE_MASK2 = 0x00001800;

        [NativeTypeName("#define D3DVS_ADDRESSMODE_SHIFT 13")]
        public const int D3DVS_ADDRESSMODE_SHIFT = 13;

        [NativeTypeName("#define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)")]
        public const int D3DVS_ADDRESSMODE_MASK = (1 << 13);

        [NativeTypeName("#define D3DSHADER_ADDRESSMODE_SHIFT 13")]
        public const int D3DSHADER_ADDRESSMODE_SHIFT = 13;

        [NativeTypeName("#define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)")]
        public const int D3DSHADER_ADDRESSMODE_MASK = (1 << 13);

        [NativeTypeName("#define D3DVS_SWIZZLE_SHIFT 16")]
        public const int D3DVS_SWIZZLE_SHIFT = 16;

        [NativeTypeName("#define D3DVS_SWIZZLE_MASK 0x00FF0000")]
        public const int D3DVS_SWIZZLE_MASK = 0x00FF0000;

        [NativeTypeName("#define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_X = (0 << 16);

        [NativeTypeName("#define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_Y = (1 << 16);

        [NativeTypeName("#define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_Z = (2 << 16);

        [NativeTypeName("#define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)")]
        public const int D3DVS_X_W = (3 << 16);

        [NativeTypeName("#define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_X = (0 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_Y = (1 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_Z = (2 << (16 + 2));

        [NativeTypeName("#define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))")]
        public const int D3DVS_Y_W = (3 << (16 + 2));

        [NativeTypeName("#define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_X = (0 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_Y = (1 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_Z = (2 << (16 + 4));

        [NativeTypeName("#define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))")]
        public const int D3DVS_Z_W = (3 << (16 + 4));

        [NativeTypeName("#define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_X = (0 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_Y = (1 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_Z = (2 << (16 + 6));

        [NativeTypeName("#define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))")]
        public const int D3DVS_W_W = (3 << (16 + 6));

        [NativeTypeName("#define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)")]
        public const int D3DVS_NOSWIZZLE = ((0 << 16) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_SWIZZLE_SHIFT 16")]
        public const int D3DSP_SWIZZLE_SHIFT = 16;

        [NativeTypeName("#define D3DSP_SWIZZLE_MASK 0x00FF0000")]
        public const int D3DSP_SWIZZLE_MASK = 0x00FF0000;

        [NativeTypeName("#define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_NOSWIZZLE = ((0 << (16 + 0)) | (1 << (16 + 2)) | (2 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATERED = ((0 << (16 + 0)) | (0 << (16 + 2)) | (0 << (16 + 4)) | (0 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEGREEN = ((1 << (16 + 0)) | (1 << (16 + 2)) | (1 << (16 + 4)) | (1 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEBLUE = ((2 << (16 + 0)) | (2 << (16 + 2)) | (2 << (16 + 4)) | (2 << (16 + 6)));

        [NativeTypeName("#define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | \\\r\n      (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )")]
        public const int D3DSP_REPLICATEALPHA = ((3 << (16 + 0)) | (3 << (16 + 2)) | (3 << (16 + 4)) | (3 << (16 + 6)));

        [NativeTypeName("#define D3DSP_SRCMOD_SHIFT 24")]
        public const int D3DSP_SRCMOD_SHIFT = 24;

        [NativeTypeName("#define D3DSP_SRCMOD_MASK 0x0F000000")]
        public const int D3DSP_SRCMOD_MASK = 0x0F000000;

        [NativeTypeName("#define D3DSP_MIN_PRECISION_SHIFT 14")]
        public const int D3DSP_MIN_PRECISION_SHIFT = 14;

        [NativeTypeName("#define D3DSP_MIN_PRECISION_MASK 0x0000C000")]
        public const int D3DSP_MIN_PRECISION_MASK = 0x0000C000;

        [NativeTypeName("#define D3DSI_COMMENTSIZE_SHIFT 16")]
        public const int D3DSI_COMMENTSIZE_SHIFT = 16;

        [NativeTypeName("#define D3DSI_COMMENTSIZE_MASK 0x7FFF0000")]
        public const int D3DSI_COMMENTSIZE_MASK = 0x7FFF0000;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT2 0")]
        public const int D3DFVF_TEXTUREFORMAT2 = 0;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT1 3")]
        public const int D3DFVF_TEXTUREFORMAT1 = 3;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT3 1")]
        public const int D3DFVF_TEXTUREFORMAT3 = 1;

        [NativeTypeName("#define D3DFVF_TEXTUREFORMAT4 2")]
        public const int D3DFVF_TEXTUREFORMAT4 = 2;

        [NativeTypeName("#define D3DPRESENT_RATE_DEFAULT 0x00000000")]
        public const int D3DPRESENT_RATE_DEFAULT = 0x00000000;

        [NativeTypeName("#define D3DPRESENTFLAG_LOCKABLE_BACKBUFFER 0x00000001")]
        public const int D3DPRESENTFLAG_LOCKABLE_BACKBUFFER = 0x00000001;

        [NativeTypeName("#define D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL 0x00000002")]
        public const int D3DPRESENTFLAG_DISCARD_DEPTHSTENCIL = 0x00000002;

        [NativeTypeName("#define D3DPRESENTFLAG_DEVICECLIP 0x00000004")]
        public const int D3DPRESENTFLAG_DEVICECLIP = 0x00000004;

        [NativeTypeName("#define D3DPRESENTFLAG_VIDEO 0x00000010")]
        public const int D3DPRESENTFLAG_VIDEO = 0x00000010;

        [NativeTypeName("#define D3DPRESENTFLAG_NOAUTOROTATE 0x00000020")]
        public const int D3DPRESENTFLAG_NOAUTOROTATE = 0x00000020;

        [NativeTypeName("#define D3DPRESENTFLAG_UNPRUNEDMODE 0x00000040")]
        public const int D3DPRESENTFLAG_UNPRUNEDMODE = 0x00000040;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_LIMITEDRGB 0x00000080")]
        public const int D3DPRESENTFLAG_OVERLAY_LIMITEDRGB = 0x00000080;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 0x00000100")]
        public const int D3DPRESENTFLAG_OVERLAY_YCbCr_BT709 = 0x00000100;

        [NativeTypeName("#define D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC 0x00000200")]
        public const int D3DPRESENTFLAG_OVERLAY_YCbCr_xvYCC = 0x00000200;

        [NativeTypeName("#define D3DPRESENTFLAG_RESTRICTED_CONTENT 0x00000400")]
        public const int D3DPRESENTFLAG_RESTRICTED_CONTENT = 0x00000400;

        [NativeTypeName("#define D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER 0x00000800")]
        public const int D3DPRESENTFLAG_RESTRICT_SHARED_RESOURCE_DRIVER = 0x00000800;

        [NativeTypeName("#define D3DUSAGE_RENDERTARGET (0x00000001L)")]
        public const int D3DUSAGE_RENDERTARGET = (0x00000001);

        [NativeTypeName("#define D3DUSAGE_DEPTHSTENCIL (0x00000002L)")]
        public const int D3DUSAGE_DEPTHSTENCIL = (0x00000002);

        [NativeTypeName("#define D3DUSAGE_DYNAMIC (0x00000200L)")]
        public const int D3DUSAGE_DYNAMIC = (0x00000200);

        [NativeTypeName("#define D3DUSAGE_NONSECURE (0x00800000L)")]
        public const int D3DUSAGE_NONSECURE = (0x00800000);

        [NativeTypeName("#define D3DUSAGE_AUTOGENMIPMAP (0x00000400L)")]
        public const int D3DUSAGE_AUTOGENMIPMAP = (0x00000400);

        [NativeTypeName("#define D3DUSAGE_DMAP (0x00004000L)")]
        public const int D3DUSAGE_DMAP = (0x00004000);

        [NativeTypeName("#define D3DUSAGE_QUERY_LEGACYBUMPMAP (0x00008000L)")]
        public const int D3DUSAGE_QUERY_LEGACYBUMPMAP = (0x00008000);

        [NativeTypeName("#define D3DUSAGE_QUERY_SRGBREAD (0x00010000L)")]
        public const int D3DUSAGE_QUERY_SRGBREAD = (0x00010000);

        [NativeTypeName("#define D3DUSAGE_QUERY_FILTER (0x00020000L)")]
        public const int D3DUSAGE_QUERY_FILTER = (0x00020000);

        [NativeTypeName("#define D3DUSAGE_QUERY_SRGBWRITE (0x00040000L)")]
        public const int D3DUSAGE_QUERY_SRGBWRITE = (0x00040000);

        [NativeTypeName("#define D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING (0x00080000L)")]
        public const int D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING = (0x00080000);

        [NativeTypeName("#define D3DUSAGE_QUERY_VERTEXTEXTURE (0x00100000L)")]
        public const int D3DUSAGE_QUERY_VERTEXTEXTURE = (0x00100000);

        [NativeTypeName("#define D3DUSAGE_QUERY_WRAPANDMIP (0x00200000L)")]
        public const int D3DUSAGE_QUERY_WRAPANDMIP = (0x00200000);

        [NativeTypeName("#define D3DUSAGE_WRITEONLY (0x00000008L)")]
        public const int D3DUSAGE_WRITEONLY = (0x00000008);

        [NativeTypeName("#define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)")]
        public const int D3DUSAGE_SOFTWAREPROCESSING = (0x00000010);

        [NativeTypeName("#define D3DUSAGE_DONOTCLIP (0x00000020L)")]
        public const int D3DUSAGE_DONOTCLIP = (0x00000020);

        [NativeTypeName("#define D3DUSAGE_POINTS (0x00000040L)")]
        public const int D3DUSAGE_POINTS = (0x00000040);

        [NativeTypeName("#define D3DUSAGE_RTPATCHES (0x00000080L)")]
        public const int D3DUSAGE_RTPATCHES = (0x00000080);

        [NativeTypeName("#define D3DUSAGE_NPATCHES (0x00000100L)")]
        public const int D3DUSAGE_NPATCHES = (0x00000100);

        [NativeTypeName("#define D3DUSAGE_TEXTAPI (0x10000000L)")]
        public const int D3DUSAGE_TEXTAPI = (0x10000000);

        [NativeTypeName("#define D3DUSAGE_RESTRICTED_CONTENT (0x00000800L)")]
        public const int D3DUSAGE_RESTRICTED_CONTENT = (0x00000800);

        [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE (0x00002000L)")]
        public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE = (0x00002000);

        [NativeTypeName("#define D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER (0x00001000L)")]
        public const int D3DUSAGE_RESTRICT_SHARED_RESOURCE_DRIVER = (0x00001000);

        [NativeTypeName("#define D3DLOCK_READONLY 0x00000010L")]
        public const int D3DLOCK_READONLY = 0x00000010;

        [NativeTypeName("#define D3DLOCK_DISCARD 0x00002000L")]
        public const int D3DLOCK_DISCARD = 0x00002000;

        [NativeTypeName("#define D3DLOCK_NOOVERWRITE 0x00001000L")]
        public const int D3DLOCK_NOOVERWRITE = 0x00001000;

        [NativeTypeName("#define D3DLOCK_NOSYSLOCK 0x00000800L")]
        public const int D3DLOCK_NOSYSLOCK = 0x00000800;

        [NativeTypeName("#define D3DLOCK_DONOTWAIT 0x00004000L")]
        public const int D3DLOCK_DONOTWAIT = 0x00004000;

        [NativeTypeName("#define D3DLOCK_NO_DIRTY_UPDATE 0x00008000L")]
        public const int D3DLOCK_NO_DIRTY_UPDATE = 0x00008000;

        [NativeTypeName("#define MAX_DEVICE_IDENTIFIER_STRING 512")]
        public const int MAX_DEVICE_IDENTIFIER_STRING = 512;

        [NativeTypeName("#define D3DISSUE_END (1 << 0)")]
        public const int D3DISSUE_END = (1 << 0);

        [NativeTypeName("#define D3DISSUE_BEGIN (1 << 1)")]
        public const int D3DISSUE_BEGIN = (1 << 1);

        [NativeTypeName("#define D3DGETDATA_FLUSH (1 << 0)")]
        public const int D3DGETDATA_FLUSH = (1 << 0);

        [NativeTypeName("#define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)")]
        public const int D3DRTYPECOUNT = ((int)(D3DRTYPE_INDEXBUFFER) + 1);

        [NativeTypeName("#define D3DCOMPOSERECTS_MAXNUMRECTS 0xFFFF")]
        public const int D3DCOMPOSERECTS_MAXNUMRECTS = 0xFFFF;

        [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXWIDTH 7")]
        public const int D3DCONVOLUTIONMONO_MAXWIDTH = 7;

        [NativeTypeName("#define D3DCONVOLUTIONMONO_MAXHEIGHT D3DCONVOLUTIONMONO_MAXWIDTH")]
        public const int D3DCONVOLUTIONMONO_MAXHEIGHT = 7;

        [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXWIDTH 8192")]
        public const int D3DFMT_A1_SURFACE_MAXWIDTH = 8192;

        [NativeTypeName("#define D3DFMT_A1_SURFACE_MAXHEIGHT 2048")]
        public const int D3DFMT_A1_SURFACE_MAXHEIGHT = 2048;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MINIMUM 0x28000000")]
        public const int D3D9_RESOURCE_PRIORITY_MINIMUM = 0x28000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_LOW 0x50000000")]
        public const int D3D9_RESOURCE_PRIORITY_LOW = 0x50000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_NORMAL 0x78000000")]
        public const int D3D9_RESOURCE_PRIORITY_NORMAL = 0x78000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_HIGH 0xa0000000")]
        public const uint D3D9_RESOURCE_PRIORITY_HIGH = 0xa0000000;

        [NativeTypeName("#define D3D9_RESOURCE_PRIORITY_MAXIMUM 0xc8000000")]
        public const uint D3D9_RESOURCE_PRIORITY_MAXIMUM = 0xc8000000;

        [NativeTypeName("#define D3D_OMAC_SIZE 16")]
        public const int D3D_OMAC_SIZE = 16;
    }
}
