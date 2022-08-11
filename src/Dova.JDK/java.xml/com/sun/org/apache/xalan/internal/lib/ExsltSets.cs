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

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.lib;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/lib/ExsltSets;", "public")]
public partial class ExsltSets
	: Dova.JDK.com.sun.org.apache.xalan.@internal.lib.ExsltBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExsltSets()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/lib/ExsltSets;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "distinct", "(Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "difference", "(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "hasSameNode", "(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "trailing", "(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "intersection", "(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "leading", "(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExsltSets(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ExsltSets() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/lib/ExsltSets;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList distinct(Dova.JDK.org.w3c.dom.NodeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList difference(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.org.w3c.dom.NodeList arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Z", "public static")]
	public static bool hasSameNode(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.org.w3c.dom.NodeList arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList trailing(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.org.w3c.dom.NodeList arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList intersection(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.org.w3c.dom.NodeList arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;Lorg/w3c/dom/NodeList;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList leading(Dova.JDK.org.w3c.dom.NodeList arg0, Dova.JDK.org.w3c.dom.NodeList arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}
}
