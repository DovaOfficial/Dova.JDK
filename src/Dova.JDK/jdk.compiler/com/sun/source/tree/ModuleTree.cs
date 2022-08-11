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

[JniSignatureAttribute("Lcom/sun/source/tree/ModuleTree;", "public abstract interface")]
public partial interface ModuleTree
	: IJavaObject
	, Dova.JDK.com.sun.source.tree.Tree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/ModuleTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Lcom/sun/source/tree/ExpressionTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnnotations", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDirectives", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModuleType", "()Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/ExpressionTree;", "public abstract")]
	Dova.JDK.com.sun.source.tree.ExpressionTree getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ExpressionTree>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getAnnotations()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getDirectives()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public abstract")]
	Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind getModuleType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public static final")]
	public partial class ModuleKind
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ModuleKind()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/source/tree/ModuleTree$ModuleKind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OPEN", "Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRONG", "Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/source/tree/ModuleTree$ModuleKind;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind OPEN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public static final")]
		public static Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind STRONG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/source/tree/ModuleTree$ModuleKind;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ModuleKind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public ModuleKind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/source/tree/ModuleTree$ModuleKind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/source/tree/ModuleTree$ModuleKind;", "public static")]
		public static Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/source/tree/ModuleTree$ModuleKind;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.source.tree.ModuleTree.ModuleKind>>(ret);
		}
	}
}
