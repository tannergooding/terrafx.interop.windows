// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA" /> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATATests
{
    /// <summary>Validates that the <see cref="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA>(), Is.EqualTo(sizeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA)));
    }

    /// <summary>Validates that the <see cref="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D11_KEY_EXCHANGE_HW_PROTECTION_INPUT_DATA), Is.EqualTo(12));
    }
}