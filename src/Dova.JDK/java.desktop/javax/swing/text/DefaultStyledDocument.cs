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

namespace Dova.JDK.javax.swing.text;

[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument;", "public")]
public partial class DefaultStyledDocument
	: Dova.JDK.javax.swing.text.AbstractDocument
	, Dova.JDK.javax.swing.text.StyledDocument
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DefaultStyledDocument()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BUFFER_SIZE_DEFAULT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "buffer", "Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "listeningStyles", "Ljava/util/Vector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "styleChangeListener", "Ljavax/swing/event/ChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "styleContextChangeListener", "Ljavax/swing/event/ChangeListener;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "updateRunnable", "Ljavax/swing/text/DefaultStyledDocument$ChangeUpdateRunnable;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DefaultStyledDocument", "()V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DefaultStyledDocument", "(Ljavax/swing/text/StyleContext;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DefaultStyledDocument", "(Ljavax/swing/text/AbstractDocument$Content;Ljavax/swing/text/StyleContext;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert", "(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setCharacterAttributes", "(IILjavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeDocumentListener", "(Ljavax/swing/event/DocumentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertUpdate", "(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/AttributeSet;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeUpdate", "(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addDocumentListener", "(Ljavax/swing/event/DocumentListener;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFont", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addStyle", "(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLogicalStyle", "(ILjavax/swing/text/Style;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElementImpl", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createSpecsForInsertAfterNewline", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;Ljava/util/Vector;II)S"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStyleContextChangeListener", "()Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "updateStylesListeningTo", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createStyleChangeListener", "()Ljavax/swing/event/ChangeListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLogicalStyle", "(I)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setParagraphAttributes", "(IILjavax/swing/text/AttributeSet;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "styleChanged", "(Ljavax/swing/text/Style;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStyle", "(Ljava/lang/String;)Ljavax/swing/text/Style;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharacterElement", "(I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultRootElement", "()Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createDefaultRoot", "()Ljavax/swing/text/AbstractDocument$AbstractElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeStyle", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getStyleNames", "()Ljava/util/Enumeration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParagraphElement", "(I)Ljavax/swing/text/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElement", "(Ljavax/swing/text/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getForeground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBackground", "(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;"));
	}

	[JniSignatureAttribute("I", "public static final")]
	public static int BUFFER_SIZE_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;", "protected")]
	public Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer buffer_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Vector;", "private transient")]
	public Dova.JDK.java.util.Vector listeningStyles_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeListener;", "private transient")]
	public Dova.JDK.javax.swing.@event.ChangeListener styleChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/event/ChangeListener;", "private transient")]
	public Dova.JDK.javax.swing.@event.ChangeListener styleContextChangeListener_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ChangeUpdateRunnable;", "private transient")]
	public Dova.JDK.javax.swing.text.DefaultStyledDocument.ChangeUpdateRunnable updateRunnable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument.ChangeUpdateRunnable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DefaultStyledDocument(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DefaultStyledDocument() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/StyleContext;)V", "public")]
	public DefaultStyledDocument(Dova.JDK.javax.swing.text.StyleContext arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$Content;Ljavax/swing/text/StyleContext;)V", "public")]
	public DefaultStyledDocument(Dova.JDK.javax.swing.text.AbstractDocument.Content arg0, Dova.JDK.javax.swing.text.StyleContext arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "protected")]
	public void insert(int arg0, JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "protected")]
	public void create(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/AttributeSet;Z)V", "public")]
	public void setCharacterAttributes(int arg0, int arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentListener;)V", "public")]
	public void removeDocumentListener(Dova.JDK.javax.swing.@event.DocumentListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;Ljavax/swing/text/AttributeSet;)V", "protected")]
	public void insertUpdate(Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg0, Dova.JDK.javax.swing.text.AttributeSet arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "protected")]
	public void removeUpdate(Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/event/DocumentListener;)V", "public")]
	public void addDocumentListener(Dova.JDK.javax.swing.@event.DocumentListener arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Font;", "public")]
	public Dova.JDK.java.awt.Font getFont(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Font>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/swing/text/Style;)Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style addStyle(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.swing.text.Style arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(ILjavax/swing/text/Style;)V", "public")]
	public void setLogicalStyle(int arg0, Dova.JDK.javax.swing.text.Style arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "private")]
	public void removeElementImpl(Dova.JDK.javax.swing.text.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;Ljava/util/Vector;II)S", "")]
	public short createSpecsForInsertAfterNewline(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, Dova.JDK.java.util.Vector arg3, int arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("()Ljavax/swing/event/ChangeListener;", "")]
	public Dova.JDK.javax.swing.@event.ChangeListener createStyleContextChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void updateStylesListeningTo()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14]);
	}

	[JniSignatureAttribute("()Ljavax/swing/event/ChangeListener;", "")]
	public Dova.JDK.javax.swing.@event.ChangeListener createStyleChangeListener()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style getLogicalStyle(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(IILjavax/swing/text/AttributeSet;Z)V", "public")]
	public void setParagraphAttributes(int arg0, int arg1, Dova.JDK.javax.swing.text.AttributeSet arg2, bool arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Style;)V", "protected")]
	public void styleChanged(Dova.JDK.javax.swing.text.Style arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/swing/text/Style;", "public")]
	public Dova.JDK.javax.swing.text.Style getStyle(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "public")]
	public Dova.JDK.javax.swing.text.Element getCharacterElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public")]
	public Dova.JDK.javax.swing.text.Element getDefaultRootElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("()Ljavax/swing/text/AbstractDocument$AbstractElement;", "protected")]
	public Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement createDefaultRoot()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
	public void removeStyle(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/Enumeration;", "public")]
	public Dova.JDK.java.util.Enumeration getStyleNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Enumeration>(ret);
	}

	[JniSignatureAttribute("(I)Ljavax/swing/text/Element;", "public")]
	public Dova.JDK.javax.swing.text.Element getParagraphElement(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/Element;)V", "public")]
	public void removeElement(Dova.JDK.javax.swing.text.Element arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getForeground(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;)Ljava/awt/Color;", "public")]
	public Dova.JDK.java.awt.Color getBackground(Dova.JDK.javax.swing.text.AttributeSet arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.awt.Color>(ret);
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;", "public")]
	public partial class ElementBuffer
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.io.Serializable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementBuffer()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "root", "Ljavax/swing/text/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "length", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "endOffset", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "changes", "Ljava/util/Vector;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "path", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertOp", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "recreateLeafs", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "insertPath", "[Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "createdFracture", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fracturedParent", "Ljavax/swing/text/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fracturedChild", "Ljavax/swing/text/Element;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offsetLastIndex", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offsetLastIndexOnReplace", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/DefaultStyledDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ElementBuffer", "(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/text/Element;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "remove", "(IILjavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "clone", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insert", "(II[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "split", "(II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "join", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;Ljavax/swing/text/Element;II)Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "create", "(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "advance", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "push", "(Ljavax/swing/text/Element;IZ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "push", "(Ljavax/swing/text/Element;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "pop", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertUpdate", "([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeUpdate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getRootElement", "()Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "beginEdits", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "endEdits", "(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertElement", "(Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "changeUpdate", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "insertFirstContent", "([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fractureDeepestLeaf", "([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fracture", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "removeElements", "(Ljavax/swing/text/Element;II)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "canJoin", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cloneAsNecessary", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;II)Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fractureFrom", "([Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "recreateFracturedElement", "(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Ljavax/swing/text/Element;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "change", "(IILjavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "")]
		public Dova.JDK.javax.swing.text.Element root_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "transient")]
		public int pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("I", "transient")]
		public int offset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("I", "transient")]
		public int length_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("I", "transient")]
		public int endOffset_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("Ljava/util/Vector;", "transient")]
		public Dova.JDK.java.util.Vector changes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "transient")]
		public Dova.JDK.java.util.Stack path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "transient")]
		public bool insertOp_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
		}

		[JniSignatureAttribute("Z", "transient")]
		public bool recreateLeafs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("[Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;", "transient")]
		public JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer.ElemChanges> insertPath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer.ElemChanges>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "transient")]
		public bool createdFracture_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "transient")]
		public Dova.JDK.javax.swing.text.Element fracturedParent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "transient")]
		public Dova.JDK.javax.swing.text.Element fracturedChild_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "transient")]
		public bool offsetLastIndex_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
		}

		[JniSignatureAttribute("Z", "transient")]
		public bool offsetLastIndexOnReplace_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[14]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[14], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument;", "final")]
		public Dova.JDK.javax.swing.text.DefaultStyledDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElementBuffer(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/text/Element;)V", "public")]
		public ElementBuffer(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0, Dova.JDK.javax.swing.text.Element arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(IILjavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "public")]
		public void remove(int arg0, int arg1, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Ljavax/swing/text/Element;", "public")]
		public Dova.JDK.javax.swing.text.Element clone(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(II[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "public")]
		public void insert(int arg0, int arg1, JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg2, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(II)Z", "")]
		public bool split(int arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;Ljavax/swing/text/Element;II)Ljavax/swing/text/Element;", "")]
		public Dova.JDK.javax.swing.text.Element join(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1, Dova.JDK.javax.swing.text.Element arg2, int arg3, int arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(I[Ljavax/swing/text/DefaultStyledDocument$ElementSpec;Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "")]
		public void create(int arg0, JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg1, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void advance(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;IZ)V", "")]
		public void push(Dova.JDK.javax.swing.text.Element arg0, int arg1, bool arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;I)V", "")]
		public void push(Dova.JDK.javax.swing.text.Element arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "")]
		public void pop()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9]);
		}

		[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "protected")]
		public void insertUpdate(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void removeUpdate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
		}

		[JniSignatureAttribute("()Ljavax/swing/text/Element;", "public")]
		public Dova.JDK.javax.swing.text.Element getRootElement()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(II)V", "")]
		public void beginEdits(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "")]
		public void endEdits(Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "")]
		public void insertElement(Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void changeUpdate()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16]);
		}

		[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "")]
		public void insertFirstContent(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementSpec;)V", "")]
		public void fractureDeepestLeaf(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementSpec> arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(I)V", "")]
		public void fracture(int arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;II)Z", "")]
		public bool removeElements(Dova.JDK.javax.swing.text.Element arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Z", "")]
		public bool canJoin(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;II)Ljavax/swing/text/Element;", "")]
		public Dova.JDK.javax.swing.text.Element cloneAsNecessary(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("([Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;II)V", "")]
		public void fractureFrom(JavaArray<Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer.ElemChanges> arg0, int arg1, int arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/Element;)Ljavax/swing/text/Element;", "")]
		public Dova.JDK.javax.swing.text.Element recreateFracturedElement(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.Element arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
		}

		[JniSignatureAttribute("(IILjavax/swing/text/AbstractDocument$DefaultDocumentEvent;)V", "public")]
		public void change(int arg0, int arg1, Dova.JDK.javax.swing.text.AbstractDocument.DefaultDocumentEvent arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;", "")]
		public partial class ElemChanges
			: Dova.JDK.java.lang.Object
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ElemChanges()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parent", "Ljavax/swing/text/Element;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "index", "I"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "added", "Ljava/util/Vector;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "removed", "Ljava/util/Vector;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isFracture", "Z"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ElemChanges", "(Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;Ljavax/swing/text/Element;IZ)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/Element;", "")]
			public Dova.JDK.javax.swing.text.Element parent_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("I", "")]
			public int index_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
					return ret;
				}
				set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}

			[JniSignatureAttribute("Ljava/util/Vector;", "")]
			public Dova.JDK.java.util.Vector added_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Ljava/util/Vector;", "")]
			public Dova.JDK.java.util.Vector removed_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Vector>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Z", "")]
			public bool isFracture_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
					return ret;
				}
				set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ElemChanges(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument$ElementBuffer;Ljavax/swing/text/Element;IZ)V", "")]
			public ElemChanges(Dova.JDK.javax.swing.text.DefaultStyledDocument.ElementBuffer arg0, Dova.JDK.javax.swing.text.Element arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$ElementBuffer$ElemChanges;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljava/lang/String;", "public")]
			public Dova.JDK.java.lang.String toString()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ElementSpec;", "public static")]
	public partial class ElementSpec
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementSpec()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$ElementSpec;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "StartTagType", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EndTagType", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ContentType", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JoinPreviousDirection", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JoinNextDirection", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OriginateDirection", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JoinFractureDirection", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "attr", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "len", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "direction", "S"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "offs", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "data", "[C"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ElementSpec", "(Ljavax/swing/text/AttributeSet;S[CII)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ElementSpec", "(Ljavax/swing/text/AttributeSet;SI)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ElementSpec", "(Ljavax/swing/text/AttributeSet;S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLength", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getType", "()S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAttributes", "()Ljavax/swing/text/AttributeSet;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOffset", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getArray", "()[C"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDirection", "()S"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setDirection", "(S)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setType", "(S)V"));
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short StartTagType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short EndTagType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short ContentType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short JoinPreviousDirection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[3], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short JoinNextDirection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[4], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short OriginateDirection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[5], value);
		}

		[JniSignatureAttribute("S", "public static final")]
		public static short JoinFractureDirection_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticShortField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticShortField(ClassRefPtr, FieldPtrs[6], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "private")]
		public Dova.JDK.javax.swing.text.AttributeSet attr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("I", "private")]
		public int len_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
		}

		[JniSignatureAttribute("S", "private")]
		public short type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[9]);
				return ret;
			}
			set => DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[9], value);
		}

		[JniSignatureAttribute("S", "private")]
		public short direction_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetShortField(CurrentRefPtr, FieldPtrs[10]);
				return ret;
			}
			set => DovaVM.Runtime.SetShortField(CurrentRefPtr, FieldPtrs[10], value);
		}

		[JniSignatureAttribute("I", "private")]
		public int offs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
		}

		[JniSignatureAttribute("[C", "private")]
		public JavaArray<char> data_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElementSpec(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;S[CII)V", "public")]
		public ElementSpec(Dova.JDK.javax.swing.text.AttributeSet arg0, short arg1, JavaArray<char> arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;SI)V", "public")]
		public ElementSpec(Dova.JDK.javax.swing.text.AttributeSet arg0, short arg1, int arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AttributeSet;S)V", "public")]
		public ElementSpec(Dova.JDK.javax.swing.text.AttributeSet arg0, short arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$ElementSpec;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getLength()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()S", "public")]
		public short getType()
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/swing/text/AttributeSet;", "public")]
		public Dova.JDK.javax.swing.text.AttributeSet getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getOffset()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()[C", "public")]
		public JavaArray<char> getArray()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}

		[JniSignatureAttribute("()S", "public")]
		public short getDirection()
		{
			var ret = DovaVM.Runtime.CallShortMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(S)V", "public")]
		public void setDirection(short arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(S)V", "public")]
		public void setType(short arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$StyleChangeUndoableEdit;", "static")]
	public partial class StyleChangeUndoableEdit
		: Dova.JDK.javax.swing.undo.AbstractUndoableEdit
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StyleChangeUndoableEdit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$StyleChangeUndoableEdit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "element", "Ljavax/swing/text/AbstractDocument$AbstractElement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "newStyle", "Ljavax/swing/text/Style;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "oldStyle", "Ljavax/swing/text/AttributeSet;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StyleChangeUndoableEdit", "(Ljavax/swing/text/AbstractDocument$AbstractElement;Ljavax/swing/text/Style;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "redo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "undo", "()V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/AbstractDocument$AbstractElement;", "protected")]
		public Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement element_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/Style;", "protected")]
		public Dova.JDK.javax.swing.text.Style newStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Style>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.AttributeSet oldStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StyleChangeUndoableEdit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/AbstractDocument$AbstractElement;Ljavax/swing/text/Style;)V", "public")]
		public StyleChangeUndoableEdit(Dova.JDK.javax.swing.text.AbstractDocument.AbstractElement arg0, Dova.JDK.javax.swing.text.Style arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$StyleChangeUndoableEdit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void redo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void undo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$AttributeUndoableEdit;", "public static")]
	public partial class AttributeUndoableEdit
		: Dova.JDK.javax.swing.undo.AbstractUndoableEdit
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttributeUndoableEdit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$AttributeUndoableEdit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "newAttributes", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "copy", "Ljavax/swing/text/AttributeSet;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isReplacing", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "element", "Ljavax/swing/text/Element;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AttributeUndoableEdit", "(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "redo", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "undo", "()V"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.AttributeSet newAttributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/AttributeSet;", "protected")]
		public Dova.JDK.javax.swing.text.AttributeSet copy_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.AttributeSet>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "protected")]
		public bool isReplacing_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/Element;", "protected")]
		public Dova.JDK.javax.swing.text.Element element_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.Element>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttributeUndoableEdit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/Element;Ljavax/swing/text/AttributeSet;Z)V", "public")]
		public AttributeUndoableEdit(Dova.JDK.javax.swing.text.Element arg0, Dova.JDK.javax.swing.text.AttributeSet arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$AttributeUndoableEdit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void redo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()V", "public")]
		public void undo()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$SectionElement;", "protected")]
	public partial class SectionElement
		: Dova.JDK.javax.swing.text.AbstractDocument.BranchElement
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SectionElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$SectionElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/DefaultStyledDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "SectionElement", "(Ljavax/swing/text/DefaultStyledDocument;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument;", "final")]
		public Dova.JDK.javax.swing.text.DefaultStyledDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SectionElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;)V", "public")]
		public SectionElement(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$SectionElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$ChangeUpdateRunnable;", "")]
	public partial class ChangeUpdateRunnable
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChangeUpdateRunnable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$ChangeUpdateRunnable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isPending", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/DefaultStyledDocument;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ChangeUpdateRunnable", "(Ljavax/swing/text/DefaultStyledDocument;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
		}

		[JniSignatureAttribute("Z", "")]
		public bool isPending_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument;", "final")]
		public Dova.JDK.javax.swing.text.DefaultStyledDocument this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChangeUpdateRunnable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;)V", "")]
		public ChangeUpdateRunnable(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$ChangeUpdateRunnable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;", "abstract static")]
	public partial class AbstractChangeHandler
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.swing.@event.ChangeListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AbstractChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "queueMap", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "doc", "Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler$DocReference;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "AbstractChangeHandler", "(Ljavax/swing/text/DefaultStyledDocument;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getStaleListeners", "(Ljavax/swing/event/ChangeListener;)Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "stateChanged", "(Ljavax/swing/event/ChangeEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireStateChanged", "(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map queueMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler$DocReference;", "private")]
		public Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler.DocReference doc_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler.DocReference>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AbstractChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;)V", "")]
		public AbstractChangeHandler(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeListener;)Ljava/util/List;", "static")]
		public static Dova.JDK.java.util.List getStaleListeners(Dova.JDK.javax.swing.@event.ChangeListener arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Ljavax/swing/event/ChangeEvent;)V", "public")]
		public void stateChanged(Dova.JDK.javax.swing.@event.ChangeEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V", "abstract")]
		public void fireStateChanged(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0, Dova.JDK.javax.swing.@event.ChangeEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler$DocReference;", "private")]
		public partial class DocReference
			: Dova.JDK.java.lang.@ref.WeakReference
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static DocReference()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler$DocReference;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocReference", "(Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;Ljavax/swing/text/DefaultStyledDocument;Ljava/lang/ref/ReferenceQueue;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getListener", "()Ljavax/swing/event/ChangeListener;"));
			}

			[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;", "final")]
			public Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler>(ret);
				}
				set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public DocReference(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler;Ljavax/swing/text/DefaultStyledDocument;Ljava/lang/ref/ReferenceQueue;)V", "")]
			public DocReference(Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler arg0, Dova.JDK.javax.swing.text.DefaultStyledDocument arg1, Dova.JDK.java.lang.@ref.ReferenceQueue arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
			{
			}

			public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$AbstractChangeHandler$DocReference;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()Ljavax/swing/event/ChangeListener;", "")]
			public Dova.JDK.javax.swing.@event.ChangeListener getListener()
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.swing.@event.ChangeListener>(ret);
			}
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$StyleChangeHandler;", "static")]
	public partial class StyleChangeHandler
		: Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StyleChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$StyleChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StyleChangeHandler", "(Ljavax/swing/text/DefaultStyledDocument;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireStateChanged", "(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StyleChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;)V", "")]
		public StyleChangeHandler(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$StyleChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V", "")]
		public void fireStateChanged(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0, Dova.JDK.javax.swing.@event.ChangeEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}

	[JniSignatureAttribute("Ljavax/swing/text/DefaultStyledDocument$StyleContextChangeHandler;", "static")]
	public partial class StyleContextChangeHandler
		: Dova.JDK.javax.swing.text.DefaultStyledDocument.AbstractChangeHandler
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StyleContextChangeHandler()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/swing/text/DefaultStyledDocument$StyleContextChangeHandler;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "StyleContextChangeHandler", "(Ljavax/swing/text/DefaultStyledDocument;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "fireStateChanged", "(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StyleContextChangeHandler(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;)V", "")]
		public StyleContextChangeHandler(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/swing/text/DefaultStyledDocument$StyleContextChangeHandler;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/swing/text/DefaultStyledDocument;Ljavax/swing/event/ChangeEvent;)V", "")]
		public void fireStateChanged(Dova.JDK.javax.swing.text.DefaultStyledDocument arg0, Dova.JDK.javax.swing.@event.ChangeEvent arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}
}
