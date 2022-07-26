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

namespace Dova.JDK.com.sun.tools.javac.main;

[JniSignatureAttribute("Lcom/sun/tools/javac/main/DelegatingJavaFileManager;", "public")]
public partial class DelegatingJavaFileManager
	: Dova.JDK.java.lang.Object
	, Dova.JDK.javax.tools.JavaFileManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DelegatingJavaFileManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/DelegatingJavaFileManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "releaseFM", "Ljavax/tools/JavaFileManager;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseFM", "Ljavax/tools/JavaFileManager;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileManager;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "flush", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "contains", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/FileObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "list", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Set;Z)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delegate", "(Ljavax/tools/JavaFileManager$Location;)Ljavax/tools/JavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getServiceLoader", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Class;)Ljava/util/ServiceLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedOption", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForOutput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForOutput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForInput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileForOutputForOriginatingFiles", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;[Ljavax/tools/FileObject;)Ljavax/tools/FileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferModuleName", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "listLocationsForModules", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasLocation", "(Ljavax/tools/JavaFileManager$Location;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForInput", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "inferBinaryName", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljavax/tools/JavaFileManager$Location;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBaseFileManager", "()Ljavax/tools/JavaFileManager;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileForOutputForOriginatingFiles", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;[Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "handleOption", "(Ljava/lang/String;Ljava/util/Iterator;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "installReleaseFileManager", "(Lcom/sun/tools/javac/util/Context;Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileManager;)V"));
	}

	[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "private final")]
	public Dova.JDK.javax.tools.JavaFileManager releaseFM_Property
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

	[JniSignatureAttribute("Ljavax/tools/JavaFileManager;", "private final")]
	public Dova.JDK.javax.tools.JavaFileManager baseFM_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DelegatingJavaFileManager(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileManager;)V", "private")]
	public DelegatingJavaFileManager(Dova.JDK.javax.tools.JavaFileManager arg0, Dova.JDK.javax.tools.JavaFileManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/DelegatingJavaFileManager;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public")]
	public void flush()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/FileObject;)Z", "public")]
	public bool contains(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.FileObject arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Set;Z)Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable list(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Set arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/ClassLoader;", "public")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljavax/tools/JavaFileManager;", "private")]
	public Dova.JDK.javax.tools.JavaFileManager @delegate(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
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

	[JniSignatureAttribute("(Ljava/lang/String;)I", "public")]
	public int isSupportedOption(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject getJavaFileForOutput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2, Dova.JDK.javax.tools.FileObject arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "public")]
	public Dova.JDK.javax.tools.FileObject getFileForOutput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.javax.tools.FileObject arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;)Ljavax/tools/FileObject;", "public")]
	public Dova.JDK.javax.tools.FileObject getFileForInput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/lang/String;[Ljavax/tools/FileObject;)Ljavax/tools/FileObject;", "public transient")]
	public Dova.JDK.javax.tools.FileObject getFileForOutputForOriginatingFiles(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.String arg2, JavaArray<Dova.JDK.javax.tools.FileObject> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.FileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String inferModuleName(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable listLocationsForModules(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Z", "public")]
	public bool hasLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;)Ljavax/tools/JavaFileObject;", "public")]
	public Dova.JDK.javax.tools.JavaFileObject getJavaFileForInput(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljavax/tools/JavaFileObject;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String inferBinaryName(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.javax.tools.JavaFileObject arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
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

	[JniSignatureAttribute("()Ljavax/tools/JavaFileManager;", "public")]
	public Dova.JDK.javax.tools.JavaFileManager getBaseFileManager()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileManager>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljavax/tools/JavaFileObject$Kind;[Ljavax/tools/FileObject;)Ljavax/tools/JavaFileObject;", "public transient")]
	public Dova.JDK.javax.tools.JavaFileObject getJavaFileForOutputForOriginatingFiles(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.tools.JavaFileObject.Kind arg2, JavaArray<Dova.JDK.javax.tools.FileObject> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.JavaFileObject>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Iterator;)Z", "public")]
	public bool handleOption(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Iterator arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/tools/javac/util/Context;Ljavax/tools/JavaFileManager;Ljavax/tools/JavaFileManager;)V", "public static")]
	public static void installReleaseFileManager(Dova.JDK.com.sun.tools.javac.util.Context arg0, Dova.JDK.javax.tools.JavaFileManager arg1, Dova.JDK.javax.tools.JavaFileManager arg2)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("Lcom/sun/tools/javac/main/DelegatingJavaFileManager$DelegatingSJFM;", "private static final")]
	public partial class DelegatingSJFM
		: Dova.JDK.com.sun.tools.javac.main.DelegatingJavaFileManager
		, Dova.JDK.javax.tools.StandardJavaFileManager
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DelegatingSJFM()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/tools/javac/main/DelegatingJavaFileManager$DelegatingSJFM;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseSJFM", "Ljavax/tools/StandardJavaFileManager;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljavax/tools/JavaFileManager;Ljavax/tools/StandardJavaFileManager;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromStrings", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromPaths", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromPaths", "(Ljava/util/Collection;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/lang/String;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/nio/file/Path;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjects", "([Ljava/io/File;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationFromPaths", "(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocationAsPaths", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asPath", "(Ljavax/tools/FileObject;)Ljava/nio/file/Path;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPathFactory", "(Ljavax/tools/StandardJavaFileManager$PathFactory;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaFileObjectsFromFiles", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setLocation", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V"));
		}

		[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager;", "private final")]
		public Dova.JDK.javax.tools.StandardJavaFileManager baseSJFM_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.javax.tools.StandardJavaFileManager>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DelegatingSJFM(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager;Ljavax/tools/StandardJavaFileManager;)V", "private")]
		public DelegatingSJFM(Dova.JDK.javax.tools.JavaFileManager arg0, Dova.JDK.javax.tools.StandardJavaFileManager arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Lcom/sun/tools/javac/main/DelegatingJavaFileManager$DelegatingSJFM;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z", "public")]
		public bool isSameFile(Dova.JDK.javax.tools.FileObject arg0, Dova.JDK.javax.tools.FileObject arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromStrings(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromPaths(Dova.JDK.java.lang.Iterable arg0)
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

		[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/Iterable;", "public transient")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.lang.String> arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("([Ljava/nio/file/Path;)Ljava/lang/Iterable;", "public transient")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.nio.file.Path> arg0)
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

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V", "public")]
		public void setLocationFromPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.util.Collection arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V", "public")]
		public void setLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getLocationAsPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljava/nio/file/Path;", "public")]
		public Dova.JDK.java.nio.file.Path asPath(Dova.JDK.javax.tools.FileObject arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/StandardJavaFileManager$PathFactory;)V", "public")]
		public void setPathFactory(Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		}

		[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
		public Dova.JDK.java.lang.Iterable getJavaFileObjectsFromFiles(Dova.JDK.java.lang.Iterable arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
		}

		[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V", "public")]
		public void setLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.Iterable arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		}
	}
}
