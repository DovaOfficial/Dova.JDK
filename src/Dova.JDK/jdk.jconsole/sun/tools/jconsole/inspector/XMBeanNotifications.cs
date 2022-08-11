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

namespace Dova.JDK.sun.tools.jconsole.inspector;

[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications;", "public")]
public partial class XMBeanNotifications
	: Dova.JDK.javax.swing.JTable
	, Dova.JDK.javax.management.NotificationListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMBeanNotifications()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "columnNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listeners", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subscribed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currentListener", "Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOTIFICATION_RECEIVED_EVENT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notificationListenersList", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "enabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "normalFont", "Ljava/awt/Font;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "boldFont", "Ljava/awt/Font;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowMinHeight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userDataEditor", "Ljavax/swing/table/TableCellEditor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mouseListener", "Lsun/tools/jconsole/inspector/XMBeanNotifications$NotifMouseListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeFormater", "Ljava/text/SimpleDateFormat;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "editor", "Ljavax/swing/table/TableCellEditor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregister", "(Ljavax/management/ObjectName;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotificationsListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isListenerRegistered", "(Lsun/tools/jconsole/inspector/XMBean;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceivedNotifications", "(Lsun/tools/jconsole/inspector/XMBean;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearCurrentNotifications", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyTable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disableNotifications", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "registerListener", "(Ljavax/swing/tree/DefaultMutableTreeNode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregisterListener", "(Ljavax/swing/tree/DefaultMutableTreeNode;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateModel", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserDataCell", "(II)Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCell;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotificationsListener", "(Ljavax/management/NotificationListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireNotificationReceived", "(Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;Lsun/tools/jconsole/inspector/XMBean;Ljavax/swing/tree/DefaultMutableTreeNode;[Ljava/lang/Object;J)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUserDataCell", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadNotifications", "(Lsun/tools/jconsole/inspector/XMBean;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTableEditable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnEditors", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellRenderer", "(II)Ljavax/swing/table/TableCellRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareRenderer", "(Ljavax/swing/table/TableCellRenderer;II)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopCellEditing", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelCellEditing", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Ljavax/management/Notification;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValueAt", "(Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCellEditable", "(II)Z"));
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> columnNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private")]
	public Dova.JDK.java.util.HashMap listeners_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool subscribed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.XMBeanNotificationsListener currentListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.XMBeanNotificationsListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String NOTIFICATION_RECEIVED_EVENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List notificationListenersList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool enabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "private")]
	public Dova.JDK.java.awt.Font normalFont_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Font;", "private")]
	public Dova.JDK.java.awt.Font boldFont_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int rowMinHeight_Property
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

	[JniSignatureAttribute("Ljavax/swing/table/TableCellEditor;", "private")]
	public Dova.JDK.javax.swing.table.TableCellEditor userDataEditor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$NotifMouseListener;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.NotifMouseListener mouseListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.NotifMouseListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/SimpleDateFormat;", "private")]
	public Dova.JDK.java.text.SimpleDateFormat timeFormater_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.SimpleDateFormat>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/TableCellEditor;", "private static")]
	public static Dova.JDK.javax.swing.table.TableCellEditor editor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMBeanNotifications(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMBeanNotifications() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Z", "private synchronized")]
	public bool unregister(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public")]
	public void addNotificationsListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBean;)Z", "public synchronized")]
	public bool isListenerRegistered(Dova.JDK.sun.tools.jconsole.inspector.XMBean arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBean;)J", "public")]
	public long getReceivedNotifications(Dova.JDK.sun.tools.jconsole.inspector.XMBean arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public synchronized")]
	public bool clearCurrentNotifications()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void emptyTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("()V", "public synchronized")]
	public void disableNotifications()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/DefaultMutableTreeNode;)V", "public synchronized")]
	public void registerListener(Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/DefaultMutableTreeNode;)Z", "public synchronized")]
	public bool unregisterListener(Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void updateModel(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(II)Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCell;", "private")]
	public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.UserDataCell getUserDataCell(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.UserDataCell>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/NotificationListener;)V", "public")]
	public void removeNotificationsListener(Dova.JDK.javax.management.NotificationListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;Lsun/tools/jconsole/inspector/XMBean;Ljavax/swing/tree/DefaultMutableTreeNode;[Ljava/lang/Object;J)V", "")]
	public void fireNotificationReceived(Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.XMBeanNotificationsListener arg0, Dova.JDK.sun.tools.jconsole.inspector.XMBean arg1, Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg2, JavaArray<Dova.JDK.java.lang.Object> arg3, long arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(II)V", "synchronized")]
	public void updateUserDataCell(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBean;)V", "public synchronized")]
	public void loadNotifications(Dova.JDK.sun.tools.jconsole.inspector.XMBean arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTableEditable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void setColumnEditors()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17]);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/table/TableCellRenderer;", "public synchronized")]
	public Dova.JDK.javax.swing.table.TableCellRenderer getCellRenderer(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellRenderer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableCellRenderer;II)Ljava/awt/Component;", "public synchronized")]
	public Dova.JDK.java.awt.Component prepareRenderer(Dova.JDK.javax.swing.table.TableCellRenderer arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void stopCellEditing()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void cancelCellEditing()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("(Ljavax/management/Notification;Ljava/lang/Object;)V", "public synchronized")]
	public void handleNotification(Dova.JDK.javax.management.Notification arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)V", "public")]
	public void setValueAt(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool isCellEditable(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellEditor;", "")]
	public partial class UserDataCellEditor
		: Dova.JDK.sun.tools.jconsole.inspector.XTextFieldEditor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UserDataCellEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/tools/jconsole/inspector/XMBeanNotifications;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/inspector/XMBeanNotifications;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopCellEditing", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellEditorComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications;", "final")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UserDataCellEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBeanNotifications;)V", "")]
		public UserDataCellEditor(Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool stopCellEditing()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellEditorComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$NotifMouseListener;", "")]
	public partial class NotifMouseListener
		: Dova.JDK.java.awt.@event.MouseAdapter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NotifMouseListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications$NotifMouseListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/tools/jconsole/inspector/XMBeanNotifications;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/inspector/XMBeanNotifications;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mousePressed", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications;", "final")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NotifMouseListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBeanNotifications;)V", "")]
		public NotifMouseListener(Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications$NotifMouseListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mousePressed(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCell;", "static")]
	public partial class UserDataCell
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UserDataCell()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCell;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minRenderer", "Ljavax/swing/table/TableCellRenderer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxRenderer", "Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellRenderer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minHeight", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimized", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "init", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "userData", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "(Ljavax/swing/table/TableCellRenderer;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderer", "()Ljavax/swing/table/TableCellRenderer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "switchState", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMaximized", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInited", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minimize", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "maximize", "()V"));
		}

		[JniSignatureAttribute("Ljavax/swing/table/TableCellRenderer;", "")]
		public Dova.JDK.javax.swing.table.TableCellRenderer minRenderer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellRenderer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellRenderer;", "")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.UserDataCellRenderer maxRenderer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications.UserDataCellRenderer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int minHeight_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool minimized_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool init_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object userData_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UserDataCell(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/awt/Component;)V", "")]
		public UserDataCell(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.awt.Component arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCell;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/table/TableCellRenderer;I)V", "")]
		public void init(Dova.JDK.javax.swing.table.TableCellRenderer arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljavax/swing/table/TableCellRenderer;", "")]
		public Dova.JDK.javax.swing.table.TableCellRenderer getRenderer()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellRenderer>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int getHeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void switchState()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isMaximized()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool isInited()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void minimize()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()V", "")]
		public void maximize()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;", "")]
	public partial class XMBeanNotificationsListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.management.NotificationListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XMBeanNotificationsListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xmbean", "Lsun/tools/jconsole/inspector/XMBean;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "node", "Ljavax/swing/tree/DefaultMutableTreeNode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "received", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "notifications", "Lsun/tools/jconsole/inspector/XMBeanNotifications;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unregistered", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "data", "Ljava/util/ArrayList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/tools/jconsole/inspector/XMBeanNotifications;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/tools/jconsole/inspector/XMBeanNotifications;Lsun/tools/jconsole/inspector/XMBeanNotifications;Lsun/tools/jconsole/inspector/XMBean;Ljavax/swing/tree/DefaultMutableTreeNode;[Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clear", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRegistered", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljavax/swing/tree/DefaultMutableTreeNode;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unregister", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceivedNotifications", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getData", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleNotification", "(Ljavax/management/Notification;Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBean;", "private")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBean xmbean_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBean>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/tree/DefaultMutableTreeNode;", "private")]
		public Dova.JDK.javax.swing.tree.DefaultMutableTreeNode node_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.DefaultMutableTreeNode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private volatile")]
		public long received_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications;", "private")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications notifications_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool unregistered_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/ArrayList;", "private")]
		public Dova.JDK.java.util.ArrayList data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications;", "final")]
		public Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XMBeanNotificationsListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBeanNotifications;Lsun/tools/jconsole/inspector/XMBeanNotifications;Lsun/tools/jconsole/inspector/XMBean;Ljavax/swing/tree/DefaultMutableTreeNode;[Ljava/lang/String;)V", "public")]
		public XMBeanNotificationsListener(Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications arg0, Dova.JDK.sun.tools.jconsole.inspector.XMBeanNotifications arg1, Dova.JDK.sun.tools.jconsole.inspector.XMBean arg2, Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg3, JavaArray<Dova.JDK.java.lang.String> arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications$XMBeanNotificationsListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public synchronized")]
		public void clear()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Z", "public synchronized")]
		public bool isRegistered()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/tree/DefaultMutableTreeNode;)V", "public synchronized")]
		public void register(Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "public synchronized")]
		public void unregister()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("()J", "public synchronized")]
		public long getReceivedNotifications()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public synchronized")]
		public Dova.JDK.java.util.List getData()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljavax/management/Notification;Ljava/lang/Object;)V", "public synchronized")]
		public void handleNotification(Dova.JDK.javax.management.Notification arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellRenderer;", "static")]
	public partial class UserDataCellRenderer
		: Dova.JDK.javax.swing.table.DefaultTableCellRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UserDataCellRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comp", "Ljava/awt/Component;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellRendererComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComponent", "()Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("Ljava/awt/Component;", "")]
		public Dova.JDK.java.awt.Component comp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public UserDataCellRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "")]
		public UserDataCellRenderer(Dova.JDK.java.awt.Component arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanNotifications$UserDataCellRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellRendererComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getComponent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}
}
