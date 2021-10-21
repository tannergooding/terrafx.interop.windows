// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="EXTRASEARCH" /> struct.</summary>
    public static unsafe partial class EXTRASEARCHTests
    {
        /// <summary>Validates that the <see cref="EXTRASEARCH" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<EXTRASEARCH>(), Is.EqualTo(sizeof(EXTRASEARCH)));
        }

        /// <summary>Validates that the <see cref="EXTRASEARCH" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(EXTRASEARCH).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="EXTRASEARCH" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(EXTRASEARCH), Is.EqualTo(4344));
        }
    }
}