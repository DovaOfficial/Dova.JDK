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

namespace Dova.JDK.javax.tools;

[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager;", "public abstract interface")]
public partial interface StandardJavaFileManager
	: IJavaObject
	, Dova.JDK.javax.tools.JavaFileManager
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardJavaFileManager()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/StandardJavaFileManager;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isSameFile", "(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjectsFromStrings", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "asFiles", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "asCollection", "(Ljava/lang/Iterable;)Ljava/util/Collection;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjectsFromPaths", "(Ljava/util/Collection;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjectsFromPaths", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "asPaths", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjects", "([Ljava/lang/String;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjects", "([Ljava/io/File;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjects", "([Ljava/nio/file/Path;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLocationFromPaths", "(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLocationForModule", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLocationAsPaths", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "asPath", "(Ljavax/tools/FileObject;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setPathFactory", "(Ljavax/tools/StandardJavaFileManager$PathFactory;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getJavaFileObjectsFromFiles", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "setLocation", "(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V"));
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public abstract")]
	Dova.JDK.java.lang.Iterable getLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;Ljavax/tools/FileObject;)Z", "public abstract")]
	bool isSameFile(Dova.JDK.javax.tools.FileObject arg0, Dova.JDK.javax.tools.FileObject arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public abstract")]
	Dova.JDK.java.lang.Iterable getJavaFileObjectsFromStrings(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "private static")]
	static Dova.JDK.java.lang.Iterable asFiles(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/util/Collection;", "private static")]
	static Dova.JDK.java.util.Collection asCollection(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Collection>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Collection;)Ljava/lang/Iterable;", "public")]
	Dova.JDK.java.lang.Iterable getJavaFileObjectsFromPaths(Dova.JDK.java.util.Collection arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public")]
	Dova.JDK.java.lang.Iterable getJavaFileObjectsFromPaths(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "private static")]
	static Dova.JDK.java.lang.Iterable asPaths(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;)Ljava/lang/Iterable;", "public abstract transient")]
	Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.lang.String> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("([Ljava/io/File;)Ljava/lang/Iterable;", "public abstract transient")]
	Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.io.File> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/file/Path;)Ljava/lang/Iterable;", "public transient")]
	Dova.JDK.java.lang.Iterable getJavaFileObjects(JavaArray<Dova.JDK.java.nio.file.Path> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/util/Collection;)V", "public")]
	void setLocationFromPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.util.Collection arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/String;Ljava/util/Collection;)V", "public")]
	void setLocationForModule(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.util.Collection arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", "public")]
	Dova.JDK.java.lang.Iterable getLocationAsPaths(Dova.JDK.javax.tools.JavaFileManager.Location arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/FileObject;)Ljava/nio/file/Path;", "public")]
	Dova.JDK.java.nio.file.Path asPath(Dova.JDK.javax.tools.FileObject arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/StandardJavaFileManager$PathFactory;)V", "public")]
	void setPathFactory(Dova.JDK.javax.tools.StandardJavaFileManager.PathFactory arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;)Ljava/lang/Iterable;", "public abstract")]
	Dova.JDK.java.lang.Iterable getJavaFileObjectsFromFiles(Dova.JDK.java.lang.Iterable arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/tools/JavaFileManager$Location;Ljava/lang/Iterable;)V", "public abstract")]
	void setLocation(Dova.JDK.javax.tools.JavaFileManager.Location arg0, Dova.JDK.java.lang.Iterable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
	}

	[JniSignatureAttribute("Ljavax/tools/StandardJavaFileManager$PathFactory;", "public abstract static interface")]
	public partial interface PathFactory
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PathFactory()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljavax/tools/StandardJavaFileManager$PathFactory;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getPath", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;"));
		}

		[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;", "public abstract transient")]
		Dova.JDK.java.nio.file.Path getPath(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
	}
}
