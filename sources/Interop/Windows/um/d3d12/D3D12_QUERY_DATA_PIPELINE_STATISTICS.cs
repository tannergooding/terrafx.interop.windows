// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS
    {
        [NativeTypeName("UINT64")]
        public ulong IAVertices;

        [NativeTypeName("UINT64")]
        public ulong IAPrimitives;

        [NativeTypeName("UINT64")]
        public ulong VSInvocations;

        [NativeTypeName("UINT64")]
        public ulong GSInvocations;

        [NativeTypeName("UINT64")]
        public ulong GSPrimitives;

        [NativeTypeName("UINT64")]
        public ulong CInvocations;

        [NativeTypeName("UINT64")]
        public ulong CPrimitives;

        [NativeTypeName("UINT64")]
        public ulong PSInvocations;

        [NativeTypeName("UINT64")]
        public ulong HSInvocations;

        [NativeTypeName("UINT64")]
        public ulong DSInvocations;

        [NativeTypeName("UINT64")]
        public ulong CSInvocations;
    }
}
