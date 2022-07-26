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

namespace Dova.JDK.sun.nio.fs;

[JniSignatureAttribute("Lsun/nio/fs/LinuxFileSystemProvider;", "")]
public partial class LinuxFileSystemProvider
	: Dova.JDK.sun.nio.fs.UnixFileSystemProvider
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static LinuxFileSystemProvider()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/LinuxFileSystemProvider;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileSystem_0", "(Ljava/lang/String;)Lsun/nio/fs/UnixFileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newFileSystem_1", "(Ljava/lang/String;)Lsun/nio/fs/LinuxFileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStore_0", "(Lsun/nio/fs/UnixPath;)Lsun/nio/fs/LinuxFileStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileStore_1", "(Lsun/nio/fs/UnixPath;)Ljava/nio/file/FileStore;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Lsun/nio/fs/DynamicFileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileTypeDetector", "()Ljava/nio/file/spi/FileTypeDetector;"));
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public LinuxFileSystemProvider(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public LinuxFileSystemProvider() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/fs/LinuxFileSystemProvider;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/nio/fs/UnixFileSystem;", "volatile")]
	public Dova.JDK.sun.nio.fs.UnixFileSystem newFileSystem_0(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixFileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lsun/nio/fs/LinuxFileSystem;", "")]
	public Dova.JDK.sun.nio.fs.LinuxFileSystem newFileSystem_1(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.LinuxFileSystem>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)Lsun/nio/fs/LinuxFileStore;", "")]
	public Dova.JDK.sun.nio.fs.LinuxFileStore getFileStore_0(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.LinuxFileStore>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)Ljava/nio/file/FileStore;", "volatile")]
	public Dova.JDK.java.nio.file.FileStore getFileStore_1(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileStore>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/String;[Ljava/nio/file/LinkOption;)Lsun/nio/fs/DynamicFileAttributeView;", "public transient")]
	public Dova.JDK.sun.nio.fs.DynamicFileAttributeView getFileAttributeView(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.DynamicFileAttributeView>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "public transient")]
	public Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/BasicFileAttributes;", "public transient")]
	public Dova.JDK.java.lang.Object readAttributes(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/spi/FileTypeDetector;", "")]
	public Dova.JDK.java.nio.file.spi.FileTypeDetector getFileTypeDetector()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.spi.FileTypeDetector>(ret);
	}
}
