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

[JniSignatureAttribute("Ljavax/print/event/PrintJobAdapter;", "public abstract")]
public partial class PrintJobAdapter
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.print.@event.PrintJobListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrintJobAdapter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/print/event/PrintJobAdapter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "PrintJobAdapter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printDataTransferCompleted", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobCompleted", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobFailed", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobCanceled", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobNoMoreEvents", "(Ljavax/print/event/PrintJobEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "printJobRequiresAttention", "(Ljavax/print/event/PrintJobEvent;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrintJobAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public PrintJobAdapter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/print/event/PrintJobAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printDataTransferCompleted(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printJobCompleted(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printJobFailed(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printJobCanceled(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printJobNoMoreEvents(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/print/event/PrintJobEvent;)V", "public")]
	public void printJobRequiresAttention(Dova.JDK.javax.print.@event.PrintJobEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}