// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispHTMLWindow2" /> struct.</summary>
public static unsafe partial class DispHTMLWindow2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispHTMLWindow2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispHTMLWindow2).GUID, Is.EqualTo(IID_DispHTMLWindow2));
    }

    /// <summary>Validates that the <see cref="DispHTMLWindow2" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispHTMLWindow2>(), Is.EqualTo(sizeof(DispHTMLWindow2)));
    }

    /// <summary>Validates that the <see cref="DispHTMLWindow2" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispHTMLWindow2).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispHTMLWindow2" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispHTMLWindow2), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispHTMLWindow2), Is.EqualTo(4));
        }
    }
}