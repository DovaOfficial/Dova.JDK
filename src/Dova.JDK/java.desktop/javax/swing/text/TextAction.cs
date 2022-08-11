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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/TextAction;", "public abstract")]
public partial class TextAction
	: Dova.JDK.javax.swing.AbstractAction
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextAction()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/TextAction;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "augmentList", "([Ljavax/swing/Action;[Ljavax/swing/Action;)[Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFocusedComponent", "()Ljavax/swing/text/JTextComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextComponent", "(Ljava/awt/event/ActionEvent;)Ljavax/swing/text/JTextComponent;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TextAction(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public TextAction(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/TextAction;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("([Ljavax/swing/Action;[Ljavax/swing/Action;)[Ljavax/swing/Action;", "public static final")]
	public static JavaArray<Dova.JDK.javax.swing.Action> augmentList(JavaArray<Dova.JDK.javax.swing.Action> arg0, JavaArray<Dova.JDK.javax.swing.Action> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.Action>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/JTextComponent;", "protected final")]
	public Dova.JDK.javax.swing.text.JTextComponent getFocusedComponent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)Ljavax/swing/text/JTextComponent;", "protected final")]
	public Dova.JDK.javax.swing.text.JTextComponent getTextComponent(Dova.JDK.java.awt.@event.ActionEvent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
	}
}
