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

[JniSignatureAttribute("Ljavax/print/MultiDocPrintService;", "public abstract interface")]
public partial interface MultiDocPrintService
	: IJavaObject
	, Dova.JDK.javax.print.PrintService
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MultiDocPrintService()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/MultiDocPrintService;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createMultiDocPrintJob", "()Ljavax/print/MultiDocPrintJob;"));
	}

	[JniSignatureAttribute("()Ljavax/print/MultiDocPrintJob;", "public abstract")]
	Dova.JDK.javax.print.MultiDocPrintJob createMultiDocPrintJob()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.MultiDocPrintJob>(ret);
	}
}
