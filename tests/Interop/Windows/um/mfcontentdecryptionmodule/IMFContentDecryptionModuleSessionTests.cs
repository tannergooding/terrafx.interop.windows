// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfcontentdecryptionmodule.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IMFContentDecryptionModuleSession" /> struct.</summary>
    public static unsafe class IMFContentDecryptionModuleSessionTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IMFContentDecryptionModuleSession" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IMFContentDecryptionModuleSession).GUID, Is.EqualTo(IID_IMFContentDecryptionModuleSession));
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModuleSession" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IMFContentDecryptionModuleSession>(), Is.EqualTo(sizeof(IMFContentDecryptionModuleSession)));
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModuleSession" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IMFContentDecryptionModuleSession).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IMFContentDecryptionModuleSession" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IMFContentDecryptionModuleSession), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IMFContentDecryptionModuleSession), Is.EqualTo(4));
            }
        }
    }
}
