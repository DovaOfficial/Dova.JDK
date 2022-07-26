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

[JniSignatureAttribute("Ljavax/swing/text/StyledDocument;", "public abstract interface")]
public partial interface StyledDocument
	: IJavaObject
	, Dova.JDK.javax.swing.text.Document
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StyledDocument()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/StyledDocument;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterElement", "(I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParagraphElement", "(I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterAttributes", "(IILjavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStyle", "(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeStyle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLogicalStyle", "(ILjavax/swing/text/Style;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalStyle", "(I)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParagraphAttributes", "(IILjavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;"));
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "public abstract")]
	Dova.JDK.javax.swing.text.Element getCharacterElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "public abstract")]
	Dova.JDK.javax.swing.text.Element getParagraphElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/AttributeSet;Z)V", "public abstract")]
	void setCharacterAttributes(int arg0, int arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;", "public abstract")]
	Dova.JDK.javax.swing.text.Style addStyle(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.Style arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public abstract")]
	void removeStyle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Style;)V", "public abstract")]
	void setLogicalStyle(int arg0, Dova.JDK.javax.swing.text.Style arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Style;", "public abstract")]
	Dova.JDK.javax.swing.text.Style getLogicalStyle(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/AttributeSet;Z)V", "public abstract")]
	void setParagraphAttributes(int arg0, int arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", "public abstract")]
	Dova.JDK.java.awt.Color getBackground(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", "public abstract")]
	Dova.JDK.java.awt.Color getForeground(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;", "public abstract")]
	Dova.JDK.java.awt.Font getFont(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/Style;", "public abstract")]
	Dova.JDK.javax.swing.text.Style getStyle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}
}
