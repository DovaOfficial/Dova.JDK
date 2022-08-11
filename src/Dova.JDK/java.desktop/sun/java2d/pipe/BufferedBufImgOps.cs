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

[JniSignatureAttribute("Lsun/java2d/pipe/BufferedBufImgOps;", "public")]
public partial class BufferedBufImgOps
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BufferedBufImgOps()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/BufferedBufImgOps;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enableConvolveOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/ConvolveOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enableRescaleOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/RescaleOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enableLookupOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/LookupOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disableConvolveOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disableRescaleOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disableLookupOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "enableBufImgOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "disableBufImgOp", "(Lsun/java2d/pipe/RenderQueue;Ljava/awt/image/BufferedImageOp;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isConvolveOpValid", "(Ljava/awt/image/ConvolveOp;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isRescaleOpValid", "(Ljava/awt/image/RescaleOp;Ljava/awt/image/BufferedImage;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isLookupOpValid", "(Ljava/awt/image/LookupOp;Ljava/awt/image/BufferedImage;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferedBufImgOps(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BufferedBufImgOps() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/BufferedBufImgOps;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/ConvolveOp;)V", "private static")]
	public static void enableConvolveOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.ConvolveOp arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/RescaleOp;)V", "private static")]
	public static void enableRescaleOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.RescaleOp arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/LookupOp;)V", "private static")]
	public static void enableLookupOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.LookupOp arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableConvolveOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableRescaleOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableLookupOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;)V", "public static")]
	public static void enableBufImgOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.BufferedImageOp arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Ljava/awt/image/BufferedImageOp;)V", "public static")]
	public static void disableBufImgOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.java.awt.image.BufferedImageOp arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ConvolveOp;)Z", "public static")]
	public static bool isConvolveOpValid(Dova.JDK.java.awt.image.ConvolveOp arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/RescaleOp;Ljava/awt/image/BufferedImage;)Z", "public static")]
	public static bool isRescaleOpValid(Dova.JDK.java.awt.image.RescaleOp arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/LookupOp;Ljava/awt/image/BufferedImage;)Z", "public static")]
	public static bool isLookupOpValid(Dova.JDK.java.awt.image.LookupOp arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}
}
