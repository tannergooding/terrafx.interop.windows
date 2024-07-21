// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT"]/*' />
public partial struct D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT
{
    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT.Input"]/*' />
    public D3DAUTHENTICATEDCHANNEL_QUERY_INPUT Input;

    /// <include file='D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT.xml' path='doc/member[@name="D3DAUTHENTICATEDCHANNEL_QUERYCRYPTOSESSION_INPUT.DXVA2DecodeHandle"]/*' />
    public HANDLE DXVA2DecodeHandle;
}
