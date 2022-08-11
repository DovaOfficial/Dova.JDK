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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;", "public")]
public partial class ClassGenerator
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ClassGen
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassGenerator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSLET_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID_INDEX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_stylesheet", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_parser", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_aloadTranslet", "Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_domClass", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_domClassSig", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_applyTemplatesSig", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_applyTemplatesSigForImport", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMethod", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMClassSig", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDOMClass", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadTranslet", "()Lcom/sun/org/apache/bcel/internal/generic/Instruction;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParser", "()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExternal", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStylesheet", "()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getApplyTemplatesSig", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getApplyTemplatesSigForImport", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("I", "protected static final")]
	public static int TRANSLET_INDEX_Property
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

	[JniSignatureAttribute("I", "protected static")]
	public static int INVALID_INDEX_Property
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

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet _stylesheet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;", "private final")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser _parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "private final")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction _aloadTranslet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String _domClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String _domClassSig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String _applyTemplatesSig_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String _applyTemplatesSigForImport_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassGenerator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;I[Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;)V", "public")]
	public ClassGenerator(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, int arg3, JavaArray<Dova.JDK.java.lang.String> arg4, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getClassName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void addMethod(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getDOMClassSig()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getDOMClass()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/generic/Instruction;", "public")]
	public Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction loadTranslet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Instruction>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;", "public final")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser getParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isExternal()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;", "public final")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet getStylesheet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getApplyTemplatesSig()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getApplyTemplatesSigForImport()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
