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

namespace Dova.JDK.javax.print;

[JniSignatureAttribute("Ljavax/print/MultiDocPrintJob;", "public abstract interface")]
public partial interface MultiDocPrintJob
	: IJavaObject
	, Dova.JDK.javax.print.DocPrintJob
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultiDocPrintJob()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/MultiDocPrintJob;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/print/MultiDoc;Ljavax/print/attribute/PrintRequestAttributeSet;)V"));
	}

	[JniSignatureAttribute("(Ljavax/print/MultiDoc;Ljavax/print/attribute/PrintRequestAttributeSet;)V", "public abstract")]
	void print(Dova.JDK.javax.print.MultiDoc arg0, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
