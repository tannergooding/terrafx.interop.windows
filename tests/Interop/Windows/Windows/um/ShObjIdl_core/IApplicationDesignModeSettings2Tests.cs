// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IApplicationDesignModeSettings2" /> struct.</summary>
[SupportedOSPlatform("windows6.3")]
public static unsafe partial class IApplicationDesignModeSettings2Tests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IApplicationDesignModeSettings2" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IApplicationDesignModeSettings2).GUID, Is.EqualTo(IID_IApplicationDesignModeSettings2));
    }
}
