// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ICONMETRICSA" /> struct.</summary>
public static unsafe partial class ICONMETRICSATests
{
    /// <summary>Validates that the <see cref="ICONMETRICSA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ICONMETRICSA>(), Is.EqualTo(sizeof(ICONMETRICSA)));
    }

    /// <summary>Validates that the <see cref="ICONMETRICSA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ICONMETRICSA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="ICONMETRICSA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(ICONMETRICSA), Is.EqualTo(76));
    }
}
