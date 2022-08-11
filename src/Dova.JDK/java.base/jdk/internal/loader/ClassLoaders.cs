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

namespace Dova.JDK.jdk.@internal.loader;

[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders;", "public")]
public partial class ClassLoaders
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClassLoaders()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/loader/ClassLoaders;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JLA", "Ljdk/internal/access/JavaLangAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BOOT_LOADER", "Ljdk/internal/loader/ClassLoaders$BootClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PLATFORM_LOADER", "Ljdk/internal/loader/ClassLoaders$PlatformClassLoader;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "APP_LOADER", "Ljdk/internal/loader/ClassLoaders$AppClassLoader;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toFileURL", "(Ljava/lang/String;)Ljava/net/URL;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "platformClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appClassLoader", "()Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "bootLoader", "()Ljdk/internal/loader/BuiltinClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setArchivedServicesCatalog", "(Ljava/lang/ClassLoader;)V"));
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaLangAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaLangAccess JLA_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaLangAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$BootClassLoader;", "private static final")]
	public static Dova.JDK.jdk.@internal.loader.ClassLoaders.BootClassLoader BOOT_LOADER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.loader.ClassLoaders.BootClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$PlatformClassLoader;", "private static final")]
	public static Dova.JDK.jdk.@internal.loader.ClassLoaders.PlatformClassLoader PLATFORM_LOADER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.loader.ClassLoaders.PlatformClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$AppClassLoader;", "private static final")]
	public static Dova.JDK.jdk.@internal.loader.ClassLoaders.AppClassLoader APP_LOADER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.loader.ClassLoaders.AppClassLoader>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ClassLoaders(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ClassLoaders() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/loader/ClassLoaders;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/net/URL;", "private static")]
	public static Dova.JDK.java.net.URL toFileURL(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URL>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public static")]
	public static Dova.JDK.java.lang.ClassLoader platformClassLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/ClassLoader;", "public static")]
	public static Dova.JDK.java.lang.ClassLoader appClassLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/loader/BuiltinClassLoader;", "static")]
	public static Dova.JDK.jdk.@internal.loader.BuiltinClassLoader bootLoader()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.loader.BuiltinClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;)V", "private static")]
	public static void setArchivedServicesCatalog(Dova.JDK.java.lang.ClassLoader arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$BootClassLoader;", "private static")]
	public partial class BootClassLoader
		: Dova.JDK.jdk.@internal.loader.BuiltinClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BootClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/loader/ClassLoaders$BootClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/loader/URLClassPath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClassOrNull", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BootClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/loader/URLClassPath;)V", "")]
		public BootClassLoader(Dova.JDK.jdk.@internal.loader.URLClassPath arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/loader/ClassLoaders$BootClassLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "protected")]
		public Dova.JDK.java.lang.Class loadClassOrNull(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$PlatformClassLoader;", "private static")]
	public partial class PlatformClassLoader
		: Dova.JDK.jdk.@internal.loader.BuiltinClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PlatformClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/loader/ClassLoaders$PlatformClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/loader/ClassLoaders$BootClassLoader;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PlatformClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/loader/ClassLoaders$BootClassLoader;)V", "")]
		public PlatformClassLoader(Dova.JDK.jdk.@internal.loader.ClassLoaders.BootClassLoader arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/loader/ClassLoaders$PlatformClassLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljdk/internal/loader/ClassLoaders$AppClassLoader;", "private static")]
	public partial class AppClassLoader
		: Dova.JDK.jdk.@internal.loader.BuiltinClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AppClassLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/loader/ClassLoaders$AppClassLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/loader/BuiltinClassLoader;Ljdk/internal/loader/URLClassPath;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "defineOrCheckPackage", "(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendToClassPathForInstrumentation", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resetArchivedStates", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPermissions", "(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AppClassLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/internal/loader/BuiltinClassLoader;Ljdk/internal/loader/URLClassPath;)V", "")]
		public AppClassLoader(Dova.JDK.jdk.@internal.loader.BuiltinClassLoader arg0, Dova.JDK.jdk.@internal.loader.URLClassPath arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/loader/ClassLoaders$AppClassLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "protected")]
		public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/jar/Manifest;Ljava/net/URL;)Ljava/lang/Package;", "protected")]
		public Dova.JDK.java.lang.Package defineOrCheckPackage(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.jar.Manifest arg1, Dova.JDK.java.net.URL arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Package>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public void appendToClassPathForInstrumentation(Dova.JDK.java.lang.String arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}

		[JniSignatureAttribute("()V", "private")]
		public void resetArchivedStates()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/security/CodeSource;)Ljava/security/PermissionCollection;", "protected")]
		public Dova.JDK.java.security.PermissionCollection getPermissions(Dova.JDK.java.security.CodeSource arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.security.PermissionCollection>(ret);
		}
	}
}
