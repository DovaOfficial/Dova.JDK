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

namespace Dova.JDK.javax.net.ssl;

[JniSignatureAttribute("Ljavax/net/ssl/SSLSessionBindingListener;", "public abstract interface")]
public partial interface SSLSessionBindingListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SSLSessionBindingListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ssl/SSLSessionBindingListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueBound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueUnbound", "(Ljavax/net/ssl/SSLSessionBindingEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSessionBindingEvent;)V", "public abstract")]
	void valueBound(Dova.JDK.javax.net.ssl.SSLSessionBindingEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLSessionBindingEvent;)V", "public abstract")]
	void valueUnbound(Dova.JDK.javax.net.ssl.SSLSessionBindingEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
