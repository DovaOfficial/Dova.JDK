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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/lib/ExsltCommon;", "public")]
public partial class ExsltCommon
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ExsltCommon()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/lib/ExsltCommon;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "objectType", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "nodeSet", "(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Ljava/lang/Object;)Lcom/sun/org/apache/xpath/internal/NodeSet;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ExsltCommon(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ExsltCommon() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/lib/ExsltCommon;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String objectType(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/extensions/ExpressionContext;Ljava/lang/Object;)Lcom/sun/org/apache/xpath/internal/NodeSet;", "public static")]
	public static Dova.JDK.com.sun.org.apache.xpath.@internal.NodeSet nodeSet(Dova.JDK.com.sun.org.apache.xalan.@internal.extensions.ExpressionContext arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xpath.@internal.NodeSet>(ret);
	}
}
