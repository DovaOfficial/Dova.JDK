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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public")]
public partial class IndexItem
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IndexItem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "label", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "element", "Ljavax/lang/model/element/Element;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "url", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "containingModule", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "containingPackage", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "containingClass", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/lang/model/element/Element;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljavax/lang/model/element/ModuleElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSimpleName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getElement", "()Ljavax/lang/model/element/Element;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescription", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUrl", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isKind", "(Lcom/sun/source/doctree/DocTree$Kind;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setUrl", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullyQualifiedLabel", "(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContainingModule", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getContainingTypeElement", "()Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHolder", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContainingClass", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toJSON", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDocTree", "()Lcom/sun/source/doctree/DocTree;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setContainingPackage", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isElementItem", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTagItem", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLabel", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCategory", "(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCategory", "(Lcom/sun/source/doctree/DocTree;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCategory", "()Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private final")]
	public Dova.JDK.java.lang.String label_Property
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

	[JniSignatureAttribute("Ljavax/lang/model/element/Element;", "private final")]
	public Dova.JDK.javax.lang.model.element.Element element_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String url_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String containingModule_Property
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

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String containingPackage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String containingClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IndexItem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;Ljava/lang/String;)V", "private")]
	public IndexItem(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljava/lang/String;)V", "private")]
	public IndexItem(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Lcom/sun/source/doctree/DocTree;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/util/DocLink;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.com.sun.source.doctree.DocTree arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.java.lang.String arg4, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocLink arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;Ljava/lang/String;Ljdk/javadoc/internal/doclets/toolkit/util/DocPath;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.DocPath arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/PackageElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.javax.lang.model.element.PackageElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public static")]
	public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem of(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getSimpleName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/Element;", "public")]
	public Dova.JDK.javax.lang.model.element.Element getElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Element>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getDescription()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getUrl()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree$Kind;)Z", "public")]
	public bool isKind(Dova.JDK.com.sun.source.doctree.DocTree.Kind arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem setUrl(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getFullyQualifiedLabel(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem setContainingModule(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("()Ljavax/lang/model/element/TypeElement;", "public")]
	public Dova.JDK.javax.lang.model.element.TypeElement getContainingTypeElement()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getHolder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem setContainingClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toJSON()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/source/doctree/DocTree;", "public")]
	public Dova.JDK.com.sun.source.doctree.DocTree getDocTree()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.doctree.DocTree>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem setContainingPackage(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isElementItem()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isTagItem()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getLabel()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category getCategory(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/doctree/DocTree;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "protected")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category getCategory(Dova.JDK.com.sun.source.doctree.DocTree arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
	}

	[JniSignatureAttribute("()Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category getCategory()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
	public partial class Category
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Category()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULES", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PACKAGES", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TYPES", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEMBERS", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TAGS", "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category MODULES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category PACKAGES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category TYPES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category MEMBERS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static final")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category TAGS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "private static final")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Category(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Category(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "public static")]
		public static Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>(ret);
		}

		[JniSignatureAttribute("()[Ljdk/javadoc/internal/doclets/toolkit/util/IndexItem$Category;", "private static")]
		public static JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.IndexItem.Category>>(ret);
		}
	}
}
