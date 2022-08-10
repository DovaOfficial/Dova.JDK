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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/SWITCH;", "public final")]
public partial class SWITCH
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CompoundInstruction
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SWITCH()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/SWITCH;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "match", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targets", "[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "instruction", "Lcom/sun/org/apache/bcel/internal/generic/Select;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "matchLength", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SWITCH", "([I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;I)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SWITCH", "([I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "sort", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstruction", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInstructionList", "()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "matchIsOrdered", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fillup", "(ILcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> match_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> targets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Select;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Select instruction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Select>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int matchLength_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SWITCH(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;I)V", "public")]
	public SWITCH(JavaArray<int> arg0, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("([I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public SWITCH(JavaArray<int> arg0, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/SWITCH;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II)V", "private")]
	public void sort(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction getInstruction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList getInstructionList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList>(ret);
	}

	[JniSignatureAttribute("(I)Z", "private")]
	public bool matchIsOrdered(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "private")]
	public void fillup(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}
}
