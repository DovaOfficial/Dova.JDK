/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.11-07:59)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.com.sun.tools.javac.api;

[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "public")]
public partial class ClientCodeWrapper
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ClientCodeWrapper()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "trustedClasses", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/util/Context;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Lcom/sun/source/util/TaskListener;)Lcom/sun/source/util/TaskListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljavax/tools/JavaFileManager;)Ljavax/tools/JavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrap", "(Ljavax/tools/DiagnosticListener;)Ljavax/tools/DiagnosticListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isTrusted", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Lcom/sun/source/util/TaskListener;)Lcom/sun/source/util/TaskListener;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljava/util/Collection;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljavax/tools/Diagnostic;)Ljavax/tools/Diagnostic;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "unwrap", "(Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instance", "(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrappedToString", "(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "wrapJavaFileObjects", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
	}

	[JniSignatureAttribute("Ljava/util/Map;", "")]
	public Dova.JDK.java.util.Map trustedClasses_Property
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
	public ClientCodeWrapper(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)V", "protected")]
	public ClientCodeWrapper(Dova.JDK.com.sun.tools.javac.util.Context arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "public")]
	public Dova.JDK.javax.tools.FileObject wrap(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)Lcom/sun/source/util/TaskListener;", "")]
	public Dova.JDK.com.sun.source.util.TaskListener wrap(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskListener>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileObject;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject wrap(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager;)Ljavax/tools/JavaFileManager;", "public")]
	public Dova.JDK.javax.tools.JavaFileManager wrap(Dova.JDK.javax.tools.JavaFileManager arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/DiagnosticListener;)Ljavax/tools/DiagnosticListener;", "public")]
	public Dova.JDK.javax.tools.DiagnosticListener wrap(Dova.JDK.javax.tools.DiagnosticListener arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DiagnosticListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "protected")]
	public bool isTrusted(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/source/util/TaskListener;)Lcom/sun/source/util/TaskListener;", "")]
	public Dova.JDK.com.sun.source.util.TaskListener unwrap(Dova.JDK.com.sun.source.util.TaskListener arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskListener>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/util/Collection;", "")]
	public Dova.JDK.java.util.Collection unwrap(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/Diagnostic;)Ljavax/tools/Diagnostic;", "private")]
	public Dova.JDK.javax.tools.Diagnostic unwrap(Dova.JDK.javax.tools.Diagnostic arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.Diagnostic>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileObject;", "")]
	public Dova.JDK.javax.tools.JavaFileObject unwrap(Dova.JDK.javax.tools.JavaFileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "")]
	public Dova.JDK.javax.tools.FileObject unwrap(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;)Lcom/sun/tools/javac/api/ClientCodeWrapper;", "public static")]
	public static Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper instance(Dova.JDK.com.sun.tools.javac.util.Context arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/Object;)Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String wrappedToString(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable wrapJavaFileObjects(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedStandardJavaFileManager;", "protected")]
	public partial class WrappedStandardJavaFileManager
		: Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper.WrappedJavaFileManager
		, Dova.JDK.javax.tools.StandardJavaFileManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedStandardJavaFileManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedStandardJavaFileManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/StandardJavaFileManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationFromPaths", "(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromFiles", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromPaths", "(Ljava/util/Collection;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromPaths", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/lang/String;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/io/File;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/nio/file/Path;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromStrings", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationAsPaths", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPath", "(Ljavax/tools/FileObject;)Ljava/nio/file/Path;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathFactory", "(Ljavax/tools/StandardJavaFileManager$PathFactory;)V"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedStandardJavaFileManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/StandardJavaFileManager;)V", "")]
		public WrappedStandardJavaFileManager(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.javax.tools.StandardJavaFileManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedStandardJavaFileManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V", "public")]
		public void setLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V", "public")]
		public void setLocationFromPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.util.Collection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromFiles(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromPaths(Dova.JDK.java.util.Collection arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromPaths(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/Iterable;", "public transient")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("([Ljava/io/File;)Ljava/lang/Iterable;", "public transient")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.io.File> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("([Ljava/nio/file/Path;)Ljava/lang/Iterable;", "public transient")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.nio.file.Path> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromStrings(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V", "public")]
		public void setLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getLocationAsPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljava/nio/file/Path;", "public")]
		public Dova.JDK.java.nio.file.Path asPath(Dova.JDK.javax.tools.FileObject arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/StandardJavaFileManager$PathFactory;)V", "public")]
		public void setPathFactory(Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileManager;", "protected")]
	public partial class WrappedJavaFileManager
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.tools.JavaFileManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedJavaFileManager()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileManager;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientJavaFileManager", "Ljavax/tools/JavaFileManager;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/JavaFileManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/FileObject;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Set;Z)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceLoader", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Class;)Ljava/util/ServiceLoader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForInput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOption", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Ljava/lang/String;Ljava/util/Iterator;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForOutput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForOutput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForOutputForOriginatingFiles", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;[Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForInput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;)Ljavax/tools/FileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForOutputForOriginatingFiles", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;[Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileManager$Location;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
		}

		[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "protected")]
		public Dova.JDK.javax.tools.JavaFileManager clientJavaFileManager_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedJavaFileManager(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/JavaFileManager;)V", "")]
		public WrappedJavaFileManager(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.javax.tools.JavaFileManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileManager;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void flush()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/FileObject;)Z", "public")]
		public bool contains(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.FileObject arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Set;Z)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable list(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2, bool arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;", "public")]
		public Dova.JDK.java.lang.ClassLoader getClassLoader(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
		}

		[JniSignatureAttribute("()V", "public")]
		public void close()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5]);
		}

		[JniSignatureAttribute("(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z", "public")]
		public bool isSameFile(Dova.JDK.javax.tools.FileObject arg0, Dova.JDK.javax.tools.FileObject arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Class;)Ljava/util/ServiceLoader;", "public")]
		public Dova.JDK.java.util.ServiceLoader getServiceLoader(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.Class arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Ljavax/tools/JavaFileObject;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject getJavaFileForInput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
		public int isSupportedOption(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Iterator;)Z", "public")]
		public bool handleOption(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Iterator arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject getJavaFileForOutput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2, Dova.JDK.javax.tools.FileObject arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "public")]
		public Dova.JDK.javax.tools.FileObject getFileForOutput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.tools.FileObject arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Z", "public")]
		public bool hasLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;[Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;", "public transient")]
		public Dova.JDK.javax.tools.JavaFileObject getJavaFileForOutputForOriginatingFiles(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2, JavaArray<Dova.JDK.javax.tools.FileObject> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;)Ljavax/tools/FileObject;", "public")]
		public Dova.JDK.javax.tools.FileObject getFileForInput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;[Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "public transient")]
		public Dova.JDK.javax.tools.FileObject getFileForOutputForOriginatingFiles(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.javax.tools.FileObject> arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;", "public")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileManager$Location;", "public")]
		public Dova.JDK.javax.tools.JavaFileManager.Location getLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager.Location>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String inferModuleName(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable listLocationsForModules(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedFileObject;", "protected")]
	public partial class WrappedFileObject
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.tools.FileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientFileObject", "Ljavax/tools/FileObject;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/FileObject;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delete", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUri", "()Ljava/net/URI;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openInputStream", "()Ljava/io/InputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openOutputStream", "()Ljava/io/OutputStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openReader", "(Z)Ljava/io/Reader;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCharContent", "(Z)Ljava/lang/CharSequence;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openWriter", "()Ljava/io/Writer;"));
		}

		[JniSignatureAttribute("Ljavax/tools/FileObject;", "protected")]
		public Dova.JDK.javax.tools.FileObject clientFileObject_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/FileObject;)V", "")]
		public WrappedFileObject(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.javax.tools.FileObject arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedFileObject;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getName()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Z", "public")]
		public bool delete()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/net/URI;", "public")]
		public Dova.JDK.java.net.URI toUri()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getLastModified()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/io/InputStream;", "public")]
		public Dova.JDK.java.io.InputStream openInputStream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/OutputStream;", "public")]
		public Dova.JDK.java.io.OutputStream openOutputStream()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
		}

		[JniSignatureAttribute("(Z)Ljava/io/Reader;", "public")]
		public Dova.JDK.java.io.Reader openReader(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
		}

		[JniSignatureAttribute("(Z)Ljava/lang/CharSequence;", "public")]
		public Dova.JDK.java.lang.CharSequence getCharContent(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.CharSequence>(ret);
		}

		[JniSignatureAttribute("()Ljava/io/Writer;", "public")]
		public Dova.JDK.java.io.Writer openWriter()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.Writer>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileObject;", "protected")]
	public partial class WrappedJavaFileObject
		: Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper.WrappedFileObject
		, Dova.JDK.javax.tools.JavaFileObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedJavaFileObject()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileObject;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/JavaFileObject;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNameCompatible", "(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNestingKind", "()Ljavax/lang/model/element/NestingKind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAccessLevel", "()Ljavax/lang/model/element/Modifier;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/tools/JavaFileObject$Kind;"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedJavaFileObject(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/JavaFileObject;)V", "")]
		public WrappedJavaFileObject(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.javax.tools.JavaFileObject arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedJavaFileObject;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Z", "public")]
		public bool isNameCompatible(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.tools.JavaFileObject.Kind arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/NestingKind;", "public")]
		public Dova.JDK.javax.lang.model.element.NestingKind getNestingKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.NestingKind>(ret);
		}

		[JniSignatureAttribute("()Ljavax/lang/model/element/Modifier;", "public")]
		public Dova.JDK.javax.lang.model.element.Modifier getAccessLevel()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.lang.model.element.Modifier>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/JavaFileObject$Kind;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject.Kind>(ret);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedDiagnosticListener;", "protected")]
	public partial class WrappedDiagnosticListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.tools.DiagnosticListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedDiagnosticListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedDiagnosticListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientDiagnosticListener", "Ljavax/tools/DiagnosticListener;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/DiagnosticListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "report", "(Ljavax/tools/Diagnostic;)V"));
		}

		[JniSignatureAttribute("Ljavax/tools/DiagnosticListener;", "protected")]
		public Dova.JDK.javax.tools.DiagnosticListener clientDiagnosticListener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.DiagnosticListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedDiagnosticListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Ljavax/tools/DiagnosticListener;)V", "")]
		public WrappedDiagnosticListener(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.javax.tools.DiagnosticListener arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedDiagnosticListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/Diagnostic;)V", "public")]
		public void report(Dova.JDK.javax.tools.Diagnostic arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedTaskListener;", "protected")]
	public partial class WrappedTaskListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.com.sun.source.util.TaskListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WrappedTaskListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedTaskListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clientTaskListener", "Lcom/sun/source/util/TaskListener;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Lcom/sun/source/util/TaskListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "started", "(Lcom/sun/source/util/TaskEvent;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "finished", "(Lcom/sun/source/util/TaskEvent;)V"));
		}

		[JniSignatureAttribute("Lcom/sun/source/util/TaskListener;", "protected")]
		public Dova.JDK.com.sun.source.util.TaskListener clientTaskListener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.source.util.TaskListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WrappedTaskListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Lcom/sun/source/util/TaskListener;)V", "")]
		public WrappedTaskListener(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.com.sun.source.util.TaskListener arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$WrappedTaskListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent;)V", "public")]
		public void started(Dova.JDK.com.sun.source.util.TaskEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("(Lcom/sun/source/util/TaskEvent;)V", "public")]
		public void finished(Dova.JDK.com.sun.source.util.TaskEvent arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$DiagnosticSourceUnwrapper;", "public")]
	public partial class DiagnosticSourceUnwrapper
		: Dova.JDK.java.lang.Object
		, Dova.JDK.javax.tools.Diagnostic
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DiagnosticSourceUnwrapper()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$DiagnosticSourceUnwrapper;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "d", "Lcom/sun/tools/javac/util/JCDiagnostic;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lcom/sun/tools/javac/api/ClientCodeWrapper;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/tools/javac/api/ClientCodeWrapper;Lcom/sun/tools/javac/util/JCDiagnostic;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMessage", "(Ljava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLineNumber", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource_0", "()Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSource_1", "()Ljavax/tools/JavaFileObject;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStartPosition", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEndPosition", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getColumnNumber", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCode", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getKind", "()Ljavax/tools/Diagnostic$Kind;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPosition", "()J"));
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/util/JCDiagnostic;", "public final")]
		public Dova.JDK.com.sun.tools.javac.util.JCDiagnostic d_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.util.JCDiagnostic>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper;", "final")]
		public Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DiagnosticSourceUnwrapper(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lcom/sun/tools/javac/api/ClientCodeWrapper;Lcom/sun/tools/javac/util/JCDiagnostic;)V", "")]
		public DiagnosticSourceUnwrapper(Dova.JDK.com.sun.tools.javac.api.ClientCodeWrapper arg0, Dova.JDK.com.sun.tools.javac.util.JCDiagnostic arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/api/ClientCodeWrapper$DiagnosticSourceUnwrapper;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getMessage(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getLineNumber()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public volatile")]
		public Dova.JDK.java.lang.Object getSource_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/JavaFileObject;", "public")]
		public Dova.JDK.javax.tools.JavaFileObject getSource_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getStartPosition()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long getEndPosition()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("()J", "public")]
		public long getColumnNumber()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getCode()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljavax/tools/Diagnostic$Kind;", "public")]
		public Dova.JDK.javax.tools.Diagnostic.Kind getKind()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.Diagnostic.Kind>(ret);
		}

		[JniSignatureAttribute("()J", "public")]
		public long getPosition()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
			return ret;
		}
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/api/ClientCodeWrapper$Trusted;", "public abstract static interface")]
	public partial interface Trusted
		: IJavaObject
		, Dova.JDK.java.lang.annotation.Annotation
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }


		static Trusted()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/api/ClientCodeWrapper$Trusted;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		}
	}
}
