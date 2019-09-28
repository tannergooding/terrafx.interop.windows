// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um\d2d1effectauthor.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    /// <summary>An effect uses this interface to alter the image rectangle of its input.</summary>
    [Guid("90F732E2-5092-4606-A819-8651970BACCD")]
    public unsafe struct ID2D1BoundsAdjustmentTransform
    {
        public readonly Vtbl* lpVtbl;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("HRESULT")]
        public delegate int _QueryInterface(ID2D1BoundsAdjustmentTransform* This, [NativeTypeName("REFIID")] Guid* riid, void** ppvObject);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _AddRef(ID2D1BoundsAdjustmentTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("ULONG")]
        public delegate uint _Release(ID2D1BoundsAdjustmentTransform* This);

        /// <summary>Return the number of input this node has.</summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        [return: NativeTypeName("UINT32")]
        public delegate uint _GetInputCount(ID2D1BoundsAdjustmentTransform* This);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _SetOutputBounds(ID2D1BoundsAdjustmentTransform* This, [NativeTypeName("D2D1_RECT_L")] RECT* outputBounds);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate void _GetOutputBounds(ID2D1BoundsAdjustmentTransform* This, [NativeTypeName("D2D1_RECT_L")] RECT* outputBounds);

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("REFIID")] Guid* riid, void** ppvObject)
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_QueryInterface>(lpVtbl->QueryInterface)(This, riid, ppvObject);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_AddRef>(lpVtbl->AddRef)(This);
            }
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_Release>(lpVtbl->Release)(This);
            }
        }

        [return: NativeTypeName("UINT32")]
        public uint GetInputCount()
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                return Marshal.GetDelegateForFunctionPointer<_GetInputCount>(lpVtbl->GetInputCount)(This);
            }
        }

        public void SetOutputBounds([NativeTypeName("D2D1_RECT_L")] RECT* outputBounds)
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_SetOutputBounds>(lpVtbl->SetOutputBounds)(This, outputBounds);
            }
        }

        public void GetOutputBounds([NativeTypeName("D2D1_RECT_L")] RECT* outputBounds)
        {
            fixed (ID2D1BoundsAdjustmentTransform* This = &this)
            {
                Marshal.GetDelegateForFunctionPointer<_GetOutputBounds>(lpVtbl->GetOutputBounds)(This, outputBounds);
            }
        }

        public struct Vtbl
        {
            public IntPtr QueryInterface;

            public IntPtr AddRef;

            public IntPtr Release;

            public IntPtr GetInputCount;

            public IntPtr SetOutputBounds;

            public IntPtr GetOutputBounds;
        }
    }
}