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

namespace Dova.JDK.java.util.random;

[JniSignatureAttribute("Ljava/util/random/RandomGeneratorFactory;", "public final")]
public partial class RandomGeneratorFactory
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static RandomGeneratorFactory()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGeneratorFactory;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljava/util/ServiceLoader$Provider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "properties", "Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctor", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctorLong", "Ljava/lang/reflect/Constructor;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "ctorBytes", "Ljava/lang/reflect/Constructor;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/ServiceLoader$Provider;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "name", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "group", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDefault", "()Ljava/util/random/RandomGeneratorFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/lang/String;)Ljava/util/random/RandomGeneratorFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getConstructors", "(Ljava/lang/Class;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProperties", "()Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "([B)Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "(J)Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "create", "()Ljava/util/random/RandomGenerator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "all", "()Ljava/util/stream/Stream;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "period", "()Ljava/math/BigInteger;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equidistribution", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDeprecated", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSubclass", "(Ljava/lang/Class;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "isSubclass", "(Ljava/lang/Class;Ljava/util/ServiceLoader$Provider;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStochastic", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getFactoryMap", "()Ljava/util/Map;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findProvider", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/ServiceLoader$Provider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "factoryOf", "(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/random/RandomGeneratorFactory;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "ensureConstructors", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "stateBits", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStatistical", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isArbitrarilyJumpable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isJumpable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSplittable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isStreamable", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isHardware", "()Z"));
	}

	[JniSignatureAttribute("Ljava/util/ServiceLoader$Provider;", "private final")]
	public Dova.JDK.java.util.ServiceLoader.Provider provider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader.Provider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;", "private volatile")]
	public Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomGeneratorProperties properties_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomGeneratorProperties>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private volatile")]
	public Dova.JDK.java.lang.reflect.Constructor ctor_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private")]
	public Dova.JDK.java.lang.reflect.Constructor ctorLong_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/lang/reflect/Constructor;", "private")]
	public Dova.JDK.java.lang.reflect.Constructor ctorBytes_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.reflect.Constructor>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public RandomGeneratorFactory(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/util/ServiceLoader$Provider;)V", "private")]
	public RandomGeneratorFactory(Dova.JDK.java.util.ServiceLoader.Provider arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/util/random/RandomGeneratorFactory;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String name()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String group()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/random/RandomGeneratorFactory;", "public static")]
	public static Dova.JDK.java.util.random.RandomGeneratorFactory getDefault()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGeneratorFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/random/RandomGenerator;", "static")]
	public static Dova.JDK.java.lang.Object of(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/random/RandomGeneratorFactory;", "public static")]
	public static Dova.JDK.java.util.random.RandomGeneratorFactory of(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGeneratorFactory>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)V", "private")]
	public void getConstructors(Dova.JDK.java.lang.Class arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("()Ljdk/internal/util/random/RandomSupport$RandomGeneratorProperties;", "private")]
	public Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomGeneratorProperties getProperties()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.jdk.@internal.util.random.RandomSupport.RandomGeneratorProperties>(ret);
	}

	[JniSignatureAttribute("([B)Ljava/util/random/RandomGenerator;", "public")]
	public Dova.JDK.java.lang.Object create(JavaArray<byte> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/util/random/RandomGenerator;", "public")]
	public Dova.JDK.java.lang.Object create(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/random/RandomGenerator;", "public")]
	public Dova.JDK.java.lang.Object create()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/stream/Stream;", "public static")]
	public static Dova.JDK.java.util.stream.Stream all()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.stream.Stream>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigInteger;", "public")]
	public Dova.JDK.java.math.BigInteger period()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int equidistribution()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isDeprecated()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Z", "private")]
	public bool isSubclass(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Class;Ljava/util/ServiceLoader$Provider;)Z", "private static")]
	public static bool isSubclass(Dova.JDK.java.lang.Class arg0, Dova.JDK.java.util.ServiceLoader.Provider arg1)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[15], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStochastic()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[16]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Map;", "private static")]
	public static Dova.JDK.java.util.Map getFactoryMap()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/ServiceLoader$Provider;", "private static")]
	public static Dova.JDK.java.util.ServiceLoader.Provider findProvider(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.ServiceLoader.Provider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/Class;)Ljava/util/random/RandomGeneratorFactory;", "static")]
	public static Dova.JDK.java.util.random.RandomGeneratorFactory factoryOf(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.Class arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.random.RandomGeneratorFactory>(ret);
	}

	[JniSignatureAttribute("()V", "private")]
	public void ensureConstructors()
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[20]);
	}

	[JniSignatureAttribute("()I", "public")]
	public int stateBits()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStatistical()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isArbitrarilyJumpable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isJumpable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLeapable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isSplittable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isStreamable()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isHardware()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("Ljava/util/random/RandomGeneratorFactory$FactoryMapHolder;", "private static")]
	public partial class FactoryMapHolder
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FactoryMapHolder()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/util/random/RandomGeneratorFactory$FactoryMapHolder;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FACTORY_MAP", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createFactoryMap", "()Ljava/util/Map;"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "static final")]
		public static Dova.JDK.java.util.Map FACTORY_MAP_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FactoryMapHolder(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public FactoryMapHolder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/util/random/RandomGeneratorFactory$FactoryMapHolder;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/util/Map;", "private static")]
		public static Dova.JDK.java.util.Map createFactoryMap()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
	}
}
