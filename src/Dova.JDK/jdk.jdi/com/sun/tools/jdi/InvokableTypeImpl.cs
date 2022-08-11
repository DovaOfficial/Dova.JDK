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

namespace Dova.JDK.com.sun.tools.jdi;

[JniSignatureAttribute("Lcom/sun/tools/jdi/InvokableTypeImpl;", "abstract")]
public partial class InvokableTypeImpl
	: Dova.JDK.com.sun.tools.jdi.ReferenceTypeImpl
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InvokableTypeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/InvokableTypeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jdi/VirtualMachine;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaces", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeMethod", "(Lcom/sun/jdi/ThreadReference;Lcom/sun/jdi/Method;Ljava/util/List;I)Lcom/sun/jdi/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateMethodInvocation", "(Lcom/sun/jdi/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendInvokeCommand", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAllInterfaces", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInvokeMethodSender", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/CommandSender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canInvoke", "(Lcom/sun/jdi/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addInterfaces", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignableTo", "(Lcom/sun/jdi/ReferenceType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVisibleMethods", "(Ljava/util/Map;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allMethods", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inheritedTypes", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "superclass", "()Lcom/sun/jdi/ClassType;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public InvokableTypeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;J)V", "")]
	public InvokableTypeImpl(Dova.JDK.com.sun.jdi.VirtualMachine arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/InvokableTypeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/List;", "abstract")]
	public Dova.JDK.java.util.List interfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;Lcom/sun/jdi/Method;Ljava/util/List;I)Lcom/sun/jdi/Value;", "public final")]
	public Dova.JDK.com.sun.jdi.Value invokeMethod(Dova.JDK.com.sun.jdi.ThreadReference arg0, Dova.JDK.com.sun.jdi.Method arg1, Dova.JDK.java.util.List arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Value>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Method;)V", "private")]
	public void validateMethodInvocation(Dova.JDK.com.sun.jdi.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "private")]
	public Dova.JDK.com.sun.tools.jdi.PacketStream sendInvokeCommand(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, Dova.JDK.com.sun.tools.jdi.MethodImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;", "abstract")]
	public Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl.InvocationResult waitForReply(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl.InvocationResult>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List getAllInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/CommandSender;", "abstract")]
	public Dova.JDK.com.sun.tools.jdi.CommandSender getInvokeMethodSender(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, Dova.JDK.com.sun.tools.jdi.MethodImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.CommandSender>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Method;)Z", "abstract")]
	public bool canInvoke(Dova.JDK.com.sun.jdi.Method arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "final")]
	public void addInterfaces(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ReferenceType;)Z", "")]
	public bool isAssignableTo(Dova.JDK.com.sun.jdi.ReferenceType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/util/Set;)V", "final")]
	public void addVisibleMethods(Dova.JDK.java.util.Map arg0, Dova.JDK.java.util.Set arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public final")]
	public Dova.JDK.java.util.List allMethods()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "final")]
	public Dova.JDK.java.util.List inheritedTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ClassType;", "abstract")]
	public Dova.JDK.com.sun.jdi.ClassType superclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ClassType>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;", "abstract static interface")]
	public partial interface InvocationResult
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InvocationResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getException", "()Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResult", "()Lcom/sun/tools/jdi/ValueImpl;"));
		}

		[JniSignatureAttribute("()Lcom/sun/tools/jdi/ObjectReferenceImpl;", "public abstract")]
		Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl getException()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/jdi/ValueImpl;", "public abstract")]
		Dova.JDK.com.sun.tools.jdi.ValueImpl getResult()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
		}
	}
}
