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

namespace Dova.JDK.sun.tools.jconsole;

[JniSignatureAttribute("Lsun/tools/jconsole/JConsole;", "public")]
public partial class JConsole
	: Dova.JDK.javax.swing.JFrame
	, Dova.JDK.java.awt.@event.ActionListener
	, Dova.JDK.javax.swing.@event.InternalFrameListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JConsole()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/JConsole;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_GTK", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_WIN", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "title", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_URL", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "updateInterval", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pluginPath", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "menuBar", "Ljavax/swing/JMenuBar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hotspotMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "exitMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowMenu", "Lsun/tools/jconsole/JConsole$WindowMenu;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tileMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cascadeMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimizeAllMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restoreAllMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userGuideMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "aboutMI", "Ljavax/swing/JMenuItem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectButton", "Ljavax/swing/JButton;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "desktop", "Ljavax/swing/JDesktopPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "connectDialog", "Lsun/tools/jconsole/ConnectDialog;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "createDialog", "Lsun/tools/jconsole/CreateMBeanDialog;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windows", "Ljava/util/ArrayList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "frameLoc", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "debug", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "pluginService", "Ljava/util/ServiceLoader;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "main", "([Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDebug", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "failed", "(Ljava/lang/Exception;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "errorMessage", "(Ljava/lang/Exception;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidRemoteString", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLocalAttachAvailable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDesktopPane", "()Ljavax/swing/JDesktopPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFrame", "(Lsun/tools/jconsole/VMPanel;)Lsun/tools/jconsole/VMInternalFrame;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showCreateMBeanDialog", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showConnectDialog", "(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tileWindows", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cascadeWindows", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHost", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addHost", "(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVmid", "(Lsun/tools/jconsole/LocalVirtualMachine;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addVmid", "(Lsun/tools/jconsole/LocalVirtualMachine;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeVMInternalFrame", "(Lsun/tools/jconsole/VMInternalFrame;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isProxyClientUsed", "(Lsun/tools/jconsole/ProxyClient;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mainInit", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lsun/tools/jconsole/ProxyClient;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initPluginService", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "pathToURLs", "(Ljava/lang/String;)[Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "initEmptyPlugin", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "fileToURL", "(Ljava/io/File;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "updateLafValues", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInternalFrames", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createMDI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addUrl", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addProxyClient", "(Lsun/tools/jconsole/ProxyClient;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "dbgStackTrace", "(Ljava/lang/Exception;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPlugins", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "usage", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameOpened", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameClosing", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameClosed", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameIconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameDeiconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameActivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameDeactivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
	}

	[JniSignatureAttribute("Z", "static")]
	public static bool IS_GTK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "static")]
	public static bool IS_WIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String title_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ROOT_URL_Property
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

	[JniSignatureAttribute("I", "private static")]
	public static int updateInterval_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String pluginPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuBar;", "private")]
	public Dova.JDK.javax.swing.JMenuBar menuBar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuBar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem hotspotMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem connectMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem exitMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/JConsole$WindowMenu;", "private")]
	public Dova.JDK.sun.tools.jconsole.JConsole.WindowMenu windowMenu_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.JConsole.WindowMenu>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem tileMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem cascadeMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem minimizeAllMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem restoreAllMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem userGuideMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JMenuItem;", "private")]
	public Dova.JDK.javax.swing.JMenuItem aboutMI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JMenuItem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
	public Dova.JDK.javax.swing.JButton connectButton_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JDesktopPane;", "private")]
	public Dova.JDK.javax.swing.JDesktopPane desktop_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JDesktopPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/ConnectDialog;", "private")]
	public Dova.JDK.sun.tools.jconsole.ConnectDialog connectDialog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.ConnectDialog>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/CreateMBeanDialog;", "private")]
	public Dova.JDK.sun.tools.jconsole.CreateMBeanDialog createDialog_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.CreateMBeanDialog>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
	public Dova.JDK.java.util.ArrayList windows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int frameLoc_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[22]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[22], value);
		}
	}

	[JniSignatureAttribute("Z", "static")]
	public static bool debug_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/ServiceLoader;", "private static")]
	public static Dova.JDK.java.util.ServiceLoader pluginService_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JConsole(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public JConsole(bool arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/tools/jconsole/JConsole;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljava/lang/String;)V", "public static")]
	public static void main(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isDebug()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void failed(Dova.JDK.java.lang.Exception arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String errorMessage(Dova.JDK.java.lang.Exception arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool isValidRemoteString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public static")]
	public static bool isLocalAttachAvailable()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/JDesktopPane;", "public")]
	public Dova.JDK.javax.swing.JDesktopPane getDesktopPane()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JDesktopPane>(ret);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/VMPanel;)Lsun/tools/jconsole/VMInternalFrame;", "private")]
	public Dova.JDK.sun.tools.jconsole.VMInternalFrame addFrame(Dova.JDK.sun.tools.jconsole.VMPanel arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.VMInternalFrame>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void showCreateMBeanDialog()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public void showConnectDialog(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.java.lang.String arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()V", "public")]
	public void tileWindows()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void cascadeWindows()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;Z)V", "")]
	public void addHost(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, bool arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Ljava/lang/String;)V", "")]
	public void addHost(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/LocalVirtualMachine;)V", "")]
	public void addVmid(Dova.JDK.sun.tools.jconsole.LocalVirtualMachine arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/LocalVirtualMachine;Z)V", "")]
	public void addVmid(Dova.JDK.sun.tools.jconsole.LocalVirtualMachine arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/VMInternalFrame;)V", "private")]
	public void removeVMInternalFrame(Dova.JDK.sun.tools.jconsole.VMInternalFrame arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/ProxyClient;)Z", "private")]
	public bool isProxyClientUsed(Dova.JDK.sun.tools.jconsole.ProxyClient arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Lsun/tools/jconsole/ProxyClient;ZZ)V", "private static")]
	public static void mainInit(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.sun.tools.jconsole.ProxyClient arg4, bool arg5, bool arg6)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void initPluginService(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Ljava/net/URL;", "private static")]
	public static JavaArray<Dova.JDK.java.net.URL> pathToURLs(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.net.URL>>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void initEmptyPlugin()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Ljava/io/File;)Ljava/net/URL;", "private static")]
	public static Dova.JDK.java.net.URL fileToURL(Dova.JDK.java.io.File arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()V", "static")]
	public static void updateLafValues()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getInternalFrames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void createMDI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Z)V", "")]
	public void addUrl(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/ProxyClient;Z)V", "")]
	public void addProxyClient(Dova.JDK.sun.tools.jconsole.ProxyClient arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Exception;)V", "private static")]
	public static void dbgStackTrace(Dova.JDK.java.lang.Exception arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "static synchronized")]
	public static Dova.JDK.java.util.List getPlugins()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()V", "private static")]
	public static void usage()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30]);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameOpened(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameClosing(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameClosed(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameIconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameDeiconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameActivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
	public void internalFrameDeactivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
	public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/JConsole$FixedJRootPane;", "private static")]
	public partial class FixedJRootPane
		: Dova.JDK.javax.swing.JRootPane
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedJRootPane()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/JConsole$FixedJRootPane;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "revalidate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixedJRootPane(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public FixedJRootPane() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/JConsole$FixedJRootPane;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void revalidate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateUI()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/JConsole$WindowMenu;", "private")]
	public partial class WindowMenu
		: Dova.JDK.javax.swing.JMenu
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WindowMenu()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/JConsole$WindowMenu;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "windowMenuWindows", "[Lsun/tools/jconsole/VMInternalFrame;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "separatorPosition", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viewR", "Ljava/awt/Rectangle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textR", "Ljava/awt/Rectangle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "iconR", "Ljava/awt/Rectangle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/tools/jconsole/JConsole;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/JConsole;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Lsun/tools/jconsole/VMInternalFrame;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "remove", "(Lsun/tools/jconsole/VMInternalFrame;)V"));
		}

		[JniSignatureAttribute("[Lsun/tools/jconsole/VMInternalFrame;", "")]
		public JavaArray<Dova.JDK.sun.tools.jconsole.VMInternalFrame> windowMenuWindows_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.tools.jconsole.VMInternalFrame>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int separatorPosition_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle viewR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle textR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Rectangle;", "")]
		public Dova.JDK.java.awt.Rectangle iconR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/JConsole;", "final")]
		public Dova.JDK.sun.tools.jconsole.JConsole this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.JConsole>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WindowMenu(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/tools/jconsole/JConsole;Ljava/lang/String;)V", "")]
		public WindowMenu(Dova.JDK.sun.tools.jconsole.JConsole arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/JConsole$WindowMenu;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lsun/tools/jconsole/VMInternalFrame;)V", "private")]
		public void add(Dova.JDK.sun.tools.jconsole.VMInternalFrame arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lsun/tools/jconsole/VMInternalFrame;)V", "private")]
		public void remove(Dova.JDK.sun.tools.jconsole.VMInternalFrame arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
