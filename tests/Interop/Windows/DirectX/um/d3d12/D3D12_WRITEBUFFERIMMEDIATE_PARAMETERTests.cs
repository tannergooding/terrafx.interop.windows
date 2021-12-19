// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER" /> struct.</summary>
public static unsafe partial class D3D12_WRITEBUFFERIMMEDIATE_PARAMETERTests
{
    /// <summary>Validates that the <see cref="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<D3D12_WRITEBUFFERIMMEDIATE_PARAMETER>(), Is.EqualTo(sizeof(D3D12_WRITEBUFFERIMMEDIATE_PARAMETER)));
    }

    /// <summary>Validates that the <see cref="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(D3D12_WRITEBUFFERIMMEDIATE_PARAMETER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="D3D12_WRITEBUFFERIMMEDIATE_PARAMETER" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(D3D12_WRITEBUFFERIMMEDIATE_PARAMETER), Is.EqualTo(16));
    }
}
