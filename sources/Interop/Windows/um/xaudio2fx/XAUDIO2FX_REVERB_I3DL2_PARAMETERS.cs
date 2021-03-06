// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xaudio2fx.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct XAUDIO2FX_REVERB_I3DL2_PARAMETERS
    {
        public float WetDryMix;

        [NativeTypeName("INT32")]
        public int Room;

        [NativeTypeName("INT32")]
        public int RoomHF;

        public float RoomRolloffFactor;

        public float DecayTime;

        public float DecayHFRatio;

        [NativeTypeName("INT32")]
        public int Reflections;

        public float ReflectionsDelay;

        [NativeTypeName("INT32")]
        public int Reverb;

        public float ReverbDelay;

        public float Diffusion;

        public float Density;

        public float HFReference;
    }
}
