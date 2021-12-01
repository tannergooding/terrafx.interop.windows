// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WICBitmapPlane" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class WICBitmapPlaneTests
{
    /// <summary>Validates that the <see cref="WICBitmapPlane" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WICBitmapPlane>(), Is.EqualTo(sizeof(WICBitmapPlane)));
    }

    /// <summary>Validates that the <see cref="WICBitmapPlane" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WICBitmapPlane).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WICBitmapPlane" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WICBitmapPlane), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WICBitmapPlane), Is.EqualTo(28));
        }
    }
}