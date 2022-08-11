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

namespace Dova.JDK.com.sun.tools.javac.tree;

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocPretty;", "public")]
public partial class DocPretty
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.doctree.DocTreeVisitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocPretty()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DocPretty;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "out", "Ljava/io/Writer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineSep", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/Writer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "println", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/util/List;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Lcom/sun/source/doctree/DocTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "print", "(Ljava/util/List;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAttribute", "(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printTagName", "(Lcom/sun/source/doctree/DocTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOther", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOther", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStartElement", "(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitStartElement", "(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEndElement", "(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEndElement", "(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAuthor", "(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAuthor", "(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocRoot", "(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocRoot", "(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndex", "(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndex", "(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInheritDoc", "(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInheritDoc", "(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLink", "(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParam", "(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParam", "(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialData", "(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialData", "(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerialField", "(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSince", "(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSince", "(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSummary", "(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSummary", "(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSystemProperty", "(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSystemProperty", "(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownBlockTag", "(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownBlockTag", "(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownInlineTag", "(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnknownInlineTag", "(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVersion", "(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVersion", "(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrows", "(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrows", "(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitText", "(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitText", "(Lcom/sun/source/doctree/TextTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEntity", "(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitEntity", "(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocComment", "(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocComment", "(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitComment", "(Lcom/sun/source/doctree/CommentTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitComment", "(Lcom/sun/source/doctree/CommentTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocType", "(Lcom/sun/source/doctree/DocTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDocType", "(Lcom/sun/source/doctree/DocTypeTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitHidden", "(Lcom/sun/source/doctree/HiddenTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitHidden", "(Lcom/sun/source/doctree/HiddenTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSee", "(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSee", "(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerial", "(Lcom/sun/source/doctree/SerialTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSerial", "(Lcom/sun/source/doctree/SerialTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSnippet", "(Lcom/sun/source/doctree/SnippetTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSnippet", "(Lcom/sun/source/doctree/SnippetTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier", "(Lcom/sun/source/doctree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdentifier", "(Lcom/sun/source/doctree/IdentifierTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDeprecated", "(Lcom/sun/source/doctree/DeprecatedTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDeprecated", "(Lcom/sun/source/doctree/DeprecatedTree;Ljava/lang/Void;)Ljava/lang/Void;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitValue", "(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Void;"));
	}

	[JniSignatureAttribute("Ljava/io/Writer;", "final")]
	public Dova.JDK.java.io.Writer @out_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "final")]
	public Dova.JDK.java.lang.String lineSep_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocPretty(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/io/Writer;)V", "public")]
	public DocPretty(Dova.JDK.java.io.Writer arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DocPretty;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "protected")]
	public void println()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/util/List;)V", "public")]
	public void print(Dova.JDK.java.util.List arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "protected")]
	public void print(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)V", "public")]
	public void print(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/List;Ljava/lang/String;)V", "protected")]
	public void print(Dova.JDK.java.util.List arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitAttribute(Dova.JDK.com.sun.source.doctree.AttributeTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAttribute(Dova.JDK.com.sun.source.doctree.AttributeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)V", "protected")]
	public void printTagName(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitOther(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitOther(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitStartElement(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/StartElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitStartElement(Dova.JDK.com.sun.source.doctree.StartElementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitEndElement(Dova.JDK.com.sun.source.doctree.EndElementTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EndElementTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEndElement(Dova.JDK.com.sun.source.doctree.EndElementTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitAuthor(Dova.JDK.com.sun.source.doctree.AuthorTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AuthorTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitAuthor(Dova.JDK.com.sun.source.doctree.AuthorTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDocRoot(Dova.JDK.com.sun.source.doctree.DocRootTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocRootTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDocRoot(Dova.JDK.com.sun.source.doctree.DocRootTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIndex(Dova.JDK.com.sun.source.doctree.IndexTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IndexTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitIndex(Dova.JDK.com.sun.source.doctree.IndexTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitInheritDoc(Dova.JDK.com.sun.source.doctree.InheritDocTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/InheritDocTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitInheritDoc(Dova.JDK.com.sun.source.doctree.InheritDocTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LinkTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLink(Dova.JDK.com.sun.source.doctree.LinkTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitParam(Dova.JDK.com.sun.source.doctree.ParamTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ParamTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitParam(Dova.JDK.com.sun.source.doctree.ParamTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSerialData(Dova.JDK.com.sun.source.doctree.SerialDataTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialDataTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSerialData(Dova.JDK.com.sun.source.doctree.SerialDataTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialFieldTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSerialField(Dova.JDK.com.sun.source.doctree.SerialFieldTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSince(Dova.JDK.com.sun.source.doctree.SinceTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SinceTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSince(Dova.JDK.com.sun.source.doctree.SinceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSummary(Dova.JDK.com.sun.source.doctree.SummaryTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SummaryTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSummary(Dova.JDK.com.sun.source.doctree.SummaryTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSystemProperty(Dova.JDK.com.sun.source.doctree.SystemPropertyTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SystemPropertyTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSystemProperty(Dova.JDK.com.sun.source.doctree.SystemPropertyTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUnknownBlockTag(Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownBlockTagTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnknownBlockTag(Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUnknownInlineTag(Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UnknownInlineTagTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUnknownInlineTag(Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitVersion(Dova.JDK.com.sun.source.doctree.VersionTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/VersionTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitVersion(Dova.JDK.com.sun.source.doctree.VersionTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitThrows(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ThrowsTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitThrows(Dova.JDK.com.sun.source.doctree.ThrowsTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitText(Dova.JDK.com.sun.source.doctree.TextTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/TextTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitText(Dova.JDK.com.sun.source.doctree.TextTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitEntity(Dova.JDK.com.sun.source.doctree.EntityTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitEntity(Dova.JDK.com.sun.source.doctree.EntityTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDocComment(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocCommentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDocComment(Dova.JDK.com.sun.source.doctree.DocCommentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/CommentTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitComment(Dova.JDK.com.sun.source.doctree.CommentTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/CommentTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitComment(Dova.JDK.com.sun.source.doctree.CommentTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDocType(Dova.JDK.com.sun.source.doctree.DocTypeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTypeTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDocType(Dova.JDK.com.sun.source.doctree.DocTypeTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/HiddenTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitHidden(Dova.JDK.com.sun.source.doctree.HiddenTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/HiddenTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitHidden(Dova.JDK.com.sun.source.doctree.HiddenTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSee(Dova.JDK.com.sun.source.doctree.SeeTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SeeTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSee(Dova.JDK.com.sun.source.doctree.SeeTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSerial(Dova.JDK.com.sun.source.doctree.SerialTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SerialTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSerial(Dova.JDK.com.sun.source.doctree.SerialTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SnippetTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitSnippet(Dova.JDK.com.sun.source.doctree.SnippetTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/SnippetTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitSnippet(Dova.JDK.com.sun.source.doctree.SnippetTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitReturn(Dova.JDK.com.sun.source.doctree.ReturnTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReturnTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitReturn(Dova.JDK.com.sun.source.doctree.ReturnTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitReference(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ReferenceTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitReference(Dova.JDK.com.sun.source.doctree.ReferenceTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitLiteral(Dova.JDK.com.sun.source.doctree.LiteralTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/LiteralTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitLiteral(Dova.JDK.com.sun.source.doctree.LiteralTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitErroneous(Dova.JDK.com.sun.source.doctree.ErroneousTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ErroneousTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitErroneous(Dova.JDK.com.sun.source.doctree.ErroneousTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ProvidesTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitProvides(Dova.JDK.com.sun.source.doctree.ProvidesTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/UsesTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitUses(Dova.JDK.com.sun.source.doctree.UsesTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IdentifierTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitIdentifier(Dova.JDK.com.sun.source.doctree.IdentifierTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/IdentifierTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitIdentifier(Dova.JDK.com.sun.source.doctree.IdentifierTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DeprecatedTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitDeprecated(Dova.JDK.com.sun.source.doctree.DeprecatedTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DeprecatedTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitDeprecated(Dova.JDK.com.sun.source.doctree.DeprecatedTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
	public Dova.JDK.java.lang.Object visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/ValueTree;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
	public Dova.JDK.java.lang.Void visitValue(Dova.JDK.com.sun.source.doctree.ValueTree arg0, Dova.JDK.java.lang.Void arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocPretty$UncheckedIOException;", "private static")]
	public partial class UncheckedIOException
		: Dova.JDK.java.lang.Error
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static UncheckedIOException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DocPretty$UncheckedIOException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/io/IOException;)V"));
		}

		[JniSignatureAttribute("J", "static final")]
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
		public UncheckedIOException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/io/IOException;)V", "")]
		public UncheckedIOException(Dova.JDK.java.io.IOException arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DocPretty$UncheckedIOException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
