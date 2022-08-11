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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/JComboBox;", "public")]
public partial class JComboBox
	: Dova.JDK.javax.swing.JComponent
	, Dova.JDK.java.awt.ItemSelectable
	, Dova.JDK.javax.swing.@event.ListDataListener
	, Dova.JDK.java.awt.@event.ActionListener
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JComboBox()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataModel", "Ljavax/swing/ComboBoxModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "renderer", "Ljavax/swing/ListCellRenderer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editor", "Ljavax/swing/ComboBoxEditor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maximumRowCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isEditable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keySelectionManager", "Ljavax/swing/JComboBox$KeySelectionManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionCommand", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightWeightPopupEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectedItemReminder", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prototypeDisplayValue", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firingActionEvent", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectingItem", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateInProgress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "action", "Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "actionPropertyChangeListener", "Ljava/beans/PropertyChangeListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Vector;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/ComboBoxModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "init", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentsChanged", "(Ljavax/swing/event/ListDataEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intervalAdded", "(Ljavax/swing/event/ListDataEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intervalRemoved", "(Ljavax/swing/event/ListDataEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAction", "()Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPropertyChanged", "(Ljavax/swing/Action;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setActionCommand", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeActionListener", "(Ljava/awt/event/ActionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionListeners", "()[Ljava/awt/event/ActionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedItem", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedIndex", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedItem", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyBinding", "(Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;IZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_0", "()Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_1", "()Ljavax/swing/plaf/ComboBoxUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUI", "(Ljavax/swing/plaf/ComboBoxUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEditable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installAncestorListener", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRenderer", "()Ljavax/swing/ListCellRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditor", "()Ljavax/swing/ComboBoxEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectedItemChanged", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireActionEvent", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMutableComboBoxModel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPopupVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPopupVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultKeySelectionManager", "()Ljavax/swing/JComboBox$KeySelectionManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hidePopup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMaximumRowCount", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRenderer", "(Ljavax/swing/ListCellRenderer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditor", "(Ljavax/swing/ComboBoxEditor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrototypeDisplayValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrototypeDisplayValue", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertItemAt", "(Ljava/lang/Object;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeItemAt", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectWithKeyChar", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureEditor", "(Ljavax/swing/ComboBoxEditor;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setKeySelectionManager", "(Ljavax/swing/JComboBox$KeySelectionManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKeySelectionManager", "()Ljavax/swing/JComboBox$KeySelectionManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemAt", "(I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "showPopup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePopupMenuCanceled", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePopupMenuWillBecomeVisible", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePopupMenuWillBecomeInvisible", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLightWeightPopupEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectedIndex", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLightWeightPopupEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPopupMenuListener", "(Ljavax/swing/event/PopupMenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePopupMenuListener", "(Ljavax/swing/event/PopupMenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPopupMenuListeners", "()[Ljavax/swing/event/PopupMenuListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModel", "()Ljavax/swing/ComboBoxModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addItemListener", "(Ljava/awt/event/ItemListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeItemListener", "(Ljava/awt/event/ItemListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedObjects", "()[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configurePropertiesFromAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isListener", "(Ljava/lang/Class;Ljava/awt/event/ActionListener;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createActionPropertyChangeListener", "(Ljavax/swing/Action;)Ljava/beans/PropertyChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setActionCommandFromAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModel", "(Ljavax/swing/ComboBoxModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireItemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getItemListeners", "()[Ljava/awt/event/ItemListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addItem", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeItem", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAllItems", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyEvent", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionCommand", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/ComboBoxModel;", "protected")]
	public Dova.JDK.javax.swing.ComboBoxModel dataModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ComboBoxModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/ListCellRenderer;", "protected")]
	public Dova.JDK.javax.swing.ListCellRenderer renderer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListCellRenderer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/ComboBoxEditor;", "protected")]
	public Dova.JDK.javax.swing.ComboBoxEditor editor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ComboBoxEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int maximumRowCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool isEditable_Property
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

	[JniSignatureAttribute("Ljavax/swing/JComboBox$KeySelectionManager;", "protected")]
	public Dova.JDK.javax.swing.JComboBox.KeySelectionManager keySelectionManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.KeySelectionManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String actionCommand_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool lightWeightPopupEnabled_Property
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

	[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
	public Dova.JDK.java.lang.Object selectedItemReminder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object prototypeDisplayValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool firingActionEvent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool selectingItem_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool updateInProgress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/Action;", "private")]
	public Dova.JDK.javax.swing.Action action_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private")]
	public Dova.JDK.java.beans.PropertyChangeListener actionPropertyChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JComboBox(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JComboBox() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Vector;)V", "public")]
	public JComboBox(Dova.JDK.java.util.Vector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public JComboBox(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/ComboBoxModel;)V", "public")]
	public JComboBox(Dova.JDK.javax.swing.ComboBoxModel arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private")]
	public void init()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getItemCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
	public void contentsChanged(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
	public void intervalAdded(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
	public void intervalRemoved(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/Action;", "public")]
	public Dova.JDK.javax.swing.Action getAction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;Ljava/lang/String;)V", "protected")]
	public void actionPropertyChanged(Dova.JDK.javax.swing.Action arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
	public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public")]
	public void addActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setActionCommand(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionListener;)V", "public")]
	public void removeActionListener(Dova.JDK.java.awt.@event.ActionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/event/ActionListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.@event.ActionListener> getActionListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.ActionListener>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getSelectedItem()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedIndex()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void setSelectedItem(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;IZ)Z", "protected")]
	public bool processKeyBinding(Dova.JDK.javax.swing.KeyStroke arg0, Dova.JDK.java.awt.@event.KeyEvent arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComponentUI;", "public volatile")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComboBoxUI;", "public")]
	public Dova.JDK.javax.swing.plaf.ComboBoxUI getUI_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComboBoxUI>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/ComboBoxUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.ComboBoxUI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEditable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installAncestorListener()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
	}

	[JniSignatureAttribute("()Ljavax/swing/ListCellRenderer;", "public")]
	public Dova.JDK.javax.swing.ListCellRenderer getRenderer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListCellRenderer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/ComboBoxEditor;", "public")]
	public Dova.JDK.javax.swing.ComboBoxEditor getEditor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ComboBoxEditor>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void selectedItemChanged()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void fireActionEvent()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28]);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkMutableComboBoxModel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setPopupVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPopupVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/JComboBox$KeySelectionManager;", "protected")]
	public Dova.JDK.javax.swing.JComboBox.KeySelectionManager createDefaultKeySelectionManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.KeySelectionManager>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void hidePopup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEditable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setMaximumRowCount(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaximumRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/ListCellRenderer;)V", "public")]
	public void setRenderer(Dova.JDK.javax.swing.ListCellRenderer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/ComboBoxEditor;)V", "public")]
	public void setEditor(Dova.JDK.javax.swing.ComboBoxEditor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getPrototypeDisplayValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void setPrototypeDisplayValue(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;I)V", "public")]
	public void insertItemAt(Dova.JDK.java.lang.Object arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void removeItemAt(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(C)Z", "public")]
	public bool selectWithKeyChar(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/ComboBoxEditor;Ljava/lang/Object;)V", "public")]
	public void configureEditor(Dova.JDK.javax.swing.ComboBoxEditor arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComboBox$KeySelectionManager;)V", "public")]
	public void setKeySelectionManager(Dova.JDK.javax.swing.JComboBox.KeySelectionManager arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/JComboBox$KeySelectionManager;", "public")]
	public Dova.JDK.javax.swing.JComboBox.KeySelectionManager getKeySelectionManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.KeySelectionManager>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getItemAt(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "public")]
	public void setAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void showPopup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void firePopupMenuCanceled()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void firePopupMenuWillBecomeVisible()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void firePopupMenuWillBecomeInvisible()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52]);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLightWeightPopupEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setSelectedIndex(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setLightWeightPopupEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuListener;)V", "public")]
	public void addPopupMenuListener(Dova.JDK.javax.swing.@event.PopupMenuListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuListener;)V", "public")]
	public void removePopupMenuListener(Dova.JDK.javax.swing.@event.PopupMenuListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/PopupMenuListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.PopupMenuListener> getPopupMenuListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.PopupMenuListener>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/ComboBoxModel;", "public")]
	public Dova.JDK.javax.swing.ComboBoxModel getModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ComboBoxModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;)V", "public")]
	public void addItemListener(Dova.JDK.java.awt.@event.ItemListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemListener;)V", "public")]
	public void removeItemListener(Dova.JDK.java.awt.@event.ItemListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
	}

	[JniSignatureAttribute("()[Ljava/lang/Object;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getSelectedObjects()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "protected")]
	public void configurePropertiesFromAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/awt/event/ActionListener;)Z", "private")]
	public bool isListener(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.awt.@event.ActionListener arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)Ljava/beans/PropertyChangeListener;", "protected")]
	public Dova.JDK.java.beans.PropertyChangeListener createActionPropertyChangeListener(Dova.JDK.javax.swing.Action arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "private")]
	public void setActionCommandFromAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/ComboBoxModel;)V", "public")]
	public void setModel(Dova.JDK.javax.swing.ComboBoxModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "protected")]
	public void fireItemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("()[Ljava/awt/event/ItemListener;", "public")]
	public JavaArray<Dova.JDK.java.awt.@event.ItemListener> getItemListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.awt.@event.ItemListener>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void addItem(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
	public void removeItem(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeAllItems()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72]);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "public")]
	public void processKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getActionCommand()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox$KeySelectionManager;", "public abstract static interface")]
	public partial interface KeySelectionManager
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static KeySelectionManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$KeySelectionManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectionForKey", "(CLjavax/swing/ComboBoxModel;)I"));
		}

		[JniSignatureAttribute("(CLjavax/swing/ComboBoxModel;)I", "public abstract")]
		int selectionForKey(char arg0, Dova.JDK.javax.swing.ComboBoxModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox$ComboBoxActionPropertyChangeListener;", "private static")]
	public partial class ComboBoxActionPropertyChangeListener
		: Dova.JDK.javax.swing.ActionPropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComboBoxActionPropertyChangeListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$ComboBoxActionPropertyChangeListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox;Ljavax/swing/Action;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPropertyChanged", "(Ljavax/swing/JComboBox;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "actionPropertyChanged", "(Ljavax/swing/JComponent;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComboBoxActionPropertyChangeListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JComboBox;Ljavax/swing/Action;)V", "")]
		public ComboBoxActionPropertyChangeListener(Dova.JDK.javax.swing.JComboBox arg0, Dova.JDK.javax.swing.Action arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$ComboBoxActionPropertyChangeListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JComboBox;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V", "protected")]
		public void actionPropertyChanged(Dova.JDK.javax.swing.JComboBox arg0, Dova.JDK.javax.swing.Action arg1, Dova.JDK.java.beans.PropertyChangeEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;Ljavax/swing/Action;Ljava/beans/PropertyChangeEvent;)V", "protected volatile")]
		public void actionPropertyChanged(Dova.JDK.javax.swing.JComponent arg0, Dova.JDK.javax.swing.Action arg1, Dova.JDK.java.beans.PropertyChangeEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox$DefaultKeySelectionManager;", "static")]
	public partial class DefaultKeySelectionManager
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.JComboBox.KeySelectionManager
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultKeySelectionManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$DefaultKeySelectionManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectionForKey", "(CLjavax/swing/ComboBoxModel;)I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultKeySelectionManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DefaultKeySelectionManager() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$DefaultKeySelectionManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(CLjavax/swing/ComboBoxModel;)I", "public")]
		public int selectionForKey(char arg0, Dova.JDK.javax.swing.ComboBoxModel arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "protected")]
	public partial class AccessibleJComboBox
		: Dova.JDK.javax.swing.JComponent.AccessibleJComponent
		, Dova.JDK.javax.accessibility.AccessibleAction
		, Dova.JDK.javax.accessibility.AccessibleSelection
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJComboBox()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popupList", "Ljavax/swing/JList;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousSelectedAccessible", "Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editorAccessibleContext", "Ljavax/swing/JComboBox$AccessibleJComboBox$EditorAccessibleContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JComboBox;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAction", "()Ljavax/accessibility/AccessibleAction;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionDescription", "(I)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAccessibleAction", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelectionCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectAllAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditorNameAndDescription", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleChildSelected", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JList;", "private")]
		public Dova.JDK.javax.swing.JList popupList_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JList>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "private")]
		public Dova.JDK.javax.accessibility.Accessible previousSelectedAccessible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$EditorAccessibleContext;", "private")]
		public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox.EditorAccessibleContext editorAccessibleContext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox.EditorAccessibleContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox;", "final")]
		public Dova.JDK.javax.swing.JComboBox this0_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJComboBox(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JComboBox;)V", "public")]
		public AccessibleJComboBox(Dova.JDK.javax.swing.JComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleAction;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleAction getAccessibleAction()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleAction>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleActionCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAccessibleActionDescription(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool doAccessibleAction(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleSelectionCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void addAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void removeAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clearAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void selectAllAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void setEditorNameAndDescription()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleChildrenCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleSelection(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isAccessibleChildSelected(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$EditorAccessibleContext;", "private")]
		public partial class EditorAccessibleContext
			: Dova.JDK.javax.accessibility.AccessibleContext
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static EditorAccessibleContext()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox$EditorAccessibleContext;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ac", "Ljavax/accessibility/AccessibleContext;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JComboBox$AccessibleJComboBox;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;)V"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleName", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleDescription", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleParent", "(Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAction", "()Ljavax/accessibility/AccessibleAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleText", "()Ljavax/accessibility/AccessibleText;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleEditableText", "()Ljavax/accessibility/AccessibleEditableText;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleValue", "()Ljavax/accessibility/AccessibleValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIcon", "()[Ljavax/accessibility/AccessibleIcon;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRelationSet", "()Ljavax/accessibility/AccessibleRelationSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleTable", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "firePropertyChange", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleParent", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
			}

			[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "private")]
			public Dova.JDK.javax.accessibility.AccessibleContext ac_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "final")]
			public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public EditorAccessibleContext(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;)V", "private")]
			public EditorAccessibleContext(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;Ljavax/accessibility/Accessible;)V", "")]
			public EditorAccessibleContext(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0, Dova.JDK.javax.accessibility.Accessible arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox$EditorAccessibleContext;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
			public Dova.JDK.java.util.Locale getLocale()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleName(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleDescription(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleParent(Dova.JDK.javax.accessibility.Accessible arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleAction;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleAction getAccessibleAction()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleAction>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleText;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleText getAccessibleText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleText>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleEditableText;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleEditableText getAccessibleEditableText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleEditableText>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleValue;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleValue getAccessibleValue()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleValue>(ret);
			}

			[JniSignatureAttribute("()[Ljavax/accessibility/AccessibleIcon;", "public")]
			public JavaArray<Dova.JDK.javax.accessibility.AccessibleIcon> getAccessibleIcon()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.accessibility.AccessibleIcon>>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRelationSet;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRelationSet getAccessibleRelationSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRelationSet>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleTable()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
			public void firePropertyChange(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2);
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleParent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
				return ret;
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPropertyChangeListener;", "private")]
		public partial class AccessibleJComboBoxPropertyChangeListener
			: Dova.JDK.java.lang.Object
			, Dova.JDK.java.beans.PropertyChangeListener
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJComboBoxPropertyChangeListener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPropertyChangeListener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JComboBox$AccessibleJComboBox;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "final")]
			public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJComboBoxPropertyChangeListener(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;)V", "private")]
			public AccessibleJComboBoxPropertyChangeListener(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPropertyChangeListener;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
			public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxListSelectionListener;", "private")]
		public partial class AccessibleJComboBoxListSelectionListener
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.swing.@event.ListSelectionListener
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJComboBoxListSelectionListener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxListSelectionListener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JComboBox$AccessibleJComboBox;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "final")]
			public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJComboBoxListSelectionListener(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;)V", "private")]
			public AccessibleJComboBoxListSelectionListener(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxListSelectionListener;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
			public void valueChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPopupMenuListener;", "private")]
		public partial class AccessibleJComboBoxPopupMenuListener
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.swing.@event.PopupMenuListener
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJComboBoxPopupMenuListener()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPopupMenuListener;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JComboBox$AccessibleJComboBox;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeVisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeInvisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuCanceled", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "final")]
			public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJComboBoxPopupMenuListener(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;)V", "private")]
			public AccessibleJComboBoxPopupMenuListener(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleJComboBoxPopupMenuListener;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
			public void popupMenuWillBecomeVisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
			public void popupMenuWillBecomeInvisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
			public void popupMenuCanceled(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleEditor;", "private")]
		public partial class AccessibleEditor
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.accessibility.Accessible
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleEditor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleEditor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JComboBox$AccessibleJComboBox;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JComboBox$AccessibleJComboBox;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
			}

			[JniSignatureAttribute("Ljavax/swing/JComboBox$AccessibleJComboBox;", "final")]
			public Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleEditor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JComboBox$AccessibleJComboBox;)V", "private")]
			public AccessibleEditor(Dova.JDK.javax.swing.JComboBox.AccessibleJComboBox arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JComboBox$AccessibleJComboBox$AccessibleEditor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}
		}
	}
}
