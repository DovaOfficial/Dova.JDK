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

namespace Dova.JDK.com.sun.tools.javac.parser;

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ReferenceParser;", "public")]
public partial class ReferenceParser
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ReferenceParser()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/ReferenceParser;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fac", "Lcom/sun/tools/javac/parser/ParserFactory;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/ParserFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/ReferenceParser$Reference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseType", "(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/tree/JCTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseParams", "(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDiags", "(Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseModule", "(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseMember", "(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/util/Name;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ParserFactory;", "private final")]
	public Dova.JDK.com.sun.tools.javac.parser.ParserFactory fac_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ParserFactory>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ReferenceParser(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/ParserFactory;)V", "public")]
	public ReferenceParser(Dova.JDK.com.sun.tools.javac.parser.ParserFactory arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/ReferenceParser;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/ReferenceParser$Reference;", "public")]
	public Dova.JDK.com.sun.tools.javac.parser.ReferenceParser.Reference parse(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.ReferenceParser.Reference>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/tree/JCTree;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree parseType(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/util/List;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.List parseParams(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;I)V", "private")]
	public void checkDiags(Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression parseModule(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;IILcom/sun/tools/javac/util/Log$DeferredDiagnosticHandler;)Lcom/sun/tools/javac/util/Name;", "private")]
	public Dova.JDK.com.sun.tools.javac.util.Name parseMember(Dova.JDK.java.lang.String arg0, int arg1, int arg2, Dova.JDK.com.sun.tools.javac.util.Log.DeferredDiagnosticHandler arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.Name>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ReferenceParser$ParseException;", "public static")]
	public partial class ParseException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ParseException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/ReferenceParser$ParseException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ILjava/lang/String;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int pos_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ParseException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ILjava/lang/String;)V", "")]
		public ParseException(int arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/ReferenceParser$ParseException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ReferenceParser$Reference;", "public static")]
	public partial class Reference
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Reference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/ReferenceParser$Reference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleName", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualExpr", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "member", "Lcom/sun/tools/javac/util/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paramTypes", "Lcom/sun/tools/javac/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression moduleName_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree qualExpr_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/Name;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.Name member_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/List;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.List paramTypes_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Reference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Lcom/sun/tools/javac/util/Name;Lcom/sun/tools/javac/util/List;)V", "")]
		public Reference(Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree arg1, Dova.JDK.com.sun.tools.javac.util.Name arg2, Dova.JDK.com.sun.tools.javac.util.List arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/ReferenceParser$Reference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/ReferenceParser$TypeAnnotationFinder;", "static")]
	public partial class TypeAnnotationFinder
		: Dova.JDK.com.sun.source.util.TreeScanner
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TypeAnnotationFinder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/ReferenceParser$TypeAnnotationFinder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "reduce", "(Lcom/sun/source/tree/Tree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/tree/Tree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitAnnotatedType", "(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Void;)Lcom/sun/source/tree/Tree;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TypeAnnotationFinder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public TypeAnnotationFinder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/ReferenceParser$TypeAnnotationFinder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object reduce(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/Tree;Lcom/sun/source/tree/Tree;)Lcom/sun/source/tree/Tree;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree reduce(Dova.JDK.com.sun.source.tree.Tree arg0, Dova.JDK.com.sun.source.tree.Tree arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object visitAnnotatedType(Dova.JDK.com.sun.source.tree.AnnotatedTypeTree arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/tree/AnnotatedTypeTree;Ljava/lang/Void;)Lcom/sun/source/tree/Tree;", "public")]
		public Dova.JDK.com.sun.source.tree.Tree visitAnnotatedType(Dova.JDK.com.sun.source.tree.AnnotatedTypeTree arg0, Dova.JDK.java.lang.Void arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.tree.Tree>(ret);
		}
	}
}
