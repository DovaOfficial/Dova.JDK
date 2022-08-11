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

namespace Dova.JDK.java.awt;

[JniSignatureAttribute("Ljava/awt/Composite;", "public abstract interface")]
public partial interface Composite
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Composite()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/Composite;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createContext", "(Ljava/awt/image/ColorModel;Ljava/awt/image/ColorModel;Ljava/awt/RenderingHints;)Ljava/awt/CompositeContext;"));
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;Ljava/awt/image/ColorModel;Ljava/awt/RenderingHints;)Ljava/awt/CompositeContext;", "public abstract")]
	Dova.JDK.java.awt.CompositeContext createContext(Dova.JDK.java.awt.image.ColorModel arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.RenderingHints arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.CompositeContext>(ret);
	}
}
