// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="TAPE_GET_MEDIA_PARAMETERS" /> struct.</summary>
public static unsafe partial class TAPE_GET_MEDIA_PARAMETERSTests
{
    /// <summary>Validates that the <see cref="TAPE_GET_MEDIA_PARAMETERS" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TAPE_GET_MEDIA_PARAMETERS>(), Is.EqualTo(sizeof(TAPE_GET_MEDIA_PARAMETERS)));
    }

    /// <summary>Validates that the <see cref="TAPE_GET_MEDIA_PARAMETERS" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TAPE_GET_MEDIA_PARAMETERS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="TAPE_GET_MEDIA_PARAMETERS" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(TAPE_GET_MEDIA_PARAMETERS), Is.EqualTo(32));
    }
}