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

[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo;", "public")]
public partial class XMBeanInfo
	: Dova.JDK.javax.swing.JPanel
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XMBeanInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "lightYellow", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "NAME_COLUMN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "VALUE_COLUMN", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnNames", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "infoTable", "Ljavax/swing/JTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descTable", "Ljavax/swing/JTable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "infoBorderPanel", "Ljavax/swing/JPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "descBorderPanel", "Ljavax/swing/JPanel;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "renderer", "Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellRenderer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "editor", "Ljavax/swing/table/TableCellEditor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanOperationInfo", "(Ljavax/management/MBeanOperationInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanNotificationInfo", "(Ljavax/management/MBeanNotificationInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyInfoTable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyDescTable", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanAttributeInfo", "(Ljavax/management/MBeanAttributeInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDescriptor", "(Ljavax/management/Descriptor;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanInfo", "(Lsun/tools/jconsole/inspector/XMBean;Ljavax/management/MBeanInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanConstructorInfo", "(Ljavax/management/MBeanConstructorInfo;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMBeanParameterInfo", "(Ljavax/management/MBeanParameterInfo;Ljava/lang/String;)V"));
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private static final")]
	public static Dova.JDK.java.awt.Color lightYellow_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int NAME_COLUMN_Property
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

	[JniSignatureAttribute("I", "private final")]
	public int VALUE_COLUMN_Property
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

	[JniSignatureAttribute("[Ljava/lang/String;", "private final")]
	public JavaArray<Dova.JDK.java.lang.String> columnNames_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable;", "private")]
	public Dova.JDK.javax.swing.JTable infoTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JTable;", "private")]
	public Dova.JDK.javax.swing.JTable descTable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTable>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JPanel;", "private")]
	public Dova.JDK.javax.swing.JPanel infoBorderPanel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JPanel;", "private")]
	public Dova.JDK.javax.swing.JPanel descBorderPanel_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JPanel>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellRenderer;", "private static")]
	public static Dova.JDK.sun.tools.jconsole.inspector.XMBeanInfo.MBeanInfoTableCellRenderer renderer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.tools.jconsole.inspector.XMBeanInfo.MBeanInfoTableCellRenderer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/table/TableCellEditor;", "private static")]
	public static Dova.JDK.javax.swing.table.TableCellEditor editor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.table.TableCellEditor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XMBeanInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public XMBeanInfo() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/management/MBeanOperationInfo;)V", "public")]
	public void addMBeanOperationInfo(Dova.JDK.javax.management.MBeanOperationInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanNotificationInfo;)V", "public")]
	public void addMBeanNotificationInfo(Dova.JDK.javax.management.MBeanNotificationInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()V", "public")]
	public void emptyInfoTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("()V", "public")]
	public void emptyDescTable()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanAttributeInfo;)V", "public")]
	public void addMBeanAttributeInfo(Dova.JDK.javax.management.MBeanAttributeInfo arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;Ljava/lang/String;)V", "private")]
	public void addDescriptor(Dova.JDK.javax.management.Descriptor arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/tools/jconsole/inspector/XMBean;Ljavax/management/MBeanInfo;)V", "public")]
	public void addMBeanInfo(Dova.JDK.sun.tools.jconsole.inspector.XMBean arg0, Dova.JDK.javax.management.MBeanInfo arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanConstructorInfo;Ljava/lang/String;)V", "private")]
	public void addMBeanConstructorInfo(Dova.JDK.javax.management.MBeanConstructorInfo arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanParameterInfo;Ljava/lang/String;)V", "private")]
	public void addMBeanParameterInfo(Dova.JDK.javax.management.MBeanParameterInfo arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo$ReadOnlyDefaultTableModel;", "private static")]
	public partial class ReadOnlyDefaultTableModel
		: Dova.JDK.javax.swing.table.DefaultTableModel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReadOnlyDefaultTableModel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanInfo$ReadOnlyDefaultTableModel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValueAt", "(Ljava/lang/Object;II)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReadOnlyDefaultTableModel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public ReadOnlyDefaultTableModel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanInfo$ReadOnlyDefaultTableModel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;II)V", "public")]
		public void setValueAt(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellRenderer;", "private static")]
	public partial class MBeanInfoTableCellRenderer
		: Dova.JDK.javax.swing.table.DefaultTableCellRenderer
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MBeanInfoTableCellRenderer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellRenderer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellRendererComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MBeanInfoTableCellRenderer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public MBeanInfoTableCellRenderer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellRenderer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellRendererComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, bool arg3, int arg4, int arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo$TableRowDivider;", "private static")]
	public partial class TableRowDivider
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TableRowDivider()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanInfo$TableRowDivider;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableRowDividerText", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String tableRowDividerText_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TableRowDivider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public TableRowDivider(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanInfo$TableRowDivider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellEditor;", "private static")]
	public partial class MBeanInfoTableCellEditor
		: Dova.JDK.sun.tools.jconsole.inspector.Utils.ReadOnlyTableCellEditor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MBeanInfoTableCellEditor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellEditor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTextField;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTableCellEditorComponent", "(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MBeanInfoTableCellEditor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTextField;)V", "public")]
		public MBeanInfoTableCellEditor(Dova.JDK.javax.swing.JTextField arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/tools/jconsole/inspector/XMBeanInfo$MBeanInfoTableCellEditor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JTable;Ljava/lang/Object;ZII)Ljava/awt/Component;", "public")]
		public Dova.JDK.java.awt.Component getTableCellEditorComponent(Dova.JDK.javax.swing.JTable arg0, Dova.JDK.java.lang.Object arg1, bool arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Component>(ret);
		}
	}
}
