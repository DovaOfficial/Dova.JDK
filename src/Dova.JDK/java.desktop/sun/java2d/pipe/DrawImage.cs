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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/DrawImage;", "public")]
public partial class DrawImage
	: Dova.JDK.java.lang.Object
	, Dova.JDK.sun.java2d.pipe.DrawImagePipe
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DrawImage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/DrawImage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAX_TX_ERROR", "D"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DrawImage", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isSimpleTranslate", "(Lsun/java2d/SunGraphics2D;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "renderImageCopy", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/Color;IIIIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "renderImageScale", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/Color;IIIIIDDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "closeToInteger", "(ID)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "tryCopyOrScale", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;I[D)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "renderImageXform", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;IIIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isBgOperation", "(Lsun/java2d/SurfaceData;Ljava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "makeBufferedImage", "(Ljava/awt/Image;Ljava/awt/Color;IIIII)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "blitSurfaceData", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;IIIIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scaleSurfaceData", "(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;IIIIDDDD)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "imageReady", "(Lsun/awt/image/ToolkitImage;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTransformColorModel", "(Lsun/java2d/SunGraphics2D;Ljava/awt/image/BufferedImage;Ljava/awt/geom/AffineTransform;)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "copyImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIILjava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scaleImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scaleImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scaleImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "scaleImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIIIILjava/awt/Color;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "transformImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "transformImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/geom/AffineTransform;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "transformImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;IIIIILjava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "transformImage", "(Lsun/java2d/SunGraphics2D;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBufferedImage", "(Ljava/awt/Image;)Ljava/awt/image/BufferedImage;"));
	}

	[JniSignatureAttribute("D", "private static final")]
	public static double MAX_TX_ERROR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticDoubleField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticDoubleField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DrawImage(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DrawImage() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/DrawImage;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;)Z", "public static")]
	public static bool isSimpleTranslate(Dova.JDK.sun.java2d.SunGraphics2D arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/Color;IIIIII)Z", "protected")]
	public bool renderImageCopy(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.Color arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/Color;IIIIIDDDD)Z", "protected")]
	public bool renderImageScale(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.Color arg2, int arg3, int arg4, int arg5, int arg6, int arg7, double arg8, double arg9, double arg10, double arg11)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return ret;
	}

	[JniSignatureAttribute("(ID)Z", "public static")]
	public static bool closeToInteger(int arg0, double arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;I[D)Z", "protected")]
	public bool tryCopyOrScale(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.java.awt.Color arg6, int arg7, JavaArray<double> arg8)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;IIIIILjava/awt/Color;)V", "protected")]
	public void renderImageXform(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.geom.AffineTransform arg2, int arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Color arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Lsun/java2d/SurfaceData;Ljava/awt/Color;)Z", "protected static")]
	public static bool isBgOperation(Dova.JDK.sun.java2d.SurfaceData arg0, Dova.JDK.java.awt.Color arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Image;Ljava/awt/Color;IIIII)Ljava/awt/image/BufferedImage;", "private")]
	public Dova.JDK.java.awt.image.BufferedImage makeBufferedImage(Dova.JDK.java.awt.Image arg0, Dova.JDK.java.awt.Color arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;IIIIIILjava/awt/Color;)V", "private static")]
	public static void blitSurfaceData(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.Region arg1, Dova.JDK.sun.java2d.SurfaceData arg2, Dova.JDK.sun.java2d.SurfaceData arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.java.awt.Color arg10)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Lsun/java2d/pipe/Region;Lsun/java2d/SurfaceData;Lsun/java2d/SurfaceData;Lsun/java2d/loops/SurfaceType;Lsun/java2d/loops/SurfaceType;IIIIDDDD)Z", "protected")]
	public bool scaleSurfaceData(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.sun.java2d.pipe.Region arg1, Dova.JDK.sun.java2d.SurfaceData arg2, Dova.JDK.sun.java2d.SurfaceData arg3, Dova.JDK.sun.java2d.loops.SurfaceType arg4, Dova.JDK.sun.java2d.loops.SurfaceType arg5, int arg6, int arg7, int arg8, int arg9, double arg10, double arg11, double arg12, double arg13)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/image/ToolkitImage;Ljava/awt/image/ImageObserver;)Z", "protected static")]
	public static bool imageReady(Dova.JDK.sun.awt.image.ToolkitImage arg0, Dova.JDK.java.awt.image.ImageObserver arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/image/BufferedImage;Ljava/awt/geom/AffineTransform;)Ljava/awt/image/ColorModel;", "private")]
	public Dova.JDK.java.awt.image.ColorModel getTransformColorModel(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.java.awt.geom.AffineTransform arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool copyImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Color arg8, Dova.JDK.java.awt.image.ImageObserver arg9)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool copyImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4, Dova.JDK.java.awt.image.ImageObserver arg5)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/Color;)Z", "public")]
	public bool copyImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, Dova.JDK.java.awt.Color arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIILjava/awt/Color;)Z", "public")]
	public bool copyImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Color arg8)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool scaleImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.java.awt.Color arg10, Dova.JDK.java.awt.image.ImageObserver arg11)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool scaleImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.java.awt.Color arg6, Dova.JDK.java.awt.image.ImageObserver arg7)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIILjava/awt/Color;)Z", "public")]
	public bool scaleImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, Dova.JDK.java.awt.Color arg6)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IIIIIIIILjava/awt/Color;)Z", "public")]
	public bool scaleImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, int arg9, Dova.JDK.java.awt.Color arg10)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;Ljava/awt/image/ImageObserver;)Z", "public")]
	public bool transformImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.geom.AffineTransform arg2, Dova.JDK.java.awt.image.ImageObserver arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;IILjava/awt/geom/AffineTransform;I)V", "protected")]
	public void transformImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, int arg2, int arg3, Dova.JDK.java.awt.geom.AffineTransform arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Image;Ljava/awt/geom/AffineTransform;IIIIILjava/awt/Color;)V", "protected")]
	public void transformImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Image arg1, Dova.JDK.java.awt.geom.AffineTransform arg2, int arg3, int arg4, int arg5, int arg6, int arg7, Dova.JDK.java.awt.Color arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;II)V", "public")]
	public void transformImage(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.image.BufferedImage arg1, Dova.JDK.java.awt.image.BufferedImageOp arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/awt/Image;)Ljava/awt/image/BufferedImage;", "protected")]
	public Dova.JDK.java.awt.image.BufferedImage getBufferedImage(Dova.JDK.java.awt.Image arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}
}
