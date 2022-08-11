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

[JniSignatureAttribute("Ljavax/swing/JTextPane;", "public")]
public partial class JTextPane
	: Dova.JDK.javax.swing.JEditorPane
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JTextPane()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/JTextPane;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "uiClassID", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/swing/text/StyledDocument;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeObject", "(Ljava/io/ObjectOutputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "paramString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setDocument", "(Ljavax/swing/text/Document;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceSelection", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "replaceSelection", "(Ljava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setCharacterAttributes", "(Ljavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDefaultEditorKit", "()Ljavax/swing/text/EditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEditorKit", "(Ljavax/swing/text/EditorKit;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setStyledDocument", "(Ljavax/swing/text/StyledDocument;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyledDocument", "()Ljavax/swing/text/StyledDocument;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInputAttributes", "()Ljavax/swing/text/MutableAttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addStyle", "(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "removeStyle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLogicalStyle", "(Ljavax/swing/text/Style;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLogicalStyle", "()Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setParagraphAttributes", "(Ljavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyledEditorKit", "()Ljavax/swing/text/StyledEditorKit;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertComponent", "(Ljava/awt/Component;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "insertIcon", "(Ljavax/swing/Icon;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharacterAttributes", "()Ljavax/swing/text/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParagraphAttributes", "()Ljavax/swing/text/AttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUIClassID", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;"));
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
	public JTextPane(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JTextPane() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/StyledDocument;)V", "public")]
	public JTextPane(Dova.JDK.javax.swing.text.StyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/JTextPane;";
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

	[JniSignatureAttribute("(Ljavax/swing/text/Document;)V", "public")]
	public void setDocument(Dova.JDK.javax.swing.text.Document arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void replaceSelection(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Z)V", "private")]
	public void replaceSelection(Dova.JDK.java.lang.String arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Z)V", "public")]
	public void setCharacterAttributes(Dova.JDK.javax.swing.text.AttributeSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/EditorKit;", "protected")]
	public Dova.JDK.javax.swing.text.EditorKit createDefaultEditorKit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.EditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/EditorKit;)V", "public final")]
	public void setEditorKit(Dova.JDK.javax.swing.text.EditorKit arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/StyledDocument;)V", "public")]
	public void setStyledDocument(Dova.JDK.javax.swing.text.StyledDocument arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/StyledDocument;", "public")]
	public Dova.JDK.javax.swing.text.StyledDocument getStyledDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.StyledDocument>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/MutableAttributeSet;", "public")]
	public Dova.JDK.javax.swing.text.MutableAttributeSet getInputAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.MutableAttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style addStyle(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.Style arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void removeStyle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Style;)V", "public")]
	public void setLogicalStyle(Dova.JDK.javax.swing.text.Style arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style getLogicalStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Z)V", "public")]
	public void setParagraphAttributes(Dova.JDK.javax.swing.text.AttributeSet arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/StyledEditorKit;", "protected final")]
	public Dova.JDK.javax.swing.text.StyledEditorKit getStyledEditorKit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.StyledEditorKit>(ret);
	}

	[JniSignatureAttribute("(Ljava/awt/Component;)V", "public")]
	public void insertComponent(Dova.JDK.java.awt.Component arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/Icon;)V", "public")]
	public void insertIcon(Dova.JDK.javax.swing.Icon arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
	public Dova.JDK.javax.swing.text.AttributeSet getCharacterAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
	public Dova.JDK.javax.swing.text.AttributeSet getParagraphAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUIClassID()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style getStyle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}
}
