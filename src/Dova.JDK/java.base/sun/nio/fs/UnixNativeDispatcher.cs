/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.nio.fs;

[JniSignatureAttribute("Lsun/nio/fs/UnixNativeDispatcher;", "")]
public partial class UnixNativeDispatcher
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixNativeDispatcher()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/nio/fs/UnixNativeDispatcher;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_OPENAT", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_FUTIMES", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_FUTIMENS", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_LUTIMES", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_XATTR", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "SUPPORTS_BIRTHTIME", "I"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "capabilities", "I"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "UnixNativeDispatcher", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "init", "()I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(IJI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(IJI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access", "(Lsun/nio/fs/UnixPath;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "close", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "open", "(Lsun/nio/fs/UnixPath;II)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "rewind", "(J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exists", "(Lsun/nio/fs/UnixPath;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "open0", "(JII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "close0", "(I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mkdir", "(Lsun/nio/fs/UnixPath;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "rename", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "rename0", "(JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readlink", "(Lsun/nio/fs/UnixPath;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "dup", "(I)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "link", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "stat", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "stat", "(Lsun/nio/fs/UnixPath;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getlinelen", "(J)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getcwd", "()[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "rmdir", "(Lsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "unlink", "(Lsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "openatSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "opendir", "(Lsun/nio/fs/UnixPath;)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fdopendir", "(I)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "symlink", "([BLsun/nio/fs/UnixPath;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lutimesSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "futimensSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "futimesSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "futimens", "(IJJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "futimes", "(IJJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lutimes", "(Lsun/nio/fs/UnixPath;JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "utimes", "(Lsun/nio/fs/UnixPath;JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lstat", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fstat", "(ILsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fstatat", "(I[BILsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "birthtimeSupported", "()Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "statvfs", "(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileStoreAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "copyToNativeBuffer", "(Lsun/nio/fs/UnixPath;)Lsun/nio/fs/NativeBuffer;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "openat0", "(IJII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "link0", "(JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "unlink0", "(J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "unlinkat0", "(IJI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mknod0", "(JIJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "renameat0", "(IJIJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mkdir0", "(JI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "rmdir0", "(J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readlink0", "(J)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "realpath0", "(J)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "symlink0", "(JJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "stat0", "(JLsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "stat1", "(J)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lstat0", "(JLsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fstatat0", "(IJILsun/nio/fs/UnixFileAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "chown0", "(JII)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lchown0", "(JII)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "chmod0", "(JI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "utimes0", "(JJJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lutimes0", "(JJJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "opendir0", "(J)J"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "access0", "(JI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "exists0", "(J)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getpwnam0", "(J)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getgrnam0", "(J)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "statvfs0", "(JLsun/nio/fs/UnixFileStoreAttributes;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fgetxattr0", "(IJJI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fsetxattr0", "(IJJI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fremovexattr0", "(IJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "openat", "(I[BII)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "unlinkat", "(I[BI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "mknod", "(Lsun/nio/fs/UnixPath;IJ)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "renameat", "(I[BI[B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "realpath", "(Lsun/nio/fs/UnixPath;)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "chown", "(Lsun/nio/fs/UnixPath;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "lchown", "(Lsun/nio/fs/UnixPath;II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fchown", "(III)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "chmod", "(Lsun/nio/fs/UnixPath;I)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fchmod", "(II)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "closedir", "(J)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "readdir", "(J)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getpwuid", "(I)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getgrgid", "(I)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getpwnam", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "getgrnam", "(Ljava/lang/String;)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "strerror", "(I)[B"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fgetxattr", "(I[BJI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fsetxattr", "(I[BJI)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "fremovexattr", "(I[B)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "flistxattr", "(IJI)I"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetStaticMethodId(ClassRefPtr, "xattrSupported", "()Z"));
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_OPENAT_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_FUTIMES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_FUTIMENS_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[2], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_LUTIMES_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_XATTR_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int SUPPORTS_BIRTHTIME_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int capabilities_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set => DovaJvm.Vm.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixNativeDispatcher(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "protected")]
	public UnixNativeDispatcher() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixNativeDispatcher;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()I", "private static native")]
	public static int init()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[0]);
		return ret;
	}

	[JniSignatureAttribute("(IJI)I", "static native")]
	public static int write(int arg0, long arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(IJI)I", "static native")]
	public static int read(int arg0, long arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;I)V", "static")]
	public static void access(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
	}

	[JniSignatureAttribute("(I)V", "static")]
	public static void close(int arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;II)I", "static")]
	public static int open(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void rewind(long arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)Z", "static")]
	public static bool exists(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JII)I", "private static native")]
	public static int open0(long arg0, int arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(I)V", "private static native")]
	public static void close0(int arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;I)V", "static")]
	public static void mkdir(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;)V", "static")]
	public static void rename(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixPath arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
	}

	[JniSignatureAttribute("(JJ)V", "private static native")]
	public static void rename0(long arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)[B", "static")]
	public static JavaArray<byte> readlink(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)I", "static native")]
	public static int dup(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixPath;)V", "static")]
	public static void link(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixPath arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;)V", "static")]
	public static void stat(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)I", "static")]
	public static int stat(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "static native")]
	public static int getlinelen(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return ret;
	}

	[JniSignatureAttribute("()[B", "static native")]
	public static JavaArray<byte> getcwd()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)V", "static")]
	public static void rmdir(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)V", "static")]
	public static void unlink(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool openatSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)J", "static")]
	public static long opendir(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)J", "static native")]
	public static long fdopendir(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("([BLsun/nio/fs/UnixPath;)V", "static")]
	public static void symlink(JavaArray<byte> arg0, Dova.JDK.sun.nio.fs.UnixPath arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool lutimesSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool futimensSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool futimesSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("(IJJ)V", "static native")]
	public static void futimens(int arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[29], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IJJ)V", "static native")]
	public static void futimes(int arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;JJ)V", "static")]
	public static void lutimes(Dova.JDK.sun.nio.fs.UnixPath arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;JJ)V", "static")]
	public static void utimes(Dova.JDK.sun.nio.fs.UnixPath arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileAttributes;)V", "static")]
	public static void lstat(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
	}

	[JniSignatureAttribute("(ILsun/nio/fs/UnixFileAttributes;)V", "static native")]
	public static void fstat(int arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0, arg1);
	}

	[JniSignatureAttribute("(I[BILsun/nio/fs/UnixFileAttributes;)V", "static")]
	public static void fstatat(int arg0, JavaArray<byte> arg1, int arg2, Dova.JDK.sun.nio.fs.UnixFileAttributes arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool birthtimeSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[36]);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;Lsun/nio/fs/UnixFileStoreAttributes;)V", "static")]
	public static void statvfs(Dova.JDK.sun.nio.fs.UnixPath arg0, Dova.JDK.sun.nio.fs.UnixFileStoreAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)Lsun/nio/fs/NativeBuffer;", "static")]
	public static Dova.JDK.sun.nio.fs.NativeBuffer copyToNativeBuffer(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.NativeBuffer>(ret);
	}

	[JniSignatureAttribute("(IJII)I", "private static native")]
	public static int openat0(int arg0, long arg1, int arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[39], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJ)V", "private static native")]
	public static void link0(long arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void unlink0(long arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[41], arg0);
	}

	[JniSignatureAttribute("(IJI)V", "private static native")]
	public static void unlinkat0(int arg0, long arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JIJ)V", "private static native")]
	public static void mknod0(long arg0, int arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[43], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(IJIJ)V", "private static native")]
	public static void renameat0(int arg0, long arg1, int arg2, long arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JI)V", "private static native")]
	public static void mkdir0(long arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[45], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "private static native")]
	public static void rmdir0(long arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[46], arg0);
	}

	[JniSignatureAttribute("(J)[B", "private static native")]
	public static JavaArray<byte> readlink0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(J)[B", "private static native")]
	public static JavaArray<byte> realpath0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(JJ)V", "private static native")]
	public static void symlink0(long arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[49], arg0, arg1);
	}

	[JniSignatureAttribute("(JLsun/nio/fs/UnixFileAttributes;)V", "private static native")]
	public static void stat0(long arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1);
	}

	[JniSignatureAttribute("(J)I", "private static native")]
	public static int stat1(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/nio/fs/UnixFileAttributes;)V", "private static native")]
	public static void lstat0(long arg0, Dova.JDK.sun.nio.fs.UnixFileAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[52], arg0, arg1);
	}

	[JniSignatureAttribute("(IJILsun/nio/fs/UnixFileAttributes;)V", "private static native")]
	public static void fstatat0(int arg0, long arg1, int arg2, Dova.JDK.sun.nio.fs.UnixFileAttributes arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(JII)V", "private static native")]
	public static void chown0(long arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[54], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JII)V", "private static native")]
	public static void lchown0(long arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[55], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JI)V", "private static native")]
	public static void chmod0(long arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[56], arg0, arg1);
	}

	[JniSignatureAttribute("(JJJ)V", "private static native")]
	public static void utimes0(long arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[57], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(JJJ)V", "private static native")]
	public static void lutimes0(long arg0, long arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[58], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(J)J", "private static native")]
	public static long opendir0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[59], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JI)V", "private static native")]
	public static void access0(long arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1);
	}

	[JniSignatureAttribute("(J)Z", "private static native")]
	public static bool exists0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private static native")]
	public static int getpwnam0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)I", "private static native")]
	public static int getgrnam0(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[63], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLsun/nio/fs/UnixFileStoreAttributes;)V", "private static native")]
	public static void statvfs0(long arg0, Dova.JDK.sun.nio.fs.UnixFileStoreAttributes arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1);
	}

	[JniSignatureAttribute("(IJJI)I", "private static native")]
	public static int fgetxattr0(int arg0, long arg1, long arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[65], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(IJJI)V", "private static native")]
	public static void fsetxattr0(int arg0, long arg1, long arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[66], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(IJ)V", "private static native")]
	public static void fremovexattr0(int arg0, long arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[67], arg0, arg1);
	}

	[JniSignatureAttribute("(I[BII)I", "static")]
	public static int openat(int arg0, JavaArray<byte> arg1, int arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[68], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(I[BI)V", "static")]
	public static void unlinkat(int arg0, JavaArray<byte> arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[69], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;IJ)V", "static")]
	public static void mknod(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1, long arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[70], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(I[BI[B)V", "static")]
	public static void renameat(int arg0, JavaArray<byte> arg1, int arg2, JavaArray<byte> arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[71], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;)[B", "static")]
	public static JavaArray<byte> realpath(Dova.JDK.sun.nio.fs.UnixPath arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;II)V", "static")]
	public static void chown(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[73], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;II)V", "static")]
	public static void lchown(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[74], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(III)V", "static native")]
	public static void fchown(int arg0, int arg1, int arg2)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[75], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixPath;I)V", "static")]
	public static void chmod(Dova.JDK.sun.nio.fs.UnixPath arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[76], arg0, arg1);
	}

	[JniSignatureAttribute("(II)V", "static native")]
	public static void fchmod(int arg0, int arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[77], arg0, arg1);
	}

	[JniSignatureAttribute("(J)V", "static native")]
	public static void closedir(long arg0)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[78], arg0);
	}

	[JniSignatureAttribute("(J)[B", "static native")]
	public static JavaArray<byte> readdir(long arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)[B", "static native")]
	public static JavaArray<byte> getpwuid(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[80], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I)[B", "static native")]
	public static JavaArray<byte> getgrgid(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "static")]
	public static int getpwnam(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[82], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)I", "static")]
	public static int getgrnam(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[83], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)[B", "static native")]
	public static JavaArray<byte> strerror(int arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(I[BJI)I", "static")]
	public static int fgetxattr(int arg0, JavaArray<byte> arg1, long arg2, int arg3)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[85], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(I[BJI)V", "static")]
	public static void fsetxattr(int arg0, JavaArray<byte> arg1, long arg2, int arg3)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[86], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(I[B)V", "static")]
	public static void fremovexattr(int arg0, JavaArray<byte> arg1)
	{
		DovaJvm.Vm.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1);
	}

	[JniSignatureAttribute("(IJI)I", "static native")]
	public static int flistxattr(int arg0, long arg1, int arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[88], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("()Z", "static")]
	public static bool xattrSupported()
	{
		var ret = DovaJvm.Vm.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[89]);
		return ret;
	}
}
