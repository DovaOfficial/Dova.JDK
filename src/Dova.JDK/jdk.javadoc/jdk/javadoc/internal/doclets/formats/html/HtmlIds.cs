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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;", "public")]
public partial class HtmlIds
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HtmlIds()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_CLASSES_TABLE", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_MODULES_TABLE", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_PACKAGES_TABLE", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_TYPE_ELEMENT_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_TYPE_OPTIONAL_ELEMENT_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ANNOTATION_TYPE_REQUIRED_ELEMENT_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_DESCRIPTION", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTRUCTOR_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_CONSTANT_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_CONSTANT_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FOR_REMOVAL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_NAVIGATION", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_PAGES", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_SEARCH", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHOD_SUMMARY_TABLE", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULES", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_DESCRIPTION", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAVBAR_SUB_LIST", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAVBAR_TOGGLE_BUTTON", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAVBAR_TOP", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NAVBAR_TOP_FIRSTROW", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NESTED_CLASS_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGES", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_DESCRIPTION", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_SUMMARY_TABLE", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY_DETAIL", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTY_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RELATED_PACKAGE_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESET_BUTTON", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEARCH_INPUT", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERVICES", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SKIP_NAVBAR_TOP", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNNAMED_PACKAGE_ANCHOR", "Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ENUM_CONSTANTS_INHERITANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELDS_INHERITANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "METHODS_INHERITANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NESTED_CLASSES_INHERITANCE", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PROPERTIES_INHERITANCE", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forProperty", "(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forPackage", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forMemberSummary", "(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forPreviewSection", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forTabPanel", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forPage", "(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forIndexChar", "(C)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forLine", "(I)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forParam", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forText", "(Ljava/lang/String;Ljava/util/Map;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInheritedClasses", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInheritedFields", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInheritedEnumConstants", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInheritedMethods", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInheritedProperties", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forErasure", "(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forInherited", "(Ljava/lang/String;Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forSummaryKind", "(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forTab", "(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;I)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forMember", "(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forMember", "(Ljavax/lang/model/element/VariableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forMember", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forMember", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/VariableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forClass", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;", "private final")]
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ALL_CLASSES_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ALL_MODULES_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ALL_PACKAGES_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ANNOTATION_TYPE_ELEMENT_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ANNOTATION_TYPE_OPTIONAL_ELEMENT_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ANNOTATION_TYPE_REQUIRED_ELEMENT_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId CLASS_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId CLASS_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId CONSTRUCTOR_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId CONSTRUCTOR_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ENUM_CONSTANT_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId ENUM_CONSTANT_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId FIELD_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId FIELD_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId FOR_REMOVAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId HELP_NAVIGATION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId HELP_PAGES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId HELP_SEARCH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId METHOD_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId METHOD_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId METHOD_SUMMARY_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId MODULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId MODULE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId NAVBAR_SUB_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId NAVBAR_TOGGLE_BUTTON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId NAVBAR_TOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId NAVBAR_TOP_FIRSTROW_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId NESTED_CLASS_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId PACKAGES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId PACKAGE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId PACKAGE_SUMMARY_TABLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId PROPERTY_DETAIL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId PROPERTY_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId RELATED_PACKAGE_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId RESET_BUTTON_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId SEARCH_INPUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId SERVICES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId SKIP_NAVBAR_TOP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId UNNAMED_PACKAGE_ANCHOR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String ENUM_CONSTANTS_INHERITANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String FIELDS_INHERITANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String METHODS_INHERITANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String NESTED_CLASSES_INHERITANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[44]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[44], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String PROPERTIES_INHERITANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[45]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[45], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public HtmlIds(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/HtmlConfiguration;)V", "")]
	public HtmlIds(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.HtmlConfiguration arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/HtmlIds;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forProperty(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/VisibleMemberTable$Kind;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forMemberSummary(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.VisibleMemberTable.Kind arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forPreviewSection(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forTabPanel(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/Navigation$PageMode;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forPage(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.Navigation.PageMode arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(C)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forIndexChar(char arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forLine(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forParam(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forText(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInheritedClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInheritedFields(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInheritedEnumConstants(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInheritedMethods(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInheritedProperties(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forErasure(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forInherited(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/SummaryAPIListBuilder$SummaryElementKind;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forSummaryKind(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.SummaryAPIListBuilder.SummaryElementKind arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;I)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forTab(Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forMember(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/VariableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forMember(Dova.JDK.javax.lang.model.element.VariableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/ExecutableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forMember(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/VariableElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forMember(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.VariableElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/formats/html/markup/HtmlId;", "")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId forClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.HtmlId>(ret);
	}
}
