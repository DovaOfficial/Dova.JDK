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

namespace Dova.JDK.sun.awt.X11;

[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer;", "final")]
public partial class XTextAreaPeer
	: Dova.JDK.sun.awt.X11.XComponentPeer
	, Dova.JDK.java.awt.peer.TextAreaPeer
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static XTextAreaPeer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textPane", "Lsun/awt/X11/XTextAreaPeer$AWTTextPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jtext", "Lsun/awt/X11/XTextAreaPeer$AWTTextArea;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstChangeSkipped", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaMouseEventHandler", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/awt/TextArea;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insert", "(Ljava/lang/String;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispose", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setText", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditable", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionEnd", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "select", "(II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSelectionStart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCaretPosition", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaretPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaMouseEvent", "(Ljava/awt/event/MouseEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaKeyEvent", "(Ljava/awt/event/KeyEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaMouseWheelEvent", "(Ljava/awt/event/MouseWheelEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleJavaInputMethodEvent", "(Ljava/awt/event/InputMethodEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTextImpl", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setScrollBarVisibility", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaintText", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setForeground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFont", "(Ljava/awt/Font;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEnabled", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setVisible", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "(II)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintPeer", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pSetCursor", "(Ljava/awt/Cursor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceRange", "(Ljava/lang/String;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaint", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "(II)Ljava/awt/Dimension;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBackground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBounds", "(IIIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handlesWheelScrolling", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputMethodRequests", "()Ljava/awt/im/InputMethodRequests;"));
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextPane;", "private final")]
	public Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextPane textPane_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextPane>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextArea;", "private final")]
	public Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextArea jtext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextArea>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool firstChangeSkipped_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler;", "private final")]
	public Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler javaMouseEventHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public XTextAreaPeer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/awt/TextArea;)V", "")]
	public XTextAreaPeer(Dova.JDK.java.awt.TextArea arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
	public void insert(Dova.JDK.java.lang.String arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void dispose()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void setText(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEditable(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectionEnd()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(II)V", "public")]
	public void select(int arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSelectionStart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setCaretPosition(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getCaretPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
	public void handleJavaMouseEvent(Dova.JDK.java.awt.@event.MouseEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/KeyEvent;)V", "")]
	public void handleJavaKeyEvent(Dova.JDK.java.awt.@event.KeyEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/MouseWheelEvent;)V", "")]
	public void handleJavaMouseWheelEvent(Dova.JDK.java.awt.@event.MouseWheelEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;)V", "")]
	public void handleJavaInputMethodEvent(Dova.JDK.java.awt.@event.InputMethodEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void setTextImpl(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void setScrollBarVisibility()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15]);
	}

	[JniSignatureAttribute("()V", "")]
	public void repaintText()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setForeground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)V", "public")]
	public void setFont(Dova.JDK.java.awt.Font arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
	public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setEnabled(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setVisible(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getPreferredSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "")]
	public void paintPeer(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;Z)V", "public")]
	public void pSetCursor(Dova.JDK.java.awt.Cursor arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)V", "public")]
	public void replaceRange(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()V", "public")]
	public void repaint()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27]);
	}

	[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/awt/Dimension;", "public")]
	public Dova.JDK.java.awt.Dimension getMinimumSize(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "public")]
	public void setBackground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(IIIII)V", "public")]
	public void setBounds(int arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFocusable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[32]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool handlesWheelScrolling()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/awt/im/InputMethodRequests;", "public")]
	public Dova.JDK.java.awt.im.InputMethodRequests getInputMethodRequests()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.im.InputMethodRequests>(ret);
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler;", "private static final")]
	public partial class JavaMouseEventHandler
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JavaMouseEventHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "outer", "Lsun/awt/X11/XTextAreaPeer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "current", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "grabbed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11/XTextAreaPeer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dispatch", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handle", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointerToUnderPoint", "(Ljava/awt/Point;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "grabbed_update", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toViewportChildLocalSpace", "(Ljavax/swing/JViewport;Ljava/awt/Point;)Ljava/awt/Point;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newMouseEvent", "(Ljava/awt/Component;Ljava/awt/Point;Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toLocalSpace", "(Ljava/awt/Component;Ljava/awt/Point;)Ljava/awt/Point;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointerIfPointOverScrollbar", "(Ljavax/swing/JScrollBar;Ljava/awt/Point;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPointerIfPointOverButton", "(Ljavax/swing/JButton;Ljava/awt/Point;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCursor", "()V"));
		}

		[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer;", "private final")]
		public Dova.JDK.sun.awt.X11.XTextAreaPeer outer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer;", "private final")]
		public Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer current_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool grabbed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JavaMouseEventHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/awt/X11/XTextAreaPeer;)V", "")]
		public JavaMouseEventHandler(Dova.JDK.sun.awt.X11.XTextAreaPeer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "private")]
		public void dispatch(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "")]
		public void handle(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Point;)V", "private")]
		public void setPointerToUnderPoint(Dova.JDK.java.awt.Point arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "private")]
		public void grabbed_update(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/JViewport;Ljava/awt/Point;)Ljava/awt/Point;", "private static")]
		public static Dova.JDK.java.awt.Point toViewportChildLocalSpace(Dova.JDK.javax.swing.JViewport arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Point;Ljava/awt/event/MouseEvent;)Ljava/awt/event/MouseEvent;", "private static")]
		public static Dova.JDK.java.awt.@event.MouseEvent newMouseEvent(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Point arg1, Dova.JDK.java.awt.@event.MouseEvent arg2)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.@event.MouseEvent>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;Ljava/awt/Point;)Ljava/awt/Point;", "private static")]
		public static Dova.JDK.java.awt.Point toLocalSpace(Dova.JDK.java.awt.Component arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Point>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JScrollBar;Ljava/awt/Point;)Z", "private")]
		public bool setPointerIfPointOverScrollbar(Dova.JDK.javax.swing.JScrollBar arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JButton;Ljava/awt/Point;)Z", "private")]
		public bool setPointerIfPointOverButton(Dova.JDK.javax.swing.JButton arg0, Dova.JDK.java.awt.Point arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()V", "private")]
		public void setCursor()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer;", "private static final")]
		public partial class Pointer
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Pointer()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bar", "Ljavax/swing/JScrollBar;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "button", "Ljavax/swing/JButton;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setText", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBar", "()Ljavax/swing/JScrollBar;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setNone", "()V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setBar", "(Ljavax/swing/JScrollBar;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setButton", "(Ljavax/swing/JButton;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNone", "()Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getButton", "()Ljavax/swing/JButton;"));
			}

			[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "private")]
			public Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type type_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JScrollBar;", "private")]
			public Dova.JDK.javax.swing.JScrollBar bar_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JScrollBar>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljavax/swing/JButton;", "private")]
			public Dova.JDK.javax.swing.JButton button_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "static final")]
			public static bool assertionsDisabled_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Pointer(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("()V", "private")]
			public Pointer() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "")]
			public Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type getType()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void setText()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
			}

			[JniSignatureAttribute("()Ljavax/swing/JScrollBar;", "")]
			public Dova.JDK.javax.swing.JScrollBar getBar()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JScrollBar>(ret);
			}

			[JniSignatureAttribute("()V", "")]
			public void setNone()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
			}

			[JniSignatureAttribute("(Ljavax/swing/JScrollBar;)V", "")]
			public void setBar(Dova.JDK.javax.swing.JScrollBar arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("(Ljavax/swing/JButton;)V", "")]
			public void setButton(Dova.JDK.javax.swing.JButton arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("()Z", "")]
			public bool isNone()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
				return ret;
			}

			[JniSignatureAttribute("()Ljavax/swing/JButton;", "")]
			public Dova.JDK.javax.swing.JButton getButton()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
			}

			[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "static final")]
			public partial class Type
				: Dova.JDK.java.lang.Enum
			{
				public new static CSharpSystem.IntPtr ClassPtr { get; }
				public new static CSharpSystem.IntPtr ClassRefPtr { get; }

				private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
				private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

				static Type()
				{
					ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;");
					ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAR", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BUTTON", "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
					MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;"));
				}

				[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static final")]
				public static Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type NONE_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static final")]
				public static Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type TEXT_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static final")]
				public static Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type BAR_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static final")]
				public static Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type BUTTON_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
						return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "private static final")]
				public static JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type> VALUES_Property
				{
					get
					{
						var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
						return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>>(ret);
					}
					set
					{
						DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
					}
				}

				[JniSignatureAttribute("(System.IntPtr)V", "public")]
				public Type(IntPtr currentRefPtr) : base(currentRefPtr)
				{
				}

				[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
				public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
				{
				}

				public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;";
				public override IntPtr GetJavaClassRaw() => ClassPtr;
				public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

				[JniSignatureAttribute("()[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static")]
				public static JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type> values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>>(ret);
				}

				[JniSignatureAttribute("(Ljava/lang/String;)Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "public static")]
				public static Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type valueOf(Dova.JDK.java.lang.String arg0)
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>(ret);
				}

				[JniSignatureAttribute("()[Lsun/awt/X11/XTextAreaPeer$JavaMouseEventHandler$Pointer$Type;", "private static")]
				public static JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type> _values()
				{
					var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.sun.awt.X11.XTextAreaPeer.JavaMouseEventHandler.Pointer.Type>>(ret);
				}
			}
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextArea;", "static final")]
	public partial class AWTTextArea
		: Dova.JDK.javax.swing.JTextArea
		, Dova.JDK.javax.swing.@event.DocumentListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWTTextArea()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$AWTTextArea;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isFocused", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "peer", "Lsun/awt/X11/XTextAreaPeer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lsun/awt/X11/XTextAreaPeer;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "repaintNow", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardFocusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forwardFocusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processInputMethodEventPublic", "(Ljava/awt/event/InputMethodEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "changedUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseEventPublic", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processMouseMotionEventPublic", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTransferHandler", "(Ljavax/swing/TransferHandler;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasFocus", "()Z"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isFocused_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer;", "private final")]
		public Dova.JDK.sun.awt.X11.XTextAreaPeer peer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AWTTextArea(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lsun/awt/X11/XTextAreaPeer;)V", "")]
		public AWTTextArea(Dova.JDK.java.lang.String arg0, Dova.JDK.sun.awt.X11.XTextAreaPeer arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$AWTTextArea;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void repaintNow()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "")]
		public void forwardFocusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "")]
		public void forwardFocusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/InputMethodEvent;)V", "public")]
		public void processInputMethodEventPublic(Dova.JDK.java.awt.@event.InputMethodEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void insertUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void removeUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "public")]
		public void changedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void processMouseEventPublic(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void processMouseMotionEventPublic(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateUI()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("(Ljavax/swing/TransferHandler;)V", "public")]
		public void setTransferHandler(Dova.JDK.javax.swing.TransferHandler arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool hasFocus()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextPane;", "private static")]
	public partial class AWTTextPane
		: Dova.JDK.javax.swing.JScrollPane
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWTTextPane()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$AWTTextPane;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jtext", "Ljavax/swing/JTextArea;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "xwin", "Lsun/awt/X11/XWindow;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "control", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "focus", "Ljava/awt/Color;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JTextArea;Lsun/awt/X11/XWindow;Ljava/awt/Container;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRealParent", "()Ljava/awt/Window;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTextArea", "()Ljavax/swing/JTextArea;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createVerticalScrollBar", "()Ljavax/swing/JScrollBar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createHorizontalScrollBar", "()Ljavax/swing/JScrollBar;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invalidate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGraphics", "()Ljava/awt/Graphics;"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTextArea;", "private final")]
		public Dova.JDK.javax.swing.JTextArea jtext_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextArea>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lsun/awt/X11/XWindow;", "private final")]
		public Dova.JDK.sun.awt.X11.XWindow xwin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XWindow>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private final")]
		public Dova.JDK.java.awt.Color control_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private final")]
		public Dova.JDK.java.awt.Color focus_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AWTTextPane(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JTextArea;Lsun/awt/X11/XWindow;Ljava/awt/Container;)V", "")]
		public AWTTextPane(Dova.JDK.javax.swing.JTextArea arg0, Dova.JDK.sun.awt.X11.XWindow arg1, Dova.JDK.java.awt.Container arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$AWTTextPane;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Window;", "public")]
		public Dova.JDK.java.awt.Window getRealParent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Window>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JTextArea;", "public")]
		public Dova.JDK.javax.swing.JTextArea getTextArea()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextArea>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JScrollBar;", "public")]
		public Dova.JDK.javax.swing.JScrollBar createVerticalScrollBar()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JScrollBar>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JScrollBar;", "public")]
		public Dova.JDK.javax.swing.JScrollBar createHorizontalScrollBar()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JScrollBar>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void invalidate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void updateUI()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("()Ljava/awt/Graphics;", "public")]
		public Dova.JDK.java.awt.Graphics getGraphics()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Graphics>(ret);
		}

		[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextPane$XAWTScrollBar;", "final")]
		public partial class XAWTScrollBar
			: Dova.JDK.javax.swing.JScrollPane.ScrollBar
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static XAWTScrollBar()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$AWTTextPane$XAWTScrollBar;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/awt/X11/XTextAreaPeer$AWTTextPane;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/awt/X11/XTextAreaPeer$AWTTextPane;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
			}

			[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextPane;", "final")]
			public Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextPane this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextPane>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public XAWTScrollBar(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lsun/awt/X11/XTextAreaPeer$AWTTextPane;I)V", "")]
			public XAWTScrollBar(Dova.JDK.sun.awt.X11.XTextAreaPeer.AWTTextPane arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$AWTTextPane$XAWTScrollBar;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()V", "public")]
			public void updateUI()
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
			}
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$BevelBorder;", "static")]
	public partial class BevelBorder
		: Dova.JDK.javax.swing.border.AbstractBorder
		, Dova.JDK.javax.swing.plaf.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BevelBorder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$BevelBorder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "darkShadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightShadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "control", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isRaised", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLjava/awt/Color;Ljava/awt/Color;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpaque", "(Ljava/awt/Component;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljava/awt/Component;Ljava/awt/Graphics;IIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorderInsets", "(Ljava/awt/Component;Ljava/awt/Insets;)Ljava/awt/Insets;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBorderInsets", "(Ljava/awt/Component;)Ljava/awt/Insets;"));
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color darkShadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color lightShadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color control_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool isRaised_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BevelBorder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZLjava/awt/Color;Ljava/awt/Color;)V", "")]
		public BevelBorder(bool arg0, Dova.JDK.java.awt.Color arg1, Dova.JDK.java.awt.Color arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$BevelBorder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "public")]
		public bool isOpaque(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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

		[JniSignatureAttribute("(Ljava/awt/Component;)Ljava/awt/Insets;", "public")]
		public Dova.JDK.java.awt.Insets getBorderInsets(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Insets>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$XAWTScrollPaneUI;", "static final")]
	public partial class XAWTScrollPaneUI
		: Dova.JDK.javax.swing.plaf.basic.BasicScrollPaneUI
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XAWTScrollPaneUI()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$XAWTScrollPaneUI;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vsbMarginBorderR", "Ljavax/swing/border/Border;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vsbMarginBorderL", "Ljavax/swing/border/Border;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hsbMarginBorder", "Ljavax/swing/border/Border;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vsbBorder", "Ljavax/swing/border/Border;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hsbBorder", "Ljavax/swing/border/Border;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyChangeHandler", "Ljava/beans/PropertyChangeListener;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "(Ljavax/swing/JScrollPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createPropertyChangeHandler", "()Ljava/beans/PropertyChangeListener;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "(Ljavax/swing/JScrollPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installListeners", "(Ljavax/swing/JScrollPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallListeners", "(Ljavax/swing/JComponent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeftToRight", "(Ljava/awt/Component;)Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private final")]
		public Dova.JDK.javax.swing.border.Border vsbMarginBorderR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private final")]
		public Dova.JDK.javax.swing.border.Border vsbMarginBorderL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private final")]
		public Dova.JDK.javax.swing.border.Border hsbMarginBorder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private")]
		public Dova.JDK.javax.swing.border.Border vsbBorder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/border/Border;", "private")]
		public Dova.JDK.javax.swing.border.Border hsbBorder_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.border.Border>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/beans/PropertyChangeListener;", "private")]
		public Dova.JDK.java.beans.PropertyChangeListener propertyChangeHandler_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XAWTScrollPaneUI(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public XAWTScrollPaneUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$XAWTScrollPaneUI;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JScrollPane;)V", "protected")]
		public void uninstallDefaults(Dova.JDK.javax.swing.JScrollPane arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("()Ljava/beans/PropertyChangeListener;", "private")]
		public Dova.JDK.java.beans.PropertyChangeListener createPropertyChangeHandler()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.beans.PropertyChangeListener>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JScrollPane;)V", "protected")]
		public void installDefaults(Dova.JDK.javax.swing.JScrollPane arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/JScrollPane;)V", "protected")]
		public void installListeners(Dova.JDK.javax.swing.JScrollPane arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "protected")]
		public void uninstallListeners(Dova.JDK.javax.swing.JComponent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/awt/Component;)Z", "")]
		public bool isLeftToRight(Dova.JDK.java.awt.Component arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarUI;", "static final")]
	public partial class XAWTScrollBarUI
		: Dova.JDK.javax.swing.plaf.basic.BasicScrollBarUI
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XAWTScrollBarUI()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarUI;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIncreaseButton", "()Ljavax/swing/JButton;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecreaseButton", "()Ljavax/swing/JButton;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintThumb", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;Ljava/awt/Rectangle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "configureScrollBarColors", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDecreaseButton", "(I)Ljavax/swing/JButton;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createIncreaseButton", "(I)Ljavax/swing/JButton;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XAWTScrollBarUI(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public XAWTScrollBarUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarUI;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/swing/JButton;", "public")]
		public Dova.JDK.javax.swing.JButton getIncreaseButton()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/JButton;", "public")]
		public Dova.JDK.javax.swing.JButton getDecreaseButton()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;Ljava/awt/Rectangle;)V", "public")]
		public void paintThumb(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1, Dova.JDK.java.awt.Rectangle arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void configureScrollBarColors()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(I)Ljavax/swing/JButton;", "protected")]
		public Dova.JDK.javax.swing.JButton createDecreaseButton(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}

		[JniSignatureAttribute("(I)Ljavax/swing/JButton;", "protected")]
		public Dova.JDK.javax.swing.JButton createIncreaseButton(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JButton>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void installDefaults()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarButton;", "static final")]
	public partial class XAWTScrollBarButton
		: Dova.JDK.javax.swing.plaf.basic.BasicArrowButton
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XAWTScrollBarButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uidefaults", "Ljavax/swing/UIDefaults;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "darkShadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lightShadow", "Ljava/awt/Color;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "buttonBack", "Ljava/awt/Color;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljava/awt/Graphics;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMaximumSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinimumSize", "()Ljava/awt/Dimension;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFocusTraversable", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/swing/UIDefaults;", "private")]
		public Dova.JDK.javax.swing.UIDefaults uidefaults_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.UIDefaults>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color darkShadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color lightShadow_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/awt/Color;", "private")]
		public Dova.JDK.java.awt.Color buttonBack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XAWTScrollBarButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public XAWTScrollBarButton(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$XAWTScrollBarButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getPreferredSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "public")]
		public void paint(Dova.JDK.java.awt.Graphics arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMaximumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Ljava/awt/Dimension;", "public")]
		public Dova.JDK.java.awt.Dimension getMinimumSize()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Dimension>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isFocusTraversable()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$XAWTCaret;", "static final")]
	public partial class XAWTCaret
		: Dova.JDK.javax.swing.text.DefaultCaret
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static XAWTCaret()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$XAWTCaret;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public XAWTCaret(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public XAWTCaret() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$XAWTCaret;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusGained(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/FocusEvent;)V", "public")]
		public void focusLost(Dova.JDK.java.awt.@event.FocusEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lsun/awt/X11/XTextAreaPeer$AWTTextAreaUI;", "static final")]
	public partial class AWTTextAreaUI
		: Dova.JDK.com.sun.java.swing.plaf.motif.MotifTextAreaUI
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AWTTextAreaUI()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/awt/X11/XTextAreaPeer$AWTTextAreaUI;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jta", "Ljavax/swing/JTextArea;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyPrefix", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createCaret", "()Ljavax/swing/text/Caret;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installKeyboardActions", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JTextArea;", "private")]
		public Dova.JDK.javax.swing.JTextArea jta_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JTextArea>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AWTTextAreaUI(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public AWTTextAreaUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/awt/X11/XTextAreaPeer$AWTTextAreaUI;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String getPropertyPrefix()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Caret;", "protected")]
		public Dova.JDK.javax.swing.text.Caret createCaret()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Caret>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void installKeyboardActions()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
		public void installUI(Dova.JDK.javax.swing.JComponent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}
	}
}
