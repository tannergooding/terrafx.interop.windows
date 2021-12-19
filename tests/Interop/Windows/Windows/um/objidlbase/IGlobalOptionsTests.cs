// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IGlobalOptions" /> struct.</summary>
public static unsafe partial class IGlobalOptionsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IGlobalOptions" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IGlobalOptions).GUID, Is.EqualTo(IID_IGlobalOptions));
    }

    /// <summary>Validates that the <see cref="IGlobalOptions" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IGlobalOptions>(), Is.EqualTo(sizeof(IGlobalOptions)));
    }

    /// <summary>Validates that the <see cref="IGlobalOptions" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IGlobalOptions).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IGlobalOptions" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IGlobalOptions), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IGlobalOptions), Is.EqualTo(4));
        }
    }
}
