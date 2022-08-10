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

namespace Dova.JDK.java.awt.image.renderable;

[JniSignatureAttribute("Ljava/awt/image/renderable/ContextualRenderedImageFactory;", "public abstract interface")]
public partial interface ContextualRenderedImageFactory
	: IJavaObject
	, Dova.JDK.java.awt.image.renderable.RenderedImageFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ContextualRenderedImageFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/renderable/ContextualRenderedImageFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getProperty", "(Ljava/awt/image/renderable/ParameterBlock;Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "(Ljava/awt/image/renderable/RenderContext;Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/image/RenderedImage;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mapRenderContext", "(ILjava/awt/image/renderable/RenderContext;Ljava/awt/image/renderable/ParameterBlock;Ljava/awt/image/renderable/RenderableImage;)Ljava/awt/image/renderable/RenderContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDynamic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPropertyNames", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBounds2D", "(Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/geom/Rectangle2D;"));
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/ParameterBlock;Ljava/lang/String;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object getProperty(Dova.JDK.java.awt.image.renderable.ParameterBlock arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/RenderContext;Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/image/RenderedImage;", "public abstract")]
	Dova.JDK.java.awt.image.RenderedImage create(Dova.JDK.java.awt.image.renderable.RenderContext arg0, Dova.JDK.java.awt.image.renderable.ParameterBlock arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
	}

	[JniSignatureAttribute("(ILjava/awt/image/renderable/RenderContext;Ljava/awt/image/renderable/ParameterBlock;Ljava/awt/image/renderable/RenderableImage;)Ljava/awt/image/renderable/RenderContext;", "public abstract")]
	Dova.JDK.java.awt.image.renderable.RenderContext mapRenderContext(int arg0, Dova.JDK.java.awt.image.renderable.RenderContext arg1, Dova.JDK.java.awt.image.renderable.ParameterBlock arg2, Dova.JDK.java.awt.image.renderable.RenderableImage arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.renderable.RenderContext>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isDynamic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "public abstract")]
	JavaArray<Dova.JDK.java.lang.String> getPropertyNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/ParameterBlock;)Ljava/awt/geom/Rectangle2D;", "public abstract")]
	Dova.JDK.java.awt.geom.Rectangle2D getBounds2D(Dova.JDK.java.awt.image.renderable.ParameterBlock arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.geom.Rectangle2D>(ret);
	}
}
