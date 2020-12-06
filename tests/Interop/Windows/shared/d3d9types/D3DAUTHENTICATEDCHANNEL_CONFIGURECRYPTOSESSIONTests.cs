// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION" /> struct.</summary>
    public static unsafe class D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSIONTests
    {
        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION>(), Is.EqualTo(sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION)));
        }

        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            if (Environment.Is64BitProcess)
            {
                Assert.That(sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION), Is.EqualTo(72));
            }
            else
            {
                Assert.That(sizeof(D3DAUTHENTICATEDCHANNEL_CONFIGURECRYPTOSESSION), Is.EqualTo(52));
            }
        }
    }
}
