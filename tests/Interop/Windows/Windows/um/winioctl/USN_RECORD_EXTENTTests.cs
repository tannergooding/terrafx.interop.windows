// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="USN_RECORD_EXTENT" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class USN_RECORD_EXTENTTests
{
    /// <summary>Validates that the <see cref="USN_RECORD_EXTENT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<USN_RECORD_EXTENT>(), Is.EqualTo(sizeof(USN_RECORD_EXTENT)));
    }

    /// <summary>Validates that the <see cref="USN_RECORD_EXTENT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(USN_RECORD_EXTENT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="USN_RECORD_EXTENT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(USN_RECORD_EXTENT), Is.EqualTo(16));
    }
}