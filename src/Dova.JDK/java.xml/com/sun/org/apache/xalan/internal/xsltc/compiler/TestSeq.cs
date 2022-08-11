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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/TestSeq;", "final")]
public partial class TestSeq
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TestSeq()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/TestSeq;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_kernelType", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_patterns", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_mode", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_default", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_instructionList", "Lcom/sun/org/apache/bcel/internal/generic/InstructionList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_start", "Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;ILcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPriority", "()D"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInstructionList", "()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTemplateHandle", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findTemplates", "(Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern", "(I)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LocationPathPattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "()I"));
	}

	[JniSignatureAttribute("I", "private")]
	public int _kernelType_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List _patterns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Mode _mode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Mode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template _default_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/InstructionList;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList _instructionList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle _start_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TestSeq(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;)V", "public")]
	public TestSeq(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Mode arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/List;ILcom/sun/org/apache/xalan/internal/xsltc/compiler/Mode;)V", "public")]
	public TestSeq(Dova.JDK.java.util.List arg0, int arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Mode arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/TestSeq;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle compile(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
	}

	[JniSignatureAttribute("()D", "public")]
	public double getPriority()
	{
		var ret = DovaVM.Runtime.CallDoubleMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void reduce()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/InstructionList;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList getInstructionList()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;)Lcom/sun/org/apache/bcel/internal/generic/InstructionHandle;", "private")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle getTemplateHandle(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)V", "public")]
	public void findTemplates(Dova.JDK.java.util.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LocationPathPattern;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.LocationPathPattern getPattern(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.LocationPathPattern>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}
}
