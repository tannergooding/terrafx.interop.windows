// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct CMSG_SIGNER_ENCODE_INFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("PCERT_INFO")]
        public CERT_INFO* pCertInfo;

        [NativeTypeName("_CMSG_SIGNER_ENCODE_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/wincrypt.h:6732:5)")]
        public _Anonymous_e__Union Anonymous;

        [NativeTypeName("DWORD")]
        public uint dwKeySpec;

        public CRYPT_ALGORITHM_IDENTIFIER HashAlgorithm;

        public void* pvHashAuxInfo;

        [NativeTypeName("DWORD")]
        public uint cAuthAttr;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgAuthAttr;

        [NativeTypeName("DWORD")]
        public uint cUnauthAttr;

        [NativeTypeName("PCRYPT_ATTRIBUTE")]
        public CRYPT_ATTRIBUTE* rgUnauthAttr;

        public ref nuint hCryptProv
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hCryptProv, 1));
            }
        }

        public ref nuint hNCryptKey
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.hNCryptKey, 1));
            }
        }

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("HCRYPTPROV")]
            public nuint hCryptProv;

            [FieldOffset(0)]
            [NativeTypeName("NCRYPT_KEY_HANDLE")]
            public nuint hNCryptKey;
        }
    }
}
