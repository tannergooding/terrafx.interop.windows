// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/Iprtrmib.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MIB_OPAQUE_QUERY" /> struct.</summary>
public static unsafe partial class MIB_OPAQUE_QUERYTests
{
    /// <summary>Validates that the <see cref="MIB_OPAQUE_QUERY" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MIB_OPAQUE_QUERY>(), Is.EqualTo(sizeof(MIB_OPAQUE_QUERY)));
    }

    /// <summary>Validates that the <see cref="MIB_OPAQUE_QUERY" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MIB_OPAQUE_QUERY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MIB_OPAQUE_QUERY" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MIB_OPAQUE_QUERY), Is.EqualTo(8));
    }
}
