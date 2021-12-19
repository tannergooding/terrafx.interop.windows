// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WAVEOUTCAPS2A" /> struct.</summary>
public static unsafe partial class WAVEOUTCAPS2ATests
{
    /// <summary>Validates that the <see cref="WAVEOUTCAPS2A" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WAVEOUTCAPS2A>(), Is.EqualTo(sizeof(WAVEOUTCAPS2A)));
    }

    /// <summary>Validates that the <see cref="WAVEOUTCAPS2A" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WAVEOUTCAPS2A).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WAVEOUTCAPS2A" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WAVEOUTCAPS2A), Is.EqualTo(100));
    }
}
