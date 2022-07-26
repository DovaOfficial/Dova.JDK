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

namespace Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util;

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;", "public")]
public partial class DocPaths
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DocPaths()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleSeparator", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOT_DOT", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLCLASSES_INDEX", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALLPACKAGES_INDEX", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLASS_USE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_VALUES", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DEPRECATED_LIST", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DOC_FILES", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ELEMENT_LIST", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GLASS_IMG", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "HELP_DOC", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEX", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEX_ALL", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INDEX_FILES", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVASCRIPT", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CLIPBOARD_SVG", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JQUERY_OVERRIDES_CSS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JQUERY_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JQUERY_UI_CSS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JQUERY_UI_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LEGAL", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEMBER_SEARCH_INDEX_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_SEARCH_INDEX_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "NEW_LIST", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVERVIEW_SUMMARY", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OVERVIEW_TREE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_LIST", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_SEARCH_INDEX_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_SUMMARY", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_TREE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGE_USE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PREVIEW_LIST", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SCRIPT_DIR", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SYSTEM_PROPERTIES", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RESOURCES", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEARCH_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SEARCH_JS_TEMPLATE", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SERIALIZED_FORM", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SOURCE_OUTPUT", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STYLESHEET", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAG_SEARCH_INDEX_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPE_SEARCH_INDEX_JS", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "X_IMG", "Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forName", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forRoot", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forPackage", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forPackage", "(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "forModule", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "indexN", "(I)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relativePath", "(Ljavax/lang/model/element/PackageElement;Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleDocFiles", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleSummary", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleSummary", "(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createModulePath", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createModulePath", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "forClass", "(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String moduleSeparator_Property
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath DOT_DOT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath ALLCLASSES_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath ALLPACKAGES_INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath CLASS_USE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath CONSTANT_VALUES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath DEPRECATED_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath DOC_FILES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath ELEMENT_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath GLASS_IMG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath HELP_DOC_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath INDEX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath INDEX_ALL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath INDEX_FILES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath JAVASCRIPT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath CLIPBOARD_SVG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath JQUERY_OVERRIDES_CSS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath JQUERY_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath JQUERY_UI_CSS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath JQUERY_UI_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath LEGAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath MEMBER_SEARCH_INDEX_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath MODULE_SEARCH_INDEX_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath NEW_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath OVERVIEW_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath OVERVIEW_TREE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PACKAGE_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PACKAGE_SEARCH_INDEX_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PACKAGE_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PACKAGE_TREE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[30]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[30], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PACKAGE_USE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[31]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[31], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath PREVIEW_LIST_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[32]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[32], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SCRIPT_DIR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[33]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[33], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SYSTEM_PROPERTIES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[34]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[34], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath RESOURCES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[35]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[35], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SEARCH_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[36]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[36], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SEARCH_JS_TEMPLATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[37]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[37], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SERIALIZED_FORM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[38]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[38], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath SOURCE_OUTPUT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[39]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[39], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath STYLESHEET_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[40]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[40], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath TAG_SEARCH_INDEX_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[41]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[41], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath TYPE_SEARCH_INDEX_JS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[42]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[42], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath X_IMG_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[43]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[43], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DocPaths(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V", "public")]
	public DocPaths(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/DocPaths;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forName(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forRoot(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forPackage(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forPackage(Dova.JDK.javax.lang.model.element.PackageElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forModule(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(I)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath indexN(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljavax/lang/model/element/PackageElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath relativePath(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.javax.lang.model.element.PackageElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath moduleDocFiles(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath moduleSummary(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath moduleSummary(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath createModulePath(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "private")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath createModulePath(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath forClass(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath>(ret);
	}
}
