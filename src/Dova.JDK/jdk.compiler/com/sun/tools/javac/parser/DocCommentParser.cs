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

namespace Dova.JDK.com.sun.tools.javac.parser;

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser;", "public")]
public partial class DocCommentParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocCommentParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "fac", "Lcom/sun/tools/javac/parser/ParserFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "diags", "Lcom/sun/tools/javac/util/JCDiagnostic$Factory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "diagSource", "Lcom/sun/tools/javac/util/DiagnosticSource;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "comment", "Lcom/sun/tools/javac/parser/Tokens$Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "m", "Lcom/sun/tools/javac/tree/DocTreeMaker;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "isFileContent", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "buf", "[C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "bp", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "buflen", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "ch", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "textStart", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "lastNonWhite", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "newline", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "tagParsers", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocCommentParser", "(Lcom/sun/tools/javac/parser/ParserFactory;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocCommentParser", "(Lcom/sun/tools/javac/parser/ParserFactory;Lcom/sun/tools/javac/util/DiagnosticSource;Lcom/sun/tools/javac/parser/Tokens$Comment;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocCommentParser", "(Lcom/sun/tools/javac/parser/ParserFactory;Lcom/sun/tools/javac/util/DiagnosticSource;Lcom/sun/tools/javac/parser/Tokens$Comment;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isJavaIdentifierStart", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isWhitespace", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newString", "(II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "reference", "(Z)Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "peek", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "()Lcom/sun/tools/javac/tree/DCTree$DCDocComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "nextChar", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isHexDigit", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skipWhitespace", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isUnquotedAttrValueTerminator", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isHorizontalWhitespace", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTagParsers", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEndPreamble", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isEndBody", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addPendingText", "(Lcom/sun/tools/javac/util/ListBuffer;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isIdentifierStart", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readTagName", "()Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "quotedString", "()Lcom/sun/tools/javac/tree/DCTree$DCText;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inlineWord", "()Lcom/sun/tools/javac/tree/DCTree$DCText;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inlineContent", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "entity", "()Lcom/sun/tools/javac/tree/DCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "entity", "(Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockTags", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockContent", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockContent", "(Lcom/sun/tools/javac/parser/DocCommentParser$Phase;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inlineText", "(Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;)Lcom/sun/tools/javac/tree/DCTree$DCText;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readJavaIdentifier", "()Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDecimalDigit", "(C)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readIdentifier", "()Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "htmlAttrs", "()Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readAttributeName", "()Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "attrValueChar", "(Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readSystemPropertyName", "()Lcom/sun/tools/javac/util/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "blockTag", "()Lcom/sun/tools/javac/tree/DCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "erroneous", "(Ljava/lang/String;II)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "erroneous", "(Ljava/lang/String;I)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "html", "()Lcom/sun/tools/javac/tree/DCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inlineTag", "(Lcom/sun/tools/javac/util/ListBuffer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "inlineTag", "()Lcom/sun/tools/javac/tree/DCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "identifier", "()Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ParserFactory;", "private final")]
	public Dova.JDK.com.sun.tools.javac.parser.ParserFactory fac_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ParserFactory>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic$Factory;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory diags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.Factory>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/DiagnosticSource;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.DiagnosticSource diagSource_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.DiagnosticSource>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment;", "private final")]
	public Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment comment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocTreeMaker;", "private final")]
	public Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker m_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool isFileContent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("[C", "private")]
	public JavaArray<char> buf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<char>>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("I", "private")]
	public int bp_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[8]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[8], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int buflen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
	}

	[JniSignatureAttribute("C", "private")]
	public char ch_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set => DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[10], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int textStart_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[11], value);
	}

	[JniSignatureAttribute("I", "private")]
	public int lastNonWhite_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[12], value);
	}

	[JniSignatureAttribute("Z", "private")]
	public bool newline_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[13]);
			return ret;
		}
		set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[13], value);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map tagParsers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocCommentParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/ParserFactory;)V", "public")]
	public DocCommentParser(Dova.JDK.com.sun.tools.javac.parser.ParserFactory arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/ParserFactory;Lcom/sun/tools/javac/util/DiagnosticSource;Lcom/sun/tools/javac/parser/Tokens$Comment;)V", "public")]
	public DocCommentParser(Dova.JDK.com.sun.tools.javac.parser.ParserFactory arg0, Dova.JDK.com.sun.tools.javac.util.DiagnosticSource arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/ParserFactory;Lcom/sun/tools/javac/util/DiagnosticSource;Lcom/sun/tools/javac/parser/Tokens$Comment;Z)V", "public")]
	public DocCommentParser(Dova.JDK.com.sun.tools.javac.parser.ParserFactory arg0, Dova.JDK.com.sun.tools.javac.util.DiagnosticSource arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isJavaIdentifierStart(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isWhitespace(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(II)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String newString(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Z)Lcom/sun/tools/javac/tree/DCTree$DCReference;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference reference(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "")]
	public bool peek(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment parse()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void nextChar()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6]);
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isHexDigit(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "protected")]
	public void skipWhitespace()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8]);
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isUnquotedAttrValueTerminator(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isHorizontalWhitespace(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map createTagParsers()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isEndPreamble()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isEndBody()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ListBuffer;I)V", "protected")]
	public void addPendingText(Dova.JDK.com.sun.tools.javac.util.ListBuffer arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isIdentifierStart(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Name readTagName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCText;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText quotedString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCText;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText inlineWord()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List inlineContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree entity()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ListBuffer;)V", "protected")]
	public void entity(Dova.JDK.com.sun.tools.javac.util.ListBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List blockTags()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List blockContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/DocCommentParser$Phase;)Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List blockContent(Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;)Lcom/sun/tools/javac/tree/DCTree$DCText;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText inlineText(Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Name readJavaIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("(C)Z", "protected")]
	public bool isDecimalDigit(char arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Name readIdentifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.List htmlAttrs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Name readAttributeName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ListBuffer;)V", "protected")]
	public void attrValueChar(Dova.JDK.com.sun.tools.javac.util.ListBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "protected")]
	public Dova.JDK.com.sun.tools.javac.util.Name readSystemPropertyName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree blockTag()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous erroneous(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous erroneous(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree html()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/ListBuffer;)V", "protected")]
	public void inlineTag(Dova.JDK.com.sun.tools.javac.util.ListBuffer arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree inlineTag()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;", "protected")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier identifier()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "private static final")]
	public partial class Phase
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Phase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser$Phase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREAMBLE", "Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BODY", "Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "POSTAMBLE", "Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Phase", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase PREAMBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase BODY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase POSTAMBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Phase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Phase(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser$Phase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$Phase;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.Phase>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser;", "private abstract static")]
	public partial class TagParser
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TagParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "kind", "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "treeKind", "Lcom/sun/source/doctree/DocTree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "retainWhiteSpace", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TagParser", "(Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;Lcom/sun/source/doctree/DocTree$Kind;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TagParser", "(Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;Lcom/sun/source/doctree/DocTree$Kind;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(I)Lcom/sun/tools/javac/tree/DCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "parse", "(ILcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;)Lcom/sun/tools/javac/tree/DCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "allowsBlock", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "allowsInline", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTreeKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "final")]
		public Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree$Kind;", "final")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind treeKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Z", "final")]
		public bool retainWhiteSpace_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set => DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TagParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;Lcom/sun/source/doctree/DocTree$Kind;)V", "")]
		public TagParser(Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;Lcom/sun/source/doctree/DocTree$Kind;Z)V", "")]
		public TagParser(Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind arg0, Dova.JDK.com.sun.source.doctree.DocTree.Kind arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/DCTree;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree parse(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
		}

		[JniSignatureAttribute("(ILcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;)Lcom/sun/tools/javac/tree/DCTree;", "")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree parse(int arg0, Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
		}

		[JniSignatureAttribute("()Z", "")]
		public bool allowsBlock()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "")]
		public bool allowsInline()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getTreeKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "static final")]
		public partial class Kind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Kind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INLINE", "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BLOCK", "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EITHER", "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Kind", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind INLINE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind BLOCK_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind EITHER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>>(ret);
				}
				set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Kind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$TagParser$Kind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.TagParser.Kind>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$ParseException;", "static")]
	public partial class ParseException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParseException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser$ParseException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParseException", "(Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ParseException", "(ILjava/lang/String;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}

		[JniSignatureAttribute("I", "final")]
		public int pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set => DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParseException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public ParseException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(ILjava/lang/String;)V", "")]
		public ParseException(int arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser$ParseException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "private static final")]
	public partial class WhitespaceRetentionPolicy
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WhitespaceRetentionPolicy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RETAIN_ALL", "Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REMOVE_FIRST_SPACE", "Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REMOVE_ALL", "Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "WhitespaceRetentionPolicy", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy RETAIN_ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy REMOVE_FIRST_SPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy REMOVE_ALL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WhitespaceRetentionPolicy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public WhitespaceRetentionPolicy(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/DocCommentParser$WhitespaceRetentionPolicy;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.DocCommentParser.WhitespaceRetentionPolicy>>(ret);
		}
	}
}
