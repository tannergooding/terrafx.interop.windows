// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mftransform.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MFAudioDecoderDegradationInfo
    {
        public MFT_AUDIO_DECODER_DEGRADATION_REASON eDegradationReason;

        public MFT_AUDIO_DECODER_DEGRADATION_TYPE eType;
    }
}
