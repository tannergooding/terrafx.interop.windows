// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='PSS_THREAD_FLAGS.xml' path='doc/member[@name="PSS_THREAD_FLAGS"]/*' />
[Flags]
[SupportedOSPlatform("windows8.1")]
public enum PSS_THREAD_FLAGS
{
    /// <include file='PSS_THREAD_FLAGS.xml' path='doc/member[@name="PSS_THREAD_FLAGS.PSS_THREAD_FLAGS_NONE"]/*' />
    PSS_THREAD_FLAGS_NONE = 0x0000,

    /// <include file='PSS_THREAD_FLAGS.xml' path='doc/member[@name="PSS_THREAD_FLAGS.PSS_THREAD_FLAGS_TERMINATED"]/*' />
    PSS_THREAD_FLAGS_TERMINATED = 0x0001,
}