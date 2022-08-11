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

[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree;", "public abstract")]
public partial class DCTree
	: Dova.JDK.java.lang.Object
	, Dova.JDK.com.sun.source.doctree.DocTree
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DCTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pos", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "pos", "(Lcom/sun/tools/javac/tree/DCTree$DCDocComment;)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDiagnosticPosition", "(Lcom/sun/tools/javac/parser/Tokens$Comment;III)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPosition", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastChild", "()Lcom/sun/tools/javac/tree/DCTree;"));
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DCTree(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DCTree() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree$DCDocComment;)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "public")]
	public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition pos(Dova.JDK.com.sun.tools.javac.tree.DCTree.DCDocComment arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getPreferredPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$Comment;III)Lcom/sun/tools/javac/util/JCDiagnostic$DiagnosticPosition;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition createDiagnosticPosition(Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic.DiagnosticPosition>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getStartPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getEndPosition()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree;", "private")]
	public Dova.JDK.com.sun.tools.javac.tree.DCTree getLastChild()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCDocComment;", "public static")]
	public partial class DCDocComment
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.DocCommentTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCDocComment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCDocComment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comment", "Lcom/sun/tools/javac/parser/Tokens$Comment;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fullBody", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "firstSentence", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tags", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preamble", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "postamble", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/parser/Tokens$Comment;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSourcePosition", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFirstSentence", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullBody", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBlockTags", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreamble", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPostamble", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/Tokens$Comment;", "public final")]
		public Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment comment_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List fullBody_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List firstSentence_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List tags_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List preamble_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List postamble_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCDocComment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/parser/Tokens$Comment;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "public")]
		public DCDocComment(Dova.JDK.com.sun.tools.javac.parser.Tokens.Comment arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5, Dova.JDK.java.util.List arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCDocComment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(I)I", "public")]
		public int getSourcePosition(int arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getFirstSentence()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getFullBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBlockTags()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getPreamble()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getPostamble()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCEndPosTree;", "public abstract static")]
	public partial class DCEndPosTree
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCEndPosTree()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCEndPosTree;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "endPos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPos", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setEndPos", "(I)Lcom/sun/tools/javac/tree/DCTree$DCEndPosTree;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int endPos_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCEndPosTree(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DCEndPosTree() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCEndPosTree;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()I", "public")]
		public int getEndPos()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/DCTree$DCEndPosTree;", "public")]
		public Dova.JDK.java.lang.Object setEndPos(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCText;", "public static")]
	public partial class DCText
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.TextTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCText()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCText;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCText(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public DCText(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCText;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCErroneous;", "public static")]
	public partial class DCErroneous
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.ErroneousTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCErroneous()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCErroneous;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "diag", "Lcom/sun/tools/javac/util/JCDiagnostic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prefPos", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPreferredPosition", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPrefPos", "(I)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPosition", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPosition", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDiagnostic", "()Ljavax/tools/Diagnostic;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic diag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int prefPos_Property
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
		public DCErroneous(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/util/JCDiagnostic;)V", "")]
		public DCErroneous(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCErroneous;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getPreferredPosition()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("(I)Lcom/sun/tools/javac/tree/DCTree$DCErroneous;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous setPrefPos(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCErroneous>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int getStartPosition()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int getEndPosition()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/Diagnostic;", "public")]
		public Dova.JDK.javax.tools.Diagnostic getDiagnostic()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.Diagnostic>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;", "public static")]
	public partial class DCIdentifier
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.IdentifierTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCIdentifier()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCIdentifier(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)V", "")]
		public DCIdentifier(Dova.JDK.javax.lang.model.element.Name arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCParam;", "public static")]
	public partial class DCParam
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.ParamTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCParam()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCParam;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isTypeParameter", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLcom/sun/tools/javac/tree/DCTree$DCIdentifier;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Lcom/sun/source/doctree/IdentifierTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTypeParameter", "()Z"));
		}

		[JniSignatureAttribute("Z", "public final")]
		public bool isTypeParameter_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCParam(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZLcom/sun/tools/javac/tree/DCTree$DCIdentifier;Ljava/util/List;)V", "")]
		public DCParam(bool arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCParam;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/doctree/IdentifierTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.IdentifierTree getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IdentifierTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isTypeParameter()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCEntity;", "public static")]
	public partial class DCEntity
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.EntityTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCEntity()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCEntity;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCEntity(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)V", "")]
		public DCEntity(Dova.JDK.javax.lang.model.element.Name arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCEntity;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCComment;", "public static")]
	public partial class DCComment
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.CommentTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCComment()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCComment;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCComment(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public DCComment(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCComment;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCAttribute;", "public static")]
	public partial class DCAttribute
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.AttributeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCAttribute()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCAttribute;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "vkind", "Lcom/sun/source/doctree/AttributeTree$ValueKind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValueKind", "()Lcom/sun/source/doctree/AttributeTree$ValueKind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/AttributeTree$ValueKind;", "public final")]
		public Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind vkind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCAttribute(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Lcom/sun/source/doctree/AttributeTree$ValueKind;Ljava/util/List;)V", "")]
		public DCAttribute(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCAttribute;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getValue()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/AttributeTree$ValueKind;", "public")]
		public Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind getValueKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.AttributeTree.ValueKind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCVersion;", "public static")]
	public partial class DCVersion
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.VersionTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCVersion()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCVersion;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCVersion(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCVersion(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCVersion;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCValue;", "public static")]
	public partial class DCValue
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.ValueTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCValue()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCValue;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ref", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/DCTree$DCReference;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "()Lcom/sun/source/doctree/ReferenceTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference @ref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCValue(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree$DCReference;)V", "")]
		public DCValue(Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCValue;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getReference()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCUses;", "public static")]
	public partial class DCUses
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.UsesTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCUses()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCUses;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceType", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceType", "()Lcom/sun/source/doctree/ReferenceTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference serviceType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCUses(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V", "")]
		public DCUses(Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCUses;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getServiceType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCUnknownInlineTag;", "public static")]
	public partial class DCUnknownInlineTag
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.UnknownInlineTagTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCUnknownInlineTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCUnknownInlineTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "content", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List content_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCUnknownInlineTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)V", "")]
		public DCUnknownInlineTag(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCUnknownInlineTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getContent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTagName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCUnknownBlockTag;", "public static")]
	public partial class DCUnknownBlockTag
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.UnknownBlockTagTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCUnknownBlockTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCUnknownBlockTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "content", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContent", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List content_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCUnknownBlockTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;)V", "")]
		public DCUnknownBlockTag(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCUnknownBlockTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getContent()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTagName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCThrows;", "public static")]
	public partial class DCThrows
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.ThrowsTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCThrows()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCThrows;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/source/doctree/DocTree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExceptionName", "()Lcom/sun/source/doctree/ReferenceTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree$Kind;", "public final")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCThrows(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V", "")]
		public DCThrows(Dova.JDK.com.sun.source.doctree.DocTree.Kind arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCThrows;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getExceptionName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSystemProperty;", "public static")]
	public partial class DCSystemProperty
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.SystemPropertyTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSystemProperty()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSystemProperty;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyName", "Ljavax/lang/model/element/Name;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyName", "()Ljavax/lang/model/element/Name;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name propertyName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSystemProperty(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)V", "")]
		public DCSystemProperty(Dova.JDK.javax.lang.model.element.Name arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSystemProperty;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getPropertyName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSummary;", "public static")]
	public partial class DCSummary
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.SummaryTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSummary()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSummary;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "summary", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSummary", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List summary_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSummary(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCSummary(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSummary;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getSummary()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCStartElement;", "public static")]
	public partial class DCStartElement
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndPosTree
		, Dova.JDK.com.sun.source.doctree.StartElementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCStartElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCStartElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attrs", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "selfClosing", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;Ljava/util/List;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSelfClosing", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List attrs_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "public final")]
		public bool selfClosing_Property
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
		public DCStartElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;Ljava/util/List;Z)V", "")]
		public DCStartElement(Dova.JDK.javax.lang.model.element.Name arg0, Dova.JDK.java.util.List arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCStartElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isSelfClosing()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSnippet;", "public static")]
	public partial class DCSnippet
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.SnippetTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSnippet()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSnippet;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "attributes", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/DCTree$DCText;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Lcom/sun/tools/javac/tree/DCTree$DCText;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAttributes", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Lcom/sun/source/doctree/TextTree;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List attributes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCText;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSnippet(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Lcom/sun/tools/javac/tree/DCTree$DCText;)V", "public")]
		public DCSnippet(Dova.JDK.java.util.List arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSnippet;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/TextTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.TextTree getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSince;", "public static")]
	public partial class DCSince
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.SinceTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSince()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSince;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSince(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCSince(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSince;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSerialField;", "public static")]
	public partial class DCSerialField
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.SerialFieldTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSerialField()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSerialField;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Lcom/sun/source/doctree/IdentifierTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getType", "()Lcom/sun/source/doctree/ReferenceTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference type_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSerialField(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree$DCIdentifier;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V", "")]
		public DCSerialField(Dova.JDK.com.sun.tools.javac.tree.DCTree.DCIdentifier arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSerialField;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/doctree/IdentifierTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.IdentifierTree getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.IdentifierTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSerialData;", "public static")]
	public partial class DCSerialData
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.SerialDataTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSerialData()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSerialData;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSerialData(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCSerialData(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSerialData;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSerial;", "public static")]
	public partial class DCSerial
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.SerialTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSerial()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSerial;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSerial(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCSerial(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSerial;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCSee;", "public static")]
	public partial class DCSee
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.SeeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCSee()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCSee;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "reference", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List reference_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCSee(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCSee(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCSee;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getReference()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReturn;", "public static")]
	public partial class DCReturn
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndPosTree
		, Dova.JDK.com.sun.source.doctree.ReturnTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCReturn()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCReturn;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "inline", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(ZLjava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isInline", "()Z"));
		}

		[JniSignatureAttribute("Z", "public final")]
		public bool inline_Property
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

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCReturn(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(ZLjava/util/List;)V", "")]
		public DCReturn(bool arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCReturn;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTagName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isInline()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public static")]
	public partial class DCReference
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndPosTree
		, Dova.JDK.com.sun.source.doctree.ReferenceTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCReference()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCReference;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signature", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleName", "Lcom/sun/tools/javac/tree/JCTree$JCExpression;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "qualifierExpression", "Lcom/sun/tools/javac/tree/JCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "memberName", "Ljavax/lang/model/element/Name;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paramTypes", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Ljavax/lang/model/element/Name;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String signature_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree$JCExpression;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression moduleName_Property
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

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/JCTree;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.JCTree qualifierExpression_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.JCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name memberName_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List paramTypes_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCReference(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/javac/tree/JCTree$JCExpression;Lcom/sun/tools/javac/tree/JCTree;Ljavax/lang/model/element/Name;Ljava/util/List;)V", "")]
		public DCReference(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.javac.tree.JCTree.JCExpression arg1, Dova.JDK.com.sun.tools.javac.tree.JCTree arg2, Dova.JDK.javax.lang.model.element.Name arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCReference;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getSignature()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCProvides;", "public static")]
	public partial class DCProvides
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.ProvidesTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCProvides()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCProvides;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serviceType", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceType", "()Lcom/sun/source/doctree/ReferenceTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference serviceType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCProvides(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V", "")]
		public DCProvides(Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCProvides;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getServiceType()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCLiteral;", "public static")]
	public partial class DCLiteral
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.LiteralTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCLiteral()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCLiteral;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/source/doctree/DocTree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Lcom/sun/tools/javac/tree/DCTree$DCText;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCText;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_0", "()Lcom/sun/tools/javac/tree/DCTree$DCText;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody_1", "()Lcom/sun/source/doctree/TextTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree$Kind;", "public final")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCText;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCLiteral(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCText;)V", "")]
		public DCLiteral(Dova.JDK.com.sun.source.doctree.DocTree.Kind arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCLiteral;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/javac/tree/DCTree$DCText;", "public")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText getBody_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCText>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/TextTree;", "public volatile")]
		public Dova.JDK.com.sun.source.doctree.TextTree getBody_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.TextTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCLink;", "public static")]
	public partial class DCLink
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.LinkTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCLink()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCLink;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "kind", "Lcom/sun/source/doctree/DocTree$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ref", "Lcom/sun/tools/javac/tree/DCTree$DCReference;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReference", "()Lcom/sun/source/doctree/ReferenceTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree$Kind;", "public final")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind kind_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCReference;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference @ref_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List label_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCLink(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree$Kind;Lcom/sun/tools/javac/tree/DCTree$DCReference;Ljava/util/List;)V", "")]
		public DCLink(Dova.JDK.com.sun.source.doctree.DocTree.Kind arg0, Dova.JDK.com.sun.tools.javac.tree.DCTree.DCReference arg1, Dova.JDK.java.util.List arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCLink;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/source/doctree/ReferenceTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.ReferenceTree getReference()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.ReferenceTree>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getLabel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCInheritDoc;", "public static")]
	public partial class DCInheritDoc
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.InheritDocTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCInheritDoc()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCInheritDoc;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCInheritDoc(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DCInheritDoc() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCInheritDoc;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCIndex;", "public static")]
	public partial class DCIndex
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.IndexTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCIndex()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCIndex;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "term", "Lcom/sun/tools/javac/tree/DCTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/tree/DCTree;Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSearchTerm", "()Lcom/sun/source/doctree/DocTree;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree;", "public final")]
		public Dova.JDK.com.sun.tools.javac.tree.DCTree term_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.tree.DCTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCIndex(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/tree/DCTree;Ljava/util/List;)V", "")]
		public DCIndex(Dova.JDK.com.sun.tools.javac.tree.DCTree arg0, Dova.JDK.java.util.List arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCIndex;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getDescription()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree getSearchTerm()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCHidden;", "public static")]
	public partial class DCHidden
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.HiddenTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCHidden()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCHidden;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCHidden(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCHidden(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCHidden;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCEndElement;", "public static")]
	public partial class DCEndElement
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndPosTree
		, Dova.JDK.com.sun.source.doctree.EndElementTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCEndElement()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCEndElement;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljavax/lang/model/element/Name;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Name;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljavax/lang/model/element/Name;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/element/Name;", "public final")]
		public Dova.JDK.javax.lang.model.element.Name name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCEndElement(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Name;)V", "")]
		public DCEndElement(Dova.JDK.javax.lang.model.element.Name arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCEndElement;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljavax/lang/model/element/Name;", "public")]
		public Dova.JDK.javax.lang.model.element.Name getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCDocType;", "public static")]
	public partial class DCDocType
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.DocTypeTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCDocType()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCDocType;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getText", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCDocType(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public DCDocType(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCDocType;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getText()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCDocRoot;", "public static")]
	public partial class DCDocRoot
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCInlineTag
		, Dova.JDK.com.sun.source.doctree.DocRootTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCDocRoot()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCDocRoot;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCDocRoot(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DCDocRoot() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCDocRoot;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCDeprecated;", "public static")]
	public partial class DCDeprecated
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.DeprecatedTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCDeprecated()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCDeprecated;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "body", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBody", "()Ljava/util/List;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List body_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCDeprecated(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCDeprecated(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCDeprecated;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getBody()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCAuthor;", "public static")]
	public partial class DCAuthor
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCBlockTag
		, Dova.JDK.com.sun.source.doctree.AuthorTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCAuthor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCAuthor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/util/List;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accept", "(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Lcom/sun/source/doctree/DocTree$Kind;"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "public final")]
		public Dova.JDK.java.util.List name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCAuthor(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;)V", "")]
		public DCAuthor(Dova.JDK.java.util.List arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCAuthor;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/List;", "public")]
		public Dova.JDK.java.util.List getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTreeVisitor;Ljava/lang/Object;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object accept(Dova.JDK.com.sun.source.doctree.DocTreeVisitor arg0, Dova.JDK.java.lang.Object arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree$Kind;", "public")]
		public Dova.JDK.com.sun.source.doctree.DocTree.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCInlineTag;", "public abstract static")]
	public partial class DCInlineTag
		: Dova.JDK.com.sun.tools.javac.tree.DCTree.DCEndPosTree
		, Dova.JDK.com.sun.source.doctree.InlineTagTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCInlineTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCInlineTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCInlineTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DCInlineTag() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCInlineTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTagName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/tree/DCTree$DCBlockTag;", "public abstract static")]
	public partial class DCBlockTag
		: Dova.JDK.com.sun.tools.javac.tree.DCTree
		, Dova.JDK.com.sun.source.doctree.BlockTagTree
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DCBlockTag()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/tree/DCTree$DCBlockTag;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTagName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DCBlockTag(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public DCBlockTag() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/tree/DCTree$DCBlockTag;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getTagName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}
}
