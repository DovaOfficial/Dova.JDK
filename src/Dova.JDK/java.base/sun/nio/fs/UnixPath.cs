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

[JniSignatureAttribute("Lsun/nio/fs/UnixPath;", "")]
public partial class UnixPath
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.nio.file.Path
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static UnixPath()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/fs/UnixPath;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JLA", "Ljdk/internal/access/JavaLangAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fs", "Lsun/nio/fs/UnixFileSystem;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "[B"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "stringValue", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "hash", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offsets", "[I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/fs/UnixFileSystem;[B)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lsun/nio/fs/UnixFileSystem;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_0", "(I)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName_1", "(I)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/nio/file/Path;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "encode", "(Lsun/nio/fs/UnixFileSystem;Ljava/lang/String;)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "startsWith", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEmpty", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "endsWith", "(Ljava/nio/file/Path;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "register", "(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;[Ljava/nio/file/WatchEvent$Modifier;)Ljava/nio/file/WatchKey;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAbsolute", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_0", "(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve_1", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolve", "([B)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "resolve", "([B[B)[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent_0", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getParent_1", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkRead", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkWrite", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkDelete", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot_0", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getRoot_1", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize_0", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "normalize_1", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalize", "(Ljava/lang/String;II)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toRealPath", "([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileName_0", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileName_1", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileSystem_0", "()Lsun/nio/fs/UnixFileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getFileSystem_1", "()Ljava/nio/file/FileSystem;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relativize_0", "(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "relativize_1", "(Ljava/nio/file/Path;)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNameCount", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAbsolutePath_0", "()Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toAbsolutePath_1", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subpath_0", "(II)Ljava/nio/file/Path;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subpath_1", "(II)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toUri", "()Ljava/net/URI;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "normalizeAndCheck", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toUnixPath", "(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathForExceptionMessage", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPathForPermissionCheck", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "asByteArray", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getByteArrayForSysCalls", "()[B"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openForAttributeAccess", "(Z)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkNotNul", "(Ljava/lang/String;C)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "initOffsets", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "emptyPath", "()Lsun/nio/fs/UnixPath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hasDotOrDotDot", "()Z"));
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

	[JniSignatureAttribute("Lsun/nio/fs/UnixFileSystem;", "private final")]
	public Dova.JDK.sun.nio.fs.UnixFileSystem fs_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixFileSystem>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[B", "private final")]
	public JavaArray<byte> path_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private volatile")]
	public Dova.JDK.java.lang.String stringValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int hash_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("[I", "private volatile")]
	public JavaArray<int> offsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public UnixPath(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixFileSystem;[B)V", "")]
	public UnixPath(Dova.JDK.sun.nio.fs.UnixFileSystem arg0, JavaArray<byte> arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixFileSystem;Ljava/lang/String;)V", "")]
	public UnixPath(Dova.JDK.sun.nio.fs.UnixFileSystem arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/fs/UnixPath;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(I)Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath getName_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path getName_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)I", "public")]
	public int compareTo(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Lsun/nio/fs/UnixFileSystem;Ljava/lang/String;)[B", "private static")]
	public static JavaArray<byte> encode(Dova.JDK.sun.nio.fs.UnixFileSystem arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool startsWith(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isEmpty()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
	public bool endsWith(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/WatchService;[Ljava/nio/file/WatchEvent$Kind;[Ljava/nio/file/WatchEvent$Modifier;)Ljava/nio/file/WatchKey;", "public transient")]
	public Dova.JDK.java.nio.file.WatchKey register(Dova.JDK.java.nio.file.WatchService arg0, JavaArray<Dova.JDK.java.nio.file.WatchEvent.Kind> arg1, JavaArray<Dova.JDK.java.nio.file.WatchEvent.Modifier> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.WatchKey>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isAbsolute()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath resolve_0(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path resolve_1(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("([B)Lsun/nio/fs/UnixPath;", "")]
	public Dova.JDK.sun.nio.fs.UnixPath resolve(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("([B[B)[B", "private static")]
	public static JavaArray<byte> resolve(JavaArray<byte> arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path getParent_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath getParent_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkRead()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[19]);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkWrite()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkDelete()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[21]);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path getRoot_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath getRoot_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath normalize_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path normalize_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;II)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String normalize(Dova.JDK.java.lang.String arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("([Ljava/nio/file/LinkOption;)Ljava/nio/file/Path;", "public transient")]
	public Dova.JDK.java.nio.file.Path toRealPath(JavaArray<Dova.JDK.java.nio.file.LinkOption> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path getFileName_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath getFileName_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixFileSystem;", "public")]
	public Dova.JDK.sun.nio.fs.UnixFileSystem getFileSystem_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixFileSystem>(ret);
	}

	[JniSignatureAttribute("()Ljava/nio/file/FileSystem;", "public volatile")]
	public Dova.JDK.java.nio.file.FileSystem getFileSystem_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileSystem>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath relativize_0(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path relativize_1(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNameCount()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[34]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path toAbsolutePath_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath toAbsolutePath_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/nio/file/Path;", "public volatile")]
	public Dova.JDK.java.nio.file.Path subpath_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
	}

	[JniSignatureAttribute("(II)Lsun/nio/fs/UnixPath;", "public")]
	public Dova.JDK.sun.nio.fs.UnixPath subpath_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Ljava/net/URI;", "public")]
	public Dova.JDK.java.net.URI toUri()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.net.URI>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String normalizeAndCheck(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/file/Path;)Lsun/nio/fs/UnixPath;", "static")]
	public static Dova.JDK.sun.nio.fs.UnixPath toUnixPath(Dova.JDK.java.nio.file.Path arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getPathForExceptionMessage()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getPathForPermissionCheck()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> asByteArray()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("()[B", "")]
	public JavaArray<byte> getByteArrayForSysCalls()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<JavaArray<byte>>(ret);
	}

	[JniSignatureAttribute("(Z)I", "")]
	public int openForAttributeAccess(bool arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;C)V", "private static")]
	public static void checkNotNul(Dova.JDK.java.lang.String arg0, char arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[47], arg0, arg1);
	}

	[JniSignatureAttribute("()V", "private")]
	public void initOffsets()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[48]);
	}

	[JniSignatureAttribute("()Lsun/nio/fs/UnixPath;", "private")]
	public Dova.JDK.sun.nio.fs.UnixPath emptyPath()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.fs.UnixPath>(ret);
	}

	[JniSignatureAttribute("()Z", "private")]
	public bool hasDotOrDotDot()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[50]);
		return ret;
	}
}
