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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal.generic;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/generic/FieldObserver;", "public abstract interface")]
public partial interface FieldObserver
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FieldObserver()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/generic/FieldObserver;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "notify", "(Lcom/sun/org/apache/bcel/internal/generic/FieldGen;)V"));
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/generic/FieldGen;)V", "public abstract")]
	void notify(Dova.JDK.com.sun.org.apache.bcel.@internal.generic.FieldGen arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}