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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LiteralElement;", "final")]
public partial class LiteralElement
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Instruction
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LiteralElement()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LiteralElement;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_name", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_literalElemParent", "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LiteralElement;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_attributeElements", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_accessedPrefixes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "_allAttributesUnique", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "display", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAttribute", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeCheck", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElemDesc", "()Lcom/sun/org/apache/xml/internal/serializer/ElemDesc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseContents", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contextDependent", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerNamespace", "(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accessedNamespace", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translateQName", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFirstAttribute", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamespaceScope", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAttributesUnique", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHTMLOutput", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canProduceAttributeNodes", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allAttributesUnique", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String _name_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LiteralElement;", "private")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.LiteralElement _literalElemParent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.LiteralElement>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List _attributeElements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map _accessedPrefixes_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool _allAttributesUnique_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LiteralElement(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public LiteralElement() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/LiteralElement;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void display(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V", "public")]
	public void addAttribute(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type typeCheck(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/xml/internal/serializer/ElemDesc;", "public")]
	public Dova.JDK.com.sun.org.apache.xml.@internal.serializer.ElemDesc getElemDesc()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xml.@internal.serializer.ElemDesc>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/Parser;)V", "public")]
	public void parseContents(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.Parser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Z", "protected")]
	public bool contextDependent()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;Z)V", "public")]
	public void registerNamespace(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String accessedNamespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String translateQName(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)V", "public")]
	public void setFirstAttribute(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getNamespaceScope(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool checkAttributesUnique()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isHTMLOutput()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SyntaxTreeNode;Z)Z", "private")]
	public bool canProduceAttributeNodes(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SyntaxTreeNode arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool allAttributesUnique()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void translate(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}
}
