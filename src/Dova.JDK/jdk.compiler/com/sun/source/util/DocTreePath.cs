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

[JniSignatureAttribute("Lcom/sun/source/util/DocTreePath;", "public")]
public partial class DocTreePath
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.Iterable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocTreePath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/util/DocTreePath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "treePath", "Lcom/sun/source/util/TreePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docComment", "Lcom/sun/source/doctree/DocCommentTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "leaf", "Lcom/sun/source/doctree/DocTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Lcom/sun/source/util/DocTreePath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/DocTreePath;Lcom/sun/source/doctree/DocTree;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPath", "(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPath", "(Lcom/sun/source/util/DocTreePath;Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocComment", "()Lcom/sun/source/doctree/DocCommentTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeaf", "()Lcom/sun/source/doctree/DocTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParentPath", "()Lcom/sun/source/util/DocTreePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTreePath", "()Lcom/sun/source/util/TreePath;"));
	}

	[JniSignatureAttribute("Lcom/sun/source/util/TreePath;", "private final")]
	public Dova.JDK.com.sun.source.util.TreePath treePath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/doctree/DocCommentTree;", "private final")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree docComment_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree;", "private final")]
	public Dova.JDK.com.sun.source.doctree.DocTree leaf_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/source/util/DocTreePath;", "private final")]
	public Dova.JDK.com.sun.source.util.DocTreePath parent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocTreePath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/DocTreePath;Lcom/sun/source/doctree/DocTree;)V", "public")]
	public DocTreePath(Dova.JDK.com.sun.source.util.DocTreePath arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;)V", "public")]
	public DocTreePath(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/source/util/DocTreePath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TreePath;Lcom/sun/source/doctree/DocCommentTree;Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;", "public static")]
	public static Dova.JDK.com.sun.source.util.DocTreePath getPath(Dova.JDK.com.sun.source.util.TreePath arg0, Dova.JDK.com.sun.source.doctree.DocCommentTree arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/DocTreePath;Lcom/sun/source/doctree/DocTree;)Lcom/sun/source/util/DocTreePath;", "public static")]
	public static Dova.JDK.com.sun.source.util.DocTreePath getPath(Dova.JDK.com.sun.source.util.DocTreePath arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocCommentTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocCommentTree getDocComment()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocCommentTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocTree getLeaf()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/DocTreePath;", "public")]
	public Dova.JDK.com.sun.source.util.DocTreePath getParentPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.DocTreePath>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/util/TreePath;", "public")]
	public Dova.JDK.com.sun.source.util.TreePath getTreePath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TreePath>(ret);
	}
}
