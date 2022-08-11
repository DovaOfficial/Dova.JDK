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

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Select;", "public abstract")]
public partial class Select
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.VariableLengthInstruction
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackConsumer
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackProducer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Select()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/Select;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "match", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indices", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targets", "[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fixed_length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "match_length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padding", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(S[I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Z)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "(I)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTarget", "(ILcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTargets", "()[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initFromFile", "(Lcom/sun/org/apache/bcel/internal/util/ByteSequence;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dump", "(Ljava/io/DataOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatch", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatchs", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFixed_length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFixed_length", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMatch_length", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatch_length", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatch", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndices", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndices", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMatches", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTargets", "([Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "containsTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPadding", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateTarget", "(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndices", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndices", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePosition", "(II)I"));
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> match_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> indices_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> targets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int fixed_length_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int match_length_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int padding_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Select(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public Select() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(S[I[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "")]
	public Select(short arg0, JavaArray<int> arg1, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> arg2, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/Select;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Z)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle getTarget(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void setTarget(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()[Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> getTargets()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/util/ByteSequence;Z)V", "protected")]
	public void initFromFile(Dova.JDK.com.sun.org.apache.bcel.@internal.util.ByteSequence arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutputStream;)V", "public")]
	public void dump(Dova.JDK.java.io.DataOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(I)I", "final")]
	public int getMatch(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getMatchs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()I", "final")]
	public int getFixed_length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "final")]
	public void setFixed_length(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()I", "final")]
	public int getMatch_length()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "final")]
	public int setMatch_length(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "final")]
	public void setMatch(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("([I)V", "final")]
	public void setIndices(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(II)I", "final")]
	public int setIndices(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([I)V", "final")]
	public void setMatches(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("([Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "final")]
	public void setTargets(JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Z", "public")]
	public bool containsTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "final")]
	public int getPadding()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)V", "public")]
	public void updateTarget(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getIndices()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(I)I", "final")]
	public int getIndices(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)I", "protected")]
	public int updatePosition(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}
}
