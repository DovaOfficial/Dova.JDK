/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.10-07:37)
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

[JniSignatureAttribute("Ljavax/management/openmbean/OpenMBeanAttributeInfoSupport;", "public")]
public partial class OpenMBeanAttributeInfoSupport
	: Dova.JDK.javax.management.MBeanAttributeInfo
	, Dova.JDK.javax.management.openmbean.OpenMBeanAttributeInfo
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OpenMBeanAttributeInfoSupport()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljavax/management/openmbean/OpenMBeanAttributeInfoSupport;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "openType", "Ljavax/management/openmbean/OpenType;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "defaultValue", "Ljava/lang/Object;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "legalValues", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "minValue", "Ljava/lang/Comparable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "maxValue", "Ljava/lang/Comparable;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "myHashCode", "Ljava/lang/Integer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "myToString", "Ljava/lang/String;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;[Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;[Ljava/lang/Object;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZ)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjavax/management/Descriptor;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "OpenMBeanAttributeInfoSupport", "(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "toString", "(Ljavax/management/openmbean/OpenMBeanParameterInfo;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "hashCode", "(Ljavax/management/openmbean/OpenMBeanParameterInfo;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "cast", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "compare", "(Ljava/lang/Object;Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getDefaultValue", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "readResolve", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "check", "(Ljavax/management/openmbean/OpenMBeanParameterInfo;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "equal", "(Ljavax/management/openmbean/OpenMBeanParameterInfo;Ljavax/management/openmbean/OpenMBeanParameterInfo;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFrom", "(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valueFrom", "(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "valuesFrom", "(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "comparableValueFrom", "(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDescriptor", "(Ljavax/management/openmbean/OpenType;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljavax/management/Descriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "makeDescriptor", "(Ljavax/management/openmbean/OpenType;Ljava/lang/Object;Ljava/util/Set;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljavax/management/Descriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFromStrings", "(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFromStringArray", "(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "convertFromString", "(Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getOpenType", "()Ljavax/management/openmbean/OpenType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMinValue", "()Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getMaxValue", "()Ljava/lang/Comparable;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "isValue", "(Ljavax/management/openmbean/OpenMBeanParameterInfo;Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "isValue", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "getLegalValues", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasDefaultValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasLegalValues", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasMinValue", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "hasMaxValue", "()Z"));
	}

	[JniSignatureAttribute("J", "static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[0]);
			return ret;
		}
		set => DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[0], value);
	}

	[JniSignatureAttribute("Ljavax/management/openmbean/OpenType;", "private")]
	public Dova.JDK.javax.management.openmbean.OpenType openType_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.OpenType>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Object;", "private final")]
	public Dova.JDK.java.lang.Object defaultValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set legalValues_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Comparable;", "private final")]
	public Dova.JDK.java.lang.Comparable minValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Comparable;", "private final")]
	public Dova.JDK.java.lang.Comparable maxValue_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/Integer;", "private transient")]
	public Dova.JDK.java.lang.Integer myHashCode_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Integer>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private transient")]
	public Dova.JDK.java.lang.String myToString_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OpenMBeanAttributeInfoSupport(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;[Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)V", "private")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.java.lang.Object arg6, JavaArray<Dova.JDK.java.lang.Object> arg7, Dova.JDK.java.lang.Comparable arg8, Dova.JDK.java.lang.Comparable arg9) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)V", "public")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.java.lang.Object arg6, Dova.JDK.java.lang.Comparable arg7, Dova.JDK.java.lang.Comparable arg8) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;[Ljava/lang/Object;)V", "public")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.java.lang.Object arg6, JavaArray<Dova.JDK.java.lang.Object> arg7) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[2], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZ)V", "public")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[3], arg0, arg1, arg2, arg3, arg4, arg5))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjavax/management/Descriptor;)V", "public")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.javax.management.Descriptor arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[4], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;Ljavax/management/openmbean/OpenType;ZZZLjava/lang/Object;)V", "public")]
	public OpenMBeanAttributeInfoSupport(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2, bool arg3, bool arg4, bool arg5, Dova.JDK.java.lang.Object arg6) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[5], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljavax/management/openmbean/OpenMBeanAttributeInfoSupport;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenMBeanParameterInfo;)Ljava/lang/String;", "static")]
	public static Dova.JDK.java.lang.String toString(Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenMBeanParameterInfo;)I", "static")]
	public static int hashCode(Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object cast(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/Object;)I", "static")]
	public static int compare(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object getDefaultValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object readResolve()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenMBeanParameterInfo;)V", "static")]
	public static void check(Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg0)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenMBeanParameterInfo;Ljavax/management/openmbean/OpenMBeanParameterInfo;)Z", "static")]
	public static bool equal(Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg0, Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object convertFrom(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.openmbean.OpenType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;", "static")]
	public static Dova.JDK.java.lang.Object valueFrom(Dova.JDK.javax.management.Descriptor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/util/Set;", "static")]
	public static Dova.JDK.java.util.Set valuesFrom(Dova.JDK.javax.management.Descriptor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/Descriptor;Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Comparable;", "static")]
	public static Dova.JDK.java.lang.Comparable comparableValueFrom(Dova.JDK.javax.management.Descriptor arg0, Dova.JDK.java.lang.String arg1, Dova.JDK.javax.management.openmbean.OpenType arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenType;Ljava/lang/Object;[Ljava/lang/Object;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljavax/management/Descriptor;", "static")]
	public static Dova.JDK.javax.management.Descriptor makeDescriptor(Dova.JDK.javax.management.openmbean.OpenType arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2, Dova.JDK.java.lang.Comparable arg3, Dova.JDK.java.lang.Comparable arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Descriptor>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenType;Ljava/lang/Object;Ljava/util/Set;Ljava/lang/Comparable;Ljava/lang/Comparable;)Ljavax/management/Descriptor;", "static")]
	public static Dova.JDK.javax.management.Descriptor makeDescriptor(Dova.JDK.javax.management.openmbean.OpenType arg0, Dova.JDK.java.lang.Object arg1, Dova.JDK.java.util.Set arg2, Dova.JDK.java.lang.Comparable arg3, Dova.JDK.java.lang.Comparable arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Descriptor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object convertFromStrings(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.openmbean.OpenType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object convertFromStringArray(Dova.JDK.java.lang.Object arg0, Dova.JDK.javax.management.openmbean.OpenType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljavax/management/openmbean/OpenType;)Ljava/lang/Object;", "private static")]
	public static Dova.JDK.java.lang.Object convertFromString(Dova.JDK.java.lang.String arg0, Dova.JDK.javax.management.openmbean.OpenType arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/openmbean/OpenType;", "public")]
	public Dova.JDK.javax.management.openmbean.OpenType getOpenType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.OpenType>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Comparable;", "public")]
	public Dova.JDK.java.lang.Comparable getMinValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Comparable;", "public")]
	public Dova.JDK.java.lang.Comparable getMaxValue()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Comparable>(ret);
	}

	[JniSignatureAttribute("(Ljavax/management/openmbean/OpenMBeanParameterInfo;Ljava/lang/Object;)Z", "static")]
	public static bool isValue(Dova.JDK.javax.management.openmbean.OpenMBeanParameterInfo arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[23], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool isValue(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getLegalValues()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasDefaultValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasLegalValues()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasMinValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool hasMaxValue()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}
}
