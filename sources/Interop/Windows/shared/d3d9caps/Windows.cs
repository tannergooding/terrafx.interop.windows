// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid D3DCRYPTOTYPE_AES128_CTR = new Guid(0x9b6bd711, 0x4f74, 0x41c9, 0x9e, 0x7b, 0xb, 0xe2, 0xd7, 0xd9, 0x3b, 0x4f);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DCRYPTOTYPE_PROPRIETARY = new Guid(0xab4e9afd, 0x1d1c, 0x46e6, 0xa7, 0x2f, 0x8, 0x69, 0x91, 0x7b, 0xd, 0xe8);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DKEYEXCHANGE_RSAES_OAEP = new Guid(0xc1949895, 0xd72a, 0x4a1d, 0x8e, 0x5d, 0xed, 0x85, 0x7d, 0x17, 0x15, 0x20);

        [NativeTypeName("const GUID")]
        public static readonly Guid D3DKEYEXCHANGE_DXVA = new Guid(0x43d3775c, 0x38e5, 0x4924, 0x8d, 0x86, 0xd3, 0xfc, 0xcf, 0x15, 0x3e, 0x9b);

        [NativeTypeName("#define D3DVS20CAPS_PREDICATION (1<<0)")]
        public const int D3DVS20CAPS_PREDICATION = (1 << 0);

        [NativeTypeName("#define D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH 24")]
        public const int D3DVS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;

        [NativeTypeName("#define D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH 0")]
        public const int D3DVS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DVS20_MAX_NUMTEMPS 32")]
        public const int D3DVS20_MAX_NUMTEMPS = 32;

        [NativeTypeName("#define D3DVS20_MIN_NUMTEMPS 12")]
        public const int D3DVS20_MIN_NUMTEMPS = 12;

        [NativeTypeName("#define D3DVS20_MAX_STATICFLOWCONTROLDEPTH 4")]
        public const int D3DVS20_MAX_STATICFLOWCONTROLDEPTH = 4;

        [NativeTypeName("#define D3DVS20_MIN_STATICFLOWCONTROLDEPTH 1")]
        public const int D3DVS20_MIN_STATICFLOWCONTROLDEPTH = 1;

        [NativeTypeName("#define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)")]
        public const int D3DPS20CAPS_ARBITRARYSWIZZLE = (1 << 0);

        [NativeTypeName("#define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)")]
        public const int D3DPS20CAPS_GRADIENTINSTRUCTIONS = (1 << 1);

        [NativeTypeName("#define D3DPS20CAPS_PREDICATION (1<<2)")]
        public const int D3DPS20CAPS_PREDICATION = (1 << 2);

        [NativeTypeName("#define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)")]
        public const int D3DPS20CAPS_NODEPENDENTREADLIMIT = (1 << 3);

        [NativeTypeName("#define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)")]
        public const int D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT = (1 << 4);

        [NativeTypeName("#define D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH 24")]
        public const int D3DPS20_MAX_DYNAMICFLOWCONTROLDEPTH = 24;

        [NativeTypeName("#define D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH 0")]
        public const int D3DPS20_MIN_DYNAMICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DPS20_MAX_NUMTEMPS 32")]
        public const int D3DPS20_MAX_NUMTEMPS = 32;

        [NativeTypeName("#define D3DPS20_MIN_NUMTEMPS 12")]
        public const int D3DPS20_MIN_NUMTEMPS = 12;

        [NativeTypeName("#define D3DPS20_MAX_STATICFLOWCONTROLDEPTH 4")]
        public const int D3DPS20_MAX_STATICFLOWCONTROLDEPTH = 4;

        [NativeTypeName("#define D3DPS20_MIN_STATICFLOWCONTROLDEPTH 0")]
        public const int D3DPS20_MIN_STATICFLOWCONTROLDEPTH = 0;

        [NativeTypeName("#define D3DPS20_MAX_NUMINSTRUCTIONSLOTS 512")]
        public const int D3DPS20_MAX_NUMINSTRUCTIONSLOTS = 512;

        [NativeTypeName("#define D3DPS20_MIN_NUMINSTRUCTIONSLOTS 96")]
        public const int D3DPS20_MIN_NUMINSTRUCTIONSLOTS = 96;

        [NativeTypeName("#define D3DMIN30SHADERINSTRUCTIONS 512")]
        public const int D3DMIN30SHADERINSTRUCTIONS = 512;

        [NativeTypeName("#define D3DMAX30SHADERINSTRUCTIONS 32768")]
        public const int D3DMAX30SHADERINSTRUCTIONS = 32768;

        [NativeTypeName("#define D3DOVERLAYCAPS_FULLRANGERGB 0x00000001")]
        public const int D3DOVERLAYCAPS_FULLRANGERGB = 0x00000001;

        [NativeTypeName("#define D3DOVERLAYCAPS_LIMITEDRANGERGB 0x00000002")]
        public const int D3DOVERLAYCAPS_LIMITEDRANGERGB = 0x00000002;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601 0x00000004")]
        public const int D3DOVERLAYCAPS_YCbCr_BT601 = 0x00000004;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709 0x00000008")]
        public const int D3DOVERLAYCAPS_YCbCr_BT709 = 0x00000008;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT601_xvYCC 0x00000010")]
        public const int D3DOVERLAYCAPS_YCbCr_BT601_xvYCC = 0x00000010;

        [NativeTypeName("#define D3DOVERLAYCAPS_YCbCr_BT709_xvYCC 0x00000020")]
        public const int D3DOVERLAYCAPS_YCbCr_BT709_xvYCC = 0x00000020;

        [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHX 0x00000040")]
        public const int D3DOVERLAYCAPS_STRETCHX = 0x00000040;

        [NativeTypeName("#define D3DOVERLAYCAPS_STRETCHY 0x00000080")]
        public const int D3DOVERLAYCAPS_STRETCHY = 0x00000080;

        [NativeTypeName("#define D3DCPCAPS_SOFTWARE 0x00000001")]
        public const int D3DCPCAPS_SOFTWARE = 0x00000001;

        [NativeTypeName("#define D3DCPCAPS_HARDWARE 0x00000002")]
        public const int D3DCPCAPS_HARDWARE = 0x00000002;

        [NativeTypeName("#define D3DCPCAPS_PROTECTIONALWAYSON 0x00000004")]
        public const int D3DCPCAPS_PROTECTIONALWAYSON = 0x00000004;

        [NativeTypeName("#define D3DCPCAPS_PARTIALDECRYPTION 0x00000008")]
        public const int D3DCPCAPS_PARTIALDECRYPTION = 0x00000008;

        [NativeTypeName("#define D3DCPCAPS_CONTENTKEY 0x00000010")]
        public const int D3DCPCAPS_CONTENTKEY = 0x00000010;

        [NativeTypeName("#define D3DCPCAPS_FRESHENSESSIONKEY 0x00000020")]
        public const int D3DCPCAPS_FRESHENSESSIONKEY = 0x00000020;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACK 0x00000040")]
        public const int D3DCPCAPS_ENCRYPTEDREADBACK = 0x00000040;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTEDREADBACKKEY 0x00000080")]
        public const int D3DCPCAPS_ENCRYPTEDREADBACKKEY = 0x00000080;

        [NativeTypeName("#define D3DCPCAPS_SEQUENTIAL_CTR_IV 0x00000100")]
        public const int D3DCPCAPS_SEQUENTIAL_CTR_IV = 0x00000100;

        [NativeTypeName("#define D3DCPCAPS_ENCRYPTSLICEDATAONLY 0x00000200")]
        public const int D3DCPCAPS_ENCRYPTSLICEDATAONLY = 0x00000200;

        [NativeTypeName("#define D3DCAPS_OVERLAY 0x00000800L")]
        public const int D3DCAPS_OVERLAY = 0x00000800;

        [NativeTypeName("#define D3DCAPS_READ_SCANLINE 0x00020000L")]
        public const int D3DCAPS_READ_SCANLINE = 0x00020000;

        [NativeTypeName("#define D3DCAPS2_FULLSCREENGAMMA 0x00020000L")]
        public const int D3DCAPS2_FULLSCREENGAMMA = 0x00020000;

        [NativeTypeName("#define D3DCAPS2_CANCALIBRATEGAMMA 0x00100000L")]
        public const int D3DCAPS2_CANCALIBRATEGAMMA = 0x00100000;

        [NativeTypeName("#define D3DCAPS2_RESERVED 0x02000000L")]
        public const int D3DCAPS2_RESERVED = 0x02000000;

        [NativeTypeName("#define D3DCAPS2_CANMANAGERESOURCE 0x10000000L")]
        public const int D3DCAPS2_CANMANAGERESOURCE = 0x10000000;

        [NativeTypeName("#define D3DCAPS2_DYNAMICTEXTURES 0x20000000L")]
        public const int D3DCAPS2_DYNAMICTEXTURES = 0x20000000;

        [NativeTypeName("#define D3DCAPS2_CANAUTOGENMIPMAP 0x40000000L")]
        public const int D3DCAPS2_CANAUTOGENMIPMAP = 0x40000000;

        [NativeTypeName("#define D3DCAPS2_CANSHARERESOURCE 0x80000000L")]
        public const uint D3DCAPS2_CANSHARERESOURCE = 0x80000000;

        [NativeTypeName("#define D3DCAPS3_RESERVED 0x8000001fL")]
        public const uint D3DCAPS3_RESERVED = 0x8000001f;

        [NativeTypeName("#define D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD 0x00000020L")]
        public const int D3DCAPS3_ALPHA_FULLSCREEN_FLIP_OR_DISCARD = 0x00000020;

        [NativeTypeName("#define D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION 0x00000080L")]
        public const int D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION = 0x00000080;

        [NativeTypeName("#define D3DCAPS3_COPY_TO_VIDMEM 0x00000100L")]
        public const int D3DCAPS3_COPY_TO_VIDMEM = 0x00000100;

        [NativeTypeName("#define D3DCAPS3_COPY_TO_SYSTEMMEM 0x00000200L")]
        public const int D3DCAPS3_COPY_TO_SYSTEMMEM = 0x00000200;

        [NativeTypeName("#define D3DCAPS3_DXVAHD 0x00000400L")]
        public const int D3DCAPS3_DXVAHD = 0x00000400;

        [NativeTypeName("#define D3DCAPS3_DXVAHD_LIMITED 0x00000800L")]
        public const int D3DCAPS3_DXVAHD_LIMITED = 0x00000800;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_DEFAULT 0x00000000L")]
        public const int D3DPRESENT_INTERVAL_DEFAULT = 0x00000000;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_ONE 0x00000001L")]
        public const int D3DPRESENT_INTERVAL_ONE = 0x00000001;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_TWO 0x00000002L")]
        public const int D3DPRESENT_INTERVAL_TWO = 0x00000002;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_THREE 0x00000004L")]
        public const int D3DPRESENT_INTERVAL_THREE = 0x00000004;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_FOUR 0x00000008L")]
        public const int D3DPRESENT_INTERVAL_FOUR = 0x00000008;

        [NativeTypeName("#define D3DPRESENT_INTERVAL_IMMEDIATE 0x80000000L")]
        public const uint D3DPRESENT_INTERVAL_IMMEDIATE = 0x80000000;

        [NativeTypeName("#define D3DCURSORCAPS_COLOR 0x00000001L")]
        public const int D3DCURSORCAPS_COLOR = 0x00000001;

        [NativeTypeName("#define D3DCURSORCAPS_LOWRES 0x00000002L")]
        public const int D3DCURSORCAPS_LOWRES = 0x00000002;

        [NativeTypeName("#define D3DDEVCAPS_EXECUTESYSTEMMEMORY 0x00000010L")]
        public const int D3DDEVCAPS_EXECUTESYSTEMMEMORY = 0x00000010;

        [NativeTypeName("#define D3DDEVCAPS_EXECUTEVIDEOMEMORY 0x00000020L")]
        public const int D3DDEVCAPS_EXECUTEVIDEOMEMORY = 0x00000020;

        [NativeTypeName("#define D3DDEVCAPS_TLVERTEXSYSTEMMEMORY 0x00000040L")]
        public const int D3DDEVCAPS_TLVERTEXSYSTEMMEMORY = 0x00000040;

        [NativeTypeName("#define D3DDEVCAPS_TLVERTEXVIDEOMEMORY 0x00000080L")]
        public const int D3DDEVCAPS_TLVERTEXVIDEOMEMORY = 0x00000080;

        [NativeTypeName("#define D3DDEVCAPS_TEXTURESYSTEMMEMORY 0x00000100L")]
        public const int D3DDEVCAPS_TEXTURESYSTEMMEMORY = 0x00000100;

        [NativeTypeName("#define D3DDEVCAPS_TEXTUREVIDEOMEMORY 0x00000200L")]
        public const int D3DDEVCAPS_TEXTUREVIDEOMEMORY = 0x00000200;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMTLVERTEX 0x00000400L")]
        public const int D3DDEVCAPS_DRAWPRIMTLVERTEX = 0x00000400;

        [NativeTypeName("#define D3DDEVCAPS_CANRENDERAFTERFLIP 0x00000800L")]
        public const int D3DDEVCAPS_CANRENDERAFTERFLIP = 0x00000800;

        [NativeTypeName("#define D3DDEVCAPS_TEXTURENONLOCALVIDMEM 0x00001000L")]
        public const int D3DDEVCAPS_TEXTURENONLOCALVIDMEM = 0x00001000;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2 0x00002000L")]
        public const int D3DDEVCAPS_DRAWPRIMITIVES2 = 0x00002000;

        [NativeTypeName("#define D3DDEVCAPS_SEPARATETEXTUREMEMORIES 0x00004000L")]
        public const int D3DDEVCAPS_SEPARATETEXTUREMEMORIES = 0x00004000;

        [NativeTypeName("#define D3DDEVCAPS_DRAWPRIMITIVES2EX 0x00008000L")]
        public const int D3DDEVCAPS_DRAWPRIMITIVES2EX = 0x00008000;

        [NativeTypeName("#define D3DDEVCAPS_HWTRANSFORMANDLIGHT 0x00010000L")]
        public const int D3DDEVCAPS_HWTRANSFORMANDLIGHT = 0x00010000;

        [NativeTypeName("#define D3DDEVCAPS_CANBLTSYSTONONLOCAL 0x00020000L")]
        public const int D3DDEVCAPS_CANBLTSYSTONONLOCAL = 0x00020000;

        [NativeTypeName("#define D3DDEVCAPS_HWRASTERIZATION 0x00080000L")]
        public const int D3DDEVCAPS_HWRASTERIZATION = 0x00080000;

        [NativeTypeName("#define D3DDEVCAPS_PUREDEVICE 0x00100000L")]
        public const int D3DDEVCAPS_PUREDEVICE = 0x00100000;

        [NativeTypeName("#define D3DDEVCAPS_QUINTICRTPATCHES 0x00200000L")]
        public const int D3DDEVCAPS_QUINTICRTPATCHES = 0x00200000;

        [NativeTypeName("#define D3DDEVCAPS_RTPATCHES 0x00400000L")]
        public const int D3DDEVCAPS_RTPATCHES = 0x00400000;

        [NativeTypeName("#define D3DDEVCAPS_RTPATCHHANDLEZERO 0x00800000L")]
        public const int D3DDEVCAPS_RTPATCHHANDLEZERO = 0x00800000;

        [NativeTypeName("#define D3DDEVCAPS_NPATCHES 0x01000000L")]
        public const int D3DDEVCAPS_NPATCHES = 0x01000000;

        [NativeTypeName("#define D3DPMISCCAPS_MASKZ 0x00000002L")]
        public const int D3DPMISCCAPS_MASKZ = 0x00000002;

        [NativeTypeName("#define D3DPMISCCAPS_CULLNONE 0x00000010L")]
        public const int D3DPMISCCAPS_CULLNONE = 0x00000010;

        [NativeTypeName("#define D3DPMISCCAPS_CULLCW 0x00000020L")]
        public const int D3DPMISCCAPS_CULLCW = 0x00000020;

        [NativeTypeName("#define D3DPMISCCAPS_CULLCCW 0x00000040L")]
        public const int D3DPMISCCAPS_CULLCCW = 0x00000040;

        [NativeTypeName("#define D3DPMISCCAPS_COLORWRITEENABLE 0x00000080L")]
        public const int D3DPMISCCAPS_COLORWRITEENABLE = 0x00000080;

        [NativeTypeName("#define D3DPMISCCAPS_CLIPPLANESCALEDPOINTS 0x00000100L")]
        public const int D3DPMISCCAPS_CLIPPLANESCALEDPOINTS = 0x00000100;

        [NativeTypeName("#define D3DPMISCCAPS_CLIPTLVERTS 0x00000200L")]
        public const int D3DPMISCCAPS_CLIPTLVERTS = 0x00000200;

        [NativeTypeName("#define D3DPMISCCAPS_TSSARGTEMP 0x00000400L")]
        public const int D3DPMISCCAPS_TSSARGTEMP = 0x00000400;

        [NativeTypeName("#define D3DPMISCCAPS_BLENDOP 0x00000800L")]
        public const int D3DPMISCCAPS_BLENDOP = 0x00000800;

        [NativeTypeName("#define D3DPMISCCAPS_NULLREFERENCE 0x00001000L")]
        public const int D3DPMISCCAPS_NULLREFERENCE = 0x00001000;

        [NativeTypeName("#define D3DPMISCCAPS_INDEPENDENTWRITEMASKS 0x00004000L")]
        public const int D3DPMISCCAPS_INDEPENDENTWRITEMASKS = 0x00004000;

        [NativeTypeName("#define D3DPMISCCAPS_PERSTAGECONSTANT 0x00008000L")]
        public const int D3DPMISCCAPS_PERSTAGECONSTANT = 0x00008000;

        [NativeTypeName("#define D3DPMISCCAPS_FOGANDSPECULARALPHA 0x00010000L")]
        public const int D3DPMISCCAPS_FOGANDSPECULARALPHA = 0x00010000;

        [NativeTypeName("#define D3DPMISCCAPS_SEPARATEALPHABLEND 0x00020000L")]
        public const int D3DPMISCCAPS_SEPARATEALPHABLEND = 0x00020000;

        [NativeTypeName("#define D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS 0x00040000L")]
        public const int D3DPMISCCAPS_MRTINDEPENDENTBITDEPTHS = 0x00040000;

        [NativeTypeName("#define D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING 0x00080000L")]
        public const int D3DPMISCCAPS_MRTPOSTPIXELSHADERBLENDING = 0x00080000;

        [NativeTypeName("#define D3DPMISCCAPS_FOGVERTEXCLAMPED 0x00100000L")]
        public const int D3DPMISCCAPS_FOGVERTEXCLAMPED = 0x00100000;

        [NativeTypeName("#define D3DPMISCCAPS_POSTBLENDSRGBCONVERT 0x00200000L")]
        public const int D3DPMISCCAPS_POSTBLENDSRGBCONVERT = 0x00200000;

        [NativeTypeName("#define D3DLINECAPS_TEXTURE 0x00000001L")]
        public const int D3DLINECAPS_TEXTURE = 0x00000001;

        [NativeTypeName("#define D3DLINECAPS_ZTEST 0x00000002L")]
        public const int D3DLINECAPS_ZTEST = 0x00000002;

        [NativeTypeName("#define D3DLINECAPS_BLEND 0x00000004L")]
        public const int D3DLINECAPS_BLEND = 0x00000004;

        [NativeTypeName("#define D3DLINECAPS_ALPHACMP 0x00000008L")]
        public const int D3DLINECAPS_ALPHACMP = 0x00000008;

        [NativeTypeName("#define D3DLINECAPS_FOG 0x00000010L")]
        public const int D3DLINECAPS_FOG = 0x00000010;

        [NativeTypeName("#define D3DLINECAPS_ANTIALIAS 0x00000020L")]
        public const int D3DLINECAPS_ANTIALIAS = 0x00000020;

        [NativeTypeName("#define D3DPRASTERCAPS_DITHER 0x00000001L")]
        public const int D3DPRASTERCAPS_DITHER = 0x00000001;

        [NativeTypeName("#define D3DPRASTERCAPS_ZTEST 0x00000010L")]
        public const int D3DPRASTERCAPS_ZTEST = 0x00000010;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGVERTEX 0x00000080L")]
        public const int D3DPRASTERCAPS_FOGVERTEX = 0x00000080;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGTABLE 0x00000100L")]
        public const int D3DPRASTERCAPS_FOGTABLE = 0x00000100;

        [NativeTypeName("#define D3DPRASTERCAPS_MIPMAPLODBIAS 0x00002000L")]
        public const int D3DPRASTERCAPS_MIPMAPLODBIAS = 0x00002000;

        [NativeTypeName("#define D3DPRASTERCAPS_ZBUFFERLESSHSR 0x00008000L")]
        public const int D3DPRASTERCAPS_ZBUFFERLESSHSR = 0x00008000;

        [NativeTypeName("#define D3DPRASTERCAPS_FOGRANGE 0x00010000L")]
        public const int D3DPRASTERCAPS_FOGRANGE = 0x00010000;

        [NativeTypeName("#define D3DPRASTERCAPS_ANISOTROPY 0x00020000L")]
        public const int D3DPRASTERCAPS_ANISOTROPY = 0x00020000;

        [NativeTypeName("#define D3DPRASTERCAPS_WBUFFER 0x00040000L")]
        public const int D3DPRASTERCAPS_WBUFFER = 0x00040000;

        [NativeTypeName("#define D3DPRASTERCAPS_WFOG 0x00100000L")]
        public const int D3DPRASTERCAPS_WFOG = 0x00100000;

        [NativeTypeName("#define D3DPRASTERCAPS_ZFOG 0x00200000L")]
        public const int D3DPRASTERCAPS_ZFOG = 0x00200000;

        [NativeTypeName("#define D3DPRASTERCAPS_COLORPERSPECTIVE 0x00400000L")]
        public const int D3DPRASTERCAPS_COLORPERSPECTIVE = 0x00400000;

        [NativeTypeName("#define D3DPRASTERCAPS_SCISSORTEST 0x01000000L")]
        public const int D3DPRASTERCAPS_SCISSORTEST = 0x01000000;

        [NativeTypeName("#define D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS 0x02000000L")]
        public const int D3DPRASTERCAPS_SLOPESCALEDEPTHBIAS = 0x02000000;

        [NativeTypeName("#define D3DPRASTERCAPS_DEPTHBIAS 0x04000000L")]
        public const int D3DPRASTERCAPS_DEPTHBIAS = 0x04000000;

        [NativeTypeName("#define D3DPRASTERCAPS_MULTISAMPLE_TOGGLE 0x08000000L")]
        public const int D3DPRASTERCAPS_MULTISAMPLE_TOGGLE = 0x08000000;

        [NativeTypeName("#define D3DPCMPCAPS_NEVER 0x00000001L")]
        public const int D3DPCMPCAPS_NEVER = 0x00000001;

        [NativeTypeName("#define D3DPCMPCAPS_LESS 0x00000002L")]
        public const int D3DPCMPCAPS_LESS = 0x00000002;

        [NativeTypeName("#define D3DPCMPCAPS_EQUAL 0x00000004L")]
        public const int D3DPCMPCAPS_EQUAL = 0x00000004;

        [NativeTypeName("#define D3DPCMPCAPS_LESSEQUAL 0x00000008L")]
        public const int D3DPCMPCAPS_LESSEQUAL = 0x00000008;

        [NativeTypeName("#define D3DPCMPCAPS_GREATER 0x00000010L")]
        public const int D3DPCMPCAPS_GREATER = 0x00000010;

        [NativeTypeName("#define D3DPCMPCAPS_NOTEQUAL 0x00000020L")]
        public const int D3DPCMPCAPS_NOTEQUAL = 0x00000020;

        [NativeTypeName("#define D3DPCMPCAPS_GREATEREQUAL 0x00000040L")]
        public const int D3DPCMPCAPS_GREATEREQUAL = 0x00000040;

        [NativeTypeName("#define D3DPCMPCAPS_ALWAYS 0x00000080L")]
        public const int D3DPCMPCAPS_ALWAYS = 0x00000080;

        [NativeTypeName("#define D3DPBLENDCAPS_ZERO 0x00000001L")]
        public const int D3DPBLENDCAPS_ZERO = 0x00000001;

        [NativeTypeName("#define D3DPBLENDCAPS_ONE 0x00000002L")]
        public const int D3DPBLENDCAPS_ONE = 0x00000002;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR 0x00000004L")]
        public const int D3DPBLENDCAPS_SRCCOLOR = 0x00000004;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR 0x00000008L")]
        public const int D3DPBLENDCAPS_INVSRCCOLOR = 0x00000008;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHA 0x00000010L")]
        public const int D3DPBLENDCAPS_SRCALPHA = 0x00000010;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCALPHA 0x00000020L")]
        public const int D3DPBLENDCAPS_INVSRCALPHA = 0x00000020;

        [NativeTypeName("#define D3DPBLENDCAPS_DESTALPHA 0x00000040L")]
        public const int D3DPBLENDCAPS_DESTALPHA = 0x00000040;

        [NativeTypeName("#define D3DPBLENDCAPS_INVDESTALPHA 0x00000080L")]
        public const int D3DPBLENDCAPS_INVDESTALPHA = 0x00000080;

        [NativeTypeName("#define D3DPBLENDCAPS_DESTCOLOR 0x00000100L")]
        public const int D3DPBLENDCAPS_DESTCOLOR = 0x00000100;

        [NativeTypeName("#define D3DPBLENDCAPS_INVDESTCOLOR 0x00000200L")]
        public const int D3DPBLENDCAPS_INVDESTCOLOR = 0x00000200;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCALPHASAT 0x00000400L")]
        public const int D3DPBLENDCAPS_SRCALPHASAT = 0x00000400;

        [NativeTypeName("#define D3DPBLENDCAPS_BOTHSRCALPHA 0x00000800L")]
        public const int D3DPBLENDCAPS_BOTHSRCALPHA = 0x00000800;

        [NativeTypeName("#define D3DPBLENDCAPS_BOTHINVSRCALPHA 0x00001000L")]
        public const int D3DPBLENDCAPS_BOTHINVSRCALPHA = 0x00001000;

        [NativeTypeName("#define D3DPBLENDCAPS_BLENDFACTOR 0x00002000L")]
        public const int D3DPBLENDCAPS_BLENDFACTOR = 0x00002000;

        [NativeTypeName("#define D3DPBLENDCAPS_SRCCOLOR2 0x00004000L")]
        public const int D3DPBLENDCAPS_SRCCOLOR2 = 0x00004000;

        [NativeTypeName("#define D3DPBLENDCAPS_INVSRCCOLOR2 0x00008000L")]
        public const int D3DPBLENDCAPS_INVSRCCOLOR2 = 0x00008000;

        [NativeTypeName("#define D3DPSHADECAPS_COLORGOURAUDRGB 0x00000008L")]
        public const int D3DPSHADECAPS_COLORGOURAUDRGB = 0x00000008;

        [NativeTypeName("#define D3DPSHADECAPS_SPECULARGOURAUDRGB 0x00000200L")]
        public const int D3DPSHADECAPS_SPECULARGOURAUDRGB = 0x00000200;

        [NativeTypeName("#define D3DPSHADECAPS_ALPHAGOURAUDBLEND 0x00004000L")]
        public const int D3DPSHADECAPS_ALPHAGOURAUDBLEND = 0x00004000;

        [NativeTypeName("#define D3DPSHADECAPS_FOGGOURAUD 0x00080000L")]
        public const int D3DPSHADECAPS_FOGGOURAUD = 0x00080000;

        [NativeTypeName("#define D3DPTEXTURECAPS_PERSPECTIVE 0x00000001L")]
        public const int D3DPTEXTURECAPS_PERSPECTIVE = 0x00000001;

        [NativeTypeName("#define D3DPTEXTURECAPS_POW2 0x00000002L")]
        public const int D3DPTEXTURECAPS_POW2 = 0x00000002;

        [NativeTypeName("#define D3DPTEXTURECAPS_ALPHA 0x00000004L")]
        public const int D3DPTEXTURECAPS_ALPHA = 0x00000004;

        [NativeTypeName("#define D3DPTEXTURECAPS_SQUAREONLY 0x00000020L")]
        public const int D3DPTEXTURECAPS_SQUAREONLY = 0x00000020;

        [NativeTypeName("#define D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE 0x00000040L")]
        public const int D3DPTEXTURECAPS_TEXREPEATNOTSCALEDBYSIZE = 0x00000040;

        [NativeTypeName("#define D3DPTEXTURECAPS_ALPHAPALETTE 0x00000080L")]
        public const int D3DPTEXTURECAPS_ALPHAPALETTE = 0x00000080;

        [NativeTypeName("#define D3DPTEXTURECAPS_NONPOW2CONDITIONAL 0x00000100L")]
        public const int D3DPTEXTURECAPS_NONPOW2CONDITIONAL = 0x00000100;

        [NativeTypeName("#define D3DPTEXTURECAPS_PROJECTED 0x00000400L")]
        public const int D3DPTEXTURECAPS_PROJECTED = 0x00000400;

        [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP 0x00000800L")]
        public const int D3DPTEXTURECAPS_CUBEMAP = 0x00000800;

        [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP 0x00002000L")]
        public const int D3DPTEXTURECAPS_VOLUMEMAP = 0x00002000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPMAP 0x00004000L")]
        public const int D3DPTEXTURECAPS_MIPMAP = 0x00004000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPVOLUMEMAP 0x00008000L")]
        public const int D3DPTEXTURECAPS_MIPVOLUMEMAP = 0x00008000;

        [NativeTypeName("#define D3DPTEXTURECAPS_MIPCUBEMAP 0x00010000L")]
        public const int D3DPTEXTURECAPS_MIPCUBEMAP = 0x00010000;

        [NativeTypeName("#define D3DPTEXTURECAPS_CUBEMAP_POW2 0x00020000L")]
        public const int D3DPTEXTURECAPS_CUBEMAP_POW2 = 0x00020000;

        [NativeTypeName("#define D3DPTEXTURECAPS_VOLUMEMAP_POW2 0x00040000L")]
        public const int D3DPTEXTURECAPS_VOLUMEMAP_POW2 = 0x00040000;

        [NativeTypeName("#define D3DPTEXTURECAPS_NOPROJECTEDBUMPENV 0x00200000L")]
        public const int D3DPTEXTURECAPS_NOPROJECTEDBUMPENV = 0x00200000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFPOINT 0x00000100L")]
        public const int D3DPTFILTERCAPS_MINFPOINT = 0x00000100;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFLINEAR 0x00000200L")]
        public const int D3DPTFILTERCAPS_MINFLINEAR = 0x00000200;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFANISOTROPIC 0x00000400L")]
        public const int D3DPTFILTERCAPS_MINFANISOTROPIC = 0x00000400;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFPYRAMIDALQUAD 0x00000800L")]
        public const int D3DPTFILTERCAPS_MINFPYRAMIDALQUAD = 0x00000800;

        [NativeTypeName("#define D3DPTFILTERCAPS_MINFGAUSSIANQUAD 0x00001000L")]
        public const int D3DPTFILTERCAPS_MINFGAUSSIANQUAD = 0x00001000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MIPFPOINT 0x00010000L")]
        public const int D3DPTFILTERCAPS_MIPFPOINT = 0x00010000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MIPFLINEAR 0x00020000L")]
        public const int D3DPTFILTERCAPS_MIPFLINEAR = 0x00020000;

        [NativeTypeName("#define D3DPTFILTERCAPS_CONVOLUTIONMONO 0x00040000L")]
        public const int D3DPTFILTERCAPS_CONVOLUTIONMONO = 0x00040000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPOINT 0x01000000L")]
        public const int D3DPTFILTERCAPS_MAGFPOINT = 0x01000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFLINEAR 0x02000000L")]
        public const int D3DPTFILTERCAPS_MAGFLINEAR = 0x02000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFANISOTROPIC 0x04000000L")]
        public const int D3DPTFILTERCAPS_MAGFANISOTROPIC = 0x04000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD 0x08000000L")]
        public const int D3DPTFILTERCAPS_MAGFPYRAMIDALQUAD = 0x08000000;

        [NativeTypeName("#define D3DPTFILTERCAPS_MAGFGAUSSIANQUAD 0x10000000L")]
        public const int D3DPTFILTERCAPS_MAGFGAUSSIANQUAD = 0x10000000;

        [NativeTypeName("#define D3DPTADDRESSCAPS_WRAP 0x00000001L")]
        public const int D3DPTADDRESSCAPS_WRAP = 0x00000001;

        [NativeTypeName("#define D3DPTADDRESSCAPS_MIRROR 0x00000002L")]
        public const int D3DPTADDRESSCAPS_MIRROR = 0x00000002;

        [NativeTypeName("#define D3DPTADDRESSCAPS_CLAMP 0x00000004L")]
        public const int D3DPTADDRESSCAPS_CLAMP = 0x00000004;

        [NativeTypeName("#define D3DPTADDRESSCAPS_BORDER 0x00000008L")]
        public const int D3DPTADDRESSCAPS_BORDER = 0x00000008;

        [NativeTypeName("#define D3DPTADDRESSCAPS_INDEPENDENTUV 0x00000010L")]
        public const int D3DPTADDRESSCAPS_INDEPENDENTUV = 0x00000010;

        [NativeTypeName("#define D3DPTADDRESSCAPS_MIRRORONCE 0x00000020L")]
        public const int D3DPTADDRESSCAPS_MIRRORONCE = 0x00000020;

        [NativeTypeName("#define D3DSTENCILCAPS_KEEP 0x00000001L")]
        public const int D3DSTENCILCAPS_KEEP = 0x00000001;

        [NativeTypeName("#define D3DSTENCILCAPS_ZERO 0x00000002L")]
        public const int D3DSTENCILCAPS_ZERO = 0x00000002;

        [NativeTypeName("#define D3DSTENCILCAPS_REPLACE 0x00000004L")]
        public const int D3DSTENCILCAPS_REPLACE = 0x00000004;

        [NativeTypeName("#define D3DSTENCILCAPS_INCRSAT 0x00000008L")]
        public const int D3DSTENCILCAPS_INCRSAT = 0x00000008;

        [NativeTypeName("#define D3DSTENCILCAPS_DECRSAT 0x00000010L")]
        public const int D3DSTENCILCAPS_DECRSAT = 0x00000010;

        [NativeTypeName("#define D3DSTENCILCAPS_INVERT 0x00000020L")]
        public const int D3DSTENCILCAPS_INVERT = 0x00000020;

        [NativeTypeName("#define D3DSTENCILCAPS_INCR 0x00000040L")]
        public const int D3DSTENCILCAPS_INCR = 0x00000040;

        [NativeTypeName("#define D3DSTENCILCAPS_DECR 0x00000080L")]
        public const int D3DSTENCILCAPS_DECR = 0x00000080;

        [NativeTypeName("#define D3DSTENCILCAPS_TWOSIDED 0x00000100L")]
        public const int D3DSTENCILCAPS_TWOSIDED = 0x00000100;

        [NativeTypeName("#define D3DTEXOPCAPS_DISABLE 0x00000001L")]
        public const int D3DTEXOPCAPS_DISABLE = 0x00000001;

        [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG1 0x00000002L")]
        public const int D3DTEXOPCAPS_SELECTARG1 = 0x00000002;

        [NativeTypeName("#define D3DTEXOPCAPS_SELECTARG2 0x00000004L")]
        public const int D3DTEXOPCAPS_SELECTARG2 = 0x00000004;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE 0x00000008L")]
        public const int D3DTEXOPCAPS_MODULATE = 0x00000008;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE2X 0x00000010L")]
        public const int D3DTEXOPCAPS_MODULATE2X = 0x00000010;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATE4X 0x00000020L")]
        public const int D3DTEXOPCAPS_MODULATE4X = 0x00000020;

        [NativeTypeName("#define D3DTEXOPCAPS_ADD 0x00000040L")]
        public const int D3DTEXOPCAPS_ADD = 0x00000040;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED 0x00000080L")]
        public const int D3DTEXOPCAPS_ADDSIGNED = 0x00000080;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSIGNED2X 0x00000100L")]
        public const int D3DTEXOPCAPS_ADDSIGNED2X = 0x00000100;

        [NativeTypeName("#define D3DTEXOPCAPS_SUBTRACT 0x00000200L")]
        public const int D3DTEXOPCAPS_SUBTRACT = 0x00000200;

        [NativeTypeName("#define D3DTEXOPCAPS_ADDSMOOTH 0x00000400L")]
        public const int D3DTEXOPCAPS_ADDSMOOTH = 0x00000400;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDDIFFUSEALPHA 0x00000800L")]
        public const int D3DTEXOPCAPS_BLENDDIFFUSEALPHA = 0x00000800;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHA 0x00001000L")]
        public const int D3DTEXOPCAPS_BLENDTEXTUREALPHA = 0x00001000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDFACTORALPHA 0x00002000L")]
        public const int D3DTEXOPCAPS_BLENDFACTORALPHA = 0x00002000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDTEXTUREALPHAPM 0x00004000L")]
        public const int D3DTEXOPCAPS_BLENDTEXTUREALPHAPM = 0x00004000;

        [NativeTypeName("#define D3DTEXOPCAPS_BLENDCURRENTALPHA 0x00008000L")]
        public const int D3DTEXOPCAPS_BLENDCURRENTALPHA = 0x00008000;

        [NativeTypeName("#define D3DTEXOPCAPS_PREMODULATE 0x00010000L")]
        public const int D3DTEXOPCAPS_PREMODULATE = 0x00010000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR 0x00020000L")]
        public const int D3DTEXOPCAPS_MODULATEALPHA_ADDCOLOR = 0x00020000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA 0x00040000L")]
        public const int D3DTEXOPCAPS_MODULATECOLOR_ADDALPHA = 0x00040000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR 0x00080000L")]
        public const int D3DTEXOPCAPS_MODULATEINVALPHA_ADDCOLOR = 0x00080000;

        [NativeTypeName("#define D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA 0x00100000L")]
        public const int D3DTEXOPCAPS_MODULATEINVCOLOR_ADDALPHA = 0x00100000;

        [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAP 0x00200000L")]
        public const int D3DTEXOPCAPS_BUMPENVMAP = 0x00200000;

        [NativeTypeName("#define D3DTEXOPCAPS_BUMPENVMAPLUMINANCE 0x00400000L")]
        public const int D3DTEXOPCAPS_BUMPENVMAPLUMINANCE = 0x00400000;

        [NativeTypeName("#define D3DTEXOPCAPS_DOTPRODUCT3 0x00800000L")]
        public const int D3DTEXOPCAPS_DOTPRODUCT3 = 0x00800000;

        [NativeTypeName("#define D3DTEXOPCAPS_MULTIPLYADD 0x01000000L")]
        public const int D3DTEXOPCAPS_MULTIPLYADD = 0x01000000;

        [NativeTypeName("#define D3DTEXOPCAPS_LERP 0x02000000L")]
        public const int D3DTEXOPCAPS_LERP = 0x02000000;

        [NativeTypeName("#define D3DFVFCAPS_TEXCOORDCOUNTMASK 0x0000ffffL")]
        public const int D3DFVFCAPS_TEXCOORDCOUNTMASK = 0x0000ffff;

        [NativeTypeName("#define D3DFVFCAPS_DONOTSTRIPELEMENTS 0x00080000L")]
        public const int D3DFVFCAPS_DONOTSTRIPELEMENTS = 0x00080000;

        [NativeTypeName("#define D3DFVFCAPS_PSIZE 0x00100000L")]
        public const int D3DFVFCAPS_PSIZE = 0x00100000;

        [NativeTypeName("#define D3DVTXPCAPS_TEXGEN 0x00000001L")]
        public const int D3DVTXPCAPS_TEXGEN = 0x00000001;

        [NativeTypeName("#define D3DVTXPCAPS_MATERIALSOURCE7 0x00000002L")]
        public const int D3DVTXPCAPS_MATERIALSOURCE7 = 0x00000002;

        [NativeTypeName("#define D3DVTXPCAPS_DIRECTIONALLIGHTS 0x00000008L")]
        public const int D3DVTXPCAPS_DIRECTIONALLIGHTS = 0x00000008;

        [NativeTypeName("#define D3DVTXPCAPS_POSITIONALLIGHTS 0x00000010L")]
        public const int D3DVTXPCAPS_POSITIONALLIGHTS = 0x00000010;

        [NativeTypeName("#define D3DVTXPCAPS_LOCALVIEWER 0x00000020L")]
        public const int D3DVTXPCAPS_LOCALVIEWER = 0x00000020;

        [NativeTypeName("#define D3DVTXPCAPS_TWEENING 0x00000040L")]
        public const int D3DVTXPCAPS_TWEENING = 0x00000040;

        [NativeTypeName("#define D3DVTXPCAPS_TEXGEN_SPHEREMAP 0x00000100L")]
        public const int D3DVTXPCAPS_TEXGEN_SPHEREMAP = 0x00000100;

        [NativeTypeName("#define D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER 0x00000200L")]
        public const int D3DVTXPCAPS_NO_TEXGEN_NONLOCALVIEWER = 0x00000200;

        [NativeTypeName("#define D3DDEVCAPS2_STREAMOFFSET 0x00000001L")]
        public const int D3DDEVCAPS2_STREAMOFFSET = 0x00000001;

        [NativeTypeName("#define D3DDEVCAPS2_DMAPNPATCH 0x00000002L")]
        public const int D3DDEVCAPS2_DMAPNPATCH = 0x00000002;

        [NativeTypeName("#define D3DDEVCAPS2_ADAPTIVETESSRTPATCH 0x00000004L")]
        public const int D3DDEVCAPS2_ADAPTIVETESSRTPATCH = 0x00000004;

        [NativeTypeName("#define D3DDEVCAPS2_ADAPTIVETESSNPATCH 0x00000008L")]
        public const int D3DDEVCAPS2_ADAPTIVETESSNPATCH = 0x00000008;

        [NativeTypeName("#define D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES 0x00000010L")]
        public const int D3DDEVCAPS2_CAN_STRETCHRECT_FROM_TEXTURES = 0x00000010;

        [NativeTypeName("#define D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH 0x00000020L")]
        public const int D3DDEVCAPS2_PRESAMPLEDDMAPNPATCH = 0x00000020;

        [NativeTypeName("#define D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET 0x00000040L")]
        public const int D3DDEVCAPS2_VERTEXELEMENTSCANSHARESTREAMOFFSET = 0x00000040;

        [NativeTypeName("#define D3DDTCAPS_UBYTE4 0x00000001L")]
        public const int D3DDTCAPS_UBYTE4 = 0x00000001;

        [NativeTypeName("#define D3DDTCAPS_UBYTE4N 0x00000002L")]
        public const int D3DDTCAPS_UBYTE4N = 0x00000002;

        [NativeTypeName("#define D3DDTCAPS_SHORT2N 0x00000004L")]
        public const int D3DDTCAPS_SHORT2N = 0x00000004;

        [NativeTypeName("#define D3DDTCAPS_SHORT4N 0x00000008L")]
        public const int D3DDTCAPS_SHORT4N = 0x00000008;

        [NativeTypeName("#define D3DDTCAPS_USHORT2N 0x00000010L")]
        public const int D3DDTCAPS_USHORT2N = 0x00000010;

        [NativeTypeName("#define D3DDTCAPS_USHORT4N 0x00000020L")]
        public const int D3DDTCAPS_USHORT4N = 0x00000020;

        [NativeTypeName("#define D3DDTCAPS_UDEC3 0x00000040L")]
        public const int D3DDTCAPS_UDEC3 = 0x00000040;

        [NativeTypeName("#define D3DDTCAPS_DEC3N 0x00000080L")]
        public const int D3DDTCAPS_DEC3N = 0x00000080;

        [NativeTypeName("#define D3DDTCAPS_FLOAT16_2 0x00000100L")]
        public const int D3DDTCAPS_FLOAT16_2 = 0x00000100;

        [NativeTypeName("#define D3DDTCAPS_FLOAT16_4 0x00000200L")]
        public const int D3DDTCAPS_FLOAT16_4 = 0x00000200;
    }
}
