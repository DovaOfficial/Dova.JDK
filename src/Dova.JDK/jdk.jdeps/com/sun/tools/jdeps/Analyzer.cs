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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer;", "public")]
public partial class Analyzer
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Analyzer()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "configuration", "Lcom/sun/tools/jdeps/JdepsConfiguration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "type", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "filter", "Lcom/sun/tools/jdeps/Analyzer$Filter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "results", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "locationToArchive", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NOT_FOUND", "Lcom/sun/tools/jdeps/Archive;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "ANY", "Ljava/util/function/Predicate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "REMOVED_JDK_INTERNALS", "Lcom/sun/tools/jdeps/Analyzer$Jdk8Internals;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Analyzer", "(Lcom/sun/tools/jdeps/JdepsConfiguration;Lcom/sun/tools/jdeps/Analyzer$Type;Lcom/sun/tools/jdeps/Analyzer$Filter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "(Ljava/lang/Iterable;Ljava/util/Map;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "requires", "(Lcom/sun/tools/jdeps/Archive;)Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDependences", "(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDependences", "(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;Lcom/sun/tools/jdeps/Analyzer$Type;Ljava/util/function/Predicate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDependences", "(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;Lcom/sun/tools/jdeps/Analyzer$Type;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasDependences", "(Lcom/sun/tools/jdeps/Archive;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "archives", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dependences", "(Lcom/sun/tools/jdeps/Archive;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "notFound", "(Lcom/sun/tools/jdeps/Archive;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration;", "protected final")]
	public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration configuration_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "protected final")]
	public Dova.JDK.com.sun.tools.jdeps.Analyzer.Type type_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Filter;", "protected final")]
	public Dova.JDK.com.sun.tools.jdeps.Analyzer.Filter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Filter>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map results_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Map;", "protected final")]
	public Dova.JDK.java.util.Map locationToArchive_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Archive;", "static final")]
	public static Dova.JDK.com.sun.tools.jdeps.Archive NOT_FOUND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/function/Predicate;", "static final")]
	public static Dova.JDK.java.util.function.Predicate ANY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Jdk8Internals;", "static final")]
	public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Jdk8Internals REMOVED_JDK_INTERNALS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Jdk8Internals>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Analyzer(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/JdepsConfiguration;Lcom/sun/tools/jdeps/Analyzer$Type;Lcom/sun/tools/jdeps/Analyzer$Filter;)V", "")]
	public Analyzer(Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Filter arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/Analyzer;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Iterable;Ljava/util/Map;)Z", "")]
	public bool run(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)Ljava/util/stream/Stream;", "")]
	public Dova.JDK.java.util.stream.Stream requires(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;)V", "")]
	public void visitDependences(Dova.JDK.com.sun.tools.jdeps.Archive arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;Lcom/sun/tools/jdeps/Analyzer$Type;Ljava/util/function/Predicate;)V", "")]
	public void visitDependences(Dova.JDK.com.sun.tools.jdeps.Archive arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg2, Dova.JDK.java.util.function.Predicate arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Visitor;Lcom/sun/tools/jdeps/Analyzer$Type;)V", "")]
	public void visitDependences(Dova.JDK.com.sun.tools.jdeps.Archive arg0, Dova.JDK.com.sun.tools.jdeps.Analyzer.Visitor arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)Z", "")]
	public bool hasDependences(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set archives()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set dependences(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)Z", "static")]
	public static bool notFound(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
	public partial class Type
		: Dova.JDK.java.lang.Enum
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Type()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Type;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "SUMMARY", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "MODULE", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PACKAGE", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "CLASS", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "VERBOSE", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$VALUES", "[Lcom/sun/tools/jdeps/Analyzer$Type;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Type", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "values", "()[Lcom/sun/tools/jdeps/Analyzer$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueOf", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/Analyzer$Type;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "$values", "()[Lcom/sun/tools/jdeps/Analyzer$Type;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type SUMMARY_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type MODULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type PACKAGE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type CLASS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "public static final")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type VERBOSE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("[Lcom/sun/tools/jdeps/Analyzer$Type;", "private static final")]
		public static JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Type(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public Type(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/Analyzer$Type;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Lcom/sun/tools/jdeps/Analyzer$Type;", "public static")]
		public static JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/Analyzer$Type;", "public static")]
		public static Dova.JDK.com.sun.tools.jdeps.Analyzer.Type valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
		}

		[JniSignatureAttribute("()[Lcom/sun/tools/jdeps/Analyzer$Type;", "private static")]
		public static JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Filter;", "abstract static interface")]
	public partial interface Filter
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Filter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Filter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "accepts", "(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/jdeps/Archive;)Z"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/jdeps/Archive;)Z", "public abstract")]
		bool accepts(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.com.sun.tools.classfile.Dependency.Location arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Dependences;", "")]
	public partial class Dependences
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.jdeps.Archive.Visitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dependences()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Dependences;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "archive", "Lcom/sun/tools/jdeps/Archive;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "requires", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "deps", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "level", "Lcom/sun/tools/jdeps/Analyzer$Type;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targetFilter", "Ljava/util/function/Predicate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "profile", "Lcom/sun/tools/jdeps/Profile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "curDep", "Lcom/sun/tools/jdeps/Analyzer$Dep;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "this$0", "Lcom/sun/tools/jdeps/Analyzer;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Dependences", "(Lcom/sun/tools/jdeps/Analyzer;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Type;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Dependences", "(Lcom/sun/tools/jdeps/Analyzer;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Type;Ljava/util/function/Predicate;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "requires", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visit", "(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "dependencies", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getTargetProfile", "(Lcom/sun/tools/jdeps/Archive;)Lcom/sun/tools/jdeps/Profile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "findArchive", "(Lcom/sun/tools/classfile/Dependency$Location;)Lcom/sun/tools/jdeps/Archive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "addDep", "(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)Lcom/sun/tools/jdeps/Analyzer$Dep;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationName", "(Lcom/sun/tools/classfile/Dependency$Location;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Archive;", "protected final")]
		public Dova.JDK.com.sun.tools.jdeps.Archive archive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "protected final")]
		public Dova.JDK.java.util.Set requires_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "protected final")]
		public Dova.JDK.java.util.Set deps_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Type;", "protected final")]
		public Dova.JDK.com.sun.tools.jdeps.Analyzer.Type level_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Type>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/function/Predicate;", "protected final")]
		public Dova.JDK.java.util.function.Predicate targetFilter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.function.Predicate>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Profile;", "private")]
		public Dova.JDK.com.sun.tools.jdeps.Profile profile_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Profile>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Dep;", "private")]
		public Dova.JDK.com.sun.tools.jdeps.Analyzer.Dep curDep_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Dep>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.Analyzer this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Dependences(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Analyzer;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Type;)V", "")]
		public Dependences(Dova.JDK.com.sun.tools.jdeps.Analyzer arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg2) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Analyzer;Lcom/sun/tools/jdeps/Archive;Lcom/sun/tools/jdeps/Analyzer$Type;Ljava/util/function/Predicate;)V", "")]
		public Dependences(Dova.JDK.com.sun.tools.jdeps.Analyzer arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.com.sun.tools.jdeps.Analyzer.Type arg2, Dova.JDK.java.util.function.Predicate arg3) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/Analyzer$Dependences;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set requires()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)V", "public")]
		public void visit(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0, Dova.JDK.com.sun.tools.classfile.Dependency.Location arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "")]
		public Dova.JDK.java.util.Set dependencies()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)Lcom/sun/tools/jdeps/Profile;", "")]
		public Dova.JDK.com.sun.tools.jdeps.Profile getTargetProfile(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Profile>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;)Lcom/sun/tools/jdeps/Archive;", "")]
		public Dova.JDK.com.sun.tools.jdeps.Archive findArchive(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)Lcom/sun/tools/jdeps/Analyzer$Dep;", "protected")]
		public Dova.JDK.com.sun.tools.jdeps.Analyzer.Dep addDep(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0, Dova.JDK.com.sun.tools.classfile.Dependency.Location arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Analyzer.Dep>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getLocationName(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Visitor;", "abstract static interface")]
	public partial interface Visitor
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Visitor()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Visitor;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "visitDependence", "(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "public abstract")]
		void visitDependence(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.tools.jdeps.Archive arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.com.sun.tools.jdeps.Archive arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Jdk8Internals;", "static")]
	public partial class Jdk8Internals
		: Dova.JDK.com.sun.tools.jdeps.Module
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Jdk8Internals()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Jdk8Internals;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NAME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "JDK8_INTERNALS", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "jdk8Internals", "Ljava/util/Set;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Jdk8Internals", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "contains", "(Lcom/sun/tools/classfile/Dependency$Location;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isExported", "(Ljava/lang/String;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isJDK", "()Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String NAME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String JDK8_INTERNALS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set jdk8Internals_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Jdk8Internals(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Jdk8Internals() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/Analyzer$Jdk8Internals;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;)Z", "public")]
		public bool contains(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Z", "public")]
		public bool isExported(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool isJDK()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/Analyzer$Dep;", "")]
	public partial class Dep
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Dep()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/Analyzer$Dep;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "origin", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "originArchive", "Lcom/sun/tools/jdeps/Archive;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "target", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "targetArchive", "Lcom/sun/tools/jdeps/Archive;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Dep", "(Lcom/sun/tools/jdeps/Analyzer;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "target", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "origin", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "originArchive", "()Lcom/sun/tools/jdeps/Archive;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "targetArchive", "()Lcom/sun/tools/jdeps/Archive;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Archive;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.Archive originArchive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Ljava/lang/String;", "final")]
		public Dova.JDK.java.lang.String target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/Archive;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.Archive targetArchive_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
			}
			set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Dep(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Analyzer;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;Ljava/lang/String;Lcom/sun/tools/jdeps/Archive;)V", "")]
		public Dep(Dova.JDK.com.sun.tools.jdeps.Analyzer arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.com.sun.tools.jdeps.Archive arg2, Dova.JDK.java.lang.String arg3, Dova.JDK.com.sun.tools.jdeps.Archive arg4) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/Analyzer$Dep;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String target()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "")]
		public Dova.JDK.java.lang.String origin()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Archive;", "")]
		public Dova.JDK.com.sun.tools.jdeps.Archive originArchive()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/jdeps/Archive;", "")]
		public Dova.JDK.com.sun.tools.jdeps.Archive targetArchive()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Archive>(ret);
		}
	}
}
