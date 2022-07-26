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

namespace Dova.JDK.com.sun.tools.jdeps;

[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration;", "public")]
public partial class JdepsConfiguration
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.lang.AutoCloseable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JdepsConfiguration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsConfiguration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_MODULE_PATH", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_DEFAULT", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ALL_SYSTEM", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MODULE_INFO", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "system", "Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "finder", "Ljava/lang/module/ModuleFinder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nameToModule", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageToModule", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "packageToUnnamedModule", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classpathArchives", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialArchives", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootModules", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/lang/Runtime$Version;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/module/Configuration;Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;Ljava/lang/module/ModuleFinder;Ljava/util/Set;Ljava/util/List;Ljava/util/List;Ljava/lang/Runtime$Version;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPackageName", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Lcom/sun/tools/classfile/Dependency$Location;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "(Ljava/util/Set;)Ljava/lang/module/Configuration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findModule", "(Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getVersion", "()Ljava/lang/Runtime$Version;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "splitPackages", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isToken", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "rootModules", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initialArchives", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addPackagesInUnnamedModule", "(Lcom/sun/tools/jdeps/Archive;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initProfiles", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toModule", "(Ljava/lang/module/ModuleReference;)Lcom/sun/tools/jdeps/Module;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addModuleReference", "(Ljava/lang/module/ModuleReference;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findModuleDescriptor", "(Ljava/lang/String;)Ljava/util/Optional;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getModules", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "classPathArchives", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ALL_MODULE_PATH_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ALL_DEFAULT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String ALL_SYSTEM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String MODULE_INFO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;", "private final")]
	public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.SystemModuleFinder system_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.SystemModuleFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/module/ModuleFinder;", "private final")]
	public Dova.JDK.java.lang.module.ModuleFinder finder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map nameToModule_Property
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

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map packageToModule_Property
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
	public Dova.JDK.java.util.Map packageToUnnamedModule_Property
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

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List classpathArchives_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List initialArchives_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set rootModules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Runtime$Version;", "private final")]
	public Dova.JDK.java.lang.Runtime.Version version_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runtime.Version>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JdepsConfiguration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/module/Configuration;Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;Ljava/lang/module/ModuleFinder;Ljava/util/Set;Ljava/util/List;Ljava/util/List;Ljava/lang/Runtime$Version;)V", "private")]
	public JdepsConfiguration(Dova.JDK.java.lang.module.Configuration arg0, Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.SystemModuleFinder arg1, Dova.JDK.java.lang.module.ModuleFinder arg2, Dova.JDK.java.util.Set arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.util.List arg5, Dova.JDK.java.lang.Runtime.Version arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsConfiguration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String toPackageName(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/classfile/Dependency$Location;)Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional findClass(Dova.JDK.com.sun.tools.classfile.Dependency.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)Ljava/lang/module/Configuration;", "public")]
	public Dova.JDK.java.lang.module.Configuration resolve(Dova.JDK.java.util.Set arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.Configuration>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional findModule(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Runtime$Version;", "public")]
	public Dova.JDK.java.lang.Runtime.Version getVersion()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runtime.Version>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map splitPackages()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "public static")]
	public static bool isToken(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set rootModules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List initialArchives()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/jdeps/Archive;)V", "private")]
	public void addPackagesInUnnamedModule(Dova.JDK.com.sun.tools.jdeps.Archive arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initProfiles()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleReference;)Lcom/sun/tools/jdeps/Module;", "public")]
	public Dova.JDK.com.sun.tools.jdeps.Module toModule(Dova.JDK.java.lang.module.ModuleReference arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.Module>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/module/ModuleReference;)V", "private")]
	public void addModuleReference(Dova.JDK.java.lang.module.ModuleReference arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional findModuleDescriptor(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "public")]
	public Dova.JDK.java.util.Map getModules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List classPathArchives()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;", "static")]
	public partial class SystemModuleFinder
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.module.ModuleFinder
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SystemModuleFinder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_HOME", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fileSystem", "Ljava/nio/file/FileSystem;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "root", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemModules", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "walk", "(Ljava/nio/file/Path;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findAll", "()Ljava/util/Set;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "moduleNames", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toModuleReference", "(Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassReader", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/ClassFileReader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dropHashes", "(Ljava/lang/module/ModuleDescriptor;)Ljava/lang/module/ModuleDescriptor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defaultSystemRoots", "()Ljava/util/Set;"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
		public static Dova.JDK.java.lang.String JAVA_HOME_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/FileSystem;", "private final")]
		public Dova.JDK.java.nio.file.FileSystem fileSystem_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path root_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map systemModules_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SystemModuleFinder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SystemModuleFinder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public SystemModuleFinder(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional find(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/Map;", "private")]
		public Dova.JDK.java.util.Map walk(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set findAll()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream moduleNames()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;", "private")]
		public Dova.JDK.java.lang.module.ModuleReference toModuleReference(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/ClassFileReader;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.ClassFileReader getClassReader(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.ClassFileReader>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/module/ModuleDescriptor;)Ljava/lang/module/ModuleDescriptor;", "private")]
		public Dova.JDK.java.lang.module.ModuleDescriptor dropHashes(Dova.JDK.java.lang.module.ModuleDescriptor arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleDescriptor>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/Set;", "public")]
		public Dova.JDK.java.util.Set defaultSystemRoots()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public static")]
	public partial class Builder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Builder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "systemModulePath", "Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootModules", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "initialArchives", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paths", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classPaths", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "tokens", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "upgradeModulePath", "Ljava/lang/module/ModuleFinder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "appModulePath", "Ljava/lang/module/ModuleFinder;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "version", "Ljava/lang/Runtime$Version;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "build", "()Lcom/sun/tools/jdeps/JdepsConfiguration;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "upgradeModulePath", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appModulePath", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addmods", "(Ljava/util/Set;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addClassPath", "(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multiRelease", "(Ljava/lang/Runtime$Version;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addRoot", "(Ljava/nio/file/Path;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createModulePathFinder", "(Ljava/lang/String;)Ljava/lang/module/ModuleFinder;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassPaths", "(Ljava/lang/String;)Ljava/util/List;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/jdeps/JdepsConfiguration$SystemModuleFinder;", "final")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.SystemModuleFinder systemModulePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.SystemModuleFinder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set rootModules_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List initialArchives_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List paths_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List classPaths_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "final")]
		public Dova.JDK.java.util.Set tokens_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/module/ModuleFinder;", "")]
		public Dova.JDK.java.lang.module.ModuleFinder upgradeModulePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/module/ModuleFinder;", "")]
		public Dova.JDK.java.lang.module.ModuleFinder appModulePath_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runtime$Version;", "")]
		public Dova.JDK.java.lang.Runtime.Version version_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runtime.Version>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Builder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "public")]
		public Builder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public Builder(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Lcom/sun/tools/jdeps/JdepsConfiguration;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration build()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder upgradeModulePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder appModulePath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder addmods(Dova.JDK.java.util.Set arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder addClassPath(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runtime$Version;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder multiRelease(Dova.JDK.java.lang.Runtime.Version arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Lcom/sun/tools/jdeps/JdepsConfiguration$Builder;", "public")]
		public Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder addRoot(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.jdeps.JdepsConfiguration.Builder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/module/ModuleFinder;", "private static")]
		public static Dova.JDK.java.lang.module.ModuleFinder createModulePathFinder(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleFinder>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/List;", "private")]
		public Dova.JDK.java.util.List getClassPaths(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
	}
}
