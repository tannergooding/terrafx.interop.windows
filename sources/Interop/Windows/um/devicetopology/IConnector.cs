// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("9C2C4058-23F5-41DE-877A-DF3AF236A09E")]
    public unsafe partial struct IConnector
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IConnector*, Guid*, void**, int>)(lpVtbl[0]))((IConnector*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IConnector*, uint>)(lpVtbl[1]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IConnector*, uint>)(lpVtbl[2]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetType([NativeTypeName("ConnectorType *")] ConnectorType* pType)
        {
            return ((delegate* stdcall<IConnector*, ConnectorType*, int>)(lpVtbl[3]))((IConnector*)Unsafe.AsPointer(ref this), pType);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDataFlow([NativeTypeName("DataFlow *")] DataFlow* pFlow)
        {
            return ((delegate* stdcall<IConnector*, DataFlow*, int>)(lpVtbl[4]))((IConnector*)Unsafe.AsPointer(ref this), pFlow);
        }

        [return: NativeTypeName("HRESULT")]
        public int ConnectTo([NativeTypeName("IConnector *")] IConnector* pConnectTo)
        {
            return ((delegate* stdcall<IConnector*, IConnector*, int>)(lpVtbl[5]))((IConnector*)Unsafe.AsPointer(ref this), pConnectTo);
        }

        [return: NativeTypeName("HRESULT")]
        public int Disconnect()
        {
            return ((delegate* stdcall<IConnector*, int>)(lpVtbl[6]))((IConnector*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int IsConnected([NativeTypeName("BOOL *")] int* pbConnected)
        {
            return ((delegate* stdcall<IConnector*, int*, int>)(lpVtbl[7]))((IConnector*)Unsafe.AsPointer(ref this), pbConnected);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectedTo([NativeTypeName("IConnector **")] IConnector** ppConTo)
        {
            return ((delegate* stdcall<IConnector*, IConnector**, int>)(lpVtbl[8]))((IConnector*)Unsafe.AsPointer(ref this), ppConTo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetConnectorIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrConnectorId)
        {
            return ((delegate* stdcall<IConnector*, ushort**, int>)(lpVtbl[9]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrConnectorId);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetDeviceIdConnectedTo([NativeTypeName("LPWSTR *")] ushort** ppwstrDeviceId)
        {
            return ((delegate* stdcall<IConnector*, ushort**, int>)(lpVtbl[10]))((IConnector*)Unsafe.AsPointer(ref this), ppwstrDeviceId);
        }
    }
}