// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DECRYPTION_STATUS_BUFFER" /> struct.</summary>
public static unsafe partial class DECRYPTION_STATUS_BUFFERTests
{
    /// <summary>Validates that the <see cref="DECRYPTION_STATUS_BUFFER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DECRYPTION_STATUS_BUFFER>(), Is.EqualTo(sizeof(DECRYPTION_STATUS_BUFFER)));
    }

    /// <summary>Validates that the <see cref="DECRYPTION_STATUS_BUFFER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DECRYPTION_STATUS_BUFFER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DECRYPTION_STATUS_BUFFER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(DECRYPTION_STATUS_BUFFER), Is.EqualTo(1));
    }
}
