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

[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit;", "public")]
public partial class HTMLEditorKit
	: Dova.JDK.javax.swing.text.StyledEditorKit
	, Dova.JDK.javax.accessibility.Accessible
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HTMLEditorKit()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "theEditor", "Ljavax/swing/JEditorPane;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_CSS", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "accessibleContext", "Ljavax/accessibility/AccessibleContext;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MoveCursor", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DefaultCursor", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "defaultFactory", "Ljavax/swing/text/ViewFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "input", "Ljavax/swing/text/MutableAttributeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_STYLES_KEY", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "linkHandler", "Ljavax/swing/text/html/HTMLEditorKit$LinkController;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "defaultParser", "Ljavax/swing/text/html/HTMLEditorKit$Parser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultCursor", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "linkCursor", "Ljava/awt/Cursor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isAutoFormSubmission", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BOLD_ACTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ITALIC_ACTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARA_INDENT_LEFT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARA_INDENT_RIGHT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FONT_CHANGE_BIGGER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FONT_CHANGE_SMALLER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COLOR_ACTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOGICAL_STYLE_ACTION", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMG_ALIGN_TOP", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMG_ALIGN_MIDDLE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMG_ALIGN_BOTTOM", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMG_BORDER", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSERT_TABLE_HTML", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSERT_UL_HTML", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSERT_OL_HTML", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSERT_HR_HTML", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSERT_PRE_HTML", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "nextLinkAction", "Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "previousLinkAction", "Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "activateLinkAction", "Ljavax/swing/text/html/HTMLEditorKit$ActivateLinkAction;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "defaultActions", "[Ljavax/swing/Action;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "foundLink", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "prevHypertextOffset", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "linkNavigationTag", "Ljava/lang/Object;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLEditorKit", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "write", "(Ljava/io/Writer;Ljavax/swing/text/Document;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "read", "(Ljava/io/Reader;Ljavax/swing/text/Document;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getActions", "()[Ljavax/swing/Action;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getViewFactory", "()Ljavax/swing/text/ViewFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultCursor", "()Ljava/awt/Cursor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getInputAttributes", "()Ljavax/swing/text/MutableAttributeSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "deinstall", "(Ljavax/swing/JEditorPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "install", "(Ljavax/swing/JEditorPane;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDefaultDocument", "()Ljavax/swing/text/Document;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setAutoFormSubmission", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ensureParser", "(Ljavax/swing/text/html/HTMLDocument;)Ljavax/swing/text/html/HTMLEditorKit$Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertHTML", "(Ljavax/swing/text/html/HTMLDocument;ILjava/lang/String;IILjavax/swing/text/html/HTML$Tag;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setStyleSheet", "(Ljavax/swing/text/html/StyleSheet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDefaultCursor", "(Ljava/awt/Cursor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLinkCursor", "(Ljava/awt/Cursor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLinkCursor", "()Ljava/awt/Cursor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getBodyElementStart", "(Ljavax/swing/text/JTextComponent;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getAttrValue", "(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Attribute;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParser", "()Ljavax/swing/text/html/HTMLEditorKit$Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getContentType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAutoFormSubmission", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createInputAttributes", "(Ljavax/swing/text/Element;Ljavax/swing/text/MutableAttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAccessibleContext", "()Ljavax/accessibility/AccessibleContext;"));
	}

	[JniSignatureAttribute("Ljavax/swing/JEditorPane;", "private")]
	public Dova.JDK.javax.swing.JEditorPane theEditor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.JEditorPane>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String DEFAULT_CSS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/accessibility/AccessibleContext;", "private")]
	public Dova.JDK.javax.accessibility.AccessibleContext accessibleContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "private static final")]
	public static Dova.JDK.java.awt.Cursor MoveCursor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "private static final")]
	public static Dova.JDK.java.awt.Cursor DefaultCursor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/ViewFactory;", "private static final")]
	public static Dova.JDK.javax.swing.text.ViewFactory defaultFactory_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/MutableAttributeSet;", "")]
	public Dova.JDK.javax.swing.text.MutableAttributeSet input_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.MutableAttributeSet>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private static final")]
	public static Dova.JDK.java.lang.Object DEFAULT_STYLES_KEY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$LinkController;", "private")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.LinkController linkHandler_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.LinkController>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$Parser;", "private static")]
	public static Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser defaultParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "private")]
	public Dova.JDK.java.awt.Cursor defaultCursor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/awt/Cursor;", "private")]
	public Dova.JDK.java.awt.Cursor linkCursor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool isAutoFormSubmission_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String BOLD_ACTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ITALIC_ACTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PARA_INDENT_LEFT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String PARA_INDENT_RIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String FONT_CHANGE_BIGGER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String FONT_CHANGE_SMALLER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String COLOR_ACTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String LOGICAL_STYLE_ACTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IMG_ALIGN_TOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IMG_ALIGN_MIDDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IMG_ALIGN_BOTTOM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String IMG_BORDER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INSERT_TABLE_HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INSERT_UL_HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INSERT_OL_HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INSERT_HR_HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String INSERT_PRE_HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;", "private static final")]
	public static Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction nextLinkAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;", "private static final")]
	public static Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction previousLinkAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$ActivateLinkAction;", "private static final")]
	public static Dova.JDK.javax.swing.text.html.HTMLEditorKit.ActivateLinkAction activateLinkAction_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.ActivateLinkAction>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljavax/swing/Action;", "private static final")]
	public static JavaArray<Dova.JDK.javax.swing.Action> defaultActions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.Action>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool foundLink_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[34]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[34], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int prevHypertextOffset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[35]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[35], value);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object linkNavigationTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HTMLEditorKit(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HTMLEditorKit() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "static")]
	public static Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;Ljavax/swing/text/Document;II)V", "public")]
	public void write(Dova.JDK.java.io.Writer arg0, Dova.JDK.javax.swing.text.Document arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/io/Reader;Ljavax/swing/text/Document;I)V", "public")]
	public void read(Dova.JDK.java.io.Reader arg0, Dova.JDK.javax.swing.text.Document arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()[Ljavax/swing/Action;", "public")]
	public JavaArray<Dova.JDK.javax.swing.Action> getActions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.Action>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/ViewFactory;", "public")]
	public Dova.JDK.javax.swing.text.ViewFactory getViewFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ViewFactory>(ret);
	}

	[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
	public Dova.JDK.java.awt.Cursor getDefaultCursor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/MutableAttributeSet;", "public")]
	public Dova.JDK.javax.swing.text.MutableAttributeSet getInputAttributes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.MutableAttributeSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "public")]
	public void deinstall(Dova.JDK.javax.swing.JEditorPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)V", "public")]
	public void install(Dova.JDK.javax.swing.JEditorPane arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Document;", "public")]
	public Dova.JDK.javax.swing.text.Document createDefaultDocument()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Document>(ret);
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setAutoFormSubmission(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;)Ljavax/swing/text/html/HTMLEditorKit$Parser;", "private")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser ensureParser(Dova.JDK.javax.swing.text.html.HTMLDocument arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;ILjava/lang/String;IILjavax/swing/text/html/HTML$Tag;)V", "public")]
	public void insertHTML(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1, Dova.JDK.java.lang.String arg2, int arg3, int arg4, Dova.JDK.javax.swing.text.html.HTML.Tag arg5)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/StyleSheet;)V", "public")]
	public void setStyleSheet(Dova.JDK.javax.swing.text.html.StyleSheet arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
	public void setDefaultCursor(Dova.JDK.java.awt.Cursor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/awt/Cursor;)V", "public")]
	public void setLinkCursor(Dova.JDK.java.awt.Cursor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("()Ljava/awt/Cursor;", "public")]
	public Dova.JDK.java.awt.Cursor getLinkCursor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Cursor>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)I", "private static")]
	public static int getBodyElementStart(Dova.JDK.javax.swing.text.JTextComponent arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Attribute;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object getAttrValue(Dova.JDK.javax.swing.text.AttributeSet arg0, Dova.JDK.javax.swing.text.html.HTML.Attribute arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/HTMLEditorKit$Parser;", "protected")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser getParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getContentType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/StyleSheet;", "public")]
	public Dova.JDK.javax.swing.text.html.StyleSheet getStyleSheet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAutoFormSubmission()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/MutableAttributeSet;)V", "protected")]
	public void createInputAttributes(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/accessibility/AccessibleContext;", "public")]
	public Dova.JDK.javax.accessibility.AccessibleContext getAccessibleContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.accessibility.AccessibleContext>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$LinkController;", "public static")]
	public partial class LinkController
		: Dova.JDK.java.awt.@event.MouseAdapter
		, Dova.JDK.java.awt.@event.MouseMotionListener
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LinkController()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$LinkController;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curElem", "Ljavax/swing/text/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curElemImage", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "href", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bias", "[Ljavax/swing/text/Position$Bias;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curOffset", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LinkController", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activateLink", "(ILjavax/swing/JEditorPane;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activateLink", "(ILjavax/swing/JEditorPane;Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doesElementContainLocation", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;III)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMapHREF", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;III)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireEvents", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createHyperlinkEvent", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljava/lang/String;Ljavax/swing/text/AttributeSet;Ljavax/swing/text/Element;Ljava/awt/event/MouseEvent;)Ljavax/swing/event/HyperlinkEvent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseClicked", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseMoved", "(Ljava/awt/event/MouseEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "mouseDragged", "(Ljava/awt/event/MouseEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "private")]
		public Dova.JDK.javax.swing.text.Element curElem_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool curElemImage_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String href_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/swing/text/Position$Bias;", "private transient")]
		public JavaArray<Dova.JDK.javax.swing.text.Position.Bias> bias_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Position.Bias>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int curOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LinkController(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public LinkController() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$LinkController;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjavax/swing/JEditorPane;)V", "protected")]
		public void activateLink(int arg0, Dova.JDK.javax.swing.JEditorPane arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}

		[JniSignatureAttribute("(ILjavax/swing/JEditorPane;Ljava/awt/event/MouseEvent;)V", "")]
		public void activateLink(int arg0, Dova.JDK.javax.swing.JEditorPane arg1, Dova.JDK.java.awt.@event.MouseEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;III)Z", "private")]
		public bool doesElementContainLocation(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;III)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getMapHREF(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, Dova.JDK.javax.swing.text.Element arg2, Dova.JDK.javax.swing.text.AttributeSet arg3, int arg4, int arg5, int arg6)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljava/lang/String;Ljavax/swing/text/Element;Ljava/awt/event/MouseEvent;)V", "")]
		public void fireEvents(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.text.Element arg3, Dova.JDK.java.awt.@event.MouseEvent arg4)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;Ljava/lang/String;Ljavax/swing/text/AttributeSet;Ljavax/swing/text/Element;Ljava/awt/event/MouseEvent;)Ljavax/swing/event/HyperlinkEvent;", "")]
		public Dova.JDK.javax.swing.@event.HyperlinkEvent createHyperlinkEvent(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.swing.text.AttributeSet arg3, Dova.JDK.javax.swing.text.Element arg4, Dova.JDK.java.awt.@event.MouseEvent arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.HyperlinkEvent>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseClicked(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseMoved(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Ljava/awt/event/MouseEvent;)V", "public")]
		public void mouseDragged(Dova.JDK.java.awt.@event.MouseEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$Parser;", "public abstract static")]
	public partial class Parser
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Parser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$Parser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Parser", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(Ljava/io/Reader;Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;Z)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Parser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public Parser() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$Parser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/io/Reader;Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;Z)V", "public abstract")]
		public void parse(Dova.JDK.java.io.Reader arg0, Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;", "public static")]
	public partial class ParserCallback
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParserCallback()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMPLIED", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParserCallback", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleError", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleComment", "([CI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleStartTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleEndTag", "(Ljavax/swing/text/html/HTML$Tag;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleSimpleTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleEndOfLineString", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleText", "([CI)V"));
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public static final")]
		public static Dova.JDK.java.lang.Object IMPLIED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParserCallback(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public ParserCallback() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "public")]
		public void handleError(Dova.JDK.java.lang.String arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("([CI)V", "public")]
		public void handleComment(JavaArray<char> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V", "public")]
		public void handleStartTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;I)V", "public")]
		public void handleEndTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V", "public")]
		public void handleSimpleTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void handleEndOfLineString(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("([CI)V", "public")]
		public void handleText(JavaArray<char> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;", "static")]
	public partial class NavigateLinkAction
		: Dova.JDK.javax.swing.text.TextAction
		, Dova.JDK.javax.swing.@event.CaretListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NavigateLinkAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "focusPainter", "Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction$FocusHighlightPainter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "focusBack", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "NavigateLinkAction", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "caretUpdate", "(Ljavax/swing/event/CaretEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "moveCaretPosition", "(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/html/HTMLEditorKit;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHTMLEditorKit", "(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/html/HTMLEditorKit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction$FocusHighlightPainter;", "private static final")]
		public static Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction.FocusHighlightPainter focusPainter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.NavigateLinkAction.FocusHighlightPainter>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool focusBack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NavigateLinkAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public NavigateLinkAction(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/CaretEvent;)V", "public")]
		public void caretUpdate(Dova.JDK.javax.swing.@event.CaretEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;Ljavax/swing/text/html/HTMLEditorKit;II)V", "private")]
		public void moveCaretPosition(Dova.JDK.javax.swing.text.JTextComponent arg0, Dova.JDK.javax.swing.text.html.HTMLEditorKit arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/JTextComponent;)Ljavax/swing/text/html/HTMLEditorKit;", "private")]
		public Dova.JDK.javax.swing.text.html.HTMLEditorKit getHTMLEditorKit(Dova.JDK.javax.swing.text.JTextComponent arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction$FocusHighlightPainter;", "static")]
		public partial class FocusHighlightPainter
			: Dova.JDK.javax.swing.text.DefaultHighlighter.DefaultHighlightPainter
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FocusHighlightPainter()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction$FocusHighlightPainter;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FocusHighlightPainter", "(Ljava/awt/Color;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "paintLayer", "(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)Ljava/awt/Shape;"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FocusHighlightPainter(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/awt/Color;)V", "")]
			public FocusHighlightPainter(Dova.JDK.java.awt.Color arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$NavigateLinkAction$FocusHighlightPainter;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/awt/Graphics;IILjava/awt/Shape;Ljavax/swing/text/JTextComponent;Ljavax/swing/text/View;)Ljava/awt/Shape;", "public")]
			public Dova.JDK.java.awt.Shape paintLayer(Dova.JDK.java.awt.Graphics arg0, int arg1, int arg2, Dova.JDK.java.awt.Shape arg3, Dova.JDK.javax.swing.text.JTextComponent arg4, Dova.JDK.javax.swing.text.View arg5)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
				return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Shape>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory;", "public static")]
	public partial class HTMLFactory
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.text.ViewFactory
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HTMLFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLFactory", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "(Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HTMLFactory(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public HTMLFactory() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "public")]
		public Dova.JDK.javax.swing.text.View create(Dova.JDK.javax.swing.text.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory$BodyBlockView;", "static")]
		public partial class BodyBlockView
			: Dova.JDK.javax.swing.text.html.BlockView
			, Dova.JDK.java.awt.@event.ComponentListener
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BodyBlockView()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory$BodyBlockView;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "cachedViewPort", "Ljava/lang/ref/Reference;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isListening", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "viewVisibleWidth", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "componentVisibleWidth", "I"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BodyBlockView", "(Ljavax/swing/text/Element;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParent", "(Ljavax/swing/text/View;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "layoutMinorAxis", "(II[I[I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "calculateMajorAxisRequirements", "(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentResized", "(Ljava/awt/event/ComponentEvent;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentMoved", "(Ljava/awt/event/ComponentEvent;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentShown", "(Ljava/awt/event/ComponentEvent;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "componentHidden", "(Ljava/awt/event/ComponentEvent;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/ref/Reference;", "private")]
			public Dova.JDK.java.lang.@ref.Reference cachedViewPort_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.@ref.Reference>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "private")]
			public bool isListening_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("I", "private")]
			public int viewVisibleWidth_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}

			[JniSignatureAttribute("I", "private")]
			public int componentVisibleWidth_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BodyBlockView(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
			public BodyBlockView(Dova.JDK.javax.swing.text.Element arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$HTMLFactory$BodyBlockView;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/View;)V", "public")]
			public void setParent(Dova.JDK.javax.swing.text.View arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(II[I[I)V", "protected")]
			public void layoutMinorAxis(int arg0, int arg1, JavaArray<int> arg2, JavaArray<int> arg3)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
			}

			[JniSignatureAttribute("(ILjavax/swing/SizeRequirements;)Ljavax/swing/SizeRequirements;", "protected")]
			public Dova.JDK.javax.swing.SizeRequirements calculateMajorAxisRequirements(int arg0, Dova.JDK.javax.swing.SizeRequirements arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.SizeRequirements>(ret);
			}

			[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
			public void componentResized(Dova.JDK.java.awt.@event.ComponentEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
			public void componentMoved(Dova.JDK.java.awt.@event.ComponentEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
			public void componentShown(Dova.JDK.java.awt.@event.ComponentEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Ljava/awt/event/ComponentEvent;)V", "public")]
			public void componentHidden(Dova.JDK.java.awt.@event.ComponentEvent arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$ActivateLinkAction;", "static")]
	public partial class ActivateLinkAction
		: Dova.JDK.javax.swing.text.TextAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ActivateLinkAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$ActivateLinkAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ActivateLinkAction", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "lock", "(Ljavax/swing/JEditorPane;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "unlock", "(Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRootView", "(Ljavax/swing/JEditorPane;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "activateLink", "(Ljava/lang/String;Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/JEditorPane;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "doObjectAction", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getView", "(Ljavax/swing/text/View;Ljavax/swing/text/Element;I)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getView", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;)Ljavax/swing/text/View;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ActivateLinkAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public ActivateLinkAction(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$ActivateLinkAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)Ljava/lang/Object;", "private")]
		public Dova.JDK.java.lang.Object @lock(Dova.JDK.javax.swing.JEditorPane arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)V", "private")]
		public void unlock(Dova.JDK.java.lang.Object arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)Ljavax/swing/text/View;", "private")]
		public Dova.JDK.javax.swing.text.View getRootView(Dova.JDK.javax.swing.JEditorPane arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/JEditorPane;I)V", "private")]
		public void activateLink(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, Dova.JDK.javax.swing.JEditorPane arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;)V", "private")]
		public void doObjectAction(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.Element arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/View;Ljavax/swing/text/Element;I)Ljavax/swing/text/View;", "private")]
		public Dova.JDK.javax.swing.text.View getView(Dova.JDK.javax.swing.text.View arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/Element;)Ljavax/swing/text/View;", "private")]
		public Dova.JDK.javax.swing.text.View getView(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.Element arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.View>(ret);
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$InsertHTMLTextAction;", "public static")]
	public partial class InsertHTMLTextAction
		: Dova.JDK.javax.swing.text.html.HTMLEditorKit.HTMLTextAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InsertHTMLTextAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$InsertHTMLTextAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "html", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parentTag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "addTag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "alternateParentTag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "alternateAddTag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "adjustSelection", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InsertHTMLTextAction", "(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InsertHTMLTextAction", "(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InsertHTMLTextAction", "(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertHTML", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjava/lang/String;IILjavax/swing/text/html/HTML$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "adjustSelection", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertAtBoundry", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertAtBoundary", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertIntoTag", "(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String html_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag parentTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag addTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag alternateParentTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag alternateAddTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool adjustSelection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InsertHTMLTextAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Z)V", "")]
		public InsertHTMLTextAction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.swing.text.html.HTML.Tag arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3, Dova.JDK.javax.swing.text.html.HTML.Tag arg4, Dova.JDK.javax.swing.text.html.HTML.Tag arg5, bool arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V", "public")]
		public InsertHTMLTextAction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.swing.text.html.HTML.Tag arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3, Dova.JDK.javax.swing.text.html.HTML.Tag arg4, Dova.JDK.javax.swing.text.html.HTML.Tag arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V", "public")]
		public InsertHTMLTextAction(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.swing.text.html.HTML.Tag arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$InsertHTMLTextAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjava/lang/String;IILjavax/swing/text/html/HTML$Tag;)V", "protected")]
		public void insertHTML(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, int arg5, Dova.JDK.javax.swing.text.html.HTML.Tag arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;II)V", "")]
		public void adjustSelection(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, int arg2, int arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V", "protected")]
		public void insertAtBoundry(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, int arg2, Dova.JDK.javax.swing.text.Element arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.javax.swing.text.html.HTML.Tag arg5, Dova.JDK.javax.swing.text.html.HTML.Tag arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/Element;Ljava/lang/String;Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)V", "protected")]
		public void insertAtBoundary(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, int arg2, Dova.JDK.javax.swing.text.Element arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.javax.swing.text.html.HTML.Tag arg5, Dova.JDK.javax.swing.text.html.HTML.Tag arg6)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTML$Tag;)Z", "")]
		public bool insertIntoTag(Dova.JDK.javax.swing.JEditorPane arg0, Dova.JDK.javax.swing.text.html.HTMLDocument arg1, int arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3, Dova.JDK.javax.swing.text.html.HTML.Tag arg4)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$InsertHRAction;", "static")]
	public partial class InsertHRAction
		: Dova.JDK.javax.swing.text.html.HTMLEditorKit.InsertHTMLTextAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InsertHRAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$InsertHRAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "InsertHRAction", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InsertHRAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public InsertHRAction() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$InsertHRAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$BeginAction;", "static")]
	public partial class BeginAction
		: Dova.JDK.javax.swing.text.TextAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BeginAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$BeginAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "select", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BeginAction", "(Ljava/lang/String;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "actionPerformed", "(Ljava/awt/event/ActionEvent;)V"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool select_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BeginAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Z)V", "")]
		public BeginAction(Dova.JDK.java.lang.String arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$BeginAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/awt/event/ActionEvent;)V", "public")]
		public void actionPerformed(Dova.JDK.java.awt.@event.ActionEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$HTMLTextAction;", "public abstract static")]
	public partial class HTMLTextAction
		: Dova.JDK.javax.swing.text.StyledEditorKit.StyledTextAction
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HTMLTextAction()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLEditorKit$HTMLTextAction;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLTextAction", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHTMLEditorKit", "(Ljavax/swing/JEditorPane;)Ljavax/swing/text/html/HTMLEditorKit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findElementMatchingTag", "(Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "elementCountToTag", "(Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getHTMLDocument", "(Ljavax/swing/JEditorPane;)Ljavax/swing/text/html/HTMLDocument;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElementsAt", "(Ljavax/swing/text/Element;II)[Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElementsAt", "(Ljavax/swing/text/html/HTMLDocument;I)[Ljavax/swing/text/Element;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HTMLTextAction(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public HTMLTextAction(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLEditorKit$HTMLTextAction;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)Ljavax/swing/text/html/HTMLEditorKit;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTMLEditorKit getHTMLEditorKit(Dova.JDK.javax.swing.JEditorPane arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/Element;", "protected")]
		public Dova.JDK.javax.swing.text.Element findElementMatchingTag(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1, Dova.JDK.javax.swing.text.html.HTML.Tag arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;ILjavax/swing/text/html/HTML$Tag;)I", "protected")]
		public int elementCountToTag(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1, Dova.JDK.javax.swing.text.html.HTML.Tag arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/JEditorPane;)Ljavax/swing/text/html/HTMLDocument;", "protected")]
		public Dova.JDK.javax.swing.text.html.HTMLDocument getHTMLDocument(Dova.JDK.javax.swing.JEditorPane arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;II)[Ljavax/swing/text/Element;", "private")]
		public JavaArray<Dova.JDK.javax.swing.text.Element> getElementsAt(Dova.JDK.javax.swing.text.Element arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Element>>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;I)[Ljavax/swing/text/Element;", "protected")]
		public JavaArray<Dova.JDK.javax.swing.text.Element> getElementsAt(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Element>>(ret);
		}
	}
}
