/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
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

[JniSignatureAttribute("Ljava/awt/image/renderable/RenderedImageFactory;", "public abstract interface")]
public partial interface RenderedImageFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RenderedImageFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/image/renderable/RenderedImageFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "(Ljava/awt/image/renderable/ParameterBlock;Ljava/awt/RenderingHints;)Ljava/awt/image/RenderedImage;"));
	}

	[JniSignatureAttribute("(Ljava/awt/image/renderable/ParameterBlock;Ljava/awt/RenderingHints;)Ljava/awt/image/RenderedImage;", "public abstract")]
	Dova.JDK.java.awt.image.RenderedImage create(Dova.JDK.java.awt.image.renderable.ParameterBlock arg0, Dova.JDK.java.awt.RenderingHints arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.RenderedImage>(ret);
	}
}
