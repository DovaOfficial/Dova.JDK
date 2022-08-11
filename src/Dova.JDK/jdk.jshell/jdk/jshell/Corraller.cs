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

namespace Dova.JDK.jdk.jshell;

[JniSignatureAttribute("Ljdk/jshell/Corraller;", "")]
public partial class Corraller
	: Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Corraller()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jshell/Corraller;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "result", "Ljdk/jshell/Wrap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dis", "Ljdk/jshell/TreeDissector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolutionExceptionBlock", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "source", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/jshell/TreeDissector;ILjava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "corral", "(Lcom/sun/tools/javac/tree/JCTree;)Ljdk/jshell/Wrap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "debugWrap", "(Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "corralToWrap", "(Lcom/sun/source/tree/Tree;)Ljdk/jshell/Wrap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultConstructor", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "corralType", "(Lcom/sun/source/tree/ClassTree;)Ljdk/jshell/Wrap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "corralMethod", "(Lcom/sun/source/tree/MethodTree;)Ljdk/jshell/Wrap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTree", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
	}

	[JniSignatureAttribute("Ljdk/jshell/Wrap;", "protected")]
	public Dova.JDK.jdk.jshell.Wrap result_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jshell/TreeDissector;", "private final")]
	public Dova.JDK.jdk.jshell.TreeDissector dis_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.TreeDissector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String resolutionExceptionBlock_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String source_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Corraller(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jshell/TreeDissector;ILjava/lang/String;)V", "public")]
	public Corraller(Dova.JDK.jdk.jshell.TreeDissector arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jshell/Corraller;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)Ljdk/jshell/Wrap;", "private")]
	public Dova.JDK.jdk.jshell.Wrap corral(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
	public void debugWrap(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;)Ljdk/jshell/Wrap;", "private")]
	public Dova.JDK.jdk.jshell.Wrap corralToWrap(Dova.JDK.com.sun.source.tree.Tree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String defaultConstructor(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/ClassTree;)Ljdk/jshell/Wrap;", "public")]
	public Dova.JDK.jdk.jshell.Wrap corralType(Dova.JDK.com.sun.source.tree.ClassTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/MethodTree;)Ljdk/jshell/Wrap;", "public")]
	public Dova.JDK.jdk.jshell.Wrap corralMethod(Dova.JDK.com.sun.source.tree.MethodTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jshell.Wrap>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
	public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
	public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
	public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
	public void visitTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}
}
