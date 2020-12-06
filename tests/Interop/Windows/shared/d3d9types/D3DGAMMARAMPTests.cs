// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3DGAMMARAMP" /> struct.</summary>
    public static unsafe class D3DGAMMARAMPTests
    {
        /// <summary>Validates that the <see cref="D3DGAMMARAMP" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3DGAMMARAMP>(), Is.EqualTo(sizeof(D3DGAMMARAMP)));
        }

        /// <summary>Validates that the <see cref="D3DGAMMARAMP" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3DGAMMARAMP).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3DGAMMARAMP" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3DGAMMARAMP), Is.EqualTo(1536));
        }
    }
}
