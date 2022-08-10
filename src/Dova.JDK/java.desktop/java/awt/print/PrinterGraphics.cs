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

namespace Dova.JDK.java.awt.print;

[JniSignatureAttribute("Ljava/awt/print/PrinterGraphics;", "public abstract interface")]
public partial interface PrinterGraphics
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrinterGraphics()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/print/PrinterGraphics;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrinterJob", "()Ljava/awt/print/PrinterJob;"));
	}

	[JniSignatureAttribute("()Ljava/awt/print/PrinterJob;", "public abstract")]
	Dova.JDK.java.awt.print.PrinterJob getPrinterJob()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PrinterJob>(ret);
	}
}
