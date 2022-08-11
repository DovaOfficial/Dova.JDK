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

namespace Dova.JDK.com.sun.tools.classfile;

[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies;", "public")]
public partial class Dependencies
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Dependencies()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "filter", "Lcom/sun/tools/classfile/Dependency$Filter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finder", "Lcom/sun/tools/classfile/Dependency$Finder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFilter", "()Lcom/sun/tools/classfile/Dependency$Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFilter", "(Lcom/sun/tools/classfile/Dependency$Filter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassDependencyFinder", "()Lcom/sun/tools/classfile/Dependency$Finder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFinder", "()Lcom/sun/tools/classfile/Dependency$Finder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAPIFinder", "(I)Lcom/sun/tools/classfile/Dependency$Finder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setFinder", "(Lcom/sun/tools/classfile/Dependency$Finder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRegexFilter", "(Ljava/util/regex/Pattern;)Lcom/sun/tools/classfile/Dependency$Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPackageFilter", "(Ljava/util/Set;Z)Lcom/sun/tools/classfile/Dependency$Filter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAllDependencies", "(Lcom/sun/tools/classfile/Dependencies$ClassFileReader;Ljava/util/Set;ZLcom/sun/tools/classfile/Dependencies$Recorder;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAllDependencies", "(Lcom/sun/tools/classfile/Dependencies$ClassFileReader;Ljava/util/Set;Z)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultFinder", "()Lcom/sun/tools/classfile/Dependency$Finder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefaultFilter", "()Lcom/sun/tools/classfile/Dependency$Filter;"));
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Filter;", "private")]
	public Dova.JDK.com.sun.tools.classfile.Dependency.Filter filter_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Filter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Finder;", "private")]
	public Dova.JDK.com.sun.tools.classfile.Dependency.Finder finder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Finder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Dependencies(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Dependencies() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Filter;", "public")]
	public Dova.JDK.com.sun.tools.classfile.Dependency.Filter getFilter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Filter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Filter;)V", "public")]
	public void setFilter(Dova.JDK.com.sun.tools.classfile.Dependency.Filter arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Finder;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Finder getClassDependencyFinder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Finder>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Finder;", "public")]
	public Dova.JDK.com.sun.tools.classfile.Dependency.Finder getFinder()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Finder>(ret);
	}

	[JniSignatureAttribute("(I)Lcom/sun/tools/classfile/Dependency$Finder;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Finder getAPIFinder(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Finder>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Finder;)V", "public")]
	public void setFinder(Dova.JDK.com.sun.tools.classfile.Dependency.Finder arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/util/regex/Pattern;)Lcom/sun/tools/classfile/Dependency$Filter;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Filter getRegexFilter(Dova.JDK.java.util.regex.Pattern arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Filter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;Z)Lcom/sun/tools/classfile/Dependency$Filter;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Filter getPackageFilter(Dova.JDK.java.util.Set arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Filter>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependencies$ClassFileReader;Ljava/util/Set;ZLcom/sun/tools/classfile/Dependencies$Recorder;)V", "public")]
	public void findAllDependencies(Dova.JDK.com.sun.tools.classfile.Dependencies.ClassFileReader arg0, Dova.JDK.java.util.Set arg1, bool arg2, Dova.JDK.com.sun.tools.classfile.Dependencies.Recorder arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependencies$ClassFileReader;Ljava/util/Set;Z)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set findAllDependencies(Dova.JDK.com.sun.tools.classfile.Dependencies.ClassFileReader arg0, Dova.JDK.java.util.Set arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Finder;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Finder getDefaultFinder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Finder>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Filter;", "public static")]
	public static Dova.JDK.com.sun.tools.classfile.Dependency.Filter getDefaultFilter()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Filter>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$APIDependencyFinder;", "static")]
	public partial class APIDependencyFinder
		: Dova.JDK.com.sun.tools.classfile.Dependencies.BasicDependencyFinder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static APIDependencyFinder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$APIDependencyFinder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "showAccess", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccess", "(Lcom/sun/tools/classfile/AccessFlags;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDependencies", "(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("I", "private")]
		public int showAccess_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public APIDependencyFinder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public APIDependencyFinder(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$APIDependencyFinder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/AccessFlags;)Z", "")]
		public bool checkAccess(Dova.JDK.com.sun.tools.classfile.AccessFlags arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable findDependencies(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$ClassDependencyFinder;", "static")]
	public partial class ClassDependencyFinder
		: Dova.JDK.com.sun.tools.classfile.Dependencies.BasicDependencyFinder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassDependencyFinder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$ClassDependencyFinder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDependencies", "(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassDependencyFinder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public ClassDependencyFinder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$ClassDependencyFinder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/ClassFile;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable findDependencies(Dova.JDK.com.sun.tools.classfile.ClassFile arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$DefaultFilter;", "static")]
	public partial class DefaultFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency.Filter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$DefaultFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lcom/sun/tools/classfile/Dependencies$DefaultFilter;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "()Lcom/sun/tools/classfile/Dependencies$DefaultFilter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Lcom/sun/tools/classfile/Dependency;)Z"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$DefaultFilter;", "private static")]
		public static Dova.JDK.com.sun.tools.classfile.Dependencies.DefaultFilter instance_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependencies.DefaultFilter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public DefaultFilter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$DefaultFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependencies$DefaultFilter;", "static")]
		public static Dova.JDK.com.sun.tools.classfile.Dependencies.DefaultFilter instance()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependencies.DefaultFilter>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency;)Z", "public")]
		public bool accepts(Dova.JDK.com.sun.tools.classfile.Dependency arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$TargetRegexFilter;", "static")]
	public partial class TargetRegexFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency.Filter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TargetRegexFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$TargetRegexFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "pattern", "Ljava/util/regex/Pattern;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/regex/Pattern;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Lcom/sun/tools/classfile/Dependency;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private final")]
		public Dova.JDK.java.util.regex.Pattern pattern_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TargetRegexFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/regex/Pattern;)V", "")]
		public TargetRegexFilter(Dova.JDK.java.util.regex.Pattern arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$TargetRegexFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency;)Z", "public")]
		public bool accepts(Dova.JDK.com.sun.tools.classfile.Dependency arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$TargetPackageFilter;", "static")]
	public partial class TargetPackageFilter
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency.Filter
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TargetPackageFilter()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$TargetPackageFilter;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageNames", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "matchSubpackages", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/Set;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "accepts", "(Lcom/sun/tools/classfile/Dependency;)Z"));
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private final")]
		public Dova.JDK.java.util.Set packageNames_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool matchSubpackages_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TargetPackageFilter(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/Set;Z)V", "")]
		public TargetPackageFilter(Dova.JDK.java.util.Set arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$TargetPackageFilter;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency;)Z", "public")]
		public bool accepts(Dova.JDK.com.sun.tools.classfile.Dependency arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$Recorder;", "public abstract static interface")]
	public partial interface Recorder
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Recorder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$Recorder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDependency", "(Lcom/sun/tools/classfile/Dependency;)V"));
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency;)V", "public abstract")]
		void addDependency(Dova.JDK.com.sun.tools.classfile.Dependency arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$ClassFileReader;", "public abstract static interface")]
	public partial interface ClassFileReader
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassFileReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$ClassFileReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassFile", "(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/ClassFile;", "public abstract")]
		Dova.JDK.com.sun.tools.classfile.ClassFile getClassFile(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ClassFile>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;", "abstract static")]
	public partial class BasicDependencyFinder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency.Finder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicDependencyFinder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locations", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "(Ljava/lang/String;)Lcom/sun/tools/classfile/Dependency$Location;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map locations_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicDependencyFinder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public BasicDependencyFinder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/classfile/Dependency$Location;", "")]
		public Dova.JDK.com.sun.tools.classfile.Dependency.Location getLocation(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder$Visitor;", "")]
		public partial class Visitor
			: Dova.JDK.java.lang.Object
			, Dova.JDK.com.sun.tools.classfile.ConstantPool.Visitor
			, Dova.JDK.com.sun.tools.classfile.Type.Visitor
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static Visitor()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder$Visitor;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "constant_pool", "Lcom/sun/tools/classfile/ConstantPool;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "Lcom/sun/tools/classfile/Dependency$Location;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "deps", "Ljava/util/Set;"));
				FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;"));
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;Lcom/sun/tools/classfile/ClassFile;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClass", "(I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/RuntimeAnnotations_attribute;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/Attributes;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/RuntimeParameterAnnotations_attribute;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/ConstantPool$CPInfo;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "scan", "(Lcom/sun/tools/classfile/Descriptor;Lcom/sun/tools/classfile/Attributes;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitModule", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitPackage", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/classfile/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitArrayType", "(Lcom/sun/tools/classfile/Type$ArrayType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClass", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInterfaceMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFieldref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDouble", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitLong", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitString", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodref", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitNameAndType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodHandle", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFloat", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitUtf8", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInvokeDynamic", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitInteger", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addDependency", "(Ljava/lang/String;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/classfile/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassType", "(Lcom/sun/tools/classfile/Type$ClassType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/classfile/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitWildcardType", "(Lcom/sun/tools/classfile/Type$WildcardType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/Type$MethodType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitMethodType", "(Lcom/sun/tools/classfile/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitDynamicConstant", "(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClasses", "([I)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDependencies", "(Lcom/sun/tools/classfile/Type;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findDependencies", "(Ljava/util/List;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSimpleType", "(Lcom/sun/tools/classfile/Type$SimpleType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitSimpleType", "(Lcom/sun/tools/classfile/Type$SimpleType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParamType", "(Lcom/sun/tools/classfile/Type$TypeParamType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitTypeParamType", "(Lcom/sun/tools/classfile/Type$TypeParamType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassSigType", "(Lcom/sun/tools/classfile/Type$ClassSigType;Ljava/lang/Void;)Ljava/lang/Void;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitClassSigType", "(Lcom/sun/tools/classfile/Type$ClassSigType;Ljava/lang/Object;)Ljava/lang/Object;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitRef", "(Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;Ljava/lang/Void;)Ljava/lang/Void;"));
			}

			[JniSignatureAttribute("Lcom/sun/tools/classfile/ConstantPool;", "private")]
			public Dova.JDK.com.sun.tools.classfile.ConstantPool constant_pool_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.ConstantPool>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Location;", "private")]
			public Dova.JDK.com.sun.tools.classfile.Dependency.Location origin_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Ljava/util/Set;", "")]
			public Dova.JDK.java.util.Set deps_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
					return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;", "final")]
			public Dova.JDK.com.sun.tools.classfile.Dependencies.BasicDependencyFinder this0_Property
			{
				get
				{
					var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
					return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependencies.BasicDependencyFinder>(ret);
				}
				set
				{
					DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
				}
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public Visitor(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder;Lcom/sun/tools/classfile/ClassFile;)V", "")]
			public Visitor(Dova.JDK.com.sun.tools.classfile.Dependencies.BasicDependencyFinder arg0, Dova.JDK.com.sun.tools.classfile.ClassFile arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
			{
			}

			public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$BasicDependencyFinder$Visitor;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(I)V", "")]
			public void addClass(int arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeAnnotations_attribute;)V", "private")]
			public void scan(Dova.JDK.com.sun.tools.classfile.RuntimeAnnotations_attribute arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Attributes;)V", "")]
			public void scan(Dova.JDK.com.sun.tools.classfile.Attributes arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/RuntimeParameterAnnotations_attribute;)V", "private")]
			public void scan(Dova.JDK.com.sun.tools.classfile.RuntimeParameterAnnotations_attribute arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CPInfo;)V", "")]
			public void scan(Dova.JDK.com.sun.tools.classfile.ConstantPool.CPInfo arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type;)V", "")]
			public void scan(Dova.JDK.com.sun.tools.classfile.Type arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Descriptor;Lcom/sun/tools/classfile/Attributes;)V", "")]
			public void scan(Dova.JDK.com.sun.tools.classfile.Descriptor arg0, Dova.JDK.com.sun.tools.classfile.Attributes arg1)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Module_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitModule(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Module_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Package_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitPackage(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Package_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ArrayType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitArrayType(Dova.JDK.com.sun.tools.classfile.Type.ArrayType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ArrayType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitArrayType(Dova.JDK.com.sun.tools.classfile.Type.ArrayType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Class_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitClass(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Class_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InterfaceMethodref_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitInterfaceMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InterfaceMethodref_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Fieldref_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitFieldref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Fieldref_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Double_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitDouble(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Double_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Long_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitLong(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Long_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_String_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitString(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_String_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Methodref_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitMethodref(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Methodref_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_NameAndType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitNameAndType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_NameAndType_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodHandle_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitMethodHandle(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodHandle_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Float_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitFloat(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Float_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Utf8_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitUtf8(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Utf8_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_InvokeDynamic_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitInvokeDynamic(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_InvokeDynamic_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Integer_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitInteger(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Integer_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
			public void addDependency(Dova.JDK.java.lang.String arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ClassType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitClassType(Dova.JDK.com.sun.tools.classfile.Type.ClassType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ClassType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitClassType(Dova.JDK.com.sun.tools.classfile.Type.ClassType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$WildcardType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitWildcardType(Dova.JDK.com.sun.tools.classfile.Type.WildcardType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$WildcardType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitWildcardType(Dova.JDK.com.sun.tools.classfile.Type.WildcardType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$MethodType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitMethodType(Dova.JDK.com.sun.tools.classfile.Type.MethodType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_MethodType_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_MethodType_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$MethodType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitMethodType(Dova.JDK.com.sun.tools.classfile.Type.MethodType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CONSTANT_Dynamic_info;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitDynamicConstant(Dova.JDK.com.sun.tools.classfile.ConstantPool.CONSTANT_Dynamic_info arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("([I)V", "")]
			public void addClasses(JavaArray<int> arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type;)V", "private")]
			public void findDependencies(Dova.JDK.com.sun.tools.classfile.Type arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
			}

			[JniSignatureAttribute("(Ljava/util/List;)V", "private")]
			public void findDependencies(Dova.JDK.java.util.List arg0)
			{
				DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$SimpleType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitSimpleType(Dova.JDK.com.sun.tools.classfile.Type.SimpleType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$SimpleType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitSimpleType(Dova.JDK.com.sun.tools.classfile.Type.SimpleType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$TypeParamType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitTypeParamType(Dova.JDK.com.sun.tools.classfile.Type.TypeParamType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$TypeParamType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitTypeParamType(Dova.JDK.com.sun.tools.classfile.Type.TypeParamType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ClassSigType;Ljava/lang/Void;)Ljava/lang/Void;", "public")]
			public Dova.JDK.java.lang.Void visitClassSigType(Dova.JDK.com.sun.tools.classfile.Type.ClassSigType arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/Type$ClassSigType;Ljava/lang/Object;)Ljava/lang/Object;", "public volatile")]
			public Dova.JDK.java.lang.Object visitClassSigType(Dova.JDK.com.sun.tools.classfile.Type.ClassSigType arg0, Dova.JDK.java.lang.Object arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}

			[JniSignatureAttribute("(Lcom/sun/tools/classfile/ConstantPool$CPRefInfo;Ljava/lang/Void;)Ljava/lang/Void;", "private")]
			public Dova.JDK.java.lang.Void visitRef(Dova.JDK.com.sun.tools.classfile.ConstantPool.CPRefInfo arg0, Dova.JDK.java.lang.Void arg1)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Void>(ret);
			}
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$SimpleDependency;", "static")]
	public partial class SimpleDependency
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleDependency()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$SimpleDependency;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "origin", "Lcom/sun/tools/classfile/Dependency$Location;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "target", "Lcom/sun/tools/classfile/Dependency$Location;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "()Lcom/sun/tools/classfile/Dependency$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOrigin", "()Lcom/sun/tools/classfile/Dependency$Location;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Location;", "private")]
		public Dova.JDK.com.sun.tools.classfile.Dependency.Location origin_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependency$Location;", "private")]
		public Dova.JDK.com.sun.tools.classfile.Dependency.Location target_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleDependency(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;Lcom/sun/tools/classfile/Dependency$Location;)V", "public")]
		public SimpleDependency(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0, Dova.JDK.com.sun.tools.classfile.Dependency.Location arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$SimpleDependency;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Location;", "public")]
		public Dova.JDK.com.sun.tools.classfile.Dependency.Location getTarget()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
		}

		[JniSignatureAttribute("()Lcom/sun/tools/classfile/Dependency$Location;", "public")]
		public Dova.JDK.com.sun.tools.classfile.Dependency.Location getOrigin()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.classfile.Dependency.Location>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$SimpleLocation;", "static")]
	public partial class SimpleLocation
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.tools.classfile.Dependency.Location
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SimpleLocation()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$SimpleLocation;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPackageName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassName", "()Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String name_Property
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

		[JniSignatureAttribute("Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String className_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SimpleLocation(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public SimpleLocation(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$SimpleLocation;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
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

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getPackageName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getClassName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$ClassFileError;", "public static")]
	public partial class ClassFileError
		: Dova.JDK.java.lang.Error
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassFileError()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$ClassFileError;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassFileError(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Throwable;)V", "public")]
		public ClassFileError(Dova.JDK.java.lang.Throwable arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$ClassFileError;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Lcom/sun/tools/classfile/Dependencies$ClassFileNotFoundException;", "public static")]
	public partial class ClassFileNotFoundException
		: Dova.JDK.java.lang.Exception
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassFileNotFoundException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/classfile/Dependencies$ClassFileNotFoundException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "className", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/Throwable;)V"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long serialVersionUID_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String className_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassFileNotFoundException(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public ClassFileNotFoundException(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Throwable;)V", "public")]
		public ClassFileNotFoundException(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Throwable arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/classfile/Dependencies$ClassFileNotFoundException;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
