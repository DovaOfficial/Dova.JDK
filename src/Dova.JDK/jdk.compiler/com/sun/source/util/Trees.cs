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

[JniSignatureAttribute("Lcom/sun/source/util/Trees;", "public abstract")]
public partial class Trees
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Trees()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/Trees;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessible", "(Lcom/sun/source/tree/Scope;Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAccessible", "(Lcom/sun/source/tree/Scope;Ljavax/lang/model/element/Element;Ljavax/lang/model/type/DeclaredType;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/Trees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Ljavax/tools/JavaCompiler$CompilationTask;)Lcom/sun/source/util/Trees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljavax/lang/model/element/ExecutableElement;)Lcom/sun/source/tree/MethodTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljavax/lang/model/element/Element;)Lcom/sun/source/tree/Tree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljavax/lang/model/element/TypeElement;)Lcom/sun/source/tree/ClassTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Lcom/sun/source/tree/Tree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)Lcom/sun/source/tree/Tree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "(Lcom/sun/source/util/TreePath;)Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getJavacTrees", "(Ljava/lang/Class;Ljava/lang/Object;)Lcom/sun/source/util/Trees;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printMessage", "(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Lcom/sun/source/tree/Tree;Lcom/sun/source/tree/CompilationUnitTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocComment", "(Lcom/sun/source/util/TreePath;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLub", "(Lcom/sun/source/tree/CatchTree;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeMirror", "(Lcom/sun/source/util/TreePath;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOriginalType", "(Ljavax/lang/model/type/ErrorType;)Ljavax/lang/model/type/TypeMirror;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourcePositions", "()Lcom/sun/source/util/SourcePositions;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScope", "(Lcom/sun/source/util/TreePath;)Lcom/sun/source/tree/Scope;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Trees(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Trees() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/Trees;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/source/tree/Scope;Ljavax/lang/model/element/TypeElement;)Z", "public abstract")]
	public bool isAccessible(Dova.JDK.com.sun.source.tree.Scope arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Scope;Ljavax/lang/model/element/Element;Ljavax/lang/model/type/DeclaredType;)Z", "public abstract")]
	public bool isAccessible(Dova.JDK.com.sun.source.tree.Scope arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.javax.lang.model.type.DeclaredType arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;", "public abstract")]
	public Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Lcom/sun/source/util/TreePath;", "public abstract")]
	public Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/util/TreePath;", "public abstract")]
	public Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)Lcom/sun/source/util/TreePath;", "public abstract")]
	public Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1, Dova.JDK.javax.lang.model.element.AnnotationValue arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/annotation/processing/ProcessingEnvironment;)Lcom/sun/source/util/Trees;", "public static")]
	public static Dova.JDK.com.sun.source.util.Trees instance(Dova.JDK.javax.annotation.processing.ProcessingEnvironment arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.Trees>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaCompiler$CompilationTask;)Lcom/sun/source/util/Trees;", "public static")]
	public static Dova.JDK.com.sun.source.util.Trees instance(Dova.JDK.javax.tools.JavaCompiler.CompilationTask arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.Trees>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Lcom/sun/source/tree/MethodTree;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.MethodTree getTree(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MethodTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Lcom/sun/source/tree/Tree;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.Tree getTree(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Lcom/sun/source/tree/ClassTree;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.ClassTree getTree(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ClassTree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;)Lcom/sun/source/tree/Tree;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.Tree getTree(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/AnnotationMirror;Ljavax/lang/model/element/AnnotationValue;)Lcom/sun/source/tree/Tree;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.Tree getTree(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1, Dova.JDK.javax.lang.model.element.AnnotationValue arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Ljavax/lang/model/element/Element;", "public abstract")]
	public Dova.JDK.javax.lang.model.element.Element getElement(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Lcom/sun/source/util/Trees;", "static")]
	public static Dova.JDK.com.sun.source.util.Trees getJavacTrees(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.Trees>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic$Kind;Ljava/lang/CharSequence;Lcom/sun/source/tree/Tree;Lcom/sun/source/tree/CompilationUnitTree;)V", "public abstract")]
	public void printMessage(Dova.JDK.javax.tools.Diagnostic.Kind arg0, Dova.JDK.java.lang.CharSequence arg1, Dova.JDK.com.sun.source.tree.Tree arg2, Dova.JDK.com.sun.source.tree.CompilationUnitTree arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Ljava/lang/String;", "public abstract")]
	public Dova.JDK.java.lang.String getDocComment(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CatchTree;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getLub(Dova.JDK.com.sun.source.tree.CatchTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getTypeMirror(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/type/ErrorType;)Ljavax/lang/model/type/TypeMirror;", "public abstract")]
	public Dova.JDK.javax.lang.model.type.TypeMirror getOriginalType(Dova.JDK.javax.lang.model.type.ErrorType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeMirror>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/SourcePositions;", "public abstract")]
	public Dova.JDK.com.sun.source.util.SourcePositions getSourcePositions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.SourcePositions>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;)Lcom/sun/source/tree/Scope;", "public abstract")]
	public Dova.JDK.com.sun.source.tree.Scope getScope(Dova.JDK.com.sun.source.util.TreePath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Scope>(ret);
	}
}
