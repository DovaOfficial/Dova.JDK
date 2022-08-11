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

namespace Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis;

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;", "public abstract")]
public partial class Interpreter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Interpreter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "api", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newExceptionValue", "(Ljdk/internal/org/objectweb/asm/tree/TryCatchBlockNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newParameterValue", "(ZILjdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEmptyValue", "(I)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReturnTypeValue", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
	}

	[JniSignatureAttribute("I", "protected final")]
	public int api_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Interpreter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public Interpreter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/analysis/Interpreter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object merge(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object newValue(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/TryCatchBlockNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Frame;Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public")]
	public Dova.JDK.java.lang.Object newExceptionValue(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.TryCatchBlockNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Frame arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(ZILjdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public")]
	public Dova.JDK.java.lang.Object newParameterValue(bool arg0, int arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public")]
	public Dova.JDK.java.lang.Object newEmptyValue(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public")]
	public Dova.JDK.java.lang.Object newReturnTypeValue(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V", "public abstract")]
	public void returnOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object naryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object ternaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object binaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object unaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object copyOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public abstract")]
	public Dova.JDK.java.lang.Object newOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
