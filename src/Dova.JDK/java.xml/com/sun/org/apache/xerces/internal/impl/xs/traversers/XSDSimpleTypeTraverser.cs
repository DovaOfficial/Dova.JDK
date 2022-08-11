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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDSimpleTypeTraverser;", "")]
public partial class XSDSimpleTypeTraverser
	: Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDAbstractTraverser
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XSDSimpleTypeTraverser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDSimpleTypeTraverser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fIsBuiltIn", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleType", "(Ljava/lang/String;Lorg/w3c/dom/Element;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseLocal", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "genAnonTypeName", "(Lorg/w3c/dom/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseSimpleTypeDecl", "(Lorg/w3c/dom/Element;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDTValidator", "(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/QName;SLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isListDatatype", "(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkBuiltIn", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "traverseGlobal", "(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorType", "(Ljava/lang/String;Ljava/lang/String;S)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fIsBuiltIn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XSDSimpleTypeTraverser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDHandler;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSAttributeChecker;)V", "")]
	public XSDSimpleTypeTraverser(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDHandler arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSAttributeChecker arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDSimpleTypeTraverser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Lorg/w3c/dom/Element;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType getSimpleType(Dova.JDK.java.lang.String arg0, Dova.JDK.org.w3c.dom.Element arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType traverseLocal(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String genAnonTypeName(Dova.JDK.org.w3c.dom.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;[Ljava/lang/Object;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType traverseSimpleTypeDecl(Dova.JDK.org.w3c.dom.Element arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg2, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Ljava/lang/String;Lcom/sun/org/apache/xerces/internal/xni/QName;SLcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType findDTValidator(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.QName arg2, short arg3, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;)Z", "private")]
	public bool isListDatatype(Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "private final")]
	public bool checkBuiltIn(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Element;Lcom/sun/org/apache/xerces/internal/impl/xs/traversers/XSDocumentInfo;Lcom/sun/org/apache/xerces/internal/impl/xs/SchemaGrammar;)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType traverseGlobal(Dova.JDK.org.w3c.dom.Element arg0, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.traversers.XSDocumentInfo arg1, Dova.JDK.com.sun.org.apache.xerces.@internal.impl.xs.SchemaGrammar arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;S)Lcom/sun/org/apache/xerces/internal/impl/dv/XSSimpleType;", "private")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType errorType(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, short arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.impl.dv.XSSimpleType>(ret);
	}
}
