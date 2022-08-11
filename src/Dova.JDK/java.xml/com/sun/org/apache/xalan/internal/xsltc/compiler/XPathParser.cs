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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/XPathParser;", "public")]
public partial class XPathParser
	: Dova.JDK.com.sun.java_cup.@internal.runtime.lr_parser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/XPathParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "grpLimit", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opLimit", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "totalOpLimit", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_production_table", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_action_table", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_reduce_table", "[[S"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action_obj", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/parser_actions;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EmptyArgs", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DummyVarRef", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/VariableRef;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_parser", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_xsltc", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/XSLTC;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_expression", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_lineNumber", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_symbolTable", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_xmlSM", "Ljdk/xml/internal/XMLSecurityManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_limitAnalyzer", "Ljdk/xml/internal/XMLLimitAnalyzer;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/java_cup/internal/runtime/Scanner;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineNumber", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;I)Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertStep", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Step;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/RelativeLocationPath;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/RelativeLocationPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addError", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ErrorMsg;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "production_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "action_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce_table", "()[[S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init_actions", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "do_action", "(ILcom/sun/java_cup/internal/runtime/lr_parser;Ljava/util/Stack;I)Lcom/sun/java_cup/internal/runtime/Symbol;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start_state", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "start_production", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "EOF_sym", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error_sym", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createStepPattern", "(ILjava/lang/Object;Ljava/util/List;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/StepPattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findNodeType", "(ILjava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report_error", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report_fatal_error", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isElementAxis", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupName", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQName", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQNameIgnoreDefaultNs", "(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCallsNodeset", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMultiDocument", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setHasIdCall", "(Z)V"));
	}

	[JniSignatureAttribute("I", "private")]
	public int grpLimit_Property
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

	[JniSignatureAttribute("I", "private")]
	public int opLimit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int totalOpLimit_Property
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

	[JniSignatureAttribute("[[S", "protected static final")]
	public static JavaArray<JavaArray<short>> _production_table_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "protected static final")]
	public static JavaArray<JavaArray<short>> _action_table_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[[S", "protected static final")]
	public static JavaArray<JavaArray<short>> _reduce_table_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/parser_actions;", "protected")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.parser_actions action_obj_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.parser_actions>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "public static final")]
	public static Dova.JDK.java.util.List EmptyArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/VariableRef;", "public static final")]
	public static Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.VariableRef DummyVarRef_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.VariableRef>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser _parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/XSLTC;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.XSLTC _xsltc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.XSLTC>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _expression_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _lineNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable _symbolTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/xml/internal/XMLSecurityManager;", "private")]
	public Dova.JDK.jdk.xml.@internal.XMLSecurityManager _xmlSM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.XMLSecurityManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/xml/internal/XMLLimitAnalyzer;", "private")]
	public Dova.JDK.jdk.xml.@internal.XMLLimitAnalyzer _limitAnalyzer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.XMLLimitAnalyzer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XPathParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;)V", "public")]
	public XPathParser(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/java_cup/internal/runtime/Scanner;)V", "public")]
	public XPathParser(Dova.JDK.com.sun.java_cup.@internal.runtime.Scanner arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XPathParser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/XPathParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "public")]
	public int getLineNumber()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/java_cup/internal/runtime/Symbol;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol parse(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Step;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/RelativeLocationPath;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/RelativeLocationPath;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.RelativeLocationPath insertStep(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Step arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.RelativeLocationPath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.RelativeLocationPath>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ErrorMsg;)V", "public final")]
	public void addError(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ErrorMsg arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()[[S", "public")]
	public JavaArray<JavaArray<short>> production_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()[[S", "public")]
	public JavaArray<JavaArray<short>> action_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()[[S", "public")]
	public JavaArray<JavaArray<short>> reduce_table()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<JavaArray<short>>>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void init_actions()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(ILcom/sun/java_cup/internal/runtime/lr_parser;Ljava/util/Stack;I)Lcom/sun/java_cup/internal/runtime/Symbol;", "public")]
	public Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol do_action(int arg0, Dova.JDK.com.sun.java_cup.@internal.runtime.lr_parser arg1, Dova.JDK.java.util.Stack arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java_cup.@internal.runtime.Symbol>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int start_state()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int start_production()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int EOF_sym()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int error_sym()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/lang/Object;Ljava/util/List;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/StepPattern;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.StepPattern createStepPattern(int arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.StepPattern>(ret);
	}

	[JniSignatureAttribute("(ILjava/lang/Object;)I", "public")]
	public int findNodeType(int arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void report_error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "public")]
	public void report_fatal_error(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isElementAxis(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;", "final")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode lookupName(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName getQName(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName getQNameIgnoreDefaultNs(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setCallsNodeset(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setMultiDocument(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setHasIdCall(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}
}
