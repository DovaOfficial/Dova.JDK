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

namespace Dova.JDK.com.sun.jmx.remote.@internal.rmi;

[JniSignatureAttribute("Lcom/sun/jmx/remote/internal/rmi/ProxyRef;", "public")]
public partial class ProxyRef
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.rmi.server.RemoteRef
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ProxyRef()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/remote/internal/rmi/ProxyRef;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ref", "Ljava/rmi/server/RemoteRef;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/rmi/server/RemoteRef;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/rmi/server/RemoteCall;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invoke", "(Ljava/rmi/Remote;Ljava/lang/reflect/Method;[Ljava/lang/Object;J)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "done", "(Ljava/rmi/server/RemoteCall;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCall", "(Ljava/rmi/server/RemoteObject;[Ljava/rmi/server/Operation;IJ)Ljava/rmi/server/RemoteCall;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteHashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteEquals", "(Ljava/rmi/server/RemoteRef;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remoteToString", "()Ljava/lang/String;"));
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

	[JniSignatureAttribute("Ljava/rmi/server/RemoteRef;", "protected")]
	public Dova.JDK.java.rmi.server.RemoteRef @ref_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RemoteRef>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ProxyRef(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteRef;)V", "public")]
	public ProxyRef(Dova.JDK.java.rmi.server.RemoteRef arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/remote/internal/rmi/ProxyRef;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteCall;)V", "public")]
	public void invoke(Dova.JDK.java.rmi.server.RemoteCall arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/rmi/Remote;Ljava/lang/reflect/Method;[Ljava/lang/Object;J)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object invoke(Dova.JDK.java.rmi.Remote arg0, Dova.JDK.java.lang.reflect.Method arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "public")]
	public void writeExternal(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)V", "public")]
	public void readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteCall;)V", "public")]
	public void done(Dova.JDK.java.rmi.server.RemoteCall arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteObject;[Ljava/rmi/server/Operation;IJ)Ljava/rmi/server/RemoteCall;", "public")]
	public Dova.JDK.java.rmi.server.RemoteCall newCall(Dova.JDK.java.rmi.server.RemoteObject arg0, JavaArray<Dova.JDK.java.rmi.server.Operation> arg1, int arg2, long arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.rmi.server.RemoteCall>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int remoteHashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/rmi/server/RemoteRef;)Z", "public")]
	public bool remoteEquals(Dova.JDK.java.rmi.server.RemoteRef arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String remoteToString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getRefClass(Dova.JDK.java.io.ObjectOutput arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
