/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lcom/sun/jdi/event/WatchpointEvent;", "public abstract interface")]
public partial interface WatchpointEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.LocatableEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static WatchpointEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/WatchpointEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "field", "()Lcom/sun/jdi/Field;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "object", "()Lcom/sun/jdi/ObjectReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "valueCurrent", "()Lcom/sun/jdi/Value;"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Field;", "public abstract")]
	Dova.JDK.com.sun.jdi.Field field()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Field>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ObjectReference;", "public abstract")]
	Dova.JDK.com.sun.jdi.ObjectReference @object()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ObjectReference>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Value;", "public abstract")]
	Dova.JDK.com.sun.jdi.Value valueCurrent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Value>(ret);
	}
}
