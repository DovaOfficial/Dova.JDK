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

[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree;", "public abstract interface")]
public partial interface MemberReferenceTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.ExpressionTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MemberReferenceTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/MemberReferenceTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getQualifierExpression", "()Lcom/sun/source/tree/ExpressionTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMode", "()Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeArguments", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public abstract")]
	Dova.JDK.javax.lang.model.element.Name getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.ExpressionTree getQualifierExpression()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public abstract")]
	Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode getMode()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getTypeArguments()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public static final")]
	public partial class ReferenceMode
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReferenceMode()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INVOKE", "Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW", "Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode INVOKE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode NEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReferenceMode(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ReferenceMode(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "public static")]
		public static Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/source/tree/MemberReferenceTree$ReferenceMode;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.MemberReferenceTree.ReferenceMode>>(ret);
		}
	}
}
