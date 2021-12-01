// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_CHANNEL_PROPERTY.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY"]/*' />
public unsafe partial struct WS_CHANNEL_PROPERTY
{
    /// <include file='WS_CHANNEL_PROPERTY.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY.id"]/*' />
    public WS_CHANNEL_PROPERTY_ID id;

    /// <include file='WS_CHANNEL_PROPERTY.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY.value"]/*' />
    public void* value;

    /// <include file='WS_CHANNEL_PROPERTY.xml' path='doc/member[@name="WS_CHANNEL_PROPERTY.valueSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint valueSize;
}