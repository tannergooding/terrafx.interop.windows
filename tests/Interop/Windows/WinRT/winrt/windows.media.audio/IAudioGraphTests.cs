// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from winrt/windows.media.audio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref="IAudioGraph" /> struct.</summary>
public static unsafe partial class IAudioGraphTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IAudioGraph" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IAudioGraph).GUID, Is.EqualTo(IID_IAudioGraph));
    }
}
