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

namespace Dova.JDK.jdk.jfr.@internal.consumer;

[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ObjectFactory;", "public abstract")]
public partial class ObjectFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ObjectFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/jfr/internal/consumer/ObjectFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "PRIVATE_ACCESS", "Ljdk/jfr/internal/consumer/JdkJfrConsumer;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_PREFIX_VERSION_1", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "TYPE_PREFIX_VERSION_2", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STACK_FRAME_VERSION_1", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassRefPtr, "STACK_FRAME_VERSION_2", "Ljava/lang/String;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassRefPtr, "objectContext", "Ljdk/jfr/internal/consumer/ObjectContext;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "ObjectFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "create", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createObject", "(JLjava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createThreadFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createFrameFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createMethodFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createdThreadGroupFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createStackTraceFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createClassLoaderFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassRefPtr, "createClassFactory", "(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassRefPtr, "createTyped", "(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljava/lang/Object;"));
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/JdkJfrConsumer;", "private static final")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer PRIVATE_ACCESS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.JdkJfrConsumer>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String TYPE_PREFIX_VERSION_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "private static final")]
	public static Dova.JDK.java.lang.String TYPE_PREFIX_VERSION_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String STACK_FRAME_VERSION_1_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/lang/String;", "public static final")]
	public static Dova.JDK.java.lang.String STACK_FRAME_VERSION_2_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
		set => DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljdk/jfr/internal/consumer/ObjectContext;", "private final")]
	public Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext objectContext_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext>(ret);
		}
		set => DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ObjectFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)V", "private")]
	public ObjectFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1) : base(DovaVM.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/jfr/internal/consumer/ObjectFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory create(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(JLjava/lang/Object;)Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object createObject(long arg0, Dova.JDK.java.lang.Object arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createThreadFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createFrameFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createMethodFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createdThreadGroupFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createStackTraceFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createClassLoaderFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/Type;Ljdk/jfr/internal/consumer/TimeConverter;)Ljdk/jfr/internal/consumer/ObjectFactory;", "private static")]
	public static Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory createClassFactory(Dova.JDK.jdk.jfr.@internal.Type arg0, Dova.JDK.jdk.jfr.@internal.consumer.TimeConverter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.jfr.@internal.consumer.ObjectFactory>(ret);
	}

	[JniSignatureAttribute("(Ljdk/jfr/internal/consumer/ObjectContext;J[Ljava/lang/Object;)Ljava/lang/Object;", "abstract")]
	public Dova.JDK.java.lang.Object createTyped(Dova.JDK.jdk.jfr.@internal.consumer.ObjectContext arg0, long arg1, JavaArray<Dova.JDK.java.lang.Object> arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}
}
