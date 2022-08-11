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
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/MultiDocPrintService;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMultiDocPrintJob", "()Ljavax/print/MultiDocPrintJob;"));
	}

	[JniSignatureAttribute("()Ljavax/print/MultiDocPrintJob;", "public abstract")]
	Dova.JDK.javax.print.MultiDocPrintJob createMultiDocPrintJob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.MultiDocPrintJob>(ret);
	}
}
