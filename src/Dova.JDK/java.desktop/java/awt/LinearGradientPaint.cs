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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/LinearGradientPaint;", "public final")]
public partial class LinearGradientPaint
	: Dova.JDK.java.awt.MultipleGradientPaint
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LinearGradientPaint()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/LinearGradientPaint;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "start", "Ljava/awt/geom/Point2D;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "end", "Ljava/awt/geom/Point2D;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;Ljava/awt/geom/AffineTransform;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(FFFF[F[Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPoint", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPoint", "()Ljava/awt/geom/Point2D;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createContext", "(Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)Ljava/awt/PaintContext;"));
	}

	[JniSignatureAttribute("Ljava/awt/geom/Point2D;", "private final")]
	public Dova.JDK.java.awt.geom.Point2D start_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/awt/geom/Point2D;", "private final")]
	public Dova.JDK.java.awt.geom.Point2D end_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LinearGradientPaint(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;Ljava/awt/geom/AffineTransform;)V", "public")]
	public LinearGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1, JavaArray<float> arg2, JavaArray<Dova.JDK.java.awt.Color> arg3, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg4, Dova.JDK.java.awt.MultipleGradientPaint.ColorSpaceType arg5, Dova.JDK.java.awt.geom.AffineTransform arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public LinearGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1, JavaArray<float> arg2, JavaArray<Dova.JDK.java.awt.Color> arg3, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;)V", "public")]
	public LinearGradientPaint(Dova.JDK.java.awt.geom.Point2D arg0, Dova.JDK.java.awt.geom.Point2D arg1, JavaArray<float> arg2, JavaArray<Dova.JDK.java.awt.Color> arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	[JniSignatureAttribute("(FFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;)V", "public")]
	public LinearGradientPaint(float arg0, float arg1, float arg2, float arg3, JavaArray<float> arg4, JavaArray<Dova.JDK.java.awt.Color> arg5, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(FFFF[F[Ljava/awt/Color;)V", "public")]
	public LinearGradientPaint(float arg0, float arg1, float arg2, float arg3, JavaArray<float> arg4, JavaArray<Dova.JDK.java.awt.Color> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/LinearGradientPaint;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getStartPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/geom/Point2D;", "public")]
	public Dova.JDK.java.awt.geom.Point2D getEndPoint()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Point2D>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;)Ljava/awt/PaintContext;", "public")]
	public Dova.JDK.java.awt.PaintContext createContext(Dova.JDK.java.awt.image.ColorModel arg0, Dova.JDK.java.awt.Rectangle arg1, Dova.JDK.java.awt.geom.Rectangle2D arg2, Dova.JDK.java.awt.geom.AffineTransform arg3, Dova.JDK.java.awt.RenderingHints arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.PaintContext>(ret);
	}
}
