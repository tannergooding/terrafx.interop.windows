// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9caps.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3DPSHADERCAPS2_0" /> struct.</summary>
    public static unsafe class D3DPSHADERCAPS2_0Tests
    {
        /// <summary>Validates that the <see cref="D3DPSHADERCAPS2_0" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3DPSHADERCAPS2_0>(), Is.EqualTo(sizeof(D3DPSHADERCAPS2_0)));
        }

        /// <summary>Validates that the <see cref="D3DPSHADERCAPS2_0" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3DPSHADERCAPS2_0).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3DPSHADERCAPS2_0" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(D3DPSHADERCAPS2_0), Is.EqualTo(20));
        }
    }
}
