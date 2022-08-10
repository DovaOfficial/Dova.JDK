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

[JniSignatureAttribute("Lcom/sun/jdi/request/EventRequestManager;", "public abstract interface")]
public partial interface EventRequestManager
	: IJavaObject
	, Dova.JDK.com.sun.jdi.Mirror
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventRequestManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/request/EventRequestManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "breakpointRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deleteEventRequests", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createClassPrepareRequest", "()Lcom/sun/jdi/request/ClassPrepareRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createClassUnloadRequest", "()Lcom/sun/jdi/request/ClassUnloadRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "threadStartRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "threadDeathRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "exceptionRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accessWatchpointRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "modificationWatchpointRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "methodEntryRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "methodExitRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "monitorContendedEnterRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "monitorContendedEnteredRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "monitorWaitRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "monitorWaitedRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "vmDeathRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMonitorWaitedRequest", "()Lcom/sun/jdi/request/MonitorWaitedRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStepRequest", "(Lcom/sun/jdi/ThreadReference;II)Lcom/sun/jdi/request/StepRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createBreakpointRequest", "(Lcom/sun/jdi/Location;)Lcom/sun/jdi/request/BreakpointRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createAccessWatchpointRequest", "(Lcom/sun/jdi/Field;)Lcom/sun/jdi/request/AccessWatchpointRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createModificationWatchpointRequest", "(Lcom/sun/jdi/Field;)Lcom/sun/jdi/request/ModificationWatchpointRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createVMDeathRequest", "()Lcom/sun/jdi/request/VMDeathRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deleteEventRequest", "(Lcom/sun/jdi/request/EventRequest;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deleteAllBreakpoints", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stepRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "classPrepareRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "classUnloadRequests", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createThreadStartRequest", "()Lcom/sun/jdi/request/ThreadStartRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createThreadDeathRequest", "()Lcom/sun/jdi/request/ThreadDeathRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createExceptionRequest", "(Lcom/sun/jdi/ReferenceType;ZZ)Lcom/sun/jdi/request/ExceptionRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMethodEntryRequest", "()Lcom/sun/jdi/request/MethodEntryRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMethodExitRequest", "()Lcom/sun/jdi/request/MethodExitRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMonitorContendedEnterRequest", "()Lcom/sun/jdi/request/MonitorContendedEnterRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMonitorContendedEnteredRequest", "()Lcom/sun/jdi/request/MonitorContendedEnteredRequest;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createMonitorWaitRequest", "()Lcom/sun/jdi/request/MonitorWaitRequest;"));
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List breakpointRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public abstract")]
	void deleteEventRequests(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/ClassPrepareRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ClassPrepareRequest createClassPrepareRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ClassPrepareRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/ClassUnloadRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ClassUnloadRequest createClassUnloadRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ClassUnloadRequest>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List threadStartRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List threadDeathRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List exceptionRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List accessWatchpointRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List modificationWatchpointRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List methodEntryRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List methodExitRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List monitorContendedEnterRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List monitorContendedEnteredRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List monitorWaitRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List monitorWaitedRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List vmDeathRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MonitorWaitedRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MonitorWaitedRequest createMonitorWaitedRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MonitorWaitedRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;II)Lcom/sun/jdi/request/StepRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.StepRequest createStepRequest(Dova.JDK.com.sun.jdi.ThreadReference arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.StepRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Location;)Lcom/sun/jdi/request/BreakpointRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.BreakpointRequest createBreakpointRequest(Dova.JDK.com.sun.jdi.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.BreakpointRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Field;)Lcom/sun/jdi/request/AccessWatchpointRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.AccessWatchpointRequest createAccessWatchpointRequest(Dova.JDK.com.sun.jdi.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.AccessWatchpointRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Field;)Lcom/sun/jdi/request/ModificationWatchpointRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ModificationWatchpointRequest createModificationWatchpointRequest(Dova.JDK.com.sun.jdi.Field arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ModificationWatchpointRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/VMDeathRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.VMDeathRequest createVMDeathRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.VMDeathRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/request/EventRequest;)V", "public abstract")]
	void deleteEventRequest(Dova.JDK.com.sun.jdi.request.EventRequest arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void deleteAllBreakpoints()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List stepRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List classPrepareRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List classUnloadRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/ThreadStartRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ThreadStartRequest createThreadStartRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ThreadStartRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/ThreadDeathRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ThreadDeathRequest createThreadDeathRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ThreadDeathRequest>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ReferenceType;ZZ)Lcom/sun/jdi/request/ExceptionRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.ExceptionRequest createExceptionRequest(Dova.JDK.com.sun.jdi.ReferenceType arg0, bool arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.ExceptionRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MethodEntryRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MethodEntryRequest createMethodEntryRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MethodEntryRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MethodExitRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MethodExitRequest createMethodExitRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MethodExitRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MonitorContendedEnterRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MonitorContendedEnterRequest createMonitorContendedEnterRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MonitorContendedEnterRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MonitorContendedEnteredRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MonitorContendedEnteredRequest createMonitorContendedEnteredRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MonitorContendedEnteredRequest>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/request/MonitorWaitRequest;", "public abstract")]
	Dova.JDK.com.sun.jdi.request.MonitorWaitRequest createMonitorWaitRequest()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.request.MonitorWaitRequest>(ret);
	}
}
