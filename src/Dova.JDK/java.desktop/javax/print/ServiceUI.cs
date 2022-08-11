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

[JniSignatureAttribute("Ljavax/print/ServiceUI;", "public")]
public partial class ServiceUI
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServiceUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/print/ServiceUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "printDialog", "(Ljava/awt/GraphicsConfiguration;II[Ljavax/print/PrintService;Ljavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeUnsupportedAttributes", "(Ljavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServiceUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ServiceUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/print/ServiceUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;II[Ljavax/print/PrintService;Ljavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)Ljavax/print/PrintService;", "public static")]
	public static Dova.JDK.javax.print.PrintService printDialog(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, JavaArray<Dova.JDK.javax.print.PrintService> arg3, Dova.JDK.javax.print.PrintService arg4, Dova.JDK.javax.print.DocFlavor arg5, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg6)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("(Ljavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/AttributeSet;)V", "private static")]
	public static void removeUnsupportedAttributes(Dova.JDK.javax.print.PrintService arg0, Dova.JDK.javax.print.DocFlavor arg1, Dova.JDK.javax.print.attribute.AttributeSet arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}
}
