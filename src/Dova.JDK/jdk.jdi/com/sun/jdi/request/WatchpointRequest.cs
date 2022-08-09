/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.jdi.request;

[JniSignatureAttribute("Lcom/sun/jdi/request/WatchpointRequest;", "public abstract interface")]
public partial interface WatchpointRequest
	: IJavaObject
	, Dova.JDK.com.sun.jdi.request.EventRequest
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WatchpointRequest()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/jdi/request/WatchpointRequest;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "field", "()Lcom/sun/jdi/Field;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addThreadFilter", "(Lcom/sun/jdi/ThreadReference;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addClassFilter", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addClassFilter", "(Lcom/sun/jdi/ReferenceType;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addClassExclusionFilter", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addInstanceFilter", "(Lcom/sun/jdi/ObjectReference;)V"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Field;", "public abstract")]
	Dova.JDK.com.sun.jdi.Field field()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Field>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;)V", "public abstract")]
	void addThreadFilter(Dova.JDK.com.sun.jdi.ThreadReference arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void addClassFilter(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ReferenceType;)V", "public abstract")]
	void addClassFilter(Dova.JDK.com.sun.jdi.ReferenceType arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void addClassExclusionFilter(Dova.JDK.java.lang.String arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ObjectReference;)V", "public abstract")]
	void addInstanceFilter(Dova.JDK.com.sun.jdi.ObjectReference arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}