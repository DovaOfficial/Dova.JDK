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

namespace Dova.JDK.sun.java2d.pipe.hw;

[JniSignatureAttribute("Lsun/java2d/pipe/hw/AccelGraphicsConfig;", "public abstract interface")]
public partial interface AccelGraphicsConfig
	: IJavaObject
	, Dova.JDK.sun.java2d.pipe.hw.BufferedContextProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccelGraphicsConfig()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/java2d/pipe/hw/AccelGraphicsConfig;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createCompatibleVolatileImage", "(IIII)Ljava/awt/image/VolatileImage;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getContextCapabilities", "()Lsun/java2d/pipe/hw/ContextCapabilities;"));
	}

	[JniSignatureAttribute("(IIII)Ljava/awt/image/VolatileImage;", "public abstract")]
	Dova.JDK.java.awt.image.VolatileImage createCompatibleVolatileImage(int arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.image.VolatileImage>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/pipe/hw/ContextCapabilities;", "public abstract")]
	Dova.JDK.sun.java2d.pipe.hw.ContextCapabilities getContextCapabilities()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.hw.ContextCapabilities>(ret);
	}
}
