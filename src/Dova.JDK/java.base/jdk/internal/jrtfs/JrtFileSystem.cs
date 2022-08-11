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

[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileSystem;", "")]
public partial class JrtFileSystem
	: Dova.JDK.java.nio.file.FileSystem
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JrtFileSystem()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/internal/jrtfs/JrtFileSystem;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljdk/internal/jrtfs/JrtFileSystemProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rootPath", "Ljdk/internal/jrtfs/JrtPath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isOpen", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isClosable", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "image", "Ljdk/internal/jrtfs/SystemImage;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "supportedFileAttributeViews", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/internal/jrtfs/JrtFileSystemProvider;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookup", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isOpen", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "provider", "()Ljava/nio/file/spi/FileSystemProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath_0", "(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPath_1", "(Ljava/lang/String;[Ljava/lang/String;)Ljdk/internal/jrtfs/JrtPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toRealPath", "(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isReadOnly", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exists", "(Ljdk/internal/jrtfs/JrtPath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "cleanup", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectory", "(Ljdk/internal/jrtfs/JrtPath;Z)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createDirectory", "(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/attribute/FileAttribute;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeparator", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootDirectories", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStores", "()Ljava/lang/Iterable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "supportedFileAttributeViews", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathMatcher", "(Ljava/lang/String;)Ljava/nio/file/PathMatcher;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUserPrincipalLookupService", "()Ljava/nio/file/attribute/UserPrincipalLookupService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newWatchService", "()Ljava/nio/file/WatchService;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newInputStream", "(Ljdk/internal/jrtfs/JrtPath;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newOutputStream", "(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newByteChannel", "(Ljdk/internal/jrtfs/JrtPath;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStore", "(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jrtfs/JrtFileStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSameFile", "(Ljdk/internal/jrtfs/JrtPath;Ljdk/internal/jrtfs/JrtPath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimes", "(Ljdk/internal/jrtfs/JrtPath;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "followLinks", "([Ljava/nio/file/LinkOption;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileChannel", "(Ljdk/internal/jrtfs/JrtPath;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readOnly", "()Ljava/nio/file/ReadOnlyFileSystemException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkNode", "(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jimage/ImageReader$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyFile", "(ZLjdk/internal/jrtfs/JrtPath;Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/CopyOption;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileContent", "(Ljdk/internal/jrtfs/JrtPath;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkOptions", "(Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lookupSymbolic", "(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iteratorOf", "(Ljdk/internal/jrtfs/JrtPath;Ljava/nio/file/DirectoryStream$Filter;)Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRootPath", "()Ljdk/internal/jrtfs/JrtPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljdk/internal/jrtfs/JrtPath;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveLink", "(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jrtfs/JrtPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributes", "(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtFileAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLink", "(Ljdk/internal/jrtfs/JrtPath;)Z"));
	}

	[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtFileSystemProvider;", "private final")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtFileSystemProvider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileSystemProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/jrtfs/JrtPath;", "private final")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath rootPath_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool isOpen_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Z", "private volatile")]
	public bool isClosable_Property
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

	[JniSignatureAttribute("Ljdk/internal/jrtfs/SystemImage;", "private")]
	public Dova.JDK.jdk.@internal.jrtfs.SystemImage image_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.SystemImage>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private static final")]
	public static Dova.JDK.java.util.Set supportedFileAttributeViews_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JrtFileSystem(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtFileSystemProvider;Ljava/util/Map;)V", "")]
	public JrtFileSystem(Dova.JDK.jdk.@internal.jrtfs.JrtFileSystemProvider arg0, Dova.JDK.java.util.Map arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/internal/jrtfs/JrtFileSystem;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "private")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.Node lookup(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isOpen()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/file/spi/FileSystemProvider;", "public")]
	public Dova.JDK.java.nio.file.spi.FileSystemProvider provider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.spi.FileSystemProvider>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path getPath_0(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/String;)Ljdk/internal/jrtfs/JrtPath;", "public transient")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath getPath_1(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.String> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtPath;", "transient")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath toRealPath(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
	}

	[JniSignatureAttribute("()Z", "public final")]
	public bool isReadOnly()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8]);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Z", "")]
	public bool exists(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return ret;
	}

	[JniSignatureAttribute("()V", "synchronized")]
	public void cleanup()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10]);
	}

	[JniSignatureAttribute("()V", "final")]
	public void ensureOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11]);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Z)Z", "")]
	public bool isDirectory(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/attribute/FileAttribute;)V", "final transient")]
	public void createDirectory(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
	public Dova.JDK.java.lang.String getSeparator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public")]
	public Dova.JDK.java.lang.Iterable getRootDirectories()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Iterable;", "public final")]
	public Dova.JDK.java.lang.Iterable getFileStores()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Iterable>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public final")]
	public Dova.JDK.java.util.Set supportedFileAttributeViews()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/nio/file/PathMatcher;", "public")]
	public Dova.JDK.java.nio.file.PathMatcher getPathMatcher(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.PathMatcher>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/attribute/UserPrincipalLookupService;", "public final")]
	public Dova.JDK.java.nio.file.attribute.UserPrincipalLookupService getUserPrincipalLookupService()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.UserPrincipalLookupService>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/WatchService;", "public final")]
	public Dova.JDK.java.nio.file.WatchService newWatchService()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.WatchService>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Ljava/io/InputStream;", "final")]
	public Dova.JDK.java.io.InputStream newInputStream(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/OpenOption;)Ljava/io/OutputStream;", "final transient")]
	public Dova.JDK.java.io.OutputStream newOutputStream(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, JavaArray<Dova.JDK.java.nio.file.OpenOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.OutputStream>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", "final transient")]
	public Dova.JDK.java.nio.channels.SeekableByteChannel newByteChannel(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SeekableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jrtfs/JrtFileStore;", "final")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtFileStore getFileStore(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileStore>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljdk/internal/jrtfs/JrtPath;)Z", "")]
	public bool isSameFile(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.jdk.@internal.jrtfs.JrtPath arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V", "final")]
	public void setTimes(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.nio.file.attribute.FileTime arg1, Dova.JDK.java.nio.file.attribute.FileTime arg2, Dova.JDK.java.nio.file.attribute.FileTime arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("([Ljava/nio/file/LinkOption;)Z", "static transient")]
	public static bool followLinks(JavaArray<Dova.JDK.java.nio.file.LinkOption> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/FileChannel;", "final transient")]
	public Dova.JDK.java.nio.channels.FileChannel newFileChannel(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.FileChannel>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/ReadOnlyFileSystemException;", "static")]
	public static Dova.JDK.java.nio.file.ReadOnlyFileSystemException readOnly()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.ReadOnlyFileSystemException>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jimage/ImageReader$Node;", "")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.Node checkNode(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
	}

	[JniSignatureAttribute("(ZLjdk/internal/jrtfs/JrtPath;Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/CopyOption;)V", "final transient")]
	public void copyFile(bool arg0, Dova.JDK.jdk.@internal.jrtfs.JrtPath arg1, Dova.JDK.jdk.@internal.jrtfs.JrtPath arg2, JavaArray<Dova.JDK.java.nio.file.CopyOption> arg3)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)[B", "")]
	public JavaArray<byte> getFileContent(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)V", "static")]
	public static void checkOptions(Dova.JDK.java.util.Set arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/internal/jimage/ImageReader$Node;", "private")]
	public Dova.JDK.jdk.@internal.jimage.ImageReader.Node lookupSymbolic(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jimage.ImageReader.Node>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Ljava/nio/file/DirectoryStream$Filter;)Ljava/util/Iterator;", "")]
	public Dova.JDK.java.util.Iterator iteratorOf(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, Dova.JDK.java.nio.file.DirectoryStream.Filter arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()Ljdk/internal/jrtfs/JrtPath;", "final")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath getRootPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;Z)V", "final")]
	public void deleteFile(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, bool arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Ljdk/internal/jrtfs/JrtPath;", "")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtPath resolveLink(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtPath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;[Ljava/nio/file/LinkOption;)Ljdk/internal/jrtfs/JrtFileAttributes;", "transient")]
	public Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributes getFileAttributes(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.jrtfs.JrtFileAttributes>(ret);
	}

	[JniSignatureAttribute("(Ljdk/internal/jrtfs/JrtPath;)Z", "")]
	public bool isLink(Dova.JDK.jdk.@internal.jrtfs.JrtPath arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return ret;
	}
}
