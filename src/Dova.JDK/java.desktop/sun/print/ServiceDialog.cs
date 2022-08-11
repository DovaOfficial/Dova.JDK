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

namespace Dova.JDK.sun.print;

[JniSignatureAttribute("Lsun/print/ServiceDialog;", "public")]
public partial class ServiceDialog
	: Dova.JDK.javax.swing.JDialog
	, Dova.JDK.java.awt.@event.ActionListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ServiceDialog()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WAITING", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPROVE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CANCEL", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "strBundle", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "panelInsets", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "compInsets", "Ljava/awt/Insets;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "messageRB", "Ljava/util/ResourceBundle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tpTabs", "Ljavax/swing/JTabbedPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btnCancel", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btnApprove", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "services", "[Ljavax/print/PrintService;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultServiceIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asOriginal", "Ljavax/print/attribute/PrintRequestAttributeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "asCurrent", "Ljavax/print/attribute/HashPrintRequestAttributeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "psCurrent", "Ljavax/print/PrintService;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docFlavor", "Ljavax/print/DocFlavor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "status", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jfc", "Lsun/print/ServiceDialog$ValidatingFileChooser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlGeneral", "Lsun/print/ServiceDialog$GeneralPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlPageSetup", "Lsun/print/ServiceDialog$PageSetupPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlAppearance", "Lsun/print/ServiceDialog$AppearancePanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isAWT", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "_keyEventClazz", "Ljava/lang/Class;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/GraphicsConfiguration;II[Ljavax/print/PrintService;ILjavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;Ljava/awt/Window;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/GraphicsConfiguration;IILjavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;Ljava/awt/Window;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/print/attribute/PrintRequestAttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMsg", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintService", "()Ljavax/print/PrintService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatus", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPrintDialog", "(II[Ljavax/print/PrintService;ILjavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getVKMnemonic", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePanels", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createExitButton", "(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEscKey", "(Ljavax/swing/JButton;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initPageDialog", "(IILjavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showFileChooser", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeMnemonics", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getImageResource", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createCheckBox", "(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JCheckBox;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRadioButton", "(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JRadioButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "showNoPrintService", "(Ljava/awt/GraphicsConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addToGB", "(Ljava/awt/Component;Ljava/awt/Container;Ljava/awt/GridBagLayout;Ljava/awt/GridBagConstraints;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addToBG", "(Ljavax/swing/AbstractButton;Ljava/awt/Container;Ljavax/swing/ButtonGroup;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initResource", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMnemonic", "(Ljava/lang/String;)C"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createButton", "(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JButton;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int WAITING_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int APPROVE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int CANCEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String strBundle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets panelInsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Insets;", "private static final")]
	public static Dova.JDK.java.awt.Insets compInsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ResourceBundle;", "private static")]
	public static Dova.JDK.java.util.ResourceBundle messageRB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ResourceBundle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTabbedPane;", "private")]
	public Dova.JDK.javax.swing.JTabbedPane tpTabs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTabbedPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton btnCancel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton btnApprove_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/print/PrintService;", "private")]
	public JavaArray<Dova.JDK.javax.print.PrintService> services_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.print.PrintService>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int defaultServiceIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Ljavax/print/attribute/PrintRequestAttributeSet;", "private")]
	public Dova.JDK.javax.print.attribute.PrintRequestAttributeSet asOriginal_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.PrintRequestAttributeSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/print/attribute/HashPrintRequestAttributeSet;", "private")]
	public Dova.JDK.javax.print.attribute.HashPrintRequestAttributeSet asCurrent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.HashPrintRequestAttributeSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/print/PrintService;", "private")]
	public Dova.JDK.javax.print.PrintService psCurrent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/print/DocFlavor;", "private")]
	public Dova.JDK.javax.print.DocFlavor docFlavor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.DocFlavor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int status_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$ValidatingFileChooser;", "private")]
	public Dova.JDK.sun.print.ServiceDialog.ValidatingFileChooser jfc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.ValidatingFileChooser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$GeneralPanel;", "private")]
	public Dova.JDK.sun.print.ServiceDialog.GeneralPanel pnlGeneral_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.GeneralPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$PageSetupPanel;", "private")]
	public Dova.JDK.sun.print.ServiceDialog.PageSetupPanel pnlPageSetup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.PageSetupPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$AppearancePanel;", "private")]
	public Dova.JDK.sun.print.ServiceDialog.AppearancePanel pnlAppearance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.AppearancePanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isAWT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class _keyEventClazz_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ServiceDialog(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;II[Ljavax/print/PrintService;ILjavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;Ljava/awt/Window;)V", "public")]
	public ServiceDialog(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, JavaArray<Dova.JDK.javax.print.PrintService> arg3, int arg4, Dova.JDK.javax.print.DocFlavor arg5, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg6, Dova.JDK.java.awt.Window arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;IILjavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;Ljava/awt/Window;)V", "public")]
	public ServiceDialog(Dova.JDK.java.awt.GraphicsConfiguration arg0, int arg1, int arg2, Dova.JDK.javax.print.PrintService arg3, Dova.JDK.javax.print.DocFlavor arg4, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg5, Dova.JDK.java.awt.Window arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/print/attribute/PrintRequestAttributeSet;", "public")]
	public Dova.JDK.javax.print.attribute.PrintRequestAttributeSet getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.PrintRequestAttributeSet>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void dispose(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
	public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getMsg(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/print/PrintService;", "public")]
	public Dova.JDK.javax.print.PrintService getPrintService()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.print.PrintService>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStatus()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(II[Ljavax/print/PrintService;ILjavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)V", "")]
	public void initPrintDialog(int arg0, int arg1, JavaArray<Dova.JDK.javax.print.PrintService> arg2, int arg3, Dova.JDK.javax.print.DocFlavor arg4, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private static")]
	public static int getVKMnemonic(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void updatePanels()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JButton;", "private static")]
	public static Dova.JDK.javax.swing.JButton createExitButton(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JButton;)V", "private")]
	public void handleEscKey(Dova.JDK.javax.swing.JButton arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(IILjavax/print/PrintService;Ljavax/print/DocFlavor;Ljavax/print/attribute/PrintRequestAttributeSet;)V", "")]
	public void initPageDialog(int arg0, int arg1, Dova.JDK.javax.print.PrintService arg2, Dova.JDK.javax.print.DocFlavor arg3, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool showFileChooser()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String removeMnemonics(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "private static")]
	public static Dova.JDK.java.net.URL getImageResource(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JCheckBox;", "private static")]
	public static Dova.JDK.javax.swing.JCheckBox createCheckBox(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JCheckBox>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JRadioButton;", "private static")]
	public static Dova.JDK.javax.swing.JRadioButton createRadioButton(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/GraphicsConfiguration;)V", "public static")]
	public static void showNoPrintService(Dova.JDK.java.awt.GraphicsConfiguration arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Container;Ljava/awt/GridBagLayout;Ljava/awt/GridBagConstraints;)V", "private static")]
	public static void addToGB(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Container arg1, Dova.JDK.java.awt.GridBagLayout arg2, Dova.JDK.java.awt.GridBagConstraints arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/AbstractButton;Ljava/awt/Container;Ljavax/swing/ButtonGroup;)V", "private static")]
	public static void addToBG(Dova.JDK.javax.swing.AbstractButton arg0, Dova.JDK.java.awt.Container arg1, Dova.JDK.javax.swing.ButtonGroup arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void initResource()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)C", "private static")]
	public static char getMnemonic(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticCharMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/event/ActionListener;)Ljavax/swing/JButton;", "private static")]
	public static Dova.JDK.javax.swing.JButton createButton(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$GeneralPanel;", "private")]
	public partial class GeneralPanel
		: Dova.JDK.javax.swing.JPanel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GeneralPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$GeneralPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlPrintService", "Lsun/print/ServiceDialog$PrintServicePanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlPrintRange", "Lsun/print/ServiceDialog$PrintRangePanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlCopies", "Lsun/print/ServiceDialog$CopiesPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrintToFileRequested", "()Z"));
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$PrintServicePanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.PrintServicePanel pnlPrintService_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.PrintServicePanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$PrintRangePanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.PrintRangePanel pnlPrintRange_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.PrintRangePanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$CopiesPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.CopiesPanel pnlCopies_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.CopiesPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GeneralPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public GeneralPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$GeneralPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrintToFileRequested()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$PageSetupPanel;", "private")]
	public partial class PageSetupPanel
		: Dova.JDK.javax.swing.JPanel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PageSetupPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$PageSetupPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlMedia", "Lsun/print/ServiceDialog$MediaPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlOrientation", "Lsun/print/ServiceDialog$OrientationPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlMargins", "Lsun/print/ServiceDialog$MarginsPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$MediaPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.MediaPanel pnlMedia_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.MediaPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$OrientationPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.OrientationPanel pnlOrientation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.OrientationPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$MarginsPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.MarginsPanel pnlMargins_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.MarginsPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PageSetupPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public PageSetupPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$PageSetupPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$AppearancePanel;", "private")]
	public partial class AppearancePanel
		: Dova.JDK.javax.swing.JPanel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AppearancePanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$AppearancePanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlChromaticity", "Lsun/print/ServiceDialog$ChromaticityPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlQuality", "Lsun/print/ServiceDialog$QualityPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlJobAttributes", "Lsun/print/ServiceDialog$JobAttributesPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlSides", "Lsun/print/ServiceDialog$SidesPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$ChromaticityPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.ChromaticityPanel pnlChromaticity_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.ChromaticityPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$QualityPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.QualityPanel pnlQuality_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.QualityPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$JobAttributesPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.JobAttributesPanel pnlJobAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.JobAttributesPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$SidesPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.SidesPanel pnlSides_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.SidesPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AppearancePanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public AppearancePanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$AppearancePanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$ValidatingFileChooser;", "private static")]
	public partial class ValidatingFileChooser
		: Dova.JDK.javax.swing.JFileChooser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ValidatingFileChooser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$ValidatingFileChooser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "approveSelection", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ValidatingFileChooser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ValidatingFileChooser() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$ValidatingFileChooser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void approveSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private static")]
	public partial class IconRadioButton
		: Dova.JDK.javax.swing.JPanel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconRadioButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$IconRadioButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rb", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lbl", "Ljavax/swing/JLabel;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZLjavax/swing/ButtonGroup;Ljava/awt/event/ActionListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addActionListener", "(Ljava/awt/event/ActionListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelected", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameAs", "(Ljava/lang/Object;)Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rb_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lbl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconRadioButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ZLjavax/swing/ButtonGroup;Ljava/awt/event/ActionListener;)V", "public")]
		public IconRadioButton(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, bool arg2, Dova.JDK.javax.swing.ButtonGroup arg3, Dova.JDK.java.awt.@event.ActionListener arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$IconRadioButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public")]
		public void addActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setEnabled(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSelected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setSelected(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool isSameAs(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$JobAttributesPanel;", "private")]
	public partial class JobAttributesPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.javax.swing.@event.ChangeListener
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JobAttributesPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$JobAttributesPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblPriority", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblJobName", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblUserName", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spinPriority", "Ljavax/swing/JSpinner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snModel", "Ljavax/swing/SpinnerNumberModel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbJobSheets", "Ljavax/swing/JCheckBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tfJobName", "Ljavax/swing/JTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tfUserName", "Ljavax/swing/JTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblPriority_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblJobName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblUserName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JSpinner;", "private")]
		public Dova.JDK.javax.swing.JSpinner spinPriority_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSpinner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/SpinnerNumberModel;", "private")]
		public Dova.JDK.javax.swing.SpinnerNumberModel snModel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SpinnerNumberModel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JCheckBox;", "private")]
		public Dova.JDK.javax.swing.JCheckBox cbJobSheets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JCheckBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTextField;", "private")]
		public Dova.JDK.javax.swing.JTextField tfJobName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTextField;", "private")]
		public Dova.JDK.javax.swing.JTextField tfUserName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JobAttributesPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public JobAttributesPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$JobAttributesPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$SidesPanel;", "private")]
	public partial class SidesPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SidesPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$SidesPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbOneSide", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbTumble", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbDuplex", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbOneSide_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbTumble_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbDuplex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SidesPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public SidesPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$SidesPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$QualityPanel;", "private")]
	public partial class QualityPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static QualityPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$QualityPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbDraft", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbNormal", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbHigh", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbDraft_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbNormal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbHigh_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public QualityPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public QualityPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$QualityPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$ChromaticityPanel;", "private")]
	public partial class ChromaticityPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChromaticityPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$ChromaticityPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbMonochrome", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbColor", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbMonochrome_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbColor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChromaticityPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public ChromaticityPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$ChromaticityPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$OrientationPanel;", "private")]
	public partial class OrientationPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OrientationPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$OrientationPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbPortrait", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbLandscape", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbRevPortrait", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbRevLandscape", "Lsun/print/ServiceDialog$IconRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlMargins", "Lsun/print/ServiceDialog$MarginsPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addOrientationListener", "(Lsun/print/ServiceDialog$MarginsPanel;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbPortrait_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbLandscape_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbRevPortrait_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$IconRadioButton;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.IconRadioButton rbRevLandscape_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.IconRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$MarginsPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.MarginsPanel pnlMargins_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.MarginsPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OrientationPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public OrientationPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$OrientationPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog$MarginsPanel;)V", "")]
		public void addOrientationListener(Dova.JDK.sun.print.ServiceDialog.MarginsPanel arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$MediaPanel;", "private")]
	public partial class MediaPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ItemListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MediaPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$MediaPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblSize", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblSource", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbSize", "Ljavax/swing/JComboBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbSource", "Ljavax/swing/JComboBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sizes", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sources", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pnlMargins", "Lsun/print/ServiceDialog$MarginsPanel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMediaListener", "(Lsun/print/ServiceDialog$MarginsPanel;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMediaName", "(Ljava/lang/String;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblSource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox;", "private")]
		public Dova.JDK.javax.swing.JComboBox cbSize_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox;", "private")]
		public Dova.JDK.javax.swing.JComboBox cbSource_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "private")]
		public Dova.JDK.java.util.Vector sizes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "private")]
		public Dova.JDK.java.util.Vector sources_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog$MarginsPanel;", "private")]
		public Dova.JDK.sun.print.ServiceDialog.MarginsPanel pnlMargins_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog.MarginsPanel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MediaPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public MediaPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$MediaPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "public")]
		public void itemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog$MarginsPanel;)V", "public")]
		public void addMediaListener(Dova.JDK.sun.print.ServiceDialog.MarginsPanel arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getMediaName(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$MarginsPanel;", "private")]
	public partial class MarginsPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MarginsPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$MarginsPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leftMargin", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rightMargin", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "topMargin", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bottomMargin", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblLeft", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblRight", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblTop", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblBottom", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "units", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lmVal", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmVal", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tmVal", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bmVal", "F"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lmObj", "Ljava/lang/Float;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rmObj", "Ljava/lang/Float;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tmObj", "Ljava/lang/Float;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bmObj", "Ljava/lang/Float;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateMargins", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validateMargins", "(FFFF)Ljavax/print/attribute/standard/MediaPrintableArea;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField leftMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField rightMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField topMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField bottomMargin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblLeft_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblRight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblTop_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblBottom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int units_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float lmVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float rmVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float tmVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[12], value);
			}
		}

		[JniSignatureAttribute("F", "private")]
		public float bmVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[13], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Float;", "private")]
		public Dova.JDK.java.lang.Float lmObj_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Float>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Float;", "private")]
		public Dova.JDK.java.lang.Float rmObj_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Float>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Float;", "private")]
		public Dova.JDK.java.lang.Float tmObj_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Float>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Float;", "private")]
		public Dova.JDK.java.lang.Float bmObj_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Float>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MarginsPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public MarginsPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$MarginsPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void updateMargins(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(FFFF)Ljavax/print/attribute/standard/MediaPrintableArea;", "private")]
		public Dova.JDK.javax.print.attribute.standard.MediaPrintableArea validateMargins(float arg0, float arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.MediaPrintableArea>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$CopiesPanel;", "private")]
	public partial class CopiesPanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.javax.swing.@event.ChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CopiesPanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$CopiesPanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "snModel", "Ljavax/swing/SpinnerNumberModel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spinCopies", "Ljavax/swing/JSpinner;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblCopies", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbCollate", "Ljavax/swing/JCheckBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scSupported", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCollateCB", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/SpinnerNumberModel;", "private")]
		public Dova.JDK.javax.swing.SpinnerNumberModel snModel_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SpinnerNumberModel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JSpinner;", "private")]
		public Dova.JDK.javax.swing.JSpinner spinCopies_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JSpinner>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblCopies_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JCheckBox;", "private")]
		public Dova.JDK.javax.swing.JCheckBox cbCollate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JCheckBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool scSupported_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CopiesPanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public CopiesPanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$CopiesPanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void updateCollateCB()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$PrintRangePanel;", "private")]
	public partial class PrintRangePanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintRangePanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$PrintRangePanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prAll", "Ljavax/print/attribute/standard/PageRanges;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbAll", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbPages", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rbSelect", "Ljavax/swing/JRadioButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tfRangeFrom", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tfRangeTo", "Ljavax/swing/JFormattedTextField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblRangeTo", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prSupported", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prPgRngSupported", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setupRangeWidgets", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateRangeAttribute", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/print/attribute/standard/PageRanges;", "private final")]
		public Dova.JDK.javax.print.attribute.standard.PageRanges prAll_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.print.attribute.standard.PageRanges>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbAll_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbPages_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JRadioButton;", "private")]
		public Dova.JDK.javax.swing.JRadioButton rbSelect_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JRadioButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField tfRangeFrom_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JFormattedTextField;", "private")]
		public Dova.JDK.javax.swing.JFormattedTextField tfRangeTo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFormattedTextField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblRangeTo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool prSupported_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool prPgRngSupported_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintRangePanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public PrintRangePanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$PrintRangePanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void setupRangeWidgets()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void updateRangeAttribute()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}

	[JniSignatureAttribute("Lsun/print/ServiceDialog$PrintServicePanel;", "private")]
	public partial class PrintServicePanel
		: Dova.JDK.javax.swing.JPanel
		, Dova.JDK.java.awt.@event.ActionListener
		, Dova.JDK.java.awt.@event.ItemListener
		, Dova.JDK.javax.swing.@event.PopupMenuListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintServicePanel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/print/ServiceDialog$PrintServicePanel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "strTitle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printToFilePermission", "Ljava/io/FilePermission;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "btnProperties", "Ljavax/swing/JButton;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbPrintToFile", "Ljavax/swing/JCheckBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cbName", "Ljavax/swing/JComboBox;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblType", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblStatus", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lblInfo", "Ljavax/swing/JLabel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uiFactory", "Ljavax/print/ServiceUIFactory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changedService", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filePermission", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/print/ServiceDialog;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/print/ServiceDialog;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInfo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeVisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeInvisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuCanceled", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPrintToFileSelected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addLabel", "(Ljava/lang/String;Ljava/awt/GridBagLayout;Ljava/awt/GridBagConstraints;)Ljavax/swing/JLabel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allowedToPrintToFile", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "throwPrintToFile", "()V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String strTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/io/FilePermission;", "private")]
		public Dova.JDK.java.io.FilePermission printToFilePermission_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.io.FilePermission>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
		public Dova.JDK.javax.swing.JButton btnProperties_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JCheckBox;", "private")]
		public Dova.JDK.javax.swing.JCheckBox cbPrintToFile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JCheckBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox;", "private")]
		public Dova.JDK.javax.swing.JComboBox cbName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblStatus_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel lblInfo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/print/ServiceUIFactory;", "private")]
		public Dova.JDK.javax.print.ServiceUIFactory uiFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.print.ServiceUIFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool changedService_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool filePermission_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
			}
		}

		[JniSignatureAttribute("Lsun/print/ServiceDialog;", "final")]
		public Dova.JDK.sun.print.ServiceDialog this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.print.ServiceDialog>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintServicePanel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/print/ServiceDialog;)V", "public")]
		public PrintServicePanel(Dova.JDK.sun.print.ServiceDialog arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/print/ServiceDialog$PrintServicePanel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateInfo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuWillBecomeVisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuWillBecomeInvisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuCanceled(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "public")]
		public void itemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPrintToFileSelected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/GridBagLayout;Ljava/awt/GridBagConstraints;)Ljavax/swing/JLabel;", "private")]
		public Dova.JDK.javax.swing.JLabel addLabel(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.GridBagLayout arg1, Dova.JDK.java.awt.GridBagConstraints arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JLabel>(ret);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool allowedToPrintToFile()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void throwPrintToFile()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}
	}
}
