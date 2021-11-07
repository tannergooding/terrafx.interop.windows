// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="STORAGE_PHYSICAL_DEVICE_DATA" /> struct.</summary>
    [SupportedOSPlatform("windows10.0")]
    public static unsafe partial class STORAGE_PHYSICAL_DEVICE_DATATests
    {
        /// <summary>Validates that the <see cref="STORAGE_PHYSICAL_DEVICE_DATA" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<STORAGE_PHYSICAL_DEVICE_DATA>(), Is.EqualTo(sizeof(STORAGE_PHYSICAL_DEVICE_DATA)));
        }

        /// <summary>Validates that the <see cref="STORAGE_PHYSICAL_DEVICE_DATA" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(STORAGE_PHYSICAL_DEVICE_DATA).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="STORAGE_PHYSICAL_DEVICE_DATA" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(STORAGE_PHYSICAL_DEVICE_DATA), Is.EqualTo(136));
        }
    }
}
