// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IFileDialogControlEvents" /> struct.</summary>
public static unsafe partial class IFileDialogControlEventsTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IFileDialogControlEvents" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IFileDialogControlEvents).GUID, Is.EqualTo(IID_IFileDialogControlEvents));
    }

    /// <summary>Validates that the <see cref="IFileDialogControlEvents" /> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IFileDialogControlEvents>(), Is.EqualTo(sizeof(IFileDialogControlEvents)));
    }

    /// <summary>Validates that the <see cref="IFileDialogControlEvents" /> struct has the right <see cref="LayoutKind" />.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IFileDialogControlEvents).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref="IFileDialogControlEvents" /> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IFileDialogControlEvents), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IFileDialogControlEvents), Is.EqualTo(4));
        }
    }
}