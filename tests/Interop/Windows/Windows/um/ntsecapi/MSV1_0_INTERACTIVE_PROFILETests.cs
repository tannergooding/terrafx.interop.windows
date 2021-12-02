// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MSV1_0_INTERACTIVE_PROFILE" /> struct.</summary>
public static unsafe partial class MSV1_0_INTERACTIVE_PROFILETests
{
    /// <summary>Validates that the <see cref="MSV1_0_INTERACTIVE_PROFILE" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MSV1_0_INTERACTIVE_PROFILE>(), Is.EqualTo(sizeof(MSV1_0_INTERACTIVE_PROFILE)));
    }

    /// <summary>Validates that the <see cref="MSV1_0_INTERACTIVE_PROFILE" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MSV1_0_INTERACTIVE_PROFILE).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MSV1_0_INTERACTIVE_PROFILE" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(MSV1_0_INTERACTIVE_PROFILE), Is.EqualTo(160));
        }
        else
        {
            Assert.That(sizeof(MSV1_0_INTERACTIVE_PROFILE), Is.EqualTo(112));
        }
    }
}
