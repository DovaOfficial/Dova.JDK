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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/Keymap;", "public abstract interface")]
public partial interface Keymap
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Keymap()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/Keymap;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDefaultAction", "(Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addActionForKeyStroke", "(Ljavax/swing/KeyStroke;Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultAction", "()Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolveParent", "()Ljavax/swing/text/Keymap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBoundKeyStrokes", "()[Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBoundActions", "()[Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getKeyStrokesForAction", "(Ljavax/swing/Action;)[Ljavax/swing/KeyStroke;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isLocallyDefined", "(Ljavax/swing/KeyStroke;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeKeyStrokeBinding", "(Ljavax/swing/KeyStroke;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeBindings", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAction", "(Ljavax/swing/KeyStroke;)Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setResolveParent", "(Ljavax/swing/text/Keymap;)V"));
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "public abstract")]
	void setDefaultAction(Dova.JDK.javax.swing.Action arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;Ljavax/swing/Action;)V", "public abstract")]
	void addActionForKeyStroke(Dova.JDK.javax.swing.KeyStroke arg0, Dova.JDK.javax.swing.Action arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/Action;", "public abstract")]
	Dova.JDK.javax.swing.Action getDefaultAction()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Keymap;", "public abstract")]
	Dova.JDK.javax.swing.text.Keymap getResolveParent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Keymap>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/KeyStroke;", "public abstract")]
	JavaArray<Dova.JDK.javax.swing.KeyStroke> getBoundKeyStrokes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.KeyStroke>>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/swing/Action;", "public abstract")]
	JavaArray<Dova.JDK.javax.swing.Action> getBoundActions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.Action>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)[Ljavax/swing/KeyStroke;", "public abstract")]
	JavaArray<Dova.JDK.javax.swing.KeyStroke> getKeyStrokesForAction(Dova.JDK.javax.swing.Action arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.KeyStroke>>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;)Z", "public abstract")]
	bool isLocallyDefined(Dova.JDK.javax.swing.KeyStroke arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;)V", "public abstract")]
	void removeKeyStrokeBinding(Dova.JDK.javax.swing.KeyStroke arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void removeBindings()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljavax/swing/KeyStroke;)Ljavax/swing/Action;", "public abstract")]
	Dova.JDK.javax.swing.Action getAction(Dova.JDK.javax.swing.KeyStroke arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.Action>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Keymap;)V", "public abstract")]
	void setResolveParent(Dova.JDK.javax.swing.text.Keymap arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}
}
