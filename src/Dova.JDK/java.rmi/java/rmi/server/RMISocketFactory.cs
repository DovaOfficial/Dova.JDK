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

namespace Dova.JDK.java.rmi.server;

[JniSignatureAttribute("Ljava/rmi/server/RMISocketFactory;", "public abstract")]
public partial class RMISocketFactory
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.rmi.server.RMIClientSocketFactory
	, Dova.JDK.java.rmi.server.RMIServerSocketFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RMISocketFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/rmi/server/RMISocketFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "factory", "Ljava/rmi/server/RMISocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultSocketFactory", "Ljava/rmi/server/RMISocketFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "handler", "Ljava/rmi/server/RMIFailureHandler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSocketFactory", "()Ljava/rmi/server/RMISocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createServerSocket", "(I)Ljava/net/ServerSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setSocketFactory", "(Ljava/rmi/server/RMISocketFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSocket", "(Ljava/lang/String;I)Ljava/net/Socket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultSocketFactory", "()Ljava/rmi/server/RMISocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setFailureHandler", "(Ljava/rmi/server/RMIFailureHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFailureHandler", "()Ljava/rmi/server/RMIFailureHandler;"));
	}

	[JniSignatureAttribute("Ljava/rmi/server/RMISocketFactory;", "private static")]
	public static Dova.JDK.java.rmi.server.RMISocketFactory factory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMISocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/server/RMISocketFactory;", "private static")]
	public static Dova.JDK.java.rmi.server.RMISocketFactory defaultSocketFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMISocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/server/RMIFailureHandler;", "private static")]
	public static Dova.JDK.java.rmi.server.RMIFailureHandler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIFailureHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RMISocketFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public RMISocketFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/rmi/server/RMISocketFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/rmi/server/RMISocketFactory;", "public static synchronized")]
	public static Dova.JDK.java.rmi.server.RMISocketFactory getSocketFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMISocketFactory>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/ServerSocket;", "public abstract")]
	public Dova.JDK.java.net.ServerSocket createServerSocket(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RMISocketFactory;)V", "public static synchronized")]
	public static void setSocketFactory(Dova.JDK.java.rmi.server.RMISocketFactory arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Ljava/net/Socket;", "public abstract")]
	public Dova.JDK.java.net.Socket createSocket(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.Socket>(ret);
	}

	[JniSignatureAttribute("()Ljava/rmi/server/RMISocketFactory;", "public static synchronized")]
	public static Dova.JDK.java.rmi.server.RMISocketFactory getDefaultSocketFactory()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMISocketFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RMIFailureHandler;)V", "public static synchronized")]
	public static void setFailureHandler(Dova.JDK.java.rmi.server.RMIFailureHandler arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljava/rmi/server/RMIFailureHandler;", "public static synchronized")]
	public static Dova.JDK.java.rmi.server.RMIFailureHandler getFailureHandler()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIFailureHandler>(ret);
	}
}
