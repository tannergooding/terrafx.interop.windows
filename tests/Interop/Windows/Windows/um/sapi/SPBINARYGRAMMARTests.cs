// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SPBINARYGRAMMAR" /> struct.</summary>
public static unsafe partial class SPBINARYGRAMMARTests
{
    /// <summary>Validates that the <see cref="SPBINARYGRAMMAR" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SPBINARYGRAMMAR>(), Is.EqualTo(sizeof(SPBINARYGRAMMAR)));
    }

    /// <summary>Validates that the <see cref="SPBINARYGRAMMAR" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SPBINARYGRAMMAR).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SPBINARYGRAMMAR" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(SPBINARYGRAMMAR), Is.EqualTo(4));
    }
}