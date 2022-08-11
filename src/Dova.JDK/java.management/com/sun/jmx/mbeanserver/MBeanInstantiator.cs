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

namespace Dova.JDK.com.sun.jmx.mbeanserver;

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/MBeanInstantiator;", "public")]
public partial class MBeanInstantiator
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static MBeanInstantiator()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/MBeanInstantiator;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clr", "Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "primitiveClasses", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoader", "(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClass", "(Ljava/lang/String;Ljavax/management/ObjectName;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findConstructor", "(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deserialize", "(Ljava/lang/String;Ljavax/management/ObjectName;[BLjava/lang/ClassLoader;)Ljava/io/ObjectInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "deserialize", "(Ljava/lang/ClassLoader;[B)Ljava/io/ObjectInputStream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ensureClassAccess", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findSignatureClasses", "([Ljava/lang/String;Ljava/lang/ClassLoader;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findClassWithDefaultLoaderRepository", "(Ljava/lang/String;)Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "loadSignatureClasses", "([Ljava/lang/String;Ljava/lang/ClassLoader;)[Ljava/lang/Class;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/ClassLoader;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Class;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "instantiate", "(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanPermission", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "checkMBeanPermission", "(Ljava/lang/Class;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassLoaderRepository", "()Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "testCreation", "(Ljava/lang/Class;)V"));
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;", "private final")]
	public Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository clr_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map primitiveClasses_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public MBeanInstantiator(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;)V", "")]
	public MBeanInstantiator(Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/MBeanInstantiator;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "static")]
	public static Dova.JDK.java.lang.Class loadClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/ObjectName;)Ljava/lang/ClassLoader;", "private")]
	public Dova.JDK.java.lang.ClassLoader getClassLoader(Dova.JDK.javax.management.ObjectName arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.ClassLoader>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class findClass(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Class;)Ljava/lang/reflect/Constructor;", "private")]
	public Dova.JDK.java.lang.reflect.Constructor findConstructor(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Class> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;[BLjava/lang/ClassLoader;)Ljava/io/ObjectInputStream;", "public")]
	public Dova.JDK.java.io.ObjectInputStream deserialize(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, JavaArray<byte> arg2, Dova.JDK.java.lang.ClassLoader arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/ClassLoader;[B)Ljava/io/ObjectInputStream;", "public")]
	public Dova.JDK.java.io.ObjectInputStream deserialize(Dova.JDK.java.lang.ClassLoader arg0, JavaArray<byte> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.io.ObjectInputStream>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private static")]
	public static void ensureClassAccess(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("([Ljava/lang/String;Ljava/lang/ClassLoader;)[Ljava/lang/Class;", "public")]
	public JavaArray<Dova.JDK.java.lang.Class> findSignatureClasses(JavaArray<Dova.JDK.java.lang.String> arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Class;", "public")]
	public Dova.JDK.java.lang.Class findClassWithDefaultLoaderRepository(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/String;Ljava/lang/ClassLoader;)[Ljava/lang/Class;", "static")]
	public static JavaArray<Dova.JDK.java.lang.Class> loadSignatureClasses(JavaArray<Dova.JDK.java.lang.String> arg0, Dova.JDK.java.lang.ClassLoader arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Class>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/ClassLoader;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, Dova.JDK.java.lang.ClassLoader arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.Class arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, JavaArray<Dova.JDK.java.lang.String> arg2, Dova.JDK.java.lang.ClassLoader arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, JavaArray<Dova.JDK.java.lang.Object> arg1, JavaArray<Dova.JDK.java.lang.String> arg2, Dova.JDK.java.lang.ClassLoader arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/ObjectName;[Ljava/lang/Object;[Ljava/lang/String;Ljava/lang/ClassLoader;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object instantiate(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.ObjectName arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, JavaArray<Dova.JDK.java.lang.String> arg3, Dova.JDK.java.lang.ClassLoader arg4)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V", "private static")]
	public static void checkMBeanPermission(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/String;Ljavax/management/ObjectName;Ljava/lang/String;)V", "private static")]
	public static void checkMBeanPermission(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.ObjectName arg2, Dova.JDK.java.lang.String arg3)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/ModifiableClassLoaderRepository;", "public")]
	public Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository getClassLoaderRepository()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.ModifiableClassLoaderRepository>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "public")]
	public void testCreation(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
	}
}
