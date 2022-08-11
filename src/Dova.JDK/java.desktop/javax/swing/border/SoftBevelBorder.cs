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

namespace Dova.JDK.javax.swing.border;

[JniSignatureAttribute("Ljavax/swing/border/SoftBevelBorder;", "public")]
public partial class SoftBevelBorder
	: Dova.JDK.javax.swing.border.BevelBorder
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SoftBevelBorder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/border/SoftBevelBorder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/awt/Color;Ljava/awt/Color;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBorderOpaque", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljava/awt/Component;Ljava/awt/Graphics;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorderInsets", "(Ljava/awt/Component;Ljava/awt/Insets;)Ljava/awt/Insets;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SoftBevelBorder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;Ljava/awt/Color;)V", "public")]
	public SoftBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2, Dova.JDK.java.awt.Color arg3, Dova.JDK.java.awt.Color arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(ILjava/awt/Color;Ljava/awt/Color;)V", "public")]
	public SoftBevelBorder(int arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(I)V", "public")]
	public SoftBevelBorder(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/border/SoftBevelBorder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Z", "public")]
	public bool isBorderOpaque()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Graphics;IIII)V", "public")]
	public void paintBorder(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Insets;)Ljava/awt/Insets;", "public")]
	public Dova.JDK.java.awt.Insets getBorderInsets(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Insets arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
	}
}
