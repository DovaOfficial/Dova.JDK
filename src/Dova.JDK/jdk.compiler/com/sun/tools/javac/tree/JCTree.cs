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

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public abstract")]
public partial class JCTree
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.tree.Tree
	, Dova.JDK.java.lang.Cloneable
	, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JCTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "clone", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pos", "()Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "()Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPos", "(I)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasTag", "(Lcom/sun/tools/javac/tree/JCTree$Tag;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPosition", "(Lcom/sun/tools/javac/tree/EndPosTable;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
	}

	[JniSignatureAttribute("I", "public")]
	public int pos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
	public Dova.JDK.com.sun.tools.javac.code.Type type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JCTree(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JCTree() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object clone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public abstract")]
	public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition pos()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree getTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public abstract")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPreferredPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7]);
		return ret;
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree setPos(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;)Z", "public")]
	public bool hasTag(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/EndPosTable;)I", "public")]
	public int getEndPosition(Dova.JDK.com.sun.tools.javac.tree.EndPosTable arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree setType(Dova.JDK.com.sun.tools.javac.code.Type arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
	public partial class Tag
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Tag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$Tag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NO_TAG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOPLEVEL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGEDEF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPORT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASSDEF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODDEF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VARDEF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BLOCK", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOLOOP", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WHILELOOP", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORLOOP", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOREACHLOOP", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LABELLED", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWITCH", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CASE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SWITCH_EXPRESSION", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYNCHRONIZED", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRY", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CATCH", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONDEXPR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXEC", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BREAK", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "YIELD", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONTINUE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROW", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASSERT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APPLY", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEWCLASS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEWARRAY", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAMBDA", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARENS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ASSIGN", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPECAST", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPETEST", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BINDINGPATTERN", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULTCASELABEL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GUARDPATTERN", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARENTHESIZEDPATTERN", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEXED", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SELECT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REFERENCE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IDENT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LITERAL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEIDENT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEARRAY", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEAPPLY", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEUNION", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEINTERSECTION", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEPARAMETER", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "WILDCARD", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPEBOUNDKIND", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_ANNOTATION", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODIFIERS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATED_TYPE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERRONEOUS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NOT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "COMPL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREINC", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREDEC", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSTINC", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POSTDEC", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NULLCHK", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "AND", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITOR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITXOR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITAND", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EQ", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GT", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GE", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINUS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MUL", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIV", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOD", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITOR_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITXOR_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BITAND_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SL_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SR_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USR_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLUS_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MINUS_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MUL_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DIV_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MOD_ASG", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULEDEF", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPORTS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPENS", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROVIDES", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "REQUIRES", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "USES", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LETEXPR", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noAssignTag", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "numberOfOperators", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/tools/javac/tree/JCTree$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNumberOfOperators", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "noAssignOp", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPostUnaryOp", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isIncOrDecUnaryOp", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAssignop", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "operatorIndex", "()I"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NO_TAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TOPLEVEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PACKAGEDEF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag IMPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag CLASSDEF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag METHODDEF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag VARDEF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SKIP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BLOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag DOLOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag WHILELOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag FORLOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag FOREACHLOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LABELLED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag CASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SWITCH_EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SYNCHRONIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag CONDEXPR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag IF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag EXEC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BREAK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag YIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag CONTINUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag RETURN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag THROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag ASSERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag APPLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NEWCLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NEWARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LAMBDA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PARENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag ASSIGN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPECAST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPETEST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BINDINGPATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag DEFAULTCASELABEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag GUARDPATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PARENTHESIZEDPATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag INDEXED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SELECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag REFERENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag IDENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEIDENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEAPPLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEUNION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEINTERSECTION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEPARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPEBOUNDKIND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag TYPE_ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MODIFIERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag ANNOTATED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag ERRONEOUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag POS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NEG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NOT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag COMPL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PREINC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PREDEC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag POSTINC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag POSTDEC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NULLCHK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag OR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag AND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITXOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITAND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag EQ_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag NE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag GT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag GE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag USR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MINUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MUL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag DIV_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITOR_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITXOR_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag BITAND_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SL_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag SR_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag USR_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PLUS_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MINUS_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MUL_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag DIV_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MOD_ASG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag MODULEDEF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag EXPORTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag OPENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag PROVIDES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag REQUIRES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag USES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag LETEXPR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "private final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag noAssignTag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[105], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private static final")]
		public static int numberOfOperators_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[106]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[106], value);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$Tag;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Tag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Tag(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/tools/javac/tree/JCTree$Tag;)V", "private")]
		public Tag(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$Tag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$Tag;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$Tag;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>>(ret);
		}

		[JniSignatureAttribute("()I", "public static")]
		public static int getNumberOfOperators()
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag noAssignOp()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPostUnaryOp()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isIncOrDecUnaryOp()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isAssignop()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int operatorIndex()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Visitor;", "public abstract static")]
	public partial class Visitor
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$Visitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotation", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBinary", "(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitApply", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBlock", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitVarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModifiers", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParenthesizedPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitGuardPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssign", "(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssignop", "(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitConditional", "(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeArray", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackageDef", "(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTopLevel", "(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUnary", "(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeIntersection", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeCast", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitParens", "(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIdent", "(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIndexed", "(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSelect", "(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeApply", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExec", "(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLambda", "(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeBoundKind", "(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDefaultCaseLabel", "(Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitYield", "(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCase", "(Lcom/sun/tools/javac/tree/JCTree$JCCase;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitIf", "(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitForLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTry", "(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSwitch", "(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSynchronized", "(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitThrow", "(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitBreak", "(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitContinue", "(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSkip", "(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAssert", "(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeUnion", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRequires", "(Lcom/sun/tools/javac/tree/JCTree$JCRequires;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitExports", "(Lcom/sun/tools/javac/tree/JCTree$JCExports;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitOpens", "(Lcom/sun/tools/javac/tree/JCTree$JCOpens;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitImport", "(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParameter", "(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitCatch", "(Lcom/sun/tools/javac/tree/JCTree$JCCatch;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLetExpr", "(Lcom/sun/tools/javac/tree/JCTree$LetExpr;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLabelled", "(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeTest", "(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTree", "(Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReturn", "(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLiteral", "(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitErroneous", "(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitProvides", "(Lcom/sun/tools/javac/tree/JCTree$JCProvides;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitReference", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUses", "(Lcom/sun/tools/javac/tree/JCTree$JCUses;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcard", "(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Visitor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Visitor() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$Visitor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;)V", "public")]
		public void visitAnnotation(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBinary;)V", "public")]
		public void visitBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;)V", "public")]
		public void visitTypeIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPrimitiveTypeTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;)V", "public")]
		public void visitApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "public")]
		public void visitBlock(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "public")]
		public void visitVarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;)V", "public")]
		public void visitModifiers(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;)V", "public")]
		public void visitParenthesizedPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParenthesizedPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;)V", "public")]
		public void visitBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;)V", "public")]
		public void visitGuardPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCGuardPattern arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;)V", "public")]
		public void visitMethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssign;)V", "public")]
		public void visitAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;)V", "public")]
		public void visitAssignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCConditional;)V", "public")]
		public void visitConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;)V", "public")]
		public void visitTypeArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayTypeTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;)V", "public")]
		public void visitAnnotatedType(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotatedType arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;)V", "public")]
		public void visitPackageDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;)V", "public")]
		public void visitTopLevel(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUnary;)V", "public")]
		public void visitUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;)V", "public")]
		public void visitTypeIntersection(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeIntersection arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;)V", "public")]
		public void visitTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCParens;)V", "public")]
		public void visitParens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIdent;)V", "public")]
		public void visitIdent(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;)V", "public")]
		public void visitIndexed(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayAccess arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;)V", "public")]
		public void visitSelect(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;)V", "public")]
		public void visitTypeApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeApply arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;)V", "public")]
		public void visitSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewArray;)V", "public")]
		public void visitNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "public")]
		public void visitClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;)V", "public")]
		public void visitExec(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpressionStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLambda;)V", "public")]
		public void visitLambda(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;)V", "public")]
		public void visitTypeBoundKind(Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCNewClass;)V", "public")]
		public void visitNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;)V", "public")]
		public void visitDefaultCaseLabel(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDefaultCaseLabel arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCYield;)V", "public")]
		public void visitYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCase;)V", "public")]
		public void visitCase(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCase arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCIf;)V", "public")]
		public void visitIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;)V", "public")]
		public void visitForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCForLoop;)V", "public")]
		public void visitForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;)V", "public")]
		public void visitWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;)V", "public")]
		public void visitDoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTry;)V", "public")]
		public void visitTry(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSwitch;)V", "public")]
		public void visitSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;)V", "public")]
		public void visitSynchronized(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSynchronized arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCThrow;)V", "public")]
		public void visitThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBreak;)V", "public")]
		public void visitBreak(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCContinue;)V", "public")]
		public void visitContinue(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCSkip;)V", "public")]
		public void visitSkip(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSkip arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCAssert;)V", "public")]
		public void visitAssert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;)V", "public")]
		public void visitTypeUnion(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeUnion arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;)V", "public")]
		public void visitModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCRequires;)V", "public")]
		public void visitRequires(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCRequires arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExports;)V", "public")]
		public void visitExports(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExports arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCOpens;)V", "public")]
		public void visitOpens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOpens arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCImport;)V", "public")]
		public void visitImport(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;)V", "public")]
		public void visitTypeParameter(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCCatch;)V", "public")]
		public void visitCatch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCatch arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$LetExpr;)V", "public")]
		public void visitLetExpr(Dova.JDK.com.sun.tools.javac.tree.JCTree.LetExpr arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;)V", "public")]
		public void visitLabelled(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;)V", "public")]
		public void visitTypeTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
		public void visitTree(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCReturn;)V", "public")]
		public void visitReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCLiteral;)V", "public")]
		public void visitLiteral(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCErroneous;)V", "public")]
		public void visitErroneous(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCErroneous arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCProvides;)V", "public")]
		public void visitProvides(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCProvides arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;)V", "public")]
		public void visitReference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCUses;)V", "public")]
		public void visitUses(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUses arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCWildcard;)V", "public")]
		public void visitWildcard(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWildcard arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Factory;", "public abstract static interface")]
	public partial interface Factory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Factory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$Factory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Opens", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCOpens;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Exports", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExports;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Provides", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCProvides;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Requires", "(ZZLcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCRequires;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeIdent", "(Lcom/sun/tools/javac/code/TypeTag;)Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "MethodDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Exec", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Erroneous", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCErroneous;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Labelled", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Ident", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCIdent;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Select", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Assign", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCAssign;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Assignop", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Conditional", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCConditional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Case", "(Lcom/sun/source/tree/CaseTree$CaseKind;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCCase;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "VarDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "BindingPattern", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeTest", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Binary", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCBinary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Literal", "(Lcom/sun/tools/javac/code/TypeTag;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCLiteral;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Apply", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Unary", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCUnary;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeCast", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Parens", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCParens;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeArray", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Indexed", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeApply", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "SwitchExpression", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeBoundKind", "(Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Wildcard", "(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCWildcard;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "NewClass", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "NewArray", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCNewArray;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Block", "(JLcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "If", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCIf;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ForeachLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ForLoop", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCForLoop;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "WhileLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "DoLoop", "(Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Try", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCTry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Try", "(Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCTry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Switch", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCSwitch;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Synchronized", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Return", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCReturn;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Throw", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCThrow;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Break", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCBreak;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Continue", "(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCContinue;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Assert", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCAssert;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Catch", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCCatch;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Annotation", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "PackageDecl", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TopLevel", "(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ModuleDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/source/tree/ModuleTree$ModuleKind;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Uses", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCUses;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Import", "(Lcom/sun/tools/javac/tree/JCTree;Z)Lcom/sun/tools/javac/tree/JCTree$JCImport;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "TypeParameter", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "LetExpr", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$LetExpr;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Yield", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCYield;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Skip", "()Lcom/sun/tools/javac/tree/JCTree$JCSkip;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ClassDef", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "Modifiers", "(JLcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCOpens;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOpens Opens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOpens>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCExports;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExports Exports(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExports>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCProvides;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCProvides Provides(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCProvides>(ret);
		}

		[JniSignatureAttribute("(ZZLcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCRequires;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCRequires Requires(bool arg0, bool arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCRequires>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;)Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPrimitiveTypeTree TypeIdent(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPrimitiveTypeTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl MethodDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.List arg6, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg7, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg8)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpressionStatement Exec(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpressionStatement>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCErroneous;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCErroneous Erroneous(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCErroneous>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement Labelled(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLabeledStatement>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCIdent;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent Ident(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIdent>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess Select(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFieldAccess>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCAssign;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign Assign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssign>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp Assignop(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssignOp>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCConditional;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional Conditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCConditional>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/CaseTree$CaseKind;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCCase;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCase Case(Dova.JDK.com.sun.source.tree.CaseTree.CaseKind arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCase>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl VarDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern BindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBindingPattern>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf TypeTest(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCInstanceOf>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCBinary;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary Binary(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBinary>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Ljava/lang/Object;)Lcom/sun/tools/javac/tree/JCTree$JCLiteral;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral Literal(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation Apply(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCUnary;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary Unary(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUnary>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast TypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeCast>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCParens;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens Parens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCParens>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayTypeTree TypeArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayTypeTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayAccess Indexed(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCArrayAccess>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeApply TypeApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeApply>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression SwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitchExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/BoundKind;)Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind TypeBoundKind(Dova.JDK.com.sun.tools.javac.code.BoundKind arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;Lcom/sun/tools/javac/tree/JCTree;)Lcom/sun/tools/javac/tree/JCTree$JCWildcard;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWildcard Wildcard(Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWildcard>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)Lcom/sun/tools/javac/tree/JCTree$JCNewClass;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass NewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg4)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3, arg4);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewClass>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCNewArray;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray NewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCNewArray>(ret);
		}

		[JniSignatureAttribute("(JLcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock Block(long arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCIf;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf If(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCIf>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop ForeachLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCEnhancedForLoop>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCForLoop;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop ForLoop(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCForLoop>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop WhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCWhileLoop>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop DoLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDoWhileLoop>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCTry;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry Try(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCTry;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry Try(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTry>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCSwitch;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch Switch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSwitch>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSynchronized Synchronized(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSynchronized>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCReturn;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn Return(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCReturn>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCThrow;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow Throw(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCThrow>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCBreak;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak Break(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBreak>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;)Lcom/sun/tools/javac/tree/JCTree$JCContinue;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue Continue(Dova.JDK.com.sun.tools.javac.util.Name arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCContinue>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCAssert;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert Assert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAssert>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)Lcom/sun/tools/javac/tree/JCTree$JCCatch;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCatch Catch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCatch>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation Annotation(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCAnnotation>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl PackageDecl(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit TopLevel(Dova.JDK.com.sun.tools.javac.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCompilationUnit>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/source/tree/ModuleTree$ModuleKind;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl ModuleDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCUses;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUses Uses(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCUses>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Z)Lcom/sun/tools/javac/tree/JCTree$JCImport;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport Import(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCImport>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter TypeParameter(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCTypeParameter>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$LetExpr;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.LetExpr LetExpr(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.LetExpr>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)Lcom/sun/tools/javac/tree/JCTree$JCYield;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield Yield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCYield>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCSkip;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSkip Skip()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCSkip>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl ClassDef(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.com.sun.tools.javac.util.List arg4, Dova.JDK.com.sun.tools.javac.util.List arg5)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1, arg2, arg3, arg4, arg5);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
		}

		[JniSignatureAttribute("(JLcom/sun/tools/javac/util/List;)Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public abstract")]
		Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers Modifiers(long arg0, Dova.JDK.com.sun.tools.javac.util.List arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$LetExpr;", "public static")]
	public partial class LetExpr
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LetExpr()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$LetExpr;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "needsCond", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List defs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool needsCond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LetExpr(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public LetExpr(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$LetExpr;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCErroneous;", "public static")]
	public partial class JCErroneous
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.ErroneousTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCErroneous()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCErroneous;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "errs", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorTrees_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getErrorTrees_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List errs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCErroneous(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCErroneous(Dova.JDK.com.sun.tools.javac.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCErroneous;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getErrorTrees_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getErrorTrees_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCUses;", "public static")]
	public partial class JCUses
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDirective
		, Dova.JDK.com.sun.source.tree.UsesTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCUses()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCUses;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualid", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceName_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceName_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression qualid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCUses(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCUses(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCUses;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getServiceName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getServiceName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCRequires;", "public static")]
	public partial class JCRequires
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDirective
		, Dova.JDK.com.sun.source.tree.RequiresTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCRequires()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCRequires;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isTransitive", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isStaticPhase", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleName", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directive", "Lcom/sun/tools/javac/code/Directive$RequiresDirective;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZZLcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleName_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleName_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTransitive", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Z", "public")]
		public bool isTransitive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool isStaticPhase_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression moduleName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Directive$RequiresDirective;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Directive.RequiresDirective directive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Directive.RequiresDirective>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCRequires(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZZLcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCRequires(bool arg0, bool arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCRequires;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isStatic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getModuleName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getModuleName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTransitive()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCProvides;", "public static")]
	public partial class JCProvides
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDirective
		, Dova.JDK.com.sun.source.tree.ProvidesTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCProvides()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCProvides;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceName", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implNames", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationNames_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementationNames_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceName_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceName_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression serviceName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List implNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCProvides(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCProvides(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCProvides;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getImplementationNames_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getImplementationNames_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getServiceName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getServiceName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCOpens;", "public static")]
	public partial class JCOpens
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDirective
		, Dova.JDK.com.sun.source.tree.OpensTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCOpens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCOpens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualid", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleNames", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directive", "Lcom/sun/tools/javac/code/Directive$OpensDirective;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleNames_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleNames_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression qualid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List moduleNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Directive$OpensDirective;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Directive.OpensDirective directive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Directive.OpensDirective>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCOpens(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCOpens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCOpens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getPackageName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getPackageName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getModuleNames_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getModuleNames_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExports;", "public static")]
	public partial class JCExports
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCDirective
		, Dova.JDK.com.sun.source.tree.ExportsTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCExports()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCExports;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualid", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleNames", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directive", "Lcom/sun/tools/javac/code/Directive$ExportsDirective;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleNames_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleNames_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression qualid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List moduleNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Directive$ExportsDirective;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Directive.ExportsDirective directive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Directive.ExportsDirective>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCExports(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCExports(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCExports;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getPackageName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getPackageName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getModuleNames_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getModuleNames_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;", "public static")]
	public partial class JCModuleDecl
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.ModuleTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCModuleDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mods", "Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/code/Type$ModuleType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualId", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "directives", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/source/tree/ModuleTree$ModuleKind;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectives_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectives_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleType", "()Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers mods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type$ModuleType;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type.ModuleType type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type.ModuleType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/ModuleTree$ModuleKind;", "private final")]
		public Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression qualId_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List directives_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCModuleDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/source/tree/ModuleTree$ModuleKind;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCModuleDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getDirectives_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getDirectives_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public")]
		public Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind getModuleType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCDirective;", "public abstract static")]
	public partial class JCDirective
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.DirectiveTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCDirective()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCDirective;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCDirective(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCDirective() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCDirective;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;", "public static")]
	public partial class JCAnnotatedType
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.AnnotatedTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCAnnotatedType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "underlyingType", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnderlyingType_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnderlyingType_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression underlyingType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCAnnotatedType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCAnnotatedType(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCAnnotatedType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getUnderlyingType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getUnderlyingType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public static")]
	public partial class JCModifiers
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.ModifiersTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCModifiers()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFlags", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("J", "public")]
		public long flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCModifiers(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLcom/sun/tools/javac/util/List;)V", "protected")]
		public JCModifiers(long arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCModifiers;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set getFlags()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;", "public static")]
	public partial class JCAnnotation
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.AnnotationTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCAnnotation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationType", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attribute", "Lcom/sun/tools/javac/code/Attribute$Compound;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotationType_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree annotationType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Attribute$Compound;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Attribute.Compound attribute_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Attribute.Compound>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCAnnotation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCAnnotation(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCAnnotation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getAnnotationType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getAnnotationType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;", "public static")]
	public partial class TypeBoundKind
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeBoundKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/code/BoundKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/BoundKind;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/BoundKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.BoundKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.BoundKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeBoundKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/BoundKind;)V", "protected")]
		public TypeBoundKind(Dova.JDK.com.sun.tools.javac.code.BoundKind arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCWildcard;", "public static")]
	public partial class JCWildcard
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.WildcardTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCWildcard()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCWildcard;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inner", "Lcom/sun/tools/javac/tree/JCTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBound_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBound_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree inner_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCWildcard(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$TypeBoundKind;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCWildcard(Dova.JDK.com.sun.tools.javac.tree.JCTree.TypeBoundKind arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCWildcard;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getBound_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getBound_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;", "public static")]
	public partial class JCTypeParameter
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.TypeParameterTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTypeParameter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bounds", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List bounds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTypeParameter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCTypeParameter(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTypeParameter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getBounds_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getBounds_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;", "public static")]
	public partial class JCTypeIntersection
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.IntersectionTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTypeIntersection()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "bounds", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBounds_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List bounds_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTypeIntersection(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCTypeIntersection(Dova.JDK.com.sun.tools.javac.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTypeIntersection;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getBounds_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getBounds_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;", "public static")]
	public partial class JCTypeUnion
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.UnionTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTypeUnion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "alternatives", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeAlternatives_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeAlternatives_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List alternatives_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTypeUnion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCTypeUnion(Dova.JDK.com.sun.tools.javac.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTypeUnion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeAlternatives_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeAlternatives_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;", "public static")]
	public partial class JCTypeApply
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.ParameterizedTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTypeApply()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arguments", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression clazz_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List arguments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTypeApply(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCTypeApply(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTypeApply;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;", "public static")]
	public partial class JCArrayTypeTree
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.ArrayTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCArrayTypeTree()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elemtype", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression elemtype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCArrayTypeTree(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCArrayTypeTree(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCArrayTypeTree;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;", "public static")]
	public partial class JCPrimitiveTypeTree
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.PrimitiveTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCPrimitiveTypeTree()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typetag", "Lcom/sun/tools/javac/code/TypeTag;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPrimitiveTypeKind", "()Ljavax/lang/model/type/TypeKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag typetag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCPrimitiveTypeTree(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;)V", "protected")]
		public JCPrimitiveTypeTree(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCPrimitiveTypeTree;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/type/TypeKind;", "public")]
		public Dova.JDK.javax.lang.model.type.TypeKind getPrimitiveTypeKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.type.TypeKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLiteral;", "public static")]
	public partial class JCLiteral
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.LiteralTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCLiteral()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCLiteral;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typetag", "Lcom/sun/tools/javac/code/TypeTag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/code/TypeTag;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_0", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCLiteral;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_1", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_2", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/TypeTag;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.TypeTag typetag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.TypeTag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCLiteral(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/TypeTag;Ljava/lang/Object;)V", "protected")]
		public JCLiteral(Dova.JDK.com.sun.tools.javac.code.TypeTag arg0, Dova.JDK.java.lang.Object arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCLiteral;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object getValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCLiteral;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral setType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLiteral>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression setType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setType_2(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCIdent;", "public static")]
	public partial class JCIdent
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.IdentifierTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCIdent()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCIdent;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCIdent(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;)V", "protected")]
		public JCIdent(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.code.Symbol arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCIdent;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;", "public static")]
	public partial class JCMemberReference
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFunctionalExpression
		, Dova.JDK.com.sun.source.tree.MemberReferenceTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCMemberReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeargs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varargsElement", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "refPolyKind", "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ownerAccessible", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overloadKind", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "referentType", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifierExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifierExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMode", "()Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasKind", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOverloadKind", "()Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOverloadKind", "(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public")]
		public Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode mode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typeargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type varargsElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind refPolyKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool ownerAccessible_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "private")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind overloadKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type referentType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCMemberReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "public")]
		public JCMemberReference(Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getQualifierExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getQualifierExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public")]
		public Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode getMode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;)Z", "public")]
		public bool hasKind(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind getOverloadKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;)V", "public")]
		public void setOverloadKind(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
		public partial class ReferenceKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ReferenceKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNBOUND", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATIC", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOUND", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLICIT_INNER", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TOPLEVEL", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ARRAY_CTOR", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mode", "Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "unbound", "Z"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILcom/sun/source/tree/MemberReferenceTree$ReferenceMode;Z)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isUnbound", "()Z"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind SUPER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind UNBOUND_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind STATIC_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind BOUND_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind IMPLICIT_INNER_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind TOPLEVEL_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind ARRAY_CTOR_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "final")]
			public Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode mode_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Z", "final")]
			public bool unbound_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[8]);
					return ret;
				}
				set
				{
					DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[8], value);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ReferenceKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;ILcom/sun/source/tree/MemberReferenceTree$ReferenceMode;Z)V", "private")]
			public ReferenceKind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$ReferenceKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.ReferenceKind>>(ret);
			}

			[JniSignatureAttribute("()Z", "public")]
			public bool isUnbound()
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
				return ret;
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static final")]
		public partial class OverloadKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OverloadKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVERLOADED", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNOVERLOADED", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ERROR", "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind OVERLOADED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind UNOVERLOADED_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind ERROR_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OverloadKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public OverloadKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCMemberReference$OverloadKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMemberReference.OverloadKind>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;", "public static")]
	public partial class JCFieldAccess
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.MemberSelectTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCFieldAccess()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selected", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier_1", "()Lcom/sun/tools/javac/util/Name;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression selected_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCFieldAccess(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/code/Symbol;)V", "protected")]
		public JCFieldAccess(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.code.Symbol arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCFieldAccess;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getIdentifier_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getIdentifier_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;", "public static")]
	public partial class JCArrayAccess
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.ArrayAccessTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCArrayAccess()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexed", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression indexed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCArrayAccess(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCArrayAccess(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCArrayAccess;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getIndex_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getIndex_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;", "public static")]
	public partial class JCGuardPattern
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern
		, Dova.JDK.com.sun.source.tree.GuardedPatternTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCGuardPattern()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "patt", "Lcom/sun/tools/javac/tree/JCTree$JCPattern;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCPattern;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern", "()Lcom/sun/source/tree/PatternTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPattern;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern patt_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCGuardPattern(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPattern;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "public")]
		public JCGuardPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCGuardPattern;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/PatternTree;", "public")]
		public Dova.JDK.com.sun.source.tree.PatternTree getPattern()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.PatternTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;", "public static")]
	public partial class JCParenthesizedPattern
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern
		, Dova.JDK.com.sun.source.tree.ParenthesizedPatternTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCParenthesizedPattern()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pattern", "Lcom/sun/tools/javac/tree/JCTree$JCPattern;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCPattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern", "()Lcom/sun/source/tree/PatternTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPattern;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern pattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCParenthesizedPattern(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCPattern;)V", "public")]
		public JCParenthesizedPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCParenthesizedPattern;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/PatternTree;", "public")]
		public Dova.JDK.com.sun.source.tree.PatternTree getPattern()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.PatternTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;", "public static")]
	public partial class JCDefaultCaseLabel
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCaseLabel
		, Dova.JDK.com.sun.source.tree.DefaultCaseLabelTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCDefaultCaseLabel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpression", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPattern", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCDefaultCaseLabel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public JCDefaultCaseLabel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCDefaultCaseLabel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isExpression()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPattern()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;", "public static")]
	public partial class JCBindingPattern
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern
		, Dova.JDK.com.sun.source.tree.BindingPatternTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCBindingPattern()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "var", "Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable", "()Lcom/sun/source/tree/VariableTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl var_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCBindingPattern(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;)V", "protected")]
		public JCBindingPattern(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCBindingPattern;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public")]
		public Dova.JDK.com.sun.source.tree.VariableTree getVariable()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPattern;", "public abstract static")]
	public partial class JCPattern
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCaseLabel
		, Dova.JDK.com.sun.source.tree.PatternTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCPattern()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCPattern;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpression", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPattern", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCPattern(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCPattern() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCPattern;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isExpression()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPattern()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;", "public static")]
	public partial class JCInstanceOf
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.InstanceOfTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCInstanceOf()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pattern", "Lcom/sun/tools/javac/tree/JCTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern_0", "()Lcom/sun/source/tree/PatternTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPattern_1", "()Lcom/sun/tools/javac/tree/JCTree$JCPattern;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree pattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCInstanceOf(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCInstanceOf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCInstanceOf;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/PatternTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.PatternTree getPattern_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.PatternTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCPattern;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern getPattern_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPattern>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;", "public static")]
	public partial class JCTypeCast
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.TypeCastTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTypeCast()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree clazz_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTypeCast(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCTypeCast(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTypeCast;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBinary;", "public static")]
	public partial class JCBinary
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression
		, Dova.JDK.com.sun.source.tree.BinaryTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCBinary()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCBinary;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOperand", "(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRightOperand_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRightOperand_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeftOperand_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLeftOperand_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression lhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression rhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCBinary(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;)V", "protected")]
		public JCBinary(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCBinary;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getOperand(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getRightOperand_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getRightOperand_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getLeftOperand_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getLeftOperand_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCUnary;", "public static")]
	public partial class JCUnary
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression
		, Dova.JDK.com.sun.source.tree.UnaryTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCUnary()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCUnary;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "arg", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOperand", "(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTag", "(Lcom/sun/tools/javac/tree/JCTree$Tag;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCUnary(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCUnary(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCUnary;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getOperand(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;)V", "public")]
		public void setTag(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;", "public static")]
	public partial class JCAssignOp
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression
		, Dova.JDK.com.sun.source.tree.CompoundAssignmentTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCAssignOp()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOperand", "(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression lhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression rhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCAssignOp(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Tag;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;)V", "protected")]
		public JCAssignOp(Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCAssignOp;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getVariable_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getVariable_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getOperand(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression;", "public abstract static")]
	public partial class JCOperatorExpression
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCOperatorExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "opcode", "Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "operator", "Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOperand", "(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOperator", "()Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$Tag;", "protected")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag opcode_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol @operator_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCOperatorExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCOperatorExpression() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public abstract")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getOperand(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/code/Symbol$OperatorSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol getOperator()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.OperatorSymbol>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "public static final")]
		public partial class OperandPos
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static OperandPos()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEFT", "Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RIGHT", "Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos LEFT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos RIGHT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public OperandPos(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public OperandPos(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCOperatorExpression$OperandPos;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCOperatorExpression.OperandPos>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCAssign;", "public static")]
	public partial class JCAssign
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.AssignmentTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCAssign()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCAssign;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rhs", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression lhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression rhs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCAssign(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCAssign(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCAssign;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getVariable_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getVariable_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCParens;", "public static")]
	public partial class JCParens
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.ParenthesizedTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCParens()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCParens;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCParens(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCParens(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCParens;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda;", "public static")]
	public partial class JCLambda
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCFunctionalExpression
		, Dova.JDK.com.sun.source.tree.LambdaExpressionTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCLambda()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCLambda;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "params", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "canCompleteNormally", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paramKind", "Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBodyKind", "()Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_0", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_1", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCLambda;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_2", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List @params_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool canCompleteNormally_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind paramKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCLambda(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)V", "public")]
		public JCLambda(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCLambda;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getParameters()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public")]
		public Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind getBodyKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getBody_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getBody_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCLambda;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda setType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression setType_2(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public static final")]
		public partial class ParameterKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static ParameterKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLICIT", "Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPLICIT", "Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind IMPLICIT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind EXPLICIT_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public ParameterKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public ParameterKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCLambda$ParameterKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCLambda.ParameterKind>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCNewArray;", "public static")]
	public partial class JCNewArray
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
		, Dova.JDK.com.sun.source.tree.NewArrayTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCNewArray()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCNewArray;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elemtype", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dims", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dimAnnotations", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elems", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimensions_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimensions_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDimAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializers_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializers_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression elemtype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List dims_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List dimAnnotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List elems_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCNewArray(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCNewArray(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCNewArray;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getDimensions_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getDimensions_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getDimAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getDimAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getInitializers_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getInitializers_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCNewClass;", "public static")]
	public partial class JCNewClass
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression
		, Dova.JDK.com.sun.source.tree.NewClassTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCNewClass()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCNewClass;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "encl", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeargs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "def", "Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructor", "Lcom/sun/tools/javac/code/Symbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varargsElement", "Lcom/sun/tools/javac/code/Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constructorType", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassBody_0", "()Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassBody_1", "()Lcom/sun/source/tree/ClassTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEnclosingExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classDeclRemoved", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Lcom/sun/tools/javac/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression encl_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typeargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression clazz_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl def_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol constructor_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type varargsElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type constructorType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCNewClass(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;)V", "protected")]
		public JCNewClass(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCNewClass;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl getClassBody_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCClassDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ClassTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ClassTree getClassBody_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ClassTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getEnclosingExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getEnclosingExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool classDeclRemoved()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getIdentifier_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getIdentifier_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;", "public static")]
	public partial class JCMethodInvocation
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression
		, Dova.JDK.com.sun.source.tree.MethodInvocationTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCMethodInvocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeargs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "meth", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "varargsElement", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodSelect_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodSelect_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getArguments_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_0", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_1", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_2", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typeargs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression meth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type varargsElement_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCMethodInvocation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCMethodInvocation(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getMethodSelect_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getMethodSelect_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeArguments_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeArguments_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCMethodInvocation;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation setType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCMethodInvocation>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression setType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setType_2(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCAssert;", "public static")]
	public partial class JCAssert
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.AssertTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCAssert()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCAssert;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "detail", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDetail_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDetail_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression detail_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCAssert(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCAssert(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCAssert;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getDetail_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getDetail_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCThrow;", "public static")]
	public partial class JCThrow
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ThrowTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCThrow()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCThrow;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCThrow(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCThrow(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCThrow;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCReturn;", "public static")]
	public partial class JCReturn
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ReturnTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCReturn()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCReturn;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCReturn(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCReturn(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCReturn;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCContinue;", "public static")]
	public partial class JCContinue
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ContinueTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCContinue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCContinue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/tree/JCTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_1", "()Lcom/sun/tools/javac/util/Name;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name label_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCContinue(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCContinue(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCContinue;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getLabel_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getLabel_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCYield;", "public static")]
	public partial class JCYield
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.YieldTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCYield()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCYield;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/tree/JCTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCYield(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCYield(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCYield;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getValue_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getValue_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBreak;", "public static")]
	public partial class JCBreak
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.BreakTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCBreak()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCBreak;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/tree/JCTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValueBreak", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_1", "()Lcom/sun/tools/javac/util/Name;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name label_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCBreak(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCBreak(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCBreak;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isValueBreak()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getLabel_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getLabel_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;", "public static")]
	public partial class JCExpressionStatement
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ExpressionStatementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCExpressionStatement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCExpressionStatement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCExpressionStatement(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCExpressionStatement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCIf;", "public static")]
	public partial class JCIf
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.IfTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCIf()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCIf;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thenpart", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elsepart", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElseStatement_0", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElseStatement_1", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThenStatement_0", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThenStatement_1", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement thenpart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement elsepart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCIf(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V", "protected")]
		public JCIf(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCIf;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getElseStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getElseStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getThenStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getThenStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCConditional;", "public static")]
	public partial class JCConditional
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression
		, Dova.JDK.com.sun.source.tree.ConditionalExpressionTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCConditional()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCConditional;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "truepart", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "falsepart", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFalseExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFalseExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrueExpression_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTrueExpression_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression truepart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression falsepart_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCConditional(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCConditional(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCConditional;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getFalseExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getFalseExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getTrueExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getTrueExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCCatch;", "public static")]
	public partial class JCCatch
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.CatchTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCCatch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCCatch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "param", "Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_0", "()Lcom/sun/source/tree/BlockTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_1", "()Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameter_0", "()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameter_1", "()Lcom/sun/source/tree/VariableTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl param_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCCatch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "protected")]
		public JCCatch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCCatch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.BlockTree getBlock_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock getBlock_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl getParameter_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.VariableTree getParameter_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCTry;", "public static")]
	public partial class JCTry
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.TryTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCTry()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCTry;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "catchers", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finalizer", "Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resources", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finallyCanCompleteNormally", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResources_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResources_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFinallyBlock_0", "()Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFinallyBlock_1", "()Lcom/sun/source/tree/BlockTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCatches_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCatches_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_0", "()Lcom/sun/source/tree/BlockTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_1", "()Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List catchers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock finalizer_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List resources_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool finallyCanCompleteNormally_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCTry(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "protected")]
		public JCTry(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCTry;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getResources_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getResources_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock getFinallyBlock_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.BlockTree getFinallyBlock_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getCatches_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getCatches_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.BlockTree getBlock_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock getBlock_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;", "public static")]
	public partial class JCSynchronized
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.SynchronizedTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCSynchronized()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_0", "()Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlock_1", "()Lcom/sun/source/tree/BlockTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression @lock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCSynchronized(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCBlock;)V", "protected")]
		public JCSynchronized(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCSynchronized;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock getBlock_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.BlockTree getBlock_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;", "public static")]
	public partial class JCSwitchExpression
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression
		, Dova.JDK.com.sun.source.tree.SwitchExpressionTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCSwitchExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selector", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cases", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endpos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasTotalPattern", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "patternSwitch", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCases_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCases_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression selector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List cases_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int endpos_Property
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

		[JniSignatureAttribute("Z", "public")]
		public bool hasTotalPattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool patternSwitch_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCSwitchExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCSwitchExpression(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCSwitchExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getCases_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getCases_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCCase;", "public static")]
	public partial class JCCase
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.CaseTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCCase()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCCase;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATEMENT", "Lcom/sun/source/tree/CaseTree$CaseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RULE", "Lcom/sun/source/tree/CaseTree$CaseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "caseKind", "Lcom/sun/source/tree/CaseTree$CaseKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "labels", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stats", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completesNormally", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/tree/CaseTree$CaseKind;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabels_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabels_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatements_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatements_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpressions_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpressions_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCaseKind", "()Lcom/sun/source/tree/CaseTree$CaseKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_0", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_1", "()Lcom/sun/source/tree/Tree;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/CaseTree$CaseKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.CaseTree.CaseKind STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CaseTree.CaseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/CaseTree$CaseKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.CaseTree.CaseKind RULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CaseTree.CaseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/CaseTree$CaseKind;", "public final")]
		public Dova.JDK.com.sun.source.tree.CaseTree.CaseKind caseKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CaseTree.CaseKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List labels_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List stats_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool completesNormally_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCCase(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/CaseTree$CaseKind;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree;)V", "protected")]
		public JCCase(Dova.JDK.com.sun.source.tree.CaseTree.CaseKind arg0, Dova.JDK.com.sun.tools.javac.util.List arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCCase;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getLabels_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getLabels_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getStatements_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getStatements_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getExpressions_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getExpressions_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/CaseTree$CaseKind;", "public")]
		public Dova.JDK.com.sun.source.tree.CaseTree.CaseKind getCaseKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.CaseTree.CaseKind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getBody_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getBody_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCSwitch;", "public static")]
	public partial class JCSwitch
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.SwitchTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCSwitch()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCSwitch;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selector", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cases", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endpos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hasTotalPattern", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "patternSwitch", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCases_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCases_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression selector_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List cases_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int endpos_Property
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

		[JniSignatureAttribute("Z", "public")]
		public bool hasTotalPattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool patternSwitch_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCSwitch(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCSwitch(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCSwitch;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getCases_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getCases_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;", "public static")]
	public partial class JCLabeledStatement
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.LabeledStatementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCLabeledStatement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_0", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_1", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_0", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel_1", "()Ljavax/lang/model/element/Name;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name label_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCLabeledStatement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V", "protected")]
		public JCLabeledStatement(Dova.JDK.com.sun.tools.javac.util.Name arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCLabeledStatement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getLabel_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getLabel_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;", "public static")]
	public partial class JCEnhancedForLoop
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.EnhancedForLoopTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCEnhancedForLoop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "var", "Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "expr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_0", "()Lcom/sun/source/tree/VariableTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVariable_1", "()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_0", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_1", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl var_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression expr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCEnhancedForLoop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V", "protected")]
		public JCEnhancedForLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCEnhancedForLoop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.VariableTree getVariable_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl getVariable_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCForLoop;", "public static")]
	public partial class JCForLoop
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ForLoopTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCForLoop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCForLoop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "init", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "step", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializer_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializer_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_0", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_1", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpdate_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUpdate_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List init_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List step_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCForLoop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V", "protected")]
		public JCForLoop(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCForLoop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getInitializer_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getInitializer_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getUpdate_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getUpdate_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;", "public static")]
	public partial class JCWhileLoop
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.WhileLoopTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCWhileLoop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_0", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_1", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCWhileLoop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCStatement;)V", "protected")]
		public JCWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCWhileLoop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;", "public static")]
	public partial class JCDoWhileLoop
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.DoWhileLoopTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCDoWhileLoop()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cond", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCondition_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_0", "()Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatement_1", "()Lcom/sun/source/tree/StatementTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression cond_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCDoWhileLoop(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCStatement;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCDoWhileLoop(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCDoWhileLoop;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getCondition_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getCondition_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement getStatement_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/StatementTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.StatementTree getStatement_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.StatementTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public static")]
	public partial class JCBlock
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.BlockTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCBlock()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCBlock;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "flags", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stats", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endpos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JLcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatements_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStatements_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("J", "public")]
		public long flags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List stats_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int endpos_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCBlock(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JLcom/sun/tools/javac/util/List;)V", "protected")]
		public JCBlock(long arg0, Dova.JDK.com.sun.tools.javac.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCBlock;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isStatic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getStatements_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getStatements_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCSkip;", "public static")]
	public partial class JCSkip
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.EmptyStatementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCSkip()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCSkip;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCSkip(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "protected")]
		public JCSkip() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCSkip;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public static")]
	public partial class JCVariableDecl
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.VariableTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCVariableDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mods", "Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameexpr", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vartype", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "init", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol$VarSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "startPos", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "declaredUsingVar", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_0", "()Lcom/sun/source/tree/ModifiersTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_1", "()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_0", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType_1", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "declaredUsingVar", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializer_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInitializer_1", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameExpression_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameExpression_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isImplicitlyTyped", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers mods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression nameexpr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression vartype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression init_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$VarSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "public")]
		public int startPos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool declaredUsingVar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[7]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[7], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCVariableDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$VarSymbol;)V", "protected")]
		public JCVariableDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$VarSymbol;Z)V", "protected")]
		public JCVariableDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.com.sun.tools.javac.code.Symbol.VarSymbol arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "protected")]
		public JCVariableDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ModifiersTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ModifiersTree getModifiers_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModifiersTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers getModifiers_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool declaredUsingVar()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getInitializer_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getInitializer_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getNameExpression_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getNameExpression_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isImplicitlyTyped()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;", "public static")]
	public partial class JCMethodDecl
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.MethodTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCMethodDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mods", "Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "restype", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typarams", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "recvparam", "Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "params", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "thrown", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defaultValue", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol$MethodSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "completesNormally", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_0", "()Lcom/sun/source/tree/ModifiersTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_1", "()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReturnType_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue_0", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDefaultValue_1", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrows_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getThrows_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverParameter_0", "()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReceiverParameter_1", "()Lcom/sun/source/tree/VariableTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_0", "()Lcom/sun/source/tree/BlockTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_1", "()Lcom/sun/tools/javac/tree/JCTree$JCBlock;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers mods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression restype_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typarams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl recvparam_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List @params_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List thrown_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression defaultValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$MethodSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public")]
		public bool completesNormally_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCMethodDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCBlock;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/code/Symbol$MethodSymbol;)V", "protected")]
		public JCMethodDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg2, Dova.JDK.com.sun.tools.javac.util.List arg3, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.List arg6, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock arg7, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg8, Dova.JDK.com.sun.tools.javac.code.Symbol.MethodSymbol arg9) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCMethodDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ModifiersTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ModifiersTree getModifiers_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModifiersTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers getModifiers_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeParameters_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeParameters_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getReturnType_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getReturnType_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getDefaultValue_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getDefaultValue_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getParameters_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getParameters_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getThrows_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getThrows_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCVariableDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl getReceiverParameter_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCVariableDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/VariableTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.VariableTree getReceiverParameter_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.VariableTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/BlockTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.BlockTree getBody_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.BlockTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCBlock;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock getBody_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCBlock>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;", "public static")]
	public partial class JCClassDecl
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement
		, Dova.JDK.com.sun.source.tree.ClassTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCClassDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "mods", "Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typarams", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "extending", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementing", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "permitting", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sym", "Lcom/sun/tools/javac/code/Symbol$ClassSymbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_0", "()Lcom/sun/source/tree/ModifiersTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModifiers_1", "()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeParameters_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName_0", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName_1", "()Lcom/sun/tools/javac/util/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMembers_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMembers_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermitsClause_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermitsClause_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementsClause_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImplementsClause_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtendsClause_0", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExtendsClause_1", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers mods_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List typarams_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression extending_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List implementing_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List permitting_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List defs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$ClassSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol sym_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCClassDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCModifiers;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/code/Symbol$ClassSymbol;)V", "protected")]
		public JCClassDecl(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers arg0, Dova.JDK.com.sun.tools.javac.util.Name arg1, Dova.JDK.com.sun.tools.javac.util.List arg2, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg3, Dova.JDK.com.sun.tools.javac.util.List arg4, Dova.JDK.com.sun.tools.javac.util.List arg5, Dova.JDK.com.sun.tools.javac.util.List arg6, Dova.JDK.com.sun.tools.javac.code.Symbol.ClassSymbol arg7) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCClassDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ModifiersTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ModifiersTree getModifiers_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModifiersTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCModifiers;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers getModifiers_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModifiers>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeParameters_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeParameters_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public volatile")]
		public Dova.JDK.javax.lang.model.element.Name getSimpleName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Name;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Name getSimpleName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getMembers_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getMembers_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getPermitsClause_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getPermitsClause_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getImplementsClause_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getImplementsClause_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getExtendsClause_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getExtendsClause_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;", "public abstract static")]
	public partial class JCFunctionalExpression
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCFunctionalExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/javac/code/Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptorType", "(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/code/Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCFunctionalExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCFunctionalExpression() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCFunctionalExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Types;)Lcom/sun/tools/javac/code/Type;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Type getDescriptorType(Dova.JDK.com.sun.tools.javac.code.Types arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Type>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression;", "public abstract static")]
	public partial class JCPolyExpression
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCPolyExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "polyKind", "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStandalone", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPoly", "()Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind polyKind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCPolyExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCPolyExpression() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isStandalone()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPoly()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public static final")]
		public partial class PolyKind
			: Dova.JDK.java.lang.Enum
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static PolyKind()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STANDALONE", "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "POLY", "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
				FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
				MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind STANDALONE_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public static final")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind POLY_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "private static final")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind> VALUES_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>>(ret);
				}
				set
				{
					DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public PolyKind(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
			public PolyKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind> values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "public static")]
			public static Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind valueOf(Dova.JDK.java.lang.String arg0)
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>(ret);
			}

			[JniSignatureAttribute("()[Lcom/sun/tools/javac/tree/JCTree$JCPolyExpression$PolyKind;", "private static")]
			public static JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind> _values()
			{
				var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPolyExpression.PolyKind>>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public abstract static")]
	public partial class JCExpression
		: Dova.JDK.com.sun.tools.javac.tree.JCTree.JCCaseLabel
		, Dova.JDK.com.sun.source.tree.ExpressionTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCExpression()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCExpression;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStandalone", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPos_0", "(I)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPos_1", "(I)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPoly", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpression", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_0", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_1", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPattern", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCExpression(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCExpression() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCExpression;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isStandalone()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setPos_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression setPos_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPoly()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isExpression()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression setType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isPattern()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCCaseLabel;", "public abstract static")]
	public partial class JCCaseLabel
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.CaseLabelTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCCaseLabel()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCCaseLabel;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isExpression", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNullPattern", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPattern", "()Z"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCCaseLabel(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCCaseLabel() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCCaseLabel;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool isExpression()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isNullPattern()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public abstract")]
		public bool isPattern()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public abstract static")]
	public partial class JCStatement
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.StatementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCStatement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCStatement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPos_0", "(I)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPos_1", "(I)Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_0", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setType_1", "(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCStatement;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCStatement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public JCStatement() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCStatement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setPos_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement setPos_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree;", "public volatile")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree setType_0(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/code/Type;)Lcom/sun/tools/javac/tree/JCTree$JCStatement;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement setType_1(Dova.JDK.com.sun.tools.javac.code.Type arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCStatement>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCImport;", "public static")]
	public partial class JCImport
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.ImportTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCImport()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCImport;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "staticImport", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualid", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "importScope", "Lcom/sun/tools/javac/code/Scope;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatic", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedIdentifier_0", "()Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifiedIdentifier_1", "()Lcom/sun/tools/javac/tree/JCTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Z", "public")]
		public bool staticImport_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree qualid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope importScope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCImport(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree;Z)V", "protected")]
		public JCImport(Dova.JDK.com.sun.tools.javac.tree.JCTree arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCImport;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Z", "public")]
		public bool isStatic()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.Tree getQualifiedIdentifier_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree getQualifiedIdentifier_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;", "public static")]
	public partial class JCPackageDecl
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.PackageTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCPackageDecl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotations", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pid", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packge", "Lcom/sun/tools/javac/code/Symbol$PackageSymbol;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_0", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName_1", "()Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List annotations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression pid_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$PackageSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol packge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCPackageDecl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;Lcom/sun/tools/javac/tree/JCTree$JCExpression;)V", "public")]
		public JCPackageDecl(Dova.JDK.com.sun.tools.javac.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getPackageName_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression getPackageName_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;", "public static")]
	public partial class JCCompilationUnit
		: Dova.JDK.com.sun.tools.javac.tree.JCTree
		, Dova.JDK.com.sun.source.tree.CompilationUnitTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JCCompilationUnit()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "defs", "Lcom/sun/tools/javac/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sourcefile", "Ljavax/tools/JavaFileObject;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "modle", "Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locn", "Ljavax/tools/JavaFileManager$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packge", "Lcom/sun/tools/javac/code/Symbol$PackageSymbol;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "toplevelScope", "Lcom/sun/tools/javac/code/Scope$WriteableScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namedImportScope", "Lcom/sun/tools/javac/code/Scope$NamedImportScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "starImportScope", "Lcom/sun/tools/javac/code/Scope$StarImportScope;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lineMap", "Lcom/sun/tools/javac/util/Position$LineMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docComments", "Lcom/sun/tools/javac/tree/DocCommentTable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPositions", "Lcom/sun/tools/javac/tree/EndPosTable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModule_0", "()Lcom/sun/source/tree/ModuleTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModule_1", "()Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName", "()Lcom/sun/source/tree/ExpressionTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage_0", "()Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackage_1", "()Lcom/sun/source/tree/PackageTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTag", "()Lcom/sun/tools/javac/tree/JCTree$Tag;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleDecl", "()Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourceFile", "()Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageAnnotations_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageAnnotations_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImports_0", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getImports_1", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDecls_0", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeDecls_1", "()Lcom/sun/tools/javac/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineMap_0", "()Lcom/sun/tools/javac/util/Position$LineMap;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineMap_1", "()Lcom/sun/source/tree/LineMap;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List defs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileObject;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject sourcefile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$ModuleSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol modle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.ModuleSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileManager$Location;", "public")]
		public Dova.JDK.javax.tools.JavaFileManager.Location locn_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Symbol$PackageSymbol;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol packge_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Symbol.PackageSymbol>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$WriteableScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope toplevelScope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.WriteableScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$NamedImportScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.NamedImportScope namedImportScope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.NamedImportScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/code/Scope$StarImportScope;", "public")]
		public Dova.JDK.com.sun.tools.javac.code.Scope.StarImportScope starImportScope_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.code.Scope.StarImportScope>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Position$LineMap;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Position.LineMap lineMap_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Position.LineMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DocCommentTable;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.DocCommentTable docComments_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DocCommentTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/EndPosTable;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.EndPosTable endPositions_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.EndPosTable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JCCompilationUnit(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/util/List;)V", "protected")]
		public JCCompilationUnit(Dova.JDK.com.sun.tools.javac.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/JCTree$JCCompilationUnit;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/tree/ModuleTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.ModuleTree getModule_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl getModule_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public")]
		public Dova.JDK.com.sun.source.tree.ExpressionTree getPackageName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCPackageDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl getPackage_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCPackageDecl>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/PackageTree;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.PackageTree getPackage_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.PackageTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$Visitor;)V", "public")]
		public void accept(Dova.JDK.com.sun.tools.javac.tree.JCTree.Visitor arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$Tag;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag getTag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.Tag>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/JCTree$JCModuleDecl;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl getModuleDecl()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCModuleDecl>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/JavaFileObject;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject getSourceFile()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getPackageAnnotations_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getPackageAnnotations_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getImports_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getImports_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public volatile")]
		public Dova.JDK.java.util.List getTypeDecls_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/List;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.List getTypeDecls_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/util/Position$LineMap;", "public")]
		public Dova.JDK.com.sun.tools.javac.util.Position.LineMap getLineMap_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Position.LineMap>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/LineMap;", "public volatile")]
		public Dova.JDK.com.sun.source.tree.LineMap getLineMap_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LineMap>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}
	}
}
