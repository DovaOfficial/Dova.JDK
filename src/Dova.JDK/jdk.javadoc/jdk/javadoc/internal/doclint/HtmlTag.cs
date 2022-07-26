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

namespace Dova.JDK.jdk.javadoc.@internal.doclint;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public")]
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
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "A", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABBR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACRONYM", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ADDRESS", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARTICLE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASIDE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "B", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BDI", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BIG", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCKQUOTE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BODY", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CAPTION", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CENTER", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CITE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CODE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLGROUP", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DD", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DFN", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIV", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EM", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FONT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOOTER", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIGURE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIGCAPTION", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRAME", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRAMESET", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H1", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H2", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H3", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H4", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H5", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "H6", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEAD", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEADER", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTML", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "I", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IFRAME", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMG", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INS", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "KBD", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LI", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINK", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAIN", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MARK", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MENU", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "META", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAV", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOFRAMES", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOSCRIPT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "P", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "Q", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "S", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SAMP", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCRIPT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECTION", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SMALL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPAN", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRIKE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRONG", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STYLE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUB", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUP", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TBODY", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TD", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEMPLATE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TFOOT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TH", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THEAD", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TIME", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TITLE", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TT", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "U", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UL", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WBR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VAR", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elemKind", "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "blockType", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endKind", "Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "index", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;Ljava/util/Set;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$ElemKind;Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;Ljava/util/Set;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$ElemKind;Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "get", "(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "attrs", "(Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "acceptsText", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Ljdk/javadoc/internal/doclint/HtmlTag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttr", "(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttrKind", "(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag A_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag ABBR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag ACRONYM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag ADDRESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag ARTICLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag ASIDE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag B_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag BDI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag BIG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag BLOCKQUOTE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag BODY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag BR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag CAPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag CENTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag CITE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag CODE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag COL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag COLGROUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DEL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DFN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DIV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag DT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag EM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FONT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FOOTER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FIGURE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FIGCAPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag FRAMESET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H3_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H4_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H5_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag H6_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag HEAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag HEADER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag HR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag HTML_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag I_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag IFRAME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag IMG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag INS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag KBD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag LI_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag LINK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag MAIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag MARK_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag MENU_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag META_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag NAV_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag NOFRAMES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag NOSCRIPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag OL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag P_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag PRE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag Q_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag S_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SAMP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SCRIPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SECTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SMALL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SPAN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag STRIKE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag STRONG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag STYLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SUB_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag SUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TBODY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TEMPLATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TFOOT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag THEAD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TITLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag TT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag U_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag UL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag WBR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag VAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind elemKind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[85]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType blockType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[86]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind endKind_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[87]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set flags_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[88]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map attrs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[89]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map index_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag;", "private static final")]
	public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag> VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlTag(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;Ljava/util/Set;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V", "private transient")]
	public HtmlTag(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType arg2, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind arg3, Dova.JDK.java.util.Set arg4, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V", "private transient")]
	public HtmlTag(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType arg2, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind arg3, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap> arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$ElemKind;Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;Ljava/util/Set;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V", "private transient")]
	public HtmlTag(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind arg2, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType arg3, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind arg4, Dova.JDK.java.util.Set arg5, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap> arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;ILjdk/javadoc/internal/doclint/HtmlTag$ElemKind;Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;[Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;)V", "private transient")]
	public HtmlTag(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind arg2, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType arg3, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind arg4, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag get(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag;", "public static")]
	public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag> values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag valueOf(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;", "private static transient")]
	public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap attrs(Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind arg0, JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrMap>(ret);
	}

	[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag;", "private static")]
	public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag> _values()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getText()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool acceptsText()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/HtmlTag;)Z", "public")]
	public bool accepts(Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr getAttr(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind getAttrKind(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static final")]
	public partial class ElemKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElemKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OK", "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID", "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBSOLETE", "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTML4", "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind INVALID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind OBSOLETE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind HTML4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElemKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ElemKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$ElemKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.ElemKind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
	public partial class BlockType
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BlockType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INLINE", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LIST_ITEM", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_ITEM", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OTHER", "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType BLOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType INLINE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType LIST_ITEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType TABLE_ITEM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType OTHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BlockType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public BlockType(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$BlockType;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.BlockType>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static final")]
	public partial class EndKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static EndKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NONE", "Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPTIONAL", "Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REQUIRED", "Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind NONE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind OPTIONAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind REQUIRED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public EndKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public EndKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$EndKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.EndKind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;", "private static")]
	public partial class AttrMap
		: Dova.JDK.java.util.EnumMap
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttrMap()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttrMap(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public AttrMap() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$AttrMap;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
	public partial class Attr
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Attr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ABBR", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALIGN", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALINK", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_ACTIVEDESCENDANT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_CONTROLS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_DESCRIBEDBY", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_EXPANDED", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_LABEL", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_LABELLEDBY", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_LEVEL", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_MULTISELECTABLE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_OWNS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_POSINSET", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_SETSIZE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_READONLY", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_REQUIRED", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_SELECTED", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARIA_SORT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AXIS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BACKGROUND", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BGCOLOR", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BORDER", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CELLSPACING", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CELLPADDING", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAR", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHAROFF", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CHARSET", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CITE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLEAR", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLOR", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COLSPAN", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPACT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COORDS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CROSSORIGIN", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DATETIME", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FACE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRAME", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FRAMEBORDER", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEADERS", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HEIGHT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HREF", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HSPACE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ID", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LINK", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LONGDESC", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MARGINHEIGHT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MARGINWIDTH", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAME", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOSHADE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOWRAP", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROFILE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REV", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REVERSED", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROLE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ROWSPAN", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RULES", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCHEME", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCOPE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCROLLING", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SHAPE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SIZE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SPACE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SRC", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "START", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STYLE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUMMARY", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TARGET", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TEXT", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALIGN", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VERSION", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VLINK", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VSPACE", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WIDTH", "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "index", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ABBR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ALIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ALINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ALT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_ACTIVEDESCENDANT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_CONTROLS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_DESCRIBEDBY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_EXPANDED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_LABEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_LABELLEDBY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_LEVEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_MULTISELECTABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_OWNS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_POSINSET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_SETSIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_READONLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_REQUIRED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_SELECTED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ARIA_SORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr AXIS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr BACKGROUND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr BGCOLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr BORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CELLSPACING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CELLPADDING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CHAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CHAROFF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CHARSET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CITE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CLEAR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr COLOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr COLSPAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr COMPACT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr COORDS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr CROSSORIGIN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr DATETIME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr FACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr FRAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr FRAMEBORDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr HEADERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr HEIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr HREF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr HSPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr LINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr LONGDESC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr MARGINHEIGHT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr MARGINWIDTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr NOSHADE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr NOWRAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr PROFILE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr REV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr REVERSED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ROLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr ROWSPAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr RULES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SCHEME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SCOPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SCROLLING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SHAPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SIZE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SRC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr START_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr STYLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr SUMMARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr TARGET_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr TEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr VALIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr VALUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr VERSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr VLINK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr VSPACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr WIDTH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "static final")]
		public static Dova.JDK.java.util.Map index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Attr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Attr(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$Attr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$Attr;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Attr>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getText()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static final")]
	public partial class AttrKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AttrKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OK", "Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVALID", "Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBSOLETE", "Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HTML4", "Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind OK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind INVALID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind OBSOLETE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind HTML4_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AttrKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public AttrKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$AttrKind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.AttrKind>>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static final")]
	public partial class Flag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Flag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPTS_BLOCK", "Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ACCEPTS_INLINE", "Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPECT_CONTENT", "Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_NEST", "Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag ACCEPTS_BLOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag ACCEPTS_INLINE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag EXPECT_CONTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag NO_NEST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Flag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Flag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/HtmlTag$Flag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/HtmlTag$Flag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag.Flag>>(ret);
		}
	}
}
