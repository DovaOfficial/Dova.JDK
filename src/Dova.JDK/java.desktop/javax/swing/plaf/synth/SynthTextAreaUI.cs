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

namespace Dova.JDK.javax.swing.plaf.synth;

[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTextAreaUI;", "public")]
public partial class SynthTextAreaUI
	: Dova.JDK.javax.swing.plaf.basic.BasicTextAreaUI
	, Dova.JDK.javax.swing.plaf.synth.SynthUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SynthTextAreaUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthTextAreaUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "handler", "Ljavax/swing/plaf/synth/SynthTextAreaUI$Handler;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljavax/swing/plaf/synth/SynthStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "updateKBAction", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "update", "(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBackground", "(Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/plaf/synth/SynthTextAreaUI;)Ljavax/swing/text/JTextComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljavax/swing/plaf/synth/SynthTextAreaUI;)Ljavax/swing/text/JTextComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateStyle", "(Ljavax/swing/text/JTextComponent;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installDefaults", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paint", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paintBorder", "(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V"));
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTextAreaUI$Handler;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI.Handler handler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI.Handler>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthStyle;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthStyle style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool updateKBAction_Property
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
	public SynthTextAreaUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SynthTextAreaUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthTextAreaUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/awt/Graphics;Ljavax/swing/JComponent;)V", "public")]
	public void update(Dova.JDK.java.awt.Graphics arg0, Dova.JDK.javax.swing.JComponent arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;I)Ljavax/swing/plaf/synth/SynthContext;", "private")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/synth/SynthContext;", "public")]
	public Dova.JDK.javax.swing.plaf.synth.SynthContext getContext(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Graphics;)V", "protected")]
	public void paintBackground(Dova.JDK.java.awt.Graphics arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTextAreaUI;)Ljavax/swing/text/JTextComponent;", "static")]
	public static Dova.JDK.javax.swing.text.JTextComponent access_000(Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTextAreaUI;)Ljavax/swing/text/JTextComponent;", "static")]
	public static Dova.JDK.javax.swing.text.JTextComponent access_100(Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.JTextComponent>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void uninstallDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Z)V", "private")]
	public void updateStyle(Dova.JDK.javax.swing.text.JTextComponent arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()V", "protected")]
	public void installDefaults()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;)V", "protected")]
	public void paint(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthContext;Ljava/awt/Graphics;IIII)V", "public")]
	public void paintBorder(Dova.JDK.javax.swing.plaf.synth.SynthContext arg0, Dova.JDK.java.awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTextAreaUI$Handler;", "private final")]
	public partial class Handler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.awt.@event.FocusListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Handler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/synth/SynthTextAreaUI$Handler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/plaf/synth/SynthTextAreaUI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/plaf/synth/SynthTextAreaUI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusGained", "(Ljava/awt/event/FocusEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "focusLost", "(Ljava/awt/event/FocusEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/plaf/synth/SynthTextAreaUI;", "final")]
		public Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Handler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/plaf/synth/SynthTextAreaUI;)V", "private")]
		public Handler(Dova.JDK.javax.swing.plaf.synth.SynthTextAreaUI arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/synth/SynthTextAreaUI$Handler;";
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
}
