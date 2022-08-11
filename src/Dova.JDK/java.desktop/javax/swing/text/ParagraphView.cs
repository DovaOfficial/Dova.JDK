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

[JniSignatureAttribute("Ljavax/swing/text/ParagraphView;", "public")]
public partial class ParagraphView
	: Dova.JDK.javax.swing.text.FlowView
	, Dova.JDK.javax.swing.text.TabExpander
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ParagraphView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/ParagraphView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "justification", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineSpacing", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstLineIndent", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tabBase", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "i18nStrategy", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tabChars", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tabDecimalChars", "[C"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignment", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlowSpan", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertiesFromAttributes", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setJustification", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClosestPositionTo", "(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOffsetToCharactersInString", "([CI)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPartialSize", "(II)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutViewCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLayoutView", "(I)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findEdgeSpan", "(Ljavax/swing/text/View;IIII)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextNorthSouthVisualPositionFrom", "(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flipEastAndWestAtEnds", "(ILjavax/swing/text/Position$Bias;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlowStart", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createRow", "()Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabBase", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFirstLineIndent", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLineSpacing", "(F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabSet", "()Ljavax/swing/text/TabSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextTabStop", "(FI)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breakView", "(IFLjava/awt/Shape;)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreakWeight", "(IF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
	}

	[JniSignatureAttribute("I", "private")]
	public int justification_Property
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

	[JniSignatureAttribute("F", "private")]
	public float lineSpacing_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("I", "protected")]
	public int firstLineIndent_Property
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
	public int tabBase_Property
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

	[JniSignatureAttribute("Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class i18nStrategy_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "static")]
	public static JavaArray<char> tabChars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[C", "static")]
	public static JavaArray<char> tabDecimalChars_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ParagraphView(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
	public ParagraphView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/ParagraphView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)F", "public")]
	public float getAlignment(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getFlowSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
	public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void setPropertiesFromAttributes()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I)V", "protected")]
	public void setJustification(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;II)I", "protected")]
	public int getClosestPositionTo(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1, Dova.JDK.java.awt.Shape arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("([CI)I", "protected")]
	public int findOffsetToCharactersInString(JavaArray<char> arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(II)F", "protected")]
	public float getPartialSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()I", "protected")]
	public int getLayoutViewCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View getLayoutView(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/View;IIII)F", "private")]
	public float findEdgeSpan(Dova.JDK.javax.swing.text.View arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I", "protected")]
	public int getNextNorthSouthVisualPositionFrom(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1, Dova.JDK.java.awt.Shape arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;)Z", "protected")]
	public bool flipEastAndWestAtEnds(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "public")]
	public int getFlowStart(int arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/View;", "protected")]
	public Dova.JDK.javax.swing.text.View createRow()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("()F", "protected")]
	public float getTabBase()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void setFirstLineIndent(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(F)V", "protected")]
	public void setLineSpacing(float arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/TabSet;", "protected")]
	public Dova.JDK.javax.swing.text.TabSet getTabSet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TabSet>(ret);
	}

	[JniSignatureAttribute("(FI)F", "public")]
	public float nextTabStop(float arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(IFLjava/awt/Shape;)Ljavax/swing/text/View;", "public")]
	public Dova.JDK.javax.swing.text.View breakView(int arg0, float arg1, Dova.JDK.java.awt.Shape arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(IF)I", "public")]
	public int getBreakWeight(int arg0, float arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("Ljavax/swing/text/ParagraphView$Row;", "")]
	public partial class Row
		: Dova.JDK.javax.swing.text.BoxView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Row()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/ParagraphView$Row;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPACE_ADDON", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPACE_ADDON_LEFTOVER_END", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START_JUSTIFIABLE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "END_JUSTIFIABLE", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "justificationData", "[I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/text/ParagraphView;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/ParagraphView;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSpan", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignment", "(I)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMinorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getViewIndexAtPosition", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeftInset", "()S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadChildren", "(Ljavax/swing/text/ViewFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMajorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "layoutMinorAxis", "(II[I[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBottomInset", "()S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isJustifiableDocument", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLastRow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBrokenRow", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isJustifyEnabled", "()Z"));
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SPACE_ADDON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int SPACE_ADDON_LEFTOVER_END_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int START_JUSTIFIABLE_Property
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

		[JniSignatureAttribute("I", "static final")]
		public static int END_JUSTIFIABLE_Property
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

		[JniSignatureAttribute("[I", "")]
		public JavaArray<int> justificationData_Property
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

		[JniSignatureAttribute("Ljavax/swing/text/ParagraphView;", "final")]
		public Dova.JDK.javax.swing.text.ParagraphView this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ParagraphView>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Row(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/ParagraphView;Ljavax/swing/text/Element;)V", "")]
		public Row(Dova.JDK.javax.swing.text.ParagraphView arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/ParagraphView$Row;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getMaximumSpan(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)F", "public")]
		public float getAlignment(int arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMinorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;", "public")]
		public Dova.JDK.java.awt.Shape modelToView(int arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(I)I", "protected")]
		public int getViewIndexAtPosition(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("()S", "protected")]
		public short getLeftInset()
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/ViewFactory;)V", "protected")]
		public void loadChildren(Dova.JDK.javax.swing.text.ViewFactory arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMajorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II[I[I)V", "protected")]
		public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("()S", "protected")]
		public short getBottomInset()
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}

		[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
		public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[13]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isJustifiableDocument()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isLastRow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isBrokenRow()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isJustifyEnabled()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17]);
			return ret;
		}
	}
}
