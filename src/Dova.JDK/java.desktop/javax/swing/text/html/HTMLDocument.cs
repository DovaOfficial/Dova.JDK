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

[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument;", "public")]
public partial class HTMLDocument
	: Dova.JDK.javax.swing.text.DefaultStyledDocument
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HTMLDocument()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "frameDocument", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "preservesUnknownTags", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "radioButtonGroupsMap", "Ljava/util/HashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TokenThreshold", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MaxThreshold", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "StepThreshold", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "AdditionalComments", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "StyleType", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "base", "Ljava/net/URL;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "hasBaseTag", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "baseTarget", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parser", "Ljavax/swing/text/html/HTMLEditorKit$Parser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "contentAttributeSet", "Ljavax/swing/text/AttributeSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MAP_PROPERTY", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEWLINE", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertInBody", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "I18NProperty", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLDocument", "(Ljavax/swing/text/AbstractDocument$Content;Ljavax/swing/text/html/StyleSheet;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLDocument", "(Ljavax/swing/text/html/StyleSheet;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLDocument", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert", "(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "replace", "(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/Element;IIIIZZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getIterator", "(Ljavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/html/HTMLDocument$Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMap", "(Ljava/lang/String;)Ljavax/swing/text/html/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBase", "()Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "(Ljava/lang/String;)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "(Ljavax/swing/text/Element;Ljava/lang/Object;Ljava/lang/Object;Z)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "(Ljavax/swing/text/Element;Ljava/lang/Object;Ljava/lang/Object;)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParser", "(Ljavax/swing/text/html/HTMLEditorKit$Parser;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBase", "(Ljava/net/URL;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReader", "(I)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReader", "(IIILjavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getReader", "(IIILjavax/swing/text/html/HTML$Tag;Z)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setFrameDocumentState", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "processHTMLFrameHyperlinkEvent", "(Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setTokenThreshold", "(I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertHTML", "(Ljavax/swing/text/Element;ILjava/lang/String;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$000", "(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$100", "(Ljavax/swing/text/html/HTMLDocument;)Ljavax/swing/text/AbstractDocument$Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$200", "(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "access$300", "(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/event/DocumentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParser", "()Ljavax/swing/text/html/HTMLEditorKit$Parser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertUpdate", "(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/AttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateFrame", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBaseTarget", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasBaseTag", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateFrameSet", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findFrame", "(Ljava/lang/String;)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "installParserIfNecessary", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setOuterHTML", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "verifyParser", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElementsAtEnd", "(Ljavax/swing/text/Element;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTokenThreshold", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPreservesUnknownTags", "(Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPreservesUnknownTags", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addMap", "(Ljavax/swing/text/html/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeMap", "(Ljavax/swing/text/html/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaps", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDefaultStyleSheetType", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultStyleSheetType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setInnerHTML", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertAfterStart", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertBeforeEnd", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertBeforeStart", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertAfterEnd", "(Ljavax/swing/text/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "obtainLock", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "releaseLock", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParagraphAttributes", "(IILjavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElements", "(Ljavax/swing/text/Element;II)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElements", "(Ljavax/swing/text/Element;IIII)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStyleSheet", "()Ljavax/swing/text/html/StyleSheet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isFrameDocument", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "matchNameAttribute", "(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Tag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDefaultRoot", "()Ljavax/swing/text/AbstractDocument$AbstractElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createBranchElement", "(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createLeafElement", "(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;II)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireUndoableEditUpdate", "(Ljavax/swing/event/UndoableEditEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireChangedUpdate", "(Ljavax/swing/event/DocumentEvent;)V"));
	}

	[JniSignatureAttribute("Z", "private")]
	public bool frameDocument_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool preservesUnknownTags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("Ljava/util/HashMap;", "private")]
	public Dova.JDK.java.util.HashMap radioButtonGroupsMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.HashMap>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String TokenThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MaxThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int StepThreshold_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String AdditionalComments_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static final")]
	public static Dova.JDK.java.lang.String StyleType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/net/URL;", "")]
	public Dova.JDK.java.net.URL @base_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "")]
	public bool hasBaseTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String baseTarget_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLEditorKit$Parser;", "private")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser parser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "private static")]
	public static Dova.JDK.javax.swing.text.AttributeSet contentAttributeSet_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String MAP_PROPERTY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[C", "private static")]
	public static JavaArray<char> NEWLINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool insertInBody_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String I18NProperty_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HTMLDocument(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$Content;Ljavax/swing/text/html/StyleSheet;)V", "public")]
	public HTMLDocument(Dova.JDK.javax.swing.text.AbstractDocument.Content arg0, Dova.JDK.javax.swing.text.html.StyleSheet arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/StyleSheet;)V", "public")]
	public HTMLDocument(Dova.JDK.javax.swing.text.html.StyleSheet arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public HTMLDocument() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "protected")]
	public void insert(int arg0, JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/Element;IIIIZZ)V", "private")]
	public void replace(Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2, int arg3, int arg4, int arg5, bool arg6, bool arg7)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/html/HTMLDocument$Iterator;", "public")]
	public Dova.JDK.javax.swing.text.html.HTMLDocument.Iterator getIterator(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.Iterator>(ret);
	}

	[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "protected")]
	public void create(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/html/Map;", "")]
	public Dova.JDK.javax.swing.text.html.Map getMap(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URL;", "public")]
	public Dova.JDK.java.net.URL getBase()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/Element;", "public")]
	public Dova.JDK.javax.swing.text.Element getElement(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/Object;Ljava/lang/Object;Z)Ljavax/swing/text/Element;", "private")]
	public Dova.JDK.javax.swing.text.Element getElement(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/Object;Ljava/lang/Object;)Ljavax/swing/text/Element;", "public")]
	public Dova.JDK.javax.swing.text.Element getElement(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLEditorKit$Parser;)V", "public")]
	public void setParser(Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/net/URL;)V", "public")]
	public void setBase(Dova.JDK.java.net.URL arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;", "public")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback getReader(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback>(ret);
	}

	[JniSignatureAttribute("(IIILjavax/swing/text/html/HTML$Tag;)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;", "public")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback getReader(int arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback>(ret);
	}

	[JniSignatureAttribute("(IIILjavax/swing/text/html/HTML$Tag;Z)Ljavax/swing/text/html/HTMLEditorKit$ParserCallback;", "")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback getReader(int arg0, int arg1, int arg2, Dova.JDK.javax.swing.text.html.HTML.Tag arg3, bool arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback>(ret);
	}

	[JniSignatureAttribute("(Z)V", "")]
	public void setFrameDocumentState(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLFrameHyperlinkEvent;)V", "public")]
	public void processHTMLFrameHyperlinkEvent(Dova.JDK.javax.swing.text.html.HTMLFrameHyperlinkEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(I)V", "public")]
	public void setTokenThreshold(int arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;ILjava/lang/String;Z)V", "private")]
	public void insertHTML(Dova.JDK.javax.swing.text.Element arg0, int arg1, Dova.JDK.java.lang.String arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "static")]
	public static void access_000(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;)Ljavax/swing/text/AbstractDocument$Content;", "static")]
	public static Dova.JDK.javax.swing.text.AbstractDocument.Content access_100(Dova.JDK.javax.swing.text.html.HTMLDocument arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AbstractDocument.Content>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "static")]
	public static void access_200(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/event/DocumentEvent;)V", "static")]
	public static void access_300(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, Dova.JDK.javax.swing.@event.DocumentEvent arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/HTMLEditorKit$Parser;", "public")]
	public Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser getParser()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLEditorKit.Parser>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/AttributeSet;)V", "protected")]
	public void insertUpdate(Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg0, Dova.JDK.javax.swing.text.AttributeSet arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "private")]
	public void updateFrame(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getBaseTarget()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool hasBaseTag()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "private")]
	public void updateFrameSet(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/Element;", "private")]
	public Dova.JDK.javax.swing.text.Element findFrame(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void installParserIfNecessary()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29]);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void setOuterHTML(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void verifyParser()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31]);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;IIII)V", "private")]
	public void removeElementsAtEnd(Dova.JDK.javax.swing.text.Element arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getTokenThreshold()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[33]);
		return ret;
	}

	[JniSignatureAttribute("(Z)V", "public")]
	public void setPreservesUnknownTags(bool arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool getPreservesUnknownTags()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/Map;)V", "")]
	public void addMap(Dova.JDK.javax.swing.text.html.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/html/Map;)V", "")]
	public void removeMap(Dova.JDK.javax.swing.text.html.Map arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "")]
	public Dova.JDK.java.util.Enumeration getMaps()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
	public void setDefaultStyleSheetType(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getDefaultStyleSheetType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void setInnerHTML(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void insertAfterStart(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void insertBeforeEnd(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void insertBeforeStart(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljava/lang/String;)V", "public")]
	public void insertAfterEnd(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "")]
	public void obtainLock()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46]);
	}

	[JniSignatureAttribute("()V", "")]
	public void releaseLock()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47]);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/AttributeSet;Z)V", "public")]
	public void setParagraphAttributes(int arg0, int arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;II)V", "private")]
	public void removeElements(Dova.JDK.javax.swing.text.Element arg0, int arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;IIII)V", "private")]
	public void removeElements(Dova.JDK.javax.swing.text.Element arg0, int arg1, int arg2, int arg3, int arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/html/StyleSheet;", "public")]
	public Dova.JDK.javax.swing.text.html.StyleSheet getStyleSheet()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.StyleSheet>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isFrameDocument()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[52]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;Ljavax/swing/text/html/HTML$Tag;)Z", "static")]
	public static bool matchNameAttribute(Dova.JDK.javax.swing.text.AttributeSet arg0, Dova.JDK.javax.swing.text.html.HTML.Tag arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AbstractDocument$AbstractElement;", "protected")]
	public Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement createDefaultRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;)Ljavax/swing/text/Element;", "protected")]
	public Dova.JDK.javax.swing.text.Element createBranchElement(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.AttributeSet arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;II)Ljavax/swing/text/Element;", "protected")]
	public Dova.JDK.javax.swing.text.Element createLeafElement(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/UndoableEditEvent;)V", "protected")]
	public void fireUndoableEditUpdate(Dova.JDK.javax.swing.@event.UndoableEditEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentEvent;)V", "protected")]
	public void fireChangedUpdate(Dova.JDK.javax.swing.@event.DocumentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "public")]
	public partial class HTMLReader
		: Dova.JDK.javax.swing.text.html.HTMLEditorKit.ParserCallback
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HTMLReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "receivedEndHTML", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "flushCount", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertAfterImplied", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "wantsTrailingNewline", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "threshold", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inParagraph", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "impliedP", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inPre", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inTextArea", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "textAreaDocument", "Ljavax/swing/text/html/TextAreaDocument;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inTitle", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastWasNewline", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "emptyAnchor", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "midInsert", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inBody", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertTag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertInsertTag", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "foundInsertTag", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertTagDepthDelta", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "popDepth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pushDepth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastMap", "Ljavax/swing/text/html/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inStyle", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultStyle", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "styles", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inHead", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isStyleCSS", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "emptyDocument", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "styleAttributes", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "option", "Ljavax/swing/text/html/Option;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parseBuffer", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "charAttr", "Ljavax/swing/text/MutableAttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "charAttrStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tagMap", "Ljava/util/Hashtable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "inBlock", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "nextTagAfterPImplied", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/html/HTMLDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLReader", "(Ljavax/swing/text/html/HTMLDocument;IIILjavax/swing/text/html/HTML$Tag;ZZZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLReader", "(Ljavax/swing/text/html/HTMLDocument;IIILjavax/swing/text/html/HTML$Tag;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HTMLReader", "(Ljavax/swing/text/html/HTMLDocument;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "flushBuffer", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addContent", "([CIIZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addContent", "([CII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleComment", "([CI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleStartTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleEndTag", "(Ljavax/swing/text/html/HTML$Tag;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleSimpleTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleEndOfLineString", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "foundInsertTag", "(Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "generateEndsSpecsForMidInsert", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "heightToElementWithName", "(Ljava/lang/Object;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "depthTo", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPathTo", "(I)[Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "adjustEndElement", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "textAreaContent", "([C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "preContent", "([C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addExternalComment", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addSpecialElement", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockClose", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockOpen", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "canInsertTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/AttributeSet;Z)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pushCharacterStyle", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "popCharacterStyle", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "adjustEndSpecsForPartialInsert", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isInsertTag", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "registerTag", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTMLDocument$HTMLReader$TagAction;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addCSSRules", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "linkCSSStyleSheet", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleText", "([CI)V"));
		}

		[JniSignatureAttribute("Z", "private")]
		public bool receivedEndHTML_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int flushCount_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool insertAfterImplied_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Z", "private")]
		public bool wantsTrailingNewline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "")]
		public int threshold_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("I", "")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inParagraph_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool impliedP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inPre_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inTextArea_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/TextAreaDocument;", "")]
		public Dova.JDK.javax.swing.text.html.TextAreaDocument textAreaDocument_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.TextAreaDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inTitle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool lastWasNewline_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool emptyAnchor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool midInsert_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inBody_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[15]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[15], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag insertTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool insertInsertTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[17]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[17], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool foundInsertTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[18]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[18], value);
		}

		[JniSignatureAttribute("I", "")]
		public int insertTagDepthDelta_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[19]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[19], value);
		}

		[JniSignatureAttribute("I", "")]
		public int popDepth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[20]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[20], value);
		}

		[JniSignatureAttribute("I", "")]
		public int pushDepth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[21]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[21], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/Map;", "")]
		public Dova.JDK.javax.swing.text.html.Map lastMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.Map>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[23]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[23], value);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String defaultStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "")]
		public Dova.JDK.java.util.Vector styles_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "")]
		public bool inHead_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[26]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[26], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool isStyleCSS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[27]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[27], value);
		}

		[JniSignatureAttribute("Z", "")]
		public bool emptyDocument_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[28]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[28], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "")]
		public Dova.JDK.javax.swing.text.AttributeSet styleAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/Option;", "")]
		public Dova.JDK.javax.swing.text.html.Option option_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.Option>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "protected")]
		public Dova.JDK.java.util.Vector parseBuffer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/MutableAttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.MutableAttributeSet charAttr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.MutableAttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack charAttrStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Hashtable;", "")]
		public Dova.JDK.java.util.Hashtable tagMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Hashtable>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "")]
		public int inBlock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[35]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[35], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "private")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag nextTagAfterPImplied_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument;", "final")]
		public Dova.JDK.javax.swing.text.html.HTMLDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HTMLReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;IIILjavax/swing/text/html/HTML$Tag;ZZZ)V", "")]
		public HTMLReader(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1, int arg2, int arg3, Dova.JDK.javax.swing.text.html.HTML.Tag arg4, bool arg5, bool arg6, bool arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;IIILjavax/swing/text/html/HTML$Tag;)V", "public")]
		public HTMLReader(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1, int arg2, int arg3, Dova.JDK.javax.swing.text.html.HTML.Tag arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;I)V", "public")]
		public HTMLReader(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Z)V", "")]
		public void flushBuffer(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("([CIIZ)V", "protected")]
		public void addContent(JavaArray<char> arg0, int arg1, int arg2, bool arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("([CII)V", "protected")]
		public void addContent(JavaArray<char> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("([CI)V", "public")]
		public void handleComment(JavaArray<char> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V", "public")]
		public void handleStartTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;I)V", "public")]
		public void handleEndTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;I)V", "public")]
		public void handleSimpleTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public void handleEndOfLineString(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Z)V", "private")]
		public void foundInsertTag(bool arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void generateEndsSpecsForMidInsert()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;I)I", "private")]
		public int heightToElementWithName(Dova.JDK.java.lang.Object arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "private")]
		public int depthTo(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return ret;
		}

		[JniSignatureAttribute("(I)[Ljavax/swing/text/Element;", "private")]
		public JavaArray<Dova.JDK.javax.swing.text.Element> getPathTo(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.Element>>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void adjustEndElement()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
		}

		[JniSignatureAttribute("([C)V", "protected")]
		public void textAreaContent(JavaArray<char> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("([C)V", "protected")]
		public void preContent(JavaArray<char> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
		public void addExternalComment(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "protected")]
		public void addSpecialElement(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "protected")]
		public void blockClose(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "protected")]
		public void blockOpen(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/AttributeSet;Z)Z", "private")]
		public bool canInsertTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, bool arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected")]
		public void pushCharacterStyle()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22]);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void popCharacterStyle()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23]);
		}

		[JniSignatureAttribute("()V", "private")]
		public void adjustEndSpecsForPartialInsert()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24]);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "private")]
		public bool isInsertTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/html/HTMLDocument$HTMLReader$TagAction;)V", "protected")]
		public void registerTag(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void addCSSRules(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void linkCSSStyleSheet(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("([CI)V", "public")]
		public void handleText(JavaArray<char> arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$TagAction;", "public")]
		public partial class TagAction
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TagAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$TagAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TagAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TagAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public TagAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$TagAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$BlockAction;", "public")]
		public partial class BlockAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BlockAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$BlockAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BlockAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BlockAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public BlockAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$BlockAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ParagraphAction;", "public")]
		public partial class ParagraphAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.BlockAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ParagraphAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ParagraphAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParagraphAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ParagraphAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public ParagraphAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$ParagraphAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$CharacterAction;", "public")]
		public partial class CharacterAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CharacterAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$CharacterAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "CharacterAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CharacterAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public CharacterAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$CharacterAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$SpecialAction;", "public")]
		public partial class SpecialAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static SpecialAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$SpecialAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SpecialAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public SpecialAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public SpecialAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$SpecialAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormAction;", "public")]
		public partial class FormAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.SpecialAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FormAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "selectModel", "Ljava/lang/Object;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "optionCount", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FormAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setModel", "(Ljava/lang/String;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljava/lang/Object;", "")]
			public Dova.JDK.java.lang.Object selectModel_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("I", "")]
			public int optionCount_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FormAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public FormAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/MutableAttributeSet;)V", "")]
			public void setModel(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$HiddenAction;", "public")]
		public partial class HiddenAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static HiddenAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$HiddenAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HiddenAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public HiddenAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public HiddenAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$HiddenAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "")]
			public bool isEmpty(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ConvertAction;", "")]
		public partial class ConvertAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ConvertAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ConvertAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ConvertAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ConvertAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public ConvertAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$ConvertAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$AnchorAction;", "")]
		public partial class AnchorAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.CharacterAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AnchorAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$AnchorAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AnchorAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AnchorAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public AnchorAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$AnchorAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$AreaAction;", "")]
		public partial class AreaAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static AreaAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$AreaAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AreaAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public AreaAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public AreaAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$AreaAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$BaseAction;", "")]
		public partial class BaseAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static BaseAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$BaseAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BaseAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public BaseAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public BaseAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$BaseAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormTagAction;", "private")]
		public partial class FormTagAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.BlockAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static FormTagAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormTagAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FormTagAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public FormTagAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "private")]
			public FormTagAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$FormTagAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$HeadAction;", "")]
		public partial class HeadAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.BlockAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static HeadAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$HeadAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "HeadAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handleLink", "(Ljavax/swing/text/AttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public HeadAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public HeadAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$HeadAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "")]
			public bool isEmpty(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)V", "private")]
			public void handleLink(Dova.JDK.javax.swing.text.AttributeSet arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$IsindexAction;", "public")]
		public partial class IsindexAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static IsindexAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$IsindexAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IsindexAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public IsindexAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public IsindexAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$IsindexAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$LinkAction;", "")]
		public partial class LinkAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.HiddenAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static LinkAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$LinkAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LinkAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public LinkAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public LinkAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$LinkAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$MapAction;", "")]
		public partial class MapAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MapAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$MapAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MapAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MapAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public MapAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$MapAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$MetaAction;", "")]
		public partial class MetaAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.HiddenAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static MetaAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$MetaAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MetaAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public MetaAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public MetaAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$MetaAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "")]
			public bool isEmpty(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ObjectAction;", "")]
		public partial class ObjectAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.SpecialAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ObjectAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$ObjectAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ObjectAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addParameter", "(Ljavax/swing/text/AttributeSet;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ObjectAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public ObjectAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$ObjectAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)V", "")]
			public void addParameter(Dova.JDK.javax.swing.text.AttributeSet arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$PreAction;", "public")]
		public partial class PreAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.BlockAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PreAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$PreAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "PreAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PreAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "public")]
			public PreAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$PreAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$StyleAction;", "")]
		public partial class StyleAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.TagAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static StyleAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$StyleAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StyleAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public StyleAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public StyleAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$StyleAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "")]
			public bool isEmpty(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader$TitleAction;", "")]
		public partial class TitleAction
			: Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader.HiddenAction
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static TitleAction()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$HTMLReader$TitleAction;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$1", "Ljavax/swing/text/html/HTMLDocument$HTMLReader;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TitleAction", "(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEmpty", "(Ljavax/swing/text/html/HTML$Tag;)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "start", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "end", "(Ljavax/swing/text/html/HTML$Tag;)V"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$HTMLReader;", "final")]
			public Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader this1_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public TitleAction(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument$HTMLReader;)V", "")]
			public TitleAction(Dova.JDK.javax.swing.text.html.HTMLDocument.HTMLReader arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$HTMLReader$TitleAction;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)Z", "")]
			public bool isEmpty(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
				return ret;
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/MutableAttributeSet;)V", "public")]
			public void start(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.MutableAttributeSet arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			}

			[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;)V", "public")]
			public void end(Dova.JDK.javax.swing.text.html.HTML.Tag arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$LeafIterator;", "static")]
	public partial class LeafIterator
		: Dova.JDK.javax.swing.text.html.HTMLDocument.Iterator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LeafIterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$LeafIterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "endOffset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tag", "Ljavax/swing/text/html/HTML$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pos", "Ljavax/swing/text/ElementIterator;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LeafIterator", "(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/Document;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isValid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTag", "()Ljavax/swing/text/html/HTML$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextLeaf", "(Ljavax/swing/text/ElementIterator;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setEndOffset", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEndOffset", "()I"));
		}

		[JniSignatureAttribute("I", "private")]
		public int endOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTML$Tag;", "private")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/ElementIterator;", "private")]
		public Dova.JDK.javax.swing.text.ElementIterator pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.ElementIterator>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LeafIterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTML$Tag;Ljavax/swing/text/Document;)V", "")]
		public LeafIterator(Dova.JDK.javax.swing.text.html.HTML.Tag arg0, Dova.JDK.javax.swing.text.Document arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$LeafIterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void next()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/HTML$Tag;", "public")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/ElementIterator;)V", "")]
		public void nextLeaf(Dova.JDK.javax.swing.text.ElementIterator arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()V", "")]
		public void setEndOffset()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$RunElement;", "public")]
	public partial class RunElement
		: Dova.JDK.javax.swing.text.AbstractDocument.LeafElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RunElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$RunElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/html/HTMLDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "RunElement", "(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolveParent", "()Ljavax/swing/text/AttributeSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument;", "final")]
		public Dova.JDK.javax.swing.text.html.HTMLDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public RunElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;II)V", "public")]
		public RunElement(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$RunElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getResolveParent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$BlockElement;", "public")]
	public partial class BlockElement
		: Dova.JDK.javax.swing.text.AbstractDocument.BranchElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BlockElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$BlockElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/html/HTMLDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "BlockElement", "(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getResolveParent", "()Ljavax/swing/text/AttributeSet;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument;", "final")]
		public Dova.JDK.javax.swing.text.html.HTMLDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTMLDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BlockElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/html/HTMLDocument;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;)V", "public")]
		public BlockElement(Dova.JDK.javax.swing.text.html.HTMLDocument arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.AttributeSet arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$BlockElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getResolveParent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$FixedLengthDocument;", "private static")]
	public partial class FixedLengthDocument
		: Dova.JDK.javax.swing.text.PlainDocument
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FixedLengthDocument()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$FixedLengthDocument;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxLength", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "FixedLengthDocument", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertString", "(ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V"));
		}

		[JniSignatureAttribute("I", "private")]
		public int maxLength_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FixedLengthDocument(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "public")]
		public FixedLengthDocument(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$FixedLengthDocument;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(ILjava/lang/String;Ljavax/swing/text/AttributeSet;)V", "public")]
		public void insertString(int arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.swing.text.AttributeSet arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$TaggedAttributeSet;", "static")]
	public partial class TaggedAttributeSet
		: Dova.JDK.javax.swing.text.SimpleAttributeSet
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TaggedAttributeSet()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$TaggedAttributeSet;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TaggedAttributeSet", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TaggedAttributeSet(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TaggedAttributeSet() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$TaggedAttributeSet;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljavax/swing/text/html/HTMLDocument$Iterator;", "public abstract static")]
	public partial class Iterator
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Iterator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/html/HTMLDocument$Iterator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Iterator", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isValid", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTag", "()Ljavax/swing/text/html/HTML$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStartOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getEndOffset", "()I"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Iterator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public Iterator() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/html/HTMLDocument$Iterator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public abstract")]
		public void next()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public abstract")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool isValid()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/html/HTML$Tag;", "public abstract")]
		public Dova.JDK.javax.swing.text.html.HTML.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.html.HTML.Tag>(ret);
		}

		[JniSignatureAttribute("()I", "public abstract")]
		public int getStartOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public abstract")]
		public int getEndOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}
}
