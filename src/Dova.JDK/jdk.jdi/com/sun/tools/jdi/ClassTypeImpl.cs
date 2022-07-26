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

[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassTypeImpl;", "public final")]
public partial class ClassTypeImpl
	: Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl
	, Dova.JDK.com.sun.jdi.ClassType
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassTypeImpl()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/ClassTypeImpl;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedSuperclass", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "superclass", "Lcom/sun/jdi/ClassType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "interfaces", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jdi/VirtualMachine;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnum", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInstance", "(Lcom/sun/jdi/ThreadReference;Lcom/sun/jdi/Method;Ljava/util/List;I)Lcom/sun/jdi/ObjectReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "interfaces", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Lcom/sun/jdi/Field;Lcom/sun/jdi/Value;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "waitForReply", "(Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sendNewInstanceCommand", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateConstructorInvocation", "(Lcom/sun/jdi/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allInterfaces", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclasses", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "concreteMethodByName", "(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/jdi/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInvokeMethodSender", "(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/CommandSender;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canInvoke", "(Lcom/sun/jdi/Method;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "superclass", "()Lcom/sun/jdi/ClassType;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool cachedSuperclass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jdi/ClassType;", "private")]
	public Dova.JDK.com.sun.jdi.ClassType superclass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ClassType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List interfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassTypeImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/VirtualMachine;J)V", "protected")]
	public ClassTypeImpl(Dova.JDK.com.sun.jdi.VirtualMachine arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/ClassTypeImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEnum()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/ThreadReference;Lcom/sun/jdi/Method;Ljava/util/List;I)Lcom/sun/jdi/ObjectReference;", "public")]
	public Dova.JDK.com.sun.jdi.ObjectReference newInstance(Dova.JDK.com.sun.jdi.ThreadReference arg0, Dova.JDK.com.sun.jdi.Method arg1, Dova.JDK.java.util.List arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ObjectReference>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List interfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Field;Lcom/sun/jdi/Value;)V", "public")]
	public void setValue(Dova.JDK.com.sun.jdi.Field arg0, Dova.JDK.com.sun.jdi.Value arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/PacketStream;)Lcom/sun/tools/jdi/InvokableTypeImpl$InvocationResult;", "")]
	public Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl.InvocationResult waitForReply(Dova.JDK.com.sun.tools.jdi.PacketStream arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl.InvocationResult>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/PacketStream;", "")]
	public Dova.JDK.com.sun.tools.jdi.PacketStream sendNewInstanceCommand(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, Dova.JDK.com.sun.tools.jdi.MethodImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.PacketStream>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Method;)V", "")]
	public void validateConstructorInvocation(Dova.JDK.com.sun.jdi.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List allInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List subclasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Lcom/sun/jdi/Method;", "public")]
	public Dova.JDK.com.sun.jdi.Method concreteMethodByName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.Method>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdi/ThreadReferenceImpl;Lcom/sun/tools/jdi/MethodImpl;[Lcom/sun/tools/jdi/ValueImpl;I)Lcom/sun/tools/jdi/CommandSender;", "")]
	public Dova.JDK.com.sun.tools.jdi.CommandSender getInvokeMethodSender(Dova.JDK.com.sun.tools.jdi.ThreadReferenceImpl arg0, Dova.JDK.com.sun.tools.jdi.MethodImpl arg1, JavaArray<Dova.JDK.com.sun.tools.jdi.ValueImpl> arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.CommandSender>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jdi/Method;)Z", "")]
	public bool canInvoke(Dova.JDK.com.sun.jdi.Method arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/jdi/ClassType;", "public")]
	public Dova.JDK.com.sun.jdi.ClassType superclass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jdi.ClassType>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdi/ClassTypeImpl$IResult;", "private static")]
	public partial class IResult
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.jdi.InvokableTypeImpl.InvocationResult
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IResult()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdi/ClassTypeImpl$IResult;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rslt", "Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getException", "()Lcom/sun/tools/jdi/ObjectReferenceImpl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResult", "()Lcom/sun/tools/jdi/ValueImpl;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;", "private final")]
		public Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod rslt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IResult(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdi/JDWP$ClassType$InvokeMethod;)V", "public")]
		public IResult(Dova.JDK.com.sun.tools.jdi.JDWP.ClassType.InvokeMethod arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdi/ClassTypeImpl$IResult;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/jdi/ObjectReferenceImpl;", "public")]
		public Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl getException()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ObjectReferenceImpl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/jdi/ValueImpl;", "public")]
		public Dova.JDK.com.sun.tools.jdi.ValueImpl getResult()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdi.ValueImpl>(ret);
		}
	}
}
