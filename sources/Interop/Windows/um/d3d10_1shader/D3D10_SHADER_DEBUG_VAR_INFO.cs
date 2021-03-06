// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D3D10_SHADER_DEBUG_VAR_INFO
    {
        [NativeTypeName("UINT")]
        public uint TokenId;

        [NativeTypeName("D3D10_SHADER_VARIABLE_TYPE")]
        public D3D_SHADER_VARIABLE_TYPE Type;

        [NativeTypeName("UINT")]
        public uint Register;

        [NativeTypeName("UINT")]
        public uint Component;

        [NativeTypeName("UINT")]
        public uint ScopeVar;

        [NativeTypeName("UINT")]
        public uint ScopeVarOffset;
    }
}
