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

[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/ConvertingMethod;", "final")]
public partial class ConvertingMethod
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ConvertingMethod()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lcom/sun/jmx/mbeanserver/ConvertingMethod;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "noStrings", "[Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljava/lang/reflect/Method;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "returnMapping", "Lcom/sun/jmx/mbeanserver/MXBeanMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paramMappings", "[Lcom/sun/jmx/mbeanserver/MXBeanMapping;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "paramConversionIsIdentity", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/reflect/Method;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "methodName", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/lang/reflect/Method;)Lcom/sun/jmx/mbeanserver/ConvertingMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljavax/management/Descriptor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethod", "()Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericParameterTypes", "()[Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGenericReturnType", "()Ljava/lang/reflect/Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeWithOpenReturn", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "invokeWithOpenReturn", "(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromOpenParameters", "([Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpenReturnType", "()Ljavax/management/openmbean/OpenType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpenParameterTypes", "()[Ljavax/management/openmbean/OpenType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCallFromOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkCallToOpen", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOpenSignature", "()[Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toOpenReturnValue", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromOpenReturnValue", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toOpenParameters", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;[Ljava/lang/Object;)[Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toOpenParameter", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;I)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "fromOpenParameter", "(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;I)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("[Ljava/lang/String;", "private static final")]
	public static JavaArray<Dova.JDK.java.lang.String> noStrings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Method;", "private final")]
	public Dova.JDK.java.lang.reflect.Method method_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lcom/sun/jmx/mbeanserver/MXBeanMapping;", "private final")]
	public Dova.JDK.com.sun.jmx.mbeanserver.MXBeanMapping returnMapping_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.MXBeanMapping>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Lcom/sun/jmx/mbeanserver/MXBeanMapping;", "private final")]
	public JavaArray<Dova.JDK.com.sun.jmx.mbeanserver.MXBeanMapping> paramMappings_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.com.sun.jmx.mbeanserver.MXBeanMapping>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool paramConversionIsIdentity_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ConvertingMethod(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)V", "private")]
	public ConvertingMethod(Dova.JDK.java.lang.reflect.Method arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Lcom/sun/jmx/mbeanserver/ConvertingMethod;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "")]
	public Dova.JDK.java.lang.String getName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "private")]
	public Dova.JDK.java.lang.String methodName()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Lcom/sun/jmx/mbeanserver/ConvertingMethod;", "static")]
	public static Dova.JDK.com.sun.jmx.mbeanserver.ConvertingMethod from(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.com.sun.jmx.mbeanserver.ConvertingMethod>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/Descriptor;", "")]
	public Dova.JDK.javax.management.Descriptor getDescriptor()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.Descriptor>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Method;", "")]
	public Dova.JDK.java.lang.reflect.Method getMethod()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("()[Ljava/lang/reflect/Type;", "")]
	public JavaArray<Dova.JDK.java.lang.reflect.Type> getGenericParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.reflect.Type>>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/reflect/Type;", "")]
	public Dova.JDK.java.lang.reflect.Type getGenericReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Type>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object invokeWithOpenReturn(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, Dova.JDK.java.lang.Object arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;[Ljava/lang/Object;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object invokeWithOpenReturn(Dova.JDK.java.lang.Object arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("([Ljava/lang/Object;)[Ljava/lang/Object;", "final")]
	public JavaArray<Dova.JDK.java.lang.Object> fromOpenParameters(JavaArray<Dova.JDK.java.lang.Object> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("()Ljavax/management/openmbean/OpenType;", "")]
	public Dova.JDK.javax.management.openmbean.OpenType getOpenReturnType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.javax.management.openmbean.OpenType>(ret);
	}

	[JniSignatureAttribute("()[Ljavax/management/openmbean/OpenType;", "")]
	public JavaArray<Dova.JDK.javax.management.openmbean.OpenType> getOpenParameterTypes()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.javax.management.openmbean.OpenType>>(ret);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkCallFromOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12]);
	}

	[JniSignatureAttribute("()V", "")]
	public void checkCallToOpen()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13]);
	}

	[JniSignatureAttribute("()[Ljava/lang/String;", "")]
	public JavaArray<Dova.JDK.java.lang.String> getOpenSignature()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object toOpenReturnValue(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object fromOpenReturnValue(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;[Ljava/lang/Object;)[Ljava/lang/Object;", "final")]
	public JavaArray<Dova.JDK.java.lang.Object> toOpenParameters(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, JavaArray<Dova.JDK.java.lang.Object> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.Object>>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;I)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object toOpenParameter(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Lcom/sun/jmx/mbeanserver/MXBeanLookup;Ljava/lang/Object;I)Ljava/lang/Object;", "final")]
	public Dova.JDK.java.lang.Object fromOpenParameter(Dova.JDK.com.sun.jmx.mbeanserver.MXBeanLookup arg0, Dova.JDK.java.lang.Object arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
