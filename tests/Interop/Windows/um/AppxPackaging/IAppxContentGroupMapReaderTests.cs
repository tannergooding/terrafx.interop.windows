// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAppxContentGroupMapReader" /> struct.</summary>
    public static unsafe class IAppxContentGroupMapReaderTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAppxContentGroupMapReader" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAppxContentGroupMapReader).GUID, Is.EqualTo(IID_IAppxContentGroupMapReader));
        }

        /// <summary>Validates that the <see cref="IAppxContentGroupMapReader" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAppxContentGroupMapReader>(), Is.EqualTo(sizeof(IAppxContentGroupMapReader)));
        }

        /// <summary>Validates that the <see cref="IAppxContentGroupMapReader" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAppxContentGroupMapReader).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAppxContentGroupMapReader" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAppxContentGroupMapReader), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAppxContentGroupMapReader), Is.EqualTo(4));
            }
        }
    }
}
