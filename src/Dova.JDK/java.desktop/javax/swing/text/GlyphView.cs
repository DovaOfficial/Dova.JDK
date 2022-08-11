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

[JniSignatureAttribute("Ljavax/swing/text/GlyphView;", "public")]
public partial class GlyphView
	: Dova.JDK.javax.swing.text.View
	, Dova.JDK.javax.swing.text.TabableView
	, Dova.JDK.java.lang.Cloneable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static GlyphView()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/GlyphView;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selections", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "length", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "impliedCR", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "skipWidth", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expander", "Ljavax/swing/text/TabExpander;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minimumSpan", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "breakSpots", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "x", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "painter", "Ljavax/swing/text/GlyphView$GlyphPainter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "defaultPainter", "Ljavax/swing/text/GlyphView$GlyphPainter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "justificationInfo", "Ljavax/swing/text/GlyphView$JustificationInfo;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "(II)Ljavax/swing/text/Segment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSpan", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAlignment", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextVisualPositionFrom", "(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabbedSpan", "(FLjavax/swing/text/TabExpander;)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTabExpander", "()Ljavax/swing/text/TabExpander;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGlyphPainter", "(Ljavax/swing/text/GlyphView$GlyphPainter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPainter", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintTextUsingColor", "(Ljava/awt/Graphics;Ljava/awt/Shape;Ljava/awt/Color;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initSelections", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreakSpot", "(II)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreaker", "()Ljava/text/BreakIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "syncCR", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGlyphPainter", "()Ljavax/swing/text/GlyphView$GlyphPainter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJustificationInfo", "(I)Ljavax/swing/text/GlyphView$JustificationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPartialSpan", "(II)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSpan", "(I)F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndOffset", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSuperscript", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubscript", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnderline", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStrikeThrough", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "breakView", "(IIFF)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFragment", "(II)Ljavax/swing/text/View;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreakWeight", "(IFF)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateAfterChange", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljava/awt/Shape;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
	}

	[JniSignatureAttribute("[B", "private")]
	public JavaArray<byte> selections_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "")]
	public int offset_Property
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
	public int length_Property
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
	public bool impliedCR_Property
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
	public bool skipWidth_Property
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

	[JniSignatureAttribute("Ljavax/swing/text/TabExpander;", "")]
	public Dova.JDK.javax.swing.text.TabExpander expander_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TabExpander>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float minimumSpan_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("[I", "private")]
	public JavaArray<int> breakSpots_Property
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

	[JniSignatureAttribute("I", "")]
	public int x_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/GlyphView$GlyphPainter;", "")]
	public Dova.JDK.javax.swing.text.GlyphView.GlyphPainter painter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.GlyphPainter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/GlyphView$GlyphPainter;", "static")]
	public static Dova.JDK.javax.swing.text.GlyphView.GlyphPainter defaultPainter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.GlyphPainter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/GlyphView$JustificationInfo;", "private")]
	public Dova.JDK.javax.swing.text.GlyphView.JustificationInfo justificationInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.JustificationInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public GlyphView(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
	public GlyphView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/GlyphView;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "protected final")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/text/Segment;", "public")]
	public Dova.JDK.javax.swing.text.Segment getText(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Segment>(ret);
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getMinimumSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getAlignment(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int getNextVisualPositionFrom(int arg0, Dova.JDK.javax.swing.text.Position.Bias arg1, Dova.JDK.java.awt.Shape arg2, int arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I", "public")]
	public int viewToModel(float arg0, float arg1, Dova.JDK.java.awt.Shape arg2, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg3)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(ILjava/awt/Shape;Ljavax/swing/text/Position$Bias;)Ljava/awt/Shape;", "public")]
	public Dova.JDK.java.awt.Shape modelToView(int arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.Position.Bias arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;Ljava/awt/Shape;Ljavax/swing/text/ViewFactory;)V", "public")]
	public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.javax.swing.text.ViewFactory arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(FLjavax/swing/text/TabExpander;)F", "public")]
	public float getTabbedSpan(float arg0, Dova.JDK.javax.swing.text.TabExpander arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/TabExpander;", "public")]
	public Dova.JDK.javax.swing.text.TabExpander getTabExpander()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.TabExpander>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/GlyphView$GlyphPainter;)V", "public")]
	public void setGlyphPainter(Dova.JDK.javax.swing.text.GlyphView.GlyphPainter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void checkPainter()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;Ljava/awt/Color;II)V", "final")]
	public void paintTextUsingColor(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.Color arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(II)V", "private")]
	public void initSelections(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("(II)I", "private")]
	public int getBreakSpot(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/text/BreakIterator;", "private")]
	public Dova.JDK.java.text.BreakIterator getBreaker()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.BreakIterator>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void syncCR()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/GlyphView$GlyphPainter;", "public")]
	public Dova.JDK.javax.swing.text.GlyphView.GlyphPainter getGlyphPainter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.GlyphPainter>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/GlyphView$JustificationInfo;", "")]
	public Dova.JDK.javax.swing.text.GlyphView.JustificationInfo getJustificationInfo(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.JustificationInfo>(ret);
	}

	[JniSignatureAttribute("(II)F", "public")]
	public float getPartialSpan(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)F", "public")]
	public float getPreferredSpan(int arg0)
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEndOffset()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSuperscript()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSubscript()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isUnderline()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStrikeThrough()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(IIFF)Ljavax/swing/text/View;", "public")]
	public Dova.JDK.javax.swing.text.View breakView(int arg0, int arg1, float arg2, float arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(II)Ljavax/swing/text/View;", "public")]
	public Dova.JDK.javax.swing.text.View createFragment(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
	}

	[JniSignatureAttribute("(IFF)I", "public")]
	public int getBreakWeight(int arg0, float arg1, float arg2)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()V", "")]
	public void updateAfterChange()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33]);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljava/awt/Shape;)V", "public")]
	public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.java.awt.Shape arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/GlyphView$JustificationInfo;", "static")]
	public partial class JustificationInfo
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JustificationInfo()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/GlyphView$JustificationInfo;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leadingSpaces", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "contentSpaces", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trailingSpaces", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasTab", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "spaceMap", "Ljava/util/BitSet;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIIIIZLjava/util/BitSet;)V"));
		}

		[JniSignatureAttribute("I", "final")]
		public int start_Property
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

		[JniSignatureAttribute("I", "final")]
		public int end_Property
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

		[JniSignatureAttribute("I", "final")]
		public int leadingSpaces_Property
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

		[JniSignatureAttribute("I", "final")]
		public int contentSpaces_Property
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

		[JniSignatureAttribute("I", "final")]
		public int trailingSpaces_Property
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

		[JniSignatureAttribute("Z", "final")]
		public bool hasTab_Property
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

		[JniSignatureAttribute("Ljava/util/BitSet;", "final")]
		public Dova.JDK.java.util.BitSet spaceMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.BitSet>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JustificationInfo(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IIIIIZLjava/util/BitSet;)V", "")]
		public JustificationInfo(int arg0, int arg1, int arg2, int arg3, int arg4, bool arg5, Dova.JDK.java.util.BitSet arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/GlyphView$JustificationInfo;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/text/GlyphView$GlyphPainter;", "public abstract static")]
	public partial class GlyphPainter
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static GlyphPainter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/GlyphView$GlyphPainter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextVisualPositionFrom", "(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "viewToModel", "(Ljavax/swing/text/GlyphView;FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "modelToView", "(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "(Ljavax/swing/text/GlyphView;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPainter", "(Ljavax/swing/text/GlyphView;II)Ljavax/swing/text/GlyphView$GlyphPainter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBoundedPosition", "(Ljavax/swing/text/GlyphView;IFF)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAscent", "(Ljavax/swing/text/GlyphView;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescent", "(Ljavax/swing/text/GlyphView;)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSpan", "(Ljavax/swing/text/GlyphView;IILjavax/swing/text/TabExpander;F)F"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljavax/swing/text/GlyphView;Ljava/awt/Graphics;Ljava/awt/Shape;II)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public GlyphPainter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public GlyphPainter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/GlyphView$GlyphPainter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;I[Ljavax/swing/text/Position$Bias;)I", "public")]
		public int getNextVisualPositionFrom(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, Dova.JDK.java.awt.Shape arg3, int arg4, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg5)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;FFLjava/awt/Shape;[Ljavax/swing/text/Position$Bias;)I", "public abstract")]
		public int viewToModel(Dova.JDK.javax.swing.text.GlyphView arg0, float arg1, float arg2, Dova.JDK.java.awt.Shape arg3, JavaArray<Dova.JDK.javax.swing.text.Position.Bias> arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;ILjavax/swing/text/Position$Bias;Ljava/awt/Shape;)Ljava/awt/Shape;", "public abstract")]
		public Dova.JDK.java.awt.Shape modelToView(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, Dova.JDK.javax.swing.text.Position.Bias arg2, Dova.JDK.java.awt.Shape arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public abstract")]
		public float getHeight(Dova.JDK.javax.swing.text.GlyphView arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;II)Ljavax/swing/text/GlyphView$GlyphPainter;", "public")]
		public Dova.JDK.javax.swing.text.GlyphView.GlyphPainter getPainter(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.GlyphView.GlyphPainter>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;IFF)I", "public abstract")]
		public int getBoundedPosition(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, float arg2, float arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public abstract")]
		public float getAscent(Dova.JDK.javax.swing.text.GlyphView arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;)F", "public abstract")]
		public float getDescent(Dova.JDK.javax.swing.text.GlyphView arg0)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;IILjavax/swing/text/TabExpander;F)F", "public abstract")]
		public float getSpan(Dova.JDK.javax.swing.text.GlyphView arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.TabExpander arg3, float arg4)
		{
			var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/GlyphView;Ljava/awt/Graphics;Ljava/awt/Shape;II)V", "public abstract")]
		public void paint(Dova.JDK.javax.swing.text.GlyphView arg0, Dova.JDK.java.awt.Graphics arg1, Dova.JDK.java.awt.Shape arg2, int arg3, int arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		}
	}
}
