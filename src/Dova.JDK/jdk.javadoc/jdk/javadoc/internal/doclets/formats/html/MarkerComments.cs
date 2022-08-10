/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/MarkerComments;", "public")]
public partial class MarkerComments
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MarkerComments()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/formats/html/MarkerComments;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_TOP_NAVBAR", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "END_OF_TOP_NAVBAR", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_MODULE_DESCRIPTION", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_MODULES_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_PACKAGES_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_SERVICES_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_CLASS_DATA", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "END_OF_CLASS_DATA", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_NESTED_CLASS_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_TYPE_OPTIONAL_MEMBER_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_INTERFACE_OPTIONAL_MEMBER_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_TYPE_REQUIRED_MEMBER_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_INTERFACE_REQUIRED_MEMBER_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_CONSTRUCTOR_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ENUM_CONSTANT_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_FIELD_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_PROPERTY_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_METHOD_SUMMARY", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_TYPE_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ANNOTATION_INTERFACE_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_METHOD_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_FIELD_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_PROPERTY_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_CONSTRUCTOR_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "START_OF_ENUM_CONSTANT_DETAILS", "Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "MarkerComments", "()V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_TOP_NAVBAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment END_OF_TOP_NAVBAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_MODULE_DESCRIPTION_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_MODULES_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_PACKAGES_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_SERVICES_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_CLASS_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment END_OF_CLASS_DATA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_NESTED_CLASS_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_TYPE_OPTIONAL_MEMBER_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_INTERFACE_OPTIONAL_MEMBER_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_TYPE_REQUIRED_MEMBER_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_INTERFACE_REQUIRED_MEMBER_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_CONSTRUCTOR_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ENUM_CONSTANT_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_FIELD_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_PROPERTY_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_METHOD_SUMMARY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_TYPE_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ANNOTATION_INTERFACE_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_METHOD_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_FIELD_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_PROPERTY_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_CONSTRUCTOR_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/formats/html/markup/Comment;", "public static final")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment START_OF_ENUM_CONSTANT_DETAILS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.formats.html.markup.Comment>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[24], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MarkerComments(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public MarkerComments() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/formats/html/MarkerComments;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
}
