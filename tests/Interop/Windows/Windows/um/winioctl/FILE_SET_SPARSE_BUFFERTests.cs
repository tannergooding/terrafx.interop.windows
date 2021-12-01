// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="FILE_SET_SPARSE_BUFFER" /> struct.</summary>
public static unsafe partial class FILE_SET_SPARSE_BUFFERTests
{
    /// <summary>Validates that the <see cref="FILE_SET_SPARSE_BUFFER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<FILE_SET_SPARSE_BUFFER>(), Is.EqualTo(sizeof(FILE_SET_SPARSE_BUFFER)));
    }

    /// <summary>Validates that the <see cref="FILE_SET_SPARSE_BUFFER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(FILE_SET_SPARSE_BUFFER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="FILE_SET_SPARSE_BUFFER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(FILE_SET_SPARSE_BUFFER), Is.EqualTo(1));
    }
}