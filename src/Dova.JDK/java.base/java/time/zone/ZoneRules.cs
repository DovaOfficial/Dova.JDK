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

namespace Dova.JDK.java.time.zone;

[JniSignatureAttribute("Ljava/time/zone/ZoneRules;", "public final")]
public partial class ZoneRules
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZoneRules()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/zone/ZoneRules;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LAST_CACHED_YEAR", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "standardTransitions", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "standardOffsets", "[Ljava/time/ZoneOffset;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "savingsInstantTransitions", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "savingsLocalTransitions", "[Ljava/time/LocalDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "wallOffsets", "[Ljava/time/ZoneOffset;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRules", "[Ljava/time/zone/ZoneOffsetTransitionRule;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "lastRulesCache", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LONG_ARRAY", "[J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LASTRULES", "[Ljava/time/zone/ZoneOffsetTransitionRule;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EMPTY_LDT_ARRAY", "[Ljava/time/LocalDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYS_PER_CYCLE", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYS_0000_TO_1970", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([J[Ljava/time/ZoneOffset;[J[Ljava/time/ZoneOffset;[Ljava/time/zone/ZoneOffsetTransitionRule;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/ZoneOffset;Ljava/time/ZoneOffset;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/ZoneOffset;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/ZoneOffset;Ljava/time/ZoneOffset;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljava/time/zone/ZoneRules;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/ZoneOffset;)Ljava/time/zone/ZoneRules;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "(Ljava/time/LocalDateTime;)Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "(Ljava/time/Instant;)Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/DataInput;)Ljava/time/zone/ZoneRules;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransition", "(Ljava/time/LocalDateTime;)Ljava/time/zone/ZoneOffsetTransition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedOffset", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getStandardOffset", "(Ljava/time/Instant;)Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findYear", "(JLjava/time/ZoneOffset;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findTransitionArray", "(I)[Ljava/time/zone/ZoneOffsetTransition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffsetInfo", "(Ljava/time/LocalDateTime;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValidOffsets", "(Ljava/time/LocalDateTime;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "findOffsetInfo", "(Ljava/time/LocalDateTime;Ljava/time/zone/ZoneOffsetTransition;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDaylightSavings", "(Ljava/time/Instant;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isDaylightSavings", "(Ljava/time/Instant;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isValidOffset", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "nextTransition", "(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "previousTransition", "(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransitions", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTransitionRules", "()Ljava/util/List;"));
	}

	[JniSignatureAttribute("J", "private static final")]
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

	[JniSignatureAttribute("I", "private static final")]
	public static int LAST_CACHED_YEAR_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> standardTransitions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/ZoneOffset;", "private final")]
	public JavaArray<Dova.JDK.java.time.ZoneOffset> standardOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.ZoneOffset>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private final")]
	public JavaArray<long> savingsInstantTransitions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/LocalDateTime;", "private final")]
	public JavaArray<Dova.JDK.java.time.LocalDateTime> savingsLocalTransitions_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.LocalDateTime>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/ZoneOffset;", "private final")]
	public JavaArray<Dova.JDK.java.time.ZoneOffset> wallOffsets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.ZoneOffset>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/zone/ZoneOffsetTransitionRule;", "private final")]
	public JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransitionRule> lastRules_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransitionRule>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private final transient")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap lastRulesCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[J", "private static final")]
	public static JavaArray<long> EMPTY_LONG_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/zone/ZoneOffsetTransitionRule;", "private static final")]
	public static JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransitionRule> EMPTY_LASTRULES_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransitionRule>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("[Ljava/time/LocalDateTime;", "private static final")]
	public static JavaArray<Dova.JDK.java.time.LocalDateTime> EMPTY_LDT_ARRAY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.LocalDateTime>>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private static final")]
	public static int DAYS_PER_CYCLE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[12]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[12], value);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long DAYS_0000_TO_1970_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[13]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[13], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZoneRules(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("([J[Ljava/time/ZoneOffset;[J[Ljava/time/ZoneOffset;[Ljava/time/zone/ZoneOffsetTransitionRule;)V", "private")]
	public ZoneRules(JavaArray<long> arg0, JavaArray<Dova.JDK.java.time.ZoneOffset> arg1, JavaArray<long> arg2, JavaArray<Dova.JDK.java.time.ZoneOffset> arg3, JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransitionRule> arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;Ljava/time/ZoneOffset;Ljava/util/List;Ljava/util/List;Ljava/util/List;)V", "")]
	public ZoneRules(Dova.JDK.java.time.ZoneOffset arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
	{
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)V", "private")]
	public ZoneRules(Dova.JDK.java.time.ZoneOffset arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[2], arg0))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/zone/ZoneRules;";
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

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;Ljava/time/ZoneOffset;Ljava/util/List;Ljava/util/List;Ljava/util/List;)Ljava/time/zone/ZoneRules;", "public static")]
	public static Dova.JDK.java.time.zone.ZoneRules of(Dova.JDK.java.time.ZoneOffset arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.util.List arg2, Dova.JDK.java.util.List arg3, Dova.JDK.java.util.List arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneRules>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/zone/ZoneRules;", "public static")]
	public static Dova.JDK.java.time.zone.ZoneRules of(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneRules>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/time/ZoneOffset;", "public")]
	public Dova.JDK.java.time.ZoneOffset getOffset(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/ZoneOffset;", "public")]
	public Dova.JDK.java.time.ZoneOffset getOffset(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)Ljava/time/zone/ZoneRules;", "static")]
	public static Dova.JDK.java.time.zone.ZoneRules readExternal(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneRules>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/time/zone/ZoneOffsetTransition;", "public")]
	public Dova.JDK.java.time.zone.ZoneOffsetTransition getTransition(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneOffsetTransition>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isFixedOffset()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/ZoneOffset;", "public")]
	public Dova.JDK.java.time.ZoneOffset getStandardOffset(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/ZoneOffset;)I", "private")]
	public int findYear(long arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[14], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(I)[Ljava/time/zone/ZoneOffsetTransition;", "private")]
	public JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransition> findTransitionArray(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.zone.ZoneOffsetTransition>>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object getOffsetInfo(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getValidOffsets(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/zone/ZoneOffsetTransition;)Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object findOffsetInfo(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.zone.ZoneOffsetTransition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration getDaylightSavings(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Z", "public")]
	public bool isDaylightSavings(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[20], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Z", "public")]
	public bool isValidOffset(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;", "public")]
	public Dova.JDK.java.time.zone.ZoneOffsetTransition nextTransition(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneOffsetTransition>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;)Ljava/time/zone/ZoneOffsetTransition;", "public")]
	public Dova.JDK.java.time.zone.ZoneOffsetTransition previousTransition(Dova.JDK.java.time.Instant arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.zone.ZoneOffsetTransition>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getTransitions()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getTransitionRules()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}
}
