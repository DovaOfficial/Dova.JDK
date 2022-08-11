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

namespace Dova.JDK.jdk.jfr.@internal;

[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport;", "public final")]
public partial class SecuritySupport
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static SecuritySupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOOKUP", "Ljava/lang/invoke/MethodHandles$Lookup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JFR_MODULE", "Ljava/lang/Module;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JFC_DIRECTORY", "Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PRIVILEGED", "Ljdk/jfr/internal/consumer/FileAccess;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JAVA_IO_TMPDIR", "Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/lang/Runnable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivileged", "(Ljava/lang/Runnable;[Ljava/security/Permission;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getResourceAsStream", "(Ljava/lang/String;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "defineClass", "(Ljava/lang/Class;[B)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setProperty", "(Ljava/lang/String;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAccessible", "(Ljava/lang/reflect/Constructor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setAccessible", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "delete", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setUncaughtExceptionHandler", "(Ljava/lang/Thread;Ljava/lang/Thread$UncaughtExceptionHandler;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toRealPath", "(Ljdk/jfr/internal/SecuritySupport$SafePath;[Ljava/nio/file/LinkOption;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getAbsolutePath", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "exists", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerShutdownHook", "(Ljava/lang/Thread;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDirectory", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "deleteOnExit", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getBooleanProperty", "(Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDirectories", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isWritable", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerEvent", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPredefinedJFCFiles", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "makeVisibleToJFR", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "moveReplace", "(Ljdk/jfr/internal/SecuritySupport$SafePath;Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clearDirectory", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "existDirectory", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFileReader", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/Reader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "touch", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureClassIsInitialized", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createThreadWitNoPermissions", "(Ljava/lang/String;Ljava/lang/Runnable;)Ljava/lang/Thread;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setDaemonThread", "(Ljava/lang/Thread;Z)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedIOWithReturn", "(Ljava/util/concurrent/Callable;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPrivilegedWithReturn", "(Ljdk/jfr/internal/SecuritySupport$CallableWithoutCheckException;[Ljava/security/Permission;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "doPriviligedIO", "(Ljdk/jfr/internal/SecuritySupport$RunnableWithCheckedException;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "registerMirror", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getPathInProperty", "(Ljava/lang/String;Ljava/lang/String;)Ljdk/jfr/internal/SecuritySupport$SafePath;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addReadEdge", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addHandlerExport", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addEventsExport", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addInstrumentExport", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRandomAccessFile", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/RandomAccessFile;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFileSize", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFileChannelToRead", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/nio/channels/ReadableByteChannel;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newFileInputStream", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/InputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createRecorderThread", "(Ljava/lang/ThreadGroup;Ljava/lang/ClassLoader;)Ljava/lang/Thread;"));
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandles$Lookup;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandles.Lookup LOOKUP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandles.Lookup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Module;", "private static final")]
	public static Dova.JDK.java.lang.Module JFR_MODULE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Module>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SafePath;", "public static final")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath JFC_DIRECTORY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/FileAccess;", "public static final")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.FileAccess PRIVILEGED_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.FileAccess>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SafePath;", "static final")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath JAVA_IO_TMPDIR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public SecuritySupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public SecuritySupport() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SecuritySupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Runnable;)V", "private static")]
	public static void doPrivileged(Dova.JDK.java.lang.Runnable arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Runnable;[Ljava/security/Permission;)V", "private static transient")]
	public static void doPrivileged(Dova.JDK.java.lang.Runnable arg0, JavaArray<Dova.JDK.java.security.Permission> arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[1], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/io/InputStream;", "public static")]
	public static Dova.JDK.java.io.InputStream getResourceAsStream(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[B)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class defineClass(Dova.JDK.java.lang.Class arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "public static")]
	public static void setProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Constructor;)V", "static")]
	public static void setAccessible(Dova.JDK.java.lang.reflect.Constructor arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "static")]
	public static void setAccessible(Dova.JDK.java.lang.reflect.Method arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[6], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "static")]
	public static void delete(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Thread;Ljava/lang/Thread$UncaughtExceptionHandler;)V", "static")]
	public static void setUncaughtExceptionHandler(Dova.JDK.java.lang.Thread arg0, Dova.JDK.java.lang.Thread.UncaughtExceptionHandler arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;[Ljava/nio/file/LinkOption;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "static transient")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath toRealPath(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0, JavaArray<Dova.JDK.java.nio.file.LinkOption> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "public static")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath getAbsolutePath(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z", "public static")]
	public static bool exists(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Thread;)V", "static")]
	public static void registerShutdownHook(Dova.JDK.java.lang.Thread arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z", "public static")]
	public static bool isDirectory(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "static")]
	public static void deleteOnExit(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Z", "static")]
	public static bool getBooleanProperty(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "static")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath createDirectories(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z", "static")]
	public static bool isWritable(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public static")]
	public static void registerEvent(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public static")]
	public static Dova.JDK.java.util.List getPredefinedJFCFiles()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void makeVisibleToJFR(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "static")]
	public static void moveReplace(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0, Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[21], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "static")]
	public static void clearDirectory(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[22], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Z", "static")]
	public static bool existDirectory(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/Reader;", "public static")]
	public static Dova.JDK.java.io.Reader newFileReader(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.Reader>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)V", "static")]
	public static void touch(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[25], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void ensureClassIsInitialized(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[26], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Runnable;)Ljava/lang/Thread;", "public static")]
	public static Dova.JDK.java.lang.Thread createThreadWitNoPermissions(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Runnable arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Thread;Z)V", "public static")]
	public static void setDaemonThread(Dova.JDK.java.lang.Thread arg0, bool arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[28], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/util/concurrent/Callable;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object doPrivilegedIOWithReturn(Dova.JDK.java.util.concurrent.Callable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$CallableWithoutCheckException;[Ljava/security/Permission;)Ljava/lang/Object;", "private static transient")]
	public static Dova.JDK.java.lang.Object doPrivilegedWithReturn(Dova.JDK.jdk.jfr.@internal.SecuritySupport.CallableWithoutCheckException arg0, JavaArray<Dova.JDK.java.security.Permission> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$RunnableWithCheckedException;)V", "private static")]
	public static void doPriviligedIO(Dova.JDK.jdk.jfr.@internal.SecuritySupport.RunnableWithCheckedException arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public static")]
	public static void registerMirror(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljdk/jfr/internal/SecuritySupport$SafePath;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath getPathInProperty(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void addReadEdge(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[34], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void addHandlerExport(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[35], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void addEventsExport(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[36], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "static")]
	public static void addInstrumentExport(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[37], arg0);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/RandomAccessFile;", "static")]
	public static Dova.JDK.java.io.RandomAccessFile createRandomAccessFile(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.RandomAccessFile>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)J", "public static")]
	public static long getFileSize(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[39], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/nio/channels/ReadableByteChannel;", "static")]
	public static Dova.JDK.java.nio.channels.ReadableByteChannel newFileChannelToRead(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.nio.channels.ReadableByteChannel>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)Ljava/io/InputStream;", "public static")]
	public static Dova.JDK.java.io.InputStream newFileInputStream(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.InputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ThreadGroup;Ljava/lang/ClassLoader;)Ljava/lang/Thread;", "static")]
	public static Dova.JDK.java.lang.Thread createRecorderThread(Dova.JDK.java.lang.ThreadGroup arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Thread>(ret);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$RunnableWithCheckedException;", "private abstract static interface")]
	public partial interface RunnableWithCheckedException
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static RunnableWithCheckedException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$RunnableWithCheckedException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "run", "()V"));
		}

		[JniSignatureAttribute("()V", "public abstract")]
		void run()
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0]);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$CallableWithoutCheckException;", "private abstract static interface")]
	public partial interface CallableWithoutCheckException
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CallableWithoutCheckException()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$CallableWithoutCheckException;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "call", "()Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("()Ljava/lang/Object;", "public abstract")]
		Dova.JDK.java.lang.Object call()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SafePath;", "public static final")]
	public partial class SafePath
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.lang.Comparable
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SafePath()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$SafePath;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "path", "Ljava/nio/file/Path;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "text", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/nio/file/Path;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljdk/jfr/internal/SecuritySupport$SafePath;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFile", "()Ljava/io/File;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPath", "()Ljava/nio/file/Path;"));
		}

		[JniSignatureAttribute("Ljava/nio/file/Path;", "private final")]
		public Dova.JDK.java.nio.file.Path path_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String text_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SafePath(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)V", "public")]
		public SafePath(Dova.JDK.java.nio.file.Path arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "public")]
		public SafePath(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SecuritySupport$SafePath;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
		public bool equals(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("(Ljdk/jfr/internal/SecuritySupport$SafePath;)I", "public")]
		public int compareTo(Dova.JDK.jdk.jfr.@internal.SecuritySupport.SafePath arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
		public int compareTo(Dova.JDK.java.lang.Object arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/io/File;", "public")]
		public Dova.JDK.java.io.File toFile()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.File>(ret);
		}

		[JniSignatureAttribute("()Ljava/nio/file/Path;", "public")]
		public Dova.JDK.java.nio.file.Path toPath()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.Path>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$DirectoryCleaner;", "private static final")]
	public partial class DirectoryCleaner
		: Dova.JDK.java.nio.file.SimpleFileVisitor
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DirectoryCleaner()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$DirectoryCleaner;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFile", "(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "visitFile", "(Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postVisitDirectory", "(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "postVisitDirectory", "(Ljava/nio/file/Path;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DirectoryCleaner(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DirectoryCleaner() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SecuritySupport$DirectoryCleaner;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public volatile")]
		public Dova.JDK.java.nio.file.FileVisitResult visitFile(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/nio/file/attribute/BasicFileAttributes;)Ljava/nio/file/FileVisitResult;", "public")]
		public Dova.JDK.java.nio.file.FileVisitResult visitFile(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.nio.file.attribute.BasicFileAttributes arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public volatile")]
		public Dova.JDK.java.nio.file.FileVisitResult postVisitDirectory(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.io.IOException arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;Ljava/io/IOException;)Ljava/nio/file/FileVisitResult;", "public")]
		public Dova.JDK.java.nio.file.FileVisitResult postVisitDirectory(Dova.JDK.java.nio.file.Path arg0, Dova.JDK.java.io.IOException arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.FileVisitResult>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$Privileged;", "private static final")]
	public partial class Privileged
		: Dova.JDK.jdk.jfr.@internal.consumer.FileAccess
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Privileged()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$Privileged;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "length", "(Ljava/io/File;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAbsolutePath", "(Ljava/io/File;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "exists", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDirectory", "(Ljava/nio/file/Path;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newDirectoryStream", "(Ljava/nio/file/Path;)Ljava/nio/file/DirectoryStream;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLastModified", "(Ljava/nio/file/Path;)Ljava/nio/file/attribute/FileTime;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "openRAF", "(Ljava/io/File;Ljava/lang/String;)Ljava/io/RandomAccessFile;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fileSize", "(Ljava/nio/file/Path;)J"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Privileged(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Privileged() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SecuritySupport$Privileged;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/io/File;)J", "public")]
		public long length(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/io/File;)Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String getAbsolutePath(Dova.JDK.java.io.File arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
		public bool exists(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Z", "public")]
		public bool isDirectory(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/DirectoryStream;", "public")]
		public Dova.JDK.java.nio.file.DirectoryStream newDirectoryStream(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.DirectoryStream>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)Ljava/nio/file/attribute/FileTime;", "public")]
		public Dova.JDK.java.nio.file.attribute.FileTime getLastModified(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.nio.file.attribute.FileTime>(ret);
		}

		[JniSignatureAttribute("(Ljava/io/File;Ljava/lang/String;)Ljava/io/RandomAccessFile;", "public")]
		public Dova.JDK.java.io.RandomAccessFile openRAF(Dova.JDK.java.io.File arg0, Dova.JDK.java.lang.String arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.io.RandomAccessFile>(ret);
		}

		[JniSignatureAttribute("(Ljava/nio/file/Path;)J", "public")]
		public long fileSize(Dova.JDK.java.nio.file.Path arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/SecuritySupport$SecureRecorderListener;", "static final")]
	public partial class SecureRecorderListener
		: Dova.JDK.java.lang.Object
		, Dova.JDK.jdk.jfr.FlightRecorderListener
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SecureRecorderListener()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/SecuritySupport$SecureRecorderListener;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "context", "Ljava/security/AccessControlContext;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "changeListener", "Ljdk/jfr/FlightRecorderListener;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/security/AccessControlContext;Ljdk/jfr/FlightRecorderListener;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recorderInitialized", "(Ljdk/jfr/FlightRecorder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "recordingStateChanged", "(Ljdk/jfr/Recording;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChangeListener", "()Ljdk/jfr/FlightRecorderListener;"));
		}

		[JniSignatureAttribute("Ljava/security/AccessControlContext;", "private final")]
		public Dova.JDK.java.security.AccessControlContext context_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.security.AccessControlContext>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/jfr/FlightRecorderListener;", "private final")]
		public Dova.JDK.jdk.jfr.FlightRecorderListener changeListener_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.FlightRecorderListener>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SecureRecorderListener(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/security/AccessControlContext;Ljdk/jfr/FlightRecorderListener;)V", "")]
		public SecureRecorderListener(Dova.JDK.java.security.AccessControlContext arg0, Dova.JDK.jdk.jfr.FlightRecorderListener arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/jfr/internal/SecuritySupport$SecureRecorderListener;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/jfr/FlightRecorder;)V", "public")]
		public void recorderInitialized(Dova.JDK.jdk.jfr.FlightRecorder arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		}

		[JniSignatureAttribute("(Ljdk/jfr/Recording;)V", "public")]
		public void recordingStateChanged(Dova.JDK.jdk.jfr.Recording arg0)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		}

		[JniSignatureAttribute("()Ljdk/jfr/FlightRecorderListener;", "public")]
		public Dova.JDK.jdk.jfr.FlightRecorderListener getChangeListener()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.FlightRecorderListener>(ret);
		}
	}
}
