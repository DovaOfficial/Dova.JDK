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

namespace Dova.JDK.javax.swing.plaf.nimbus;

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/SliderTrackPainter;", "final")]
public partial class SliderTrackPainter
	: Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SliderTrackPainter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/SliderTrackPainter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKGROUND_DISABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKGROUND_ENABLED", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "state", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctx", "Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljava/awt/geom/Path2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rect", "Ljava/awt/geom/Rectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "roundRect", "Ljava/awt/geom/RoundRectangle2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ellipse", "Ljava/awt/geom/Ellipse2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color1", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color2", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color3", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color4", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color5", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color6", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color7", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color8", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color9", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color10", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "color11", "Ljava/awt/Color;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "componentColors", "[Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPaintContext", "()Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "doPaint", "(Ljava/awt/Graphics2D;Ljavax/swing/JComponent;II[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient1", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient2", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient3", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeGradient4", "(Ljava/awt/Shape;)Ljava/awt/Paint;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRoundRect1", "()Ljava/awt/geom/RoundRectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRoundRect2", "()Ljava/awt/geom/RoundRectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRoundRect3", "()Ljava/awt/geom/RoundRectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRoundRect4", "()Ljava/awt/geom/RoundRectangle2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackgroundDisabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackgroundEnabled", "(Ljava/awt/Graphics2D;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "decodeRoundRect5", "()Ljava/awt/geom/RoundRectangle2D;"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int BACKGROUND_DISABLED_Property
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
	public static int BACKGROUND_ENABLED_Property
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

	[JniSignatureAttribute("I", "private")]
	public int state_Property
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

	[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;", "private")]
	public Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext ctx_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Path2D;", "private")]
	public Dova.JDK.java.awt.geom.Path2D path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Path2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Rectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.Rectangle2D rect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D roundRect_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Ellipse2D;", "private")]
	public Dova.JDK.java.awt.geom.Ellipse2D ellipse_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Ellipse2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color5_Property
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

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color7_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color8_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color9_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color10_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/Color;", "private")]
	public Dova.JDK.java.awt.Color color11_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/lang/Object;", "private")]
	public JavaArray<Dova.JDK.java.lang.Object> componentColors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SliderTrackPainter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;I)V", "public")]
	public SliderTrackPainter(Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/SliderTrackPainter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljavax/swing/plaf/nimbus/AbstractRegionPainter$PaintContext;", "protected final")]
	public Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext getPaintContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.nimbus.AbstractRegionPainter.PaintContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;Ljavax/swing/JComponent;II[Ljava/lang/Object;)V", "protected")]
	public void doPaint(Dova.JDK.java.awt.Graphics2D arg0, Dova.JDK.javax.swing.JComponent arg1, int arg2, int arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient1(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient2(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient3(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Shape;)Ljava/awt/Paint;", "private")]
	public Dova.JDK.java.awt.Paint decodeGradient4(Dova.JDK.java.awt.Shape arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Paint>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D decodeRoundRect1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D decodeRoundRect2()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D decodeRoundRect3()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D decodeRoundRect4()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintBackgroundDisabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics2D;)V", "private")]
	public void paintBackgroundEnabled(Dova.JDK.java.awt.Graphics2D arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/RoundRectangle2D;", "private")]
	public Dova.JDK.java.awt.geom.RoundRectangle2D decodeRoundRect5()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.RoundRectangle2D>(ret);
	}
}
