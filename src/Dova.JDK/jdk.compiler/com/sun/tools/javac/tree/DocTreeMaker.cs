/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:22)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.tree;

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocTreeMaker;", "public")]
public partial class DocTreeMaker
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.util.DocTreeFactory
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocTreeMaker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DocTreeMaker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "treeMakerKey", "Lcom/sun/tools/javac/util/Context$Key;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "sentenceBreakTags", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "pos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "trees", "Lcom/sun/tools/javac/api/JavacTrees;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "referenceParser", "Lcom/sun/tools/javac/parser/ReferenceParser;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocTreeMaker", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "cast", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "at_0", "(I)Lcom/sun/source/util/DocTreeFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "at_1", "(I)Lcom/sun/tools/javac/tree/DocTreeMaker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/tree/DocTreeMaker;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "skipWhiteSpace", "(Ljava/lang/String;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSentenceBreak", "(Ljava/lang/String;Lcom/sun/source/doctree/DocTree;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newTextTree_0", "(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newTextTree_1", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCText;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "defaultSentenceBreak", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReturnTree_0", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReturn;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReturnTree_1", "(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReturnTree_0", "(ZLjava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReturn;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReturnTree_1", "(ZLjava/util/List;)Lcom/sun/source/doctree/ReturnTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newProvidesTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCProvides;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newProvidesTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ProvidesTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newParamTree_0", "(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCParam;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newParamTree_1", "(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLiteralTree_0", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCLiteral;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLiteralTree_1", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLinkPlainTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLinkPlainTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLinkTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCLink;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newLinkTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newInheritDocTree_0", "()Lcom/sun/source/doctree/InheritDocTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newInheritDocTree_1", "()Lcom/sun/tools/javac/tree/DCTree$DCInheritDoc;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newIndexTree_0", "(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCIndex;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newIndexTree_1", "(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/source/doctree/IndexTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newIdentifierTree_0", "(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newIdentifierTree_1", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/IdentifierTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUsesTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUses;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUsesTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/UsesTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUnknownInlineTagTree_0", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUnknownInlineTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUnknownInlineTagTree_1", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownInlineTagTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUnknownBlockTagTree_0", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUnknownBlockTag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newUnknownBlockTagTree_1", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownBlockTagTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newThrowsTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCThrows;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newThrowsTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSystemPropertyTree_0", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/SystemPropertyTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSystemPropertyTree_1", "(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCSystemProperty;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSummaryTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/SummaryTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSummaryTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSummary;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newStartElementTree_0", "(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/source/doctree/StartElementTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newStartElementTree_1", "(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/tools/javac/tree/DCTree$DCStartElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSnippetTree_0", "(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/SnippetTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSnippetTree_1", "(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCSnippet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSinceTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/SinceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSinceTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSince;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialFieldTree_0", "(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerialField;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialFieldTree_1", "(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/SerialFieldTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialDataTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/SerialDataTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialDataTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerialData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialTree_0", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerial;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSerialTree_1", "(Ljava/util/List;)Lcom/sun/source/doctree/SerialTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSeeTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/SeeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newSeeTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSee;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReferenceTree", "(Ljava/lang/String;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReferenceTree_0", "(Ljava/lang/String;)Lcom/sun/source/doctree/ReferenceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newReferenceTree_1", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newHiddenTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/HiddenTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newHiddenTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCHidden;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newExceptionTree_0", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newExceptionTree_1", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCThrows;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newErroneousTree_0", "(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newErroneousTree_1", "(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/source/doctree/ErroneousTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEntityTree_0", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EntityTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEntityTree_1", "(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCEntity;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEndElementTree_0", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EndElementTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newEndElementTree_1", "(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCEndElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocTypeTree_0", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCDocType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocTypeTree_1", "(Ljava/lang/String;)Lcom/sun/source/doctree/DocTypeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocRootTree_0", "()Lcom/sun/source/doctree/DocRootTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocRootTree_1", "()Lcom/sun/tools/javac/tree/DCTree$DCDocRoot;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDeprecatedTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/DeprecatedTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDeprecatedTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDeprecated;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newCommentTree_0", "(Ljava/lang/String;)Lcom/sun/source/doctree/CommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newCommentTree_1", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "splitBody", "(Ljava/util/Collection;)Lcom/sun/tools/javac/util/Pair;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocCommentTree", "(Lcom/sun/tools/javac/parser/Tokens$Comment;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocCommentTree_0", "(Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocCommentTree_1", "(Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocCommentTree_0", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newDocCommentTree_1", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newCodeTree_0", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newCodeTree_1", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCLiteral;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newAuthorTree_0", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCAuthor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newAuthorTree_1", "(Ljava/util/List;)Lcom/sun/source/doctree/AuthorTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newAttributeTree_0", "(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCAttribute;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newAttributeTree_1", "(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/source/doctree/AttributeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSentenceBreak", "(Lcom/sun/source/doctree/DocTree;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSentenceBreak", "(Ljavax/lang/model/element/Name;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isTextTree", "(Lcom/sun/source/doctree/DocTree;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newVersionTree_0", "(Ljava/util/List;)Lcom/sun/source/doctree/VersionTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newVersionTree_1", "(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCVersion;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newValueTree_0", "(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/source/doctree/ValueTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "newValueTree_1", "(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/tools/javac/tree/DCTree$DCValue;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFirstSentence", "(Ljava/util/List;)Ljava/util/List;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/util/Context$Key;", "protected static final")]
	public static Dova.JDK.com.sun.tools.javac.util.Context.Key treeMakerKey_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Context.Key>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "final")]
	public Dova.JDK.java.util.Set sentenceBreakTags_Property
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

	[JniSignatureAttribute("I", "public")]
	public int pos_Property
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

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/JavacTrees;", "private final")]
	public Dova.JDK.com.sun.tools.javac.api.JavacTrees trees_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.JavacTrees>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ReferenceParser;", "private final")]
	public Dova.JDK.com.sun.tools.javac.parser.ReferenceParser referenceParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ReferenceParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocTreeMaker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public DocTreeMaker(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DocTreeMaker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List cast(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/source/util/DocTreeFactory;", "public volatile")]
	public Dova.JDK.com.sun.source.util.DocTreeFactory at_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreeFactory>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/DocTreeMaker;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker at_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/tree/DocTreeMaker;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DocTreeMaker>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;I)I", "private")]
	public int skipWhiteSpace(Dova.JDK.java.lang.String arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/source/doctree/DocTree;)I", "private")]
	public int getSentenceBreak(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.TextTree newTextTree_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCText;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText newTextTree_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private")]
	public int defaultSentenceBreak(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReturn;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReturn newReturnTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReturn>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ReturnTree newReturnTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReturnTree>(ret);
	}

	[JniSignatureAttribute("(ZLjava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReturn;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReturn newReturnTree_0(bool arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReturn>(ret);
	}

	[JniSignatureAttribute("(ZLjava/util/List;)Lcom/sun/source/doctree/ReturnTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ReturnTree newReturnTree_1(bool arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReturnTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCProvides;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCProvides newProvidesTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCProvides>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ProvidesTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ProvidesTree newProvidesTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ProvidesTree>(ret);
	}

	[JniSignatureAttribute("(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCParam;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCParam newParamTree_0(bool arg0, Dova.JDK.com.sun.source.doctree.IdentifierTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCParam>(ret);
	}

	[JniSignatureAttribute("(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ParamTree newParamTree_1(bool arg0, Dova.JDK.com.sun.source.doctree.IdentifierTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ParamTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCLiteral;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLiteral newLiteralTree_0(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLiteral>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.LiteralTree newLiteralTree_1(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LiteralTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.LinkTree newLinkPlainTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LinkTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCLink;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLink newLinkPlainTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLink>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCLink;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLink newLinkTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLink>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.LinkTree newLinkTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LinkTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/InheritDocTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.InheritDocTree newInheritDocTree_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.InheritDocTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCInheritDoc;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInheritDoc newInheritDocTree_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInheritDoc>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCIndex;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIndex newIndexTree_0(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIndex>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/source/doctree/IndexTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.IndexTree newIndexTree_1(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IndexTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier newIdentifierTree_0(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/IdentifierTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.IdentifierTree newIdentifierTree_1(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IdentifierTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUses;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUses newUsesTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUses>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/UsesTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.UsesTree newUsesTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UsesTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUnknownInlineTag;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUnknownInlineTag newUnknownInlineTagTree_0(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUnknownInlineTag>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownInlineTagTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree newUnknownInlineTagTree_1(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCUnknownBlockTag;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUnknownBlockTag newUnknownBlockTagTree_0(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCUnknownBlockTag>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownBlockTagTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree newUnknownBlockTagTree_1(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCThrows;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCThrows newThrowsTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCThrows>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ThrowsTree newThrowsTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ThrowsTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/SystemPropertyTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SystemPropertyTree newSystemPropertyTree_0(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SystemPropertyTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCSystemProperty;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSystemProperty newSystemPropertyTree_1(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSystemProperty>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SummaryTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SummaryTree newSummaryTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SummaryTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSummary;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSummary newSummaryTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSummary>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/source/doctree/StartElementTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.StartElementTree newStartElementTree_0(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.StartElementTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/tools/javac/tree/DCTree$DCStartElement;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCStartElement newStartElementTree_1(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCStartElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/SnippetTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SnippetTree newSnippetTree_0(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.source.doctree.TextTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SnippetTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCSnippet;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSnippet newSnippetTree_1(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.source.doctree.TextTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSnippet>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SinceTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SinceTree newSinceTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SinceTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSince;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSince newSinceTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSince>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerialField;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerialField newSerialFieldTree_0(Dova.JDK.com.sun.source.doctree.IdentifierTree arg0, Dova.JDK.com.sun.source.doctree.ReferenceTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerialField>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/SerialFieldTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SerialFieldTree newSerialFieldTree_1(Dova.JDK.com.sun.source.doctree.IdentifierTree arg0, Dova.JDK.com.sun.source.doctree.ReferenceTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialFieldTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SerialDataTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SerialDataTree newSerialDataTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialDataTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerialData;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerialData newSerialDataTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerialData>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSerial;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerial newSerialTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSerial>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SerialTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SerialTree newSerialTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SeeTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.SeeTree newSeeTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SeeTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCSee;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSee newSeeTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCSee>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference newReferenceTree(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.javax.lang.model.element.Name arg3, Dova.JDK.java.util.List arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/ReferenceTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ReferenceTree newReferenceTree_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference newReferenceTree_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/HiddenTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.HiddenTree newHiddenTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.HiddenTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCHidden;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCHidden newHiddenTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCHidden>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ThrowsTree newExceptionTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ThrowsTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCThrows;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCThrows newExceptionTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCThrows>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous newErroneousTree_0(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.Diagnostic arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/source/doctree/ErroneousTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ErroneousTree newErroneousTree_1(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.Diagnostic arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ErroneousTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EntityTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.EntityTree newEntityTree_0(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.EntityTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCEntity;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEntity newEntityTree_1(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEntity>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EndElementTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.EndElementTree newEndElementTree_0(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.EndElementTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/tools/javac/tree/DCTree$DCEndElement;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndElement newEndElementTree_1(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCDocType;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocType newDocTypeTree_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/DocTypeTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.DocTypeTree newDocTypeTree_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTypeTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocRootTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.DocRootTree newDocRootTree_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocRootTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCDocRoot;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocRoot newDocRootTree_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocRoot>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/DeprecatedTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.DeprecatedTree newDeprecatedTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DeprecatedTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDeprecated;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDeprecated newDeprecatedTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDeprecated>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/CommentTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.CommentTree newCommentTree_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.CommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/DCTree$DCComment;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCComment newCommentTree_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCComment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Lcom/sun/tools/javac/util/Pair;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Pair splitBody(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Pair>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$Comment;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment newDocCommentTree(Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment newDocCommentTree_0(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree newDocCommentTree_1(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment newDocCommentTree_0(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree newDocCommentTree_1(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.LiteralTree newCodeTree_0(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LiteralTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/tools/javac/tree/DCTree$DCLiteral;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLiteral newCodeTree_1(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCLiteral>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCAuthor;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCAuthor newAuthorTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCAuthor>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/AuthorTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.AuthorTree newAuthorTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AuthorTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCAttribute;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCAttribute newAttributeTree_0(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCAttribute>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/source/doctree/AttributeTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.AttributeTree newAttributeTree_1(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AttributeTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Z)Z", "private")]
	public bool isSentenceBreak(Dova.JDK.com.sun.source.doctree.DocTree arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[88], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Z", "private")]
	public bool isSentenceBreak(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Z", "private")]
	public bool isTextTree(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/VersionTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.VersionTree newVersionTree_0(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.VersionTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/tools/javac/tree/DCTree$DCVersion;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCVersion newVersionTree_1(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCVersion>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/source/doctree/ValueTree;", "public volatile")]
	public Dova.JDK.com.sun.source.doctree.ValueTree newValueTree_0(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ValueTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/tools/javac/tree/DCTree$DCValue;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCValue newValueTree_1(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[94], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCValue>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getFirstSentence(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
