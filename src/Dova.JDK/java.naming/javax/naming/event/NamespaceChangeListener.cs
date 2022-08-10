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

namespace Dova.JDK.javax.naming.@event;

[JniSignatureAttribute("Ljavax/naming/event/NamespaceChangeListener;", "public abstract interface")]
public partial interface NamespaceChangeListener
	: IJavaObject
	, Dova.JDK.javax.naming.@event.NamingListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NamespaceChangeListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/event/NamespaceChangeListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "objectAdded", "(Ljavax/naming/event/NamingEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "objectRemoved", "(Ljavax/naming/event/NamingEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "objectRenamed", "(Ljavax/naming/event/NamingEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingEvent;)V", "public abstract")]
	void objectAdded(Dova.JDK.javax.naming.@event.NamingEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingEvent;)V", "public abstract")]
	void objectRemoved(Dova.JDK.javax.naming.@event.NamingEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingEvent;)V", "public abstract")]
	void objectRenamed(Dova.JDK.javax.naming.@event.NamingEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}
}
