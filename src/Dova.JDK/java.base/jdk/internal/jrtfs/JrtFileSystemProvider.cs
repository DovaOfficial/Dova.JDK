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

namespace Dova.JDK.jdk.@internal.jrtfs;

[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileSystemProvider;", "public final")]
public partial class JrtFileSystemProvider
	: Dova.JDK.java.nio.file.spi.FileSystemProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JrtFileSystemProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jrtfs/JrtFileSystemProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "theFileSystem", "Ljava/nio/file/FileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JRT_FS_JAR", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHidden", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPermission", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "delete", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkAccess", "(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copy", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getScheme", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath", "(Ljava/net/URI;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDirectory", "(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileSystem", "(Ljava/net/URI;)Ljava/nio/file/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileSystem", "(Ljava/lang/String;Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileSystem", "(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOutputStream", "(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectoryStream", "(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream$Filter;)Ljava/nio/file/DirectoryStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readSymbolicLink", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStore", "(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setAttribute", "(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newAsynchronousFileChannel", "(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkUri", "(Ljava/net/URI;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newJrtFsLoader", "(Ljava/nio/file/Path;)Ljava/net/URLClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTheFileSystem", "()Ljava/nio/file/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toJrtPath", "(Ljava/nio/file/Path;)Ljdk/internal/jrtfs/JrtPath;"));
	}

	[JniSignatureAttribute("Ljava/nio/file/FileSystem;", "private volatile")]
	public Dova.JDK.java.nio.file.FileSystem theFileSystem_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String JRT_FS_JAR_Property
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

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JrtFileSystemProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JrtFileSystemProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtFileSystemProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool isHidden(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "private")]
	public void checkPermission()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public final")]
	public void delete(Dova.JDK.java.nio.file.Path arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/AccessMode;)V", "public transient")]
	public void checkAccess(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.AccessMode> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", "public transient")]
	public void copy(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1, JavaArray<Dova.JDK.java.nio.file.CopyOption> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getScheme()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path getPath(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/attribute/FileAttribute;)V", "public transient")]
	public void createDirectory(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)Ljava/nio/file/FileSystem;", "public")]
	public Dova.JDK.java.nio.file.FileSystem getFileSystem(Dova.JDK.java.net.URI arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;", "private")]
	public Dova.JDK.java.nio.file.FileSystem newFileSystem(Dova.JDK.java.lang.String arg0, Dova.JDK.java.net.URI arg1, Dova.JDK.java.util.Map arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;Ljava/util/Map;)Ljava/nio/file/FileSystem;", "public")]
	public Dova.JDK.java.nio.file.FileSystem newFileSystem(Dova.JDK.java.net.URI arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/InputStream;", "public transient")]
	public Dova.JDK.java.io.InputStream newInputStream(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", "public transient")]
	public Dova.JDK.java.io.OutputStream newOutputStream(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", "public transient")]
	public Dova.JDK.java.nio.channels.SeekableByteChannel newByteChannel(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SeekableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/DirectoryStream$Filter;)Ljava/nio/file/DirectoryStream;", "public")]
	public Dova.JDK.java.nio.file.DirectoryStream newDirectoryStream(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.DirectoryStream.Filter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.DirectoryStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;[Ljava/nio/file/CopyOption;)V", "public transient")]
	public void move(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1, JavaArray<Dova.JDK.java.nio.file.CopyOption> arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public")]
	public Dova.JDK.java.nio.file.Path readSymbolicLink(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/FileStore;", "public")]
	public Dova.JDK.java.nio.file.FileStore getFileStore(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileStore>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/Path;)Z", "public")]
	public bool isSameFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.Path arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "public transient")]
	public Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;", "public transient")]
	public Dova.JDK.java.lang.Object readAttributes(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Ljava/util/Map;", "public transient")]
	public Dova.JDK.java.util.Map readAttributes(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;Ljava/lang/Object;[Ljava/nio/file/LinkOption;)V", "public transient")]
	public void setAttribute(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.java.lang.Object arg2, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", "public transient")]
	public Dova.JDK.java.nio.channels.FileChannel newFileChannel(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.FileChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/Set;Ljava/util/concurrent/ExecutorService;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/AsynchronousFileChannel;", "public transient")]
	public Dova.JDK.java.nio.channels.AsynchronousFileChannel newAsynchronousFileChannel(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.Set arg1, Dova.JDK.java.util.concurrent.ExecutorService arg2, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.AsynchronousFileChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/net/URI;)V", "private")]
	public void checkUri(Dova.JDK.java.net.URI arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/net/URLClassLoader;", "private static")]
	public static Dova.JDK.java.net.URLClassLoader newJrtFsLoader(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URLClassLoader>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/FileSystem;", "private")]
	public Dova.JDK.java.nio.file.FileSystem getTheFileSystem()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljdk/internal/jrtfs/JrtPath;", "static final")]
	public static Dova.JDK.jdk.@internal.jrtfs.JrtPath toJrtPath(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
	}

	[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileSystemProvider$JrtFsLoader;", "private static")]
	public partial class JrtFsLoader
		: Dova.JDK.java.net.URLClassLoader
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static JrtFsLoader()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jrtfs/JrtFileSystemProvider$JrtFsLoader;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/net/URL;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Z)Ljava/lang/Class;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public JrtFsLoader(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("([Ljava/net/URL;)V", "")]
		public JrtFsLoader(JavaArray<Dova.JDK.java.net.URL> arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtFileSystemProvider$JrtFsLoader;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Z)Ljava/lang/Class;", "protected")]
		public Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, bool arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
	}
}
