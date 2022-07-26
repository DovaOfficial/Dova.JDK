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

namespace Dova.JDK.jdk.@internal.module;

[JniSignatureAttribute("Ljdk/internal/module/ModuleReferences;", "")]
public partial class ModuleReferences
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ModuleReferences()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleReferences;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newModule", "(Ljdk/internal/module/ModuleInfo$Attributes;Ljava/net/URI;Ljava/util/function/Supplier;Ljdk/internal/module/ModulePatcher;Ljdk/internal/module/ModuleHashes$HashSupplier;)Ljava/lang/module/ModuleReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newJModModule", "(Ljdk/internal/module/ModuleInfo$Attributes;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newJarModule", "(Ljdk/internal/module/ModuleInfo$Attributes;Ljdk/internal/module/ModulePatcher;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newExplodedModule", "(Ljdk/internal/module/ModuleInfo$Attributes;Ljdk/internal/module/ModulePatcher;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ModuleReferences(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public ModuleReferences() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleReferences;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/internal/module/ModuleInfo$Attributes;Ljava/net/URI;Ljava/util/function/Supplier;Ljdk/internal/module/ModulePatcher;Ljdk/internal/module/ModuleHashes$HashSupplier;)Ljava/lang/module/ModuleReference;", "private static")]
	public static Dova.JDK.java.lang.module.ModuleReference newModule(Dova.JDK.jdk.@internal.module.ModuleInfo.Attributes arg0, Dova.JDK.java.net.URI arg1, Dova.JDK.java.util.function.Supplier arg2, Dova.JDK.jdk.@internal.module.ModulePatcher arg3, Dova.JDK.jdk.@internal.module.ModuleHashes.HashSupplier arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/module/ModuleInfo$Attributes;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;", "static")]
	public static Dova.JDK.java.lang.module.ModuleReference newJModModule(Dova.JDK.jdk.@internal.module.ModuleInfo.Attributes arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/module/ModuleInfo$Attributes;Ljdk/internal/module/ModulePatcher;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;", "static")]
	public static Dova.JDK.java.lang.module.ModuleReference newJarModule(Dova.JDK.jdk.@internal.module.ModuleInfo.Attributes arg0, Dova.JDK.jdk.@internal.module.ModulePatcher arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/module/ModuleInfo$Attributes;Ljdk/internal/module/ModulePatcher;Ljava/nio/file/Path;)Ljava/lang/module/ModuleReference;", "static")]
	public static Dova.JDK.java.lang.module.ModuleReference newExplodedModule(Dova.JDK.jdk.@internal.module.ModuleInfo.Attributes arg0, Dova.JDK.jdk.@internal.module.ModulePatcher arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.module.ModuleReference>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/module/ModuleReferences$ExplodedModuleReader;", "static")]
	public partial class ExplodedModuleReader
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.module.ModuleReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ExplodedModuleReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleReferences$ExplodedModuleReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dir", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "read", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path dir_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private volatile")]
		public bool closed_Property
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
		public ExplodedModuleReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "")]
		public ExplodedModuleReader(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleReferences$ExplodedModuleReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public")]
		public Dova.JDK.java.util.stream.Stream list()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional find(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional read(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
		public Dova.JDK.java.util.Optional open(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()V", "private")]
		public void ensureOpen()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/module/ModuleReferences$JModModuleReader;", "static")]
	public partial class JModModuleReader
		: Dova.JDK.jdk.@internal.module.ModuleReferences.SafeCloseModuleReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JModModuleReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleReferences$JModModuleReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jf", "Ljdk/internal/jmod/JmodFile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uri", "Ljava/net/URI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/net/URI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntry", "(Ljava/lang/String;)Ljdk/internal/jmod/JmodFile$Entry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implClose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newJmodFile", "(Ljava/nio/file/Path;)Ljdk/internal/jmod/JmodFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implFind", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implOpen", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implList", "()Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("Ljdk/internal/jmod/JmodFile;", "private final")]
		public Dova.JDK.jdk.@internal.jmod.JmodFile jf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jmod.JmodFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/URI;", "private final")]
		public Dova.JDK.java.net.URI uri_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JModModuleReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/net/URI;)V", "")]
		public JModModuleReader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.net.URI arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleReferences$JModModuleReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jmod/JmodFile$Entry;", "private")]
		public Dova.JDK.jdk.@internal.jmod.JmodFile.Entry getEntry(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jmod.JmodFile.Entry>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void implClose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/internal/jmod/JmodFile;", "static")]
		public static Dova.JDK.jdk.@internal.jmod.JmodFile newJmodFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jmod.JmodFile>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional implFind(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional implOpen(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream implList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/module/ModuleReferences$JarModuleReader;", "static")]
	public partial class JarModuleReader
		: Dova.JDK.jdk.@internal.module.ModuleReferences.SafeCloseModuleReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JarModuleReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleReferences$JarModuleReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "jf", "Ljava/util/jar/JarFile;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "uri", "Ljava/net/URI;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;Ljava/net/URI;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEntry", "(Ljava/lang/String;)Ljava/util/jar/JarEntry;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implClose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implFind", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implOpen", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implList", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newJarFile", "(Ljava/nio/file/Path;)Ljava/util/jar/JarFile;"));
		}

		[JniSignatureAttribute("Ljava/util/jar/JarFile;", "private final")]
		public Dova.JDK.java.util.jar.JarFile jf_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/net/URI;", "private final")]
		public Dova.JDK.java.net.URI uri_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JarModuleReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/net/URI;)V", "")]
		public JarModuleReader(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.net.URI arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleReferences$JarModuleReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/jar/JarEntry;", "private")]
		public Dova.JDK.java.util.jar.JarEntry getEntry(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarEntry>(ret);
		}

		[JniSignatureAttribute("()V", "")]
		public void implClose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional implFind(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "")]
		public Dova.JDK.java.util.Optional implOpen(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "")]
		public Dova.JDK.java.util.stream.Stream implList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/util/jar/JarFile;", "static")]
		public static Dova.JDK.java.util.jar.JarFile newJarFile(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.jar.JarFile>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/module/ModuleReferences$SafeCloseModuleReader;", "abstract static")]
	public partial class SafeCloseModuleReader
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.module.ModuleReader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SafeCloseModuleReader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/module/ModuleReferences$SafeCloseModuleReader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lock", "Ljava/util/concurrent/locks/ReadWriteLock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "readLock", "Ljava/util/concurrent/locks/Lock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "writeLock", "Ljava/util/concurrent/locks/Lock;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "closed", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "()Ljava/util/stream/Stream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "find", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implClose", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implFind", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implOpen", "(Ljava/lang/String;)Ljava/util/Optional;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implList", "()Ljava/util/stream/Stream;"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/ReadWriteLock;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.ReadWriteLock @lock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.ReadWriteLock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/Lock;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.Lock readLock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/locks/Lock;", "private final")]
		public Dova.JDK.java.util.concurrent.locks.Lock writeLock_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.locks.Lock>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private")]
		public bool closed_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SafeCloseModuleReader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "")]
		public SafeCloseModuleReader() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/module/ModuleReferences$SafeCloseModuleReader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public final")]
		public Dova.JDK.java.util.stream.Stream list()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public final")]
		public Dova.JDK.java.util.Optional find(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()V", "public final")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public final")]
		public Dova.JDK.java.util.Optional open(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()V", "abstract")]
		public void implClose()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "abstract")]
		public Dova.JDK.java.util.Optional implFind(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "abstract")]
		public Dova.JDK.java.util.Optional implOpen(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
		}

		[JniSignatureAttribute("()Ljava/util/stream/Stream;", "abstract")]
		public Dova.JDK.java.util.stream.Stream implList()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
		}
	}
}
