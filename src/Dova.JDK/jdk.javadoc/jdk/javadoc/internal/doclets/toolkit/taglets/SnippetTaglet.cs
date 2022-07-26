/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:58)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet;", "public")]
public partial class SnippetTaglet
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.BaseTaglet
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SnippetTaglet()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "packageName", "(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "error", "(Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljava/lang/String;[Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljdk/javadoc/internal/doclets/toolkit/Resources;Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Diags;Ljava/util/Optional;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "diff", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPackageElement", "(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInlineTagOutput", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringValueOf", "(Lcom/sun/source/doctree/AttributeTree;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "languageFromFileName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "generateContent", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "badSnippet", "(Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljava/util/Optional;)Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toDisplayForm", "(Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;)Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;"));
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SnippetTaglet(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SnippetTaglet() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String packageName(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljava/lang/String;[Ljava/lang/Object;)V", "private transient")]
	public void error(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.com.sun.source.doctree.DocTree arg2, Dova.JDK.java.lang.String arg3, JavaArray<Dova.JDK.java.lang.Object> arg4)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Resources;Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Diags;Ljava/util/Optional;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText parse(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Resources arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Diags arg1, Dova.JDK.java.util.Optional arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String diff(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljavax/lang/model/element/PackageElement;", "private static")]
	public static Dova.JDK.javax.lang.model.element.PackageElement getPackageElement(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content getInlineTagOutput(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/AttributeTree;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String stringValueOf(Dova.JDK.com.sun.source.doctree.AttributeTree arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String languageFromFileName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content generateContent(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/taglets/TagletWriter;Ljava/util/Optional;)Ljdk/javadoc/internal/doclets/toolkit/Content;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content badSnippet(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.TagletWriter arg0, Dova.JDK.java.util.Optional arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;)Ljdk/javadoc/internal/doclets/toolkit/taglets/snippet/StyledText;", "private static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText toDisplayForm(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.snippet.StyledText>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$BadSnippetException;", "private static final")]
	public partial class BadSnippetException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BadSnippetException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$BadSnippetException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tag", "Lcom/sun/source/doctree/DocTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "args", "[Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/source/doctree/DocTree;Ljava/lang/String;[Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "args", "()[Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "key", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "tag", "()Lcom/sun/source/doctree/DocTree;"));
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

		[JniSignatureAttribute("Lcom/sun/source/doctree/DocTree;", "private final transient")]
		public Dova.JDK.com.sun.source.doctree.DocTree tag_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/lang/Object;", "private final transient")]
		public JavaArray<Dova.JDK.java.lang.Object> args_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BadSnippetException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;Ljava/lang/String;[Ljava/lang/Object;)V", "transient")]
		public BadSnippetException(Dova.JDK.com.sun.source.doctree.DocTree arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.lang.Object> arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$BadSnippetException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/lang/Object;", "")]
		public JavaArray<Dova.JDK.java.lang.Object> args()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String key()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree;", "")]
		public Dova.JDK.com.sun.source.doctree.DocTree tag()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "public static final")]
	public partial class Language
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Language()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA", "Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTIES", "Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "languages", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "identifier", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;ILjava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIdentifier", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language JAVA_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language PROPERTIES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map languages_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String identifier_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Language(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/lang/String;)V", "private")]
		public Language(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public static")]
		public static Dova.JDK.java.util.Optional of(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Language;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.taglets.SnippetTaglet.Language>>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getIdentifier()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Diags;", "public abstract static interface")]
	public partial interface Diags
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Diags()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/taglets/SnippetTaglet$Diags;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "warn", "(Ljava/lang/String;I)V"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "public abstract")]
		void warn(Dova.JDK.java.lang.String arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		}
	}
}
