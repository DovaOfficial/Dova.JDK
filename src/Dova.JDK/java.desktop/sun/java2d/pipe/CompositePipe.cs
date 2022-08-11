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

[JniSignatureAttribute("Lsun/java2d/pipe/CompositePipe;", "public abstract interface")]
public partial interface CompositePipe
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CompositePipe()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/java2d/pipe/CompositePipe;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSequence", "(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "needTile", "(Ljava/lang/Object;IIII)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "renderPathTile", "(Ljava/lang/Object;[BIIIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipTile", "(Ljava/lang/Object;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endSequence", "(Ljava/lang/Object;)V"));
	}

	[JniSignatureAttribute("(Lsun/java2d/SunGraphics2D;Ljava/awt/Shape;Ljava/awt/Rectangle;[I)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object startSequence(Dova.JDK.sun.java2d.SunGraphics2D arg0, Dova.JDK.java.awt.Shape arg1, Dova.JDK.java.awt.Rectangle arg2, JavaArray<int> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;IIII)Z", "public abstract")]
	bool needTile(Dova.JDK.java.lang.Object arg0, int arg1, int arg2, int arg3, int arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[BIIIIII)V", "public abstract")]
	void renderPathTile(Dova.JDK.java.lang.Object arg0, JavaArray<byte> arg1, int arg2, int arg3, int arg4, int arg5, int arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;II)V", "public abstract")]
	void skipTile(Dova.JDK.java.lang.Object arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public abstract")]
	void endSequence(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}
}
