/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.xs;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSValue;", "public abstract interface")]
public partial interface XSValue
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSValue()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xs/XSValue;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDefinition", "()Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberTypeDefinition", "()Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNormalizedValue", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMemberTypeDefinitions", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActualValueType", "()S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getListValueTypes", "()Lcom/sun/org/apache/xerces/internal/xs/ShortList;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSSimpleTypeDefinition getTypeDefinition()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSSimpleTypeDefinition>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSSimpleTypeDefinition;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSSimpleTypeDefinition getMemberTypeDefinition()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSSimpleTypeDefinition>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getNormalizedValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getActualValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getMemberTypeDefinitions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("()S", "public abstract")]
	short getActualValueType()
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/ShortList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList getListValueTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.ShortList>(ret);
	}
}
