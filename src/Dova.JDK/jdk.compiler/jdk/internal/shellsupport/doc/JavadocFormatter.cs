/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.@internal.shellsupport.doc;

[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter;", "public")]
public partial class JavadocFormatter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JavadocFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CODE_RESET", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CODE_HIGHLIGHT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CODE_UNDERLINE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineLimit", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "escapeSequencesSupported", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX_LINE_LENGTH", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORTEST_LINE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDENT", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "docSections", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "inlineReturns", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IZ)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "escape", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addNewLineIfNeeded", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indentString", "(I)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatJavadoc", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "reflow", "(Ljava/lang/StringBuilder;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addSpaceIfNeeded", "(Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getHtmlTag", "(Ljavax/lang/model/element/Name;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "countTableColumns", "(Lcom/sun/source/doctree/DocCommentTree;)Ljava/util/Map;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CODE_RESET_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CODE_HIGHLIGHT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String CODE_UNDERLINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int lineLimit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool escapeSequencesSupported_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int MAX_LINE_LENGTH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SHORTEST_LINE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int INDENT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map docSections_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String inlineReturns_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JavadocFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(IZ)V", "public")]
	public JavadocFormatter(int arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String escape(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "private static")]
	public static void addNewLineIfNeeded(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String indentString(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String formatJavadoc(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;III)V", "private static")]
	public static void reflow(Dova.JDK.java.lang.StringBuilder arg0, int arg1, int arg2, int arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/StringBuilder;)V", "private static")]
	public static void addSpaceIfNeeded(Dova.JDK.java.lang.StringBuilder arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "private static")]
	public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag getHtmlTag(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;)Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map countTableColumns(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$FormatJavadocScanner;", "private")]
	public partial class FormatJavadocScanner
		: Dova.JDK.com.sun.source.util.DocTreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FormatJavadocScanner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocFormatter$FormatJavadocScanner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljava/lang/StringBuilder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "task", "Lcom/sun/source/util/JavacTask;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trees", "Lcom/sun/source/util/DocTrees;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reflownTo", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indent", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "limit", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pre", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableColumns", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "listStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tableStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cellsStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "headerStack", "Ljava/util/Stack;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastNode", "Lcom/sun/source/doctree/DocTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/internal/shellsupport/doc/JavadocFormatter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/shellsupport/doc/JavadocFormatter;Ljava/lang/StringBuilder;Lcom/sun/source/util/JavacTask;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startSection", "(Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatDef", "(Ljava/lang/CharSequence;Ljava/util/List;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reflowTillNow", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleEndElement", "(Ljavax/lang/model/element/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEndElement", "(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEntity", "(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocComment", "(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitText", "(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParam", "(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrows", "(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStartElement", "(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/lang/StringBuilder;", "private final")]
		public Dova.JDK.java.lang.StringBuilder result_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/JavacTask;", "private final")]
		public Dova.JDK.com.sun.source.util.JavacTask task_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.JavacTask>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/util/DocTrees;", "private final")]
		public Dova.JDK.com.sun.source.util.DocTrees trees_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int reflownTo_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int indent_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int limit_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool pre_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map tableColumns_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack listStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack defStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack tableStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack cellsStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Stack;", "")]
		public Dova.JDK.java.util.Stack headerStack_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Stack>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree;", "private")]
		public Dova.JDK.com.sun.source.doctree.DocTree lastNode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter;", "final")]
		public Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FormatJavadocScanner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/shellsupport/doc/JavadocFormatter;Ljava/lang/StringBuilder;Lcom/sun/source/util/JavacTask;)V", "public")]
		public FormatJavadocScanner(Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter arg0, Dova.JDK.java.lang.StringBuilder arg1, Dova.JDK.com.sun.source.util.JavacTask arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocFormatter$FormatJavadocScanner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object scan(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;)V", "private")]
		public void startSection(Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/util/List;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object formatDef(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitReturn(Dova.JDK.com.sun.source.doctree.ReturnTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void reflowTillNow()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)V", "private")]
		public void handleEndElement(Dova.JDK.javax.lang.model.element.Name arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitEndElement(Dova.JDK.com.sun.source.doctree.EndElementTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitEntity(Dova.JDK.com.sun.source.doctree.EntityTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitDocComment(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitText(Dova.JDK.com.sun.source.doctree.TextTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitParam(Dova.JDK.com.sun.source.doctree.ParamTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitThrows(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitLiteral(Dova.JDK.com.sun.source.doctree.LiteralTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object visitStartElement(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "static final")]
	public partial class HtmlTag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static HtmlTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTML", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H1", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H2", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H3", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H4", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H5", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H6", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCKQUOTE", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRE", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMG", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OL", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UL", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LI", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DL", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DT", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DD", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TR", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TD", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TH", "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "index", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljavax/lang/model/element/Name;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;"));
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag HTML_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H3_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H5_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag H6_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag BLOCKQUOTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag P_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag PRE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag IMG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag OL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag UL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag LI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag DL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag DT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag DD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag TABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag TR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag TD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag TH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public HtmlTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public HtmlTag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag get(Dova.JDK.javax.lang.model.element.Name arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "public static")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/internal/shellsupport/doc/JavadocFormatter$HtmlTag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.HtmlTag>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "private abstract static")]
	public partial class Sections
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Sections()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_PARAMS", "Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARAMS", "Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURNS", "Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "matches", "(Lcom/sun/source/doctree/DocTree;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;"));
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections TYPE_PARAMS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections PARAMS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections RETURNS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static final")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections THROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Sections(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Sections(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "public static")]
		public static Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "public abstract")]
		public bool matches(Dova.JDK.com.sun.source.doctree.DocTree arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()[Ljdk/internal/shellsupport/doc/JavadocFormatter$Sections;", "private static")]
		public static JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.@internal.shellsupport.doc.JavadocFormatter.Sections>>(ret);
		}
	}
}
