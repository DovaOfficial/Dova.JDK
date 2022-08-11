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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "public abstract")]
public partial class BranchInstruction
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionTargeter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BranchInstruction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "position", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(SLcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetOffset", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargetOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndex", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFromFile", "(Lcom/sun/org/apache/bcel/internal/util/ByteSequence;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOpcode", "(S)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPosition", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "notifyTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionTargeter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePosition", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "()I"));
	}

	[JniSignatureAttribute("I", "private")]
	public int index_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle target_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int position_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BranchInstruction(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public BranchInstruction() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(SLcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "protected")]
	public BranchInstruction(short arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)I", "protected")]
	public int getTargetOffset(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getTargetOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void setTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()I", "public final")]
	public int getIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/util/ByteSequence;Z)V", "protected")]
	public void initFromFile(Dova.JDK.com.sun.org.apache.bcel.@internal.util.ByteSequence arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(S)V", "")]
	public void setOpcode(short arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setPosition(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionTargeter;)V", "static")]
	public static void notifyTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionTargeter arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z", "public")]
	public bool containsTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void updateTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(II)I", "protected")]
	public int updatePosition(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}
}
