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

namespace Dova.JDK.sun.java2d.pipe;

[JniSignatureAttribute("Lsun/java2d/pipe/PixelFillPipe;", "public abstract interface")]
public partial interface PixelFillPipe
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static PixelFillPipe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/PixelFillPipe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillPolygon", "(Lsun/java2d/SunGraphics2D;[I[II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRoundRect", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillOval", "(Lsun/java2d/SunGraphics2D;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillArc", "(Lsun/java2d/SunGraphics2D;IIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fillRect", "(Lsun/java2d/SunGraphics2D;IIII)V"));
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;[I[II)V", "public abstract")]
	void fillPolygon(Dova.JDK.sun.java2d.SunGraphics2D arg0, JavaArray<int> arg1, JavaArray<int> arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public abstract")]
	void fillRoundRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public abstract")]
	void fillOval(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIIIII)V", "public abstract")]
	void fillArc(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;IIII)V", "public abstract")]
	void fillRect(Dova.JDK.sun.java2d.SunGraphics2D arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
	}
}
