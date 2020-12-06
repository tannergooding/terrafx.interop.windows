// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IDirect3DDevice9Video" /> struct.</summary>
    public static unsafe class IDirect3DDevice9VideoTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IDirect3DDevice9Video" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IDirect3DDevice9Video).GUID, Is.EqualTo(IID_IDirect3DDevice9Video));
        }

        /// <summary>Validates that the <see cref="IDirect3DDevice9Video" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IDirect3DDevice9Video>(), Is.EqualTo(sizeof(IDirect3DDevice9Video)));
        }

        /// <summary>Validates that the <see cref="IDirect3DDevice9Video" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IDirect3DDevice9Video).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IDirect3DDevice9Video" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IDirect3DDevice9Video), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IDirect3DDevice9Video), Is.EqualTo(4));
            }
        }
    }
}
