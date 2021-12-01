// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IMFMediaSourceExtensionNotify" /> struct.</summary>
[SupportedOSPlatform("windows8.1")]
public static unsafe partial class IMFMediaSourceExtensionNotifyTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFMediaSourceExtensionNotify" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFMediaSourceExtensionNotify).GUID, Is.EqualTo(IID_IMFMediaSourceExtensionNotify));
    }

    /// <summary>Validates that the <see cref="IMFMediaSourceExtensionNotify" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFMediaSourceExtensionNotify>(), Is.EqualTo(sizeof(IMFMediaSourceExtensionNotify)));
    }

    /// <summary>Validates that the <see cref="IMFMediaSourceExtensionNotify" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFMediaSourceExtensionNotify).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IMFMediaSourceExtensionNotify" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFMediaSourceExtensionNotify), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFMediaSourceExtensionNotify), Is.EqualTo(4));
        }
    }
}