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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.formats.html;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
public partial class HtmlLinkInfo
	: Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.links.LinkInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HtmlLinkInfo()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "where", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "targetMember", "Ljavax/lang/model/element/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/type/TypeMirror;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContext", "()Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "label", "(Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "label", "(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "style", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "includeTypeParameterLinks", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "targetMember", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "skipPreview", "(Z)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newContent", "()Ljdk/javadoc/internal/doclets/toolkit/Content;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "varargs", "(Z)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContext", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "where", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLinkable", "()Z"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind context_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String where_Property
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

	[JniSignatureAttribute("Ljavax/lang/model/element/Element;", "public")]
	public Dova.JDK.javax.lang.model.element.Element targetMember_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle style_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "public final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlLinkInfo(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/type/TypeMirror;)V", "public")]
	public HtmlLinkInfo(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg1, Dova.JDK.javax.lang.model.type.TypeMirror arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/TypeElement;)V", "public")]
	public HtmlLinkInfo(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg1, Dova.JDK.javax.lang.model.element.TypeElement arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;Ljavax/lang/model/element/ExecutableElement;)V", "public")]
	public HtmlLinkInfo(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg1, Dova.JDK.javax.lang.model.element.ExecutableElement arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind getContext()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo label(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/Content;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo label(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlStyle;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo style(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool includeTypeParameterLinks()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5]);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo targetMember(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo skipPreview(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/Content;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content newContent()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.Content>(ret);
	}

	[JniSignatureAttribute("(Z)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo varargs(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;)V", "public final")]
	public void setContext(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo where(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLinkable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
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
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEFAULT", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEMBER", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEMBER_DEPRECATED_PREVIEW", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_USE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEX", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIALIZED_FORM", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIAL_MEMBER", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEE_TAG", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "VALUE_TAG", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TREE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_HEADER", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_SIGNATURE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RETURN_TYPE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUMMARY_RETURN_TYPE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXECUTABLE_MEMBER_PARAM", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUPER_INTERFACES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLEMENTED_INTERFACES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IMPLEMENTED_CLASSES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBINTERFACES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SUBCLASSES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_SIGNATURE_PARENT_NAME", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PERMITTED_SUBCLASSES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXECUTABLE_ELEMENT_COPY", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_SPECIFIED_BY", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_OVERRIDES", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_TREE_PARENT", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEMBER_TYPE_PARAMS", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_USE_HEADER", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY_COPY", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECEIVER_TYPE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RECORD_COMPONENT", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "THROWS_TYPE", "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind DEFAULT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind MEMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind MEMBER_DEPRECATED_PREVIEW_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_USE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind INDEX_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CONSTANT_SUMMARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SERIALIZED_FORM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SERIAL_MEMBER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SEE_TAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind VALUE_TAG_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind TREE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_HEADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_SIGNATURE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind RETURN_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SUMMARY_RETURN_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind EXECUTABLE_MEMBER_PARAM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SUPER_INTERFACES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind IMPLEMENTED_INTERFACES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind IMPLEMENTED_CLASSES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SUBINTERFACES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind SUBCLASSES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_SIGNATURE_PARENT_NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind PERMITTED_SUBCLASSES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind EXECUTABLE_ELEMENT_COPY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind METHOD_SPECIFIED_BY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind METHOD_OVERRIDES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind ANNOTATION_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_TREE_PARENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind MEMBER_TYPE_PARAMS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind CLASS_USE_HEADER_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind PROPERTY_COPY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind RECEIVER_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind RECORD_COMPONENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind THROWS_TYPE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Kind(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Kind(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/formats/html/HtmlLinkInfo$Kind;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlLinkInfo.Kind>>(ret);
		}
	}
}
