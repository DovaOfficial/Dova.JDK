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

namespace Dova.JDK.com.sun.org.apache.xpath.@internal;

[JniSignatureAttribute("Lcom/sun/org/apache/xpath/internal/XPathAPI;", "public")]
public partial class XPathAPI
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XPathAPI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xpath/internal/XPathAPI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eval", "(Lorg/w3c/dom/Node;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eval", "(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "eval", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectSingleNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectSingleNode", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectNodeIterator", "(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/traversal/NodeIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectNodeIterator", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/traversal/NodeIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectNodeList", "(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "selectNodeList", "(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/NodeList;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XPathAPI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XPathAPI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xpath/internal/XPathAPI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Lcom/sun/org/apache/xml/internal/utils/PrefixResolver;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject eval(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.org.apache.xml.@internal.utils.PrefixResolver arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject eval(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Node arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject eval(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/Node;", "public static")]
	public static Dova.JDK.org.w3c.dom.Node selectSingleNode(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Node arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/Node;", "public static")]
	public static Dova.JDK.org.w3c.dom.Node selectSingleNode(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.Node>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/traversal/NodeIterator;", "public static")]
	public static Dova.JDK.org.w3c.dom.traversal.NodeIterator selectNodeIterator(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Node arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeIterator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/traversal/NodeIterator;", "public static")]
	public static Dova.JDK.org.w3c.dom.traversal.NodeIterator selectNodeIterator(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.traversal.NodeIterator>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;Lorg/w3c/dom/Node;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList selectNodeList(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.org.w3c.dom.Node arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/Node;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList selectNodeList(Dova.JDK.org.w3c.dom.Node arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}
}
