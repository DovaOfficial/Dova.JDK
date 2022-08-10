/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/lib/ExsltDynamic;", "public")]
public partial class ExsltDynamic
	: Dova.JDK.com.sun.org.apache.xalan.@internal.lib.ExsltBase
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExsltDynamic()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/lib/ExsltDynamic;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXSL_URI", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ExsltDynamic", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "min", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "max", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "map", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "sum", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "closure", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)Lorg/w3c/dom/NodeList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "evaluate", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Ljava/lang/String;)Lcom/sun/org/apache/xpath/internal/objects/XObject;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EXSL_URI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExsltDynamic(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ExsltDynamic() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/lib/ExsltDynamic;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D", "public static")]
	public static double min(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.org.w3c.dom.NodeList arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D", "public static")]
	public static double max(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.org.w3c.dom.NodeList arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList map(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.org.w3c.dom.NodeList arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)D", "public static")]
	public static double sum(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.org.w3c.dom.NodeList arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticDoubleMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Lorg/w3c/dom/NodeList;Ljava/lang/String;)Lorg/w3c/dom/NodeList;", "public static")]
	public static Dova.JDK.org.w3c.dom.NodeList closure(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.org.w3c.dom.NodeList arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.org.w3c.dom.NodeList>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Ljava/lang/String;)Lcom/sun/org/apache/xpath/internal/objects/XObject;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject evaluate(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.objects.XObject>(ret);
	}
}
