// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D2D1_INPUT_ELEMENT_DESC" /> struct.</summary>
public static unsafe partial class D2D1_INPUT_ELEMENT_DESCTests
{
    /// <summary>Validates that the <see cref="D2D1_INPUT_ELEMENT_DESC" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D2D1_INPUT_ELEMENT_DESC>(), Is.EqualTo(sizeof(D2D1_INPUT_ELEMENT_DESC)));
    }

    /// <summary>Validates that the <see cref="D2D1_INPUT_ELEMENT_DESC" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D2D1_INPUT_ELEMENT_DESC).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D2D1_INPUT_ELEMENT_DESC" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(D2D1_INPUT_ELEMENT_DESC), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(D2D1_INPUT_ELEMENT_DESC), Is.EqualTo(20));
        }
    }
}