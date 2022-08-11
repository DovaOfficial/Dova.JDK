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

[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;", "public")]
public partial class Comparators
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Comparators()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "utils", "Ljdk/javadoc/internal/doclets/toolkit/util/Utils;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "moduleComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "allClassesComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "summaryComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "serialFieldTreeComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "overrideUseComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "indexUseComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMirrorClassUseComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "typeMirrorIndexUseComparator", "Ljava/util/Comparator;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classUseComparator", "Ljava/util/Comparator;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeGeneralPurposeComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeClassUseComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTypeMirrorClassUseComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makePackageComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeModuleComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeOverrideUseComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeIndexElementComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeAllClassesComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSummaryComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeSerialFieldTreeComparator", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "makeTypeMirrorIndexUseComparator", "()Ljava/util/Comparator;"));
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Utils;", "private final")]
	public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils utils_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator moduleComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator allClassesComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator packageComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator summaryComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator serialFieldTreeComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator overrideUseComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator indexUseComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator typeMirrorClassUseComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator typeMirrorIndexUseComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Comparator;", "private")]
	public Dova.JDK.java.util.Comparator classUseComparator_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Comparators(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/Utils;)V", "")]
	public Comparators(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Utils arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeGeneralPurposeComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeClassUseComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeTypeMirrorClassUseComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makePackageComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeModuleComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeOverrideUseComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeIndexElementComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeAllClassesComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeSummaryComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeSerialFieldTreeComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public")]
	public Dova.JDK.java.util.Comparator makeTypeMirrorIndexUseComparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators$ElementComparator;", "private abstract")]
	public partial class ElementComparator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.util.Comparator
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ElementComparator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators$ElementComparator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTypeCode", "(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFullyQualifiedName", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareFullyQualifiedNames", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasParameters", "(Ljavax/lang/model/element/Element;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParametersAsString", "(Ljava/util/List;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareParameters", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareParameters", "(ZLjava/util/List;Ljava/util/List;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKindIndex", "(Ljavax/lang/model/element/Element;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareNames", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareModuleNames", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareElementKinds", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I"));
		}

		[JniSignatureAttribute("Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;", "final")]
		public Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ElementComparator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/javadoc/internal/doclets/toolkit/util/Comparators;)V", "public")]
		public ElementComparator(Dova.JDK.jdk.javadoc.@internal.doclets.toolkit.util.Comparators arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/javadoc/internal/doclets/toolkit/util/Comparators$ElementComparator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/lang/model/type/TypeMirror;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getTypeCode(Dova.JDK.javax.lang.model.type.TypeMirror arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getFullyQualifiedName(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I", "protected")]
		public int compareFullyQualifiedNames(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "")]
		public bool hasParameters(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/List;)Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String getParametersAsString(Dova.JDK.java.util.List arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I", "protected")]
		public int compareParameters(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(ZLjava/util/List;Ljava/util/List;)I", "protected")]
		public int compareParameters(bool arg0, Dova.JDK.java.util.List arg1, Dova.JDK.java.util.List arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)I", "private")]
		public int getKindIndex(Dova.JDK.javax.lang.model.element.Element arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I", "protected")]
		public int compareNames(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I", "protected")]
		public int compareModuleNames(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)I", "protected")]
		public int compareElementKinds(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return ret;
		}
	}
}
