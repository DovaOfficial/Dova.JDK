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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/BCELFactory;", "")]
public partial class BCELFactory
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.EmptyVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BCELFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/util/BCELFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_PREFIX", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_mg", "Lcom/sun/org/apache/bcel/internal/generic/MethodGen;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_out", "Ljava/io/PrintWriter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_cp", "Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "branch_map", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "branches", "Ljava/util/List;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/bcel/internal/generic/MethodGen;Ljava/io/PrintWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createConstant", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConstantPushInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ConstantPushInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ArrayInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/Instruction;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateBranchTargets", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateExceptionHandlers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/FieldInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAllocationInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/AllocationInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLDC", "(Lcom/sun/org/apache/bcel/internal/generic/LDC;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLDC2_W", "(Lcom/sun/org/apache/bcel/internal/generic/LDC2_W;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitINSTANCEOF", "(Lcom/sun/org/apache/bcel/internal/generic/INSTANCEOF;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCHECKCAST", "(Lcom/sun/org/apache/bcel/internal/generic/CHECKCAST;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBranchInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRET", "(Lcom/sun/org/apache/bcel/internal/generic/RET;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturnInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/ReturnInstruction;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLocalVariableInstruction", "(Lcom/sun/org/apache/bcel/internal/generic/LocalVariableInstruction;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CONSTANT_PREFIX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/MethodGen;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MethodGen _mg_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MethodGen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/io/PrintWriter;", "private final")]
	public Dova.JDK.java.io.PrintWriter _out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.PrintWriter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen _cp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map branch_map_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List branches_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BCELFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/MethodGen;Ljava/io/PrintWriter;)V", "")]
	public BCELFactory(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.MethodGen arg0, Dova.JDK.java.io.PrintWriter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/util/BCELFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void start()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "private")]
	public void createConstant(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ConstantPushInstruction;)V", "public")]
	public void visitConstantPushInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPushInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ArrayInstruction;)V", "public")]
	public void visitArrayInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ArrayInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Instruction;)Z", "private")]
	public bool visitInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateBranchTargets()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void updateExceptionHandlers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FieldInstruction;)V", "public")]
	public void visitFieldInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FieldInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/InvokeInstruction;)V", "public")]
	public void visitInvokeInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InvokeInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/AllocationInstruction;)V", "public")]
	public void visitAllocationInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.AllocationInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LDC;)V", "public")]
	public void visitLDC(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LDC arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LDC2_W;)V", "public")]
	public void visitLDC2_W(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LDC2_W arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/INSTANCEOF;)V", "public")]
	public void visitINSTANCEOF(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.INSTANCEOF arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/CHECKCAST;)V", "public")]
	public void visitCHECKCAST(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.CHECKCAST arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;)V", "public")]
	public void visitBranchInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/RET;)V", "public")]
	public void visitRET(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.RET arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/ReturnInstruction;)V", "public")]
	public void visitReturnInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ReturnInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/LocalVariableInstruction;)V", "public")]
	public void visitLocalVariableInstruction(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.LocalVariableInstruction arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}
}
