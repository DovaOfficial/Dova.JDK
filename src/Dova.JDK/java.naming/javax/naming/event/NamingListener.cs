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

namespace Dova.JDK.javax.naming.@event;

[JniSignatureAttribute("Ljavax/naming/event/NamingListener;", "public abstract interface")]
public partial interface NamingListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NamingListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/naming/event/NamingListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "namingExceptionThrown", "(Ljavax/naming/event/NamingExceptionEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/naming/event/NamingExceptionEvent;)V", "public abstract")]
	void namingExceptionThrown(Dova.JDK.javax.naming.@event.NamingExceptionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
