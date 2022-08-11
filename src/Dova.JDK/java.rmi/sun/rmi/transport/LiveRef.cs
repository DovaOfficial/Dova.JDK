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

namespace Dova.JDK.sun.rmi.transport;

[JniSignatureAttribute("Lsun/rmi/transport/LiveRef;", "public")]
public partial class LiveRef
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LiveRef()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/LiveRef;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ep", "Lsun/rmi/transport/Endpoint;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "id", "Ljava/rmi/server/ObjID;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ch", "Lsun/rmi/transport/Channel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLocal", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/rmi/server/ObjID;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/rmi/server/ObjID;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/rmi/server/ObjID;Lsun/rmi/transport/Endpoint;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "write", "(Ljava/io/ObjectOutput;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "read", "(Ljava/io/ObjectInput;Z)Lsun/rmi/transport/LiveRef;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPort", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChannel", "()Lsun/rmi/transport/Channel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndpoint", "()Lsun/rmi/transport/Endpoint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exportObject", "(Lsun/rmi/transport/Target;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerSocketFactory", "()Ljava/rmi/server/RMIServerSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteEquals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClientSocketFactory", "()Ljava/rmi/server/RMIClientSocketFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getObjID", "()Ljava/rmi/server/ObjID;"));
	}

	[JniSignatureAttribute("Lsun/rmi/transport/Endpoint;", "private final")]
	public Dova.JDK.sun.rmi.transport.Endpoint ep_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Endpoint>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/rmi/server/ObjID;", "private final")]
	public Dova.JDK.java.rmi.server.ObjID id_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.ObjID>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/rmi/transport/Channel;", "private transient")]
	public Dova.JDK.sun.rmi.transport.Channel ch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Channel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isLocal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LiveRef(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/rmi/server/ObjID;ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V", "public")]
	public LiveRef(Dova.JDK.java.rmi.server.ObjID arg0, int arg1, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg2, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(Ljava/rmi/server/ObjID;I)V", "public")]
	public LiveRef(Dova.JDK.java.rmi.server.ObjID arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(ILjava/rmi/server/RMIClientSocketFactory;Ljava/rmi/server/RMIServerSocketFactory;)V", "public")]
	public LiveRef(int arg0, Dova.JDK.java.rmi.server.RMIClientSocketFactory arg1, Dova.JDK.java.rmi.server.RMIServerSocketFactory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public LiveRef(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/rmi/server/ObjID;Lsun/rmi/transport/Endpoint;Z)V", "public")]
	public LiveRef(Dova.JDK.java.rmi.server.ObjID arg0, Dova.JDK.sun.rmi.transport.Endpoint arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/rmi/transport/LiveRef;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;Z)V", "public")]
	public void write(Dova.JDK.java.io.ObjectOutput arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;Z)Lsun/rmi/transport/LiveRef;", "public static")]
	public static Dova.JDK.sun.rmi.transport.LiveRef read(Dova.JDK.java.io.ObjectInput arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.LiveRef>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPort()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Channel;", "public")]
	public Dova.JDK.sun.rmi.transport.Channel getChannel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Channel>(ret);
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Endpoint;", "")]
	public Dova.JDK.sun.rmi.transport.Endpoint getEndpoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Endpoint>(ret);
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Target;)V", "public")]
	public void exportObject(Dova.JDK.sun.rmi.transport.Target arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/rmi/server/RMIServerSocketFactory;", "public")]
	public Dova.JDK.java.rmi.server.RMIServerSocketFactory getServerSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIServerSocketFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool remoteEquals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/rmi/server/RMIClientSocketFactory;", "public")]
	public Dova.JDK.java.rmi.server.RMIClientSocketFactory getClientSocketFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RMIClientSocketFactory>(ret);
	}

	[JniSignatureAttribute("()Ljava/rmi/server/ObjID;", "public")]
	public Dova.JDK.java.rmi.server.ObjID getObjID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.ObjID>(ret);
	}
}
