// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/StructuredQueryCondition.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum CONDITION_TYPE
    {
        CT_AND_CONDITION = 0,
        CT_OR_CONDITION = (CT_AND_CONDITION + 1),
        CT_NOT_CONDITION = (CT_OR_CONDITION + 1),
        CT_LEAF_CONDITION = (CT_NOT_CONDITION + 1),
    }
}
