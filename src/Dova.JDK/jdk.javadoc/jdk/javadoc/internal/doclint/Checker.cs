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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker;", "public")]
public partial class Checker
	: Dova.JDK.com.sun.source.util.DocTreePathScanner
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Checker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/Checker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "env", "Ljdk/javadoc/internal/doclint/Env;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foundParams", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foundThrows", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foundAnchors", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foundInheritDoc", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "foundReturn", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasNonWhitespaceText", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tagStack", "Ljava/util/Deque;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currHeadingTag", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implicitHeadingRank", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inIndex", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inLink", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inSummary", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "validId", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "validNumber", "Ljava/util/regex/Pattern;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "docRoot", "Ljava/util/regex/Pattern;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclint/Env;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/source/util/TreePath;Ljava/lang/StringBuilder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "(Lcom/sun/source/util/TreePath;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSynthetic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/util/TreePath;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isCheckedException", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkURI", "(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDefaultConstructor", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportReference", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAnonymous", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkThrowsDocumented", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkTagStack", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warnIfEmpty", "(Ljdk/javadoc/internal/doclint/Checker$TagStackItem;Lcom/sun/source/doctree/DocTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warnIfEmpty", "(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasNonWhitespace", "(Lcom/sun/source/doctree/TextTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAllowsText", "(Lcom/sun/source/doctree/DocTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "markEnclosingTag", "(Ljdk/javadoc/internal/doclint/Checker$Flag;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkStructure", "(Lcom/sun/source/doctree/StartElementTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkHeading", "(Lcom/sun/source/doctree/StartElementTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfClosingAllowed", "(Ljdk/javadoc/internal/doclint/HtmlTag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHeadingRank", "(Ljdk/javadoc/internal/doclint/HtmlTag;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttrValue", "(Lcom/sun/source/doctree/AttributeTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingPackageOrClass", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkThrowsDeclared", "(Lcom/sun/source/doctree/ReferenceTree;Ljavax/lang/model/type/TypeMirror;Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkUnknownTag", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isConstant", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reportMissing", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isThrowable", "(Ljavax/lang/model/type/TypeMirror;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkParamsDocumented", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAnchor", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEndElement", "(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEndElement", "(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEntity", "(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEntity", "(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocComment", "(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocComment", "(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitText", "(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitText", "(Lcom/sun/source/doctree/TextTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParam", "(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParam", "(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrows", "(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrows", "(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStartElement", "(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStartElement", "(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAuthor", "(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAuthor", "(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocRoot", "(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocRoot", "(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndex", "(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndex", "(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInheritDoc", "(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInheritDoc", "(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialData", "(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialData", "(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSince", "(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSince", "(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSummary", "(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSummary", "(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSystemProperty", "(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSystemProperty", "(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownBlockTag", "(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownBlockTag", "(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownInlineTag", "(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownInlineTag", "(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVersion", "(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVersion", "(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNormalClass", "(Lcom/sun/source/util/TreePath;)Z"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Env;", "final")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.Env env_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Env>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set foundParams_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set foundThrows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map foundAnchors_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool foundInheritDoc_Property
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

	[JniSignatureAttribute("Z", "")]
	public bool foundReturn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("Z", "")]
	public bool hasNonWhitespaceText_Property
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

	[JniSignatureAttribute("Ljava/util/Deque;", "private final")]
	public Dova.JDK.java.util.Deque tagStack_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Deque>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag currHeadingTag_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int implicitHeadingRank_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[9]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[9], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[10]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[10], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inLink_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[11]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[11], value);
		}
	}

	[JniSignatureAttribute("Z", "private")]
	public bool inSummary_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern validId_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern validNumber_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
	public static Dova.JDK.java.util.regex.Pattern docRoot_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Checker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/Env;)V", "")]
	public Checker(Dova.JDK.jdk.javadoc.@internal.doclint.Env arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/Checker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Ljava/lang/StringBuilder;)V", "")]
	public void toString(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.java.lang.StringBuilder arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String toString(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isSynthetic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/util/TreePath;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void scan(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.com.sun.source.util.TreePath arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAttribute(Dova.JDK.com.sun.source.doctree.AttributeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitAttribute(Dova.JDK.com.sun.source.doctree.AttributeTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "private")]
	public bool isCheckedException(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/String;)V", "private")]
	public void checkURI(Dova.JDK.com.sun.source.doctree.AttributeTree arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isDefaultConstructor()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private transient")]
	public void reportReference(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool isAnonymous()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void checkThrowsDocumented(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkTagStack()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/Checker$TagStackItem;Lcom/sun/source/doctree/DocTree;)V", "")]
	public void warnIfEmpty(Dova.JDK.jdk.javadoc.@internal.doclint.Checker.TagStackItem arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)V", "")]
	public void warnIfEmpty(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.util.List arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Z", "")]
	public bool hasNonWhitespace(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)V", "")]
	public void checkAllowsText(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/Checker$Flag;)V", "")]
	public void markEnclosingTag(Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V", "private")]
	public void checkStructure(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V", "private")]
	public void checkHeading(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/HtmlTag;)Z", "private")]
	public bool isSelfClosingAllowed(Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclint/HtmlTag;)I", "private")]
	public int getHeadingRank(Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "private")]
	public Dova.JDK.com.sun.source.doctree.DocTree.Kind getParentKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String getAttrValue(Dova.JDK.com.sun.source.doctree.AttributeTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/Element;", "private")]
	public Dova.JDK.javax.lang.model.element.Element getEnclosingPackageOrClass(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljavax/lang/model/type/TypeMirror;Ljava/util/List;)V", "private")]
	public void checkThrowsDeclared(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1, Dova.JDK.java.util.List arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/String;)V", "private")]
	public void checkUnknownTag(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "private")]
	public bool isConstant(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "private transient")]
	public void reportMissing(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Z", "private")]
	public bool isThrowable(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
	public void checkParamsDocumented(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "private")]
	public bool checkAnchor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitReturn(Dova.JDK.com.sun.source.doctree.ReturnTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitReturn(Dova.JDK.com.sun.source.doctree.ReturnTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitEndElement(Dova.JDK.com.sun.source.doctree.EndElementTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEndElement(Dova.JDK.com.sun.source.doctree.EndElementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitEntity(Dova.JDK.com.sun.source.doctree.EntityTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEntity(Dova.JDK.com.sun.source.doctree.EntityTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDocComment(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDocComment(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitText(Dova.JDK.com.sun.source.doctree.TextTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitText(Dova.JDK.com.sun.source.doctree.TextTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitParam(Dova.JDK.com.sun.source.doctree.ParamTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitParam(Dova.JDK.com.sun.source.doctree.ParamTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitThrows(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitThrows(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLiteral(Dova.JDK.com.sun.source.doctree.LiteralTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLiteral(Dova.JDK.com.sun.source.doctree.LiteralTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitStartElement(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitStartElement(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAuthor(Dova.JDK.com.sun.source.doctree.AuthorTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitAuthor(Dova.JDK.com.sun.source.doctree.AuthorTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDocRoot(Dova.JDK.com.sun.source.doctree.DocRootTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDocRoot(Dova.JDK.com.sun.source.doctree.DocRootTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitErroneous(Dova.JDK.com.sun.source.doctree.ErroneousTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitErroneous(Dova.JDK.com.sun.source.doctree.ErroneousTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitIndex(Dova.JDK.com.sun.source.doctree.IndexTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIndex(Dova.JDK.com.sun.source.doctree.IndexTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInheritDoc(Dova.JDK.com.sun.source.doctree.InheritDocTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInheritDoc(Dova.JDK.com.sun.source.doctree.InheritDocTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitReference(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitReference(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSerialData(Dova.JDK.com.sun.source.doctree.SerialDataTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSerialData(Dova.JDK.com.sun.source.doctree.SerialDataTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSince(Dova.JDK.com.sun.source.doctree.SinceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSince(Dova.JDK.com.sun.source.doctree.SinceTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSummary(Dova.JDK.com.sun.source.doctree.SummaryTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSummary(Dova.JDK.com.sun.source.doctree.SummaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSystemProperty(Dova.JDK.com.sun.source.doctree.SystemPropertyTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSystemProperty(Dova.JDK.com.sun.source.doctree.SystemPropertyTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnknownBlockTag(Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUnknownBlockTag(Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnknownInlineTag(Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUnknownInlineTag(Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitVersion(Dova.JDK.com.sun.source.doctree.VersionTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitVersion(Dova.JDK.com.sun.source.doctree.VersionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Z", "private")]
	public bool isNormalClass(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[86], arg0);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$TagStackItem;", "static")]
	public partial class TagStackItem
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TagStackItem()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/Checker$TagStackItem;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tree", "Lcom/sun/source/doctree/DocTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Ljdk/javadoc/internal/doclint/HtmlTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree;", "final")]
		public Dova.JDK.com.sun.source.doctree.DocTree tree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/HtmlTag;", "final")]
		public Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set attrs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TagStackItem(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclint/HtmlTag;)V", "")]
		public TagStackItem(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.jdk.javadoc.@internal.doclint.HtmlTag arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/Checker$TagStackItem;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclint/Checker$Flag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_HAS_CAPTION", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TABLE_IS_PRESENTATION", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HAS_ELEMENT", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HAS_HEADING", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HAS_INLINE_TAG", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HAS_TEXT", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REPORTED_BAD_INLINE", "Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/Checker$Flag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclint/Checker$Flag;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag TABLE_HAS_CAPTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag TABLE_IS_PRESENTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag HAS_ELEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag HAS_HEADING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag HAS_INLINE_TAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag HAS_TEXT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag REPORTED_BAD_INLINE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclint/Checker$Flag;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
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

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclint/Checker$Flag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclint/Checker$Flag;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclint/Checker$Flag;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclint.Checker.Flag>>(ret);
		}
	}
}
