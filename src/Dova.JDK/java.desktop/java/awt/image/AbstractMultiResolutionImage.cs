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

namespace Dova.JDK.java.awt.image;

[JniSignatureAttribute("Ljava/awt/image/AbstractMultiResolutionImage;", "public abstract")]
public partial class AbstractMultiResolutionImage
	: Dova.JDK.java.awt.Image
	, Dova.JDK.java.awt.image.MultiResolutionImage
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractMultiResolutionImage()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/AbstractMultiResolutionImage;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperty", "(Ljava/lang/String;Ljava/awt/image/ImageObserver;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource", "()Ljava/awt/image/ImageProducer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseImage", "()Ljava/awt/Image;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "(Ljava/awt/image/ImageObserver;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "(Ljava/awt/image/ImageObserver;)I"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractMultiResolutionImage(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public AbstractMultiResolutionImage() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/awt/image/AbstractMultiResolutionImage;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/awt/image/ImageObserver;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.awt.image.ImageObserver arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/image/ImageProducer;", "public")]
	public Dova.JDK.java.awt.image.ImageProducer getSource()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.ImageProducer>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Image;", "protected abstract")]
	public Dova.JDK.java.awt.Image getBaseImage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Image>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
	public Dova.JDK.java.awt.Graphics getGraphics()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)I", "public")]
	public int getWidth(Dova.JDK.java.awt.image.ImageObserver arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/image/ImageObserver;)I", "public")]
	public int getHeight(Dova.JDK.java.awt.image.ImageObserver arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}
}
