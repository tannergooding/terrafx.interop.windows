// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/immdev.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CANDIDATEINFO" /> struct.</summary>
    public static unsafe class CANDIDATEINFOTests
    {
        /// <summary>Validates that the <see cref="CANDIDATEINFO" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CANDIDATEINFO>(), Is.EqualTo(sizeof(CANDIDATEINFO)));
        }

        /// <summary>Validates that the <see cref="CANDIDATEINFO" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CANDIDATEINFO).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CANDIDATEINFO" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CANDIDATEINFO), Is.EqualTo(144));
        }
    }
}
