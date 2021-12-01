// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_CONSTRAINT"]/*' />
public unsafe partial struct WS_SECURITY_BINDING_PROPERTY_CONSTRAINT
{
    /// <include file='WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.id"]/*' />
    public WS_SECURITY_BINDING_PROPERTY_ID id;

    /// <include file='WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.allowedValues"]/*' />
    public void* allowedValues;

    /// <include file='WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.allowedValuesSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint allowedValuesSize;

    /// <include file='WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.xml' path='doc/member[@name="WS_SECURITY_BINDING_PROPERTY_CONSTRAINT.@out"]/*' />
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/WebServices.h:6147:5)")]
    public _out_e__Struct @out;

    /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct"]/*' />
    public partial struct _out_e__Struct
    {
        /// <include file='_out_e__Struct.xml' path='doc/member[@name="_out_e__Struct.securityBindingProperty"]/*' />
        public WS_SECURITY_BINDING_PROPERTY securityBindingProperty;
    }
}