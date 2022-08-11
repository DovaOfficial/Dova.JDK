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

namespace Dova.JDK.com.sun.jdi.@event;

[JniSignatureAttribute("Lcom/sun/jdi/event/MonitorWaitedEvent;", "public abstract interface")]
public partial interface MonitorWaitedEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.LocatableEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MonitorWaitedEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/MonitorWaitedEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thread", "()Lcom/sun/jdi/ThreadReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "monitor", "()Lcom/sun/jdi/ObjectReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timedout", "()Z"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ThreadReference;", "public abstract")]
	Dova.JDK.com.sun.jdi.ThreadReference thread()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ThreadReference>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ObjectReference;", "public abstract")]
	Dova.JDK.com.sun.jdi.ObjectReference monitor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ObjectReference>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool timedout()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}
}
