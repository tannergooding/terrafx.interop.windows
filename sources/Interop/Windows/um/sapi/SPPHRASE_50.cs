// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASE_50
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("WORD")]
        public ushort LangID;

        [NativeTypeName("WORD")]
        public ushort wHomophoneGroupId;

        [NativeTypeName("ULONGLONG")]
        public ulong ullGrammarID;

        [NativeTypeName("ULONGLONG")]
        public ulong ftStartTime;

        [NativeTypeName("ULONGLONG")]
        public ulong ullAudioStreamPosition;

        [NativeTypeName("ULONG")]
        public uint ulAudioSizeBytes;

        [NativeTypeName("ULONG")]
        public uint ulRetainedSizeBytes;

        [NativeTypeName("ULONG")]
        public uint ulAudioSizeTime;

        public SPPHRASERULE Rule;

        [NativeTypeName("const SPPHRASEPROPERTY *")]
        public SPPHRASEPROPERTY* pProperties;

        [NativeTypeName("const SPPHRASEELEMENT *")]
        public SPPHRASEELEMENT* pElements;

        [NativeTypeName("ULONG")]
        public uint cReplacements;

        [NativeTypeName("const SPPHRASEREPLACEMENT *")]
        public SPPHRASEREPLACEMENT* pReplacements;

        [NativeTypeName("GUID")]
        public Guid SREngineID;

        [NativeTypeName("ULONG")]
        public uint ulSREnginePrivateDataSize;

        [NativeTypeName("const BYTE *")]
        public byte* pSREnginePrivateData;
    }
}
