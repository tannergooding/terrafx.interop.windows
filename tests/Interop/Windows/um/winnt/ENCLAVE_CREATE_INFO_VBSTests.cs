// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="ENCLAVE_CREATE_INFO_VBS" /> struct.</summary>
    public static unsafe class ENCLAVE_CREATE_INFO_VBSTests
    {
        /// <summary>Validates that the <see cref="ENCLAVE_CREATE_INFO_VBS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<ENCLAVE_CREATE_INFO_VBS>(), Is.EqualTo(sizeof(ENCLAVE_CREATE_INFO_VBS)));
        }

        /// <summary>Validates that the <see cref="ENCLAVE_CREATE_INFO_VBS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(ENCLAVE_CREATE_INFO_VBS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="ENCLAVE_CREATE_INFO_VBS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(ENCLAVE_CREATE_INFO_VBS), Is.EqualTo(36));
        }
    }
}
