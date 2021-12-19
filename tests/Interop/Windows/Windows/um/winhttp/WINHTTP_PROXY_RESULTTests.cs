// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="WINHTTP_PROXY_RESULT" /> struct.</summary>
[SupportedOSPlatform("windows8.0")]
public static unsafe partial class WINHTTP_PROXY_RESULTTests
{
    /// <summary>Validates that the <see cref="WINHTTP_PROXY_RESULT" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_PROXY_RESULT>(), Is.EqualTo(sizeof(WINHTTP_PROXY_RESULT)));
    }

    /// <summary>Validates that the <see cref="WINHTTP_PROXY_RESULT" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_PROXY_RESULT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="WINHTTP_PROXY_RESULT" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINHTTP_PROXY_RESULT), Is.EqualTo(16));
        }
        else
        {
            Assert.That(sizeof(WINHTTP_PROXY_RESULT), Is.EqualTo(8));
        }
    }
}
