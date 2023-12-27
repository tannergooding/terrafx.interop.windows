// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.applicationmodel.email.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.WinRT;

/// <include file='IEmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeSigningAlgorithm"]/*' />
public enum IEmailMailboxSmimeSigningAlgorithm
{
    /// <include file='IEmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_Any"]/*' />
    EmailMailboxSmimeSigningAlgorithm_Any = 0,

    /// <include file='IEmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_Sha1"]/*' />
    EmailMailboxSmimeSigningAlgorithm_Sha1 = 1,

    /// <include file='IEmailMailboxSmimeSigningAlgorithm.xml' path='doc/member[@name="IEmailMailboxSmimeSigningAlgorithm.EmailMailboxSmimeSigningAlgorithm_MD5"]/*' />
    EmailMailboxSmimeSigningAlgorithm_MD5 = 2,
}
