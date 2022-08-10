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

namespace Dova.JDK.com.sun.source.tree;

[JniSignatureAttribute("Lcom/sun/source/tree/Tree;", "public abstract interface")]
public partial interface Tree
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Tree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/Tree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accept", "(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getKind", "()Lcom/sun/source/tree/Tree$Kind;"));
	}

	[JniSignatureAttribute("(Lcom/sun/source/tree/TreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public abstract")]
	Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.tree.TreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/Tree$Kind;", "public abstract")]
	Dova.JDK.com.sun.source.tree.Tree.Kind getKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
	public partial class Kind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Kind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/Tree$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ANNOTATED_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ANNOTATION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_ANNOTATION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARRAY_ACCESS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ARRAY_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ASSERT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BLOCK", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BREAK", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CASE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CATCH", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "COMPILATION_UNIT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONDITIONAL_EXPRESSION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONTINUE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DO_WHILE_LOOP", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENHANCED_FOR_LOOP", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPRESSION_STATEMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEMBER_SELECT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MEMBER_REFERENCE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FOR_LOOP", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IDENTIFIER", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IF", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IMPORT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INSTANCE_OF", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LABELED_STATEMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "METHOD_INVOCATION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODIFIERS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEW_ARRAY", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NEW_CLASS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LAMBDA_EXPRESSION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKAGE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARENTHESIZED", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BINDING_PATTERN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GUARDED_PATTERN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARENTHESIZED_PATTERN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DEFAULT_CASE_LABEL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PRIMITIVE_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RETURN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EMPTY_STATEMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SWITCH", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SWITCH_EXPRESSION", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SYNCHRONIZED", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "THROW", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TRY", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PARAMETERIZED_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNION_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERSECTION_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_CAST", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_PARAMETER", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VARIABLE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WHILE_LOOP", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "POSTFIX_INCREMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "POSTFIX_DECREMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREFIX_INCREMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PREFIX_DECREMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNARY_PLUS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNARY_MINUS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BITWISE_COMPLEMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LOGICAL_COMPLEMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MULTIPLY", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIVIDE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REMAINDER", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PLUS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MINUS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_SHIFT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_SHIFT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNSIGNED_RIGHT_SHIFT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LESS_THAN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GREATER_THAN", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LESS_THAN_EQUAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "GREATER_THAN_EQUAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EQUAL_TO", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_EQUAL_TO", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "AND", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "XOR", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OR", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONDITIONAL_AND", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CONDITIONAL_OR", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MULTIPLY_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DIVIDE_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REMAINDER_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PLUS_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MINUS_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LEFT_SHIFT_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RIGHT_SHIFT_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNSIGNED_RIGHT_SHIFT_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "AND_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "XOR_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OR_ASSIGNMENT", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INT_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "LONG_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "FLOAT_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "DOUBLE_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "BOOLEAN_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CHAR_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STRING_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NULL_LITERAL", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "UNBOUNDED_WILDCARD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXTENDS_WILDCARD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUPER_WILDCARD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ERRONEOUS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "INTERFACE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ENUM", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ANNOTATION_TYPE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULE", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPORTS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OPENS", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PROVIDES", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "RECORD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REQUIRES", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "USES", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "OTHER", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "YIELD", "Lcom/sun/source/tree/Tree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "associatedInterface", "Ljava/lang/Class;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/source/tree/Tree$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Kind", "(Ljava/lang/String;ILjava/lang/Class;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/source/tree/Tree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asInterface", "()Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ANNOTATED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind TYPE_ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ARRAY_ACCESS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ARRAY_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ASSERT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind BLOCK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind BREAK_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CASE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CATCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind COMPILATION_UNIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CONDITIONAL_EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CONTINUE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind DO_WHILE_LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ENHANCED_FOR_LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind EXPRESSION_STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MEMBER_SELECT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MEMBER_REFERENCE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind FOR_LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind IDENTIFIER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind IF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind IMPORT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind INSTANCE_OF_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LABELED_STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind METHOD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind METHOD_INVOCATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MODIFIERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind NEW_ARRAY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind NEW_CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LAMBDA_EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PARENTHESIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind BINDING_PATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind GUARDED_PATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PARENTHESIZED_PATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind DEFAULT_CASE_LABEL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PRIMITIVE_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind RETURN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind EMPTY_STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind SWITCH_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind SWITCH_EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind SYNCHRONIZED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind THROW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind TRY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PARAMETERIZED_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[46]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[46], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNION_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[47]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[47], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind INTERSECTION_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[48]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[48], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind TYPE_CAST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[49]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[49], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind TYPE_PARAMETER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[50]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[50], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind VARIABLE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[51]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[51], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind WHILE_LOOP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[52]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[52], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind POSTFIX_INCREMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[53]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[53], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind POSTFIX_DECREMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[54]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[54], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PREFIX_INCREMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[55]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[55], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PREFIX_DECREMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[56]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[56], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNARY_PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[57]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[57], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNARY_MINUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[58]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[58], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind BITWISE_COMPLEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[59]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[59], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LOGICAL_COMPLEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[60]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[60], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MULTIPLY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[61]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[61], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind DIVIDE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[62]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[62], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind REMAINDER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[63]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[63], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PLUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[64]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[64], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MINUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[65]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[65], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LEFT_SHIFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[66]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[66], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind RIGHT_SHIFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[67]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[67], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNSIGNED_RIGHT_SHIFT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[68]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[68], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LESS_THAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[69]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[69], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind GREATER_THAN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[70]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[70], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LESS_THAN_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[71]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[71], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind GREATER_THAN_EQUAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[72]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[72], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind EQUAL_TO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[73]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[73], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind NOT_EQUAL_TO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[74]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[74], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind AND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[75]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[75], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind XOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[76]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[76], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind OR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[77]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[77], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CONDITIONAL_AND_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[78]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[78], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CONDITIONAL_OR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[79]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[79], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MULTIPLY_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[80]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[80], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind DIVIDE_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[81]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[81], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind REMAINDER_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[82]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[82], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PLUS_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[83]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[83], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MINUS_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[84]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[84], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LEFT_SHIFT_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[85]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[85], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind RIGHT_SHIFT_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[86]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[86], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNSIGNED_RIGHT_SHIFT_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[87]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[87], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind AND_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[88]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[88], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind XOR_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[89]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[89], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind OR_ASSIGNMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[90]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[90], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind INT_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[91]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[91], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind LONG_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[92]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[92], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind FLOAT_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[93]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[93], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind DOUBLE_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[94]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[94], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind BOOLEAN_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[95]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[95], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind CHAR_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[96]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[96], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind STRING_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[97]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[97], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind NULL_LITERAL_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[98]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[98], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind UNBOUNDED_WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[99]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[99], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind EXTENDS_WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[100]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[100], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind SUPER_WILDCARD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[101]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[101], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ERRONEOUS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[102]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[102], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind INTERFACE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[103]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[103], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ENUM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[104]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[104], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind ANNOTATION_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[105]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[105], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind MODULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[106]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[106], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind EXPORTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[107]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[107], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind OPENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[108]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[108], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind PROVIDES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[109]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[109], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind RECORD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[110]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[110], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind REQUIRES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[111]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[111], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind USES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[112]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[112], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind OTHER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[113]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[113], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/Tree$Kind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind YIELD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[114]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[114], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/Class;", "private final")]
		public Dova.JDK.java.lang.Class associatedInterface_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[115]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[115], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/source/tree/Tree$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[116]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[116], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/Class;)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.Class arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/source/tree/Tree$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/source/tree/Tree$Kind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/tree/Tree$Kind;", "public static")]
		public static Dova.JDK.com.sun.source.tree.Tree.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree.Kind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/source/tree/Tree$Kind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.Tree.Kind>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Class;", "public")]
		public Dova.JDK.java.lang.Class asInterface()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}
}
