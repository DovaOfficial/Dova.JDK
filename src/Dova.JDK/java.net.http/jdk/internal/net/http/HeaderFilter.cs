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

namespace Dova.JDK.jdk.@internal.net.http;

[JniSignatureAttribute("Ljdk/internal/net/http/HeaderFilter;", "abstract interface")]
public partial interface HeaderFilter
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HeaderFilter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/net/http/HeaderFilter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "response", "(Ljdk/internal/net/http/Response;)Ljdk/internal/net/http/HttpRequestImpl;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "request", "(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;)V"));
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/Response;)Ljdk/internal/net/http/HttpRequestImpl;", "public abstract")]
	Dova.JDK.jdk.@internal.net.http.HttpRequestImpl response(Dova.JDK.jdk.@internal.net.http.Response arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.net.http.HttpRequestImpl>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/net/http/HttpRequestImpl;Ljdk/internal/net/http/MultiExchange;)V", "public abstract")]
	void request(Dova.JDK.jdk.@internal.net.http.HttpRequestImpl arg0, Dova.JDK.jdk.@internal.net.http.MultiExchange arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}
}
