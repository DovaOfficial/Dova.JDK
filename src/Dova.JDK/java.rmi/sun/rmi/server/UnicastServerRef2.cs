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

namespace Dova.JDK.sun.rmi.server;

[JniSignatureAttribute("Lsun/rmi/server/UnicastServerRef2;", "public")]
public partial class UnicastServerRef2
	: Dova.JDK.sun.rmi.server.UnicastServerRef
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnicastServerRef2()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/server/UnicastServerRef2;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/io/ObjectInputFilter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/LiveRef;Ljava/io/ObjectInputFilter;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/LiveRef;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClientRef", "()Ljava/rmi/server/RemoteRef;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRefClass", "(Ljava/io/ObjectOutput;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnicastServerRef2(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/io/ObjectInputFilter;)V", "public")]
	public UnicastServerRef2(int arg0, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg1, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg2, Dova.JDK.java.io.ObjectInputFilter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V", "public")]
	public UnicastServerRef2(int arg0, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg1, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/LiveRef;Ljava/io/ObjectInputFilter;)V", "public")]
	public UnicastServerRef2(Dova.JDK.sun.rmi.transport.LiveRef arg0, Dova.JDK.java.io.ObjectInputFilter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/LiveRef;)V", "public")]
	public UnicastServerRef2(Dova.JDK.sun.rmi.transport.LiveRef arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public UnicastServerRef2() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/rmi/server/UnicastServerRef2;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/rmi/server/RemoteRef;", "protected")]
	public Dova.JDK.java.rmi.server.RemoteRef getClientRef()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RemoteRef>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getRefClass(Dova.JDK.java.io.ObjectOutput arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
