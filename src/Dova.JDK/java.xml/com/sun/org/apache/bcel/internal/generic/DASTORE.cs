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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/DASTORE;", "public")]
public partial class DASTORE
	: Dova.JDK.com.sun.org.apache.bcel.@internal.generic.ArrayInstruction
	, Dova.JDK.com.sun.org.apache.bcel.@internal.generic.StackConsumer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DASTORE()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/DASTORE;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/org/apache/bcel/internal/generic/Visitor;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DASTORE(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DASTORE() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/generic/DASTORE;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/Visitor;)V", "public")]
	public void accept(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
