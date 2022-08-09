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

namespace Dova.JDK.javax.print.@event;

[JniSignatureAttribute("Ljavax/print/event/PrintJobListener;", "public abstract interface")]
public partial interface PrintJobListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintJobListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/event/PrintJobListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printDataTransferCompleted", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobCompleted", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobFailed", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobCanceled", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobNoMoreEvents", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobRequiresAttention", "(Ljavax/print/event/PrintJobEvent;)V"));
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printDataTransferCompleted(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printJobCompleted(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printJobFailed(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printJobCanceled(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printJobNoMoreEvents(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public abstract")]
	void printJobRequiresAttention(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
