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

[JniSignatureAttribute("Ljavax/print/DocPrintJob;", "public abstract interface")]
public partial interface DocPrintJob
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocPrintJob()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/DocPrintJob;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/print/Doc;Ljavax/print/attribute/PrintRequestAttributeSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljavax/print/attribute/PrintJobAttributeSet;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getPrintService", "()Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addPrintJobListener", "(Ljavax/print/event/PrintJobListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removePrintJobListener", "(Ljavax/print/event/PrintJobListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addPrintJobAttributeListener", "(Ljavax/print/event/PrintJobAttributeListener;Ljavax/print/attribute/PrintJobAttributeSet;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removePrintJobAttributeListener", "(Ljavax/print/event/PrintJobAttributeListener;)V"));
	}

	[JniSignatureAttribute("(Ljavax/print/Doc;Ljavax/print/attribute/PrintRequestAttributeSet;)V", "public abstract")]
	void print(Dova.JDK.javax.print.Doc arg0, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/print/attribute/PrintJobAttributeSet;", "public abstract")]
	Dova.JDK.javax.print.attribute.PrintJobAttributeSet getAttributes()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.PrintJobAttributeSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintService;", "public abstract")]
	Dova.JDK.javax.print.PrintService getPrintService()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobListener;)V", "public abstract")]
	void addPrintJobListener(Dova.JDK.javax.print.@event.PrintJobListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobListener;)V", "public abstract")]
	void removePrintJobListener(Dova.JDK.javax.print.@event.PrintJobListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobAttributeListener;Ljavax/print/attribute/PrintJobAttributeSet;)V", "public abstract")]
	void addPrintJobAttributeListener(Dova.JDK.javax.print.@event.PrintJobAttributeListener arg0, Dova.JDK.javax.print.attribute.PrintJobAttributeSet arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobAttributeListener;)V", "public abstract")]
	void removePrintJobAttributeListener(Dova.JDK.javax.print.@event.PrintJobAttributeListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
