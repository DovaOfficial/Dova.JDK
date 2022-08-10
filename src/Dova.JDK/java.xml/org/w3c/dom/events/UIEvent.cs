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

namespace Dova.JDK.org.w3c.dom.events;

[JniSignatureAttribute("Lorg/w3c/dom/events/UIEvent;", "public abstract interface")]
public partial interface UIEvent
	: IJavaObject
	, Dova.JDK.org.w3c.dom.events.Event
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UIEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/events/UIEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getView", "()Lorg/w3c/dom/views/AbstractView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "initUIEvent", "(Ljava/lang/String;ZZLorg/w3c/dom/views/AbstractView;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDetail", "()I"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/views/AbstractView;", "public abstract")]
	Dova.JDK.org.w3c.dom.views.AbstractView getView()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.views.AbstractView>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ZZLorg/w3c/dom/views/AbstractView;I)V", "public abstract")]
	void initUIEvent(Dova.JDK.java.lang.String arg0, bool arg1, bool arg2, Dova.JDK.org.w3c.dom.views.AbstractView arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	int getDetail()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}
}
