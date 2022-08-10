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

namespace Dova.JDK.com.sun.imageio.plugins.common;

[JniSignatureAttribute("Lcom/sun/imageio/plugins/common/ImageUtil;", "public")]
public partial class ImageUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ImageUtil()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/imageio/plugins/common/ImageUtil;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ImageUtil", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isNonStandardICCColorSpace", "(Ljava/awt/color/ColorSpace;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canEncodeImage", "(Ljavax/imageio/ImageWriter;Ljavax/imageio/ImageTypeSpecifier;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "canEncodeImage", "(Ljavax/imageio/ImageWriter;Ljava/awt/image/ColorModel;Ljava/awt/image/SampleModel;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getDestinationType", "(Ljavax/imageio/ImageReadParam;Ljava/util/Iterator;)Ljavax/imageio/ImageTypeSpecifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isBinary", "(Ljava/awt/image/SampleModel;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getTileSize", "(Ljava/awt/image/SampleModel;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createColorModel", "(Ljava/awt/color/ColorSpace;Ljava/awt/image/SampleModel;)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createColorModel", "(Ljava/awt/image/SampleModel;)Ljava/awt/image/ColorModel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getUnpackedBinaryData", "(Ljava/awt/image/Raster;Ljava/awt/Rectangle;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setUnpackedBinaryData", "([BLjava/awt/image/WritableRaster;Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getElementSize", "(Ljava/awt/image/SampleModel;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBandSize", "(Ljava/awt/image/SampleModel;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isIndicesForGrayscale", "([B[B[B)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertObjectToString", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "imageIsContiguous", "(Ljava/awt/image/RenderedImage;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPackedBinaryData", "(Ljava/awt/image/Raster;Ljava/awt/Rectangle;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setPackedBinaryData", "([BLjava/awt/image/WritableRaster;Ljava/awt/Rectangle;)V"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ImageUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public ImageUtil() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/imageio/plugins/common/ImageUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/color/ColorSpace;)Z", "public static")]
	public static bool isNonStandardICCColorSpace(Dova.JDK.java.awt.color.ColorSpace arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;Ljavax/imageio/ImageTypeSpecifier;)V", "public static final")]
	public static void canEncodeImage(Dova.JDK.javax.imageio.ImageWriter arg0, Dova.JDK.javax.imageio.ImageTypeSpecifier arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;Ljava/awt/image/ColorModel;Ljava/awt/image/SampleModel;)V", "public static final")]
	public static void canEncodeImage(Dova.JDK.javax.imageio.ImageWriter arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.image.SampleModel arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReadParam;Ljava/util/Iterator;)Ljavax/imageio/ImageTypeSpecifier;", "public static final")]
	public static Dova.JDK.javax.imageio.ImageTypeSpecifier getDestinationType(Dova.JDK.javax.imageio.ImageReadParam arg0, Dova.JDK.java.util.Iterator arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.imageio.ImageTypeSpecifier>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;)Z", "public static")]
	public static bool isBinary(Dova.JDK.java.awt.image.SampleModel arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;)J", "public static")]
	public static long getTileSize(Dova.JDK.java.awt.image.SampleModel arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/color/ColorSpace;Ljava/awt/image/SampleModel;)Ljava/awt/image/ColorModel;", "public static")]
	public static Dova.JDK.java.awt.image.ColorModel createColorModel(Dova.JDK.java.awt.color.ColorSpace arg0, Dova.JDK.java.awt.image.SampleModel arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;)Ljava/awt/image/ColorModel;", "public static final")]
	public static Dova.JDK.java.awt.image.ColorModel createColorModel(Dova.JDK.java.awt.image.SampleModel arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ColorModel>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/Rectangle;)[B", "public static")]
	public static JavaArray<byte> getUnpackedBinaryData(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BLjava/awt/image/WritableRaster;Ljava/awt/Rectangle;)V", "public static")]
	public static void setUnpackedBinaryData(JavaArray<byte> arg0, Dova.JDK.java.awt.image.WritableRaster arg1, Dova.JDK.java.awt.Rectangle arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;)I", "public static")]
	public static int getElementSize(Dova.JDK.java.awt.image.SampleModel arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/SampleModel;)J", "public static")]
	public static long getBandSize(Dova.JDK.java.awt.image.SampleModel arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B[B[B)Z", "public static")]
	public static bool isIndicesForGrayscale(JavaArray<byte> arg0, JavaArray<byte> arg1, JavaArray<byte> arg2)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String convertObjectToString(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/RenderedImage;)Z", "public static final")]
	public static bool imageIsContiguous(Dova.JDK.java.awt.image.RenderedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/Raster;Ljava/awt/Rectangle;)[B", "public static")]
	public static JavaArray<byte> getPackedBinaryData(Dova.JDK.java.awt.image.Raster arg0, Dova.JDK.java.awt.Rectangle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([BLjava/awt/image/WritableRaster;Ljava/awt/Rectangle;)V", "public static")]
	public static void setPackedBinaryData(JavaArray<byte> arg0, Dova.JDK.java.awt.image.WritableRaster arg1, Dova.JDK.java.awt.Rectangle arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2);
	}
}
