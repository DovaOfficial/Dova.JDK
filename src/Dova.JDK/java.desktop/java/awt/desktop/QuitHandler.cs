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

namespace Dova.JDK.java.awt.desktop;

[JniSignatureAttribute("Ljava/awt/desktop/QuitHandler;", "public abstract interface")]
public partial interface QuitHandler
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static QuitHandler()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/awt/desktop/QuitHandler;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleQuitRequestWith", "(Ljava/awt/desktop/QuitEvent;Ljava/awt/desktop/QuitResponse;)V"));
	}

	[JniSignatureAttribute("(Ljava/awt/desktop/QuitEvent;Ljava/awt/desktop/QuitResponse;)V", "public abstract")]
	void handleQuitRequestWith(Dova.JDK.java.awt.desktop.QuitEvent arg0, Dova.JDK.java.awt.desktop.QuitResponse arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}
}
