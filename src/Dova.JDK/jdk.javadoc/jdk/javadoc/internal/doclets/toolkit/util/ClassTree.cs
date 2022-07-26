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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;", "public")]
public partial class ClassTree
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassTree()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseClasses", "Ljava/util/SortedSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subClasses", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseInterfaces", "Ljava/util/SortedSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subInterfaces", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseEnums", "Ljava/util/SortedSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subEnums", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseAnnotationTypes", "Ljava/util/SortedSet;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subAnnotationTypes", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "implementingClasses", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "configuration", "Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "comparator", "Ljava/util/Comparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/SortedSet;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/doclet/DocletEnvironment;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subClasses", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subInterfaces", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implementingClasses", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseAnnotationTypes", "()Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseEnums", "()Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseClasses", "()Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "baseInterfaces", "()Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processType", "(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljava/util/Collection;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "processInterface", "(Ljavax/lang/model/element/TypeElement;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "allSubClasses", "(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directSubClasses0", "(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "directSubClasses", "(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "buildTree", "(Ljava/lang/Iterable;)V"));
	}

	[JniSignatureAttribute("Ljava/util/SortedSet;", "private final")]
	public Dova.JDK.java.util.SortedSet baseClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map subClasses_Property
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

	[JniSignatureAttribute("Ljava/util/SortedSet;", "private final")]
	public Dova.JDK.java.util.SortedSet baseInterfaces_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map subInterfaces_Property
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

	[JniSignatureAttribute("Ljava/util/SortedSet;", "private final")]
	public Dova.JDK.java.util.SortedSet baseEnums_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map subEnums_Property
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

	[JniSignatureAttribute("Ljava/util/SortedSet;", "private final")]
	public Dova.JDK.java.util.SortedSet baseAnnotationTypes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map subAnnotationTypes_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map implementingClasses_Property
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

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private final")]
	public Dova.JDK.java.util.Comparator comparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassTree(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/SortedSet;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public")]
	public ClassTree(Dova.JDK.java.util.SortedSet arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/doclet/DocletEnvironment;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;)V", "public")]
	public ClassTree(Dova.JDK.jdk.javadoc.doclet.DocletEnvironment arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Z)V", "public")]
	public ClassTree(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/ClassTree;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;Ljavax/lang/model/element/TypeElement;)Z", "private")]
	public bool add(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1, Dova.JDK.javax.lang.model.element.TypeElement arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "private")]
	public Dova.JDK.java.util.SortedSet get(Dova.JDK.java.util.Map arg0, Dova.JDK.javax.lang.model.element.TypeElement arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet subClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet subInterfaces(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet implementingClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet baseAnnotationTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet baseEnums()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet baseClasses()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet baseInterfaces()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Ljdk/javadoc/internal/doclets/toolkit/BaseConfiguration;Ljava/util/Collection;Ljava/util/Map;)V", "private")]
	public void processType(Dova.JDK.javax.lang.model.element.TypeElement arg0, Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.BaseConfiguration arg1, Dova.JDK.java.util.Collection arg2, Dova.JDK.java.util.Map arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)V", "private")]
	public void processInterface(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet allSubClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;", "private")]
	public Dova.JDK.java.util.SortedSet directSubClasses0(Dova.JDK.javax.lang.model.element.TypeElement arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;Z)Ljava/util/SortedSet;", "public")]
	public Dova.JDK.java.util.SortedSet directSubClasses(Dova.JDK.javax.lang.model.element.TypeElement arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.SortedSet>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)V", "private")]
	public void buildTree(Dova.JDK.java.lang.Iterable arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}
}
