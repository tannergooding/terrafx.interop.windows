// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATATests
{
    /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA>(), Is.EqualTo(sizeof(MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA)));
    }

    /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA), Is.EqualTo(528));
    }
}
