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

namespace Dova.JDK.javax.management;

[JniSignatureAttribute("Ljavax/management/MBeanServerFactory;", "public")]
public partial class MBeanServerFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MBeanServerFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/MBeanServerFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "builder", "Ljavax/management/MBeanServerBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mBeanServerList", "Ljava/util/ArrayList;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkPermission", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newBuilder", "(Ljava/lang/Class;)Ljavax/management/MBeanServerBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newMBeanServer", "()Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "releaseMBeanServer", "(Ljavax/management/MBeanServer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeMBeanServer", "(Ljavax/management/MBeanServer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createMBeanServer", "()Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createMBeanServer", "(Ljava/lang/String;)Ljavax/management/MBeanServer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addMBeanServer", "(Ljavax/management/MBeanServer;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getNewMBeanServerBuilder", "()Ljavax/management/MBeanServerBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findMBeanServer", "(Ljava/lang/String;)Ljava/util/ArrayList;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mBeanServerId", "(Ljavax/management/MBeanServer;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadBuilderClass", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanServerBuilder", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getClassLoaderRepository", "(Ljavax/management/MBeanServer;)Ljavax/management/loading/ClassLoaderRepository;"));
	}

	[JniSignatureAttribute("Ljavax/management/MBeanServerBuilder;", "private static")]
	public static Dova.JDK.javax.management.MBeanServerBuilder builder_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/ArrayList;", "private static final")]
	public static Dova.JDK.java.util.ArrayList mBeanServerList_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MBeanServerFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public MBeanServerFactory() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/MBeanServerFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private static")]
	public static void checkPermission(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/management/MBeanServerBuilder;", "private static")]
	public static Dova.JDK.javax.management.MBeanServerBuilder newBuilder(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/management/MBeanServer;", "public static")]
	public static Dova.JDK.javax.management.MBeanServer newMBeanServer(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServer;", "public static")]
	public static Dova.JDK.javax.management.MBeanServer newMBeanServer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "public static")]
	public static void releaseMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[4], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "private static synchronized")]
	public static void removeMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServer;", "public static")]
	public static Dova.JDK.javax.management.MBeanServer createMBeanServer()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljavax/management/MBeanServer;", "public static")]
	public static Dova.JDK.javax.management.MBeanServer createMBeanServer(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServer>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)V", "private static synchronized")]
	public static void addMBeanServer(Dova.JDK.javax.management.MBeanServer arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljavax/management/MBeanServerBuilder;", "private static synchronized")]
	public static Dova.JDK.javax.management.MBeanServerBuilder getNewMBeanServerBuilder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanServerBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/ArrayList;", "public static synchronized")]
	public static Dova.JDK.java.util.ArrayList findMBeanServer(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ArrayList>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String mBeanServerId(Dova.JDK.javax.management.MBeanServer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "private static")]
	public static Dova.JDK.java.lang.Class loadBuilderClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("()V", "private static synchronized")]
	public static void checkMBeanServerBuilder()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("(Ljavax/management/MBeanServer;)Ljavax/management/loading/ClassLoaderRepository;", "public static")]
	public static Dova.JDK.javax.management.loading.ClassLoaderRepository getClassLoaderRepository(Dova.JDK.javax.management.MBeanServer arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.loading.ClassLoaderRepository>(ret);
	}
}
