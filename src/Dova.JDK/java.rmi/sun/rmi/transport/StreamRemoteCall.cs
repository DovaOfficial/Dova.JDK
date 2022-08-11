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

[JniSignatureAttribute("Lsun/rmi/transport/StreamRemoteCall;", "public")]
public partial class StreamRemoteCall
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.rmi.server.RemoteCall
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StreamRemoteCall()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/rmi/transport/StreamRemoteCall;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "in", "Lsun/rmi/transport/ConnectionInputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Lsun/rmi/transport/ConnectionOutputStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "conn", "Lsun/rmi/transport/Connection;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Ljava/io/ObjectInputFilter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resultStarted", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serverException", "Ljava/lang/Exception;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/Connection;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/rmi/transport/Connection;Ljava/rmi/server/ObjID;IJ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputStream", "()Ljava/io/ObjectInput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "done", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseInputStream", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "releaseOutputStream", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConnection", "()Lsun/rmi/transport/Connection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResultStream", "(Z)Ljava/io/ObjectOutput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "executeCall", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServerException", "()Ljava/lang/Exception;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "discardPendingRefs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setObjectInputFilter", "(Ljava/io/ObjectInputFilter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputStream", "()Ljava/io/ObjectOutput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOutputStream", "(Z)Ljava/io/ObjectOutput;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exceptionReceivedFromServer", "(Ljava/lang/Exception;)V"));
	}

	[JniSignatureAttribute("Lsun/rmi/transport/ConnectionInputStream;", "private")]
	public Dova.JDK.sun.rmi.transport.ConnectionInputStream @in_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.ConnectionInputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/rmi/transport/ConnectionOutputStream;", "private")]
	public Dova.JDK.sun.rmi.transport.ConnectionOutputStream @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.ConnectionOutputStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/rmi/transport/Connection;", "private")]
	public Dova.JDK.sun.rmi.transport.Connection conn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Connection>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/ObjectInputFilter;", "private")]
	public Dova.JDK.java.io.ObjectInputFilter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputFilter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool resultStarted_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Exception;", "private")]
	public Dova.JDK.java.lang.Exception serverException_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StreamRemoteCall(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Connection;)V", "public")]
	public StreamRemoteCall(Dova.JDK.sun.rmi.transport.Connection arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lsun/rmi/transport/Connection;Ljava/rmi/server/ObjID;IJ)V", "public")]
	public StreamRemoteCall(Dova.JDK.sun.rmi.transport.Connection arg0, Dova.JDK.java.rmi.server.ObjID arg1, int arg2, long arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/rmi/transport/StreamRemoteCall;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/io/ObjectInput;", "public")]
	public Dova.JDK.java.io.ObjectInput getInputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInput>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void done()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void releaseInputStream()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void releaseOutputStream()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Lsun/rmi/transport/Connection;", "public")]
	public Dova.JDK.sun.rmi.transport.Connection getConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.rmi.transport.Connection>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/io/ObjectOutput;", "public")]
	public Dova.JDK.java.io.ObjectOutput getResultStream(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectOutput>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void executeCall()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()Ljava/lang/Exception;", "public")]
	public Dova.JDK.java.lang.Exception getServerException()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Exception>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void discardPendingRefs()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputFilter;)V", "public")]
	public void setObjectInputFilter(Dova.JDK.java.io.ObjectInputFilter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljava/io/ObjectOutput;", "public")]
	public Dova.JDK.java.io.ObjectOutput getOutputStream()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectOutput>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/io/ObjectOutput;", "private")]
	public Dova.JDK.java.io.ObjectOutput getOutputStream(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectOutput>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)V", "protected")]
	public void exceptionReceivedFromServer(Dova.JDK.java.lang.Exception arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}
}
