// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES"]/*' />
public partial struct DXGI_GAMMA_CONTROL_CAPABILITIES
{
    /// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES.ScaleAndOffsetSupported"]/*' />
    public BOOL ScaleAndOffsetSupported;

    /// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES.MaxConvertedValue"]/*' />
    public float MaxConvertedValue;

    /// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES.MinConvertedValue"]/*' />
    public float MinConvertedValue;

    /// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES.NumGammaControlPoints"]/*' />
    public uint NumGammaControlPoints;

    /// <include file='DXGI_GAMMA_CONTROL_CAPABILITIES.xml' path='doc/member[@name="DXGI_GAMMA_CONTROL_CAPABILITIES.ControlPointPositions"]/*' />
    [NativeTypeName("float[1025]")]
    public _ControlPointPositions_e__FixedBuffer ControlPointPositions;

    /// <include file='_ControlPointPositions_e__FixedBuffer.xml' path='doc/member[@name="_ControlPointPositions_e__FixedBuffer"]/*' />
    [InlineArray(1025)]
    public partial struct _ControlPointPositions_e__FixedBuffer
    {
        public float e0;
    }
}
