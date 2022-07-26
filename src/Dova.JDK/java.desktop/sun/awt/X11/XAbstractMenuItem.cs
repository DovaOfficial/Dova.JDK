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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XAbstractMenuItem;", "public abstract interface")]
public partial interface XAbstractMenuItem
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XAbstractMenuItem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XAbstractMenuItem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWidth", "(Ljava/awt/Graphics;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeight", "(Ljava/awt/Graphics;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;IIIIZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getShortcutWidth", "(Ljava/awt/Graphics;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setMenuPeer", "(Lsun/awt/X11/XMenuPeer;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)I", "public abstract")]
	int getWidth(Dova.JDK.java.awt.Graphics arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)I", "public abstract")]
	int getHeight(Dova.JDK.java.awt.Graphics arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;IIIIZ)V", "public abstract")]
	void paint(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, bool arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getLabel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)I", "public abstract")]
	int getShortcutWidth(Dova.JDK.java.awt.Graphics arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XMenuPeer;)V", "public abstract")]
	void setMenuPeer(Dova.JDK.sun.awt.X11.XMenuPeer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}
}
