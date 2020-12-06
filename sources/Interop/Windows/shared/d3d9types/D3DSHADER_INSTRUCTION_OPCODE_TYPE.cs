// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D3DSHADER_INSTRUCTION_OPCODE_TYPE
    {
        D3DSIO_NOP = 0,
        D3DSIO_MOV,
        D3DSIO_ADD,
        D3DSIO_SUB,
        D3DSIO_MAD,
        D3DSIO_MUL,
        D3DSIO_RCP,
        D3DSIO_RSQ,
        D3DSIO_DP3,
        D3DSIO_DP4,
        D3DSIO_MIN,
        D3DSIO_MAX,
        D3DSIO_SLT,
        D3DSIO_SGE,
        D3DSIO_EXP,
        D3DSIO_LOG,
        D3DSIO_LIT,
        D3DSIO_DST,
        D3DSIO_LRP,
        D3DSIO_FRC,
        D3DSIO_M4x4,
        D3DSIO_M4x3,
        D3DSIO_M3x4,
        D3DSIO_M3x3,
        D3DSIO_M3x2,
        D3DSIO_CALL,
        D3DSIO_CALLNZ,
        D3DSIO_LOOP,
        D3DSIO_RET,
        D3DSIO_ENDLOOP,
        D3DSIO_LABEL,
        D3DSIO_DCL,
        D3DSIO_POW,
        D3DSIO_CRS,
        D3DSIO_SGN,
        D3DSIO_ABS,
        D3DSIO_NRM,
        D3DSIO_SINCOS,
        D3DSIO_REP,
        D3DSIO_ENDREP,
        D3DSIO_IF,
        D3DSIO_IFC,
        D3DSIO_ELSE,
        D3DSIO_ENDIF,
        D3DSIO_BREAK,
        D3DSIO_BREAKC,
        D3DSIO_MOVA,
        D3DSIO_DEFB,
        D3DSIO_DEFI,
        D3DSIO_TEXCOORD = 64,
        D3DSIO_TEXKILL,
        D3DSIO_TEX,
        D3DSIO_TEXBEM,
        D3DSIO_TEXBEML,
        D3DSIO_TEXREG2AR,
        D3DSIO_TEXREG2GB,
        D3DSIO_TEXM3x2PAD,
        D3DSIO_TEXM3x2TEX,
        D3DSIO_TEXM3x3PAD,
        D3DSIO_TEXM3x3TEX,
        D3DSIO_RESERVED0,
        D3DSIO_TEXM3x3SPEC,
        D3DSIO_TEXM3x3VSPEC,
        D3DSIO_EXPP,
        D3DSIO_LOGP,
        D3DSIO_CND,
        D3DSIO_DEF,
        D3DSIO_TEXREG2RGB,
        D3DSIO_TEXDP3TEX,
        D3DSIO_TEXM3x2DEPTH,
        D3DSIO_TEXDP3,
        D3DSIO_TEXM3x3,
        D3DSIO_TEXDEPTH,
        D3DSIO_CMP,
        D3DSIO_BEM,
        D3DSIO_DP2ADD,
        D3DSIO_DSX,
        D3DSIO_DSY,
        D3DSIO_TEXLDD,
        D3DSIO_SETP,
        D3DSIO_TEXLDL,
        D3DSIO_BREAKP,
        D3DSIO_PHASE = 0xFFFD,
        D3DSIO_COMMENT = 0xFFFE,
        D3DSIO_END = 0xFFFF,
        D3DSIO_FORCE_DWORD = 0x7fffffff,
    }
}
