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

namespace Dova.JDK.javax.swing.text.html;

[JniSignatureAttribute("Ljavax/swing/text/html/TableView;", "")]
public partial class TableView
	: Dova.JDK.javax.swing.text.BoxView
	, Dova.JDK.javax.swing.text.ViewFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TableView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/TableView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attr", "Ljavax/swing/text/AttributeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "painter", "Ljavax/swing/text/html/StyleSheet$BoxPainter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellSpacing", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "borderWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "captionIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "relativeCells", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multiRowCells", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnSpans", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnOffsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "totalColumnRequirements", "Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "columnRequirements", "[Ljavax/swing/SizeRequirements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowIterator", "Ljavax/swing/text/html/TableView$RowIterator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "colIterator", "Ljavax/swing/text/html/TableView$ColumnIterator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rows", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipComments", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gridValid", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY", "Ljava/util/BitSet;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(II[Ljavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParent", "(Ljavax/swing/text/View;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateInsets", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMultiRowSpan", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewFactory", "()Ljavax/swing/text/ViewFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertiesFromAttributes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMajorAxis", "(II[I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMinorAxis", "(II[I[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAtPoint", "(IILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
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
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createTableRow", "(Ljavax/swing/text/Element;)Ljavax/swing/text/html/TableView$RowView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnSpan", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRowSpan", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardUpdate", "(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRow", "(I)Ljavax/swing/text/html/TableView$RowView;"));
	}

	[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "private")]
	public Dova.JDK.javax.swing.text.AttributeSet attr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/StyleSheet$BoxPainter;", "private")]
	public Dova.JDK.javax.swing.text.html.StyleSheet.BoxPainter painter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet.BoxPainter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int cellSpacing_Property
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
	public int borderWidth_Property
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

	[JniSignatureAttribute("I", "private")]
	public int captionIndex_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool relativeCells_Property
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

	[JniSignatureAttribute("Z", "private")]
	public bool multiRowCells_Property
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

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> columnSpans_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[I", "")]
	public JavaArray<int> columnOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/SizeRequirements;", "")]
	public Dova.JDK.javax.swing.SizeRequirements totalColumnRequirements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljavax/swing/SizeRequirements;", "")]
	public JavaArray<Dova.JDK.javax.swing.SizeRequirements> columnRequirements_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.SizeRequirements>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$RowIterator;", "")]
	public Dova.JDK.javax.swing.text.html.TableView.RowIterator rowIterator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView.RowIterator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$ColumnIterator;", "")]
	public Dova.JDK.javax.swing.text.html.TableView.ColumnIterator colIterator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView.ColumnIterator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "")]
	public Dova.JDK.java.util.Vector rows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool skipComments_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool gridValid_Property
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

	[JniSignatureAttribute("Ljava/util/BitSet;", "private static final")]
	public static Dova.JDK.java.util.BitSet EMPTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
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

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/TableView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(II[Ljavax/swing/text/View;)V", "public")]
	public void replace(int arg0, int arg1, JavaArray<Dova.JDK.javax.swing.text.View> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "public")]
	public Dova.JDK.javax.swing.text.View create(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
	public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)V", "public")]
	public void setParent(Dova.JDK.javax.swing.text.View arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateInsets()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(II)I", "public")]
	public int getMultiRowSpan(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/ViewFactory;", "public")]
	public Dova.JDK.javax.swing.text.ViewFactory getViewFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
	public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void setPropertiesFromAttributes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getRowCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/StyleSheet;", "protected")]
	public Dova.JDK.javax.swing.text.html.StyleSheet getStyleSheet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
	}

	[JniSignatureAttribute("(II[I[I)V", "protected")]
	public void layoutMajorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(II[I[I)V", "protected")]
	public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
	public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("(IILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View getViewAtPoint(int arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View getViewAtPosition(int arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void invalidateGrid()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)I", "protected")]
	public int getRowsOccupied(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;)I", "protected")]
	public int getColumnsOccupied(Dova.JDK.javax.swing.text.View arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "")]
	public void addFill(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateGrid()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
	}

	[JniSignatureAttribute("(I[I[I[Ljavax/swing/SizeRequirements;)V", "protected")]
	public void layoutColumns(int arg0, JavaArray<int> arg1, JavaArray<int> arg2, JavaArray<Dova.JDK.javax.swing.SizeRequirements> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)V", "")]
	public void calculateColumnRequirements(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/View;)V", "")]
	public void checkSingleColumnCell(int arg0, int arg1, Dova.JDK.javax.swing.text.View arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IIILjavax/swing/text/View;)V", "")]
	public void checkMultiColumnCell(int arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.View arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/html/TableView$RowView;", "protected")]
	public Dova.JDK.javax.swing.text.html.TableView.RowView createTableRow(Dova.JDK.javax.swing.text.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView.RowView>(ret);
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getColumnSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getRowSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent$ElementChange;Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "protected")]
	public void forwardUpdate(Dova.JDK.javax.swing.@event.DocumentEvent.ElementChange arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1, Dova.JDK.java.awt.Shape arg2, Dova.JDK.javax.swing.text.ViewFactory arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getColumnCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/html/TableView$RowView;", "")]
	public Dova.JDK.javax.swing.text.html.TableView.RowView getRow(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView.RowView>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$RowIterator;", "")]
	public partial class RowIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.text.html.CSS.LayoutIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RowIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/TableView$RowIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "row", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "adjustments", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsets", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spans", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/TableView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/TableView;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOffset", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndex", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayoutArrays", "([I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAdjustments", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustMultiRowSpan", "(III)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSpan", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadingCollapseSpan", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrailingCollapseSpan", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorderWidth", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdjustmentWeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpan", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(F)F"));
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

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> adjustments_Property
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

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> offsets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> spans_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/TableView;", "final")]
		public Dova.JDK.javax.swing.text.html.TableView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RowIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/TableView;)V", "")]
		public RowIterator(Dova.JDK.javax.swing.text.html.TableView arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/TableView$RowIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setOffset(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setIndex(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("([I[I)V", "")]
		public void setLayoutArrays(JavaArray<int> arg0, JavaArray<int> arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void updateAdjustments()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(III)V", "")]
		public void adjustMultiRowSpan(int arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getMinimumSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getMaximumSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setSpan(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()F", "public")]
		public float getLeadingCollapseSpan()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()F", "public")]
		public float getTrailingCollapseSpan()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()F", "public")]
		public float getBorderWidth()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAdjustmentWeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getSpan()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getPreferredSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$ColumnIterator;", "")]
	public partial class ColumnIterator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.text.html.CSS.LayoutIterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ColumnIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/TableView$ColumnIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "col", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "percentages", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "adjustmentWeights", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsets", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spans", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/TableView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/TableView;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOffset", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCount", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setIndex", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLayoutArrays", "([I[II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updatePercentagesAndAdjustmentWeights", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "disablePercentages", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSpan", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeadingCollapseSpan", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrailingCollapseSpan", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorderWidth", "()F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdjustmentWeight", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpan", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(F)F"));
		}

		[JniSignatureAttribute("I", "private")]
		public int col_Property
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

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> percentages_Property
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

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> adjustmentWeights_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> offsets_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[I", "private")]
		public JavaArray<int> spans_Property
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

		[JniSignatureAttribute("Ljavax/swing/text/html/TableView;", "final")]
		public Dova.JDK.javax.swing.text.html.TableView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ColumnIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/TableView;)V", "")]
		public ColumnIterator(Dova.JDK.javax.swing.text.html.TableView arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/TableView$ColumnIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setOffset(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setIndex(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("([I[II)V", "public")]
		public void setLayoutArrays(JavaArray<int> arg0, JavaArray<int> arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(I)V", "private")]
		public void updatePercentagesAndAdjustmentWeights(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void disablePercentages()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getMinimumSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getMaximumSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)V", "public")]
		public void setSpan(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()F", "public")]
		public float getLeadingCollapseSpan()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}

		[JniSignatureAttribute("()F", "public")]
		public float getTrailingCollapseSpan()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("()F", "public")]
		public float getBorderWidth()
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[12]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getAdjustmentWeight()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getSpan()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("(F)F", "public")]
		public float getPreferredSpan(float arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$RowView;", "public")]
	public partial class RowView
		: Dova.JDK.javax.swing.text.BoxView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RowView()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/TableView$RowView;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "painter", "Ljavax/swing/text/html/StyleSheet$BoxPainter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attr", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fillColumns", "Ljava/util/BitSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rowIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "viewIndex", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "multiRowCells", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/html/TableView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/html/TableView;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replace", "(II[Ljavax/swing/text/View;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findViewAtPoint", "(IILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertiesFromAttributes", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFilled", "(I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMajorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMinorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewAtPosition", "(ILjava/awt/Rectangle;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResizeWeight", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clearFilledColumns", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillColumn", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "preferenceChanged", "(Ljavax/swing/text/View;ZZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnCount", "()I"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/StyleSheet$BoxPainter;", "private")]
		public Dova.JDK.javax.swing.text.html.StyleSheet.BoxPainter painter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet.BoxPainter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "private")]
		public Dova.JDK.javax.swing.text.AttributeSet attr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/BitSet;", "")]
		public Dova.JDK.java.util.BitSet fillColumns_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "")]
		public int rowIndex_Property
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

		[JniSignatureAttribute("I", "")]
		public int viewIndex_Property
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

		[JniSignatureAttribute("Z", "")]
		public bool multiRowCells_Property
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

		[JniSignatureAttribute("Ljavax/swing/text/html/TableView;", "final")]
		public Dova.JDK.javax.swing.text.html.TableView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TableView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RowView(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/TableView;Ljavax/swing/text/Element;)V", "public")]
		public RowView(Dova.JDK.javax.swing.text.html.TableView arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/TableView$RowView;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(II[Ljavax/swing/text/View;)V", "public")]
		public void replace(int arg0, int arg1, JavaArray<Dova.JDK.javax.swing.text.View> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("(IILjava/awt/Rectangle;)Ljavax/swing/text/View;", "")]
		public Dova.JDK.javax.swing.text.View findViewAtPoint(int arg0, int arg1, Dova.JDK.java.awt.Rectangle arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMinimumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMaximumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void setPropertiesFromAttributes()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(I)Z", "")]
		public bool isFilled(int arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/StyleSheet;", "protected")]
		public Dova.JDK.javax.swing.text.html.StyleSheet getStyleSheet()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMajorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("(ILjava/awt/Rectangle;)Ljavax/swing/text/View;", "protected")]
		public Dova.JDK.javax.swing.text.View getViewAtPosition(int arg0, Dova.JDK.java.awt.Rectangle arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getPreferredSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getResizeWeight(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
			return ret;
		}

		[JniSignatureAttribute("()V", "")]
		public void clearFilledColumns()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void fillColumn(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/View;ZZ)V", "public")]
		public void preferenceChanged(Dova.JDK.javax.swing.text.View arg0, bool arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		}

		[JniSignatureAttribute("()I", "")]
		public int getColumnCount()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[20]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/TableView$CellView;", "static")]
	public partial class CellView
		: Dova.JDK.javax.swing.text.html.BlockView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CellView()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/TableView$CellView;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMajorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CellView(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
		public CellView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/TableView$CellView;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMajorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}
	}
}
