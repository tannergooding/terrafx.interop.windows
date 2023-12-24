// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="ID3D12VideoProcessor1" /> struct.</summary>
[SupportedOSPlatform("windows10.0.19043.0")]
public static unsafe partial class ID3D12VideoProcessor1Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ID3D12VideoProcessor1" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ID3D12VideoProcessor1).GUID, Is.EqualTo(IID_ID3D12VideoProcessor1));
    }
}
