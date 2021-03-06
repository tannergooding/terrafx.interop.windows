// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/amvideo.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct MPEG1VIDEOINFO
    {
        public VIDEOINFOHEADER hdr;

        [NativeTypeName("DWORD")]
        public uint dwStartTimeCode;

        [NativeTypeName("DWORD")]
        public uint cbSequenceHeader;

        [NativeTypeName("BYTE [1]")]
        public fixed byte bSequenceHeader[1];
    }
}
