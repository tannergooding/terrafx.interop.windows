// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.SPLEXICONTYPE;

namespace TerraFX.Interop
{
    public enum SpeechLexiconType
    {
        SLTUser = eLEXTYPE_USER,
        SLTApp = eLEXTYPE_APP,
    }
}
