// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ProcessSnapshot.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="PSS_PERFORMANCE_COUNTERS" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class PSS_PERFORMANCE_COUNTERSTests
{
    /// <summary>Validates that the <see cref="PSS_PERFORMANCE_COUNTERS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<PSS_PERFORMANCE_COUNTERS>(), Is.EqualTo(sizeof(PSS_PERFORMANCE_COUNTERS)));
    }

    /// <summary>Validates that the <see cref="PSS_PERFORMANCE_COUNTERS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(PSS_PERFORMANCE_COUNTERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="PSS_PERFORMANCE_COUNTERS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(PSS_PERFORMANCE_COUNTERS), Is.EqualTo(96));
    }
}
