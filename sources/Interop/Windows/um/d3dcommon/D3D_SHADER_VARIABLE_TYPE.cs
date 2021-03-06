// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3dcommon.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3D_SHADER_VARIABLE_TYPE
    {
        D3D_SVT_VOID = 0,
        D3D_SVT_BOOL = 1,
        D3D_SVT_INT = 2,
        D3D_SVT_FLOAT = 3,
        D3D_SVT_STRING = 4,
        D3D_SVT_TEXTURE = 5,
        D3D_SVT_TEXTURE1D = 6,
        D3D_SVT_TEXTURE2D = 7,
        D3D_SVT_TEXTURE3D = 8,
        D3D_SVT_TEXTURECUBE = 9,
        D3D_SVT_SAMPLER = 10,
        D3D_SVT_SAMPLER1D = 11,
        D3D_SVT_SAMPLER2D = 12,
        D3D_SVT_SAMPLER3D = 13,
        D3D_SVT_SAMPLERCUBE = 14,
        D3D_SVT_PIXELSHADER = 15,
        D3D_SVT_VERTEXSHADER = 16,
        D3D_SVT_PIXELFRAGMENT = 17,
        D3D_SVT_VERTEXFRAGMENT = 18,
        D3D_SVT_UINT = 19,
        D3D_SVT_UINT8 = 20,
        D3D_SVT_GEOMETRYSHADER = 21,
        D3D_SVT_RASTERIZER = 22,
        D3D_SVT_DEPTHSTENCIL = 23,
        D3D_SVT_BLEND = 24,
        D3D_SVT_BUFFER = 25,
        D3D_SVT_CBUFFER = 26,
        D3D_SVT_TBUFFER = 27,
        D3D_SVT_TEXTURE1DARRAY = 28,
        D3D_SVT_TEXTURE2DARRAY = 29,
        D3D_SVT_RENDERTARGETVIEW = 30,
        D3D_SVT_DEPTHSTENCILVIEW = 31,
        D3D_SVT_TEXTURE2DMS = 32,
        D3D_SVT_TEXTURE2DMSARRAY = 33,
        D3D_SVT_TEXTURECUBEARRAY = 34,
        D3D_SVT_HULLSHADER = 35,
        D3D_SVT_DOMAINSHADER = 36,
        D3D_SVT_INTERFACE_POINTER = 37,
        D3D_SVT_COMPUTESHADER = 38,
        D3D_SVT_DOUBLE = 39,
        D3D_SVT_RWTEXTURE1D = 40,
        D3D_SVT_RWTEXTURE1DARRAY = 41,
        D3D_SVT_RWTEXTURE2D = 42,
        D3D_SVT_RWTEXTURE2DARRAY = 43,
        D3D_SVT_RWTEXTURE3D = 44,
        D3D_SVT_RWBUFFER = 45,
        D3D_SVT_BYTEADDRESS_BUFFER = 46,
        D3D_SVT_RWBYTEADDRESS_BUFFER = 47,
        D3D_SVT_STRUCTURED_BUFFER = 48,
        D3D_SVT_RWSTRUCTURED_BUFFER = 49,
        D3D_SVT_APPEND_STRUCTURED_BUFFER = 50,
        D3D_SVT_CONSUME_STRUCTURED_BUFFER = 51,
        D3D_SVT_MIN8FLOAT = 52,
        D3D_SVT_MIN10FLOAT = 53,
        D3D_SVT_MIN16FLOAT = 54,
        D3D_SVT_MIN12INT = 55,
        D3D_SVT_MIN16INT = 56,
        D3D_SVT_MIN16UINT = 57,
        D3D10_SVT_VOID = D3D_SVT_VOID,
        D3D10_SVT_BOOL = D3D_SVT_BOOL,
        D3D10_SVT_INT = D3D_SVT_INT,
        D3D10_SVT_FLOAT = D3D_SVT_FLOAT,
        D3D10_SVT_STRING = D3D_SVT_STRING,
        D3D10_SVT_TEXTURE = D3D_SVT_TEXTURE,
        D3D10_SVT_TEXTURE1D = D3D_SVT_TEXTURE1D,
        D3D10_SVT_TEXTURE2D = D3D_SVT_TEXTURE2D,
        D3D10_SVT_TEXTURE3D = D3D_SVT_TEXTURE3D,
        D3D10_SVT_TEXTURECUBE = D3D_SVT_TEXTURECUBE,
        D3D10_SVT_SAMPLER = D3D_SVT_SAMPLER,
        D3D10_SVT_SAMPLER1D = D3D_SVT_SAMPLER1D,
        D3D10_SVT_SAMPLER2D = D3D_SVT_SAMPLER2D,
        D3D10_SVT_SAMPLER3D = D3D_SVT_SAMPLER3D,
        D3D10_SVT_SAMPLERCUBE = D3D_SVT_SAMPLERCUBE,
        D3D10_SVT_PIXELSHADER = D3D_SVT_PIXELSHADER,
        D3D10_SVT_VERTEXSHADER = D3D_SVT_VERTEXSHADER,
        D3D10_SVT_PIXELFRAGMENT = D3D_SVT_PIXELFRAGMENT,
        D3D10_SVT_VERTEXFRAGMENT = D3D_SVT_VERTEXFRAGMENT,
        D3D10_SVT_UINT = D3D_SVT_UINT,
        D3D10_SVT_UINT8 = D3D_SVT_UINT8,
        D3D10_SVT_GEOMETRYSHADER = D3D_SVT_GEOMETRYSHADER,
        D3D10_SVT_RASTERIZER = D3D_SVT_RASTERIZER,
        D3D10_SVT_DEPTHSTENCIL = D3D_SVT_DEPTHSTENCIL,
        D3D10_SVT_BLEND = D3D_SVT_BLEND,
        D3D10_SVT_BUFFER = D3D_SVT_BUFFER,
        D3D10_SVT_CBUFFER = D3D_SVT_CBUFFER,
        D3D10_SVT_TBUFFER = D3D_SVT_TBUFFER,
        D3D10_SVT_TEXTURE1DARRAY = D3D_SVT_TEXTURE1DARRAY,
        D3D10_SVT_TEXTURE2DARRAY = D3D_SVT_TEXTURE2DARRAY,
        D3D10_SVT_RENDERTARGETVIEW = D3D_SVT_RENDERTARGETVIEW,
        D3D10_SVT_DEPTHSTENCILVIEW = D3D_SVT_DEPTHSTENCILVIEW,
        D3D10_SVT_TEXTURE2DMS = D3D_SVT_TEXTURE2DMS,
        D3D10_SVT_TEXTURE2DMSARRAY = D3D_SVT_TEXTURE2DMSARRAY,
        D3D10_SVT_TEXTURECUBEARRAY = D3D_SVT_TEXTURECUBEARRAY,
        D3D11_SVT_HULLSHADER = D3D_SVT_HULLSHADER,
        D3D11_SVT_DOMAINSHADER = D3D_SVT_DOMAINSHADER,
        D3D11_SVT_INTERFACE_POINTER = D3D_SVT_INTERFACE_POINTER,
        D3D11_SVT_COMPUTESHADER = D3D_SVT_COMPUTESHADER,
        D3D11_SVT_DOUBLE = D3D_SVT_DOUBLE,
        D3D11_SVT_RWTEXTURE1D = D3D_SVT_RWTEXTURE1D,
        D3D11_SVT_RWTEXTURE1DARRAY = D3D_SVT_RWTEXTURE1DARRAY,
        D3D11_SVT_RWTEXTURE2D = D3D_SVT_RWTEXTURE2D,
        D3D11_SVT_RWTEXTURE2DARRAY = D3D_SVT_RWTEXTURE2DARRAY,
        D3D11_SVT_RWTEXTURE3D = D3D_SVT_RWTEXTURE3D,
        D3D11_SVT_RWBUFFER = D3D_SVT_RWBUFFER,
        D3D11_SVT_BYTEADDRESS_BUFFER = D3D_SVT_BYTEADDRESS_BUFFER,
        D3D11_SVT_RWBYTEADDRESS_BUFFER = D3D_SVT_RWBYTEADDRESS_BUFFER,
        D3D11_SVT_STRUCTURED_BUFFER = D3D_SVT_STRUCTURED_BUFFER,
        D3D11_SVT_RWSTRUCTURED_BUFFER = D3D_SVT_RWSTRUCTURED_BUFFER,
        D3D11_SVT_APPEND_STRUCTURED_BUFFER = D3D_SVT_APPEND_STRUCTURED_BUFFER,
        D3D11_SVT_CONSUME_STRUCTURED_BUFFER = D3D_SVT_CONSUME_STRUCTURED_BUFFER,
        D3D_SVT_FORCE_DWORD = 0x7fffffff,
    }
}
