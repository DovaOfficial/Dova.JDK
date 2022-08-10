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

namespace Dova.JDK.javax.lang.model.util;

[JniSignatureAttribute("Ljavax/lang/model/util/Elements;", "public abstract interface")]
public partial interface Elements
	: IJavaObject
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Elements()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/util/Elements;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getName", "(Ljava/lang/CharSequence;)Ljavax/lang/model/element/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isBridge", "(Ljavax/lang/model/element/ExecutableElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDeprecated", "(Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Ljavax/lang/model/element/ModuleElement;Ljavax/lang/model/element/ModuleElement$Directive;)Ljavax/lang/model/util/Elements$Origin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Ljavax/lang/model/AnnotatedConstruct;Ljavax/lang/model/element/AnnotationMirror;)Ljavax/lang/model/util/Elements$Origin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOrigin", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/util/Elements$Origin;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeElement", "(Ljava/lang/CharSequence;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTypeElement", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/CharSequence;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllModuleElements", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllPackageElements", "(Ljava/lang/CharSequence;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllTypeElements", "(Ljava/lang/CharSequence;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getElementValuesWithDefaults", "(Ljavax/lang/model/element/AnnotationMirror;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOutermostTypeElement", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllAnnotationMirrors", "(Ljavax/lang/model/element/Element;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hides", "(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getConstantExpression", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "printElements", "(Ljava/io/Writer;[Ljavax/lang/model/element/Element;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isAutomaticModule", "(Ljavax/lang/model/element/ModuleElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "recordComponentFor", "(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/RecordComponentElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getFileObjectOf", "(Ljavax/lang/model/element/Element;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getBinaryName", "(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/Name;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModuleOf", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "overrides", "(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getAllMembers", "(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageOf", "(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageElement", "(Ljavax/lang/model/element/ModuleElement;Ljava/lang/CharSequence;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPackageElement", "(Ljava/lang/CharSequence;)Ljavax/lang/model/element/PackageElement;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isFunctionalInterface", "(Ljavax/lang/model/element/TypeElement;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDocComment", "(Ljavax/lang/model/element/Element;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getModuleElement", "(Ljava/lang/CharSequence;)Ljavax/lang/model/element/ModuleElement;"));
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljavax/lang/model/element/Name;", "public abstract")]
	Dova.JDK.javax.lang.model.element.Name getName(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Z", "public")]
	bool isBridge(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool isDeprecated(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljavax/lang/model/element/ModuleElement$Directive;)Ljavax/lang/model/util/Elements$Origin;", "public")]
	Dova.JDK.javax.lang.model.util.Elements.Origin getOrigin(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.javax.lang.model.element.ModuleElement.Directive arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/AnnotatedConstruct;Ljavax/lang/model/element/AnnotationMirror;)Ljavax/lang/model/util/Elements$Origin;", "public")]
	Dova.JDK.javax.lang.model.util.Elements.Origin getOrigin(Dova.JDK.javax.lang.model.AnnotatedConstruct arg0, Dova.JDK.javax.lang.model.element.AnnotationMirror arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/util/Elements$Origin;", "public")]
	Dova.JDK.javax.lang.model.util.Elements.Origin getOrigin(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljavax/lang/model/element/TypeElement;", "public abstract")]
	Dova.JDK.javax.lang.model.element.TypeElement getTypeElement(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljava/lang/CharSequence;)Ljavax/lang/model/element/TypeElement;", "public")]
	Dova.JDK.javax.lang.model.element.TypeElement getTypeElement(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	Dova.JDK.java.util.Set getAllModuleElements()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/Set;", "public")]
	Dova.JDK.java.util.Set getAllPackageElements(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/util/Set;", "public")]
	Dova.JDK.java.util.Set getAllTypeElements(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/AnnotationMirror;)Ljava/util/Map;", "public abstract")]
	Dova.JDK.java.util.Map getElementValuesWithDefaults(Dova.JDK.javax.lang.model.element.AnnotationMirror arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/TypeElement;", "public")]
	Dova.JDK.javax.lang.model.element.TypeElement getOutermostTypeElement(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.TypeElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getAllAnnotationMirrors(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;Ljavax/lang/model/element/Element;)Z", "public abstract")]
	bool hides(Dova.JDK.javax.lang.model.element.Element arg0, Dova.JDK.javax.lang.model.element.Element arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getConstantExpression(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/Writer;[Ljavax/lang/model/element/Element;)V", "public abstract transient")]
	void printElements(Dova.JDK.java.io.Writer arg0, JavaArray<Dova.JDK.javax.lang.model.element.Element> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;)Z", "public")]
	bool isAutomaticModule(Dova.JDK.javax.lang.model.element.ModuleElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;)Ljavax/lang/model/element/RecordComponentElement;", "public")]
	Dova.JDK.javax.lang.model.element.RecordComponentElement recordComponentFor(Dova.JDK.javax.lang.model.element.ExecutableElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.RecordComponentElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/tools/JavaFileObject;", "public")]
	Dova.JDK.javax.tools.JavaFileObject getFileObjectOf(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljavax/lang/model/element/Name;", "public abstract")]
	Dova.JDK.javax.lang.model.element.Name getBinaryName(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Name>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/ModuleElement;", "public")]
	Dova.JDK.javax.lang.model.element.ModuleElement getModuleOf(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ModuleElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/ExecutableElement;Ljavax/lang/model/element/TypeElement;)Z", "public abstract")]
	bool overrides(Dova.JDK.javax.lang.model.element.ExecutableElement arg0, Dova.JDK.javax.lang.model.element.ExecutableElement arg1, Dova.JDK.javax.lang.model.element.TypeElement arg2)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Ljava/util/List;", "public abstract")]
	Dova.JDK.java.util.List getAllMembers(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljavax/lang/model/element/PackageElement;", "public abstract")]
	Dova.JDK.javax.lang.model.element.PackageElement getPackageOf(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/ModuleElement;Ljava/lang/CharSequence;)Ljavax/lang/model/element/PackageElement;", "public")]
	Dova.JDK.javax.lang.model.element.PackageElement getPackageElement(Dova.JDK.javax.lang.model.element.ModuleElement arg0, Dova.JDK.java.lang.CharSequence arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljavax/lang/model/element/PackageElement;", "public abstract")]
	Dova.JDK.javax.lang.model.element.PackageElement getPackageElement(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.PackageElement>(ret);
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/TypeElement;)Z", "public abstract")]
	bool isFunctionalInterface(Dova.JDK.javax.lang.model.element.TypeElement arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/lang/model/element/Element;)Ljava/lang/String;", "public abstract")]
	Dova.JDK.java.lang.String getDocComment(Dova.JDK.javax.lang.model.element.Element arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljavax/lang/model/element/ModuleElement;", "public")]
	Dova.JDK.javax.lang.model.element.ModuleElement getModuleElement(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.ModuleElement>(ret);
	}

	[JniSignatureAttribute("Ljavax/lang/model/util/Elements$Origin;", "public static final")]
	public partial class Origin
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Origin()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/lang/model/util/Elements$Origin;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "EXPLICIT", "Ljavax/lang/model/util/Elements$Origin;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MANDATED", "Ljavax/lang/model/util/Elements$Origin;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SYNTHETIC", "Ljavax/lang/model/util/Elements$Origin;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Ljavax/lang/model/util/Elements$Origin;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Origin", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Ljavax/lang/model/util/Elements$Origin;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Ljavax/lang/model/util/Elements$Origin;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Ljavax/lang/model/util/Elements$Origin;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isDeclared", "()Z"));
		}

		[JniSignatureAttribute("Ljavax/lang/model/util/Elements$Origin;", "public static final")]
		public static Dova.JDK.javax.lang.model.util.Elements.Origin EXPLICIT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/lang/model/util/Elements$Origin;", "public static final")]
		public static Dova.JDK.javax.lang.model.util.Elements.Origin MANDATED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljavax/lang/model/util/Elements$Origin;", "public static final")]
		public static Dova.JDK.javax.lang.model.util.Elements.Origin SYNTHETIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Ljavax/lang/model/util/Elements$Origin;", "private static final")]
		public static JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Origin(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Origin(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljavax/lang/model/util/Elements$Origin;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljavax/lang/model/util/Elements$Origin;", "public static")]
		public static JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/lang/model/util/Elements$Origin;", "public static")]
		public static Dova.JDK.javax.lang.model.util.Elements.Origin valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.util.Elements.Origin>(ret);
		}

		[JniSignatureAttribute("()[Ljavax/lang/model/util/Elements$Origin;", "private static")]
		public static JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.lang.model.util.Elements.Origin>>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isDeclared()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}
}
