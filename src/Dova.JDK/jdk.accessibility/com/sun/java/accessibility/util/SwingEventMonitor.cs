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

namespace Dova.JDK.com.sun.java.accessibility.util;

[JniSignatureAttribute("Lcom/sun/java/accessibility/util/SwingEventMonitor;", "public")]
public partial class SwingEventMonitor
	: Dova.JDK.com.sun.java.accessibility.util.AWTEventMonitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SwingEventMonitor()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/accessibility/util/SwingEventMonitor;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "listenerList", "Ljavax/swing/event/EventListenerList;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "swingListener", "Lcom/sun/java/accessibility/util/SwingEventMonitor$SwingEventListener;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addCellEditorListener", "(Ljavax/swing/event/CellEditorListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeCellEditorListener", "(Ljavax/swing/event/CellEditorListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addListDataListener", "(Ljavax/swing/event/ListDataListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeListDataListener", "(Ljavax/swing/event/ListDataListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addListSelectionListener", "(Ljavax/swing/event/ListSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeListSelectionListener", "(Ljavax/swing/event/ListSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addMenuListener", "(Ljavax/swing/event/MenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeMenuListener", "(Ljavax/swing/event/MenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addPopupMenuListener", "(Ljavax/swing/event/PopupMenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removePopupMenuListener", "(Ljavax/swing/event/PopupMenuListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTableModelListener", "(Ljavax/swing/event/TableModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTableModelListener", "(Ljavax/swing/event/TableModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTreeExpansionListener", "(Ljavax/swing/event/TreeExpansionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTreeExpansionListener", "(Ljavax/swing/event/TreeExpansionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTreeModelListener", "(Ljavax/swing/event/TreeModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTreeModelListener", "(Ljavax/swing/event/TreeModelListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeUndoableEditListener", "(Ljavax/swing/event/UndoableEditListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addInternalFrameListener", "(Ljavax/swing/event/InternalFrameListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeInternalFrameListener", "(Ljavax/swing/event/InternalFrameListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeDocumentListener", "(Ljavax/swing/event/DocumentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addDocumentListener", "(Ljavax/swing/event/DocumentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addChangeListener", "(Ljavax/swing/event/ChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addCaretListener", "(Ljavax/swing/event/CaretListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeCaretListener", "(Ljavax/swing/event/CaretListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeVetoableChangeListener", "(Ljava/beans/VetoableChangeListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addAncestorListener", "(Ljavax/swing/event/AncestorListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeAncestorListener", "(Ljavax/swing/event/AncestorListener;)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/event/EventListenerList;", "protected static final")]
	public static Dova.JDK.javax.swing.@event.EventListenerList listenerList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.EventListenerList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/java/accessibility/util/SwingEventMonitor$SwingEventListener;", "private static final")]
	public static Dova.JDK.com.sun.java.accessibility.util.SwingEventMonitor.SwingEventListener swingListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.java.accessibility.util.SwingEventMonitor.SwingEventListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SwingEventMonitor(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SwingEventMonitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/SwingEventMonitor;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/swing/event/CellEditorListener;)V", "public static")]
	public static void addCellEditorListener(Dova.JDK.javax.swing.@event.CellEditorListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/CellEditorListener;)V", "public static")]
	public static void removeCellEditorListener(Dova.JDK.javax.swing.@event.CellEditorListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelListener;)V", "public static")]
	public static void addColumnModelListener(Dova.JDK.javax.swing.@event.TableColumnModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelListener;)V", "public static")]
	public static void removeColumnModelListener(Dova.JDK.javax.swing.@event.TableColumnModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListDataListener;)V", "public static")]
	public static void addListDataListener(Dova.JDK.javax.swing.@event.ListDataListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListDataListener;)V", "public static")]
	public static void removeListDataListener(Dova.JDK.javax.swing.@event.ListDataListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionListener;)V", "public static")]
	public static void addListSelectionListener(Dova.JDK.javax.swing.@event.ListSelectionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionListener;)V", "public static")]
	public static void removeListSelectionListener(Dova.JDK.javax.swing.@event.ListSelectionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuListener;)V", "public static")]
	public static void addMenuListener(Dova.JDK.javax.swing.@event.MenuListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/MenuListener;)V", "public static")]
	public static void removeMenuListener(Dova.JDK.javax.swing.@event.MenuListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuListener;)V", "public static")]
	public static void addPopupMenuListener(Dova.JDK.javax.swing.@event.PopupMenuListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuListener;)V", "public static")]
	public static void removePopupMenuListener(Dova.JDK.javax.swing.@event.PopupMenuListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableModelListener;)V", "public static")]
	public static void addTableModelListener(Dova.JDK.javax.swing.@event.TableModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableModelListener;)V", "public static")]
	public static void removeTableModelListener(Dova.JDK.javax.swing.@event.TableModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionListener;)V", "public static")]
	public static void addTreeExpansionListener(Dova.JDK.javax.swing.@event.TreeExpansionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionListener;)V", "public static")]
	public static void removeTreeExpansionListener(Dova.JDK.javax.swing.@event.TreeExpansionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelListener;)V", "public static")]
	public static void addTreeModelListener(Dova.JDK.javax.swing.@event.TreeModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelListener;)V", "public static")]
	public static void removeTreeModelListener(Dova.JDK.javax.swing.@event.TreeModelListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public static")]
	public static void addTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public static")]
	public static void removeTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/UndoableEditListener;)V", "public static")]
	public static void addUndoableEditListener(Dova.JDK.javax.swing.@event.UndoableEditListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/UndoableEditListener;)V", "public static")]
	public static void removeUndoableEditListener(Dova.JDK.javax.swing.@event.UndoableEditListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameListener;)V", "public static")]
	public static void addInternalFrameListener(Dova.JDK.javax.swing.@event.InternalFrameListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameListener;)V", "public static")]
	public static void removeInternalFrameListener(Dova.JDK.javax.swing.@event.InternalFrameListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public static")]
	public static void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public static")]
	public static void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentListener;)V", "public static")]
	public static void removeDocumentListener(Dova.JDK.javax.swing.@event.DocumentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentListener;)V", "public static")]
	public static void addDocumentListener(Dova.JDK.javax.swing.@event.DocumentListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[27], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public static")]
	public static void removeChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)V", "public static")]
	public static void addChangeListener(Dova.JDK.javax.swing.@event.ChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/CaretListener;)V", "public static")]
	public static void addCaretListener(Dova.JDK.javax.swing.@event.CaretListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/CaretListener;)V", "public static")]
	public static void removeCaretListener(Dova.JDK.javax.swing.@event.CaretListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public static")]
	public static void addVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/VetoableChangeListener;)V", "public static")]
	public static void removeVetoableChangeListener(Dova.JDK.java.beans.VetoableChangeListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/AncestorListener;)V", "public static")]
	public static void addAncestorListener(Dova.JDK.javax.swing.@event.AncestorListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/AncestorListener;)V", "public static")]
	public static void removeAncestorListener(Dova.JDK.javax.swing.@event.AncestorListener arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("Lcom/sun/java/accessibility/util/SwingEventMonitor$SwingEventListener;", "static")]
	public partial class SwingEventListener
		: Dova.JDK.com.sun.java.accessibility.util.AWTEventMonitor.AWTEventsListener
		, Dova.JDK.javax.swing.@event.AncestorListener
		, Dova.JDK.javax.swing.@event.CaretListener
		, Dova.JDK.javax.swing.@event.CellEditorListener
		, Dova.JDK.javax.swing.@event.ChangeListener
		, Dova.JDK.javax.swing.@event.DocumentListener
		, Dova.JDK.javax.swing.@event.ListDataListener
		, Dova.JDK.javax.swing.@event.ListSelectionListener
		, Dova.JDK.javax.swing.@event.MenuListener
		, Dova.JDK.javax.swing.@event.PopupMenuListener
		, Dova.JDK.javax.swing.@event.TableColumnModelListener
		, Dova.JDK.javax.swing.@event.TableModelListener
		, Dova.JDK.javax.swing.@event.TreeExpansionListener
		, Dova.JDK.javax.swing.@event.TreeModelListener
		, Dova.JDK.javax.swing.@event.TreeSelectionListener
		, Dova.JDK.javax.swing.@event.UndoableEditListener
		, Dova.JDK.javax.swing.@event.InternalFrameListener
		, Dova.JDK.java.beans.PropertyChangeListener
		, Dova.JDK.java.beans.VetoableChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SwingEventListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/java/accessibility/util/SwingEventMonitor$SwingEventListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caretListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeCaretMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addCaretMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caretArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellEditorListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeCellEditorMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addCellEditorMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellEditorArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getCellEditorMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeChangeMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addChangeMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getColumnModelMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "documentListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeDocumentMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addDocumentMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "documentArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDocumentMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getModelMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listSelectionListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeListSelectionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addListSelectionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listSelectionArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getSelectionModelMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "menuListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeMenuMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addMenuMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "menuArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popupMenuListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removePopupMenuMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addPopupMenuMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "popupMenuArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPopupMenuMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeExpansionListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeTreeExpansionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addTreeExpansionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeExpansionArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeSelectionListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeTreeSelectionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addTreeSelectionMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeSelectionArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "undoableEditListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeUndoableEditMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addUndoableEditMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "undoableEditArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalFrameListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removeInternalFrameMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addInternalFrameMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "internalFrameArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeListeners", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "removePropertyChangeMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "addPropertyChangeMethod", "Ljava/lang/reflect/Method;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeArgs", "[Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nullClass", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nullArgs", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljava/awt/Component;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "(Ljava/awt/Component;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeListeners", "(Ljava/awt/Component;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeIntrospection", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ancestorAdded", "(Ljavax/swing/event/AncestorEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ancestorRemoved", "(Ljavax/swing/event/AncestorEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingStopped", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingCanceled", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contentsChanged", "(Ljavax/swing/event/ListDataEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intervalAdded", "(Ljavax/swing/event/ListDataEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "intervalRemoved", "(Ljavax/swing/event/ListDataEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuCanceled", "(Ljavax/swing/event/MenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuDeselected", "(Ljavax/swing/event/MenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "menuSelected", "(Ljavax/swing/event/MenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeVisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuWillBecomeInvisible", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popupMenuCanceled", "(Ljavax/swing/event/PopupMenuEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableChanged", "(Ljavax/swing/event/TableModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeCollapsed", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeExpanded", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "undoableEditHappened", "(Ljavax/swing/event/UndoableEditEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameOpened", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameActivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameDeactivated", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameIconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameDeiconified", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameClosing", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "internalFrameClosed", "(Ljavax/swing/event/InternalFrameEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "vetoableChange", "(Ljava/beans/PropertyChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ancestorMoved", "(Ljavax/swing/event/AncestorEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "caretUpdate", "(Ljavax/swing/event/CaretEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentAdded", "(Ljava/awt/event/ContainerEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "componentRemoved", "(Ljava/awt/event/ContainerEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> caretListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeCaretMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addCaretMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> caretArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> cellEditorListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeCellEditorMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addCellEditorMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> cellEditorArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getCellEditorMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> changeListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeChangeMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addChangeMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> changeArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getColumnModelMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> documentListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeDocumentMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addDocumentMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> documentArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getDocumentMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getModelMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> listSelectionListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeListSelectionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addListSelectionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> listSelectionArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getSelectionModelMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> menuListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeMenuMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addMenuMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> menuArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> popupMenuListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removePopupMenuMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addPopupMenuMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> popupMenuArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method getPopupMenuMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> treeExpansionListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeTreeExpansionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addTreeExpansionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> treeExpansionArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> treeSelectionListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeTreeSelectionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addTreeSelectionMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> treeSelectionArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> undoableEditListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeUndoableEditMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addUndoableEditMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> undoableEditArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> internalFrameListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removeInternalFrameMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addInternalFrameMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> internalFrameArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> propertyChangeListeners_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method removePropertyChangeMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private")]
		public Dova.JDK.java.lang.reflect.Method addPropertyChangeMethod_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> propertyChangeArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "private")]
		public JavaArray<Dova.JDK.java.lang.Class> nullClass_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
		public JavaArray<Dova.JDK.java.lang.Object> nullArgs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SwingEventListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public SwingEventListener() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/java/accessibility/util/SwingEventMonitor$SwingEventListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;I)V", "protected")]
		public void installListeners(Dova.JDK.java.awt.Component arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
		public void installListeners(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;I)V", "protected")]
		public void removeListeners(Dova.JDK.java.awt.Component arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)V", "protected")]
		public void removeListeners(Dova.JDK.java.awt.Component arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool initializeIntrospection()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public")]
		public void ancestorAdded(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public")]
		public void ancestorRemoved(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void editingStopped(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void editingCanceled(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnAdded(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void columnMarginChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnMoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnRemoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
		public void columnSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
		public void contentsChanged(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
		public void intervalAdded(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListDataEvent;)V", "public")]
		public void intervalRemoved(Dova.JDK.javax.swing.@event.ListDataEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
		public void valueChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "public")]
		public void valueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/MenuEvent;)V", "public")]
		public void menuCanceled(Dova.JDK.javax.swing.@event.MenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/MenuEvent;)V", "public")]
		public void menuDeselected(Dova.JDK.javax.swing.@event.MenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/MenuEvent;)V", "public")]
		public void menuSelected(Dova.JDK.javax.swing.@event.MenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuWillBecomeVisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuWillBecomeInvisible(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/PopupMenuEvent;)V", "public")]
		public void popupMenuCanceled(Dova.JDK.javax.swing.@event.PopupMenuEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "public")]
		public void tableChanged(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
		public void treeCollapsed(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
		public void treeExpanded(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesInserted(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesRemoved(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeStructureChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/UndoableEditEvent;)V", "public")]
		public void undoableEditHappened(Dova.JDK.javax.swing.@event.UndoableEditEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameOpened(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameActivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameDeactivated(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameIconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameDeiconified(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameClosing(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/InternalFrameEvent;)V", "public")]
		public void internalFrameClosed(Dova.JDK.javax.swing.@event.InternalFrameEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void vetoableChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/AncestorEvent;)V", "public")]
		public void ancestorMoved(Dova.JDK.javax.swing.@event.AncestorEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/CaretEvent;)V", "public")]
		public void caretUpdate(Dova.JDK.javax.swing.@event.CaretEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentAdded(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ContainerEvent;)V", "public")]
		public void componentRemoved(Dova.JDK.java.awt.@event.ContainerEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		}
	}
}
