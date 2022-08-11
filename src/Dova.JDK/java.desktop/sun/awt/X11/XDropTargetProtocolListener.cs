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

[JniSignatureAttribute("Lsun/awt/X11/XDropTargetProtocolListener;", "abstract interface")]
public partial interface XDropTargetProtocolListener
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XDropTargetProtocolListener()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XDropTargetProtocolListener;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleDropTargetNotification", "(Lsun/awt/X11/XWindow;IIII[JJI)V"));
	}

	[JniSignatureAttribute("(Lsun/awt/X11/XWindow;IIII[JJI)V", "public abstract")]
	void handleDropTargetNotification(Dova.JDK.sun.awt.X11.XWindow arg0, int arg1, int arg2, int arg3, int arg4, JavaArray<long> arg5, long arg6, int arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}
}
