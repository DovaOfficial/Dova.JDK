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

namespace Dova.JDK.sun.net.www.protocol.file;

[JniSignatureAttribute("Lsun/net/www/protocol/file/Handler;", "public")]
public partial class Handler
	: Dova.JDK.java.net.URLStreamHandler
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Handler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/net/www/protocol/file/Handler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseURL", "(Ljava/net/URL;Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHost", "(Ljava/net/URL;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openConnection", "(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openConnection", "(Ljava/net/URL;)Ljava/net/URLConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFileURLConnection", "(Ljava/net/URL;Ljava/io/File;)Ljava/net/URLConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hostsEqual", "(Ljava/net/URL;Ljava/net/URL;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Handler() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/net/www/protocol/file/Handler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/lang/String;II)V", "protected")]
	public void parseURL(Dova.JDK.java.net.URL arg0, Dova.JDK.java.lang.String arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getHost(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/Proxy;)Ljava/net/URLConnection;", "public synchronized")]
	public Dova.JDK.java.net.URLConnection openConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.Proxy arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)Ljava/net/URLConnection;", "public synchronized")]
	public Dova.JDK.java.net.URLConnection openConnection(Dova.JDK.java.net.URL arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/io/File;)Ljava/net/URLConnection;", "protected")]
	public Dova.JDK.java.net.URLConnection createFileURLConnection(Dova.JDK.java.net.URL arg0, Dova.JDK.java.io.File arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLConnection>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URL;Ljava/net/URL;)Z", "protected")]
	public bool hostsEqual(Dova.JDK.java.net.URL arg0, Dova.JDK.java.net.URL arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}
}
