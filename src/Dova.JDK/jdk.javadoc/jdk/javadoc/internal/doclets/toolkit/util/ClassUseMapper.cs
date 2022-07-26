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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;", "public")]
public partial class ClassUseMapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassUseMapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classtree", "Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToPackage", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToPackageAnnotations", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToClass", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToSubclass", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToSubinterface", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToImplementingClass", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToField", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodReturn", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodArgs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodThrows", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToConstructorArgs", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToConstructorThrows", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToConstructorAnnotations", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToConstructorParamAnnotation", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToConstructorArgTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToClassTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToClassAnnotations", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodArgTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodAnnotations", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodReturnTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToMethodParamAnnotation", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classToFieldTypeParam", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "annotationToField", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "docEnv", "Ljdk/javadoc/doclet/DocletEnvironment;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "elementUtils", "Ljavax/lang/model/util/Elements;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeUtils", "Ljavax/lang/model/util/Types;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comparators", "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addAll", "(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implementingClasses", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "packageSet", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subclasses", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subinterfaces", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTypeParameterToMap", "(Ljava/util/Map;Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapTypeParameters", "(Ljava/util/Map;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapTypeParameters", "(Ljava/util/Map;Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapExecutable", "(Ljavax/lang/model/element/ExecutableElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classSet", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "refList", "(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mapAnnotations", "(Ljava/util/Map;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)V"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree classtree_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToPackage_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToPackageAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToSubclass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToSubinterface_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map classToImplementingClass_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodReturn_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodThrows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToConstructorArgs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToConstructorThrows_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToConstructorAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToConstructorParamAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToConstructorArgTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToClassTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToClassAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodArgTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodAnnotations_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodReturnTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToMethodParamAnnotation_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map classToFieldTypeParam_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "public final")]
	public Dova.JDK.java.util.Map annotationToField_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[24]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[24], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/doclet/DocletEnvironment;", "private final")]
	public Dova.JDK.jdk.javadoc.doclet.DocletEnvironment docEnv_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[25]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.doclet.DocletEnvironment>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[25], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "private final")]
	public Dova.JDK.javax.lang.model.util.Elements elementUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[26]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[26], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Types;", "private final")]
	public Dova.JDK.javax.lang.model.util.Types typeUtils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[27]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Types>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[27], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[28]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[28], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators comparators_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[29]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[29], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassUseMapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;)V", "public")]
	public ClassUseMapper(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.ClassTree arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/ClassUseMapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/Element;)V", "private")]
	public void add(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljava/util/Collection;)V", "private")]
	public void addAll(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.java.util.Collection arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection implementingClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set packageSet(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection subclasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Collection;", "private")]
	public Dova.JDK.java.util.Collection subinterfaces(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/element/Element;)V", "private")]
	public void addTypeParameterToMap(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)V", "private")]
	public void mapTypeParameters(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/type/TypeMirror;Ljavax/lang/model/element/Element;)V", "private")]
	public void mapTypeParameters(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.type.TypeMirror arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)V", "private")]
	public void mapExecutable(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/Set;", "private")]
	public Dova.JDK.java.util.Set classSet(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List refList(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)V", "private")]
	public void mapAnnotations(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.Element arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}
}
