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

[JniSignatureAttribute("Lcom/sun/tools/javac/parser/TextBlockSupport;", "")]
public partial class TextBlockSupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static TextBlockSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/TextBlockSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexOfNonWhitespace", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkWhitespace", "(Ljava/lang/String;)Ljava/util/Set;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public TextBlockSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public TextBlockSupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/TextBlockSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)I", "private static")]
	public static int indexOfNonWhitespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set checkWhitespace(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "static final")]
	public partial class WhitespaceChecks
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WhitespaceChecks()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INCONSISTENT", "Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TRAILING", "Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks INCONSISTENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "public static final")]
		public static Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks TRAILING_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WhitespaceChecks(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public WhitespaceChecks(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "public static")]
		public static Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/javac/parser/TextBlockSupport$WhitespaceChecks;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.javac.parser.TextBlockSupport.WhitespaceChecks>>(ret);
		}
	}
}
