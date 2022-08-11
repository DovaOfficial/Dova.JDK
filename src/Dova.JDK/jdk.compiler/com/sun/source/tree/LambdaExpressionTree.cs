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

namespace Dova.JDK.com.sun.source.tree;

[JniSignatureAttribute("Lcom/sun/source/tree/LambdaExpressionTree;", "public abstract interface")]
public partial interface LambdaExpressionTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.ExpressionTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LambdaExpressionTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/LambdaExpressionTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParameters", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBodyKind", "()Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Lcom/sun/source/tree/Tree;"));
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getParameters()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public abstract")]
	Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind getBodyKind()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/Tree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.Tree getBody()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public static final")]
	public partial class BodyKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BodyKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXPRESSION", "Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STATEMENT", "Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind EXPRESSION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind STATEMENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BodyKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public BodyKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "public static")]
		public static Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/source/tree/LambdaExpressionTree$BodyKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.LambdaExpressionTree.BodyKind>>(ret);
		}
	}
}
