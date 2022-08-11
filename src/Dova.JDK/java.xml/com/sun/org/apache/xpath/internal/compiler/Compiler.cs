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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.compiler;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/compiler/Compiler;", "public")]
public partial class Compiler
	: Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.OpMap
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Compiler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/compiler/Compiler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "countOp", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locPathDepth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEBUG", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "s_nextMethodId", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_currentPrefixResolver", "Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_errorHandler", "Ljavax/xml/transform/ErrorListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_locator", "Ljavax/xml/transform/SourceLocator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "m_functionTable", "Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/xml/transform/ErrorListener;Ljavax/xml/transform/SourceLocator;Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compile", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "arg", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mod", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lt", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "number", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "string", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "predicate", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "or", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "literal", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mult", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "and", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "div", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "neg", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "union", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locationPath", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNamespaceContext", "(Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceContext", "()Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "bool", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWhatToShow", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notequals", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lte", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gte", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "numberlit", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileExtension", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileFunction", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matchPattern", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "locationPathPattern", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileOperation", "(Lcom/sun/org/apache/xpath/internal/operations/Operation;I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileUnary", "(Lcom/sun/org/apache/xpath/internal/operations/UnaryOperation;I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stepPattern", "(IILcom/sun/org/apache/xpath/internal/patterns/StepPattern;)Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCompiledPredicates", "(I)[Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "countPredicates", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compilePredicates", "(I[Lcom/sun/org/apache/xpath/internal/Expression;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextMethodId", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compileExpression", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationPathDepth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFunctionTable", "()Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "assertion", "(ZLjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "variable", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "gt", "(I)Lcom/sun/org/apache/xpath/internal/Expression;"));
	}

	[JniSignatureAttribute("I", "")]
	public int countOp_Property
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
	public int locPathDepth_Property
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

	[JniSignatureAttribute("Z", "private static final")]
	public static bool DEBUG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("J", "private static")]
	public static long s_nextMethodId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;", "private")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver m_currentPrefixResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/ErrorListener;", "")]
	public Dova.JDK.javax.xml.transform.ErrorListener m_errorHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.ErrorListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/transform/SourceLocator;", "")]
	public Dova.JDK.javax.xml.transform.SourceLocator m_locator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.transform.SourceLocator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.FunctionTable m_functionTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.FunctionTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Compiler(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/xml/transform/ErrorListener;Ljavax/xml/transform/SourceLocator;Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;)V", "public")]
	public Compiler(Dova.JDK.javax.xml.transform.ErrorListener arg0, Dova.JDK.javax.xml.transform.SourceLocator arg1, Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.FunctionTable arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Compiler() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/compiler/Compiler;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression group(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression equals(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compile(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression arg(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression mod(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
	public void error(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression lt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression number(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "public")]
	public void warn(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression @string(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression predicate(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression or(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression literal(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression mult(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression and(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression minus(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression plus(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression div(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression neg(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression union(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression locationPath(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)V", "public")]
	public void setNamespaceContext(Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver getNamespaceContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression @bool(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getWhatToShow(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression notequals(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression lte(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression gte(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression numberlit(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compileExtension(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compileFunction(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression matchPattern(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression locationPathPattern(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/operations/Operation;I)Lcom/sun/org/apache/xpath/internal/Expression;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compileOperation(Dova.JDK.com.sun.org.apache.xpath.@internal.operations.Operation arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/operations/UnaryOperation;I)Lcom/sun/org/apache/xpath/internal/Expression;", "private")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compileUnary(Dova.JDK.com.sun.org.apache.xpath.@internal.operations.UnaryOperation arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(IILcom/sun/org/apache/xpath/internal/patterns/StepPattern;)Lcom/sun/org/apache/xpath/internal/patterns/StepPattern;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern stepPattern(int arg0, int arg1, Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.patterns.StepPattern>(ret);
	}

	[JniSignatureAttribute("(I)[Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression> getCompiledPredicates(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int countPredicates(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I[Lcom/sun/org/apache/xpath/internal/Expression;)V", "private")]
	public void compilePredicates(int arg0, JavaArray<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
	}

	[JniSignatureAttribute("()J", "private synchronized")]
	public long getNextMethodId()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "public")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression compileExpression(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLocationPathDepth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xpath/internal/compiler/FunctionTable;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.FunctionTable getFunctionTable()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.compiler.FunctionTable>(ret);
	}

	[JniSignatureAttribute("(ZLjava/lang/String;)V", "public")]
	public void assertion(bool arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression variable(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/org/apache/xpath/internal/Expression;", "protected")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.Expression gt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.Expression>(ret);
	}
}
