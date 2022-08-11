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

[JniSignatureAttribute("Ljavax/swing/JTree;", "public")]
public partial class JTree
	: Dova.JDK.javax.swing.JComponent
	, Dova.JDK.javax.swing.Scrollable
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeModel", "Ljavax/swing/tree/TreeModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionModel", "Ljavax/swing/tree/TreeSelectionModel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootVisible", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellRenderer", "Ljavax/swing/tree/TreeCellRenderer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowHeight", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowHeightSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandedState", "Ljava/util/Hashtable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showsRootHandles", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showsRootHandlesSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selectionRedirector", "Ljavax/swing/JTree$TreeSelectionRedirector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellEditor", "Ljavax/swing/tree/TreeCellEditor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "editable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "largeModel", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "visibleRowCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "invokesStopCellEditing", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scrollsOnExpand", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "scrollsOnExpandSet", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toggleClickCount", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeModelListener", "Ljavax/swing/event/TreeModelListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandedStack", "Ljava/util/Stack;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadPath", "Ljavax/swing/tree/TreePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "anchorPath", "Ljavax/swing/tree/TreePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandsSelectedPaths", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "settingUI", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dragEnabled", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropMode", "Ljavax/swing/DropMode;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropLocation", "Ljavax/swing/JTree$DropLocation;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateInProgress", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expandRow", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dropTimer", "Ljavax/swing/JTree$TreeTimer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uiTreeExpansionListener", "Ljavax/swing/event/TreeExpansionListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEMP_STACK_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CELL_RENDERER_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TREE_MODEL_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROOT_VISIBLE_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHOWS_ROOT_HANDLES_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROW_HEIGHT_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CELL_EDITOR_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EDITABLE_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LARGE_MODEL_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SELECTION_MODEL_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VISIBLE_ROW_COUNT_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKES_STOP_CELL_EDITING_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCROLLS_ON_EXPAND_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOGGLE_CLICK_COUNT_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEAD_SELECTION_PATH_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANCHOR_SELECTION_PATH_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPANDS_SELECTED_PATHS_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Vector;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Hashtable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/tree/TreeNode;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/tree/TreeNode;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/tree/TreeModel;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEditable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCellRenderer", "(Ljavax/swing/tree/TreeCellRenderer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTreeWillExpandListener", "(Ljavax/swing/event/TreeWillExpandListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastSelectedPathComponent", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasBeenExpanded", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setShowsRootHandles", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRootVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpanded", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpanded", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionPath", "()Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearSelection", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionModel", "()Ljavax/swing/tree/TreeSelectionModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelectionEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVisibleRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisibleRowCount", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextMatch", "(Ljava/lang/String;ILjavax/swing/text/Position$Bias;)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultTreeModel", "()Ljavax/swing/tree/TreeModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createTreeModel", "(Ljava/lang/Object;)Ljavax/swing/tree/TreeModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandRoot", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearToggledPaths", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTreeModelListener", "()Ljavax/swing/event/TreeModelListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClosestRowForLocation", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowBounds", "(I)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathForRow", "(I)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelDropTimer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCollapsed", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCollapsed", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startDropTimer", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAnchorSelectionPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLeadSelectionPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionPaths", "()[Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnchorSelectionPath", "()Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadSelectionPath", "()Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowForLocation", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathBounds", "(Ljavax/swing/tree/TreePath;)Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionRows", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionRows", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionRows", "()[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinSelectionRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaxSelectionRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowForPath", "(Ljavax/swing/tree/TreePath;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPathSelected", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "expandPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeVisible", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollPathToVisible", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpandedState", "(Ljavax/swing/tree/TreePath;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collapsePath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClosestPathForLocation", "(II)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathForLocation", "(II)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stopEditing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cancelEditing", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startEditingAtPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditingPath", "()Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathBetweenRows", "(II)[Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionPath", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionRows", "([I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertValueToText", "(Ljava/lang/Object;ZZZIZ)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArchivableExpandedState", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unarchiveExpandedState", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModelIndexsForPath", "(Ljavax/swing/tree/TreePath;)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathForIndexs", "([I)Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedRowHeight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireTreeWillExpand", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireTreeExpanded", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireTreeWillCollapse", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireTreeCollapsed", "(Ljavax/swing/tree/TreePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDescendantSelectedPaths", "(Ljavax/swing/event/TreeModelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDescendantSelectedPaths", "(Ljavax/swing/tree/TreePath;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescendantToggledPaths", "(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescendantSelectedPaths", "(Ljavax/swing/tree/TreePath;Z)[Ljavax/swing/tree/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setScrollsOnExpand", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRootVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShowsRootHandles", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLargeModel", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLargeModel", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInvokesStopCellEditing", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInvokesStopCellEditing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollsOnExpand", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setToggleClickCount", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToggleClickCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setExpandsSelectedPaths", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpandsSelectedPaths", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPathEditable", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadSelectionRow", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpandedDescendants", "(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scrollRowToVisible", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "collapseRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionRow", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTreeExpansionListener", "(Ljavax/swing/event/TreeExpansionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTreeExpansionListener", "(Ljavax/swing/event/TreeExpansionListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreeExpansionListeners", "()[Ljavax/swing/event/TreeExpansionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTreeWillExpandListener", "(Ljavax/swing/event/TreeWillExpandListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreeWillExpandListeners", "()[Ljavax/swing/event/TreeWillExpandListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreeSelectionListeners", "()[Ljavax/swing/event/TreeSelectionListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireValueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeDidChange", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeDescendantToggledPaths", "(Ljava/util/Enumeration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellRenderer", "()Ljavax/swing/tree/TreeCellRenderer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCellEditor", "()Ljavax/swing/tree/TreeCellEditor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCellEditor", "(Ljavax/swing/tree/TreeCellEditor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDragEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDragEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDropMode", "(Ljavax/swing/DropMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDropMode", "()Ljavax/swing/DropMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDropLocation", "()Ljavax/swing/JTree$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredScrollableViewportSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableUnitIncrement", "(Ljava/awt/Rectangle;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableBlockIncrement", "(Ljava/awt/Rectangle;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportWidth", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScrollableTracksViewportHeight", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "(Ljavax/swing/tree/TreePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUI", "(Ljavax/swing/plaf/TreeUI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_0", "()Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUI_1", "()Ljavax/swing/plaf/TreeUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getToolTipText", "(Ljava/awt/event/MouseEvent;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropLocationForPoint_0", "(Ljava/awt/Point;)Ljavax/swing/JTree$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropLocationForPoint_1", "(Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDropLocation", "(Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dndDone", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUIProperty", "(Ljava/lang/String;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionModel", "(Ljavax/swing/tree/TreeSelectionModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setModel", "(Ljavax/swing/tree/TreeModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowHeight", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowHeight", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModel", "()Ljavax/swing/tree/TreeModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkDragEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkDropMode", "(Ljavax/swing/DropMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEditing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionInterval", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isRowSelected", "(I)Z"));
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

	[JniSignatureAttribute("Ljavax/swing/tree/TreeModel;", "protected transient")]
	public Dova.JDK.javax.swing.tree.TreeModel treeModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreeSelectionModel;", "protected transient")]
	public Dova.JDK.javax.swing.tree.TreeSelectionModel selectionModel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeSelectionModel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool rootVisible_Property
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

	[JniSignatureAttribute("Ljavax/swing/tree/TreeCellRenderer;", "protected transient")]
	public Dova.JDK.javax.swing.tree.TreeCellRenderer cellRenderer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeCellRenderer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int rowHeight_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool rowHeightSet_Property
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

	[JniSignatureAttribute("Ljava/util/Hashtable;", "private transient")]
	public Dova.JDK.java.util.Hashtable expandedState_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool showsRootHandles_Property
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
	public bool showsRootHandlesSet_Property
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

	[JniSignatureAttribute("Ljavax/swing/JTree$TreeSelectionRedirector;", "protected transient")]
	public Dova.JDK.javax.swing.JTree.TreeSelectionRedirector selectionRedirector_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.TreeSelectionRedirector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreeCellEditor;", "protected transient")]
	public Dova.JDK.javax.swing.tree.TreeCellEditor cellEditor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeCellEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool editable_Property
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

	[JniSignatureAttribute("Z", "protected")]
	public bool largeModel_Property
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

	[JniSignatureAttribute("I", "protected")]
	public int visibleRowCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[14]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[14], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool invokesStopCellEditing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
		}
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool scrollsOnExpand_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool scrollsOnExpandSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int toggleClickCount_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[18]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[18], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/TreeModelListener;", "protected transient")]
	public Dova.JDK.javax.swing.@event.TreeModelListener treeModelListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.TreeModelListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Stack;", "private transient")]
	public Dova.JDK.java.util.Stack expandedStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreePath;", "private")]
	public Dova.JDK.javax.swing.tree.TreePath leadPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/tree/TreePath;", "private")]
	public Dova.JDK.javax.swing.tree.TreePath anchorPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool expandsSelectedPaths_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool settingUI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[24]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[24], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool dragEnabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[25]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[25], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/DropMode;", "private")]
	public Dova.JDK.javax.swing.DropMode dropMode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DropMode>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$DropLocation;", "private transient")]
	public Dova.JDK.javax.swing.JTree.DropLocation dropLocation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.DropLocation>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private transient")]
	public bool updateInProgress_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int expandRow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[29]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[29], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$TreeTimer;", "private")]
	public Dova.JDK.javax.swing.JTree.TreeTimer dropTimer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.TreeTimer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/event/TreeExpansionListener;", "private transient")]
	public Dova.JDK.javax.swing.@event.TreeExpansionListener uiTreeExpansionListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.TreeExpansionListener>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static")]
	public static int TEMP_STACK_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[32]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[32], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CELL_RENDERER_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String TREE_MODEL_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ROOT_VISIBLE_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SHOWS_ROOT_HANDLES_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ROW_HEIGHT_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String CELL_EDITOR_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EDITABLE_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String LARGE_MODEL_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SELECTION_MODEL_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String VISIBLE_ROW_COUNT_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String INVOKES_STOP_CELL_EDITING_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String SCROLLS_ON_EXPAND_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String TOGGLE_CLICK_COUNT_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String LEAD_SELECTION_PATH_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ANCHOR_SELECTION_PATH_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String EXPANDS_SELECTED_PATHS_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[49]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[49], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JTree(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)V", "public")]
	public JTree(JavaArray<Dova.JDK.java.lang.Object> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Vector;)V", "public")]
	public JTree(Dova.JDK.java.util.Vector arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/util/Hashtable;)V", "public")]
	public JTree(Dova.JDK.java.util.Hashtable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeNode;)V", "public")]
	public JTree(Dova.JDK.javax.swing.tree.TreeNode arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeNode;Z)V", "public")]
	public JTree(Dova.JDK.javax.swing.tree.TreeNode arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeModel;)V", "public")]
	public JTree(Dova.JDK.javax.swing.tree.TreeModel arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JTree() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JTree;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEditable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEditable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeCellRenderer;)V", "public")]
	public void setCellRenderer(Dova.JDK.javax.swing.tree.TreeCellRenderer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public")]
	public void addTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeWillExpandListener;)V", "public")]
	public void addTreeWillExpandListener(Dova.JDK.javax.swing.@event.TreeWillExpandListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getLastSelectedPathComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool hasBeenExpanded(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setShowsRootHandles(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setRootVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool isExpanded(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isExpanded(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getSelectionPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void setSelectionPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void clearSelection()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeSelectionModel;", "public")]
	public Dova.JDK.javax.swing.tree.TreeSelectionModel getSelectionModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeSelectionModel>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSelectionEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getVisibleRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setVisibleRowCount(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjavax/swing/text/Position$Bias;)Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getNextMatch(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeModel;", "protected static")]
	public static Dova.JDK.javax.swing.tree.TreeModel getDefaultTreeModel()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljavax/swing/tree/TreeModel;", "protected static")]
	public static Dova.JDK.javax.swing.tree.TreeModel createTreeModel(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void expandRoot()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void expandRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void clearToggledPaths()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()Ljavax/swing/event/TreeModelListener;", "protected")]
	public Dova.JDK.javax.swing.@event.TreeModelListener createTreeModelListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.TreeModelListener>(ret);
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getClosestRowForLocation(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getRowBounds(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getPathForRow(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void cancelDropTimer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32]);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool isCollapsed(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isCollapsed(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void startDropTimer()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35]);
	}

	[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
	public void setSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void setAnchorSelectionPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void setLeadSelectionPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/tree/TreePath;", "public")]
	public JavaArray<Dova.JDK.javax.swing.tree.TreePath> getSelectionPaths()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.tree.TreePath>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getAnchorSelectionPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getLeadSelectionPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getRowForLocation(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Ljava/awt/Rectangle;", "public")]
	public Dova.JDK.java.awt.Rectangle getPathBounds(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void setSelectionRows(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void addSelectionPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
	public void addSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void addSelectionRows(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getSelectionRows()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectionCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[49]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinSelectionRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMaxSelectionRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[51]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)I", "public")]
	public int getRowForPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool isPathSelected(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void expandPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void makeVisible(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void scrollPathToVisible(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Z)V", "protected")]
	public void setExpandedState(Dova.JDK.javax.swing.tree.TreePath arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void collapsePath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getClosestPathForLocation(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getPathForLocation(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool stopEditing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61]);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void cancelEditing()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62]);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void startEditingAtPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreePath;", "public")]
	public Dova.JDK.javax.swing.tree.TreePath getEditingPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public")]
	public void removeTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
	}

	[JniSignatureAttribute("(II)[Ljavax/swing/tree/TreePath;", "protected")]
	public JavaArray<Dova.JDK.javax.swing.tree.TreePath> getPathBetweenRows(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.tree.TreePath>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
	public void removeSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void removeSelectionPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
	}

	[JniSignatureAttribute("([I)V", "public")]
	public void removeSelectionRows(JavaArray<int> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;ZZZIZ)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String convertValueToText(Dova.JDK.java.lang.Object arg0, bool arg1, bool arg2, bool arg3, int arg4, bool arg5)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getArchivableExpandedState()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "private")]
	public void unarchiveExpandedState(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)[I", "private")]
	public JavaArray<int> getModelIndexsForPath(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("([I)Ljavax/swing/tree/TreePath;", "private")]
	public Dova.JDK.javax.swing.tree.TreePath getPathForIndexs(JavaArray<int> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFixedRowHeight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void fireTreeWillExpand(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void fireTreeExpanded(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void fireTreeWillCollapse(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)V", "public")]
	public void fireTreeCollapsed(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[79], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "")]
	public void removeDescendantSelectedPaths(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[80], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Z)Z", "protected")]
	public bool removeDescendantSelectedPaths(Dova.JDK.javax.swing.tree.TreePath arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;", "protected")]
	public Dova.JDK.java.util.Enumeration getDescendantToggledPaths(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Z)[Ljavax/swing/tree/TreePath;", "private")]
	public JavaArray<Dova.JDK.javax.swing.tree.TreePath> getDescendantSelectedPaths(Dova.JDK.javax.swing.tree.TreePath arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.tree.TreePath>>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setScrollsOnExpand(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isRootVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[85]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getShowsRootHandles()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[86]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setLargeModel(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLargeModel()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[88]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setInvokesStopCellEditing(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getInvokesStopCellEditing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[90]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollsOnExpand()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[91]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setToggleClickCount(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getToggleClickCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[93]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setExpandsSelectedPaths(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getExpandsSelectedPaths()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[95]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool isPathEditable(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setSelectionRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[97], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void addSelectionRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[98], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getLeadSelectionRow()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[99]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getExpandedDescendants(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void scrollRowToVisible(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[101], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void collapseRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[102], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void removeSelectionRow(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[103], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionListener;)V", "public")]
	public void addTreeExpansionListener(Dova.JDK.javax.swing.@event.TreeExpansionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[104], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionListener;)V", "public")]
	public void removeTreeExpansionListener(Dova.JDK.javax.swing.@event.TreeExpansionListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[105], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/TreeExpansionListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.TreeExpansionListener> getTreeExpansionListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[106]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.TreeExpansionListener>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeWillExpandListener;)V", "public")]
	public void removeTreeWillExpandListener(Dova.JDK.javax.swing.@event.TreeWillExpandListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[107], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/TreeWillExpandListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.TreeWillExpandListener> getTreeWillExpandListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[108]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.TreeWillExpandListener>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/TreeSelectionListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.TreeSelectionListener> getTreeSelectionListeners()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[109]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.TreeSelectionListener>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "protected")]
	public void fireValueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[110], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void treeDidChange()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[111]);
	}

	[JniSignatureAttribute("(Ljava/util/Enumeration;)V", "protected")]
	public void removeDescendantToggledPaths(Dova.JDK.java.util.Enumeration arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[112], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeCellRenderer;", "public")]
	public Dova.JDK.javax.swing.tree.TreeCellRenderer getCellRenderer()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[113]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeCellRenderer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeCellEditor;", "public")]
	public Dova.JDK.javax.swing.tree.TreeCellEditor getCellEditor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[114]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeCellEditor>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeCellEditor;)V", "public")]
	public void setCellEditor(Dova.JDK.javax.swing.tree.TreeCellEditor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[115], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setDragEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[116], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getDragEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[117]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/DropMode;)V", "public final")]
	public void setDropMode(Dova.JDK.javax.swing.DropMode arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[118], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/DropMode;", "public final")]
	public Dova.JDK.javax.swing.DropMode getDropMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[119]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.DropMode>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/JTree$DropLocation;", "public final")]
	public Dova.JDK.javax.swing.JTree.DropLocation getDropLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[120]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.DropLocation>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredScrollableViewportSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[121]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;II)I", "public")]
	public int getScrollableUnitIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[122], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;II)I", "public")]
	public int getScrollableBlockIncrement(Dova.JDK.java.awt.Rectangle arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[123], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportWidth()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[124]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getScrollableTracksViewportHeight()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[125]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;)Z", "public")]
	public bool isVisible(Dova.JDK.javax.swing.tree.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[126], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[127]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/TreeUI;)V", "public")]
	public void setUI(Dova.JDK.javax.swing.plaf.TreeUI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[128], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/ComponentUI;", "public volatile")]
	public Dova.JDK.javax.swing.plaf.ComponentUI getUI_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[129]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/plaf/TreeUI;", "public")]
	public Dova.JDK.javax.swing.plaf.TreeUI getUI_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[130]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.TreeUI>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[131]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[132]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getToolTipText(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[133], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/swing/JTree$DropLocation;", "")]
	public Dova.JDK.javax.swing.JTree.DropLocation dropLocationForPoint_0(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[134], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.DropLocation>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/swing/TransferHandler$DropLocation;", "volatile")]
	public Dova.JDK.javax.swing.TransferHandler.DropLocation dropLocationForPoint_1(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[135], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.TransferHandler.DropLocation>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/TransferHandler$DropLocation;Ljava/lang/Object;Z)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object setDropLocation(Dova.JDK.javax.swing.TransferHandler.DropLocation arg0, Dova.JDK.java.lang.Object arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[136], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void dndDone()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[137]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)V", "")]
	public void setUIProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[138], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeSelectionModel;)V", "public")]
	public void setSelectionModel(Dova.JDK.javax.swing.tree.TreeSelectionModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[139], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/tree/TreeModel;)V", "public")]
	public void setModel(Dova.JDK.javax.swing.tree.TreeModel arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[140], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setRowHeight(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[141], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowHeight()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[142]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/tree/TreeModel;", "public")]
	public Dova.JDK.javax.swing.tree.TreeModel getModel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[143]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
	}

	[JniSignatureAttribute("(Z)V", "private static")]
	public static void checkDragEnabled(bool arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[144], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/DropMode;)V", "private static")]
	public static void checkDropMode(Dova.JDK.javax.swing.DropMode arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[145], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isEditing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[146]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void setSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[147], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void addSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[148], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void removeSelectionInterval(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[149], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Z", "public")]
	public bool isRowSelected(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[150], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$DynamicUtilTreeNode;", "public static")]
	public partial class DynamicUtilTreeNode
		: Dova.JDK.javax.swing.tree.DefaultMutableTreeNode
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DynamicUtilTreeNode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$DynamicUtilTreeNode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasChildren", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "childValue", "Ljava/lang/Object;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "loadedChildren", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Object;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "children", "()Ljava/util/Enumeration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeaf", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createChildren", "(Ljavax/swing/tree/DefaultMutableTreeNode;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildAt", "(I)Ljavax/swing/tree/TreeNode;"));
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool hasChildren_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "protected")]
		public Dova.JDK.java.lang.Object childValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool loadedChildren_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DynamicUtilTreeNode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)V", "public")]
		public DynamicUtilTreeNode(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$DynamicUtilTreeNode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
		public Dova.JDK.java.util.Enumeration children()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isLeaf()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected")]
		public void loadChildren()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljavax/swing/tree/DefaultMutableTreeNode;Ljava/lang/Object;)V", "public static")]
		public static void createChildren(Dova.JDK.javax.swing.tree.DefaultMutableTreeNode arg0, Dova.JDK.java.lang.Object arg1)
		{
			DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getChildCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/swing/tree/TreeNode;", "public")]
		public Dova.JDK.javax.swing.tree.TreeNode getChildAt(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeNode>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$AccessibleJTree;", "protected")]
	public partial class AccessibleJTree
		: Dova.JDK.javax.swing.JComponent.AccessibleJComponent
		, Dova.JDK.javax.accessibility.AccessibleSelection
		, Dova.JDK.javax.swing.@event.TreeSelectionListener
		, Dova.JDK.javax.swing.@event.TreeModelListener
		, Dova.JDK.javax.swing.@event.TreeExpansionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJTree()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$AccessibleJTree;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadSelectionPath", "Ljavax/swing/tree/TreePath;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadSelectionAccessible", "Ljavax/accessibility/Accessible;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentComponent", "()Ljava/awt/Component;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelectionCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAccessibleSelection", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectAllAccessibleSelection", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireVisibleDataPropertyChange", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireActiveDescendantPropertyChange", "(Ljavax/swing/tree/TreePath;Ljavax/swing/tree/TreePath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeExpanded", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeCollapsed", "(Ljavax/swing/event/TreeExpansionEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChildrenCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleChild", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "()Ljavax/accessibility/AccessibleSelection;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "(I)Ljavax/accessibility/Accessible;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleChildSelected", "(I)Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/tree/TreePath;", "")]
		public Dova.JDK.javax.swing.tree.TreePath leadSelectionPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "")]
		public Dova.JDK.javax.accessibility.Accessible leadSelectionAccessible_Property
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

		[JniSignatureAttribute("Ljavax/swing/JTree;", "final")]
		public Dova.JDK.javax.swing.JTree this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJTree(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTree;)V", "public")]
		public AccessibleJTree(Dova.JDK.javax.swing.JTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$AccessibleJTree;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "private")]
		public Dova.JDK.javax.accessibility.AccessibleContext getCurrentAccessibleContext()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Component;", "private")]
		public Dova.JDK.java.awt.Component getCurrentComponent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "public")]
		public void valueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleSelectionCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void addAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void removeAccessibleSelection(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void clearAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void selectAllAccessibleSelection()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void fireVisibleDataPropertyChange()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("(Ljavax/swing/tree/TreePath;Ljavax/swing/tree/TreePath;)V", "")]
		public void fireActiveDescendantPropertyChange(Dova.JDK.javax.swing.tree.TreePath arg0, Dova.JDK.javax.swing.tree.TreePath arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
		public void treeExpanded(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeExpansionEvent;)V", "public")]
		public void treeCollapsed(Dova.JDK.javax.swing.@event.TreeExpansionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesInserted(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesRemoved(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeStructureChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleChildrenCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
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

		[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
		public Dova.JDK.javax.accessibility.Accessible getAccessibleSelection(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAccessibleIndexInParent()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22]);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "public")]
		public bool isAccessibleChildSelected(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return ret;
		}

		[JniSignatureAttribute("Ljavax/swing/JTree$AccessibleJTree$AccessibleJTreeNode;", "protected")]
		public partial class AccessibleJTreeNode
			: Dova.JDK.javax.accessibility.AccessibleContext
			, Dova.JDK.javax.accessibility.Accessible
			, Dova.JDK.javax.accessibility.AccessibleComponent
			, Dova.JDK.javax.accessibility.AccessibleSelection
			, Dova.JDK.javax.accessibility.AccessibleAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AccessibleJTreeNode()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$AccessibleJTree$AccessibleJTreeNode;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Ljavax/swing/JTree;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treeModel", "Ljavax/swing/tree/TreeModel;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "obj", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljavax/swing/tree/TreePath;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "accessibleParent", "Ljavax/accessibility/Accessible;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isLeaf", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$1", "Ljavax/swing/JTree$AccessibleJTree;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTree$AccessibleJTree;Ljavax/swing/JTree;Ljavax/swing/tree/TreePath;Ljavax/accessibility/Accessible;)V"));
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
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationInJTree", "()Ljava/awt/Point;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildTreePath", "(I)Ljavax/swing/tree/TreePath;"));
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
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelectionCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAccessibleSelection", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeAccessibleSelection", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearAccessibleSelection", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "selectAllAccessibleSelection", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionCount", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleActionDescription", "(I)Ljava/lang/String;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doAccessibleAction", "(I)Z"));
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
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleSelection", "(I)Ljavax/accessibility/Accessible;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleIndexInParent", "()I"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessibleChildSelected", "(I)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleStateSet", "()Ljavax/accessibility/AccessibleStateSet;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleName", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/JTree;", "private")]
			public Dova.JDK.javax.swing.JTree tree_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/tree/TreeModel;", "private")]
			public Dova.JDK.javax.swing.tree.TreeModel treeModel_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreeModel>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "private")]
			public Dova.JDK.java.lang.Object obj_Property
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

			[JniSignatureAttribute("Ljavax/swing/tree/TreePath;", "private")]
			public Dova.JDK.javax.swing.tree.TreePath path_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/accessibility/Accessible;", "private")]
			public Dova.JDK.javax.accessibility.Accessible accessibleParent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("I", "private")]
			public int index_Property
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

			[JniSignatureAttribute("Z", "private")]
			public bool isLeaf_Property
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

			[JniSignatureAttribute("Ljavax/swing/JTree$AccessibleJTree;", "final")]
			public Dova.JDK.javax.swing.JTree.AccessibleJTree this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.AccessibleJTree>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AccessibleJTreeNode(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/JTree$AccessibleJTree;Ljavax/swing/JTree;Ljavax/swing/tree/TreePath;Ljavax/accessibility/Accessible;)V", "public")]
			public AccessibleJTreeNode(Dova.JDK.javax.swing.JTree.AccessibleJTree arg0, Dova.JDK.javax.swing.JTree arg1, Dova.JDK.javax.swing.tree.TreePath arg2, Dova.JDK.javax.accessibility.Accessible arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/JTree$AccessibleJTree$AccessibleJTreeNode;";
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

			[JniSignatureAttribute("()Ljava/awt/Point;", "protected")]
			public Dova.JDK.java.awt.Point getLocationInJTree()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("(I)Ljavax/swing/tree/TreePath;", "private")]
			public Dova.JDK.javax.swing.tree.TreePath getChildTreePath(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)V", "public")]
			public void setLocation(Dova.JDK.java.awt.Point arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setForeground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
			public void setFont(Dova.JDK.java.awt.Font arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleDescription(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setEnabled(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			}

			[JniSignatureAttribute("(Z)V", "public")]
			public void setVisible(bool arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
			public void setAccessibleName(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			}

			[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
			public Dova.JDK.java.awt.Font getFont()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
			}

			[JniSignatureAttribute("()V", "public")]
			public void requestFocus()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25]);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleSelectionCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
				return ret;
			}

			[JniSignatureAttribute("(I)V", "public")]
			public void addAccessibleSelection(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
			}

			[JniSignatureAttribute("(I)V", "public")]
			public void removeAccessibleSelection(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			}

			[JniSignatureAttribute("()V", "public")]
			public void clearAccessibleSelection()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
			}

			[JniSignatureAttribute("()V", "public")]
			public void selectAllAccessibleSelection()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30]);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleActionCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleActionDescription(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool doAccessibleAction(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isVisible()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[34]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isShowing()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[36]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
			public void setCursor(Dova.JDK.java.awt.Cursor arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getForeground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public")]
			public Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
			public Dova.JDK.java.awt.Color getBackground()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
			public void setBackground(Dova.JDK.java.awt.Color arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public")]
			public void setBounds(Dova.JDK.java.awt.Rectangle arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleChildrenCount()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[44]);
				return ret;
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleChild(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleComponent;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleComponent getAccessibleComponent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleComponent>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljava/awt/Point;", "public")]
			public Dova.JDK.java.awt.Point getLocationOnScreen()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isFocusTraversable()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[49]);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
			public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleParent()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleSelection;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleSelection getAccessibleSelection()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleSelection>(ret);
			}

			[JniSignatureAttribute("(I)Ljavax/accessibility/Accessible;", "public")]
			public Dova.JDK.javax.accessibility.Accessible getAccessibleSelection(int arg0)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
			}

			[JniSignatureAttribute("()I", "public")]
			public int getAccessibleIndexInParent()
			{
				var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[54]);
				return ret;
			}

			[JniSignatureAttribute("(I)Z", "public")]
			public bool isAccessibleChildSelected(int arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
				return ret;
			}

			[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
			public Dova.JDK.java.awt.Cursor getCursor()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public")]
			public void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
			}

			[JniSignatureAttribute("()Ljavax/accessibility/AccessibleStateSet;", "public")]
			public Dova.JDK.javax.accessibility.AccessibleStateSet getAccessibleStateSet()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleStateSet>(ret);
			}

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String getAccessibleName()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$DropLocation;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$DropLocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljavax/swing/tree/TreePath;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/Point;Ljavax/swing/tree/TreePath;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "()Ljavax/swing/tree/TreePath;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChildIndex", "()I"));
		}

		[JniSignatureAttribute("Ljavax/swing/tree/TreePath;", "private final")]
		public Dova.JDK.javax.swing.tree.TreePath path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int index_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DropLocation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/awt/Point;Ljavax/swing/tree/TreePath;I)V", "private")]
		public DropLocation(Dova.JDK.java.awt.Point arg0, Dova.JDK.javax.swing.tree.TreePath arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$DropLocation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/tree/TreePath;", "public")]
		public Dova.JDK.javax.swing.tree.TreePath getPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.tree.TreePath>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getChildIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$TreeTimer;", "private")]
	public partial class TreeTimer
		: Dova.JDK.javax.swing.Timer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TreeTimer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$TreeTimer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fireActionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTree;", "final")]
		public Dova.JDK.javax.swing.JTree this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TreeTimer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTree;)V", "public")]
		public TreeTimer(Dova.JDK.javax.swing.JTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$TreeTimer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void fireActionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$EmptySelectionModel;", "protected static")]
	public partial class EmptySelectionModel
		: Dova.JDK.javax.swing.tree.DefaultTreeSelectionModel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EmptySelectionModel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$EmptySelectionModel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sharedInstance", "Ljavax/swing/JTree$EmptySelectionModel;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionMode", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeTreeSelectionListener", "(Ljavax/swing/event/TreeSelectionListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeSelectionPaths", "([Ljavax/swing/tree/TreePath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRowMapper", "(Ljavax/swing/tree/RowMapper;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sharedInstance", "()Ljavax/swing/JTree$EmptySelectionModel;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removePropertyChangeListener", "(Ljava/beans/PropertyChangeListener;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTree$EmptySelectionModel;", "protected static final")]
		public static Dova.JDK.javax.swing.JTree.EmptySelectionModel sharedInstance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.EmptySelectionModel>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EmptySelectionModel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public EmptySelectionModel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$EmptySelectionModel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public")]
		public void addTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setSelectionMode(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
		public void setSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
		public void addSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionListener;)V", "public")]
		public void removeTreeSelectionListener(Dova.JDK.javax.swing.@event.TreeSelectionListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("([Ljavax/swing/tree/TreePath;)V", "public")]
		public void removeSelectionPaths(JavaArray<Dova.JDK.javax.swing.tree.TreePath> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/tree/RowMapper;)V", "public")]
		public void setRowMapper(Dova.JDK.javax.swing.tree.RowMapper arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
		public void addPropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljavax/swing/JTree$EmptySelectionModel;", "public static")]
		public static Dova.JDK.javax.swing.JTree.EmptySelectionModel sharedInstance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree.EmptySelectionModel>(ret);
		}

		[JniSignatureAttribute("(Ljava/beans/PropertyChangeListener;)V", "public")]
		public void removePropertyChangeListener(Dova.JDK.java.beans.PropertyChangeListener arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$TreeSelectionRedirector;", "protected")]
	public partial class TreeSelectionRedirector
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.io.Serializable
		, Dova.JDK.javax.swing.@event.TreeSelectionListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TreeSelectionRedirector()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$TreeSelectionRedirector;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "valueChanged", "(Ljavax/swing/event/TreeSelectionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTree;", "final")]
		public Dova.JDK.javax.swing.JTree this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TreeSelectionRedirector(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTree;)V", "protected")]
		public TreeSelectionRedirector(Dova.JDK.javax.swing.JTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$TreeSelectionRedirector;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/TreeSelectionEvent;)V", "public")]
		public void valueChanged(Dova.JDK.javax.swing.@event.TreeSelectionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTree$TreeModelHandler;", "protected")]
	public partial class TreeModelHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.TreeModelListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TreeModelHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTree$TreeModelHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesInserted", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeNodesRemoved", "(Ljavax/swing/event/TreeModelEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "treeStructureChanged", "(Ljavax/swing/event/TreeModelEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTree;", "final")]
		public Dova.JDK.javax.swing.JTree this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TreeModelHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTree;)V", "protected")]
		public TreeModelHandler(Dova.JDK.javax.swing.JTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JTree$TreeModelHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesInserted(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeNodesRemoved(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/TreeModelEvent;)V", "public")]
		public void treeStructureChanged(Dova.JDK.javax.swing.@event.TreeModelEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
