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

namespace Dova.JDK.javax.swing;

[JniSignatureAttribute("Ljavax/swing/JToggleButton;", "public")]
public partial class JToggleButton
	: Dova.JDK.javax.swing.AbstractButton
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JToggleButton()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToggleButton;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Action;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljavax/swing/Icon;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljavax/swing/Icon;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Icon;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/Icon;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGroupSelection", "(Ljava/awt/event/FocusEvent$Cause;)Ljavax/swing/JToggleButton;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocusUnconditionally", "(Ljava/awt/event/FocusEvent$Cause;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocusInWindowUnconditionally", "(Ljava/awt/event/FocusEvent$Cause;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$100", "(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$200", "(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "access$000", "(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateUI", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "shouldUpdateSelectedStateFromAction", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocus", "(Ljava/awt/event/FocusEvent$Cause;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "requestFocusInWindow", "(Ljava/awt/event/FocusEvent$Cause;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String uiClassID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JToggleButton(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "public")]
	public JToggleButton(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/Action;)V", "public")]
	public JToggleButton(Dova.JDK.javax.swing.Action arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/Icon;)V", "public")]
	public JToggleButton(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.Icon arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/Icon;Z)V", "public")]
	public JToggleButton(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.Icon arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JToggleButton() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[4]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;)V", "public")]
	public JToggleButton(Dova.JDK.javax.swing.Icon arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[5], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;Z)V", "public")]
	public JToggleButton(Dova.JDK.javax.swing.Icon arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[6], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public JToggleButton(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[7], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JToggleButton;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectOutputStream;)V", "private")]
	public void writeObject(Dova.JDK.java.io.ObjectOutputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String paramString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent$Cause;)Ljavax/swing/JToggleButton;", "private")]
	public Dova.JDK.javax.swing.JToggleButton getGroupSelection(Dova.JDK.java.awt.@event.FocusEvent.Cause arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToggleButton>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent$Cause;)V", "private")]
	public void requestFocusUnconditionally(Dova.JDK.java.awt.@event.FocusEvent.Cause arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent$Cause;)Z", "private")]
	public bool requestFocusInWindowUnconditionally(Dova.JDK.java.awt.@event.FocusEvent.Cause arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;", "static")]
	public static Dova.JDK.javax.accessibility.AccessibleContext access_100(Dova.JDK.javax.swing.JToggleButton arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;", "static")]
	public static Dova.JDK.javax.accessibility.AccessibleContext access_200(Dova.JDK.javax.swing.JToggleButton arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JToggleButton;)Ljavax/accessibility/AccessibleContext;", "static")]
	public static Dova.JDK.javax.accessibility.AccessibleContext access_000(Dova.JDK.javax.swing.JToggleButton arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void updateUI()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool shouldUpdateSelectedStateFromAction()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent$Cause;)V", "public")]
	public void requestFocus(Dova.JDK.java.awt.@event.FocusEvent.Cause arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/event/FocusEvent$Cause;)Z", "public")]
	public bool requestFocusInWindow(Dova.JDK.java.awt.@event.FocusEvent.Cause arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/JToggleButton$ToggleButtonModel;", "public static")]
	public partial class ToggleButtonModel
		: Dova.JDK.javax.swing.DefaultButtonModel
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ToggleButtonModel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToggleButton$ToggleButtonModel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelected", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setSelected", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPressed", "(Z)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ToggleButtonModel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ToggleButtonModel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JToggleButton$ToggleButtonModel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isSelected()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setSelected(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Z)V", "public")]
		public void setPressed(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/JToggleButton$AccessibleJToggleButton;", "protected")]
	public partial class AccessibleJToggleButton
		: Dova.JDK.javax.swing.AbstractButton.AccessibleAbstractButton
		, Dova.JDK.java.awt.@event.ItemListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AccessibleJToggleButton()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JToggleButton$AccessibleJToggleButton;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljavax/swing/JToggleButton;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/JToggleButton;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessibleRole", "()Ljavax/accessibility/AccessibleRole;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "itemStateChanged", "(Ljava/awt/event/ItemEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/JToggleButton;", "final")]
		public Dova.JDK.javax.swing.JToggleButton this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JToggleButton>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AccessibleJToggleButton(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/JToggleButton;)V", "public")]
		public AccessibleJToggleButton(Dova.JDK.javax.swing.JToggleButton arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/JToggleButton$AccessibleJToggleButton;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/accessibility/AccessibleRole;", "public")]
		public Dova.JDK.javax.accessibility.AccessibleRole getAccessibleRole()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleRole>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ItemEvent;)V", "public")]
		public void itemStateChanged(Dova.JDK.java.awt.@event.ItemEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}
}
