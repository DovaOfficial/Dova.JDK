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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;", "final")]
public partial class SymbolTable
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SymbolTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_stylesheets", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_primops", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_variables", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_templates", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_attributeSets", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_aliases", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_excludedURI", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_excludedURIStack", "Ljava/util/Stack;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_decimalFormats", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_keys", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_nsCounter", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_current", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKey", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Key;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addParam", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStylesheet", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pushExcludedNamespacesContext", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popExcludedNamespacesContext", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupAttributeSet", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "excludeURI", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecimalFormatting", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/DecimalFormatting;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDecimalFormatting", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/DecimalFormatting;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupStylesheet", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTemplate", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPrimop", "(Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPrefixAlias", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupName", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupNamespace", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupPrimop", "(Ljava/lang/String;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVariable", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttributeSet", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupVariable", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupParam", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCurrentNode", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupTemplate", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateNamespacePrefix", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupPrefixAlias", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "excludeNamespaces", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExcludedNamespace", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unExcludeNamespaces", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addKey", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Key;)V"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map _stylesheets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map _primops_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _variables_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _templates_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _attributeSets_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _aliases_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _excludedURI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Stack;", "private")]
	public Dova.JDK.java.util.Stack _excludedURIStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _decimalFormats_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _keys_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int _nsCounter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode _current_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SymbolTable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public SymbolTable() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Key;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Key getKey(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Key>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Param addParam(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Param arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Param>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet addStylesheet(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void pushExcludedNamespacesContext()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void popExcludedNamespacesContext()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.AttributeSet lookupAttributeSet(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.AttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void excludeURI(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/DecimalFormatting;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.DecimalFormatting getDecimalFormatting(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.DecimalFormatting>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/DecimalFormatting;)V", "public")]
	public void addDecimalFormatting(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.DecimalFormatting arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Stylesheet;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet lookupStylesheet(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Stylesheet>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template addTemplate(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodType;)V", "public")]
	public void addPrimop(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodType arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public void addPrefixAlias(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode lookupName(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String lookupNamespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List lookupPrimop(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Variable addVariable(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Variable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Variable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/AttributeSet;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.AttributeSet addAttributeSet(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.AttributeSet>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Variable;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Variable lookupVariable(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Variable>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Param;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Param lookupParam(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Param>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V", "public")]
	public void setCurrentNode(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Template;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template lookupTemplate(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Template>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String generateNamespacePrefix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String lookupPrefixAlias(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void excludeNamespaces(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
	public bool isExcludedNamespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void unExcludeNamespaces(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Key;)V", "public")]
	public void addKey(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Key arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}
}
