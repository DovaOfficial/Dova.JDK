/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.jdi.request;

[JniSignatureAttribute("Lcom/sun/jdi/request/MethodEntryRequest;", "public abstract interface")]
public partial interface MethodEntryRequest
	: IJavaObject
	, Dova.JDK.com.sun.jdi.request.EventRequest
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodEntryRequest()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/request/MethodEntryRequest;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addThreadFilter", "(Lcom/sun/jdi/ThreadReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addClassFilter", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addClassFilter", "(Lcom/sun/jdi/ReferenceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addClassExclusionFilter", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addInstanceFilter", "(Lcom/sun/jdi/ObjectReference;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;)V", "public abstract")]
	void addThreadFilter(Dova.JDK.com.sun.jdi.ThreadReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void addClassFilter(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ReferenceType;)V", "public abstract")]
	void addClassFilter(Dova.JDK.com.sun.jdi.ReferenceType arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void addClassExclusionFilter(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ObjectReference;)V", "public abstract")]
	void addInstanceFilter(Dova.JDK.com.sun.jdi.ObjectReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
