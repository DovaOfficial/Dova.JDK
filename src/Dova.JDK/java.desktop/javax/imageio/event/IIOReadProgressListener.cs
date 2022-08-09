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

namespace Dova.JDK.javax.imageio.@event;

[JniSignatureAttribute("Ljavax/imageio/event/IIOReadProgressListener;", "public abstract interface")]
public partial interface IIOReadProgressListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IIOReadProgressListener()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljavax/imageio/event/IIOReadProgressListener;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "imageComplete", "(Ljavax/imageio/ImageReader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sequenceStarted", "(Ljavax/imageio/ImageReader;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "sequenceComplete", "(Ljavax/imageio/ImageReader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "imageStarted", "(Ljavax/imageio/ImageReader;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "imageProgress", "(Ljavax/imageio/ImageReader;F)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "thumbnailStarted", "(Ljavax/imageio/ImageReader;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "thumbnailProgress", "(Ljavax/imageio/ImageReader;F)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "thumbnailComplete", "(Ljavax/imageio/ImageReader;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "readAborted", "(Ljavax/imageio/ImageReader;)V"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public abstract")]
	void imageComplete(Dova.JDK.javax.imageio.ImageReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;I)V", "public abstract")]
	void sequenceStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public abstract")]
	void sequenceComplete(Dova.JDK.javax.imageio.ImageReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;I)V", "public abstract")]
	void imageStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;F)V", "public abstract")]
	void imageProgress(Dova.JDK.javax.imageio.ImageReader arg0, float arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;II)V", "public abstract")]
	void thumbnailStarted(Dova.JDK.javax.imageio.ImageReader arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;F)V", "public abstract")]
	void thumbnailProgress(Dova.JDK.javax.imageio.ImageReader arg0, float arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public abstract")]
	void thumbnailComplete(Dova.JDK.javax.imageio.ImageReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageReader;)V", "public abstract")]
	void readAborted(Dova.JDK.javax.imageio.ImageReader arg0)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}
}
