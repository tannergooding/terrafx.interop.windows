// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D10_DEVICE_STATE_TYPES
    {
        D3D10_DST_SO_BUFFERS = 1,
        D3D10_DST_OM_RENDER_TARGETS,
        D3D10_DST_OM_DEPTH_STENCIL_STATE,
        D3D10_DST_OM_BLEND_STATE,
        D3D10_DST_VS,
        D3D10_DST_VS_SAMPLERS,
        D3D10_DST_VS_SHADER_RESOURCES,
        D3D10_DST_VS_CONSTANT_BUFFERS,
        D3D10_DST_GS,
        D3D10_DST_GS_SAMPLERS,
        D3D10_DST_GS_SHADER_RESOURCES,
        D3D10_DST_GS_CONSTANT_BUFFERS,
        D3D10_DST_PS,
        D3D10_DST_PS_SAMPLERS,
        D3D10_DST_PS_SHADER_RESOURCES,
        D3D10_DST_PS_CONSTANT_BUFFERS,
        D3D10_DST_IA_VERTEX_BUFFERS,
        D3D10_DST_IA_INDEX_BUFFER,
        D3D10_DST_IA_INPUT_LAYOUT,
        D3D10_DST_IA_PRIMITIVE_TOPOLOGY,
        D3D10_DST_RS_VIEWPORTS,
        D3D10_DST_RS_SCISSOR_RECTS,
        D3D10_DST_RS_RASTERIZER_STATE,
        D3D10_DST_PREDICATION,
    }
}
