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

namespace Dova.JDK.sun.awt.im;

[JniSignatureAttribute("Lsun/awt/im/InputMethodWindow;", "public abstract interface")]
public partial interface InputMethodWindow
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputMethodWindow()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/im/InputMethodWindow;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setInputContext", "(Lsun/awt/im/InputContext;)V"));
	}

	[JniSignatureAttribute("(Lsun/awt/im/InputContext;)V", "public abstract")]
	void setInputContext(Dova.JDK.sun.awt.im.InputContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}
}
