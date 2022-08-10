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

[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "public")]
public partial class TreePath
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Iterable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TreePath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/TreePath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "compilationUnit", "Lcom/sun/source/tree/CompilationUnitTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "leaf", "Lcom/sun/source/tree/Tree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "parent", "Lcom/sun/source/util/TreePath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TreePath", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/tree/Tree;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "TreePath", "(Lcom/sun/source/tree/CompilationUnitTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPath", "(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "getPath", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLeaf", "()Lcom/sun/source/tree/Tree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getCompilationUnit", "()Lcom/sun/source/tree/CompilationUnitTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getParentPath", "()Lcom/sun/source/util/TreePath;"));
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/CompilationUnitTree;", "private")]
	public Dova.JDK.com.sun.source.tree.CompilationUnitTree compilationUnit_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CompilationUnitTree>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/Tree;", "private")]
	public Dova.JDK.com.sun.source.tree.Tree leaf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "private")]
	public Dova.JDK.com.sun.source.util.TreePath parent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TreePath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/tree/Tree;)V", "public")]
	public TreePath(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.tree.Tree arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;)V", "public")]
	public TreePath(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/TreePath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/CompilationUnitTree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;", "public static")]
	public static Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.com.sun.source.tree.CompilationUnitTree arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/tree/Tree;)Lcom/sun/source/util/TreePath;", "public static")]
	public static Dova.JDK.com.sun.source.util.TreePath getPath(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public")]
	public Dova.JDK.com.sun.source.tree.Tree getLeaf()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/CompilationUnitTree;", "public")]
	public Dova.JDK.com.sun.source.tree.CompilationUnitTree getCompilationUnit()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CompilationUnitTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/TreePath;", "public")]
	public Dova.JDK.com.sun.source.util.TreePath getParentPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}
}
