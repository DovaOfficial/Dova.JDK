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

namespace Dova.JDK.sun.awt.im;

[JniSignatureAttribute("Lsun/awt/im/SimpleInputMethodWindow;", "public")]
public partial class SimpleInputMethodWindow
	: Dova.JDK.java.awt.Frame
	, Dova.JDK.sun.awt.im.InputMethodWindow
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SimpleInputMethodWindow()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/im/SimpleInputMethodWindow;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inputContext", "Lsun/awt/im/InputContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SimpleInputMethodWindow", "(Ljava/lang/String;Lsun/awt/im/InputContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInputContext", "(Lsun/awt/im/InputContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInputContext", "()Ljava/awt/im/InputContext;"));
	}

	[JniSignatureAttribute("Lsun/awt/im/InputContext;", "")]
	public Dova.JDK.sun.awt.im.InputContext inputContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.im.InputContext>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SimpleInputMethodWindow(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lsun/awt/im/InputContext;)V", "public")]
	public SimpleInputMethodWindow(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.awt.im.InputContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/im/SimpleInputMethodWindow;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lsun/awt/im/InputContext;)V", "public")]
	public void setInputContext(Dova.JDK.sun.awt.im.InputContext arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/im/InputContext;", "public")]
	public Dova.JDK.java.awt.im.InputContext getInputContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.im.InputContext>(ret);
	}
}
