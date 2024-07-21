// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdipluseffects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using static TerraFX.Interop.Gdiplus.Gdiplus;

namespace TerraFX.Interop.Gdiplus;

public unsafe partial struct Sharpen : Sharpen.Interface
{
    public Sharpen()
    {
        Base = new Effect();

        CGpEffect* nativeEffect;
        _ = GdipCreateEffect(SharpenEffectGuid, &nativeEffect);
        Base.nativeEffect = nativeEffect;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public void Dispose()
    {
        ((delegate* unmanaged<Sharpen*, void>)(Base.lpVtbl[0]))((Sharpen*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : Effect.Interface
    {
    }
}
