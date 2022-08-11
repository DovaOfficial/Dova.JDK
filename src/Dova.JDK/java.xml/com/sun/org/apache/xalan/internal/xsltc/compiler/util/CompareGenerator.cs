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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/CompareGenerator;", "public final")]
public partial class CompareGenerator
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompareGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/CompareGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOM_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CURRENT_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEVEL_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSLET_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAST_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ITERATOR_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_iloadCurrent", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_istoreCurrent", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_aloadDom", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_iloadLast", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_aloadIterator", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_astoreIterator", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILcom/sun/org/apache/bcel/internal/generic/Type;[Lcom/sun/org/apache/bcel/internal/generic/Type;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionList;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadDOM", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadIterator", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadCurrentNode", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocalIndex", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeIterator", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "storeCurrentNode", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadLastNode", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHandlerIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIteratorIndex", "()I"));
	}

	[JniSignatureAttribute("I", "private static")]
	public static int DOM_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int CURRENT_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int LEVEL_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int TRANSLET_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int LAST_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int ITERATOR_INDEX_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _iloadCurrent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _istoreCurrent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _aloadDom_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _iloadLast_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _aloadIterator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _astoreIterator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CompareGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILcom/sun/org/apache/bcel/internal/generic/Type;[Lcom/sun/org/apache/bcel/internal/generic/Type;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/generic/InstructionList;Lcom/sun/org/apache/bcel/internal/generic/ConstantPoolGen;)V", "public")]
	public CompareGenerator(int arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type arg1, JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type> arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.InstructionList arg6, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ConstantPoolGen arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/CompareGenerator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadDOM()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadCurrentNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int getLocalIndex(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction storeIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction storeCurrentNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadLastNode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHandlerIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getIteratorIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}
}
