/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.org.objectweb.asm;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Handler;", "final")]
public partial class Handler
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Handler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/Handler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "startPc", "Ljdk/internal/org/objectweb/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "endPc", "Ljdk/internal/org/objectweb/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handlerPc", "Ljdk/internal/org/objectweb/asm/Label;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "catchType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "catchTypeDescriptor", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextHandler", "Ljdk/internal/org/objectweb/asm/Handler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Handler", "(Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;ILjava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Handler", "(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "removeRange", "(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;)Ljdk/internal/org/objectweb/asm/Handler;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getExceptionTableLength", "(Ljdk/internal/org/objectweb/asm/Handler;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getExceptionTableSize", "(Ljdk/internal/org/objectweb/asm/Handler;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "putExceptionTable", "(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/ByteVector;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Label;", "final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Label startPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Label>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Label;", "final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Label endPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Label>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Label;", "final")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Label handlerPc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Label>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "final")]
	public int catchType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String catchTypeDescriptor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/Handler;", "")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.Handler nextHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Handler>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;ILjava/lang/String;)V", "")]
	public Handler(Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg2, int arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;)V", "")]
	public Handler(Dova.JDK.jdk.@internal.org.objectweb.asm.Handler arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/Handler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/Label;Ljdk/internal/org/objectweb/asm/Label;)Ljdk/internal/org/objectweb/asm/Handler;", "static")]
	public static Dova.JDK.jdk.@internal.org.objectweb.asm.Handler removeRange(Dova.JDK.jdk.@internal.org.objectweb.asm.Handler arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Label arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.Handler>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handler;)I", "static")]
	public static int getExceptionTableLength(Dova.JDK.jdk.@internal.org.objectweb.asm.Handler arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handler;)I", "static")]
	public static int getExceptionTableSize(Dova.JDK.jdk.@internal.org.objectweb.asm.Handler arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Handler;Ljdk/internal/org/objectweb/asm/ByteVector;)V", "static")]
	public static void putExceptionTable(Dova.JDK.jdk.@internal.org.objectweb.asm.Handler arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.ByteVector arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}
}
