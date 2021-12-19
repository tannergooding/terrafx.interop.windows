// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SPC_LINK" /> struct.</summary>
public static unsafe partial class SPC_LINKTests
{
    /// <summary>Validates that the <see cref="SPC_LINK" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPC_LINK>(), Is.EqualTo(sizeof(SPC_LINK)));
    }

    /// <summary>Validates that the <see cref="SPC_LINK" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPC_LINK).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SPC_LINK" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SPC_LINK), Is.EqualTo(40));
        }
        else
        {
            Assert.That(sizeof(SPC_LINK), Is.EqualTo(28));
        }
    }
}
