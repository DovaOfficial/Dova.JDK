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

namespace Dova.JDK.javax.swing.plaf.basic;

[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicEditorPaneUI;", "public")]
public partial class BasicEditorPaneUI
	: Dova.JDK.javax.swing.plaf.basic.BasicTextUI
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static BasicEditorPaneUI()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicEditorPaneUI;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FONT_ATTRIBUTE_KEY", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyPrefix", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEditorKit", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateForeground", "(Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getActionMap", "()Ljavax/swing/ActionMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createUI", "(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateDisplayProperties", "(Ljava/awt/Font;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanDisplayProperties", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addActions", "(Ljavax/swing/ActionMap;[Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeActions", "(Ljavax/swing/ActionMap;[Ljavax/swing/Action;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateCSS", "(Ljava/awt/Font;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateFont", "(Ljava/awt/Font;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "updateStyle", "(Ljava/awt/Font;Ljava/awt/Color;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "propertyChange", "(Ljava/beans/PropertyChangeEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "installUI", "(Ljavax/swing/JComponent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "uninstallUI", "(Ljavax/swing/JComponent;)V"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String FONT_ATTRIBUTE_KEY_Property
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
	public BasicEditorPaneUI(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public BasicEditorPaneUI() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicEditorPaneUI;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "protected")]
	public Dova.JDK.java.lang.String getPropertyPrefix()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/EditorKit;", "public")]
	public Dova.JDK.javax.swing.text.EditorKit getEditorKit(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Color;)V", "private")]
	public void updateForeground(Dova.JDK.java.awt.Color arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/ActionMap;", "")]
	public Dova.JDK.javax.swing.ActionMap getActionMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.ActionMap>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)Ljavax/swing/plaf/ComponentUI;", "public static")]
	public static Dova.JDK.javax.swing.plaf.ComponentUI createUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.plaf.ComponentUI>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/Color;)V", "")]
	public void updateDisplayProperties(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.Color arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void cleanDisplayProperties()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(Ljavax/swing/ActionMap;[Ljavax/swing/Action;)V", "")]
	public void addActions(Dova.JDK.javax.swing.ActionMap arg0, JavaArray<Dova.JDK.javax.swing.Action> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/ActionMap;[Ljavax/swing/Action;)V", "")]
	public void removeActions(Dova.JDK.javax.swing.ActionMap arg0, JavaArray<Dova.JDK.javax.swing.Action> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/Color;)V", "private")]
	public void updateCSS(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.Color arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;)V", "private")]
	public void updateFont(Dova.JDK.java.awt.Font arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Font;Ljava/awt/Color;)V", "private")]
	public void updateStyle(Dova.JDK.java.awt.Font arg0, Dova.JDK.java.awt.Color arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/beans/PropertyChangeEvent;)V", "protected")]
	public void propertyChange(Dova.JDK.java.beans.PropertyChangeEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void installUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JComponent;)V", "public")]
	public void uninstallUI(Dova.JDK.javax.swing.JComponent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/plaf/basic/BasicEditorPaneUI$StyleSheetUIResource;", "static")]
	public partial class StyleSheetUIResource
		: Dova.JDK.javax.swing.text.html.StyleSheet
		, Dova.JDK.javax.swing.plaf.UIResource
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StyleSheetUIResource()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/plaf/basic/BasicEditorPaneUI$StyleSheetUIResource;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StyleSheetUIResource(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public StyleSheetUIResource() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/plaf/basic/BasicEditorPaneUI$StyleSheetUIResource;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
