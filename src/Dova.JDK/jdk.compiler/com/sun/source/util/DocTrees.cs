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

namespace Dova.JDK.com.sun.source.util;

[JniSignatureAttribute("Lcom/sun/source/util/DocTrees;", "public abstract")]
public partial class DocTrees
	: Dova.JDK.com.sun.source.util.Trees
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocTrees()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/DocTrees;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "DocTrees", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getType", "(Lcom/sun/source/util/DocTreePath;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/DocTrees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "instance", "(Ljavax/tools/JavaCompiler$CompilationTask;)Lcom/sun/source/util/DocTrees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElement", "(Lcom/sun/source/util/DocTreePath;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBreakIterator", "()Ljava/text/BreakIterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocCommentTree", "(Lcom/sun/source/util/TreePath;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocCommentTree", "(Ljavax/tools/FileObject;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocCommentTree", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocCommentTree", "(Ljavax/lang/model/element/Element;Ljava/lang/String;)Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocTreePath", "(Ljavax/tools/FileObject;Ljavax/lang/model/element/PackageElement;)Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFirstSentence", "(Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/tree/CompilationUnitTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setBreakIterator", "(Ljava/text/BreakIterator;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocTreeFactory", "()Lcom/sun/source/util/DocTreeFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCharacters", "(Lcom/sun/source/doctree/EntityTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourcePositions_0", "()Lcom/sun/source/util/SourcePositions;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getSourcePositions_1", "()Lcom/sun/source/util/DocSourcePositions;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocTrees(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DocTrees() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/DocTrees;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/source/util/DocTreePath;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getType(Dova.JDK.com.sun.source.util.DocTreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/DocTrees;", "public static")]
	public static Dova.JDK.com.sun.source.util.DocTrees instance(Dova.JDK.javax.annotation.processing.ProcessingEnvironment arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaCompiler$CompilationTask;)Lcom/sun/source/util/DocTrees;", "public static")]
	public static Dova.JDK.com.sun.source.util.DocTrees instance(Dova.JDK.javax.tools.JavaCompiler.CompilationTask arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTrees>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/DocTreePath;)Ljavax/lang/model/element/Element;", "public abstract")]
	public Dova.JDK.javax.lang.model.element.Element getElement(Dova.JDK.com.sun.source.util.DocTreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/BreakIterator;", "public abstract")]
	public Dova.JDK.java.text.BreakIterator getBreakIterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.BreakIterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;)Lcom/sun/source/doctree/DocCommentTree;", "public abstract")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocCommentTree(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;Ljavax/lang/model/element/PackageElement;)Lcom/sun/source/util/DocTreePath;", "public abstract")]
	public Dova.JDK.com.sun.source.util.DocTreePath getDocTreePath(Dova.JDK.javax.tools.FileObject arg0, Dova.JDK.javax.lang.model.element.PackageElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/List;)Ljava/util/List;", "public abstract")]
	public Dova.JDK.java.util.List getFirstSentence(Dova.JDK.java.util.List arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Lcom/sun/source/doctree/DocTree;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/tree/CompilationUnitTree;)V", "public abstract")]
	public void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2, Dova.JDK.com.sun.source.doctree.DocCommentTree arg3, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljava/text/BreakIterator;)V", "public abstract")]
	public void setBreakIterator(Dova.JDK.java.text.BreakIterator arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/DocTreeFactory;", "public abstract")]
	public Dova.JDK.com.sun.source.util.DocTreeFactory getDocTreeFactory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreeFactory>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/EntityTree;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getCharacters(Dova.JDK.com.sun.source.doctree.EntityTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/SourcePositions;", "public volatile")]
	public Dova.JDK.com.sun.source.util.SourcePositions getSourcePositions_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.SourcePositions>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/DocSourcePositions;", "public abstract")]
	public Dova.JDK.com.sun.source.util.DocSourcePositions getSourcePositions_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocSourcePositions>(ret);
	}
}
