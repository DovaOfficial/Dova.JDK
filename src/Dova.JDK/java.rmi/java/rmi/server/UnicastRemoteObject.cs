/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.rmi.server;

[JniSignatureAttribute("Ljava/rmi/server/UnicastRemoteObject;", "public")]
public partial class UnicastRemoteObject
	: Dova.JDK.java.rmi.server.RemoteServer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnicastRemoteObject()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/rmi/server/UnicastRemoteObject;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "port", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "csf", "Ljava/rmi/server/RMIClientSocketFactory;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "ssf", "Ljava/rmi/server/RMIServerSocketFactory;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicastRemoteObject", "(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicastRemoteObject", "(I)V"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnicastRemoteObject", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;ILjava/io/ObjectInputFilter;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/io/ObjectInputFilter;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;Lsun/rmi/server/UnicastServerRef;)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;I)Ljava/rmi/Remote;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exportObject", "(Ljava/rmi/Remote;)Ljava/rmi/server/RemoteStub;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "reexport", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "unexportObject", "(Ljava/rmi/Remote;Z)Z"));
	}

	[JniSignatureAttribute("I", "private")]
	public int port_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljava/rmi/server/RMIClientSocketFactory;", "private")]
	public Dova.JDK.java.rmi.server.RMIClientSocketFactory csf_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIClientSocketFactory>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/rmi/server/RMIServerSocketFactory;", "private")]
	public Dova.JDK.java.rmi.server.RMIServerSocketFactory ssf_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIServerSocketFactory>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnicastRemoteObject(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V", "protected")]
	public UnicastRemoteObject(int arg0, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg1, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg2) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public UnicastRemoteObject(int arg0) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public UnicastRemoteObject() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/rmi/server/UnicastRemoteObject;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)Ljava/rmi/Remote;", "public static")]
	public static Dova.JDK.java.rmi.Remote exportObject(Dova.JDK.java.rmi.Remote arg0, int arg1, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg2, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;ILjava/io/ObjectInputFilter;)Ljava/rmi/Remote;", "public static")]
	public static Dova.JDK.java.rmi.Remote exportObject(Dova.JDK.java.rmi.Remote arg0, int arg1, Dova.JDK.java.io.ObjectInputFilter arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;Ljava/io/ObjectInputFilter;)Ljava/rmi/Remote;", "public static")]
	public static Dova.JDK.java.rmi.Remote exportObject(Dova.JDK.java.rmi.Remote arg0, int arg1, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg2, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg3, Dova.JDK.java.io.ObjectInputFilter arg4)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Lsun/rmi/server/UnicastServerRef;)Ljava/rmi/Remote;", "private static")]
	public static Dova.JDK.java.rmi.Remote exportObject(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.sun.rmi.server.UnicastServerRef arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;I)Ljava/rmi/Remote;", "public static")]
	public static Dova.JDK.java.rmi.Remote exportObject(Dova.JDK.java.rmi.Remote arg0, int arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.Remote>(ret);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;)Ljava/rmi/server/RemoteStub;", "public static")]
	public static Dova.JDK.java.rmi.server.RemoteStub exportObject(Dova.JDK.java.rmi.Remote arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RemoteStub>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void reexport()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Z)Z", "public static")]
	public static bool unexportObject(Dova.JDK.java.rmi.Remote arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}
}