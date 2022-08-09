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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/java2d/pipe/BufferedBufImgOps;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "BufferedBufImgOps", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "enableConvolveOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/ConvolveOp;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "enableRescaleOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/RescaleOp;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "enableLookupOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/LookupOp;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "disableConvolveOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "disableRescaleOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "disableLookupOp", "(Lsun/java2d/pipe/RenderQueue;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "enableBufImgOp", "(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "disableBufImgOp", "(Lsun/java2d/pipe/RenderQueue;Ljava/awt/image/BufferedImageOp;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isConvolveOpValid", "(Ljava/awt/image/ConvolveOp;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isRescaleOpValid", "(Ljava/awt/image/RescaleOp;Ljava/awt/image/BufferedImage;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "isLookupOpValid", "(Ljava/awt/image/LookupOp;Ljava/awt/image/BufferedImage;)Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public BufferedBufImgOps(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BufferedBufImgOps() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/pipe/BufferedBufImgOps;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/ConvolveOp;)V", "private static")]
	public static void enableConvolveOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.ConvolveOp arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/RescaleOp;)V", "private static")]
	public static void enableRescaleOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.RescaleOp arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/LookupOp;)V", "private static")]
	public static void enableLookupOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.LookupOp arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableConvolveOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableRescaleOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;)V", "private static")]
	public static void disableLookupOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Lsun/java2d/SurfaceData;Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImageOp;)V", "public static")]
	public static void enableBufImgOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.sun.java2d.SurfaceData arg1, Dova.JDK.java.awt.image.BufferedImage arg2, Dova.JDK.java.awt.image.BufferedImageOp arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/pipe/RenderQueue;Ljava/awt/image/BufferedImageOp;)V", "public static")]
	public static void disableBufImgOp(Dova.JDK.sun.java2d.pipe.RenderQueue arg0, Dova.JDK.java.awt.image.BufferedImageOp arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ConvolveOp;)Z", "public static")]
	public static bool isConvolveOpValid(Dova.JDK.java.awt.image.ConvolveOp arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/RescaleOp;Ljava/awt/image/BufferedImage;)Z", "public static")]
	public static bool isRescaleOpValid(Dova.JDK.java.awt.image.RescaleOp arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/LookupOp;Ljava/awt/image/BufferedImage;)Z", "public static")]
	public static bool isLookupOpValid(Dova.JDK.java.awt.image.LookupOp arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}
}
