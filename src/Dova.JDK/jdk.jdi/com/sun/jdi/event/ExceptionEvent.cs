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

[JniSignatureAttribute("Lcom/sun/jdi/event/ExceptionEvent;", "public abstract interface")]
public partial interface ExceptionEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.LocatableEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExceptionEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/ExceptionEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exception", "()Lcom/sun/jdi/ObjectReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "catchLocation", "()Lcom/sun/jdi/Location;"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ObjectReference;", "public abstract")]
	Dova.JDK.com.sun.jdi.ObjectReference exception()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ObjectReference>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Location;", "public abstract")]
	Dova.JDK.com.sun.jdi.Location catchLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Location>(ret);
	}
}
