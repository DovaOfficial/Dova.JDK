/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/RtMethodGenerator;", "public final")]
public partial class RtMethodGenerator
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RtMethodGenerator()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/RtMethodGenerator;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "HANDLER_INDEX", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_astoreHandler", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "_aloadHandler", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "RtMethodGenerator", "(ILcom/sun/org/apache/bcel/internal/generic/Type;[Lcom/sun/org/apache/bcel/internal/generic/Type;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionList;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "loadHandler", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "storeHandler", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLocalIndex", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getIteratorIndex", "()I"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int HANDLER_INDEX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _astoreHandler_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _aloadHandler_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RtMethodGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/Type;[Lcom/sun/org/apache/bcel/internal/generic/Type;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionList;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "public")]
	public RtMethodGenerator(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type arg1, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type> arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList arg6, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg7) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/RtMethodGenerator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadHandler()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction storeHandler()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getLocalIndex(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getIteratorIndex()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}
}