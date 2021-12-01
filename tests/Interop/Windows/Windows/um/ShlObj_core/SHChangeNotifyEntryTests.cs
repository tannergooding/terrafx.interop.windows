// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="SHChangeNotifyEntry" /> struct.</summary>
public static unsafe partial class SHChangeNotifyEntryTests
{
    /// <summary>Validates that the <see cref="SHChangeNotifyEntry" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SHChangeNotifyEntry>(), Is.EqualTo(sizeof(SHChangeNotifyEntry)));
    }

    /// <summary>Validates that the <see cref="SHChangeNotifyEntry" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SHChangeNotifyEntry).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="SHChangeNotifyEntry" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SHChangeNotifyEntry), Is.EqualTo(12));
        }
        else
        {
            Assert.That(sizeof(SHChangeNotifyEntry), Is.EqualTo(8));
        }
    }
}