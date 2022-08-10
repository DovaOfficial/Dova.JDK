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

namespace Dova.JDK.sun.java2d.opengl;

[JniSignatureAttribute("Lsun/java2d/opengl/OGLGraphicsConfig;", "abstract interface")]
public partial interface OGLGraphicsConfig
	: IJavaObject
	, Dova.JDK.sun.java2d.pipe.hw.AccelGraphicsConfig
	, Dova.JDK.sun.awt.image.SurfaceManager.ProxiedGraphicsConfig
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OGLGraphicsConfig()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/opengl/OGLGraphicsConfig;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContext_0", "()Lsun/java2d/pipe/BufferedContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContext_1", "()Lsun/java2d/opengl/OGLContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isCapPresent", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createManagedSurface", "(III)Lsun/java2d/SurfaceData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getNativeConfigInfo", "()J"));
	}

	[JniSignatureAttribute("()Lsun/java2d/pipe/BufferedContext;", "public volatile")]
	Dova.JDK.sun.java2d.pipe.BufferedContext getContext_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.pipe.BufferedContext>(ret);
	}

	[JniSignatureAttribute("()Lsun/java2d/opengl/OGLContext;", "public abstract")]
	Dova.JDK.sun.java2d.opengl.OGLContext getContext_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.opengl.OGLContext>(ret);
	}

	[JniSignatureAttribute("(I)Z", "public abstract")]
	bool isCapPresent(int arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(III)Lsun/java2d/SurfaceData;", "public abstract")]
	Dova.JDK.sun.java2d.SurfaceData createManagedSurface(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.java2d.SurfaceData>(ret);
	}

	[JniSignatureAttribute("()J", "public abstract")]
	long getNativeConfigInfo()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}
}
