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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/RequestFocusController;", "public abstract interface")]
public partial interface RequestFocusController
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RequestFocusController()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/RequestFocusController;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "acceptRequestFocus", "(Ljava/awt/Component;Ljava/awt/Component;ZZLjava/awt/event/FocusEvent$Cause;)Z"));
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Component;ZZLjava/awt/event/FocusEvent$Cause;)Z", "public abstract")]
	bool acceptRequestFocus(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Component arg1, bool arg2, bool arg3, Dova.JDK.java.awt.@event.FocusEvent.Cause arg4)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}
}
