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

namespace Dova.JDK.com.sun.tools.javac.parser;

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens;", "public")]
public partial class Tokens
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Tokens()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "names", "Lcom/sun/tools/javac/util/Names;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "keywords", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "tokensKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DUMMY", "Lcom/sun/tools/javac/parser/Tokens$Token;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/parser/Tokens;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupKind", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupKind", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Names;", "private final")]
	public Dova.JDK.com.sun.tools.javac.util.Names names_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Names>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private")]
	public Dova.JDK.java.util.Map keywords_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key tokensKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token;", "public static final")]
	public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token DUMMY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Tokens(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public Tokens(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/parser/Tokens;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.parser.Tokens instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "")]
	public Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind lookupKind(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "")]
	public Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind lookupKind(Dova.JDK.com.sun.tools.javac.util.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
	public partial class TokenKind
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.com.sun.tools.javac.api.Formattable
		, Dova.JDK.java.util.function.Predicate
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TokenKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$TokenKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EOF", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENTIFIER", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABSTRACT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASSERT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOLEAN", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAK", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BYTE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CATCH", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONST", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DO", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELSE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXTENDS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FINALLY", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOAT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GOTO", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLEMENTS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPORT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCEOF", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTERFACE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONG", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NATIVE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVATE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROTECTED", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PUBLIC", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHORT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRICTFP", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWITCH", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNCHRONIZED", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THIS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROW", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRANSIENT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRY", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOID", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VOLATILE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHILE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INTLITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONGLITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FLOATLITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOUBLELITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARLITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRINGLITERAL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRUE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FALSE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDERSCORE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARROW", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLCOL", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LPAREN", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RPAREN", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LBRACE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RBRACE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LBRACKET", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RBRACKET", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEMI", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMMA", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELLIPSIS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BANG", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TILDE", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUES", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLON", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BANGEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMPAMP", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BARBAR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUSPLUS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBSUB", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUS", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUB", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STAR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLASH", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMP", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAR", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CARET", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERCENT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTLT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTGT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUSEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STAREQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SLASHEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AMPEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BAREQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CARETEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERCENTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LTLTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GTGTGTEQ", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MONKEYS_AT", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CUSTOM", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$Token$Tag;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;Lcom/sun/tools/javac/parser/Tokens$Token$Tag;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Ljava/util/Locale;Lcom/sun/tools/javac/api/Messages;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "test", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind EOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ERROR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind IDENTIFIER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ABSTRACT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ASSERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BOOLEAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BREAK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BYTE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CONST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CONTINUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind DO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind DOUBLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ELSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ENUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind EXTENDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FINAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FINALLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FLOAT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GOTO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind IF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind IMPLEMENTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind IMPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind INSTANCEOF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind INT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind NATIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind NEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PRIVATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PROTECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PUBLIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind RETURN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SHORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind STATIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind STRICTFP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SUPER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SYNCHRONIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind THIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind THROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind THROWS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind TRANSIENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind TRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind VOID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind VOLATILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind WHILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind INTLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LONGLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FLOATLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind DOUBLELITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CHARLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind STRINGLITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind TRUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind FALSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind NULL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind UNDERSCORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ARROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind COLCOL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LPAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind RPAREN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LBRACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind RBRACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LBRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind RBRACKET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SEMI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind COMMA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind DOT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind ELLIPSIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind EQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BANG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind TILDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind QUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind COLON_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind EQEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BANGEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind AMPAMP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BARBAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PLUSPLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SUBSUB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SUB_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind STAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SLASH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind AMP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CARET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PERCENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LTLT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GTGT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GTGTGT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PLUSEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SUBEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind STAREQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind SLASHEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind AMPEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind BAREQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CARETEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind PERCENTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind LTLTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GTGTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind GTGTGTEQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind MONKEYS_AT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind CUSTOM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[114], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public final")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[115], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TokenKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/parser/Tokens$Token$Tag;)V", "private")]
		public TokenKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public TokenKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;Lcom/sun/tools/javac/parser/Tokens$Token$Tag;)V", "private")]
		public TokenKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public TokenKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$TokenKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/util/Locale;Lcom/sun/tools/javac/api/Messages;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString(Dova.JDK.java.util.Locale arg0, Dova.JDK.com.sun.tools.javac.api.Messages arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public volatile")]
		public bool test(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;)Z", "public")]
		public bool test(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token;", "public static")]
	public partial class Token
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Token()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$Token;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/parser/Tokens$TokenKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comments", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "split", "(Lcom/sun/tools/javac/parser/Tokens;)[Lcom/sun/tools/javac/parser/Tokens$Token;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "comment", "(Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;)Lcom/sun/tools/javac/parser/Tokens$Comment;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "radix", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKind", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringVal", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deprecatedFlag", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getComments", "(Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;)Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$TokenKind;", "public final")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public final")]
		public int pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("I", "public final")]
		public int endPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.List comments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Token(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILcom/sun/tools/javac/util/List;)V", "")]
		public Token(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$Token;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens;)[Lcom/sun/tools/javac/parser/Tokens$Token;", "")]
		public JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token> split(Dova.JDK.com.sun.tools.javac.parser.Tokens arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token>>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;)Lcom/sun/tools/javac/parser/Tokens$Comment;", "public")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment comment(Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int radix()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected")]
		public void checkKind()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String stringVal()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool deprecatedFlag()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;)Lcom/sun/tools/javac/util/List;", "private")]
		public Dova.JDK.com.sun.tools.javac.util.List getComments(Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "static final")]
		public partial class Tag
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Tag()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAMED", "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRING", "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NUMERIC", "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag DEFAULT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag NAMED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag STRING_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag NUMERIC_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Tag(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public Tag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$Token$Tag;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$Token$Tag;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Token.Tag>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$NumericToken;", "static final")]
	public partial class NumericToken
		: Dova.JDK.com.sun.tools.javac.parser.Tokens.StringToken
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumericToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$NumericToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "radix", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILjava/lang/String;ILcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "radix", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKind", "()V"));
		}

		[JniSignatureAttribute("I", "public final")]
		public int radix_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumericToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILjava/lang/String;ILcom/sun/tools/javac/util/List;)V", "public")]
		public NumericToken(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, int arg4, Dova.JDK.com.sun.tools.javac.util.List arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$NumericToken;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int radix()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()V", "protected")]
		public void checkKind()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$StringToken;", "static")]
	public partial class StringToken
		: Dova.JDK.com.sun.tools.javac.parser.Tokens.Token
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StringToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$StringToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringVal", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILjava/lang/String;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKind", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stringVal", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String stringVal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StringToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILjava/lang/String;Lcom/sun/tools/javac/util/List;)V", "public")]
		public StringToken(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, int arg1, int arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.javac.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$StringToken;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "protected")]
		public void checkKind()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String stringVal()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$NamedToken;", "static final")]
	public partial class NamedToken
		: Dova.JDK.com.sun.tools.javac.parser.Tokens.Token
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NamedToken()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$NamedToken;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkKind", "()V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NamedToken(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$TokenKind;IILcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)V", "public")]
		public NamedToken(Dova.JDK.com.sun.tools.javac.parser.Tokens.TokenKind arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.Name arg3, Dova.JDK.com.sun.tools.javac.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$NamedToken;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()V", "protected")]
		public void checkKind()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment;", "public abstract static interface")]
	public partial interface Comment
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Comment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$Comment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourcePos", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStyle", "()Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public abstract")]
		Dova.JDK.java.lang.String getText()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		bool isDeprecated()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "public abstract")]
		int getSourcePos(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle getStyle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static final")]
		public partial class CommentStyle
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CommentStyle()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINE", "Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK", "Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVADOC", "Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle LINE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle BLOCK_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle JAVADOC_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CommentStyle(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public CommentStyle(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/Tokens$Comment$CommentStyle;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment.CommentStyle>>(ret);
			}
		}
	}
}
