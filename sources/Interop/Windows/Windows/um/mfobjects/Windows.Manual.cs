// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

public static unsafe partial class Windows
{
    public const int MEUnknown = 0;

    public const int MEError = 1;

    public const int MEExtendedType = 2;

    public const int MENonFatalError = 3;

    public const int MEGenericV1Anchor = MENonFatalError;

    public const int MESessionUnknown = 100;

    public const int MESessionTopologySet = 101;

    public const int MESessionTopologiesCleared = 102;

    public const int MESessionStarted = 103;

    public const int MESessionPaused = 104;

    public const int MESessionStopped = 105;

    public const int MESessionClosed = 106;

    public const int MESessionEnded = 107;

    public const int MESessionRateChanged = 108;

    public const int MESessionScrubSampleComplete = 109;

    public const int MESessionCapabilitiesChanged = 110;

    public const int MESessionTopologyStatus = 111;

    public const int MESessionNotifyPresentationTime = 112;

    public const int MENewPresentation = 113;

    public const int MELicenseAcquisitionStart = 114;

    public const int MELicenseAcquisitionCompleted = 115;

    public const int MEIndividualizationStart = 116;

    public const int MEIndividualizationCompleted = 117;

    public const int MEEnablerProgress = 118;

    public const int MEEnablerCompleted = 119;

    public const int MEPolicyError = 120;

    public const int MEPolicyReport = 121;

    public const int MEBufferingStarted = 122;

    public const int MEBufferingStopped = 123;

    public const int MEConnectStart = 124;

    public const int MEConnectEnd = 125;

    public const int MEReconnectStart = 126;

    public const int MEReconnectEnd = 127;

    public const int MERendererEvent = 128;

    public const int MESessionStreamSinkFormatChanged = 129;

    public const int MESessionV1Anchor = MESessionStreamSinkFormatChanged;

    public const int MESourceUnknown = 200;

    public const int MESourceStarted = 201;

    public const int MEStreamStarted = 202;

    public const int MESourceSeeked = 203;

    public const int MEStreamSeeked = 204;

    public const int MENewStream = 205;

    public const int MEUpdatedStream = 206;

    public const int MESourceStopped = 207;

    public const int MEStreamStopped = 208;

    public const int MESourcePaused = 209;

    public const int MEStreamPaused = 210;

    public const int MEEndOfPresentation = 211;

    public const int MEEndOfStream = 212;

    public const int MEMediaSample = 213;

    public const int MEStreamTick = 214;

    public const int MEStreamThinMode = 215;

    public const int MEStreamFormatChanged = 216;

    public const int MESourceRateChanged = 217;

    public const int MEEndOfPresentationSegment = 218;

    public const int MESourceCharacteristicsChanged = 219;

    public const int MESourceRateChangeRequested = 220;

    public const int MESourceMetadataChanged = 221;

    public const int MESequencerSourceTopologyUpdated = 222;

    public const int MESourceV1Anchor = MESequencerSourceTopologyUpdated;

    public const int MESinkUnknown = 300;

    public const int MEStreamSinkStarted = 301;

    public const int MEStreamSinkStopped = 302;

    public const int MEStreamSinkPaused = 303;

    public const int MEStreamSinkRateChanged = 304;

    public const int MEStreamSinkRequestSample = 305;

    public const int MEStreamSinkMarker = 306;

    public const int MEStreamSinkPrerolled = 307;

    public const int MEStreamSinkScrubSampleComplete = 308;

    public const int MEStreamSinkFormatChanged = 309;

    public const int MEStreamSinkDeviceChanged = 310;

    public const int MEQualityNotify = 311;

    public const int MESinkInvalidated = 312;

    public const int MEAudioSessionNameChanged = 313;

    public const int MEAudioSessionVolumeChanged = 314;

    public const int MEAudioSessionDeviceRemoved = 315;

    public const int MEAudioSessionServerShutdown = 316;

    public const int MEAudioSessionGroupingParamChanged = 317;

    public const int MEAudioSessionIconChanged = 318;

    public const int MEAudioSessionFormatChanged = 319;

    public const int MEAudioSessionDisconnected = 320;

    public const int MEAudioSessionExclusiveModeOverride = 321;

    public const int MESinkV1Anchor = MEAudioSessionExclusiveModeOverride;

    public const int MECaptureAudioSessionVolumeChanged = 322;

    public const int MECaptureAudioSessionDeviceRemoved = 323;

    public const int MECaptureAudioSessionFormatChanged = 324;

    public const int MECaptureAudioSessionDisconnected = 325;

    public const int MECaptureAudioSessionExclusiveModeOverride = 326;

    public const int MECaptureAudioSessionServerShutdown = 327;

    public const int MESinkV2Anchor = MECaptureAudioSessionServerShutdown;

    public const int METrustUnknown = 400;

    public const int MEPolicyChanged = 401;

    public const int MEContentProtectionMessage = 402;

    public const int MEPolicySet = 403;

    public const int METrustV1Anchor = MEPolicySet;

    public const int MEWMDRMLicenseBackupCompleted = 500;

    public const int MEWMDRMLicenseBackupProgress = 501;

    public const int MEWMDRMLicenseRestoreCompleted = 502;

    public const int MEWMDRMLicenseRestoreProgress = 503;

    public const int MEWMDRMLicenseAcquisitionCompleted = 506;

    public const int MEWMDRMIndividualizationCompleted = 508;

    public const int MEWMDRMIndividualizationProgress = 513;

    public const int MEWMDRMProximityCompleted = 514;

    public const int MEWMDRMLicenseStoreCleaned = 515;

    public const int MEWMDRMRevocationDownloadCompleted = 516;

    public const int MEWMDRMV1Anchor = MEWMDRMRevocationDownloadCompleted;

    public const int METransformUnknown = 600;

    public const int METransformNeedInput = (METransformUnknown + 1);

    public const int METransformHaveOutput = (METransformNeedInput + 1);

    public const int METransformDrainComplete = (METransformHaveOutput + 1);

    public const int METransformMarker = (METransformDrainComplete + 1);

    public const int METransformInputStreamStateChanged = (METransformMarker + 1);

    public const int MEByteStreamCharacteristicsChanged = 700;

    public const int MEVideoCaptureDeviceRemoved = 800;

    public const int MEVideoCaptureDevicePreempted = 801;

    public const int MEStreamSinkFormatInvalidated = 802;

    public const int MEEncodingParameters = 803;

    public const int MEContentProtectionMetadata = 900;

    public const int MEDeviceThermalStateChanged = 950;

    public const int MEReservedMax = 10000;
}
