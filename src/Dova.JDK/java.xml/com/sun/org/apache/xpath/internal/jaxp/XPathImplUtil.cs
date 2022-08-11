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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal.jaxp;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/jaxp/XPathImplUtil;", "")]
public partial class XPathImplUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathImplUtil()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/jaxp/XPathImplUtil;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "functionResolver", "Ljavax/xml/xpath/XPathFunctionResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "variableResolver", "Ljavax/xml/xpath/XPathVariableResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefixResolver", "Lcom/sun/org/apache/xpath/internal/jaxp/JAXPPrefixResolver;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overrideDefaultParser", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "featureSecureProcessing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "featureManager", "Ljdk/xml/internal/JdkXmlFeatures;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xmlSecMgr", "Ljdk/xml/internal/XMLSecurityManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljavax/xml/namespace/QName;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eval", "(Ljava/lang/Object;Lcom/sun/org/apache/xpath/internal/XPath;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResultAsType", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;Ljavax/xml/namespace/QName;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedClassType", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getXPathResult", "(Lcom/sun/org/apache/xpath/internal/objects/XObject;Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocument", "(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;"));
	}

	[JniSignatureAttribute("Ljavax/xml/xpath/XPathFunctionResolver;", "")]
	public Dova.JDK.javax.xml.xpath.XPathFunctionResolver functionResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathFunctionResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/xml/xpath/XPathVariableResolver;", "")]
	public Dova.JDK.javax.xml.xpath.XPathVariableResolver variableResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.xml.xpath.XPathVariableResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/jaxp/JAXPPrefixResolver;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.jaxp.JAXPPrefixResolver prefixResolver_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.jaxp.JAXPPrefixResolver>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool overrideDefaultParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool featureSecureProcessing_Property
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

	[JniSignatureAttribute("Ljdk/xml/internal/JdkXmlFeatures;", "")]
	public Dova.JDK.jdk.xml.@internal.JdkXmlFeatures featureManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.JdkXmlFeatures>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/xml/internal/XMLSecurityManager;", "")]
	public Dova.JDK.jdk.xml.@internal.XMLSecurityManager xmlSecMgr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.xml.@internal.XMLSecurityManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XPathImplUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public XPathImplUtil() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/jaxp/XPathImplUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/String;)V", "")]
	public void requireNonNull(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/xml/namespace/QName;)V", "")]
	public void isSupported(Dova.JDK.javax.xml.@namespace.QName arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Lcom/sun/org/apache/xpath/internal/XPath;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "")]
	public Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject eval(Dova.JDK.java.lang.Object arg0, Dova.JDK.com.sun.org.apache.xpath.@internal.XPath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;Ljavax/xml/namespace/QName;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getResultAsType(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0, Dova.JDK.javax.xml.@namespace.QName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "")]
	public void isSupportedClassType(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xpath/internal/objects/XObject;Ljava/lang/Class;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object getXPathResult(Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lorg/xml/sax/InputSource;)Lorg/w3c/dom/Document;", "")]
	public Dova.JDK.org.w3c.dom.Document getDocument(Dova.JDK.org.xml.sax.InputSource arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Document>(ret);
	}
}
