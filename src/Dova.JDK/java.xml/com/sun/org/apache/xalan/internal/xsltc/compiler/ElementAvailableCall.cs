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

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/ElementAvailableCall;", "final")]
public partial class ElementAvailableCall
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FunctionCall
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ElementAvailableCall()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/ElementAvailableCall;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "typeCheck", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResult", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "translate", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "evaluateAtCompileTime", "()Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ElementAvailableCall(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Ljava/util/List;)V", "public")]
	public ElementAvailableCall(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/ElementAvailableCall;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/SymbolTable;)Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/Type;", "public")]
	public Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type typeCheck(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.SymbolTable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.Type>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getResult()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void translate(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object evaluateAtCompileTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
