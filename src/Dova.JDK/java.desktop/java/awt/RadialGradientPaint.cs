/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/RadialGradientPaint;", "public final")]
public partial class RadialGradientPaint
	: Dova.JDK.java.awt.MultipleGradientPaint
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RadialGradientPaint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/RadialGradientPaint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "focus", "Ljava/awt/geom/Point2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "center", "Ljava/awt/geom/Point2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "radius", "F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(FFFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(Ljava/awt/geom/Point2D;FLjava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(Ljava/awt/geom/Point2D;FLjava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;Ljava/awt/geom/AffineTransform;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(Ljava/awt/geom/Rectangle2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(FFF[F[Ljava/awt/Color;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(Ljava/awt/geom/Point2D;F[F[Ljava/awt/Color;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(FFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RadialGradientPaint", "(Ljava/awt/geom/Point2D;F[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createGradientTransform", "(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/AffineTransform;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFocusPoint", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRadius", "()F"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)Ljava/awt/PaintContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCenterPoint", "()Ljava/awt/geom/Point2D;"));
	}

	[JniSignatureAttribute("Ljava/awt/geom/Point2D;", "private final")]
	public Dova.JDK.java.awt.geom.Point2D focus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/geom/Point2D;", "private final")]
	public Dova.JDK.java.awt.geom.Point2D center_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("F", "private final")]
	public float radius_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RadialGradientPaint(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(FFFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public RadialGradientPaint(float arg0, float arg1, float arg2, float arg3, float arg4, JavaArray<float> arg5, JavaArray<Dova.JDK.java.awt.Color> arg6, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;FLjava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public RadialGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, float arg1, Dova.JDK.java.awt.geom.Point2D arg2, JavaArray<float> arg3, JavaArray<Dova.JDK.java.awt.Color> arg4, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;FLjava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;Ljava/awt/geom/AffineTransform;)V", "public")]
	public RadialGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, float arg1, Dova.JDK.java.awt.geom.Point2D arg2, JavaArray<float> arg3, JavaArray<Dova.JDK.java.awt.Color> arg4, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg5, Dova.JDK.java.awt.MultipleGradientPaint.ColorSpaceType arg6, Dova.JDK.java.awt.geom.AffineTransform arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public RadialGradientPaint(Dova.JDK.java.awt.geom.Rectangle2D arg0, JavaArray<float> arg1, JavaArray<Dova.JDK.java.awt.Color> arg2, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(FFF[F[Ljava/awt/Color;)V", "public")]
	public RadialGradientPaint(float arg0, float arg1, float arg2, JavaArray<float> arg3, JavaArray<Dova.JDK.java.awt.Color> arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;F[F[Ljava/awt/Color;)V", "public")]
	public RadialGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, float arg1, JavaArray<float> arg2, JavaArray<Dova.JDK.java.awt.Color> arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(FFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public RadialGradientPaint(float arg0, float arg1, float arg2, JavaArray<float> arg3, JavaArray<Dova.JDK.java.awt.Color> arg4, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[6], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;F[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public RadialGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, float arg1, JavaArray<float> arg2, JavaArray<Dova.JDK.java.awt.Color> arg3, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[7], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/RadialGradientPaint;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/geom/Rectangle2D;)Ljava/awt/geom/AffineTransform;", "private static")]
	public static Dova.JDK.java.awt.geom.AffineTransform createGradientTransform(Dova.JDK.java.awt.geom.Rectangle2D arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.AffineTransform>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getFocusPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()F", "public")]
	public float getRadius()
	{
		var ret = DovaVM.Runtime.CallFloatMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)Ljava/awt/PaintContext;", "public")]
	public Dova.JDK.java.awt.PaintContext createContext(Dova.JDK.java.awt.image.ColorModel arg0, Dova.JDK.java.awt.Rectangle arg1, Dova.JDK.java.awt.geom.Rectangle2D arg2, Dova.JDK.java.awt.geom.AffineTransform arg3, Dova.JDK.java.awt.RenderingHints arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PaintContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getCenterPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}
}
