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

[JniSignatureAttribute("Lcom/sun/net/httpserver/HttpsConfigurator;", "public")]
public partial class HttpsConfigurator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HttpsConfigurator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/net/httpserver/HttpsConfigurator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Ljavax/net/ssl/SSLContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/net/ssl/SSLContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSSLContext", "()Ljavax/net/ssl/SSLContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configure", "(Lcom/sun/net/httpserver/HttpsParameters;)V"));
	}

	[JniSignatureAttribute("Ljavax/net/ssl/SSLContext;", "private")]
	public Dova.JDK.javax.net.ssl.SSLContext context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HttpsConfigurator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/net/ssl/SSLContext;)V", "public")]
	public HttpsConfigurator(Dova.JDK.javax.net.ssl.SSLContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/net/httpserver/HttpsConfigurator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/net/ssl/SSLContext;", "public")]
	public Dova.JDK.javax.net.ssl.SSLContext getSSLContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ssl.SSLContext>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/net/httpserver/HttpsParameters;)V", "public")]
	public void configure(Dova.JDK.com.sun.net.httpserver.HttpsParameters arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}
}
