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

[JniSignatureAttribute("Ljava/awt/print/PrinterJob;", "public abstract")]
public partial class PrinterJob
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PrinterJob()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/print/PrinterJob;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PrinterJob", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "print", "(Ljavax/print/attribute/PrintRequestAttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cancel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCancelled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPrinterJob", "()Ljava/awt/print/PrinterJob;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintService", "(Ljavax/print/PrintService;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintable", "(Ljava/awt/print/Printable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPrintable", "(Ljava/awt/print/Printable;Ljava/awt/print/PageFormat;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCopies", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCopies", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDialog", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printDialog", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getUserName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPrintService", "()Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lookupPrintServices", "()[Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPageFormat", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultPage", "()Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultPage", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pageDialog", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pageDialog", "(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "validatePage", "(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "lookupStreamPrintServices", "(Ljava/lang/String;)[Ljavax/print/StreamPrintServiceFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPageable", "(Ljava/awt/print/Pageable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setJobName", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJobName", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public PrinterJob(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public PrinterJob() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/print/PrinterJob;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public abstract")]
	public void print()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/PrintRequestAttributeSet;)V", "public")]
	public void print(Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	public void cancel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool isCancelled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/print/PrinterJob;", "public static")]
	public static Dova.JDK.java.awt.print.PrinterJob getPrinterJob()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PrinterJob>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/PrintService;)V", "public")]
	public void setPrintService(Dova.JDK.javax.print.PrintService arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/print/Printable;)V", "public abstract")]
	public void setPrintable(Dova.JDK.java.awt.print.Printable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/print/Printable;Ljava/awt/print/PageFormat;)V", "public abstract")]
	public void setPrintable(Dova.JDK.java.awt.print.Printable arg0, Dova.JDK.java.awt.print.PageFormat arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public abstract")]
	public void setCopies(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()I", "public abstract")]
	public int getCopies()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/PrintRequestAttributeSet;)Z", "public")]
	public bool printDialog(Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	public bool printDialog()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getUserName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintService;", "public")]
	public Dova.JDK.javax.print.PrintService getPrintService()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/print/PrintService;", "public static")]
	public static JavaArray<Dova.JDK.javax.print.PrintService> lookupPrintServices()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.PrintService>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;", "public")]
	public Dova.JDK.java.awt.print.PageFormat getPageFormat(Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/print/PageFormat;", "public")]
	public Dova.JDK.java.awt.print.PageFormat defaultPage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", "public abstract")]
	public Dova.JDK.java.awt.print.PageFormat defaultPage(Dova.JDK.java.awt.print.PageFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", "public abstract")]
	public Dova.JDK.java.awt.print.PageFormat pageDialog(Dova.JDK.java.awt.print.PageFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/attribute/PrintRequestAttributeSet;)Ljava/awt/print/PageFormat;", "public")]
	public Dova.JDK.java.awt.print.PageFormat pageDialog(Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/print/PageFormat;)Ljava/awt/print/PageFormat;", "public abstract")]
	public Dova.JDK.java.awt.print.PageFormat validatePage(Dova.JDK.java.awt.print.PageFormat arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.PageFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljavax/print/StreamPrintServiceFactory;", "public static")]
	public static JavaArray<Dova.JDK.javax.print.StreamPrintServiceFactory> lookupStreamPrintServices(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.StreamPrintServiceFactory>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/print/Pageable;)V", "public abstract")]
	public void setPageable(Dova.JDK.java.awt.print.Pageable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	public void setJobName(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getJobName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
