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

namespace Dova.JDK.javax.net;

[JniSignatureAttribute("Ljavax/net/ServerSocketFactory;", "public abstract")]
public partial class ServerSocketFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServerSocketFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/net/ServerSocketFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "theFactory", "Ljavax/net/ServerSocketFactory;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefault", "()Ljavax/net/ServerSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createServerSocket", "(II)Ljava/net/ServerSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createServerSocket", "(IILjava/net/InetAddress;)Ljava/net/ServerSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createServerSocket", "(I)Ljava/net/ServerSocket;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createServerSocket", "()Ljava/net/ServerSocket;"));
	}

	[JniSignatureAttribute("Ljavax/net/ServerSocketFactory;", "private static")]
	public static Dova.JDK.javax.net.ServerSocketFactory theFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ServerSocketFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServerSocketFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public ServerSocketFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/net/ServerSocketFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/net/ServerSocketFactory;", "public static")]
	public static Dova.JDK.javax.net.ServerSocketFactory getDefault()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.net.ServerSocketFactory>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/net/ServerSocket;", "public abstract")]
	public Dova.JDK.java.net.ServerSocket createServerSocket(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}

	[JniSignatureAttribute("(IILjava/net/InetAddress;)Ljava/net/ServerSocket;", "public abstract")]
	public Dova.JDK.java.net.ServerSocket createServerSocket(int arg0, int arg1, Dova.JDK.java.net.InetAddress arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/net/ServerSocket;", "public abstract")]
	public Dova.JDK.java.net.ServerSocket createServerSocket(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/ServerSocket;", "public")]
	public Dova.JDK.java.net.ServerSocket createServerSocket()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.ServerSocket>(ret);
	}
}
