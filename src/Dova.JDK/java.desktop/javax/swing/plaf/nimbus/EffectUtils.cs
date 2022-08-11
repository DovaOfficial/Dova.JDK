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

[JniSignatureAttribute("Ljavax/swing/plaf/nimbus/EffectUtils;", "")]
public partial class EffectUtils
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static EffectUtils()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/nimbus/EffectUtils;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createColorModelCompatibleImage", "(Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createGaussianKernel", "(I)[F"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPixels", "(Ljava/awt/image/BufferedImage;IIII[I)[I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPixels", "(Ljava/awt/image/BufferedImage;IIII[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "blur", "([B[BII[FI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "blur", "([I[III[FI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clearImage", "(Ljava/awt/image/BufferedImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "gaussianBlur", "(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;I)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createCompatibleTranslucentImage", "(II)Ljava/awt/image/BufferedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPixels", "(Ljava/awt/image/BufferedImage;IIII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setPixels", "(Ljava/awt/image/BufferedImage;IIII[B)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getGraphicsConfiguration", "()Ljava/awt/GraphicsConfiguration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isHeadless", "()Z"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public EffectUtils(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public EffectUtils() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/nimbus/EffectUtils;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)Ljava/awt/image/BufferedImage;", "public static")]
	public static Dova.JDK.java.awt.image.BufferedImage createColorModelCompatibleImage(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(I)[F", "static")]
	public static JavaArray<float> createGaussianKernel(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<float>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;IIII[I)[I", "public static")]
	public static JavaArray<int> getPixels(Dova.JDK.java.awt.image.BufferedImage arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<int> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;IIII[B)[B", "static")]
	public static JavaArray<byte> getPixels(Dova.JDK.java.awt.image.BufferedImage arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<byte> arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("([B[BII[FI)V", "static")]
	public static void blur(JavaArray<byte> arg0, JavaArray<byte> arg1, int arg2, int arg3, JavaArray<float> arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("([I[III[FI)V", "private static")]
	public static void blur(JavaArray<int> arg0, JavaArray<int> arg1, int arg2, int arg3, JavaArray<float> arg4, int arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;)V", "static")]
	public static void clearImage(Dova.JDK.java.awt.image.BufferedImage arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;Ljava/awt/image/BufferedImage;I)Ljava/awt/image/BufferedImage;", "static")]
	public static Dova.JDK.java.awt.image.BufferedImage gaussianBlur(Dova.JDK.java.awt.image.BufferedImage arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/image/BufferedImage;", "public static")]
	public static Dova.JDK.java.awt.image.BufferedImage createCompatibleTranslucentImage(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.BufferedImage>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;IIII[I)V", "public static")]
	public static void setPixels(Dova.JDK.java.awt.image.BufferedImage arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<int> arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/image/BufferedImage;IIII[B)V", "static")]
	public static void setPixels(Dova.JDK.java.awt.image.BufferedImage arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<byte> arg5)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Ljava/awt/GraphicsConfiguration;", "private static")]
	public static Dova.JDK.java.awt.GraphicsConfiguration getGraphicsConfiguration()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.GraphicsConfiguration>(ret);
	}

	[JniSignatureAttribute("()Z", "private static")]
	public static bool isHeadless()
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[12]);
		return ret;
	}
}
