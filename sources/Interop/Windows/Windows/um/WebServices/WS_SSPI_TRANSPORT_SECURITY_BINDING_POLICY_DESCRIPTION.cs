// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION"]/*' />
public partial struct WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION
{
    /// <include file='WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION.xml' path='doc/member[@name="WS_SSPI_TRANSPORT_SECURITY_BINDING_POLICY_DESCRIPTION.securityBindingProperties"]/*' />
    public WS_SECURITY_BINDING_PROPERTIES securityBindingProperties;
}
