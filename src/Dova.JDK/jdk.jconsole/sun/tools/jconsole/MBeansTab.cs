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

[JniSignatureAttribute("Lsun/tools/jconsole/MBeansTab;", "public")]
public partial class MBeansTab
	: Dova.JDK.sun.tools.jconsole.Tab
	, Dova.JDK.javax.management.NotificationListener
	, Dova.JDK.java.beans.PropertyChangeListener
	, Dova.JDK.javax.swing.@event.TreeSelectionListener
	, Dova.JDK.javax.swing.@event.TreeWillExpandListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MBeansTab()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/MBeansTab;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lsun/tools/jconsole/inspector/XTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sheet", "Lsun/tools/jconsole/inspector/XSheet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viewer", "Lsun/tools/jconsole/inspector/XDataViewer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ml", "Ljava/awt/event/MouseListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/VMPanel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "()Lsun/tools/jconsole/inspector/XTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSnapshotMBeanServerConnection", "()Lsun/tools/jconsole/ProxyClient$SnapshotMBeanServerConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getTabName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpdateInterval", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Ljavax/management/Notification;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanServerConnection", "()Ljavax/management/MBeanServerConnection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setupTab", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildMBeanServerView", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDataViewer", "()Lsun/tools/jconsole/inspector/XDataViewer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSheet", "()Lsun/tools/jconsole/inspector/XSheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeWillExpand", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeWillCollapse", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XTree;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XTree tree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XSheet;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XSheet sheet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XSheet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XDataViewer;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XDataViewer viewer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XDataViewer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/event/MouseListener;", "private")]
	public Dova.JDK.java.awt.@event.MouseListener ml_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MBeansTab(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/VMPanel;)V", "public")]
	public MBeansTab(Dova.JDK.sun.tools.jconsole.VMPanel arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/tools/jconsole/MBeansTab;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void update()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("()Lsun/tools/jconsole/inspector/XTree;", "public")]
	public Dova.JDK.sun.tools.jconsole.inspector.XTree getTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XTree>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()Lsun/tools/jconsole/ProxyClient$SnapshotMBeanServerConnection;", "public")]
	public Dova.JDK.sun.tools.jconsole.ProxyClient.SnapshotMBeanServerConnection getSnapshotMBeanServerConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.ProxyClient.SnapshotMBeanServerConnection>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getTabName()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getUpdateInterval()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;Ljava/lang/Object;)V", "public")]
	public void handleNotification(Dova.JDK.javax.management.Notification arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServerConnection;", "public")]
	public Dova.JDK.javax.management.MBeanServerConnection getMBeanServerConnection()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerConnection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "public")]
	public void valueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void setupTab()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()V", "private")]
	public void buildMBeanServerView()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()Lsun/tools/jconsole/inspector/XDataViewer;", "public")]
	public Dova.JDK.sun.tools.jconsole.inspector.XDataViewer getDataViewer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XDataViewer>(ret);
	}

	[JniSignatureAttribute("()Lsun/tools/jconsole/inspector/XSheet;", "public")]
	public Dova.JDK.sun.tools.jconsole.inspector.XSheet getSheet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XSheet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
	public void treeWillExpand(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
	public void treeWillCollapse(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}
}
