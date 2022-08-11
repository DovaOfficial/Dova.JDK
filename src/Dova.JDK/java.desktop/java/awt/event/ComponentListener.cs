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

namespace Dova.JDK.java.awt.@event;

[JniSignatureAttribute("Ljava/awt/event/ComponentListener;", "public abstract interface")]
public partial interface ComponentListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ComponentListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/event/ComponentListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentMoved", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentShown", "(Ljava/awt/event/ComponentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public abstract")]
	void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public abstract")]
	void componentMoved(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public abstract")]
	void componentShown(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public abstract")]
	void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}
}
