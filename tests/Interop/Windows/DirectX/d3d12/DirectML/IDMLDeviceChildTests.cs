// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from DirectML.h in microsoft/DirectX-Headers tag v1.614.0
// Original source is Copyright © Microsoft. Licensed under the MIT license

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="IDMLDeviceChild" /> struct.</summary>
public static unsafe partial class IDMLDeviceChildTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDMLDeviceChild" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDMLDeviceChild).GUID, Is.EqualTo(IID_IDMLDeviceChild));
    }
}
