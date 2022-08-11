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

namespace Dova.JDK.javax.accessibility;

[JniSignatureAttribute("Ljavax/accessibility/AccessibleComponent;", "public abstract interface")]
public partial interface AccessibleComponent
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AccessibleComponent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/accessibility/AccessibleComponent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljava/awt/Point;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds", "()Ljava/awt/Rectangle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSize", "(Ljava/awt/Dimension;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEnabled", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isVisible", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljava/awt/Point;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBackground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getForeground", "()Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFont", "()Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFontMetrics", "(Ljava/awt/Font;)Ljava/awt/FontMetrics;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isShowing", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationOnScreen", "()Ljava/awt/Point;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(Ljava/awt/Rectangle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addFocusListener", "(Ljava/awt/event/FocusListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "(Ljava/awt/Cursor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCursor", "()Ljava/awt/Cursor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeFocusListener", "(Ljava/awt/event/FocusListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleAt", "(Ljava/awt/Point;)Ljavax/accessibility/Accessible;"));
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Z", "public abstract")]
	bool contains(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Rectangle;", "public abstract")]
	Dova.JDK.java.awt.Rectangle getBounds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Rectangle>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public abstract")]
	Dova.JDK.java.awt.Point getLocation()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public abstract")]
	Dova.JDK.java.awt.Dimension getSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Dimension;)V", "public abstract")]
	void setSize(Dova.JDK.java.awt.Dimension arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isEnabled()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isVisible()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)V", "public abstract")]
	void setLocation(Dova.JDK.java.awt.Point arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public abstract")]
	Dova.JDK.java.awt.Color getBackground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Color;", "public abstract")]
	Dova.JDK.java.awt.Color getForeground()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Font;", "public abstract")]
	Dova.JDK.java.awt.Font getFont()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)Ljava/awt/FontMetrics;", "public abstract")]
	Dova.JDK.java.awt.FontMetrics getFontMetrics(Dova.JDK.java.awt.Font arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.FontMetrics>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public abstract")]
	void setBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isShowing()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/Point;", "public abstract")]
	Dova.JDK.java.awt.Point getLocationOnScreen()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public abstract")]
	void setEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Rectangle;)V", "public abstract")]
	void setBounds(Dova.JDK.java.awt.Rectangle arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public abstract")]
	void setForeground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)V", "public abstract")]
	void setFont(Dova.JDK.java.awt.Font arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("()V", "public abstract")]
	void requestFocus()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()Z", "public abstract")]
	bool isFocusTraversable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public abstract")]
	void addFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public abstract")]
	void setCursor(Dova.JDK.java.awt.Cursor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Cursor;", "public abstract")]
	Dova.JDK.java.awt.Cursor getCursor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusListener;)V", "public abstract")]
	void removeFocusListener(Dova.JDK.java.awt.@event.FocusListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Point;)Ljavax/accessibility/Accessible;", "public abstract")]
	Dova.JDK.javax.accessibility.Accessible getAccessibleAt(Dova.JDK.java.awt.Point arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.Accessible>(ret);
	}
}
