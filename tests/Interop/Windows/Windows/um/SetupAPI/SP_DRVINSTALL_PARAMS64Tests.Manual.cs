// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SP_DRVINSTALL_PARAMS64" /> struct.</summary>
public static unsafe partial class SP_DRVINSTALL_PARAMS64Tests
{
    /// <summary>Validates that the <see cref="SP_DRVINSTALL_PARAMS64" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SP_DRVINSTALL_PARAMS64>(), Is.EqualTo(sizeof(SP_DRVINSTALL_PARAMS64)));
    }

    /// <summary>Validates that the <see cref="SP_DRVINSTALL_PARAMS64" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SP_DRVINSTALL_PARAMS64).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SP_DRVINSTALL_PARAMS64" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SP_DRVINSTALL_PARAMS64), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SP_DRVINSTALL_PARAMS64), Is.EqualTo(20));
        }
    }
}