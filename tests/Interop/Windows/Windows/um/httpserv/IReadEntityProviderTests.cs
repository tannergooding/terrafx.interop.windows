// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;

/// <summary>Provides validation of the <see cref="IReadEntityProvider" /> struct.</summary>
public static unsafe partial class IReadEntityProviderTests
{
    /// <summary>Validates that the <see cref="Guid" /> of the <see cref="IReadEntityProvider" /> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IReadEntityProvider).GUID, Is.EqualTo(IID_IReadEntityProvider));
    }
}