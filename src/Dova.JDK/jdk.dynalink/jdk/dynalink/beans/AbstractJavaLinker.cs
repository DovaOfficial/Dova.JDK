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

namespace Dova.JDK.jdk.dynalink.beans;

[JniSignatureAttribute("Ljdk/dynalink/beans/AbstractJavaLinker;", "abstract")]
public partial class AbstractJavaLinker
	: Dova.JDK.java.lang.Object
	, Dova.JDK.jdk.dynalink.linker.GuardingDynamicLinker
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AbstractJavaLinker()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/AbstractJavaLinker;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "clazz", "Ljava/lang/Class;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "classGuard", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "assignableGuard", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertyGetters", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "propertySetters", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "methods", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_METHOD_HANDLE_NOT_NULL", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_NULL_DROP_METHOD_HANDLE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "privateLookup", "Ljdk/dynalink/linker/support/Lookup;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_ANNOTATED_METHOD_NOT_NULL", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "CONSTANT_NULL_DROP_ANNOTATED_METHOD", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_ANNOTATED_METHOD", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GETTER_INVOKER", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "IS_DYNAMIC_METHOD", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "OBJECT_IDENTITY", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_PROPERTY_GETTER_HANDLE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPropertyGetterHandle", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_PROPERTY_SETTER_HANDLE", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getPropertySetterHandle", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GET_DYNAMIC_METHOD", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "getDynamicMethod", "Ljava/lang/invoke/MethodHandle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertyGetter", "(Ljava/lang/String;Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertyGetter", "(Ljava/lang/String;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setPropertyGetter", "(Ljava/lang/reflect/Method;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyGetterHandle", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDynamicMethod", "(Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/beans/DynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDynamicMethod", "(Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDynamicMethod", "(Ljava/lang/Object;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createFacetIntrospector", "()Ljdk/dynalink/beans/FacetIntrospector;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertySetterHandle", "(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getUnmodifiableKeys", "(Ljava/util/Map;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMostGenericGetter", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMostGenericGetter", "(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDynamicMethod", "(Ljava/lang/Iterable;Ljava/lang/Class;Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createDynamicMethod", "(Ljava/lang/reflect/Executable;)Ljdk/dynalink/beans/SingleDynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mergeMethods", "(Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/DynamicMethod;Ljava/lang/Class;Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "unreflectSafely", "(Ljava/lang/reflect/Executable;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getExplicitSignatureDynamicMethod", "(Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/beans/SingleDynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructorMethod", "(Ljava/lang/String;)Ljdk/dynalink/beans/SingleDynamicMethod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnnamedPropertySetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamedPropertySetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "assertParameterCount", "(Ljdk/dynalink/CallSiteDescriptor;I)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createGuardedDynamicMethodInvocation", "(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/linker/GuardedInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getReadablePropertyNames", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getWritablePropertyNames", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodNames", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocationComponent", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMethodGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNextComponent", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createNoSuchMemberHandler", "(Ljdk/dynalink/beans/MissingMemberHandlerFactory;Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassGuardedInvocationComponent", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDynamicMethodInvocation", "(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnnamedPropertyGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamedPropertyGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAssignableGuard", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnnamedMethodGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNamedMethodGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getMethodGetterType", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljava/lang/invoke/MethodType;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "matchReturnTypes", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/AbstractJavaLinker$MethodPair;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertyGetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getPropertySetter", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getClassGuard", "(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMember", "(Ljava/lang/String;Ljava/lang/reflect/Executable;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addMember", "(Ljava/lang/String;Ljdk/dynalink/beans/SingleDynamicMethod;Ljava/util/Map;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "decapitalize", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuardedInvocation", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getGuard", "(Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;"));
	}

	[JniSignatureAttribute("Ljava/lang/Class;", "final")]
	public Dova.JDK.java.lang.Class clazz_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Class>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle classGuard_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle assignableGuard_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map propertyGetters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map propertySetters_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private final")]
	public Dova.JDK.java.util.Map methods_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle IS_METHOD_HANDLE_NOT_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle CONSTANT_NULL_DROP_METHOD_HANDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/linker/support/Lookup;", "private static final")]
	public static Dova.JDK.jdk.dynalink.linker.support.Lookup privateLookup_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.support.Lookup>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle IS_ANNOTATED_METHOD_NOT_NULL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle CONSTANT_NULL_DROP_ANNOTATED_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle GET_ANNOTATED_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle GETTER_INVOKER_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle IS_DYNAMIC_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle OBJECT_IDENTITY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle GET_PROPERTY_GETTER_HANDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle getPropertyGetterHandle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle GET_PROPERTY_SETTER_HANDLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle getPropertySetterHandle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private static final")]
	public static Dova.JDK.java.lang.invoke.MethodHandle GET_DYNAMIC_METHOD_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "private final")]
	public Dova.JDK.java.lang.invoke.MethodHandle getDynamicMethod_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "static final")]
	public static bool assertionsDisabled_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[21]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[21], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AbstractJavaLinker(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;)V", "")]
	public AbstractJavaLinker(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "")]
	public AbstractJavaLinker(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.java.lang.invoke.MethodHandle arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/AbstractJavaLinker;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "private")]
	public void setPropertyGetter(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg1, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/invoke/MethodHandle;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
	public void setPropertyGetter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;I)V", "private")]
	public void setPropertyGetter(Dova.JDK.java.lang.reflect.Method arg0, int arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getPropertyGetterHandle(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/beans/DynamicMethod;", "private")]
	public Dova.JDK.jdk.dynalink.beans.DynamicMethod getDynamicMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.DynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;", "")]
	public Dova.JDK.jdk.dynalink.beans.DynamicMethod getDynamicMethod(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.DynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getDynamicMethod(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljdk/dynalink/beans/FacetIntrospector;", "abstract")]
	public Dova.JDK.jdk.dynalink.beans.FacetIntrospector createFacetIntrospector()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.FacetIntrospector>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/Object;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle getPropertySetterHandle(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.java.lang.Object arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;)Ljava/util/Set;", "private static")]
	public static Dova.JDK.java.util.Set getUnmodifiableKeys(Dova.JDK.java.util.Map arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getMostGenericGetter(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Method;)Ljava/lang/reflect/Method;", "private static")]
	public static Dova.JDK.java.lang.reflect.Method getMostGenericGetter(Dova.JDK.java.lang.reflect.Method arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Method>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Iterable;Ljava/lang/Class;Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;", "static")]
	public static Dova.JDK.jdk.dynalink.beans.DynamicMethod createDynamicMethod(Dova.JDK.java.lang.Iterable arg0, Dova.JDK.java.lang.Class arg1, Dova.JDK.java.lang.String arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.DynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)Ljdk/dynalink/beans/SingleDynamicMethod;", "private static")]
	public static Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod createDynamicMethod(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/DynamicMethod;Ljava/lang/Class;Ljava/lang/String;)Ljdk/dynalink/beans/DynamicMethod;", "private static")]
	public static Dova.JDK.jdk.dynalink.beans.DynamicMethod mergeMethods(Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg0, Dova.JDK.jdk.dynalink.beans.DynamicMethod arg1, Dova.JDK.java.lang.Class arg2, Dova.JDK.java.lang.String arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.DynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/reflect/Executable;)Ljava/lang/invoke/MethodHandle;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodHandle unreflectSafely(Dova.JDK.java.lang.reflect.Executable arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/beans/SingleDynamicMethod;", "private")]
	public Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod getExplicitSignatureDynamicMethod(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljdk/dynalink/beans/SingleDynamicMethod;", "abstract")]
	public Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod getConstructorMethod(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getUnnamedPropertySetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getNamedPropertySetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;I)V", "private static")]
	public static void assertParameterCount(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, int arg1)
	{
		DovaVM.Runtime.CallStaticVoidMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/String;Ljava/util/Map;)Ljdk/dynalink/linker/GuardedInvocation;", "private")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation createGuardedDynamicMethodInvocation(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set getReadablePropertyNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set getWritablePropertyNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "")]
	public Dova.JDK.java.util.Set getMethodNames()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "protected")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getGuardedInvocationComponent(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getMethodGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getNextComponent(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/MissingMemberHandlerFactory;Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent createNoSuchMemberHandler(Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg0, Dova.JDK.jdk.dynalink.linker.LinkRequest arg1, Dova.JDK.jdk.dynalink.linker.LinkerServices arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodType;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getClassGuardedInvocationComponent(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;Ljava/lang/String;Ljava/util/Map;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle getDynamicMethodInvocation(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.java.lang.String arg2, Dova.JDK.java.util.Map arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getUnnamedPropertyGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getNamedPropertyGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle getAssignableGuard(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getUnnamedMethodGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getNamedMethodGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljava/lang/invoke/MethodType;", "private static")]
	public static Dova.JDK.java.lang.invoke.MethodType getMethodGetterType(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodType>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)Ljdk/dynalink/beans/AbstractJavaLinker$MethodPair;", "static")]
	public static Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.MethodPair matchReturnTypes(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.MethodPair>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getPropertyGetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljdk/dynalink/beans/GuardedInvocationComponent;", "private")]
	public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent getPropertySetter(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "")]
	public Dova.JDK.java.lang.invoke.MethodHandle getClassGuard(Dova.JDK.java.lang.invoke.MethodType arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/reflect/Executable;Ljava/util/Map;)V", "private")]
	public void addMember(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.reflect.Executable arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljdk/dynalink/beans/SingleDynamicMethod;Ljava/util/Map;)V", "private")]
	public void addMember(Dova.JDK.java.lang.String arg0, Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg1, Dova.JDK.java.util.Map arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String decapitalize(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;)Ljdk/dynalink/linker/GuardedInvocation;", "public")]
	public Dova.JDK.jdk.dynalink.linker.GuardedInvocation getGuardedInvocation(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.GuardedInvocation>(ret);
	}

	[JniSignatureAttribute("(Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;Ljava/lang/invoke/MethodType;)Ljava/lang/invoke/MethodHandle;", "private")]
	public Dova.JDK.java.lang.invoke.MethodHandle getGuard(Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg0, Dova.JDK.java.lang.invoke.MethodType arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/AbstractJavaLinker$AnnotatedDynamicMethod;", "private static final")]
	public partial class AnnotatedDynamicMethod
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AnnotatedDynamicMethod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/AbstractJavaLinker$AnnotatedDynamicMethod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method", "Ljdk/dynalink/beans/SingleDynamicMethod;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "validationType", "Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$assertionsDisabled", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTarget", "(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getInvocation", "(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/SingleDynamicMethod;", "private final")]
		public Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod method_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;", "final")]
		public Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType validationType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "static final")]
		public static bool assertionsDisabled_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticBooleanField(ClassRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticBooleanField(ClassRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AnnotatedDynamicMethod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/dynalink/beans/SingleDynamicMethod;Ljdk/dynalink/beans/GuardedInvocationComponent$ValidationType;)V", "")]
		public AnnotatedDynamicMethod(Dova.JDK.jdk.dynalink.beans.SingleDynamicMethod arg0, Dova.JDK.jdk.dynalink.beans.GuardedInvocationComponent.ValidationType arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/AbstractJavaLinker$AnnotatedDynamicMethod;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljdk/dynalink/CallSiteDescriptor;Ljdk/dynalink/linker/LinkerServices;)Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle getTarget(Dova.JDK.jdk.dynalink.CallSiteDescriptor arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}

		[JniSignatureAttribute("(Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;)Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle getInvocation(Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;", "static final")]
	public partial class ComponentLinkRequest
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ComponentLinkRequest()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linkRequest", "Ljdk/dynalink/linker/LinkRequest;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "linkerServices", "Ljdk/dynalink/linker/LinkerServices;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "missingMemberHandlerFactory", "Ljdk/dynalink/beans/MissingMemberHandlerFactory;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseOperation", "Ljdk/dynalink/Operation;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "namespaces", "Ljava/util/List;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "name", "Ljava/lang/Object;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;Ljdk/dynalink/Operation;Ljava/util/List;Ljava/lang/Object;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDescriptor", "()Ljdk/dynalink/CallSiteDescriptor;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "popNamespace", "()Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;"));
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/LinkRequest;", "final")]
		public Dova.JDK.jdk.dynalink.linker.LinkRequest linkRequest_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.LinkRequest>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/linker/LinkerServices;", "final")]
		public Dova.JDK.jdk.dynalink.linker.LinkerServices linkerServices_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.linker.LinkerServices>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/beans/MissingMemberHandlerFactory;", "final")]
		public Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory missingMemberHandlerFactory_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljdk/dynalink/Operation;", "final")]
		public Dova.JDK.jdk.dynalink.Operation baseOperation_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.Operation>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/List;", "final")]
		public Dova.JDK.java.util.List namespaces_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/Object;", "final")]
		public Dova.JDK.java.lang.Object name_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ComponentLinkRequest(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;)V", "")]
		public ComponentLinkRequest(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(Ljdk/dynalink/linker/LinkRequest;Ljdk/dynalink/linker/LinkerServices;Ljdk/dynalink/beans/MissingMemberHandlerFactory;Ljdk/dynalink/Operation;Ljava/util/List;Ljava/lang/Object;)V", "private")]
		public ComponentLinkRequest(Dova.JDK.jdk.dynalink.linker.LinkRequest arg0, Dova.JDK.jdk.dynalink.linker.LinkerServices arg1, Dova.JDK.jdk.dynalink.beans.MissingMemberHandlerFactory arg2, Dova.JDK.jdk.dynalink.Operation arg3, Dova.JDK.java.util.List arg4, Dova.JDK.java.lang.Object arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljdk/dynalink/CallSiteDescriptor;", "")]
		public Dova.JDK.jdk.dynalink.CallSiteDescriptor getDescriptor()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.CallSiteDescriptor>(ret);
		}

		[JniSignatureAttribute("()Ljdk/dynalink/beans/AbstractJavaLinker$ComponentLinkRequest;", "")]
		public Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest popNamespace()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.dynalink.beans.AbstractJavaLinker.ComponentLinkRequest>(ret);
		}
	}

	[JniSignatureAttribute("Ljdk/dynalink/beans/AbstractJavaLinker$MethodPair;", "static")]
	public partial class MethodPair
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static MethodPair()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljdk/dynalink/beans/AbstractJavaLinker$MethodPair;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method1", "Ljava/lang/invoke/MethodHandle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "method2", "Ljava/lang/invoke/MethodHandle;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "guardWithTest", "(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;"));
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.MethodHandle method1_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/invoke/MethodHandle;", "final")]
		public Dova.JDK.java.lang.invoke.MethodHandle method2_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public MethodPair(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;Ljava/lang/invoke/MethodHandle;)V", "")]
		public MethodPair(Dova.JDK.java.lang.invoke.MethodHandle arg0, Dova.JDK.java.lang.invoke.MethodHandle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljdk/dynalink/beans/AbstractJavaLinker$MethodPair;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/invoke/MethodHandle;)Ljava/lang/invoke/MethodHandle;", "")]
		public Dova.JDK.java.lang.invoke.MethodHandle guardWithTest(Dova.JDK.java.lang.invoke.MethodHandle arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.invoke.MethodHandle>(ret);
		}
	}
}
