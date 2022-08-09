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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/LinearGradientPaintContext;", "final")]
public partial class LinearGradientPaintContext
	: Dova.JDK.java.awt.MultipleGradientPaintContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LinearGradientPaintContext()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/LinearGradientPaintContext;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dgdX", "F"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "dgdY", "F"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "gc", "F"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "LinearGradientPaintContext", "(Ljava/awt/LinearGradientPaint;Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "fillRaster", "([IIIIIII)V"));
	}

	[JniSignatureAttribute("F", "private")]
	public float dgdX_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("F", "private")]
	public float dgdY_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("F", "private")]
	public float gc_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LinearGradientPaintContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/LinearGradientPaint;Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;)V", "")]
	public LinearGradientPaintContext(Dova.JDK.java.awt.LinearGradientPaint arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.Rectangle arg2, Dova.JDK.java.awt.geom.Rectangle2D arg3, Dova.JDK.java.awt.geom.AffineTransform arg4, Dova.JDK.java.awt.RenderingHints arg5, Dova.JDK.java.awt.geom.Point2D arg6, Dova.JDK.java.awt.geom.Point2D arg7, JavaArray<float> arg8, JavaArray<Dova.JDK.java.awt.Color> arg9, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg10, Dova.JDK.java.awt.MultipleGradientPaint.ColorSpaceType arg11) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/LinearGradientPaintContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([IIIIIII)V", "protected")]
	public void fillRaster(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}
}