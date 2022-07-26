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

namespace Dova.JDK.javax.imageio.@event;

[JniSignatureAttribute("Ljavax/imageio/event/IIOReadUpdateListener;", "public abstract interface")]
public partial interface IIOReadUpdateListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IIOReadUpdateListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/event/IIOReadUpdateListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "passStarted", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIIII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "passComplete", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailPassStarted", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIIII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailUpdate", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIII[I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "thumbnailPassComplete", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "imageUpdate", "(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIII[I)V"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIIII[I)V", "public abstract")]
	void passStarted(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, JavaArray<int> arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;)V", "public abstract")]
	void passComplete(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIIII[I)V", "public abstract")]
	void thumbnailPassStarted(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, JavaArray<int> arg9)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIII[I)V", "public abstract")]
	void thumbnailUpdate(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, JavaArray<int> arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;)V", "public abstract")]
	void thumbnailPassComplete(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;Ljava/awt/image/BufferedImage;IIIIII[I)V", "public abstract")]
	void imageUpdate(Dova.JDK.javax.imageio.ImageReader arg0, Dova.JDK.java.awt.image.BufferedImage arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7, JavaArray<int> arg8)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
	}
}
