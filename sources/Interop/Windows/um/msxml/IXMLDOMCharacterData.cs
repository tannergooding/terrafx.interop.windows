// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("2933BF84-7B36-11D2-B20E-00C04F983E60")]
    public unsafe partial struct IXMLDOMCharacterData
    {
        public void** lpVtbl;

        [return: NativeTypeName("HRESULT")]
        public int QueryInterface([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("void **")] void** ppvObject)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, Guid*, void**, int>)(lpVtbl[0]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, uint>)(lpVtbl[1]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, uint>)(lpVtbl[2]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this));
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfoCount([NativeTypeName("UINT *")] uint* pctinfo)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, uint*, int>)(lpVtbl[3]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), pctinfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetTypeInfo([NativeTypeName("UINT")] uint iTInfo, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("ITypeInfo **")] ITypeInfo** ppTInfo)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [return: NativeTypeName("HRESULT")]
        public int GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, [NativeTypeName("UINT")] uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
        }

        [return: NativeTypeName("HRESULT")]
        public int Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, [NativeTypeName("DISPPARAMS *")] DISPPARAMS* pDispParams, [NativeTypeName("VARIANT *")] VARIANT* pVarResult, [NativeTypeName("EXCEPINFO *")] EXCEPINFO* pExcepInfo, [NativeTypeName("UINT *")] uint* puArgErr)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeName([NativeTypeName("BSTR *")] ushort** name)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[7]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), name);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeValue([NativeTypeName("VARIANT *")] VARIANT* value)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, VARIANT*, int>)(lpVtbl[8]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeValue(VARIANT value)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, VARIANT, int>)(lpVtbl[9]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), value);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeType([NativeTypeName("DOMNodeType *")] DOMNodeType* type)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, DOMNodeType*, int>)(lpVtbl[10]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), type);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parentNode([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** parent)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[11]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), parent);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_childNodes([NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** childList)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNodeList**, int>)(lpVtbl[12]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), childList);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_firstChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** firstChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[13]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), firstChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_lastChild([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** lastChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[14]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), lastChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_previousSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** previousSibling)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[15]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), previousSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nextSibling([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** nextSibling)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[16]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nextSibling);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_attributes([NativeTypeName("IXMLDOMNamedNodeMap **")] IXMLDOMNamedNodeMap** attributeMap)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNamedNodeMap**, int>)(lpVtbl[17]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), attributeMap);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertBefore([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, VARIANT refChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, VARIANT, IXMLDOMNode**, int>)(lpVtbl[18]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, refChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* oldChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outOldChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[19]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, oldChild, outOldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int removeChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* childNode, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** oldChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[20]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), childNode, oldChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendChild([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* newChild, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** outNewChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, IXMLDOMNode**, int>)(lpVtbl[21]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), newChild, outNewChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int hasChildNodes([NativeTypeName("VARIANT_BOOL *")] short* hasChild)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, short*, int>)(lpVtbl[22]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), hasChild);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_ownerDocument([NativeTypeName("IXMLDOMDocument **")] IXMLDOMDocument** XMLDOMDocument)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMDocument**, int>)(lpVtbl[23]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), XMLDOMDocument);
        }

        [return: NativeTypeName("HRESULT")]
        public int cloneNode([NativeTypeName("VARIANT_BOOL")] short deep, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** cloneRoot)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, short, IXMLDOMNode**, int>)(lpVtbl[24]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), deep, cloneRoot);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypeString([NativeTypeName("BSTR *")] ushort** nodeType)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[25]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nodeType);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_text([NativeTypeName("BSTR *")] ushort** text)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[26]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_text([NativeTypeName("BSTR")] ushort* text)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, int>)(lpVtbl[27]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), text);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_specified([NativeTypeName("VARIANT_BOOL *")] short* isSpecified)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, short*, int>)(lpVtbl[28]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), isSpecified);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_definition([NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** definitionNode)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode**, int>)(lpVtbl[29]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), definitionNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_nodeTypedValue([NativeTypeName("VARIANT *")] VARIANT* typedValue)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, VARIANT*, int>)(lpVtbl[30]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_nodeTypedValue(VARIANT typedValue)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, VARIANT, int>)(lpVtbl[31]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), typedValue);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_dataType([NativeTypeName("VARIANT *")] VARIANT* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, VARIANT*, int>)(lpVtbl[32]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_dataType([NativeTypeName("BSTR")] ushort* dataTypeName)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, int>)(lpVtbl[33]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataTypeName);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_xml([NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[34]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNode([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, [NativeTypeName("BSTR *")] ushort** xmlString)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, ushort**, int>)(lpVtbl[35]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), stylesheet, xmlString);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectNodes([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNodeList **")] IXMLDOMNodeList** resultList)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, IXMLDOMNodeList**, int>)(lpVtbl[36]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), queryString, resultList);
        }

        [return: NativeTypeName("HRESULT")]
        public int selectSingleNode([NativeTypeName("BSTR")] ushort* queryString, [NativeTypeName("IXMLDOMNode **")] IXMLDOMNode** resultNode)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, IXMLDOMNode**, int>)(lpVtbl[37]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), queryString, resultNode);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_parsed([NativeTypeName("VARIANT_BOOL *")] short* isParsed)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, short*, int>)(lpVtbl[38]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), isParsed);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_namespaceURI([NativeTypeName("BSTR *")] ushort** namespaceURI)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[39]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), namespaceURI);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_prefix([NativeTypeName("BSTR *")] ushort** prefixString)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[40]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), prefixString);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_baseName([NativeTypeName("BSTR *")] ushort** nameString)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[41]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), nameString);
        }

        [return: NativeTypeName("HRESULT")]
        public int transformNodeToObject([NativeTypeName("IXMLDOMNode *")] IXMLDOMNode* stylesheet, VARIANT outputObject)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, IXMLDOMNode*, VARIANT, int>)(lpVtbl[42]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), stylesheet, outputObject);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_data([NativeTypeName("BSTR *")] ushort** data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort**, int>)(lpVtbl[43]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int put_data([NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, int>)(lpVtbl[44]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int get_length([NativeTypeName("long *")] int* dataLength)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int*, int>)(lpVtbl[45]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), dataLength);
        }

        [return: NativeTypeName("HRESULT")]
        public int substringData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR *")] ushort** data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int, int, ushort**, int>)(lpVtbl[46]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int appendData([NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, ushort*, int>)(lpVtbl[47]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), data);
        }

        [return: NativeTypeName("HRESULT")]
        public int insertData([NativeTypeName("long")] int offset, [NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int, ushort*, int>)(lpVtbl[48]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, data);
        }

        [return: NativeTypeName("HRESULT")]
        public int deleteData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int, int, int>)(lpVtbl[49]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count);
        }

        [return: NativeTypeName("HRESULT")]
        public int replaceData([NativeTypeName("long")] int offset, [NativeTypeName("long")] int count, [NativeTypeName("BSTR")] ushort* data)
        {
            return ((delegate* stdcall<IXMLDOMCharacterData*, int, int, ushort*, int>)(lpVtbl[50]))((IXMLDOMCharacterData*)Unsafe.AsPointer(ref this), offset, count, data);
        }
    }
}
