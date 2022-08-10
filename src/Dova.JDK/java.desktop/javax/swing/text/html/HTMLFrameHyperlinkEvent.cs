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

namespace Dova.JDK.javax.swing.text.html;

[JniSignatureAttribute("Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;", "public")]
public partial class HTMLFrameHyperlinkEvent
	: Dova.JDK.javax.swing.@event.HyperlinkEvent
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HTMLFrameHyperlinkEvent()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targetFrame", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFrameHyperlinkEvent", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/awt/event/InputEvent;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFrameHyperlinkEvent", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFrameHyperlinkEvent", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFrameHyperlinkEvent", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFrameHyperlinkEvent", "(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTarget", "()Ljava/lang/String;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String targetFrame_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HTMLFrameHyperlinkEvent(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/awt/event/InputEvent;Ljava/lang/String;)V", "public")]
	public HTMLFrameHyperlinkEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.Element arg4, Dova.JDK.java.awt.@event.InputEvent arg5, Dova.JDK.java.lang.String arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public HTMLFrameHyperlinkEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.javax.swing.text.Element arg4, Dova.JDK.java.lang.String arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public HTMLFrameHyperlinkEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.javax.swing.text.Element arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;Ljava/lang/String;)V", "public")]
	public HTMLFrameHyperlinkEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/swing/event/HyperlinkEvent$EventType;Ljava/net/URL;Ljava/lang/String;)V", "public")]
	public HTMLFrameHyperlinkEvent(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.swing.@event.HyperlinkEvent.EventType arg1, Dova.JDK.java.net.URL arg2, Dova.JDK.java.lang.String arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}
}
