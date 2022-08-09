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
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/Composite;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createContext", "(Ljava/awt/image/ColorModel;Ljava/awt/image/ColorModel;Ljava/awt/RenderingHints;)Ljava/awt/CompositeContext;"));
	}

	[JniSignatureAttribute("(Ljava/awt/image/ColorModel;Ljava/awt/image/ColorModel;Ljava/awt/RenderingHints;)Ljava/awt/CompositeContext;", "public abstract")]
	Dova.JDK.java.awt.CompositeContext createContext(Dova.JDK.java.awt.image.ColorModel arg0, Dova.JDK.java.awt.image.ColorModel arg1, Dova.JDK.java.awt.RenderingHints arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.CompositeContext>(ret);
	}
}