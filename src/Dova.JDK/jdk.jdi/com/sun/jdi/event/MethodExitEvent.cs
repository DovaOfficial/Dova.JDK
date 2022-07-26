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

[JniSignatureAttribute("Lcom/sun/jdi/event/MethodExitEvent;", "public abstract interface")]
public partial interface MethodExitEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.LocatableEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MethodExitEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/MethodExitEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "method", "()Lcom/sun/jdi/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnValue", "()Lcom/sun/jdi/Value;"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Method;", "public abstract")]
	Dova.JDK.com.sun.jdi.Method method()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Method>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Value;", "public abstract")]
	Dova.JDK.com.sun.jdi.Value returnValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Value>(ret);
	}
}
