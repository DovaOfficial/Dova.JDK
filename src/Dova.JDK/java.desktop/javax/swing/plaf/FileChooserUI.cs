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

namespace Dova.JDK.javax.swing.plaf;

[JniSignatureAttribute("Ljavax/swing/plaf/FileChooserUI;", "public abstract")]
public partial class FileChooserUI
	: Dova.JDK.javax.swing.plaf.ComponentUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static FileChooserUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/FileChooserUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultButton", "(Ljavax/swing/JFileChooser;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAcceptAllFileFilter", "(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileFilter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureFileIsVisible", "(Ljavax/swing/JFileChooser;Ljava/io/File;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rescanCurrentDirectory", "(Ljavax/swing/JFileChooser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDialogTitle", "(Ljavax/swing/JFileChooser;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileView", "(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getApproveButtonText", "(Ljavax/swing/JFileChooser;)Ljava/lang/String;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public FileChooserUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public FileChooserUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/FileChooserUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Ljavax/swing/JButton;", "public")]
	public Dova.JDK.javax.swing.JButton getDefaultButton(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileFilter;", "public abstract")]
	public Dova.JDK.javax.swing.filechooser.FileFilter getAcceptAllFileFilter(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.filechooser.FileFilter>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;Ljava/io/File;)V", "public abstract")]
	public void ensureFileIsVisible(Dova.JDK.javax.swing.JFileChooser arg0, Dova.JDK.java.io.File arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)V", "public abstract")]
	public void rescanCurrentDirectory(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getDialogTitle(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Ljavax/swing/filechooser/FileView;", "public abstract")]
	public Dova.JDK.javax.swing.filechooser.FileView getFileView(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.filechooser.FileView>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JFileChooser;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getApproveButtonText(Dova.JDK.javax.swing.JFileChooser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
