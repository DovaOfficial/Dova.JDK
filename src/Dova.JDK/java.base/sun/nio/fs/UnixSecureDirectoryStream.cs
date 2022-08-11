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

[JniSignatureAttribute("Lsun/nio/fs/UnixSecureDirectoryStream;", "")]
public partial class UnixSecureDirectoryStream
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.nio.file.SecureDirectoryStream
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixSecureDirectoryStream()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixSecureDirectoryStream;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ds", "Lsun/nio/fs/UnixDirectoryStream;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dfd", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/fs/UnixPath;JILjava/nio/file/DirectoryStream$Filter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "iterator", "()Ljava/util/Iterator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "close", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newByteChannel", "(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newByteChannel", "(Ljava/lang/Object;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectoryStream", "(Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectoryStream", "(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/lang/Object;Ljava/nio/file/SecureDirectoryStream;Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "move", "(Ljava/nio/file/Path;Ljava/nio/file/SecureDirectoryStream;Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/lang/Object;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeView", "(Ljava/lang/Class;)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "implDelete", "(Ljava/nio/file/Path;ZI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileAttributeViewImpl", "(Lsun/nio/fs/UnixPath;Ljava/lang/Class;Z)Ljava/nio/file/attribute/FileAttributeView;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteDirectory", "(Ljava/nio/file/Path;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteDirectory", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deleteFile", "(Ljava/nio/file/Path;)V"));
	}

	[JniSignatureAttribute("Lsun/nio/fs/UnixDirectoryStream;", "private final")]
	public Dova.JDK.sun.nio.fs.UnixDirectoryStream ds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixDirectoryStream>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int dfd_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixSecureDirectoryStream(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;JILjava/nio/file/DirectoryStream$Filter;)V", "")]
	public UnixSecureDirectoryStream(Dova.JDK.sun.nio.fs.UnixPath arg0, long arg1, int arg2, Dova.JDK.java.nio.file.DirectoryStream.Filter arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixSecureDirectoryStream;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;", "private")]
	public Dova.JDK.sun.nio.fs.UnixPath getName(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Iterator;", "public")]
	public Dova.JDK.java.util.Iterator iterator()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Iterator>(ret);
	}

	[JniSignatureAttribute("()V", "public")]
	public void close()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2]);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", "public transient")]
	public Dova.JDK.java.nio.channels.SeekableByteChannel newByteChannel(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SeekableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/util/Set;[Ljava/nio/file/attribute/FileAttribute;)Ljava/nio/channels/SeekableByteChannel;", "public volatile")]
	public Dova.JDK.java.nio.channels.SeekableByteChannel newByteChannel(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.util.Set arg1, JavaArray<Dova.JDK.java.nio.file.attribute.FileAttribute> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.SeekableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;", "public volatile")]
	public Dova.JDK.java.nio.file.SecureDirectoryStream newDirectoryStream(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.SecureDirectoryStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;[Ljava/nio/file/LinkOption;)Ljava/nio/file/SecureDirectoryStream;", "public transient")]
	public Dova.JDK.java.nio.file.SecureDirectoryStream newDirectoryStream(Dova.JDK.java.nio.file.Path arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.SecureDirectoryStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/SecureDirectoryStream;Ljava/lang/Object;)V", "public volatile")]
	public void move(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.SecureDirectoryStream arg1, Dova.JDK.java.lang.Object arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/SecureDirectoryStream;Ljava/nio/file/Path;)V", "public")]
	public void move(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.SecureDirectoryStream arg1, Dova.JDK.java.nio.file.Path arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "public volatile")]
	public Dova.JDK.java.nio.file.attribute.FileAttributeView getFileAttributeView(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.FileAttributeView>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/lang/Class;[Ljava/nio/file/LinkOption;)Ljava/nio/file/attribute/FileAttributeView;", "public transient")]
	public Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.lang.Class arg1, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/nio/file/attribute/FileAttributeView;", "public")]
	public Dova.JDK.java.lang.Object getFileAttributeView(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;ZI)V", "private")]
	public void implDelete(Dova.JDK.java.nio.file.Path arg0, bool arg1, int arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Ljava/lang/Class;Z)Ljava/nio/file/attribute/FileAttributeView;", "private")]
	public Dova.JDK.java.lang.Object getFileAttributeViewImpl(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.java.lang.Class arg1, bool arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public")]
	public void deleteDirectory(Dova.JDK.java.nio.file.Path arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
	public void deleteDirectory(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "public volatile")]
	public void deleteFile(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public")]
	public void deleteFile(Dova.JDK.java.nio.file.Path arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
	}

	[JniSignatureAttribute("Lsun/nio/fs/UnixSecureDirectoryStream$BasicFileAttributeViewImpl;", "private")]
	public partial class BasicFileAttributeViewImpl
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.nio.file.attribute.BasicFileAttributeView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static BasicFileAttributeViewImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixSecureDirectoryStream$BasicFileAttributeViewImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "file", "Lsun/nio/fs/UnixPath;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "followLinks", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/nio/fs/UnixSecureDirectoryStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/fs/UnixSecureDirectoryStream;Lsun/nio/fs/UnixPath;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "open", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setTimes", "(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkWriteAccess", "()V"));
		}

		[JniSignatureAttribute("Lsun/nio/fs/UnixPath;", "final")]
		public Dova.JDK.sun.nio.fs.UnixPath file_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "final")]
		public bool followLinks_Property
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

		[JniSignatureAttribute("Lsun/nio/fs/UnixSecureDirectoryStream;", "final")]
		public Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public BasicFileAttributeViewImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/nio/fs/UnixSecureDirectoryStream;Lsun/nio/fs/UnixPath;Z)V", "")]
		public BasicFileAttributeViewImpl(Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream arg0, Dova.JDK.sun.nio.fs.UnixPath arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixSecureDirectoryStream$BasicFileAttributeViewImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "")]
		public int open()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "public")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes readAttributes()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;Ljava/nio/file/attribute/FileTime;)V", "public")]
		public void setTimes(Dova.JDK.java.nio.file.attribute.FileTime arg0, Dova.JDK.java.nio.file.attribute.FileTime arg1, Dova.JDK.java.nio.file.attribute.FileTime arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkWriteAccess()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4]);
		}
	}

	[JniSignatureAttribute("Lsun/nio/fs/UnixSecureDirectoryStream$PosixFileAttributeViewImpl;", "private")]
	public partial class PosixFileAttributeViewImpl
		: Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream.BasicFileAttributeViewImpl
		, Dova.JDK.java.nio.file.attribute.PosixFileAttributeView
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PosixFileAttributeViewImpl()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixSecureDirectoryStream$PosixFileAttributeViewImpl;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "this$0", "Lsun/nio/fs/UnixSecureDirectoryStream;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/fs/UnixSecureDirectoryStream;Lsun/nio/fs/UnixPath;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOwner", "()Ljava/nio/file/attribute/UserPrincipal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes_0", "()Ljava/nio/file/attribute/BasicFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readAttributes_1", "()Ljava/nio/file/attribute/PosixFileAttributes;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPermissions", "(Ljava/util/Set;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOwner", "(Ljava/nio/file/attribute/UserPrincipal;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setOwners", "(II)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkWriteAndUserAccess", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setGroup", "(Ljava/nio/file/attribute/GroupPrincipal;)V"));
		}

		[JniSignatureAttribute("Lsun/nio/fs/UnixSecureDirectoryStream;", "final")]
		public Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream this0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PosixFileAttributeViewImpl(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Lsun/nio/fs/UnixSecureDirectoryStream;Lsun/nio/fs/UnixPath;Z)V", "")]
		public PosixFileAttributeViewImpl(Dova.JDK.sun.nio.fs.UnixSecureDirectoryStream arg0, Dova.JDK.sun.nio.fs.UnixPath arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixSecureDirectoryStream$PosixFileAttributeViewImpl;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String name()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/UserPrincipal;", "public")]
		public Dova.JDK.java.nio.file.attribute.UserPrincipal getOwner()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.UserPrincipal>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/BasicFileAttributes;", "public volatile")]
		public Dova.JDK.java.nio.file.attribute.BasicFileAttributes readAttributes_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.BasicFileAttributes>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/attribute/PosixFileAttributes;", "public")]
		public Dova.JDK.java.nio.file.attribute.PosixFileAttributes readAttributes_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.PosixFileAttributes>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;)V", "public")]
		public void setPermissions(Dova.JDK.java.util.Set arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		}

		[JniSignatureAttribute("(Ljava/nio/file/attribute/UserPrincipal;)V", "public")]
		public void setOwner(Dova.JDK.java.nio.file.attribute.UserPrincipal arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		}

		[JniSignatureAttribute("(II)V", "private")]
		public void setOwners(int arg0, int arg1)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		}

		[JniSignatureAttribute("()V", "private")]
		public void checkWriteAndUserAccess()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7]);
		}

		[JniSignatureAttribute("(Ljava/nio/file/attribute/GroupPrincipal;)V", "public")]
		public void setGroup(Dova.JDK.java.nio.file.attribute.GroupPrincipal arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		}
	}
}
