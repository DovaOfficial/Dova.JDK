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

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;", "")]
public partial class StandardMBeanIntrospector
	: Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static StandardMBeanIntrospector()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "instance", "Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "definitelyImmutable", "Ljava/util/WeakHashMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "perInterfaceMap", "Lcom/sun/jmx/mbeanserver/MBeanIntrospector$PerInterfaceMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "mbeanInfoMap", "Lcom/sun/jmx/mbeanserver/MBeanIntrospector$MBeanInfoMap;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/reflect/Method;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "(Ljava/lang/Object;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInstance", "()Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericParameterTypes", "(Ljava/lang/Object;)[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericParameterTypes", "(Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericReturnType", "(Ljava/lang/Object;)Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericReturnType", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "(Ljava/lang/Object;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSignature", "(Ljava/lang/reflect/Method;)[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethod", "(Ljava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkMethod", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isMXBean", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanDescriptor", "(Ljava/lang/Class;)Ljavax/management/Descriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAnalyzer", "(Ljava/lang/Class;)Lcom/sun/jmx/mbeanserver/MBeanAnalyzer;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isDefinitelyImmutableInfo", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPerInterfaceMap", "()Lcom/sun/jmx/mbeanserver/MBeanIntrospector$PerInterfaceMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeM2", "(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeM2", "(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validParameter", "(Ljava/lang/reflect/Method;Ljava/lang/Object;ILjava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "validParameter", "(Ljava/lang/Object;Ljava/lang/Object;ILjava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanInfoMap", "()Lcom/sun/jmx/mbeanserver/MBeanIntrospector$MBeanInfoMap;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mFrom_0", "(Ljava/lang/reflect/Method;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mFrom_1", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanAttributeInfo", "(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)Ljavax/management/MBeanAttributeInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanAttributeInfo", "(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljavax/management/MBeanAttributeInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanOperationInfo", "(Ljava/lang/String;Ljava/lang/reflect/Method;)Ljavax/management/MBeanOperationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMBeanOperationInfo", "(Ljava/lang/String;Ljava/lang/Object;)Ljavax/management/MBeanOperationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBasicMBeanDescriptor", "()Ljavax/management/Descriptor;"));
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;", "private static final")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.StandardMBeanIntrospector instance_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.StandardMBeanIntrospector>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/WeakHashMap;", "private static final")]
	public static Dova.JDK.java.util.WeakHashMap definitelyImmutable_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.WeakHashMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/MBeanIntrospector$PerInterfaceMap;", "private static final")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.PerInterfaceMap perInterfaceMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.PerInterfaceMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/MBeanIntrospector$MBeanInfoMap;", "private static final")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.MBeanInfoMap mbeanInfoMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.MBeanInfoMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public StandardMBeanIntrospector(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "")]
	public StandardMBeanIntrospector() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/String;", "volatile")]
	public Dova.JDK.java.lang.String getName(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/StandardMBeanIntrospector;", "static")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.StandardMBeanIntrospector getInstance()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.StandardMBeanIntrospector>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/reflect/Type;", "volatile")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericParameterTypes(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)[Ljava/lang/reflect/Type;", "")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericParameterTypes(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/reflect/Type;", "volatile")]
	public Dova.JDK.java.lang.reflect.Type getGenericReturnType(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Type;", "")]
	public Dova.JDK.java.lang.reflect.Type getGenericReturnType(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)[Ljava/lang/String;", "volatile")]
	public JavaArray<Dova.JDK.java.lang.String> getSignature(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)[Ljava/lang/String;", "")]
	public JavaArray<Dova.JDK.java.lang.String> getSignature(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)V", "volatile")]
	public void checkMethod(Dova.JDK.java.lang.Object arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "")]
	public void checkMethod(Dova.JDK.java.lang.reflect.Method arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
	}

	[JniSignatureAttribute("()Z", "")]
	public bool isMXBean()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljavax/management/Descriptor;", "")]
	public Dova.JDK.javax.management.Descriptor getMBeanDescriptor(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Descriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/jmx/mbeanserver/MBeanAnalyzer;", "")]
	public Dova.JDK.com.sun.jmx.mbeanserver.MBeanAnalyzer getAnalyzer(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanAnalyzer>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "static")]
	public static bool isDefinitelyImmutableInfo(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/MBeanIntrospector$PerInterfaceMap;", "")]
	public Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.PerInterfaceMap getPerInterfaceMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.PerInterfaceMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "volatile")]
	public Dova.JDK.java.lang.Object invokeM2(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object invokeM2(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;Ljava/lang/Object;ILjava/lang/Object;)Z", "")]
	public bool validParameter(Dova.JDK.java.lang.reflect.Method arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;ILjava/lang/Object;)Z", "volatile")]
	public bool validParameter(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1, int arg2, Dova.JDK.java.lang.Object arg3)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("()Lcom/sun/jmx/mbeanserver/MBeanIntrospector$MBeanInfoMap;", "")]
	public Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.MBeanInfoMap getMBeanInfoMap()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MBeanIntrospector.MBeanInfoMap>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/Object;", "volatile")]
	public Dova.JDK.java.lang.Object mFrom_0(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "")]
	public Dova.JDK.java.lang.reflect.Method mFrom_1(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;Ljava/lang/reflect/Method;)Ljavax/management/MBeanAttributeInfo;", "")]
	public Dova.JDK.javax.management.MBeanAttributeInfo getMBeanAttributeInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1, Dova.JDK.java.lang.reflect.Method arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanAttributeInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;Ljava/lang/Object;)Ljavax/management/MBeanAttributeInfo;", "volatile")]
	public Dova.JDK.javax.management.MBeanAttributeInfo getMBeanAttributeInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanAttributeInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Method;)Ljavax/management/MBeanOperationInfo;", "")]
	public Dova.JDK.javax.management.MBeanOperationInfo getMBeanOperationInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Method arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanOperationInfo>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Object;)Ljavax/management/MBeanOperationInfo;", "volatile")]
	public Dova.JDK.javax.management.MBeanOperationInfo getMBeanOperationInfo(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.MBeanOperationInfo>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/Descriptor;", "")]
	public Dova.JDK.javax.management.Descriptor getBasicMBeanDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Descriptor>(ret);
	}
}
