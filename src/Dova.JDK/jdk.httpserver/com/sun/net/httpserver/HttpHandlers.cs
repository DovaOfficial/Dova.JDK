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

namespace Dova.JDK.com.sun.net.httpserver;

[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpHandlers;", "public final")]
public partial class HttpHandlers
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpHandlers()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/HttpHandlers;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(ILcom/sun/net/httpserver/Headers;Ljava/lang/String;)Lcom/sun/net/httpserver/HttpHandler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "handleOrElse", "(Ljava/util/function/Predicate;Lcom/sun/net/httpserver/HttpHandler;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpHandler;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpHandlers(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public HttpHandlers() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/HttpHandlers;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(ILcom/sun/net/httpserver/Headers;Ljava/lang/String;)Lcom/sun/net/httpserver/HttpHandler;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpHandler of(int arg0, Dova.JDK.com.sun.net.httpserver.Headers arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpHandler>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/function/Predicate;Lcom/sun/net/httpserver/HttpHandler;Lcom/sun/net/httpserver/HttpHandler;)Lcom/sun/net/httpserver/HttpHandler;", "public static")]
	public static Dova.JDK.com.sun.net.httpserver.HttpHandler handleOrElse(Dova.JDK.java.util.function.Predicate arg0, Dova.JDK.com.sun.net.httpserver.HttpHandler arg1, Dova.JDK.com.sun.net.httpserver.HttpHandler arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.net.httpserver.HttpHandler>(ret);
	}
}
