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

namespace Dova.JDK.org.w3c.dom.events;

[JniSignatureAttribute("Lorg/w3c/dom/events/EventTarget;", "public abstract interface")]
public partial interface EventTarget
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EventTarget()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lorg/w3c/dom/events/EventTarget;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addEventListener", "(Ljava/lang/String;Lorg/w3c/dom/events/EventListener;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeEventListener", "(Ljava/lang/String;Lorg/w3c/dom/events/EventListener;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispatchEvent", "(Lorg/w3c/dom/events/Event;)Z"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/events/EventListener;Z)V", "public abstract")]
	void addEventListener(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.events.EventListener arg1, bool arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/events/EventListener;Z)V", "public abstract")]
	void removeEventListener(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.events.EventListener arg1, bool arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/events/Event;)Z", "public abstract")]
	bool dispatchEvent(Dova.JDK.org.w3c.dom.events.Event arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}
}
