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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/TableView;", "public abstract")]
public partial class TableView
	: Dova.JDK.javax.swing.text.BoxView
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TableView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/TableView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnSpans", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnOffsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "totalColumnRequirements", "Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnRequirements", "[Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rows", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gridValid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY", "Ljava/util/BitSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(II[Ljavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMinorAxis", "(II[I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAtPosition", "(ILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidateGrid", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowsOccupied", "(Ljavax/swing/text/View;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnsOccupied", "(Ljavax/swing/text/View;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFill", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateGrid", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutColumns", "(I[I[I[Ljavax/swing/SizeRequirements;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateColumnRequirements", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkSingleColumnCell", "(IILjavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMultiColumnCell", "(IIILjavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTableRow", "(Ljavax/swing/text/Element;)Ljavax/swing/text/TableView$TableRow;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTableCell", "(Ljavax/swing/text/Element;)Ljavax/swing/text/TableView$TableCell;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnSpan", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowSpan", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardUpdate", "(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "(I)Ljavax/swing/text/TableView$TableRow;"));
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> columnSpans_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> columnOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SizeRequirements;", "")]
	public Dova.JDK.javax.swing.SizeRequirements totalColumnRequirements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/swing/SizeRequirements;", "")]
	public JavaArray<Dova.JDK.javax.swing.SizeRequirements> columnRequirements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.SizeRequirements>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "")]
	public Dova.JDK.java.util.Vector rows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool gridValid_Property
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

	[JniSignatureAttribute("Ljava/util/BitSet;", "private static final")]
	public static Dova.JDK.java.util.BitSet EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TableView(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
	public TableView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/TableView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II[Ljavax/swing/text/View;)V", "public")]
	public void replace(int arg0, int arg1, JavaArray<Dova.JDK.javax.swing.text.View> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
	public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("()I", "")]
	public int getRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(II[I[I)V", "protected")]
	public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View getViewAtPosition(int arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void invalidateGrid()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)I", "")]
	public int getRowsOccupied(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)I", "")]
	public int getColumnsOccupied(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "")]
	public void addFill(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateGrid()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("(I[I[I[Ljavax/swing/SizeRequirements;)V", "protected")]
	public void layoutColumns(int arg0, JavaArray<int> arg1, JavaArray<int> arg2, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void calculateColumnRequirements(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/View;)V", "")]
	public void checkSingleColumnCell(int arg0, int arg1, Dova.JDK.javax.swing.text.View arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIILjavax/swing/text/View;)V", "")]
	public void checkMultiColumnCell(int arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.View arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/TableView$TableRow;", "protected")]
	public Dova.JDK.javax.swing.text.TableView.TableRow createTableRow(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TableView.TableRow>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/TableView$TableCell;", "protected")]
	public Dova.JDK.javax.swing.text.TableView.TableCell createTableCell(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TableView.TableCell>(ret);
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getColumnSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "")]
	public int getRowSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "protected")]
	public void forwardUpdate(Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.java.awt.Shape arg2, Dova.JDK.javax.swing.text.ViewFactory arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()I", "")]
	public int getColumnCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/TableView$TableRow;", "")]
	public Dova.JDK.javax.swing.text.TableView.TableRow getRow(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TableView.TableRow>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/TableView$TableRow;", "public")]
	public partial class TableRow
		: Dova.JDK.javax.swing.text.BoxView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TableRow()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/TableView$TableRow;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fillColumns", "Ljava/util/BitSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/TableView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/TableView;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(II[Ljavax/swing/text/View;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFilled", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMajorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMinorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAtPosition", "(ILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResizeWeight", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearFilledColumns", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setRow", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillColumn", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "()I"));
		}

		[JniSignatureAttribute("Ljava/util/BitSet;", "")]
		public Dova.JDK.java.util.BitSet fillColumns_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
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

		[JniSignatureAttribute("Ljavax/swing/text/TableView;", "final")]
		public Dova.JDK.javax.swing.text.TableView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TableView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TableRow(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/TableView;Ljavax/swing/text/Element;)V", "public")]
		public TableRow(Dova.JDK.javax.swing.text.TableView arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/TableView$TableRow;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(II[Ljavax/swing/text/View;)V", "public")]
		public void replace(int arg0, int arg1, JavaArray<Dova.JDK.javax.swing.text.View> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMinimumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMaximumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)Z", "")]
		public bool isFilled(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMajorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("(ILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
		public Dova.JDK.javax.swing.text.View getViewAtPosition(int arg0, Dova.JDK.java.awt.Rectangle arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getPreferredSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getResizeWeight(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void clearFilledColumns()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void setRow(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void fillColumn(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("()I", "")]
		public int getColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()I", "")]
		public int getRow()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/TableView$TableCell;", "public")]
	public partial class TableCell
		: Dova.JDK.javax.swing.text.BoxView
		, Dova.JDK.javax.swing.text.TableView.GridCell
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TableCell()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/TableView$TableCell;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "col", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/TableView;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGridLocation", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGridRow", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGridColumn", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		}

		[JniSignatureAttribute("I", "")]
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

		[JniSignatureAttribute("I", "")]
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TableCell(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/TableView;Ljavax/swing/text/Element;)V", "public")]
		public TableCell(Dova.JDK.javax.swing.text.TableView arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/TableView$TableCell;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getRowCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(II)V", "public")]
		public void setGridLocation(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getGridRow()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getGridColumn()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/TableView$GridCell;", "abstract static interface")]
	public partial interface GridCell
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GridCell()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/TableView$GridCell;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGridLocation", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGridRow", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGridColumn", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getRowCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(II)V", "public abstract")]
		void setGridLocation(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getGridRow()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getGridColumn()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		int getColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}
}
