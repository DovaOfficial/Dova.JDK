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

namespace Dova.JDK.org.w3c.dom.ls;

[JniSignatureAttribute("Lorg/w3c/dom/ls/LSLoadEvent;", "public abstract interface")]
public partial interface LSLoadEvent
	: IJavaObject
	, Dova.JDK.org.w3c.dom.events.Event
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LSLoadEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lorg/w3c/dom/ls/LSLoadEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInput", "()Lorg/w3c/dom/ls/LSInput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNewDocument", "()Lorg/w3c/dom/Document;"));
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSInput;", "public abstract")]
	Dova.JDK.org.w3c.dom.ls.LSInput getInput()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSInput>(ret);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/Document;", "public abstract")]
	Dova.JDK.org.w3c.dom.Document getNewDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Document>(ret);
	}
}
