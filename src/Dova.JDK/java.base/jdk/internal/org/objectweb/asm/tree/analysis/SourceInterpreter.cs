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

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/SourceInterpreter;", "public")]
public partial class SourceInterpreter
	: Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Interpreter
	, Dova.JDK.jdk.@internal.org.objectweb.asm.Opcodes
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SourceInterpreter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/analysis/SourceInterpreter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "merge", "(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_0", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValue_1", "(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "containsAll", "(Ljava/util/Set;Ljava/util/Set;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_0", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_1", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOperation_0", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOperation_1", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SourceInterpreter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SourceInterpreter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public SourceInterpreter(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/analysis/SourceInterpreter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue merge(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value merge(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value newValue_0(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/Type;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue newValue_1(Dova.JDK.jdk.@internal.org.objectweb.asm.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Ljava/util/Set;)Z", "private static")]
	public static bool containsAll(Dova.JDK.java.util.Set arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)V", "public")]
	public void returnOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V", "public volatile")]
	public void returnOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value naryOperation_0(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue naryOperation_1(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value ternaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue ternaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue binaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value binaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value unaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue unaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue copyOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value copyOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value newOperation_0(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;)Ljdk/internal/org/objectweb/asm/tree/analysis/SourceValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue newOperation_1(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.SourceValue>(ret);
	}
}
