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

namespace Dova.JDK.com.sun.net.httpserver;

[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpHandler;", "public abstract interface")]
public partial interface HttpHandler
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/HttpHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "(Lcom/sun/net/httpserver/HttpExchange;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpExchange;)V", "public abstract")]
	void handle(Dova.JDK.com.sun.net.httpserver.HttpExchange arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
