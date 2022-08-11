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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/DocTreeFactory;", "public abstract interface")]
public partial interface DocTreeFactory
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocTreeFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/DocTreeFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "at", "(I)Lcom/sun/source/util/DocTreeFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSerialTree", "(Ljava/util/List;)Lcom/sun/source/doctree/SerialTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSerialDataTree", "(Ljava/util/List;)Lcom/sun/source/doctree/SerialDataTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSerialFieldTree", "(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/SerialFieldTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSinceTree", "(Ljava/util/List;)Lcom/sun/source/doctree/SinceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newAuthorTree", "(Ljava/util/List;)Lcom/sun/source/doctree/AuthorTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDocTypeTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/DocTypeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEntityTree", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EntityTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newErroneousTree", "(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/source/doctree/ErroneousTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newExceptionTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newHiddenTree", "(Ljava/util/List;)Lcom/sun/source/doctree/HiddenTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newIndexTree", "(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/source/doctree/IndexTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCommentTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/CommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDeprecatedTree", "(Ljava/util/List;)Lcom/sun/source/doctree/DeprecatedTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDocRootTree", "()Lcom/sun/source/doctree/DocRootTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstSentence", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSnippetTree", "(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/SnippetTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSummaryTree", "(Ljava/util/List;)Lcom/sun/source/doctree/SummaryTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSystemPropertyTree", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/SystemPropertyTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newUnknownInlineTagTree", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownInlineTagTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newUsesTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/UsesTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInheritDocTree", "()Lcom/sun/source/doctree/InheritDocTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newLinkPlainTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newLiteralTree", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newProvidesTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ProvidesTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newValueTree", "(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/source/doctree/ValueTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newVersionTree", "(Ljava/util/List;)Lcom/sun/source/doctree/VersionTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newUnknownBlockTagTree", "(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownBlockTagTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newCodeTree", "(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newTextTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newIdentifierTree", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/IdentifierTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newParamTree", "(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReturnTree", "(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReturnTree", "(ZLjava/util/List;)Lcom/sun/source/doctree/ReturnTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newReferenceTree", "(Ljava/lang/String;)Lcom/sun/source/doctree/ReferenceTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newSeeTree", "(Ljava/util/List;)Lcom/sun/source/doctree/SeeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newThrowsTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newLinkTree", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newStartElementTree", "(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/source/doctree/StartElementTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newEndElementTree", "(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EndElementTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newAttributeTree", "(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/source/doctree/AttributeTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDocCommentTree", "(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDocCommentTree", "(Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;"));
	}

	[JniSignatureAttribute("(I)Lcom/sun/source/util/DocTreeFactory;", "public abstract")]
	Dova.JDK.com.sun.source.util.DocTreeFactory at(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreeFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SerialTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SerialTree newSerialTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SerialDataTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SerialDataTree newSerialDataTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialDataTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IdentifierTree;Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/SerialFieldTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SerialFieldTree newSerialFieldTree(Dova.JDK.com.sun.source.doctree.IdentifierTree arg0, Dova.JDK.com.sun.source.doctree.ReferenceTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SerialFieldTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SinceTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SinceTree newSinceTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SinceTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/AuthorTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.AuthorTree newAuthorTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AuthorTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/DocTypeTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.DocTypeTree newDocTypeTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTypeTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EntityTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.EntityTree newEntityTree(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.EntityTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/Diagnostic;)Lcom/sun/source/doctree/ErroneousTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ErroneousTree newErroneousTree(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.Diagnostic arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ErroneousTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ThrowsTree newExceptionTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ThrowsTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/HiddenTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.HiddenTree newHiddenTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.HiddenTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/util/List;)Lcom/sun/source/doctree/IndexTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.IndexTree newIndexTree(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IndexTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/CommentTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.CommentTree newCommentTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.CommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/DeprecatedTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.DeprecatedTree newDeprecatedTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DeprecatedTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocRootTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.DocRootTree newDocRootTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocRootTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getFirstSentence(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/SnippetTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SnippetTree newSnippetTree(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.source.doctree.TextTree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SnippetTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SummaryTree;", "public")]
	Dova.JDK.com.sun.source.doctree.SummaryTree newSummaryTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SummaryTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/SystemPropertyTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SystemPropertyTree newSystemPropertyTree(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SystemPropertyTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownInlineTagTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree newUnknownInlineTagTree(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/UsesTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.UsesTree newUsesTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UsesTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/InheritDocTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.InheritDocTree newInheritDocTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.InheritDocTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.LinkTree newLinkPlainTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LinkTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.LiteralTree newLiteralTree(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LiteralTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ProvidesTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ProvidesTree newProvidesTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ProvidesTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;)Lcom/sun/source/doctree/ValueTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ValueTree newValueTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ValueTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/VersionTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.VersionTree newVersionTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.VersionTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)Lcom/sun/source/doctree/UnknownBlockTagTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree newUnknownBlockTagTree(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;)Lcom/sun/source/doctree/LiteralTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.LiteralTree newCodeTree(Dova.JDK.com.sun.source.doctree.TextTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LiteralTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/TextTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.TextTree newTextTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/IdentifierTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.IdentifierTree newIdentifierTree(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IdentifierTree>(ret);
	}

	[JniSignatureAttribute("(ZLcom/sun/source/doctree/IdentifierTree;Ljava/util/List;)Lcom/sun/source/doctree/ParamTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ParamTree newParamTree(bool arg0, Dova.JDK.com.sun.source.doctree.IdentifierTree arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ParamTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/ReturnTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ReturnTree newReturnTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReturnTree>(ret);
	}

	[JniSignatureAttribute("(ZLjava/util/List;)Lcom/sun/source/doctree/ReturnTree;", "public")]
	Dova.JDK.com.sun.source.doctree.ReturnTree newReturnTree(bool arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReturnTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/doctree/ReferenceTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ReferenceTree newReferenceTree(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Lcom/sun/source/doctree/SeeTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.SeeTree newSeeTree(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.SeeTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/ThrowsTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.ThrowsTree newThrowsTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ThrowsTree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/util/List;)Lcom/sun/source/doctree/LinkTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.LinkTree newLinkTree(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.LinkTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;Z)Lcom/sun/source/doctree/StartElementTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.StartElementTree newStartElementTree(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.StartElementTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)Lcom/sun/source/doctree/EndElementTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.EndElementTree newEndElementTree(Dova.JDK.javax.lang.model.element.Name arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.EndElementTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)Lcom/sun/source/doctree/AttributeTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.AttributeTree newAttributeTree(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind arg1, Dova.JDK.java.util.List arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AttributeTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.DocCommentTree newDocCommentTree(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/util/List;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	Dova.JDK.com.sun.source.doctree.DocCommentTree newDocCommentTree(Dova.JDK.java.util.List arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}
}
