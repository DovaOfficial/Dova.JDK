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

namespace Dova.JDK.com.sun.org.apache.bcel.@internal;

[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/Repository;", "public abstract")]
public partial class Repository
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Repository()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/org/apache/bcel/internal/Repository;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "repository", "Lcom/sun/org/apache/bcel/internal/util/Repository;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInterfaces", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getInterfaces", "(Ljava/lang/String;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "addClass", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupClass", "(Ljava/lang/String;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "lookupClass", "(Ljava/lang/Class;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "clearCache", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSuperClasses", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getSuperClasses", "(Ljava/lang/String;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "implementationOf", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "implementationOf", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "implementationOf", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "implementationOf", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "setRepository", "(Lcom/sun/org/apache/bcel/internal/util/Repository;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getRepository", "()Lcom/sun/org/apache/bcel/internal/util/Repository;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeClass", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "removeClass", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instanceOf", "(Ljava/lang/String;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instanceOf", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Ljava/lang/String;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instanceOf", "(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "instanceOf", "(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z"));
	}

	[JniSignatureAttribute("Lcom/sun/org/apache/bcel/internal/util/Repository;", "private static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.util.Repository repository_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.util.Repository>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Repository(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public Repository() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/org/apache/bcel/internal/Repository;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass> getInterfaces(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass> getInterfaces(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass addClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass lookupClass(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass lookupClass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>(ret);
	}

	[JniSignatureAttribute("()V", "public static")]
	public static void clearCache()
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[5]);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass> getSuperClasses(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)[Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;", "public static")]
	public static JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass> getSuperClasses(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z", "public static")]
	public static bool implementationOf(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z", "public static")]
	public static bool implementationOf(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "public static")]
	public static bool implementationOf(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Ljava/lang/String;)Z", "public static")]
	public static bool implementationOf(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/util/Repository;)V", "public static")]
	public static void setRepository(Dova.JDK.com.sun.org.apache.bcel.@internal.util.Repository arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("()Lcom/sun/org/apache/bcel/internal/util/Repository;", "public static")]
	public static Dova.JDK.com.sun.org.apache.bcel.@internal.util.Repository getRepository()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.org.apache.bcel.@internal.util.Repository>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)V", "public static")]
	public static void removeClass(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "public static")]
	public static void removeClass(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[15], arg0);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Z", "public static")]
	public static bool instanceOf(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Ljava/lang/String;)Z", "public static")]
	public static bool instanceOf(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z", "public static")]
	public static bool instanceOf(Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;Lcom/sun/org/apache/bcel/internal/classfile/JavaClass;)Z", "public static")]
	public static bool instanceOf(Dova.JDK.java.lang.String arg0, Dova.JDK.com.sun.org.apache.bcel.@internal.classfile.JavaClass arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return ret;
	}
}
