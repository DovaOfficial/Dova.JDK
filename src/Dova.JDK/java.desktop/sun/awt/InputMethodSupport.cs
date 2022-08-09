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

namespace Dova.JDK.sun.awt;

[JniSignatureAttribute("Lsun/awt/InputMethodSupport;", "public abstract interface")]
public partial interface InputMethodSupport
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static InputMethodSupport()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/awt/InputMethodSupport;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "createInputMethodWindow", "(Ljava/lang/String;Lsun/awt/im/InputContext;)Ljava/awt/Window;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "enableInputMethodsForTextComponent", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDefaultKeyboardLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInputMethodAdapterDescriptor", "()Ljava/awt/im/spi/InputMethodDescriptor;"));
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/awt/im/InputContext;)Ljava/awt/Window;", "public abstract")]
	Dova.JDK.java.awt.Window createInputMethodWindow(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.awt.im.InputContext arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool enableInputMethodsForTextComponent()
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public abstract")]
	Dova.JDK.java.util.Locale getDefaultKeyboardLocale()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/im/spi/InputMethodDescriptor;", "public abstract")]
	Dova.JDK.java.awt.im.spi.InputMethodDescriptor getInputMethodAdapterDescriptor()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.im.spi.InputMethodDescriptor>(ret);
	}
}