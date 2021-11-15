// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows
{
    public static unsafe partial class Windows
    {
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaSession(IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePMPMediaSession([NativeTypeName("DWORD")] uint dwCreationFlags, IMFAttributes* pConfiguration, IMFMediaSession** ppMediaSession, IMFActivate** ppEnablerActivate);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSourceResolver(IMFSourceResolver** ppISourceResolver);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT CreatePropertyStore(IPropertyStore** ppStore);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedSchemes(PROPVARIANT* pPropVarSchemeArray);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSupportedMimeTypes(PROPVARIANT* pPropVarMimeTypeArray);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopology(IMFTopology** ppTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopologyNode(MF_TOPOLOGY_TYPE NodeType, IMFTopologyNode** ppNode);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetTopoNodeCurrentType(IMFTopologyNode* pNode, [NativeTypeName("DWORD")] uint dwStreamIndex, BOOL fOutput, IMFMediaType** ppType);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetService(IUnknown* punkObject, [NativeTypeName("const GUID &")] Guid* guidService, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvObject);

        [DllImport("mfplat", ExactSpelling = true)]
        [return: NativeTypeName("MFTIME")]
        public static extern long MFGetSystemTime();

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationClock(IMFPresentationClock** ppPresentationClock);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateSystemTimeSource(IMFPresentationTimeSource** ppSystemTimeSource);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePresentationDescriptor([NativeTypeName("DWORD")] uint cStreamDescriptors, IMFStreamDescriptor** apStreamDescriptors, IMFPresentationDescriptor** ppPresentationDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFRequireProtectedEnvironment(IMFPresentationDescriptor* pPresentationDescriptor);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFSerializePresentationDescriptor(IMFPresentationDescriptor* pPD, [NativeTypeName("DWORD *")] uint* pcbData, byte** ppbData);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFDeserializePresentationDescriptor([NativeTypeName("DWORD")] uint cbData, byte* pbData, IMFPresentationDescriptor** ppPD);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamDescriptor([NativeTypeName("DWORD")] uint dwStreamIdentifier, [NativeTypeName("DWORD")] uint cMediaTypes, IMFMediaType** apMediaTypes, IMFStreamDescriptor** ppDescriptor);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSimpleTypeHandler(IMFMediaTypeHandler** ppHandler);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFShutdownObject(IUnknown* pUnk);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRenderer(IMFAttributes* pAudioAttributes, IMFMediaSink** ppSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAudioRendererActivate(IMFActivate** ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateVideoRendererActivate(HWND hwndVideo, IMFActivate** ppActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreate3GPMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMP3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAC3MediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateADTSMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateMuxSink(Guid guidOutputSubType, IMFAttributes* pOutputAttributes, IMFByteStream* pOutputByteStream, IMFMediaSink** ppMuxSink);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateFMPEG4MediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateAVIMediaSink(IMFByteStream* pIByteStream, IMFMediaType* pVideoMediaType, IMFMediaType* pAudioMediaType, IMFMediaSink** ppIMediaSink);

        [SupportedOSPlatform("windows8.1")]
        [DllImport("mfsrcsnk", ExactSpelling = true)]
        public static extern HRESULT MFCreateWAVEMediaSink(IMFByteStream* pTargetByteStream, IMFMediaType* pAudioMediaType, IMFMediaSink** ppMediaSink);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTopoLoader(IMFTopoLoader** ppObj);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV1_LicenseAcquisition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAF, 0xEE, 0xF6, 0x4F,
                    0x43, 0x0B,
                    0x97, 0x47,
                    0x9B,
                    0x85,
                    0xAB,
                    0xF3,
                    0x18,
                    0x15,
                    0xE7,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV7_LicenseAcquisition
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0x06, 0x33, 0x00,
                    0x06, 0x4A,
                    0x84, 0x48,
                    0xA0,
                    0x97,
                    0xEF,
                    0x6D,
                    0x22,
                    0xEC,
                    0x84,
                    0xA3
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_WMDRMV7_Individualization
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4A, 0xC8, 0xD2, 0xAC,
                    0x03, 0xB3,
                    0x65, 0x4F,
                    0xBC,
                    0x2C,
                    0x2C,
                    0x84,
                    0x8D,
                    0x01,
                    0xA9,
                    0x89
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_UpdateRevocationInformation
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0xB0, 0x58, 0xE5,
                    0xC4, 0xB3,
                    0xA0, 0x44,
                    0x92,
                    0x4C,
                    0x50,
                    0xD1,
                    0x78,
                    0x93,
                    0x23,
                    0x85
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_UpdateUntrustedComponent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xD6, 0xF3, 0x79, 0x98,
                    0xE2, 0xCE,
                    0xE6, 0x48,
                    0xB5,
                    0x73,
                    0x97,
                    0x67,
                    0xAB,
                    0x17,
                    0x2F,
                    0x16
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFENABLETYPE_MF_RebootRequired
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x4B, 0x3D, 0x4D, 0x6D,
                    0xCE, 0x0E,
                    0x52, 0x46,
                    0x8B,
                    0x3A,
                    0xF2,
                    0xD2,
                    0x42,
                    0x60,
                    0xD8,
                    0x87
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_POLICY_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0xA2, 0xBA, 0x1A,
                    0x3B, 0x9D,
                    0xC6, 0x47,
                    0xAB,
                    0x48,
                    0xC5,
                    0x95,
                    0x06,
                    0xDE,
                    0x78,
                    0x4D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_CAPTURE_POLICY_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xCD, 0x0A, 0x03, 0x24,
                    0x7A, 0x10,
                    0x65, 0x42,
                    0x97,
                    0x5C,
                    0x41,
                    0x4E,
                    0x33,
                    0xE6,
                    0x5F,
                    0x2A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_STREAM_VOLUME_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xFA, 0xB5, 0xF8,
                    0xEF, 0x32,
                    0xF5, 0x46,
                    0xB1,
                    0x72,
                    0x13,
                    0x21,
                    0x21,
                    0x2F,
                    0xB2,
                    0xC4
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MR_AUDIO_POLICY_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x37, 0xD7, 0x1F, 0x91,
                    0x75, 0x67,
                    0xB0, 0x4A,
                    0xA6,
                    0x14,
                    0x29,
                    0x78,
                    0x62,
                    0xFD,
                    0xAC,
                    0x88
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleGrabberSinkActivate(IMFMediaType* pIMFMediaType, IMFSampleGrabberSinkCallback* pIMFSampleGrabberSinkCallback, IMFActivate** ppIActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateStandardQualityManager(IMFQualityManager** ppQualityManager);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSource(IUnknown* pReserved, IMFSequencerSource** ppSequencerSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSequencerSegmentOffset([NativeTypeName("MFSequencerElementId")] uint dwId, [NativeTypeName("MFTIME")] long hnsOffset, PROPVARIANT* pvarSegmentOffset);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateAggregateSource(IMFCollection* pSourceCollection, IMFMediaSource** ppAggSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateCredentialCache(IMFNetCredentialCache** ppCache);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateProxyLocator([NativeTypeName("LPCWSTR")] ushort* pszProtocol, IPropertyStore* pProxyConfig, IMFNetProxyLocator** ppProxyLocator);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFNET_SAVEJOB_SERVICE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7F, 0x58, 0x5A, 0xB8,
                    0x02, 0x3D,
                    0x52, 0x4E,
                    0x95,
                    0x65,
                    0x55,
                    0xD3,
                    0xEC,
                    0x1E,
                    0x7F,
                    0xF7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateNetSchemePlugin([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPVOID *")] void** ppvHandler);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_BEST_EFFORT
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x31, 0x63, 0xE0, 0xC8,
                    0xF0, 0x75,
                    0xC1, 0x4E,
                    0x8E,
                    0x77,
                    0x17,
                    0x57,
                    0x8F,
                    0x77,
                    0x3B,
                    0x46
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_FAIL_OVER
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC5, 0xAB, 0x36, 0x85,
                    0xF1, 0x38,
                    0x51, 0x41,
                    0x9C,
                    0xCE,
                    0xF5,
                    0x5D,
                    0x94,
                    0x12,
                    0x29,
                    0xAC
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xFC, 0x76, 0x84, 0x00,
                    0x58, 0x4B,
                    0x80, 0x4D,
                    0xA7,
                    0x90,
                    0xE7,
                    0x29,
                    0x76,
                    0x73,
                    0x16,
                    0x1D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFPROTECTIONATTRIBUTE_HDCP_SRM
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x07, 0x21, 0x30, 0x6F,
                    0x77, 0x34,
                    0x68, 0x44,
                    0x8A,
                    0x08,
                    0xEE,
                    0xF9,
                    0xDB,
                    0x10,
                    0xE2,
                    0x0F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreatePMPServer([NativeTypeName("DWORD")] uint dwCreationFlags, IMFPMPServer** ppPMPServer);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateRemoteDesktopPlugin(IMFRemoteDesktopPlugin** ppPlugin);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT CreateNamedPropertyStore(INamedPropertyStore** ppStore);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateSampleCopierMFT(IMFTransform** ppCopierMFT);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeProfile(IMFTranscodeProfile** ppTranscodeProfile);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopology(IMFMediaSource* pSrc, [NativeTypeName("LPCWSTR")] ushort* pwszOutputFilePath, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeTopologyFromByteStream(IMFMediaSource* pSrc, IMFByteStream* pOutputStream, IMFTranscodeProfile* pProfile, IMFTopology** ppTranscodeTopo);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFTranscodeGetAudioOutputAvailableTypes([NativeTypeName("const GUID &")] Guid* guidSubType, [NativeTypeName("DWORD")] uint dwMFTFlags, IMFAttributes* pCodecConfig, IMFCollection** ppAvailableTypes);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateTranscodeSinkActivate(IMFActivate** ppActivate);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateTrackedSample(IMFTrackedSample** ppMFSample);

        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStream(IStream* pStream, IMFByteStream** ppByteStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStream(IMFByteStream* pByteStream, IStream** ppStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMFByteStreamOnStreamEx(IUnknown* punkStream, IMFByteStream** ppByteStream);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateStreamOnMFByteStreamEx(IMFByteStream* pByteStream, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateMediaTypeFromProperties(IUnknown* punkStream, IMFMediaType** ppMediaType);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreatePropertiesFromMediaType(IMFMediaType* pMediaType, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFEnumDeviceSources(IMFAttributes* pAttributes, IMFActivate*** pppSourceActivate, [NativeTypeName("UINT32 *")] uint* pcSourceActivate);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSource(IMFAttributes* pAttributes, IMFMediaSource** ppSource);

        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateDeviceSourceActivate(IMFAttributes* pAttributes, IMFActivate** ppActivate);

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_DeviceTimestamp
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xE7, 0x35, 0x3E, 0x8F,
                    0xCD, 0x2D,
                    0x87, 0x48,
                    0x86,
                    0x22,
                    0x2A,
                    0x58,
                    0xBA,
                    0xA6,
                    0x52,
                    0xB0
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraViewTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x1F, 0x25, 0x4E,
                    0x0F, 0x83,
                    0x70, 0x47,
                    0x85,
                    0x9A,
                    0x4B,
                    0x8D,
                    0x99,
                    0xAA,
                    0x80,
                    0x9B
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraCoordinateSystem
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2F, 0xC8, 0x13, 0x9D,
                    0x99, 0x21,
                    0x67, 0x4E,
                    0x91,
                    0xCD,
                    0xD1,
                    0xA4,
                    0x18,
                    0x1F,
                    0x25,
                    0x34
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const IID")]
        public static ref readonly Guid MFSampleExtension_Spatial_CameraProjectionTransform
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB5, 0xFC, 0xF9, 0x47,
                    0x02, 0x2A,
                    0x26, 0x4F,
                    0xA4,
                    0x77,
                    0x79,
                    0x2F,
                    0xDF,
                    0x95,
                    0x88,
                    0x6A
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFCreateProtectedEnvironmentAccess(IMFProtectedEnvironmentAccess** ppAccess);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFLoadSignedLibrary([NativeTypeName("LPCWSTR")] ushort* pszName, IMFSignedLibrary** ppLib);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetSystemId(IMFSystemId** ppId);

        [SupportedOSPlatform("windows8.0")]
        [DllImport("mf", ExactSpelling = true)]
        public static extern HRESULT MFGetLocalId([NativeTypeName("const BYTE *")] byte* verifier, [NativeTypeName("UINT32")] uint size, [NativeTypeName("LPWSTR *")] ushort** id);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentProtectionDevice([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, IMFContentProtectionDevice** ContentProtectionDevice);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFIsContentProtectionDeviceSupported([NativeTypeName("const GUID &")] Guid* ProtectionSystemId, BOOL* isSupported);

        [SupportedOSPlatform("windows10.0")]
        [DllImport("mfplat", ExactSpelling = true)]
        public static extern HRESULT MFCreateContentDecryptorContext([NativeTypeName("const GUID &")] Guid* guidMediaProtectionSystemId, IMFDXGIDeviceManager* pD3DManager, IMFContentProtectionDevice* pContentProtectionDevice, IMFContentDecryptorContext** ppContentDecryptorContext);

        [SupportedOSPlatform("windows10.0.14393.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorGroup([NativeTypeName("LPCWSTR")] ushort* SensorGroupSymbolicLink, IMFSensorGroup** ppSensorGroup);

        [SupportedOSPlatform("windows10.0.17134.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfile([NativeTypeName("const GUID &")] Guid* ProfileType, [NativeTypeName("UINT32")] uint ProfileIndex, [NativeTypeName("LPCWSTR")] ushort* Constraints, IMFSensorProfile** ppProfile);

        [SupportedOSPlatform("windows10.0.15063.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorProfileCollection(IMFSensorProfileCollection** ppSensorProfile);

        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateSensorActivityMonitor(IMFSensorActivitiesReportCallback* pCallback, IMFSensorActivityMonitor** ppActivityMonitor);

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFStreamExtension_ExtendedCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xDF, 0xB3, 0x74, 0xAA,
                    0x2C, 0x9A,
                    0xD6, 0x48,
                    0x83,
                    0x93,
                    0x5B,
                    0xD1,
                    0xC1,
                    0xA8,
                    0x1E,
                    0x6E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid MFSampleExtension_ExtendedCameraIntrinsics
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0xC4, 0x0B, 0x56,
                    0xE0, 0x4D,
                    0x13, 0x41,
                    0x9C,
                    0xDC,
                    0x83,
                    0x2D,
                    0xB9,
                    0x74,
                    0x0F,
                    0x3D
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [SupportedOSPlatform("windows10.0.19041.0")]
        [DllImport("mfsensorgroup", ExactSpelling = true)]
        public static extern HRESULT MFCreateRelativePanelWatcher([NativeTypeName("PCWSTR")] ushort* videoDeviceId, [NativeTypeName("PCWSTR")] ushort* displayMonitorDeviceId, IMFRelativePanelWatcher** ppRelativePanelWatcher);

        [NativeTypeName("#define MEDIASINK_FIXED_STREAMS 0x00000001")]
        public const int MEDIASINK_FIXED_STREAMS = 0x00000001;

        [NativeTypeName("#define MEDIASINK_CANNOT_MATCH_CLOCK 0x00000002")]
        public const int MEDIASINK_CANNOT_MATCH_CLOCK = 0x00000002;

        [NativeTypeName("#define MEDIASINK_RATELESS 0x00000004")]
        public const int MEDIASINK_RATELESS = 0x00000004;

        [NativeTypeName("#define MEDIASINK_CLOCK_REQUIRED 0x00000008")]
        public const int MEDIASINK_CLOCK_REQUIRED = 0x00000008;

        [NativeTypeName("#define MEDIASINK_CAN_PREROLL 0x00000010")]
        public const int MEDIASINK_CAN_PREROLL = 0x00000010;

        [NativeTypeName("#define MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE 0x00000020")]
        public const int MEDIASINK_REQUIRE_REFERENCE_MEDIATYPE = 0x00000020;

        [NativeTypeName("#define MFCLOCK_FREQUENCY_HNS 10000000")]
        public const int MFCLOCK_FREQUENCY_HNS = 10000000;

        [NativeTypeName("#define MFCLOCK_TOLERANCE_UNKNOWN 50000")]
        public const int MFCLOCK_TOLERANCE_UNKNOWN = 50000;

        [NativeTypeName("#define MFCLOCK_JITTER_ISR 1000")]
        public const int MFCLOCK_JITTER_ISR = 1000;

        [NativeTypeName("#define MFCLOCK_JITTER_DPC 4000")]
        public const int MFCLOCK_JITTER_DPC = 4000;

        [NativeTypeName("#define MFCLOCK_JITTER_PASSIVE 10000")]
        public const int MFCLOCK_JITTER_PASSIVE = 10000;

        [NativeTypeName("#define PRESENTATION_CURRENT_POSITION 0x7fffffffffffffff")]
        public const long PRESENTATION_CURRENT_POSITION = 0x7fffffffffffffff;

        [NativeTypeName("#define MFRR_INFO_VERSION 0")]
        public const int MFRR_INFO_VERSION = 0;

        [NativeTypeName("#define SHA_HASH_LEN 20")]
        public const int SHA_HASH_LEN = 20;

        [NativeTypeName("#define MFSEQUENCER_INVALID_ELEMENT_ID ( 0xffffffff )")]
        public const uint MFSEQUENCER_INVALID_ELEMENT_ID = (0xffffffff);

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_DIGITAL ((DWORD) 0x00000001)")]
        public const uint MFOUTPUTATTRIBUTE_DIGITAL = ((uint)(0x00000001));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION ((DWORD) 0x00000002)")]
        public const uint MFOUTPUTATTRIBUTE_NONSTANDARDIMPLEMENTATION = ((uint)(0x00000002));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_VIDEO ((DWORD) 0x00000004)")]
        public const uint MFOUTPUTATTRIBUTE_VIDEO = ((uint)(0x00000004));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_COMPRESSED ((DWORD) 0x00000008)")]
        public const uint MFOUTPUTATTRIBUTE_COMPRESSED = ((uint)(0x00000008));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_SOFTWARE ((DWORD) 0x00000010)")]
        public const uint MFOUTPUTATTRIBUTE_SOFTWARE = ((uint)(0x00000010));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUS ((DWORD) 0x00000020)")]
        public const uint MFOUTPUTATTRIBUTE_BUS = ((uint)(0x00000020));

        [NativeTypeName("#define MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION ((DWORD) 0x0000FF00)")]
        public const uint MFOUTPUTATTRIBUTE_BUSIMPLEMENTATION = ((uint)(0x0000FF00));

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START 0x04000000")]
        public const int MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START = 0x04000000;

        [NativeTypeName("#define MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID MFCONTENTPROTECTIONDEVICE_FUNCTIONID_START")]
        public const int MFCONTENTPROTECTIONDEVICE_REALTIMECLIENT_DATA_FUNCTIONID = 0x04000000;
    }
}
