// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_TS_SERVICE_DATAOBJECT = new Guid(0x6086fbb5, 0xe225, 0x46ce, 0xa7, 0x70, 0xc1, 0xbb, 0xd3, 0xe0, 0x5d, 0x7b);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_TS_SERVICE_ACCESSIBLE = new Guid(0xf9786200, 0xa5bf, 0x4a0f, 0x8c, 0x24, 0xfb, 0x16, 0xf5, 0xd1, 0xaa, 0xbb);

        [NativeTypeName("const GUID")]
        public static readonly Guid GUID_TS_SERVICE_ACTIVEX = new Guid(0xea937a50, 0xc9a6, 0x4b7d, 0x89, 0x4a, 0x49, 0xd9, 0x9b, 0x78, 0x48, 0x34);

        [NativeTypeName("#define TS_E_INVALIDPOS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0200)")]
        public const int TS_E_INVALIDPOS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0200))));

        [NativeTypeName("#define TS_E_NOLOCK MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0201)")]
        public const int TS_E_NOLOCK = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0201))));

        [NativeTypeName("#define TS_E_NOOBJECT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0202)")]
        public const int TS_E_NOOBJECT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0202))));

        [NativeTypeName("#define TS_E_NOSERVICE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0203)")]
        public const int TS_E_NOSERVICE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0203))));

        [NativeTypeName("#define TS_E_NOINTERFACE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0204)")]
        public const int TS_E_NOINTERFACE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0204))));

        [NativeTypeName("#define TS_E_NOSELECTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0205)")]
        public const int TS_E_NOSELECTION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0205))));

        [NativeTypeName("#define TS_E_NOLAYOUT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0206)")]
        public const int TS_E_NOLAYOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0206))));

        [NativeTypeName("#define TS_E_INVALIDPOINT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0207)")]
        public const int TS_E_INVALIDPOINT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0207))));

        [NativeTypeName("#define TS_E_SYNCHRONOUS MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0208)")]
        public const int TS_E_SYNCHRONOUS = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0208))));

        [NativeTypeName("#define TS_E_READONLY MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x0209)")]
        public const int TS_E_READONLY = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x0209))));

        [NativeTypeName("#define TS_E_FORMAT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0x020a)")]
        public const int TS_E_FORMAT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0x020a))));

        [NativeTypeName("#define TS_S_ASYNC MAKE_HRESULT(SEVERITY_SUCCESS, FACILITY_ITF, 0x0300)")]
        public const int TS_S_ASYNC = unchecked((int)(((uint)(0) << 31) | ((uint)(4) << 16) | ((uint)(0x0300))));

        [NativeTypeName("#define TS_AS_TEXT_CHANGE ( 0x1 )")]
        public const int TS_AS_TEXT_CHANGE = (0x1);

        [NativeTypeName("#define TS_AS_SEL_CHANGE ( 0x2 )")]
        public const int TS_AS_SEL_CHANGE = (0x2);

        [NativeTypeName("#define TS_AS_LAYOUT_CHANGE ( 0x4 )")]
        public const int TS_AS_LAYOUT_CHANGE = (0x4);

        [NativeTypeName("#define TS_AS_ATTR_CHANGE ( 0x8 )")]
        public const int TS_AS_ATTR_CHANGE = (0x8);

        [NativeTypeName("#define TS_AS_STATUS_CHANGE ( 0x10 )")]
        public const int TS_AS_STATUS_CHANGE = (0x10);

        [NativeTypeName("#define TS_AS_ALL_SINKS ( ( ( ( ( TS_AS_TEXT_CHANGE | TS_AS_SEL_CHANGE )  | TS_AS_LAYOUT_CHANGE )  | TS_AS_ATTR_CHANGE )  | TS_AS_STATUS_CHANGE )  )")]
        public const int TS_AS_ALL_SINKS = ((((((0x1) | (0x2)) | (0x4)) | (0x8)) | (0x10)));

        [NativeTypeName("#define TS_LF_SYNC ( 0x1 )")]
        public const int TS_LF_SYNC = (0x1);

        [NativeTypeName("#define TS_LF_READ ( 0x2 )")]
        public const int TS_LF_READ = (0x2);

        [NativeTypeName("#define TS_LF_READWRITE ( 0x6 )")]
        public const int TS_LF_READWRITE = (0x6);

        [NativeTypeName("#define TS_SD_READONLY ( 0x1 )")]
        public const int TS_SD_READONLY = (0x1);

        [NativeTypeName("#define TS_SD_LOADING ( 0x2 )")]
        public const int TS_SD_LOADING = (0x2);

        [NativeTypeName("#define TS_SD_RESERVED ( 0x4 )")]
        public const int TS_SD_RESERVED = (0x4);

        [NativeTypeName("#define TS_SD_TKBAUTOCORRECTENABLE ( 0x8 )")]
        public const int TS_SD_TKBAUTOCORRECTENABLE = (0x8);

        [NativeTypeName("#define TS_SD_TKBPREDICTIONENABLE ( 0x10 )")]
        public const int TS_SD_TKBPREDICTIONENABLE = (0x10);

        [NativeTypeName("#define TS_SD_UIINTEGRATIONENABLE ( 0x20 )")]
        public const int TS_SD_UIINTEGRATIONENABLE = (0x20);

        [NativeTypeName("#define TS_SD_INPUTPANEMANUALDISPLAYENABLE ( 0x40 )")]
        public const int TS_SD_INPUTPANEMANUALDISPLAYENABLE = (0x40);

        [NativeTypeName("#define TS_SD_EMBEDDEDHANDWRITINGVIEW_ENABLED ( 0x80 )")]
        public const int TS_SD_EMBEDDEDHANDWRITINGVIEW_ENABLED = (0x80);

        [NativeTypeName("#define TS_SD_EMBEDDEDHANDWRITINGVIEW_VISIBLE ( 0x100 )")]
        public const int TS_SD_EMBEDDEDHANDWRITINGVIEW_VISIBLE = (0x100);

        [NativeTypeName("#define TS_SS_DISJOINTSEL ( 0x1 )")]
        public const int TS_SS_DISJOINTSEL = (0x1);

        [NativeTypeName("#define TS_SS_REGIONS ( 0x2 )")]
        public const int TS_SS_REGIONS = (0x2);

        [NativeTypeName("#define TS_SS_TRANSITORY ( 0x4 )")]
        public const int TS_SS_TRANSITORY = (0x4);

        [NativeTypeName("#define TS_SS_NOHIDDENTEXT ( 0x8 )")]
        public const int TS_SS_NOHIDDENTEXT = (0x8);

        [NativeTypeName("#define TS_SS_TKBAUTOCORRECTENABLE ( 0x10 )")]
        public const int TS_SS_TKBAUTOCORRECTENABLE = (0x10);

        [NativeTypeName("#define TS_SS_TKBPREDICTIONENABLE ( 0x20 )")]
        public const int TS_SS_TKBPREDICTIONENABLE = (0x20);

        [NativeTypeName("#define TS_SS_UWPCONTROL ( 0x40 )")]
        public const int TS_SS_UWPCONTROL = (0x40);

        [NativeTypeName("#define TS_SD_MASKALL ( ( TS_SD_READONLY | TS_SD_LOADING )  )")]
        public const int TS_SD_MASKALL = (((0x1) | (0x2)));

        [NativeTypeName("#define TS_ST_CORRECTION ( 0x1 )")]
        public const int TS_ST_CORRECTION = (0x1);

        [NativeTypeName("#define TS_IE_CORRECTION ( 0x1 )")]
        public const int TS_IE_CORRECTION = (0x1);

        [NativeTypeName("#define TS_IE_COMPOSITION ( 0x2 )")]
        public const int TS_IE_COMPOSITION = (0x2);

        [NativeTypeName("#define TS_TC_CORRECTION ( 0x1 )")]
        public const int TS_TC_CORRECTION = (0x1);

        [NativeTypeName("#define TS_IAS_NOQUERY ( 0x1 )")]
        public const int TS_IAS_NOQUERY = (0x1);

        [NativeTypeName("#define TS_IAS_QUERYONLY ( 0x2 )")]
        public const int TS_IAS_QUERYONLY = (0x2);

        [NativeTypeName("#define TS_DEFAULT_SELECTION ( ( ULONG  )-1 )")]
        public const uint TS_DEFAULT_SELECTION = unchecked((uint)(-1));

        [NativeTypeName("#define GXFPF_ROUND_NEAREST ( 0x1 )")]
        public const int GXFPF_ROUND_NEAREST = (0x1);

        [NativeTypeName("#define GXFPF_NEAREST ( 0x2 )")]
        public const int GXFPF_NEAREST = (0x2);

        [NativeTypeName("#define TS_CHAR_EMBEDDED ( 0xfffc )")]
        public const int TS_CHAR_EMBEDDED = (0xfffc);

        [NativeTypeName("#define TS_CHAR_REGION ( 0 )")]
        public const int TS_CHAR_REGION = (0);

        [NativeTypeName("#define TS_CHAR_REPLACEMENT ( 0xfffd )")]
        public const int TS_CHAR_REPLACEMENT = (0xfffd);

        [NativeTypeName("#define TS_ATTR_FIND_BACKWARDS ( 0x1 )")]
        public const int TS_ATTR_FIND_BACKWARDS = (0x1);

        [NativeTypeName("#define TS_ATTR_FIND_WANT_OFFSET ( 0x2 )")]
        public const int TS_ATTR_FIND_WANT_OFFSET = (0x2);

        [NativeTypeName("#define TS_ATTR_FIND_UPDATESTART ( 0x4 )")]
        public const int TS_ATTR_FIND_UPDATESTART = (0x4);

        [NativeTypeName("#define TS_ATTR_FIND_WANT_VALUE ( 0x8 )")]
        public const int TS_ATTR_FIND_WANT_VALUE = (0x8);

        [NativeTypeName("#define TS_ATTR_FIND_WANT_END ( 0x10 )")]
        public const int TS_ATTR_FIND_WANT_END = (0x10);

        [NativeTypeName("#define TS_ATTR_FIND_HIDDEN ( 0x20 )")]
        public const int TS_ATTR_FIND_HIDDEN = (0x20);

        [NativeTypeName("#define TS_VCOOKIE_NUL ( 0xffffffff )")]
        public const uint TS_VCOOKIE_NUL = (0xffffffff);

        [NativeTypeName("#define TS_CH_PRECEDING_DEL ( 1 )")]
        public const int TS_CH_PRECEDING_DEL = (1);

        [NativeTypeName("#define TS_CH_FOLLOWING_DEL ( 2 )")]
        public const int TS_CH_FOLLOWING_DEL = (2);

        [NativeTypeName("#define TS_SHIFT_COUNT_HIDDEN ( 0x1 )")]
        public const int TS_SHIFT_COUNT_HIDDEN = (0x1);

        [NativeTypeName("#define TS_SHIFT_HALT_HIDDEN ( 0x2 )")]
        public const int TS_SHIFT_HALT_HIDDEN = (0x2);

        [NativeTypeName("#define TS_SHIFT_HALT_VISIBLE ( 0x4 )")]
        public const int TS_SHIFT_HALT_VISIBLE = (0x4);

        [NativeTypeName("#define TS_SHIFT_COUNT_ONLY ( 0x8 )")]
        public const int TS_SHIFT_COUNT_ONLY = (0x8);

        [NativeTypeName("#define TS_GTA_HIDDEN ( 0x1 )")]
        public const int TS_GTA_HIDDEN = (0x1);

        [NativeTypeName("#define TS_GEA_HIDDEN ( 0x1 )")]
        public const int TS_GEA_HIDDEN = (0x1);

        public static readonly Guid IID_ITextStoreACP = new Guid(0x28888FE3, 0xC2A0, 0x483A, 0xA3, 0xEA, 0x8C, 0xB1, 0xCE, 0x51, 0xFF, 0x3D);

        public static readonly Guid IID_ITextStoreACP2 = new Guid(0xF86AD89F, 0x5FE4, 0x4B8D, 0xBB, 0x9F, 0xEF, 0x37, 0x97, 0xA8, 0x4F, 0x1F);

        public static readonly Guid IID_ITextStoreACPSink = new Guid(0x22D44C94, 0xA419, 0x4542, 0xA2, 0x72, 0xAE, 0x26, 0x09, 0x3E, 0xCE, 0xCF);

        public static readonly Guid IID_IAnchor = new Guid(0x0FEB7E34, 0x5A60, 0x4356, 0x8E, 0xF7, 0xAB, 0xDE, 0xC2, 0xFF, 0x7C, 0xF8);

        public static readonly Guid IID_ITextStoreAnchor = new Guid(0x9B2077B0, 0x5F18, 0x4DEC, 0xBE, 0xE9, 0x3C, 0xC7, 0x22, 0xF5, 0xDF, 0xE0);

        public static readonly Guid IID_ITextStoreAnchorSink = new Guid(0xAA80E905, 0x2021, 0x11D2, 0x93, 0xE0, 0x00, 0x60, 0xB0, 0x67, 0xB8, 0x6E);
    }
}
