/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.javax.swing.table;

[JniSignatureAttribute("Ljavax/swing/table/DefaultTableColumnModel;", "public")]
public partial class DefaultTableColumnModel
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.swing.table.TableColumnModel
	, Dova.JDK.java.beans.PropertyChangeListener
	, Dova.JDK.javax.swing.@event.ListSelectionListener
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultTableColumnModel()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/swing/table/DefaultTableColumnModel;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "tableColumns", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "selectionModel", "Ljavax/swing/ListSelectionModel;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "columnMargin", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "listenerList", "Ljavax/swing/event/EventListenerList;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "changeEvent", "Ljavax/swing/event/ChangeEvent;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "columnSelectionAllowed", "Z"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "totalColumnWidth", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DefaultTableColumnModel", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "invalidateWidthCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireColumnAdded", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireColumnRemoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireColumnMoved", "(Ljavax/swing/event/TableColumnModelEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireColumnMarginChanged", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "recalcWidthCache", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fireColumnSelectionChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnModelListeners", "()[Ljavax/swing/event/TableColumnModelListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumns", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumn", "(I)Ljavax/swing/table/TableColumn;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setColumnSelectionAllowed", "(Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSelectionModel", "()Ljavax/swing/ListSelectionModel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "valueChanged", "(Ljavax/swing/event/ListSelectionEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createSelectionModel", "()Ljavax/swing/ListSelectionModel;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addColumnModelListener", "(Ljavax/swing/event/TableColumnModelListener;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getListeners", "(Ljava/lang/Class;)[Ljava/util/EventListener;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setSelectionModel", "(Ljavax/swing/ListSelectionModel;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "setColumnMargin", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnMargin", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnCount", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "removeColumn", "(Ljavax/swing/table/TableColumn;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "addColumn", "(Ljavax/swing/table/TableColumn;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSelectedColumns", "()[I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnSelectionAllowed", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getSelectedColumnCount", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnIndex", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "moveColumn", "(II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getColumnIndexAtX", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTotalColumnWidth", "()I"));
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
	public Dova.JDK.java.util.Vector tableColumns_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/ListSelectionModel;", "protected")]
	public Dova.JDK.javax.swing.ListSelectionModel selectionModel_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "protected")]
	public int columnMargin_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("Ljavax/swing/event/EventListenerList;", "protected")]
	public Dova.JDK.javax.swing.@event.EventListenerList listenerList_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.EventListenerList>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeEvent;", "protected transient")]
	public Dova.JDK.javax.swing.@event.ChangeEvent changeEvent_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeEvent>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "protected")]
	public bool columnSelectionAllowed_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("I", "protected")]
	public int totalColumnWidth_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultTableColumnModel(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultTableColumnModel() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/table/DefaultTableColumnModel;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "private")]
	public void invalidateWidthCache()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "protected")]
	public void fireColumnAdded(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "protected")]
	public void fireColumnRemoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelEvent;)V", "protected")]
	public void fireColumnMoved(Dova.JDK.javax.swing.@event.TableColumnModelEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void fireColumnMarginChanged()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void recalcWidthCache()
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "protected")]
	public void fireColumnSelectionChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("()[Ljavax/swing/event/TableColumnModelListener;", "public")]
	public JavaArray<Dova.JDK.javax.swing.@event.TableColumnModelListener> getColumnModelListeners()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.@event.TableColumnModelListener>>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getColumns()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/table/TableColumn;", "public")]
	public Dova.JDK.javax.swing.table.TableColumn getColumn(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableColumn>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setColumnSelectionAllowed(bool arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ListSelectionModel;", "public")]
	public Dova.JDK.javax.swing.ListSelectionModel getSelectionModel()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/ListSelectionEvent;)V", "public")]
	public void valueChanged(Dova.JDK.javax.swing.@event.ListSelectionEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ListSelectionModel;", "protected")]
	public Dova.JDK.javax.swing.ListSelectionModel createSelectionModel()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ListSelectionModel>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelListener;)V", "public")]
	public void removeColumnModelListener(Dova.JDK.javax.swing.@event.TableColumnModelListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/TableColumnModelListener;)V", "public")]
	public void addColumnModelListener(Dova.JDK.javax.swing.@event.TableColumnModelListener arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "public")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)[Ljava/util/EventListener;", "public")]
	public JavaArray<Dova.JDK.java.lang.Object> getListeners(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/ListSelectionModel;)V", "public")]
	public void setSelectionModel(Dova.JDK.javax.swing.ListSelectionModel arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setColumnMargin(int arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getColumnMargin()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getColumnCount()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumn;)V", "public")]
	public void removeColumn(Dova.JDK.javax.swing.table.TableColumn arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/table/TableColumn;)V", "public")]
	public void addColumn(Dova.JDK.javax.swing.table.TableColumn arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()[I", "public")]
	public JavaArray<int> getSelectedColumns()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getColumnSelectionAllowed()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectedColumnCount()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public")]
	public int getColumnIndex(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void moveColumn(int arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getColumnIndexAtX(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTotalColumnWidth()
	{
		var ret = DovaJvm.Vm.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}
}