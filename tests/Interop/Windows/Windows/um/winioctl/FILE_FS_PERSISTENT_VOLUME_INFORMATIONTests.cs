// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FILE_FS_PERSISTENT_VOLUME_INFORMATION" /> struct.</summary>
public static unsafe partial class FILE_FS_PERSISTENT_VOLUME_INFORMATIONTests
{
    /// <summary>Validates that the <see cref="FILE_FS_PERSISTENT_VOLUME_INFORMATION" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_FS_PERSISTENT_VOLUME_INFORMATION>(), Is.EqualTo(sizeof(FILE_FS_PERSISTENT_VOLUME_INFORMATION)));
    }

    /// <summary>Validates that the <see cref="FILE_FS_PERSISTENT_VOLUME_INFORMATION" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_FS_PERSISTENT_VOLUME_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FILE_FS_PERSISTENT_VOLUME_INFORMATION" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_FS_PERSISTENT_VOLUME_INFORMATION), Is.EqualTo(16));
    }
}