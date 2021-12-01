// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IAgileReference" /> struct.</summary>
public static unsafe partial class IAgileReferenceTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAgileReference" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAgileReference).GUID, Is.EqualTo(IID_IAgileReference));
    }

    /// <summary>Validates that the <see cref="IAgileReference" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IAgileReference>(), Is.EqualTo(sizeof(IAgileReference)));
    }

    /// <summary>Validates that the <see cref="IAgileReference" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IAgileReference).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IAgileReference" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IAgileReference), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IAgileReference), Is.EqualTo(4));
        }
    }
}