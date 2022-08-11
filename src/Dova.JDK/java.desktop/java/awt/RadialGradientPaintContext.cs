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

[JniSignatureAttribute("Ljava/awt/RadialGradientPaintContext;", "final")]
public partial class RadialGradientPaintContext
	: Dova.JDK.java.awt.MultipleGradientPaintContext
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RadialGradientPaintContext()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/RadialGradientPaintContext;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isSimpleFocus", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isNonCyclic", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "radius", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "centerX", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "centerY", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusX", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focusY", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "radiusSq", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constA", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constB", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "gDeltaDelta", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trivial", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCALEBACK", "F"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SQRT_LUT_SIZE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "sqrtLut", "[F"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/RadialGradientPaint;Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;FFFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "simpleNonCyclicFillRaster", "([IIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cyclicCircularGradientFillRaster", "([IIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRaster", "([IIIIIII)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isSimpleFocus_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isNonCyclic_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float radius_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float centerX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float centerY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float focusX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float focusY_Property
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

	[JniSignatureAttribute("F", "private")]
	public float radiusSq_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float constA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[8], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float constB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float gDeltaDelta_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("F", "private")]
	public float trivial_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetFloatField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetFloatField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("F", "private static final")]
	public static float SCALEBACK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticFloatField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticFloatField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SQRT_LUT_SIZE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("[F", "private static")]
	public static JavaArray<float> sqrtLut_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RadialGradientPaintContext(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/RadialGradientPaint;Ljava/awt/image/ColorModel;Ljava/awt/Rectangle;Ljava/awt/geom/Rectangle2D;Ljava/awt/geom/AffineTransform;Ljava/awt/RenderingHints;FFFFF[F[Ljava/awt/Color;Ljava/awt/MultipleGradientPaint$CycleMethod;Ljava/awt/MultipleGradientPaint$ColorSpaceType;)V", "")]
	public RadialGradientPaintContext(Dova.JDK.java.awt.RadialGradientPaint arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.Rectangle arg2, Dova.JDK.java.awt.geom.Rectangle2D arg3, Dova.JDK.java.awt.geom.AffineTransform arg4, Dova.JDK.java.awt.RenderingHints arg5, float arg6, float arg7, float arg8, float arg9, float arg10, JavaArray<float> arg11, JavaArray<Dova.JDK.java.awt.Color> arg12, Dova.JDK.java.awt.MultipleGradientPaint.CycleMethod arg13, Dova.JDK.java.awt.MultipleGradientPaint.ColorSpaceType arg14) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/RadialGradientPaintContext;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([IIIIIII)V", "private")]
	public void simpleNonCyclicFillRaster(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("([IIIIIII)V", "private")]
	public void cyclicCircularGradientFillRaster(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("([IIIIIII)V", "protected")]
	public void fillRaster(JavaArray<int> arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}
}
