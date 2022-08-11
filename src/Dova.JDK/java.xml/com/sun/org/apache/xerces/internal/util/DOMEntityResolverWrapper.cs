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

namespace Dova.JDK.com.sun.org.apache.xerces.@internal.util;

[JniSignatureAttribute("Lcom/sun/org/apache/xerces/internal/util/DOMEntityResolverWrapper;", "public")]
public partial class DOMEntityResolverWrapper
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLEntityResolver
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DOMEntityResolverWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xerces/internal/util/DOMEntityResolverWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XML_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "XSD_TYPE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fEntityResolver", "Lorg/w3c/dom/ls/LSResourceResolver;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lorg/w3c/dom/ls/LSResourceResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEntityResolver", "(Lorg/w3c/dom/ls/LSResourceResolver;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntityResolver", "()Lorg/w3c/dom/ls/LSResourceResolver;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveEntity", "(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XML_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String XSD_TYPE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lorg/w3c/dom/ls/LSResourceResolver;", "protected")]
	public Dova.JDK.org.w3c.dom.ls.LSResourceResolver fEntityResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSResourceResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DOMEntityResolverWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DOMEntityResolverWrapper() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/ls/LSResourceResolver;)V", "public")]
	public DOMEntityResolverWrapper(Dova.JDK.org.w3c.dom.ls.LSResourceResolver arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xerces/internal/util/DOMEntityResolverWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getType(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/ls/LSResourceResolver;)V", "public")]
	public void setEntityResolver(Dova.JDK.org.w3c.dom.ls.LSResourceResolver arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lorg/w3c/dom/ls/LSResourceResolver;", "public")]
	public Dova.JDK.org.w3c.dom.ls.LSResourceResolver getEntityResolver()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.ls.LSResourceResolver>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xerces/internal/xni/XMLResourceIdentifier;)Lcom/sun/org/apache/xerces/internal/xni/parser/XMLInputSource;", "public")]
	public Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource resolveEntity(Dova.JDK.com.sun.org.apache.xerces.@internal.xni.XMLResourceIdentifier arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xerces.@internal.xni.parser.XMLInputSource>(ret);
	}
}
