/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-01:21)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Core;
using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.nio.ch;

[JniSignatureAttribute("Lsun/nio/ch/IOUtil;", "public")]
public partial class IOUtil
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static IOUtil()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/IOUtil;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "IOV_MAX", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "WRITEV_MAX", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "NIO_ACCESS", "Ljdk/internal/access/JavaNioAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "IOUtil", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "load", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZLsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZZILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JLsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;ZLsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;ZLsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JLsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZLsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;Lsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZZILsun/nio/ch/NativeDispatcher;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "read", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "initIDs", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "bufferAddress", "(Ljava/nio/ByteBuffer;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireScope", "(Ljava/nio/ByteBuffer;Z)Ljava/lang/Runnable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "configureBlocking", "(Ljava/io/FileDescriptor;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "writeFromNativeBuffer", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "releaseScope", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "releaseScopes", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "readIntoNativeBuffer", "(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireScopes", "([Ljava/nio/ByteBuffer;)Ljava/lang/Runnable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "acquireScopes", "(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljava/lang/Runnable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "setfdVal", "(Ljava/io/FileDescriptor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "iovMax", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "writevMax", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "newFD", "(I)Ljava/io/FileDescriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makePipe", "(Z)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "write1", "(IB)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drain1", "(I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fdLimit", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "fdVal", "(Ljava/io/FileDescriptor;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "drain", "(I)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "randomBytes", "([B)Z"));
	}

	[JniSignatureAttribute("I", "static final")]
	public static int IOV_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("J", "static final")]
	public static long WRITEV_MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/access/JavaNioAccess;", "private static final")]
	public static Dova.JDK.jdk.@internal.access.JavaNioAccess NIO_ACCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.access.JavaNioAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public IOUtil(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public IOUtil() : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/nio/ch/IOUtil;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()V", "public static")]
	public static void load()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0]);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long write(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, Dova.JDK.sun.nio.ch.NativeDispatcher arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZLsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int write(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, Dova.JDK.sun.nio.ch.NativeDispatcher arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long write(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int write(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZZILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long write(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, bool arg4, bool arg5, int arg6, Dova.JDK.sun.nio.ch.NativeDispatcher arg7)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JLsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int write(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, Dova.JDK.sun.nio.ch.NativeDispatcher arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;ZLsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long write(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, bool arg2, Dova.JDK.sun.nio.ch.NativeDispatcher arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZILsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int write(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, int arg4, Dova.JDK.sun.nio.ch.NativeDispatcher arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;ZLsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long read(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, bool arg2, Dova.JDK.sun.nio.ch.NativeDispatcher arg3)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JLsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int read(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, Dova.JDK.sun.nio.ch.NativeDispatcher arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long read(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, Dova.JDK.sun.nio.ch.NativeDispatcher arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZLsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int read(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, Dova.JDK.sun.nio.ch.NativeDispatcher arg4)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;Lsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long read(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, Dova.JDK.sun.nio.ch.NativeDispatcher arg2)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long read(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int read(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;[Ljava/nio/ByteBuffer;IIZZILsun/nio/ch/NativeDispatcher;)J", "static")]
	public static long read(Dova.JDK.java.io.FileDescriptor arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1, int arg2, int arg3, bool arg4, bool arg5, int arg6, Dova.JDK.sun.nio.ch.NativeDispatcher arg7)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZILsun/nio/ch/NativeDispatcher;)I", "static")]
	public static int read(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, int arg4, Dova.JDK.sun.nio.ch.NativeDispatcher arg5)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3, arg4, arg5);
		return ret;
	}

	[JniSignatureAttribute("()V", "static native")]
	public static void initIDs()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18]);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;)J", "static")]
	public static long bufferAddress(Dova.JDK.java.nio.ByteBuffer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;Z)Ljava/lang/Runnable;", "static")]
	public static Dova.JDK.java.lang.Runnable acquireScope(Dova.JDK.java.nio.ByteBuffer arg0, bool arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Z)V", "public static native")]
	public static void configureBlocking(Dova.JDK.java.io.FileDescriptor arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I", "private static")]
	public static int writeFromNativeBuffer(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[22], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "private static")]
	public static void releaseScope(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[23], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "static")]
	public static void releaseScopes(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[24], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;Ljava/nio/ByteBuffer;JZZILsun/nio/ch/NativeDispatcher;)I", "private static")]
	public static int readIntoNativeBuffer(Dova.JDK.java.io.FileDescriptor arg0, Dova.JDK.java.nio.ByteBuffer arg1, long arg2, bool arg3, bool arg4, int arg5, Dova.JDK.sun.nio.ch.NativeDispatcher arg6)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[25], arg0, arg1, arg2, arg3, arg4, arg5, arg6);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/nio/ByteBuffer;)Ljava/lang/Runnable;", "static")]
	public static Dova.JDK.java.lang.Runnable acquireScopes(JavaArray<Dova.JDK.java.nio.ByteBuffer> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
	}

	[JniSignatureAttribute("(Ljava/nio/ByteBuffer;[Ljava/nio/ByteBuffer;)Ljava/lang/Runnable;", "static")]
	public static Dova.JDK.java.lang.Runnable acquireScopes(Dova.JDK.java.nio.ByteBuffer arg0, JavaArray<Dova.JDK.java.nio.ByteBuffer> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;I)V", "static native")]
	public static void setfdVal(Dova.JDK.java.io.FileDescriptor arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("()I", "static native")]
	public static int iovMax()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()J", "static native")]
	public static long writevMax()
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/io/FileDescriptor;", "public static")]
	public static Dova.JDK.java.io.FileDescriptor newFD(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.FileDescriptor>(ret);
	}

	[JniSignatureAttribute("(Z)J", "static native")]
	public static long makePipe(bool arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(IB)I", "static native")]
	public static int write1(int arg0, byte arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)I", "static native")]
	public static int drain1(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "static native")]
	public static int fdLimit()
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[35]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/FileDescriptor;)I", "public static native")]
	public static int fdVal(Dova.JDK.java.io.FileDescriptor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Z", "static native")]
	public static bool drain(int arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[37], arg0);
		return ret;
	}

	[JniSignatureAttribute("([B)Z", "static native")]
	public static bool randomBytes(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return ret;
	}

	[JniSignatureAttribute("Lsun/nio/ch/IOUtil$Releaser;", "static final")]
	public partial class Releaser
		: Dova.JDK.java.lang.Record
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Releaser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/IOUtil$Releaser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "handle", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "Releaser", "(Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "handle", "()Ljava/lang/Runnable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "ofNullable", "(Ljava/lang/Runnable;)Ljava/lang/Runnable;"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable handle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Releaser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "")]
		public Releaser(Dova.JDK.java.lang.Runnable handle) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], handle))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/IOUtil$Releaser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public final")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Runnable;", "static")]
		public static Dova.JDK.java.lang.Runnable of(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Runnable;", "public")]
		public Dova.JDK.java.lang.Runnable handle()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;)Ljava/lang/Runnable;", "static")]
		public static Dova.JDK.java.lang.Runnable ofNullable(Dova.JDK.java.lang.Runnable arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
	}

	[JniSignatureAttribute("Lsun/nio/ch/IOUtil$LinkedRunnable;", "static final")]
	public partial class LinkedRunnable
		: Dova.JDK.java.lang.Record
		, Dova.JDK.java.lang.Runnable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LinkedRunnable()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/nio/ch/IOUtil$LinkedRunnable;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "node", "Ljava/lang/Runnable;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "next", "Ljava/lang/Runnable;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "LinkedRunnable", "(Ljava/lang/Runnable;Ljava/lang/Runnable;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "run", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "next", "()Ljava/lang/Runnable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "of", "(Ljava/lang/Runnable;Ljava/lang/Runnable;)Lsun/nio/ch/IOUtil$LinkedRunnable;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "node", "()Ljava/lang/Runnable;"));
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable node_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Runnable;", "private final")]
		public Dova.JDK.java.lang.Runnable next_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LinkedRunnable(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Runnable;)V", "")]
		public LinkedRunnable(Dova.JDK.java.lang.Runnable node, Dova.JDK.java.lang.Runnable next) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], node, next))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/nio/ch/IOUtil$LinkedRunnable;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()V", "public")]
		public void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public final")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public final")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public final")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/Runnable;", "public")]
		public Dova.JDK.java.lang.Runnable next()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Runnable;Ljava/lang/Runnable;)Lsun/nio/ch/IOUtil$LinkedRunnable;", "static")]
		public static Dova.JDK.sun.nio.ch.IOUtil.LinkedRunnable of(Dova.JDK.java.lang.Runnable arg0, Dova.JDK.java.lang.Runnable arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.nio.ch.IOUtil.LinkedRunnable>(ret);
		}

		[JniSignatureAttribute("()Ljava/lang/Runnable;", "public")]
		public Dova.JDK.java.lang.Runnable node()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Runnable>(ret);
		}
	}
}
