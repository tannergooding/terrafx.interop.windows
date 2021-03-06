// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="IAudioClientDuckingControl" /> struct.</summary>
    public static unsafe class IAudioClientDuckingControlTests
    {
        /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAudioClientDuckingControl" /> struct is correct.</summary>
        [Test]
        public static void GuidOfTest()
        {
            Assert.That(typeof(IAudioClientDuckingControl).GUID, Is.EqualTo(IID_IAudioClientDuckingControl));
        }

        /// <summary>Validates that the <see cref="IAudioClientDuckingControl" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<IAudioClientDuckingControl>(), Is.EqualTo(sizeof(IAudioClientDuckingControl)));
        }

        /// <summary>Validates that the <see cref="IAudioClientDuckingControl" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(IAudioClientDuckingControl).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="IAudioClientDuckingControl" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(IAudioClientDuckingControl), Is.EqualTo(8));
            }
            else
            {
                Assert.That(sizeof(IAudioClientDuckingControl), Is.EqualTo(4));
            }
        }
    }
}
