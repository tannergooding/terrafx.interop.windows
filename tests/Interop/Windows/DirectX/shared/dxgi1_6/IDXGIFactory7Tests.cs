// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/dxgi1_6.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDXGIFactory7" /> struct.</summary>
[SupportedOSPlatform("windows10.0.17763.0")]
public static unsafe partial class IDXGIFactory7Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDXGIFactory7" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDXGIFactory7).GUID, Is.EqualTo(IID_IDXGIFactory7));
    }
}
