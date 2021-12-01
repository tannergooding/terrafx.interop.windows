// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="DispXMLHttpRequestEventTarget" /> struct.</summary>
public static unsafe partial class DispXMLHttpRequestEventTargetTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="DispXMLHttpRequestEventTarget" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(DispXMLHttpRequestEventTarget).GUID, Is.EqualTo(IID_DispXMLHttpRequestEventTarget));
    }

    /// <summary>Validates that the <see cref="DispXMLHttpRequestEventTarget" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<DispXMLHttpRequestEventTarget>(), Is.EqualTo(sizeof(DispXMLHttpRequestEventTarget)));
    }

    /// <summary>Validates that the <see cref="DispXMLHttpRequestEventTarget" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(DispXMLHttpRequestEventTarget).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="DispXMLHttpRequestEventTarget" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(DispXMLHttpRequestEventTarget), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(DispXMLHttpRequestEventTarget), Is.EqualTo(4));
        }
    }
}