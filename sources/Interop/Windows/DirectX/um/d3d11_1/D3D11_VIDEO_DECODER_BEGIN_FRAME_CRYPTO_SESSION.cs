// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

[SupportedOSPlatform("windows10.0")]
public unsafe partial struct D3D11_VIDEO_DECODER_BEGIN_FRAME_CRYPTO_SESSION
{
    public ID3D11CryptoSession* pCryptoSession;

    public uint BlobSize;

    public void* pBlob;

    public Guid* pKeyInfoId;

    public uint PrivateDataSize;

    public void* pPrivateData;
}