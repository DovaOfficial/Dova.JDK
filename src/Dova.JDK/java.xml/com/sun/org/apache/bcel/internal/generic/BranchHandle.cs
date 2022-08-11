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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/BranchHandle;", "public final")]
public partial class BranchHandle
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BranchHandle()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/BranchHandle;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bi", "Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPosition", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/Instruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBranchHandle", "(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)Lcom/sun/org/apache/bcel/internal/generic/BranchHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePosition", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "()I"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction bi_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BranchHandle(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V", "private")]
	public BranchHandle(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/BranchHandle;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void setTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void setPosition(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Instruction;)V", "public")]
	public void setInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void updateTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)Lcom/sun/org/apache/bcel/internal/generic/BranchHandle;", "static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchHandle getBranchHandle(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchHandle>(ret);
	}

	[JniSignatureAttribute("(II)I", "protected")]
	public int updatePosition(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}
}
