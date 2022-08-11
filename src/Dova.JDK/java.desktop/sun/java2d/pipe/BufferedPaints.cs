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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/BufferedPaints;", "public")]
public partial class BufferedPaints
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferedPaints()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/BufferedPaints;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MULTI_MAX_FRACTIONS", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setColor", "(Lsun/java2d/pipe/RenderQueue;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setGradientPaint", "(Lsun/java2d/pipe/RenderQueue;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;ZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setGradientPaint", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/GradientPaint;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setTexturePaint", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/TexturePaint;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resetPaint", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setLinearGradientPaint", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/LinearGradientPaint;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRadialGradientPaint", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/RadialGradientPaint;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertSRGBtoLinearRGB", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "colorToIntArgbPrePixel", "(Ljava/awt/Color;Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertToIntArgbPrePixels", "([Ljava/awt/Color;Z)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPaint", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;I)V"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int MULTI_MAX_FRACTIONS_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferedPaints(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BufferedPaints() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/BufferedPaints;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;I)V", "private static")]
	public static void setColor(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Ljava/awt/geom/AffineTransform;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/geom/Point2D;Ljava/awt/geom/Point2D;ZZ)V", "private static")]
	public static void setGradientPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.java.awt.geom.AffineTransform arg1, Dova.JDK.java.awt.Color arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.geom.Point2D arg4, Dova.JDK.java.awt.geom.Point2D arg5, bool arg6, bool arg7)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/GradientPaint;Z)V", "private static")]
	public static void setGradientPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.GradientPaint arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/TexturePaint;Z)V", "private static")]
	public static void setTexturePaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.TexturePaint arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "static")]
	public static void resetPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/LinearGradientPaint;Z)V", "private static")]
	public static void setLinearGradientPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.LinearGradientPaint arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/RadialGradientPaint;Z)V", "private static")]
	public static void setRadialGradientPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.RadialGradientPaint arg2, bool arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I)I", "public static")]
	public static int convertSRGBtoLinearRGB(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Color;Z)I", "private static")]
	public static int colorToIntArgbPrePixel(Dova.JDK.java.awt.Color arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/awt/Color;Z)[I", "private static")]
	public static JavaArray<int> convertToIntArgbPrePixels(JavaArray<Dova.JDK.java.awt.Color> arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SunGraphics2D;Ljava/awt/Paint;I)V", "static")]
	public static void setPaint(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SunGraphics2D arg1, Dova.JDK.java.awt.Paint arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
	}
}
