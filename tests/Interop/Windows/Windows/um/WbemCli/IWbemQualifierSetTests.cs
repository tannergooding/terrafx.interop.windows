// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IWbemQualifierSet" /> struct.</summary>
public static unsafe partial class IWbemQualifierSetTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IWbemQualifierSet" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IWbemQualifierSet).GUID, Is.EqualTo(IID_IWbemQualifierSet));
    }

    /// <summary>Validates that the <see cref="IWbemQualifierSet" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IWbemQualifierSet>(), Is.EqualTo(sizeof(IWbemQualifierSet)));
    }

    /// <summary>Validates that the <see cref="IWbemQualifierSet" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IWbemQualifierSet).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IWbemQualifierSet" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IWbemQualifierSet), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IWbemQualifierSet), Is.EqualTo(4));
        }
    }
}