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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/lib/NodeInfo;", "public")]
public partial class NodeInfo
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static NodeInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/lib/NodeInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lineNumber", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lineNumber", "(Lorg/w3c/dom/NodeList;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "publicId", "(Lorg/w3c/dom/NodeList;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "publicId", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "columnNumber", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "columnNumber", "(Lorg/w3c/dom/NodeList;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "systemId", "(Lorg/w3c/dom/NodeList;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "systemId", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public NodeInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public NodeInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/lib/NodeInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)I", "public static")]
	public static int lineNumber(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;)I", "public static")]
	public static int lineNumber(Dova.JDK.org.w3c.dom.NodeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String publicId(Dova.JDK.org.w3c.dom.NodeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String publicId(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)I", "public static")]
	public static int columnNumber(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;)I", "public static")]
	public static int columnNumber(Dova.JDK.org.w3c.dom.NodeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lorg/w3c/dom/NodeList;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String systemId(Dova.JDK.org.w3c.dom.NodeList arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String systemId(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
