// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D3DAUTHENTICATEDCHANNEL_QUERYINFOBUSTYPE_OUTPUT
    {
        public D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT Output;

        public D3DBUSTYPE BusType;

        [NativeTypeName("BOOL")]
        public int bAccessibleInContiguousBlocks;

        [NativeTypeName("BOOL")]
        public int bAccessibleInNonContiguousBlocks;
    }
}
