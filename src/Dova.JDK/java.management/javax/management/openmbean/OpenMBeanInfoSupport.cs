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

namespace Dova.JDK.javax.management.openmbean;

[JniSignatureAttribute("Ljavax/management/openmbean/OpenMBeanInfoSupport;", "public")]
public partial class OpenMBeanInfoSupport
	: Dova.JDK.javax.management.MBeanInfo
	, Dova.JDK.javax.management.openmbean.OpenMBeanInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OpenMBeanInfoSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/openmbean/OpenMBeanInfoSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myHashCode", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "myToString", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Ljavax/management/openmbean/OpenMBeanAttributeInfo;[Ljavax/management/openmbean/OpenMBeanConstructorInfo;[Ljavax/management/openmbean/OpenMBeanOperationInfo;[Ljavax/management/MBeanNotificationInfo;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;[Ljavax/management/openmbean/OpenMBeanAttributeInfo;[Ljavax/management/openmbean/OpenMBeanConstructorInfo;[Ljavax/management/openmbean/OpenMBeanOperationInfo;[Ljavax/management/MBeanNotificationInfo;Ljavax/management/Descriptor;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "constructorArray", "([Ljavax/management/openmbean/OpenMBeanConstructorInfo;)[Ljavax/management/MBeanConstructorInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "operationArray", "([Ljavax/management/openmbean/OpenMBeanOperationInfo;)[Ljavax/management/MBeanOperationInfo;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "sameArrayContents", "([Ljava/lang/Object;[Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "arraySetHash", "([Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "attributeArray", "([Ljavax/management/openmbean/OpenMBeanAttributeInfo;)[Ljavax/management/MBeanAttributeInfo;"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
		}
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "private transient")]
	public Dova.JDK.java.lang.Integer myHashCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String myToString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OpenMBeanInfoSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljavax/management/openmbean/OpenMBeanAttributeInfo;[Ljavax/management/openmbean/OpenMBeanConstructorInfo;[Ljavax/management/openmbean/OpenMBeanOperationInfo;[Ljavax/management/MBeanNotificationInfo;)V", "public")]
	public OpenMBeanInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanAttributeInfo> arg2, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanConstructorInfo> arg3, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanOperationInfo> arg4, JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;[Ljavax/management/openmbean/OpenMBeanAttributeInfo;[Ljavax/management/openmbean/OpenMBeanConstructorInfo;[Ljavax/management/openmbean/OpenMBeanOperationInfo;[Ljavax/management/MBeanNotificationInfo;Ljavax/management/Descriptor;)V", "public")]
	public OpenMBeanInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanAttributeInfo> arg2, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanConstructorInfo> arg3, JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanOperationInfo> arg4, JavaArray<Dova.JDK.javax.management.MBeanNotificationInfo> arg5, Dova.JDK.javax.management.Descriptor arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/openmbean/OpenMBeanInfoSupport;";
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

	[JniSignatureAttribute("([Ljavax/management/openmbean/OpenMBeanConstructorInfo;)[Ljavax/management/MBeanConstructorInfo;", "private static")]
	public static JavaArray<Dova.JDK.javax.management.MBeanConstructorInfo> constructorArray(JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanConstructorInfo> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanConstructorInfo>>(ret);
	}

	[JniSignatureAttribute("([Ljavax/management/openmbean/OpenMBeanOperationInfo;)[Ljavax/management/MBeanOperationInfo;", "private static")]
	public static JavaArray<Dova.JDK.javax.management.MBeanOperationInfo> operationArray(JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanOperationInfo> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanOperationInfo>>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;[Ljava/lang/Object;)Z", "private static")]
	public static bool sameArrayContents(JavaArray<Dova.JDK.java.lang.Object> arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)I", "private static")]
	public static int arraySetHash(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("([Ljavax/management/openmbean/OpenMBeanAttributeInfo;)[Ljavax/management/MBeanAttributeInfo;", "private static")]
	public static JavaArray<Dova.JDK.javax.management.MBeanAttributeInfo> attributeArray(JavaArray<Dova.JDK.javax.management.openmbean.OpenMBeanAttributeInfo> arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.MBeanAttributeInfo>>(ret);
	}
}
