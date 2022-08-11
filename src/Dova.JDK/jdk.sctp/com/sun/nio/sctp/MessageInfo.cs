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

namespace Dova.JDK.com.sun.nio.sctp;

[JniSignatureAttribute("Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
public partial class MessageInfo
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MessageInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/nio/sctp/MessageInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bytes", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "address", "()Ljava/net/SocketAddress;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "complete", "(Z)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unordered", "(Z)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isComplete", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "association", "()Lcom/sun/nio/sctp/Association;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createOutgoing", "(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createOutgoing", "(Lcom/sun/nio/sctp/Association;Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "streamNumber", "(I)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "streamNumber", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnordered", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "payloadProtocolID", "(I)Lcom/sun/nio/sctp/MessageInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "payloadProtocolID", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeToLive", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "timeToLive", "(J)Lcom/sun/nio/sctp/MessageInfo;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MessageInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public MessageInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/nio/sctp/MessageInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public abstract")]
	public int bytes()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/net/SocketAddress;", "public abstract")]
	public Dova.JDK.java.net.SocketAddress address()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.SocketAddress>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo complete(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo unordered(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isComplete()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/nio/sctp/Association;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.Association association()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.Association>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/MessageInfo;", "public static")]
	public static Dova.JDK.com.sun.nio.sctp.MessageInfo createOutgoing(Dova.JDK.java.net.SocketAddress arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/nio/sctp/Association;Ljava/net/SocketAddress;I)Lcom/sun/nio/sctp/MessageInfo;", "public static")]
	public static Dova.JDK.com.sun.nio.sctp.MessageInfo createOutgoing(Dova.JDK.com.sun.nio.sctp.Association arg0, Dova.JDK.java.net.SocketAddress arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo streamNumber(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int streamNumber()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isUnordered()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo payloadProtocolID(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int payloadProtocolID()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public abstract")]
	public long timeToLive()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(J)Lcom/sun/nio/sctp/MessageInfo;", "public abstract")]
	public Dova.JDK.com.sun.nio.sctp.MessageInfo timeToLive(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.nio.sctp.MessageInfo>(ret);
	}
}
