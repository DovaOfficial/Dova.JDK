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

[JniSignatureAttribute("Ljdk/internal/org/objectweb/asm/tree/analysis/BasicVerifier;", "public")]
public partial class BasicVerifier
	: Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicInterpreter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicVerifier()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/org/objectweb/asm/tree/analysis/BasicVerifier;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementValue", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ternaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "binaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unaryOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "returnOperation", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_0", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "naryOperation_1", "(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArrayValue", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubTypeOf", "(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BasicVerifier(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicVerifier() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public BasicVerifier(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/org/objectweb/asm/tree/analysis/BasicVerifier;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "protected")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue getElementValue(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value copyOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue copyOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value ternaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue ternaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg2, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue binaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value binaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue unaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value unaryOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)V", "public")]
	public void returnOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;Ljdk/internal/org/objectweb/asm/tree/analysis/Value;)V", "public volatile")]
	public void returnOperation(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg1, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;", "public")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue naryOperation_0(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/AbstractInsnNode;Ljava/util/List;)Ljdk/internal/org/objectweb/asm/tree/analysis/Value;", "public volatile")]
	public Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value naryOperation_1(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.AbstractInsnNode arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.Value>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z", "protected")]
	public bool isArrayValue(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;Ljdk/internal/org/objectweb/asm/tree/analysis/BasicValue;)Z", "protected")]
	public bool isSubTypeOf(Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg0, Dova.JDK.jdk.@internal.org.objectweb.asm.tree.analysis.BasicValue arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}
}
