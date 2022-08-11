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

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;", "public abstract interface")]
public partial interface XSModelGroupDefinition
	: IJavaObject
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSModelGroupDefinition()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/xs/XSModelGroupDefinition;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotation", "()Lcom/sun/org/apache/xerces/internal/xs/XSAnnotation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelGroup", "()Lcom/sun/org/apache/xerces/internal/xs/XSModelGroup;"));
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSAnnotation;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAnnotation getAnnotation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSAnnotation>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSObjectList;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSObjectList>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xerces/internal/xs/XSModelGroup;", "public abstract")]
	Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroup getModelGroup()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xs.XSModelGroup>(ret);
	}
}
