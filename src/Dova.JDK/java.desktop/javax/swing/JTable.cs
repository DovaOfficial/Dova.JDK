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

[JniSignatureAttribute("Ljavax/swing/JTable;", "public")]
public partial class JTable
	: Dova.JDK.javax.swing.JComponent
	, Dova.JDK.javax.swing.@event.TableModelListener
	, Dova.JDK.javax.swing.Scrollable
	, Dova.JDK.javax.swing.@event.TableColumnModelListener
	, Dova.JDK.javax.swing.@event.ListSelectionListener
	, Dova.JDK.javax.swing.@event.CellEditorListener
	, Dova.JDK.javax.accessibility.Accessible
	, Dova.JDK.javax.swing.@event.RowSorterListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JTable()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_RESIZE_OFF", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_RESIZE_NEXT_COLUMN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_RESIZE_SUBSEQUENT_COLUMNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_RESIZE_LAST_COLUMN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AUTO_RESIZE_ALL_COLUMNS", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dataModel", "Ljavax/swing/table/TableModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnModel", "Ljavax/swing/table/TableColumnModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionModel", "Ljavax/swing/ListSelectionModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableHeader", "Ljavax/swing/table/JTableHeader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowHeight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowMargin", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gridColor", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showHorizontalLines", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showVerticalLines", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autoResizeMode", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autoCreateColumnsFromModel", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preferredViewportSize", "Ljava/awt/Dimension;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowSelectionAllowed", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellSelectionEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editorComp", "Ljava/awt/Component;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellEditor", "Ljavax/swing/table/TableCellEditor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editingColumn", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editingRow", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultRenderersByColumnClass", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultEditorsByColumnClass", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionForeground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionBackground", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowModel", "Ljavax/swing/SizeSequence;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "surrendersFocusOnKeystroke", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editorRemover", "Ljava/beans/PropertyChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnSelectionAdjusting", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowSelectionAdjusting", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printError", "Ljava/lang/Throwable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isRowHeightSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateSelectionOnSort", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sortManager", "Ljavax/swing/JTable$SortManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ignoreSortChange", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sorterChanged", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "autoCreateRowSorter", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fillsViewportHeight", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropMode", "Ljavax/swing/DropMode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropLocation", "Ljavax/swing/JTable$DropLocation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateInProgress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/table/TableModel;Ljavax/swing/table/TableColumnModel;Ljavax/swing/ListSelectionModel;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(II)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Vector;Ljava/util/Vector;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([[Ljava/lang/Object;[Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/table/TableModel;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/table/TableModel;Ljavax/swing/table/TableColumnModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "limit", "(III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;ZLjavax/print/attribute/PrintRequestAttributeSet;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;ZLjavax/print/attribute/PrintRequestAttributeSet;ZLjavax/print/PrintService;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljavax/swing/JTable$PrintMode;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnModel", "()Ljavax/swing/table/TableColumnModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumn", "(Ljava/lang/Object;)Ljavax/swing/table/TableColumn;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectAll", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearSelection", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionMode", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPreferredScrollableViewportSize", "(Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnSelectionAllowed", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionModel", "()Ljavax/swing/ListSelectionModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustSizes", "(JLjavax/swing/JTable$Resizable3;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustSizes", "(JLjavax/swing/JTable$Resizable2;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellRenderer", "(II)Ljavax/swing/table/TableCellRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareRenderer", "(Ljavax/swing/table/TableCellRenderer;II)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editCellAt", "(IILjava/util/EventObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editCellAt", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellEditor", "(II)Ljavax/swing/table/TableCellEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellEditor", "()Ljavax/swing/table/TableCellEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareEditor", "(Ljavax/swing/table/TableCellEditor;II)Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCellEditor", "(Ljavax/swing/table/TableCellEditor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditingRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditingColumn", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableChanged", "(Ljavax/swing/event/TableModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutoCreateRowSorter", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sorterChanged", "(Ljavax/swing/event/RowSorterEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sortedTableChanged", "(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/event/TableModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaintSortedRows", "(Ljavax/swing/JTable$ModelChange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "notifySorter", "(Ljavax/swing/JTable$ModelChange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreSortingEditingRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutoCreateColumnsFromModel", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableRowsInserted", "(Ljavax/swing/event/TableModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableRowsDeleted", "(Ljavax/swing/event/TableModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadingRow", "(Ljava/awt/Rectangle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadingCol", "(Ljava/awt/Rectangle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "leadingEdge", "(Ljava/awt/Rectangle;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreviousBlockIncrement", "(Ljava/awt/Rectangle;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextBlockIncrement", "(Ljava/awt/Rectangle;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "trailingEdge", "(Ljava/awt/Rectangle;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrailingRow", "(Ljava/awt/Rectangle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrailingCol", "(Ljava/awt/Rectangle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFillsViewportHeight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditorComponent", "()Ljava/awt/Component;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSurrendersFocusOnKeystroke", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultRenderers", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultEditors", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultTableHeader", "()Ljavax/swing/table/JTableHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTableHeader", "(Ljavax/swing/table/JTableHeader;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShowGrid", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSurrendersFocusOnKeystroke", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrintable", "(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;)Ljava/awt/print/Printable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createScrollPaneForTable", "(Ljavax/swing/JTable;)Ljavax/swing/JScrollPane;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIntercellSpacing", "(Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIntercellSpacing", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGridColor", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGridColor", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShowHorizontalLines", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShowVerticalLines", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAutoResizeMode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoCreateColumnsFromModel", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultRenderer", "(Ljava/lang/Class;Ljavax/swing/table/TableCellRenderer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDefaultEditor", "(Ljava/lang/Class;Ljavax/swing/table/TableCellEditor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDragEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDragEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDropMode", "(Ljavax/swing/DropMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDropMode", "()Ljavax/swing/DropMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDropLocation", "()Ljavax/swing/JTable$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoCreateRowSorter", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUpdateSelectionOnSort", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpdateSelectionOnSort", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCellSelectionEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellSelectionEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeRowSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeColumnSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedColumn", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeSelection", "(IIZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionForeground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionForeground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditingColumn", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditingRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreSortingSelection", "([IILjavax/swing/JTable$ModelChange;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertSelectionToModel", "(Ljavax/swing/event/RowSorterEvent;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingStopped", "(Ljavax/swing/event/ChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingCanceled", "(Ljavax/swing/event/ChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredScrollableViewportSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableUnitIncrement", "(Ljava/awt/Rectangle;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableBlockIncrement", "(Ljava/awt/Rectangle;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportWidth", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportHeight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFillsViewportHeight", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUI", "(Ljavax/swing/plaf/TableUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_0", "()Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_1", "()Ljavax/swing/plaf/TableUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compWriteObjectNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processKeyBinding", "(Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;IZ)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToolTipText", "(Ljava/awt/event/MouseEvent;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeNotify", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropLocationForPoint_0", "(Ljava/awt/Point;)Ljavax/swing/JTable$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropLocationForPoint_1", "(Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDropLocation", "(Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUIProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doLayout", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultColumnModel", "()Ljavax/swing/table/TableColumnModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnModel", "(Ljavax/swing/table/TableColumnModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultSelectionModel", "()Ljavax/swing/ListSelectionModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionModel", "(Ljavax/swing/ListSelectionModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultDataModel", "()Ljavax/swing/table/TableModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModel", "(Ljavax/swing/table/TableModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initializeLocalVars", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureEnclosingScrollPane", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableHeader", "()Ljavax/swing/table/JTableHeader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureEnclosingScrollPaneUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unconfigureEnclosingScrollPane", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowHeight", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowHeight", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resizeAndRepaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowHeight", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowModel", "()Ljavax/swing/SizeSequence;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowMargin", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShowHorizontalLines", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShowVerticalLines", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isValidAutoResizeMode", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultColumnsFromModel", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModel", "()Ljavax/swing/table/TableModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeColumn", "(Ljavax/swing/table/TableColumn;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addColumn", "(Ljavax/swing/table/TableColumn;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultRenderer", "(Ljava/lang/Class;)Ljavax/swing/table/TableCellRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultEditor", "(Ljava/lang/Class;)Ljavax/swing/table/TableCellEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDragEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkDropMode", "(Ljavax/swing/DropMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rowAtPoint", "(Ljava/awt/Point;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnAtPoint", "(Ljava/awt/Point;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellRect", "(IIZ)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRowSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addColumnSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedRows", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedColumns", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdjustedIndex", "(IZ)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearSelectionAndLeadAnchor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setColumnSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowSorter", "(Ljavax/swing/RowSorter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnSelectionAllowed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowSelectionAllowed", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowSelectionAllowed", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEditing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeEditor", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundRow", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "boundColumn", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedColumnCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRowSelected", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isColumnSelected", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCellSelected", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changeSelectionModel", "(Ljavax/swing/ListSelectionModel;IZZZIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertColumnIndexToModel", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertColumnIndexToView", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowSorter", "()Ljavax/swing/RowSorter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertRowIndexToView", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertRowIndexToView", "(ILjavax/swing/JTable$ModelChange;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertRowIndexToModel", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertRowIndexToModel", "(Ljavax/swing/event/RowSorterEvent;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnName", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnClass", "(I)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValueAt", "(II)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValueAt", "(Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCellEditable", "(II)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moveColumn", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowMargin", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResizingColumn", "()Ljavax/swing/table/TableColumn;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setWidthsFromPreferredWidths", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewIndexForColumn", "(Ljavax/swing/table/TableColumn;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accommodateDelta", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAutoResizeMode", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sizeColumnsToFit", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "sizeColumnsToFit", "(Z)V"));
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

	[JniSignatureAttribute("I", "public static final")]
	public static int AUTO_RESIZE_OFF_Property
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
	public static int AUTO_RESIZE_NEXT_COLUMN_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int AUTO_RESIZE_SUBSEQUENT_COLUMNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int AUTO_RESIZE_LAST_COLUMN_Property
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

	[JniSignatureAttribute("I", "public static final")]
	public static int AUTO_RESIZE_ALL_COLUMNS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/TableModel;", "protected")]
	public Dova.JDK.javax.swing.table.TableModel dataModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/TableColumnModel;", "protected")]
	public Dova.JDK.javax.swing.table.TableColumnModel columnModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumnModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/ListSelectionModel;", "protected")]
	public Dova.JDK.javax.swing.ListSelectionModel selectionModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/JTableHeader;", "protected")]
	public Dova.JDK.javax.swing.table.JTableHeader tableHeader_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.JTableHeader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int rowHeight_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int rowMargin_Property
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

	[JniSignatureAttribute("Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color gridColor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool showHorizontalLines_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool showVerticalLines_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int autoResizeMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool autoCreateColumnsFromModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[16]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[16], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Dimension;", "protected")]
	public Dova.JDK.java.awt.Dimension preferredViewportSize_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool rowSelectionAllowed_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool cellSelectionEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[19]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[19], value);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Component;", "protected transient")]
	public Dova.JDK.java.awt.Component editorComp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/TableCellEditor;", "protected transient")]
	public Dova.JDK.javax.swing.table.TableCellEditor cellEditor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected transient")]
	public int editingColumn_Property
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

	[JniSignatureAttribute("I", "protected transient")]
	public int editingRow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "protected transient")]
	public Dova.JDK.java.util.Hashtable defaultRenderersByColumnClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Hashtable;", "protected transient")]
	public Dova.JDK.java.util.Hashtable defaultEditorsByColumnClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color selectionForeground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "protected")]
	public Dova.JDK.java.awt.Color selectionBackground_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SizeSequence;", "private")]
	public Dova.JDK.javax.swing.SizeSequence rowModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeSequence>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dragEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool surrendersFocusOnKeystroke_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[30]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[30], value);
		}
	}

	[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private")]
	public Dova.JDK.java.beans.PropertyChangeListener editorRemover_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool columnSelectionAdjusting_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool rowSelectionAdjusting_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[33]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[33], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Throwable;", "private")]
	public Dova.JDK.java.lang.Throwable printError_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isRowHeightSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[35], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool updateSelectionOnSort_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[36]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[36], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$SortManager;", "private transient")]
	public Dova.JDK.javax.swing.JTable.SortManager sortManager_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.SortManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool ignoreSortChange_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[38]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[38], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool sorterChanged_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[39]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[39], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool autoCreateRowSorter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[40]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[40], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool fillsViewportHeight_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[41]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[41], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/DropMode;", "private")]
	public Dova.JDK.javax.swing.DropMode dropMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DropMode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$DropLocation;", "private transient")]
	public Dova.JDK.javax.swing.JTable.DropLocation dropLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.DropLocation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool updateInProgress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[44]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[44], value);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[45]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[45], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JTable(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableModel;Ljavax/swing/table/TableColumnModel;Ljavax/swing/ListSelectionModel;)V", "public")]
	public JTable(Dova.JDK.javax.swing.table.TableModel arg0, Dova.JDK.javax.swing.table.TableColumnModel arg1, Dova.JDK.javax.swing.ListSelectionModel arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(II)V", "public")]
	public JTable(int arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Vector;Ljava/util/Vector;)V", "public")]
	public JTable(Dova.JDK.java.util.Vector arg0, Dova.JDK.java.util.Vector arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("([[Ljava/lang/Object;[Ljava/lang/Object;)V", "public")]
	public JTable(JavaArray<JavaArray<Dova.JDK.java.lang.Object>> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JTable() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableModel;)V", "public")]
	public JTable(Dova.JDK.javax.swing.table.TableModel arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableModel;Ljavax/swing/table/TableColumnModel;)V", "public")]
	public JTable(Dova.JDK.javax.swing.table.TableModel arg0, Dova.JDK.javax.swing.table.TableColumnModel arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JTable;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(III)I", "private")]
	public int limit(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;ZLjavax/print/attribute/PrintRequestAttributeSet;Z)Z", "public")]
	public bool print(Dova.JDK.javax.swing.JTable.PrintMode arg0, Dova.JDK.java.text.MessageFormat arg1, Dova.JDK.java.text.MessageFormat arg2, bool arg3, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool print()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;ZLjavax/print/attribute/PrintRequestAttributeSet;ZLjavax/print/PrintService;)Z", "public")]
	public bool print(Dova.JDK.javax.swing.JTable.PrintMode arg0, Dova.JDK.java.text.MessageFormat arg1, Dova.JDK.java.text.MessageFormat arg2, bool arg3, Dova.JDK.javax.print.attribute.PrintRequestAttributeSet arg4, bool arg5, Dova.JDK.javax.print.PrintService arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;)Z", "public")]
	public bool print(Dova.JDK.javax.swing.JTable.PrintMode arg0, Dova.JDK.java.text.MessageFormat arg1, Dova.JDK.java.text.MessageFormat arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$PrintMode;)Z", "public")]
	public bool print(Dova.JDK.javax.swing.JTable.PrintMode arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableColumnModel;", "public")]
	public Dova.JDK.javax.swing.table.TableColumnModel getColumnModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumnModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/swing/table/TableColumn;", "public")]
	public Dova.JDK.javax.swing.table.TableColumn getColumn(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumn>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void selectAll()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearSelection()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setRowSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setSelectionMode(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
	public void setPreferredScrollableViewportSize(Dova.JDK.java.awt.Dimension arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setColumnSelectionAllowed(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ListSelectionModel;", "public")]
	public Dova.JDK.javax.swing.ListSelectionModel getSelectionModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
	public void valueChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(JLjavax/swing/JTable$Resizable3;Z)V", "private")]
	public void adjustSizes(long arg0, Dova.JDK.javax.swing.JTable.Resizable3 arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JLjavax/swing/JTable$Resizable2;Z)V", "private")]
	public void adjustSizes(long arg0, Dova.JDK.javax.swing.JTable.Resizable2 arg1, bool arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/table/TableCellRenderer;", "public")]
	public Dova.JDK.javax.swing.table.TableCellRenderer getCellRenderer(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellRenderer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableCellRenderer;II)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component prepareRenderer(Dova.JDK.javax.swing.table.TableCellRenderer arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(IILjava/util/EventObject;)Z", "public")]
	public bool editCellAt(int arg0, int arg1, Dova.JDK.java.util.EventObject arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool editCellAt(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljavax/swing/table/TableCellEditor;", "public")]
	public Dova.JDK.javax.swing.table.TableCellEditor getCellEditor(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableCellEditor;", "public")]
	public Dova.JDK.javax.swing.table.TableCellEditor getCellEditor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableCellEditor;II)Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component prepareEditor(Dova.JDK.javax.swing.table.TableCellEditor arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableCellEditor;)V", "public")]
	public void setCellEditor(Dova.JDK.javax.swing.table.TableCellEditor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setEditingRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setEditingColumn(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "public")]
	public void tableChanged(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAutoCreateRowSorter()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;)V", "public")]
	public void sorterChanged(Dova.JDK.javax.swing.@event.RowSorterEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/event/TableModelEvent;)V", "private")]
	public void sortedTableChanged(Dova.JDK.javax.swing.@event.RowSorterEvent arg0, Dova.JDK.javax.swing.@event.TableModelEvent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$ModelChange;)V", "private")]
	public void repaintSortedRows(Dova.JDK.javax.swing.JTable.ModelChange arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$ModelChange;)V", "private")]
	public void notifySorter(Dova.JDK.javax.swing.JTable.ModelChange arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("(I)V", "private")]
	public void restoreSortingEditingRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getAutoCreateColumnsFromModel()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "private")]
	public void tableRowsInserted(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "private")]
	public void tableRowsDeleted(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)I", "private")]
	public int getLeadingRow(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)I", "private")]
	public int getLeadingCol(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;I)I", "private")]
	public int leadingEdge(Dova.JDK.java.awt.Rectangle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;I)I", "private")]
	public int getPreviousBlockIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;I)I", "private")]
	public int getNextBlockIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;I)I", "private")]
	public int trailingEdge(Dova.JDK.java.awt.Rectangle arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)I", "private")]
	public int getTrailingRow(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)I", "private")]
	public int getTrailingCol(Dova.JDK.java.awt.Rectangle arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getFillsViewportHeight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Component;", "public")]
	public Dova.JDK.java.awt.Component getEditorComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getSurrendersFocusOnKeystroke()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53]);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void createDefaultRenderers()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void createDefaultEditors()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55]);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/JTableHeader;", "protected")]
	public Dova.JDK.javax.swing.table.JTableHeader createDefaultTableHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.JTableHeader>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/JTableHeader;)V", "public")]
	public void setTableHeader(Dova.JDK.javax.swing.table.JTableHeader arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setShowGrid(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setSurrendersFocusOnKeystroke(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable$PrintMode;Ljava/text/MessageFormat;Ljava/text/MessageFormat;)Ljava/awt/print/Printable;", "public")]
	public Dova.JDK.java.awt.print.Printable getPrintable(Dova.JDK.javax.swing.JTable.PrintMode arg0, Dova.JDK.java.text.MessageFormat arg1, Dova.JDK.java.text.MessageFormat arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.Printable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JTable;)Ljavax/swing/JScrollPane;", "public static")]
	public static Dova.JDK.javax.swing.JScrollPane createScrollPaneForTable(Dova.JDK.javax.swing.JTable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JScrollPane>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
	public void setIntercellSpacing(Dova.JDK.java.awt.Dimension arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getIntercellSpacing()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setGridColor(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getGridColor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getShowHorizontalLines()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[66]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getShowVerticalLines()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getAutoResizeMode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[68]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoCreateColumnsFromModel(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljavax/swing/table/TableCellRenderer;)V", "public")]
	public void setDefaultRenderer(Dova.JDK.java.lang.Class arg0, Dova.JDK.javax.swing.table.TableCellRenderer arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljavax/swing/table/TableCellEditor;)V", "public")]
	public void setDefaultEditor(Dova.JDK.java.lang.Class arg0, Dova.JDK.javax.swing.table.TableCellEditor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setDragEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getDragEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[73]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/DropMode;)V", "public final")]
	public void setDropMode(Dova.JDK.javax.swing.DropMode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/DropMode;", "public final")]
	public Dova.JDK.javax.swing.DropMode getDropMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DropMode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JTable$DropLocation;", "public final")]
	public Dova.JDK.javax.swing.JTable.DropLocation getDropLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.DropLocation>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoCreateRowSorter(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setUpdateSelectionOnSort(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getUpdateSelectionOnSort()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[79]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setCellSelectionEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getCellSelectionEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[81]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void removeRowSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void removeColumnSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedColumn()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[84]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[85]);
		return ret;
	}

	[JniSignatureAttribute("(IIZZ)V", "public")]
	public void changeSelection(int arg0, int arg1, bool arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getSelectionForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setSelectionForeground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getSelectionBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setSelectionBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEditingColumn()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[91]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEditingRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[92]);
		return ret;
	}

	[JniSignatureAttribute("([IILjavax/swing/JTable$ModelChange;)V", "private")]
	public void restoreSortingSelection(JavaArray<int> arg0, int arg1, Dova.JDK.javax.swing.JTable.ModelChange arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[93], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;)[I", "private")]
	public JavaArray<int> convertSelectionToModel(Dova.JDK.javax.swing.@event.RowSorterEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
	public void columnAdded(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
	public void columnRemoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
	public void columnMoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
	public void columnMarginChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
	public void columnSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[99], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
	public void editingStopped(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[100], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
	public void editingCanceled(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredScrollableViewportSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;II)I", "public")]
	public int getScrollableUnitIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[103], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;II)I", "public")]
	public int getScrollableBlockIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[104], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportWidth()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[105]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportHeight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[106]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setFillsViewportHeight(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[108]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/TableUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.TableUI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[109], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComponentUI;", "public volatile")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[110]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/TableUI;", "public")]
	public Dova.JDK.javax.swing.plaf.TableUI getUI_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[111]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.TableUI>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[112]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void compWriteObjectNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[113]);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;Ljava/awt/event/KeyEvent;IZ)Z", "protected")]
	public bool processKeyBinding(Dova.JDK.javax.swing.KeyStroke arg0, Dova.JDK.java.awt.@event.KeyEvent arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[115], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getToolTipText(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[116], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void addNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[117]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeNotify()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118]);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/swing/JTable$DropLocation;", "")]
	public Dova.JDK.javax.swing.JTable.DropLocation dropLocationForPoint_0(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.DropLocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;", "volatile")]
	public Dova.JDK.javax.swing.TransferHandler.DropLocation dropLocationForPoint_1(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TransferHandler.DropLocation>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object setDropLocation(Dova.JDK.javax.swing.TransferHandler.DropLocation arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "")]
	public void setUIProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "public")]
	public void doLayout()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[123]);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableColumnModel;", "protected")]
	public Dova.JDK.javax.swing.table.TableColumnModel createDefaultColumnModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[124]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumnModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumnModel;)V", "public")]
	public void setColumnModel(Dova.JDK.javax.swing.table.TableColumnModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[125], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ListSelectionModel;", "protected")]
	public Dova.JDK.javax.swing.ListSelectionModel createDefaultSelectionModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[126]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/ListSelectionModel;)V", "public")]
	public void setSelectionModel(Dova.JDK.javax.swing.ListSelectionModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[127], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableModel;", "protected")]
	public Dova.JDK.javax.swing.table.TableModel createDefaultDataModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[128]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableModel;)V", "public")]
	public void setModel(Dova.JDK.javax.swing.table.TableModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[129], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void initializeLocalVars()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[130]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void configureEnclosingScrollPane()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[131]);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/JTableHeader;", "public")]
	public Dova.JDK.javax.swing.table.JTableHeader getTableHeader()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.JTableHeader>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void configureEnclosingScrollPaneUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[133]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void unconfigureEnclosingScrollPane()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[134]);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setRowHeight(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[135], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRowHeight(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[136], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void resizeAndRepaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[137]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[138]);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRowHeight(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[139], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/SizeSequence;", "private")]
	public Dova.JDK.javax.swing.SizeSequence getRowModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[140]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeSequence>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRowMargin(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[141], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setShowHorizontalLines(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[142], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setShowVerticalLines(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[143], arg0);
	}

	[JniSignatureAttribute("(I)Z", "private static")]
	public static bool isValidAutoResizeMode(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[144], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void createDefaultColumnsFromModel()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[145]);
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableModel;", "public")]
	public Dova.JDK.javax.swing.table.TableModel getModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[146]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableModel>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getColumnCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[147]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumn;)V", "public")]
	public void removeColumn(Dova.JDK.javax.swing.table.TableColumn arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[148], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumn;)V", "public")]
	public void addColumn(Dova.JDK.javax.swing.table.TableColumn arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[149], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/swing/table/TableCellRenderer;", "public")]
	public Dova.JDK.javax.swing.table.TableCellRenderer getDefaultRenderer(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellRenderer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/swing/table/TableCellEditor;", "public")]
	public Dova.JDK.javax.swing.table.TableCellEditor getDefaultEditor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[151], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void checkDragEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[152], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/DropMode;)V", "private static")]
	public static void checkDropMode(Dova.JDK.javax.swing.DropMode arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[153], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)I", "public")]
	public int rowAtPoint(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[154], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)I", "public")]
	public int columnAtPoint(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[155], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IIZ)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getCellRect(int arg0, int arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[156], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void addRowSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[157], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void addColumnSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[158], arg0, arg1);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getSelectedRows()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[159]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getSelectedColumns()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[160]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(IZ)I", "private")]
	public int getAdjustedIndex(int arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[161], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void clearSelectionAndLeadAnchor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[162]);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setColumnSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[163], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/RowSorter;)V", "public")]
	public void setRowSorter(Dova.JDK.javax.swing.RowSorter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[164], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getColumnSelectionAllowed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[165]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRowSelectionAllowed(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[166], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getRowSelectionAllowed()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[167]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEditing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[168]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void removeEditor()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[169]);
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int boundRow(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[170], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "private")]
	public int boundColumn(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[171], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedColumnCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[172]);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isRowSelected(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[173], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isColumnSelected(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[174], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool isCellSelected(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[175], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/ListSelectionModel;IZZZIZ)V", "private")]
	public void changeSelectionModel(Dova.JDK.javax.swing.ListSelectionModel arg0, int arg1, bool arg2, bool arg3, bool arg4, int arg5, bool arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[176], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int convertColumnIndexToModel(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[177], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int convertColumnIndexToView(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[178], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/RowSorter;", "public")]
	public Dova.JDK.javax.swing.RowSorter getRowSorter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[179]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.RowSorter>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int convertRowIndexToView(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[180], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/JTable$ModelChange;)I", "private")]
	public int convertRowIndexToView(int arg0, Dova.JDK.javax.swing.JTable.ModelChange arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[181], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int convertRowIndexToModel(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[182], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;I)I", "private")]
	public int convertRowIndexToModel(Dova.JDK.javax.swing.@event.RowSorterEvent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[183], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getColumnName(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[184], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class getColumnClass(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[185], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getValueAt(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[186], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)V", "public")]
	public void setValueAt(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[187], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(II)Z", "public")]
	public bool isCellEditable(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[188], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void moveColumn(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[189], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowMargin()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[190]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/table/TableColumn;", "private")]
	public Dova.JDK.javax.swing.table.TableColumn getResizingColumn()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[191]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumn>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private")]
	public void setWidthsFromPreferredWidths(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[192], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumn;)I", "private")]
	public int viewIndexForColumn(Dova.JDK.javax.swing.table.TableColumn arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[193], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void accommodateDelta(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[194], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setAutoResizeMode(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[195], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void sizeColumnsToFit(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[196], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void sizeColumnsToFit(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[197], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$SortManager;", "private final")]
	public partial class SortManager
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SortManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$SortManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sorter", "Ljavax/swing/RowSorter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelSelection", "Ljavax/swing/ListSelectionModel;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelLeadIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "syncingSelection", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastModelSelection", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelRowSizes", "Ljavax/swing/SizeSequence;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable;Ljavax/swing/RowSorter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheSelection", "(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cacheModelSelection", "(Ljavax/swing/event/RowSorterEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setViewRowHeightsFromModel", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "restoreSelection", "(Ljavax/swing/JTable$ModelChange;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prepareForChange", "(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processChange", "(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allChanged", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setViewRowHeight", "(II)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/RowSorter;", "")]
		public Dova.JDK.javax.swing.RowSorter sorter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.RowSorter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/ListSelectionModel;", "private")]
		public Dova.JDK.javax.swing.ListSelectionModel modelSelection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int modelLeadIndex_Property
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

		[JniSignatureAttribute("Z", "private")]
		public bool syncingSelection_Property
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

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> lastModelSelection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/SizeSequence;", "private")]
		public Dova.JDK.javax.swing.SizeSequence modelRowSizes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeSequence>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable;", "final")]
		public Dova.JDK.javax.swing.JTable this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SortManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljavax/swing/RowSorter;)V", "")]
		public SortManager(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.javax.swing.RowSorter arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$SortManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void dispose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;)V", "private")]
		public void cacheSelection(Dova.JDK.javax.swing.@event.RowSorterEvent arg0, Dova.JDK.javax.swing.JTable.ModelChange arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;)V", "private")]
		public void cacheModelSelection(Dova.JDK.javax.swing.@event.RowSorterEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void setViewRowHeightsFromModel()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable$ModelChange;)V", "private")]
		public void restoreSelection(Dova.JDK.javax.swing.JTable.ModelChange arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;)V", "public")]
		public void prepareForChange(Dova.JDK.javax.swing.@event.RowSorterEvent arg0, Dova.JDK.javax.swing.JTable.ModelChange arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/RowSorterEvent;Ljavax/swing/JTable$ModelChange;Z)V", "public")]
		public void processChange(Dova.JDK.javax.swing.@event.RowSorterEvent arg0, Dova.JDK.javax.swing.JTable.ModelChange arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "public")]
		public void allChanged()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
		public void viewSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(II)V", "public")]
		public void setViewRowHeight(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$DropLocation;", "public static final")]
	public partial class DropLocation
		: Dova.JDK.javax.swing.TransferHandler.DropLocation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DropLocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$DropLocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "col", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInsertRow", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isInsertCol", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Point;IIZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumn", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInsertRow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInsertColumn", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "()I"));
		}

		[JniSignatureAttribute("I", "private final")]
		public int row_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int col_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool isInsertRow_Property
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

		[JniSignatureAttribute("Z", "private final")]
		public bool isInsertCol_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DropLocation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Point;IIZZ)V", "private")]
		public DropLocation(Dova.JDK.java.awt.Point arg0, int arg1, int arg2, bool arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$DropLocation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getColumn()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInsertRow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInsertColumn()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getRow()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$Resizable3;", "private abstract static interface")]
	public partial interface Resizable3
		: IJavaObject
		, Dova.JDK.javax.swing.JTable.Resizable2
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resizable3()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$Resizable3;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMidPointAt", "(I)I"));
		}

		[JniSignatureAttribute("(I)I", "public abstract")]
		int getMidPointAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$Resizable2;", "private abstract static interface")]
	public partial interface Resizable2
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Resizable2()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$Resizable2;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElementCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLowerBoundAt", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpperBoundAt", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSizeAt", "(II)V"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getElementCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public abstract")]
		int getLowerBoundAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public abstract")]
		int getUpperBoundAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(II)V", "public abstract")]
		void setSizeAt(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$CellEditorRemover;", "")]
	public partial class CellEditorRemover
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.beans.PropertyChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CellEditorRemover()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$CellEditorRemover;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusManager", "Ljava/awt/KeyboardFocusManager;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable;Ljava/awt/KeyboardFocusManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/awt/KeyboardFocusManager;", "")]
		public Dova.JDK.java.awt.KeyboardFocusManager focusManager_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.KeyboardFocusManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable;", "final")]
		public Dova.JDK.javax.swing.JTable this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CellEditorRemover(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/awt/KeyboardFocusManager;)V", "public")]
		public CellEditorRemover(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.awt.KeyboardFocusManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$CellEditorRemover;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$ModelChange;", "private final")]
	public partial class ModelChange
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModelChange()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$ModelChange;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startModelIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endModelIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modelRowCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "event", "Ljavax/swing/event/TableModelEvent;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allRowsChanged", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable;Ljavax/swing/event/TableModelEvent;)V"));
		}

		[JniSignatureAttribute("I", "")]
		public int startModelIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int endModelIndex_Property
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

		[JniSignatureAttribute("I", "")]
		public int type_Property
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

		[JniSignatureAttribute("I", "")]
		public int modelRowCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/event/TableModelEvent;", "")]
		public Dova.JDK.javax.swing.@event.TableModelEvent @event_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.TableModelEvent>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int length_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Z", "")]
		public bool allRowsChanged_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModelChange(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljavax/swing/event/TableModelEvent;)V", "")]
		public ModelChange(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.javax.swing.@event.TableModelEvent arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$ModelChange;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$PrintMode;", "public static final")]
	public partial class PrintMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrintMode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$PrintMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NORMAL", "Ljavax/swing/JTable$PrintMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIT_WIDTH", "Ljavax/swing/JTable$PrintMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljavax/swing/JTable$PrintMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljavax/swing/JTable$PrintMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljavax/swing/JTable$PrintMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljavax/swing/JTable$PrintMode;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$PrintMode;", "public static final")]
		public static Dova.JDK.javax.swing.JTable.PrintMode NORMAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.PrintMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$PrintMode;", "public static final")]
		public static Dova.JDK.javax.swing.JTable.PrintMode FIT_WIDTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.PrintMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/swing/JTable$PrintMode;", "private static final")]
		public static JavaArray<Dova.JDK.javax.swing.JTable.PrintMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.JTable.PrintMode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrintMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public PrintMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$PrintMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/swing/JTable$PrintMode;", "public static")]
		public static JavaArray<Dova.JDK.javax.swing.JTable.PrintMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.JTable.PrintMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/JTable$PrintMode;", "public static")]
		public static Dova.JDK.javax.swing.JTable.PrintMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.PrintMode>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/swing/JTable$PrintMode;", "private static")]
		public static JavaArray<Dova.JDK.javax.swing.JTable.PrintMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.JTable.PrintMode>>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$ThreadSafePrintable;", "private static")]
	public partial class ThreadSafePrintable
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.print.Printable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ThreadSafePrintable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$ThreadSafePrintable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printDelegate", "Ljava/awt/print/Printable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retVal", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "retThrowable", "Ljava/lang/Throwable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/print/Printable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/awt/Graphics;Ljava/awt/print/PageFormat;I)I"));
		}

		[JniSignatureAttribute("Ljava/awt/print/Printable;", "private")]
		public Dova.JDK.java.awt.print.Printable printDelegate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.print.Printable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int retVal_Property
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

		[JniSignatureAttribute("Ljava/lang/Throwable;", "private")]
		public Dova.JDK.java.lang.Throwable retThrowable_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Throwable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ThreadSafePrintable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/print/Printable;)V", "public")]
		public ThreadSafePrintable(Dova.JDK.java.awt.print.Printable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$ThreadSafePrintable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/print/PageFormat;I)I", "public")]
		public int print(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.print.PageFormat arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable;", "protected")]
	public partial class AccessibleJTable
		: Dova.JDK.javax.swing.JComponent.AccessibleJComponent
		, Dova.JDK.javax.accessibility.AccessibleSelection
		, Dova.JDK.javax.swing.@event.ListSelectionListener
		, Dova.JDK.javax.swing.@event.TableModelListener
		, Dova.JDK.javax.swing.@event.TableColumnModelListener
		, Dova.JDK.javax.swing.@event.CellEditorListener
		, Dova.JDK.java.beans.PropertyChangeListener
		, Dova.JDK.javax.accessibility.AccessibleExtendedTable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJTable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$AccessibleJTable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousFocusedRow", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "previousFocusedCol", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caption", "Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "summary", "Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowDescription", "[Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnDescription", "[Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleTable", "()Ljavax/accessibility/AccessibleTable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexAt", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnAtIndex", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowAtIndex", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRow", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumn", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndex", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelectionCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectAllAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleCaption", "()Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleCaption", "(Ljavax/accessibility/Accessible;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSummary", "()Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleSummary", "(Ljavax/accessibility/Accessible;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowExtentAt", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnExtentAt", "(II)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowHeader", "()Ljavax/accessibility/AccessibleTable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnHeader", "()Ljavax/accessibility/AccessibleTable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowDescription", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowDescription", "(ILjavax/accessibility/Accessible;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnDescription", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnDescription", "(ILjavax/accessibility/Accessible;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleSelected", "(II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleRowSelected", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleColumnSelected", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleRows", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleColumns", "()[I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableChanged", "(Ljavax/swing/event/TableModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableRowsInserted", "(Ljavax/swing/event/TableModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tableRowsDeleted", "(Ljavax/swing/event/TableModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnMarginChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "columnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingStopped", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "editingCanceled", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(II)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleChildSelected", "(I)Z"));
		}

		[JniSignatureAttribute("I", "")]
		public int previousFocusedRow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int previousFocusedCol_Property
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

		[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "private")]
		public Dova.JDK.javax.accessibility.Accessible caption_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "private")]
		public Dova.JDK.javax.accessibility.Accessible summary_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/accessibility/Accessible;", "private")]
		public JavaArray<Dova.JDK.javax.accessibility.Accessible> rowDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.accessibility.Accessible>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljavax/accessibility/Accessible;", "private")]
		public JavaArray<Dova.JDK.javax.accessibility.Accessible> columnDescription_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.accessibility.Accessible>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable;", "final")]
		public Dova.JDK.javax.swing.JTable this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJTable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;)V", "protected")]
		public AccessibleJTable(Dova.JDK.javax.swing.JTable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$AccessibleJTable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleTable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getAccessibleIndexAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getAccessibleColumnAtIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getAccessibleRowAtIndex(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getAccessibleRow(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getAccessibleColumn(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getAccessibleIndex(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
		public void valueChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleSelectionCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void addAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void removeAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clearAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void selectAllAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleCaption()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
		public void setAccessibleCaption(Dova.JDK.javax.accessibility.Accessible arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleSummary()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
		public void setAccessibleSummary(Dova.JDK.javax.accessibility.Accessible arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleRowCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getAccessibleRowExtentAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(II)I", "public")]
		public int getAccessibleColumnExtentAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleRowHeader()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
		public void setAccessibleRowHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleColumnHeader()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
		public void setAccessibleColumnHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleRowDescription(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
		public void setAccessibleRowDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleColumnDescription(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
		public void setAccessibleColumnDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		}

		[JniSignatureAttribute("(II)Z", "public")]
		public bool isAccessibleSelected(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isAccessibleRowSelected(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isAccessibleColumnSelected(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[I", "public")]
		public JavaArray<int> getSelectedAccessibleRows()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("()[I", "public")]
		public JavaArray<int> getSelectedAccessibleColumns()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "public")]
		public void tableChanged(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "public")]
		public void tableRowsInserted(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableModelEvent;)V", "public")]
		public void tableRowsDeleted(Dova.JDK.javax.swing.@event.TableModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnAdded(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnRemoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "public")]
		public void columnMoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void columnMarginChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
		public void columnSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void editingStopped(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void editingCanceled(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
		public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleChildrenCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(II)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleSelection(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isAccessibleChildSelected(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			return ret;
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableModelChange;", "protected")]
		public partial class AccessibleJTableModelChange
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.accessibility.AccessibleTableModelChange
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJTableModelChange()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableModelChange;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstRow", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRow", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstColumn", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastColumn", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable$AccessibleJTable;IIIII)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstColumn", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastColumn", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastRow", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstRow", "()I"));
			}

			[JniSignatureAttribute("I", "protected")]
			public int type_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("I", "protected")]
			public int firstRow_Property
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

			[JniSignatureAttribute("I", "protected")]
			public int lastRow_Property
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

			[JniSignatureAttribute("I", "protected")]
			public int firstColumn_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("I", "protected")]
			public int lastColumn_Property
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

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJTableModelChange(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JTable$AccessibleJTable;IIIII)V", "protected")]
			public AccessibleJTableModelChange(Dova.JDK.javax.swing.JTable.AccessibleJTable arg0, int arg1, int arg2, int arg3, int arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableModelChange;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()I", "public")]
			public int getType()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getFirstColumn()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getLastColumn()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getLastRow()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getFirstRow()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableCell;", "protected")]
		public partial class AccessibleJTableCell
			: Dova.JDK.javax.accessibility.AccessibleContext
			, Dova.JDK.javax.accessibility.Accessible
			, Dova.JDK.javax.accessibility.AccessibleComponent
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJTableCell()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableCell;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljavax/swing/JTable;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "column", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JTable$AccessibleJTable;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable$AccessibleJTable;Ljavax/swing/JTable;III)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAction", "()Ljavax/accessibility/AccessibleAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleText", "()Ljavax/accessibility/AccessibleText;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleValue", "()Ljavax/accessibility/AccessibleValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentComponent", "()Ljava/awt/Component;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleDescription", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleName", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleParent", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/JTable;", "private")]
			public Dova.JDK.javax.swing.JTable parent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int row_Property
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

			[JniSignatureAttribute("I", "private")]
			public int column_Property
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

			[JniSignatureAttribute("I", "private")]
			public int index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable;", "final")]
			public Dova.JDK.javax.swing.JTable.AccessibleJTable this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.AccessibleJTable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJTableCell(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JTable$AccessibleJTable;Ljavax/swing/JTable;III)V", "public")]
			public AccessibleJTableCell(Dova.JDK.javax.swing.JTable.AccessibleJTable arg0, Dova.JDK.javax.swing.JTable arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableCell;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public")]
			public bool contains(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
			public Dova.JDK.java.awt.Rectangle getBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
			public Dova.JDK.java.awt.Point getLocation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
			public Dova.JDK.java.awt.Dimension getSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
			public Dova.JDK.java.util.Locale getLocale()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
			public void setSize(Dova.JDK.java.awt.Dimension arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleAction;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleAction getAccessibleAction()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleAction>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleText;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleText getAccessibleText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleText>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleValue;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleValue getAccessibleValue()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleValue>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "protected")]
			public Dova.JDK.javax.accessibility.AccessibleContext getCurrentAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Component;", "protected")]
			public Dova.JDK.java.awt.Component getCurrentComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
			public void setLocation(Dova.JDK.java.awt.Point arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setForeground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
			public void setFont(Dova.JDK.java.awt.Font arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleDescription(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setEnabled(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setVisible(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleName(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			}

			[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
			public Dova.JDK.java.awt.Font getFont()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void requestFocus()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isShowing()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
			public void setCursor(Dova.JDK.java.awt.Cursor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getForeground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
			public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getBackground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setBackground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
			public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
			public Dova.JDK.java.awt.Point getLocationOnScreen()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isFocusTraversable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleParent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
			public Dova.JDK.java.awt.Cursor getCursor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable$AccessibleTableHeader;", "private")]
		public partial class AccessibleTableHeader
			: Dova.JDK.java.lang.Object
			, Dova.JDK.javax.accessibility.AccessibleTable
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleTableHeader()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$AccessibleJTable$AccessibleTableHeader;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "header", "Ljavax/swing/table/JTableHeader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headerModel", "Ljavax/swing/table/TableColumnModel;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JTable$AccessibleJTable;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable$AccessibleJTable;Ljavax/swing/table/JTableHeader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleCaption", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleCaption", "(Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSummary", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleSummary", "(Ljavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowExtentAt", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnExtentAt", "(II)I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowHeader", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnHeader", "()Ljavax/accessibility/AccessibleTable;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnHeader", "(Ljavax/accessibility/AccessibleTable;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRowDescription", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleRowDescription", "(ILjavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleColumnDescription", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleColumnDescription", "(ILjavax/accessibility/Accessible;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleSelected", "(II)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleRowSelected", "(I)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleColumnSelected", "(I)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleRows", "()[I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectedAccessibleColumns", "()[I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(II)Ljavax/accessibility/Accessible;"));
			}

			[JniSignatureAttribute("Ljavax/swing/table/JTableHeader;", "private")]
			public Dova.JDK.javax.swing.table.JTableHeader header_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.JTableHeader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/table/TableColumnModel;", "private")]
			public Dova.JDK.javax.swing.table.TableColumnModel headerModel_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumnModel>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable;", "final")]
			public Dova.JDK.javax.swing.JTable.AccessibleJTable this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.AccessibleJTable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleTableHeader(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JTable$AccessibleJTable;Ljavax/swing/table/JTableHeader;)V", "")]
			public AccessibleTableHeader(Dova.JDK.javax.swing.JTable.AccessibleJTable arg0, Dova.JDK.javax.swing.table.JTableHeader arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JTable$AccessibleJTable$AccessibleTableHeader;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleCaption()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleCaption(Dova.JDK.javax.accessibility.Accessible arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleSummary()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleSummary(Dova.JDK.javax.accessibility.Accessible arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleRowCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
				return ret;
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleColumnCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "public")]
			public int getAccessibleRowExtentAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(II)I", "public")]
			public int getAccessibleColumnExtentAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleRowHeader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
			public void setAccessibleRowHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleTable;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleTable getAccessibleColumnHeader()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleTable>(ret);
			}

			[JniSignatureAttribute("(Ljavax/accessibility/AccessibleTable;)V", "public")]
			public void setAccessibleColumnHeader(Dova.JDK.javax.accessibility.AccessibleTable arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleRowDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleRowDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleColumnDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("(ILjavax/accessibility/Accessible;)V", "public")]
			public void setAccessibleColumnDescription(int arg0, Dova.JDK.javax.accessibility.Accessible arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
			}

			[JniSignatureAttribute("(II)Z", "public")]
			public bool isAccessibleSelected(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool isAccessibleRowSelected(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
				return ret;
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool isAccessibleColumnSelected(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
				return ret;
			}

			[JniSignatureAttribute("()[I", "public")]
			public JavaArray<int> getSelectedAccessibleRows()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}

			[JniSignatureAttribute("()[I", "public")]
			public JavaArray<int> getSelectedAccessibleColumns()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}

			[JniSignatureAttribute("(II)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(int arg0, int arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableHeaderCell;", "private")]
		public partial class AccessibleJTableHeaderCell
			: Dova.JDK.javax.accessibility.AccessibleContext
			, Dova.JDK.javax.accessibility.Accessible
			, Dova.JDK.javax.accessibility.AccessibleComponent
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJTableHeaderCell()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableHeaderCell;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "column", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljavax/swing/table/JTableHeader;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rendererComponent", "Ljava/awt/Component;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JTable$AccessibleJTable;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTable$AccessibleJTable;IILjavax/swing/table/JTableHeader;Ljava/awt/Component;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleDescription", "()Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAction", "()Ljavax/accessibility/AccessibleAction;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleText", "()Ljavax/accessibility/AccessibleText;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleValue", "()Ljavax/accessibility/AccessibleValue;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentComponent", "()Ljava/awt/Component;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleDescription", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAccessibleName", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleComponent", "()Ljavax/accessibility/AccessibleComponent;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleParent", "()Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("I", "private")]
			public int row_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int column_Property
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

			[JniSignatureAttribute("Ljavax/swing/table/JTableHeader;", "private")]
			public Dova.JDK.javax.swing.table.JTableHeader parent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.JTableHeader>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/awt/Component;", "private")]
			public Dova.JDK.java.awt.Component rendererComponent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JTable$AccessibleJTable;", "final")]
			public Dova.JDK.javax.swing.JTable.AccessibleJTable this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable.AccessibleJTable>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJTableHeaderCell(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JTable$AccessibleJTable;IILjavax/swing/table/JTableHeader;Ljava/awt/Component;)V", "public")]
			public AccessibleJTableHeaderCell(Dova.JDK.javax.swing.JTable.AccessibleJTable arg0, int arg1, int arg2, Dova.JDK.javax.swing.table.JTableHeader arg3, Dova.JDK.java.awt.Component arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JTable$AccessibleJTable$AccessibleJTableHeaderCell;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public")]
			public bool contains(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public")]
			public Dova.JDK.java.awt.Rectangle getBounds()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
			public Dova.JDK.java.awt.Point getLocation()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
			public Dova.JDK.java.awt.Dimension getSize()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
			}

			[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
			public Dova.JDK.java.util.Locale getLocale()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public")]
			public void setSize(Dova.JDK.java.awt.Dimension arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isEnabled()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleDescription()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleAction;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleAction getAccessibleAction()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleAction>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleText;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleText getAccessibleText()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleText>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleValue;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleValue getAccessibleValue()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleValue>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "private")]
			public Dova.JDK.javax.accessibility.AccessibleContext getCurrentAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Component;", "private")]
			public Dova.JDK.java.awt.Component getCurrentComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
			public void setLocation(Dova.JDK.java.awt.Point arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setForeground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
			public void setFont(Dova.JDK.java.awt.Font arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleDescription(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setEnabled(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setVisible(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleName(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			}

			[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
			public Dova.JDK.java.awt.Font getFont()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void requestFocus()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isShowing()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
			public void setCursor(Dova.JDK.java.awt.Cursor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getForeground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
			public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getBackground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setBackground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
			public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
			public Dova.JDK.java.awt.Point getLocationOnScreen()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isFocusTraversable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleParent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[43]);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
			public Dova.JDK.java.awt.Cursor getCursor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$BooleanEditor;", "static")]
	public partial class BooleanEditor
		: Dova.JDK.javax.swing.DefaultCellEditor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BooleanEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$BooleanEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BooleanEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public BooleanEditor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$BooleanEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$NumberEditor;", "static")]
	public partial class NumberEditor
		: Dova.JDK.javax.swing.JTable.GenericEditor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumberEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$NumberEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumberEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public NumberEditor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$NumberEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$GenericEditor;", "static")]
	public partial class GenericEditor
		: Dova.JDK.javax.swing.DefaultCellEditor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GenericEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$GenericEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "argTypes", "[Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Ljava/lang/reflect/Constructor;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopCellEditing", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellEditorValue", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellEditorComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("[Ljava/lang/Class;", "")]
		public JavaArray<Dova.JDK.java.lang.Class> argTypes_Property
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

		[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "")]
		public Dova.JDK.java.lang.reflect.Constructor constructor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GenericEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public GenericEditor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$GenericEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool stopCellEditing()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getCellEditorValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellEditorComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$BooleanRenderer;", "static")]
	public partial class BooleanRenderer
		: Dova.JDK.javax.swing.JCheckBox
		, Dova.JDK.javax.swing.table.TableCellRenderer
		, Dova.JDK.javax.swing.plaf.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BooleanRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$BooleanRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noFocusBorder", "Ljavax/swing/border/Border;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellRendererComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private static final")]
		public static Dova.JDK.javax.swing.border.Border noFocusBorder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BooleanRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public BooleanRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$BooleanRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellRendererComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$IconRenderer;", "static")]
	public partial class IconRenderer
		: Dova.JDK.javax.swing.table.DefaultTableCellRenderer.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static IconRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$IconRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public IconRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public IconRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$IconRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void setValue(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$DateRenderer;", "static")]
	public partial class DateRenderer
		: Dova.JDK.javax.swing.table.DefaultTableCellRenderer.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DateRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$DateRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "formatter", "Ljava/text/DateFormat;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/text/DateFormat;", "")]
		public Dova.JDK.java.text.DateFormat formatter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DateRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DateRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$DateRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void setValue(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$DoubleRenderer;", "static")]
	public partial class DoubleRenderer
		: Dova.JDK.javax.swing.JTable.NumberRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DoubleRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$DoubleRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "formatter", "Ljava/text/NumberFormat;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/lang/Object;)V"));
		}

		[JniSignatureAttribute("Ljava/text/NumberFormat;", "")]
		public Dova.JDK.java.text.NumberFormat formatter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.text.NumberFormat>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DoubleRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DoubleRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$DoubleRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "public")]
		public void setValue(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable$NumberRenderer;", "static")]
	public partial class NumberRenderer
		: Dova.JDK.javax.swing.table.DefaultTableCellRenderer.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumberRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTable$NumberRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumberRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public NumberRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTable$NumberRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
