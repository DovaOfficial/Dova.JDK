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

[JniSignatureAttribute("Lcom/sun/jdi/event/ModificationWatchpointEvent;", "public abstract interface")]
public partial interface ModificationWatchpointEvent
	: IJavaObject
	, Dova.JDK.com.sun.jdi.@event.WatchpointEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModificationWatchpointEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jdi/event/ModificationWatchpointEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueToBe", "()Lcom/sun/jdi/Value;"));
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/Value;", "public abstract")]
	Dova.JDK.com.sun.jdi.Value valueToBe()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Value>(ret);
	}
}
