// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText"]/*' />
[Guid("1F2A94C9-A3DF-430D-9D0F-ACD85DDC29AF")]
[NativeTypeName("struct IMFTimedText : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IMFTimedText : IMFTimedText.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMFTimedText));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, Guid*, void**, int>)(lpVtbl[0]))((IMFTimedText*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, uint>)(lpVtbl[1]))((IMFTimedText*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, uint>)(lpVtbl[2]))((IMFTimedText*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.RegisterNotifications"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RegisterNotifications(IMFTimedTextNotify* notify)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextNotify*, int>)(lpVtbl[3]))((IMFTimedText*)Unsafe.AsPointer(ref this), notify);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.SelectTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SelectTrack([NativeTypeName("DWORD")] uint trackId, BOOL selected)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, uint, BOOL, int>)(lpVtbl[4]))((IMFTimedText*)Unsafe.AsPointer(ref this), trackId, selected);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.AddDataSource"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddDataSource(IMFByteStream* byteStream, [NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFByteStream*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int>)(lpVtbl[5]))((IMFTimedText*)Unsafe.AsPointer(ref this), byteStream, label, language, kind, isDefault, trackId);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.AddDataSourceFromUrl"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT AddDataSourceFromUrl([NativeTypeName("LPCWSTR")] char* url, [NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, char*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int>)(lpVtbl[6]))((IMFTimedText*)Unsafe.AsPointer(ref this), url, label, language, kind, isDefault, trackId);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.AddTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT AddTrack([NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, IMFTimedTextTrack** track)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack**, int>)(lpVtbl[7]))((IMFTimedText*)Unsafe.AsPointer(ref this), label, language, kind, track);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.RemoveTrack"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveTrack(IMFTimedTextTrack* track)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextTrack*, int>)(lpVtbl[8]))((IMFTimedText*)Unsafe.AsPointer(ref this), track);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.GetCueTimeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetCueTimeOffset(double* offset)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, double*, int>)(lpVtbl[9]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.SetCueTimeOffset"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetCueTimeOffset(double offset)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, double, int>)(lpVtbl[10]))((IMFTimedText*)Unsafe.AsPointer(ref this), offset);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.GetTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetTracks(IMFTimedTextTrackList** tracks)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[11]))((IMFTimedText*)Unsafe.AsPointer(ref this), tracks);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.GetActiveTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetActiveTracks(IMFTimedTextTrackList** activeTracks)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[12]))((IMFTimedText*)Unsafe.AsPointer(ref this), activeTracks);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.GetTextTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetTextTracks(IMFTimedTextTrackList** textTracks)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[13]))((IMFTimedText*)Unsafe.AsPointer(ref this), textTracks);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.GetMetadataTracks"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetMetadataTracks(IMFTimedTextTrackList** metadataTracks)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, IMFTimedTextTrackList**, int>)(lpVtbl[14]))((IMFTimedText*)Unsafe.AsPointer(ref this), metadataTracks);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.SetInBandEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetInBandEnabled(BOOL enabled)
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, BOOL, int>)(lpVtbl[15]))((IMFTimedText*)Unsafe.AsPointer(ref this), enabled);
    }

    /// <include file='IMFTimedText.xml' path='doc/member[@name="IMFTimedText.IsInBandEnabled"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public BOOL IsInBandEnabled()
    {
        return ((delegate* unmanaged[MemberFunction]<IMFTimedText*, int>)(lpVtbl[16]))((IMFTimedText*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RegisterNotifications(IMFTimedTextNotify* notify);

        [VtblIndex(4)]
        HRESULT SelectTrack([NativeTypeName("DWORD")] uint trackId, BOOL selected);

        [VtblIndex(5)]
        HRESULT AddDataSource(IMFByteStream* byteStream, [NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId);

        [VtblIndex(6)]
        HRESULT AddDataSourceFromUrl([NativeTypeName("LPCWSTR")] char* url, [NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, BOOL isDefault, [NativeTypeName("DWORD *")] uint* trackId);

        [VtblIndex(7)]
        HRESULT AddTrack([NativeTypeName("LPCWSTR")] char* label, [NativeTypeName("LPCWSTR")] char* language, MF_TIMED_TEXT_TRACK_KIND kind, IMFTimedTextTrack** track);

        [VtblIndex(8)]
        HRESULT RemoveTrack(IMFTimedTextTrack* track);

        [VtblIndex(9)]
        HRESULT GetCueTimeOffset(double* offset);

        [VtblIndex(10)]
        HRESULT SetCueTimeOffset(double offset);

        [VtblIndex(11)]
        HRESULT GetTracks(IMFTimedTextTrackList** tracks);

        [VtblIndex(12)]
        HRESULT GetActiveTracks(IMFTimedTextTrackList** activeTracks);

        [VtblIndex(13)]
        HRESULT GetTextTracks(IMFTimedTextTrackList** textTracks);

        [VtblIndex(14)]
        HRESULT GetMetadataTracks(IMFTimedTextTrackList** metadataTracks);

        [VtblIndex(15)]
        HRESULT SetInBandEnabled(BOOL enabled);

        [VtblIndex(16)]
        BOOL IsInBandEnabled();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint> Release;

        [NativeTypeName("HRESULT (IMFTimedTextNotify *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextNotify*, int> RegisterNotifications;

        [NativeTypeName("HRESULT (DWORD, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, uint, BOOL, int> SelectTrack;

        [NativeTypeName("HRESULT (IMFByteStream *, LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, BOOL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFByteStream*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int> AddDataSource;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, BOOL, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, BOOL, uint*, int> AddDataSourceFromUrl;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, char*, char*, MF_TIMED_TEXT_TRACK_KIND, IMFTimedTextTrack**, int> AddTrack;

        [NativeTypeName("HRESULT (IMFTimedTextTrack *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextTrack*, int> RemoveTrack;

        [NativeTypeName("HRESULT (double *) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double*, int> GetCueTimeOffset;

        [NativeTypeName("HRESULT (double) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, double, int> SetCueTimeOffset;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextTrackList**, int> GetTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextTrackList**, int> GetActiveTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextTrackList**, int> GetTextTracks;

        [NativeTypeName("HRESULT (IMFTimedTextTrackList **) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, IMFTimedTextTrackList**, int> GetMetadataTracks;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, BOOL, int> SetInBandEnabled;

        [NativeTypeName("BOOL () __attribute__((stdcall))")]
        public delegate* unmanaged[MemberFunction]<TSelf*, int> IsInBandEnabled;
    }
}
