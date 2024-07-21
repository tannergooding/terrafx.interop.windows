// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SpatialAudioHrtf.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct.</summary>
[SupportedOSPlatform("windows10.0.15063.0")]
public static unsafe partial class ISpatialAudioObjectRenderStreamForHrtfTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="ISpatialAudioObjectRenderStreamForHrtf" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpatialAudioObjectRenderStreamForHrtf).GUID, Is.EqualTo(IID_ISpatialAudioObjectRenderStreamForHrtf));
    }
}
