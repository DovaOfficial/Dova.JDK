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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public abstract")]
public partial class Type
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Constants
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Type()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Int", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Real", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Boolean", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NodeSet", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "String", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ResultTree", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Reference", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Void", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Object", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ObjectString", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Node", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Root", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Element", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Attribute", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Text", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Comment", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Processing_Instruction", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "LT", "(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "GT", "(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DIV", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "identicalTo", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateTo", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateTo", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newObjectType", "(Ljava/lang/Class;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newObjectType", "(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSignature", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJCType", "()Lcom/sun/org/apache/bcel/internal/generic/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "STORE", "(I)Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DUP", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "LOAD", "(I)Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateFrom", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "POP", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "distanceTo", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSimple", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateToDesynthesized", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/BooleanType;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FlowList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateToDesynthesized", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FlowList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNumber", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implementedAsMethod", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateBox", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateUnBox", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ADD", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "SUB", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "MUL", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "REM", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "NEG", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "GE", "(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "LE", "(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "CMP", "(Z)Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Int_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Real_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Boolean_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type NodeSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type String_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type ResultTree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Reference_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Void_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Object_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type ObjectString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Node_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Root_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Element_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Attribute_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Text_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Comment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type Processing_Instruction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Type(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Type() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction LT(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction GT(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction DIV()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)Z", "public abstract")]
	public bool identicalTo(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Ljava/lang/Class;)V", "public")]
	public void translateTo(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)V", "public")]
	public void translateTo(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type newObjectType(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type newObjectType(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String toSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Type;", "public abstract")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type toJCType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Type>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction STORE(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction DUP()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction LOAD(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Ljava/lang/Class;)V", "public")]
	public void translateFrom(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.java.lang.Class arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction POP()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)I", "public")]
	public int distanceTo(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSimple()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/BooleanType;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FlowList;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FlowList translateToDesynthesized(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.BooleanType arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FlowList>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FlowList;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FlowList translateToDesynthesized(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FlowList>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNumber()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool implementedAsMethod()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void translateBox(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void translateUnBox(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction ADD()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction SUB()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction MUL()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction REM()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction NEG()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction GE(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/bcel/internal/generic/BranchInstruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction LE(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.BranchInstruction>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction CMP(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}
}
