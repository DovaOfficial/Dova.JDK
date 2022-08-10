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

namespace Dova.JDK.javax.imageio.@event;

[JniSignatureAttribute("Ljavax/imageio/event/IIOWriteProgressListener;", "public abstract interface")]
public partial interface IIOWriteProgressListener
	: IJavaObject
	, Dova.JDK.java.util.EventListener
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IIOWriteProgressListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/imageio/event/IIOWriteProgressListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "writeAborted", "(Ljavax/imageio/ImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "imageStarted", "(Ljavax/imageio/ImageWriter;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "imageProgress", "(Ljavax/imageio/ImageWriter;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "thumbnailStarted", "(Ljavax/imageio/ImageWriter;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "thumbnailProgress", "(Ljavax/imageio/ImageWriter;F)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "thumbnailComplete", "(Ljavax/imageio/ImageWriter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "imageComplete", "(Ljavax/imageio/ImageWriter;)V"));
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;)V", "public abstract")]
	void writeAborted(Dova.JDK.javax.imageio.ImageWriter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;I)V", "public abstract")]
	void imageStarted(Dova.JDK.javax.imageio.ImageWriter arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;F)V", "public abstract")]
	void imageProgress(Dova.JDK.javax.imageio.ImageWriter arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;II)V", "public abstract")]
	void thumbnailStarted(Dova.JDK.javax.imageio.ImageWriter arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;F)V", "public abstract")]
	void thumbnailProgress(Dova.JDK.javax.imageio.ImageWriter arg0, float arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;)V", "public abstract")]
	void thumbnailComplete(Dova.JDK.javax.imageio.ImageWriter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/imageio/ImageWriter;)V", "public abstract")]
	void imageComplete(Dova.JDK.javax.imageio.ImageWriter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}
}
