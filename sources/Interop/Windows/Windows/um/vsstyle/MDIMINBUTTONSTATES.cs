// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MDIMINBUTTONSTATES.xml' path='doc/member[@name="MDIMINBUTTONSTATES"]/*' />
public enum MDIMINBUTTONSTATES
{
    /// <include file='MDIMINBUTTONSTATES.xml' path='doc/member[@name="MDIMINBUTTONSTATES.MDMI_NORMAL"]/*' />
    MDMI_NORMAL = 1,

    /// <include file='MDIMINBUTTONSTATES.xml' path='doc/member[@name="MDIMINBUTTONSTATES.MDMI_HOT"]/*' />
    MDMI_HOT = 2,

    /// <include file='MDIMINBUTTONSTATES.xml' path='doc/member[@name="MDIMINBUTTONSTATES.MDMI_PUSHED"]/*' />
    MDMI_PUSHED = 3,

    /// <include file='MDIMINBUTTONSTATES.xml' path='doc/member[@name="MDIMINBUTTONSTATES.MDMI_DISABLED"]/*' />
    MDMI_DISABLED = 4,
}
