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

namespace Dova.JDK.sun.java2d.xr;

[JniSignatureAttribute("Lsun/java2d/xr/XRGraphicsConfig;", "public")]
public partial class XRGraphicsConfig
	: Dova.JDK.sun.awt.X11GraphicsConfig
	, Dova.JDK.sun.awt.image.SurfaceManager.ProxiedGraphicsConfig
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XRGraphicsConfig()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/xr/XRGraphicsConfig;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11GraphicsDevice;IIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getConfig", "(Lsun/awt/X11GraphicsDevice;IIIZ)Lsun/java2d/xr/XRGraphicsConfig;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSurfaceType", "()Lsun/java2d/loops/SurfaceType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProxyKey", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createSurfaceData", "(Lsun/awt/X11ComponentPeer;)Lsun/java2d/SurfaceData;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XRGraphicsConfig(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;IIIZ)V", "private")]
	public XRGraphicsConfig(Dova.JDK.sun.awt.X11GraphicsDevice arg0, int arg1, int arg2, int arg3, bool arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/java2d/xr/XRGraphicsConfig;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/X11GraphicsDevice;IIIZ)Lsun/java2d/xr/XRGraphicsConfig;", "public static")]
	public static Dova.JDK.sun.java2d.xr.XRGraphicsConfig getConfig(Dova.JDK.sun.awt.X11GraphicsDevice arg0, int arg1, int arg2, int arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.xr.XRGraphicsConfig>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/loops/SurfaceType;", "public synchronized")]
	public Dova.JDK.sun.java2d.loops.SurfaceType getSurfaceType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.loops.SurfaceType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getProxyKey()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lsun/awt/X11ComponentPeer;)Lsun/java2d/SurfaceData;", "public")]
	public Dova.JDK.sun.java2d.SurfaceData createSurfaceData(Dova.JDK.sun.awt.X11ComponentPeer arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}
}
