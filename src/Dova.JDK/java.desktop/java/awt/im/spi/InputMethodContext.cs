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

namespace Dova.JDK.java.awt.im.spi;

[JniSignatureAttribute("Ljava/awt/im/spi/InputMethodContext;", "public abstract interface")]
public partial interface InputMethodContext
	: IJavaObject
	, Dova.JDK.java.awt.im.InputMethodRequests
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputMethodContext()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Ljava/awt/im/spi/InputMethodContext;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "dispatchInputMethodEvent", "(ILjava/text/AttributedCharacterIterator;ILjava/awt/font/TextHitInfo;Ljava/awt/font/TextHitInfo;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createInputMethodJFrame", "(Ljava/lang/String;Z)Ljavax/swing/JFrame;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "enableClientWindowNotification", "(Ljava/awt/im/spi/InputMethod;Z)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createInputMethodWindow", "(Ljava/lang/String;Z)Ljava/awt/Window;"));
	}

	[JniSignatureAttribute("(ILjava/text/AttributedCharacterIterator;ILjava/awt/font/TextHitInfo;Ljava/awt/font/TextHitInfo;)V", "public abstract")]
	void dispatchInputMethodEvent(int arg0, Dova.JDK.java.text.AttributedCharacterIterator arg1, int arg2, Dova.JDK.java.awt.font.TextHitInfo arg3, Dova.JDK.java.awt.font.TextHitInfo arg4)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljavax/swing/JFrame;", "public abstract")]
	Dova.JDK.javax.swing.JFrame createInputMethodJFrame(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JFrame>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/im/spi/InputMethod;Z)V", "public abstract")]
	void enableClientWindowNotification(Dova.JDK.java.awt.im.spi.InputMethod arg0, bool arg1)
	{
		DovaJvm.Vm.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/awt/Window;", "public abstract")]
	Dova.JDK.java.awt.Window createInputMethodWindow(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}
}
