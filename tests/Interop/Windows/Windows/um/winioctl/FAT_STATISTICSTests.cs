// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FAT_STATISTICS" /> struct.</summary>
public static unsafe partial class FAT_STATISTICSTests
{
    /// <summary>Validates that the <see cref="FAT_STATISTICS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FAT_STATISTICS>(), Is.EqualTo(sizeof(FAT_STATISTICS)));
    }

    /// <summary>Validates that the <see cref="FAT_STATISTICS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FAT_STATISTICS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FAT_STATISTICS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FAT_STATISTICS), Is.EqualTo(36));
    }
}