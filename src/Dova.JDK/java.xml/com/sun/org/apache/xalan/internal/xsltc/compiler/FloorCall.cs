/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler;

[JniSignatureAttribute("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FloorCall;", "final")]
public partial class FloorCall
	: Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.FunctionCall
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FloorCall()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FloorCall;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "FloorCall", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "translate", "(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FloorCall(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/QName;Ljava/util/List;)V", "public")]
	public FloorCall(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.QName arg0, Dova.JDK.java.util.List arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/xalan/internal/xsltc/compiler/FloorCall;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/ClassGenerator;Lcom/sun/org/apache/xalan/internal/xsltc/compiler/util/MethodGenerator;)V", "public")]
	public void translate(Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.ClassGenerator arg0, Dova.JDK.com.sun.org.apache.xalan.@internal.xsltc.compiler.util.MethodGenerator arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}