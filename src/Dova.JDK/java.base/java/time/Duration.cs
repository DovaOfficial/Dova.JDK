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

namespace Dova.JDK.java.time;

[JniSignatureAttribute("Ljava/time/Duration;", "public final")]
public partial class Duration
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.time.temporal.TemporalAmount
	, Dova.JDK.java.lang.Comparable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static Duration()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/Duration;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ZERO", "Ljava/time/Duration;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BI_NANOS_PER_SECOND", "Ljava/math/BigInteger;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "seconds", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nanos", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JI)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "abs", "()Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/time/Duration;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMillis", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(Ljava/math/BigDecimal;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(JI)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(ZJJJJI)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toNanos", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "between", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isZero", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNano", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDays", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSeconds", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isNegative", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus", "(Ljava/time/Duration;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPositive", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(JJ)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus", "(Ljava/time/Duration;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getUnits", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "charMatch", "(Ljava/lang/CharSequence;IIC)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseNumber", "(Ljava/lang/CharSequence;IIILjava/lang/String;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parseFraction", "(Ljava/lang/CharSequence;III)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSeconds", "(JJ)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofSeconds", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "negated", "()Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofNanos", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSeconds", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusNanos", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusSeconds", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMillis", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "multipliedBy", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusHours", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMinutes", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toBigDecimalSeconds", "()Ljava/math/BigDecimal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHours", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMinutes", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofDays", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofHours", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofMinutes", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofMillis", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSeconds", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNanos", "(I)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusHours", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMinutes", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusSeconds", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMillis", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusNanos", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dividedBy", "(J)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dividedBy", "(Ljava/time/Duration;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "addTo", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "subtractFrom", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toDaysPart", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toHoursPart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMinutesPart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toSecondsPart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toMillisPart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toNanosPart", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/Duration;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/DataInput;)Ljava/time/Duration;"));
	}

	[JniSignatureAttribute("Ljava/time/Duration;", "public static final")]
	public static Dova.JDK.java.time.Duration ZERO_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[1]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[1], value);
		}
	}

	[JniSignatureAttribute("Ljava/math/BigInteger;", "private static final")]
	public static Dova.JDK.java.math.BigInteger BI_NANOS_PER_SECOND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigInteger>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private final")]
	public long seconds_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private final")]
	public int nanos_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public Duration(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(JI)V", "private")]
	public Duration(long arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/Duration;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)J", "public")]
	public long get(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int hashCode()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration abs()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)I", "public")]
	public int compareTo(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration of(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration from(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
	}

	[JniSignatureAttribute("()J", "public")]
	public long toMillis()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[10]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/math/BigDecimal;)Ljava/time/Duration;", "private static")]
	public static Dova.JDK.java.time.Duration create(Dova.JDK.java.math.BigDecimal arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(JI)Ljava/time/Duration;", "private static")]
	public static Dova.JDK.java.time.Duration create(long arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(ZJJJJI)Ljava/time/Duration;", "private static")]
	public static Dova.JDK.java.time.Duration create(bool arg0, long arg1, long arg2, long arg3, long arg4, int arg5)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3, arg4, arg5);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long toNanos()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[15]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration parse(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/Temporal;)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration between(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.Temporal arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isZero()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNano()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[19]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long toDays()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[20]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long toSeconds()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[21]);
		return ret;
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isNegative()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[22]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minus(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minus(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isPositive()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plus(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(JJ)Ljava/time/Duration;", "private")]
	public Dova.JDK.java.time.Duration plus(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plus(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getUnits()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;IIC)Z", "private static")]
	public static bool charMatch(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, char arg3)
	{
		var ret = DovaVM.Runtime.CallStaticBooleanMethodA(ClassRefPtr, MethodPtrs[30], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;IIILjava/lang/String;)J", "private static")]
	public static long parseNumber(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, int arg3, Dova.JDK.java.lang.String arg4)
	{
		var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[31], arg0, arg1, arg2, arg3, arg4);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;III)I", "private static")]
	public static int parseFraction(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[32], arg0, arg1, arg2, arg3);
		return ret;
	}

	[JniSignatureAttribute("(JJ)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofSeconds(long arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration negated()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long getSeconds()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[37]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusMillis(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration multipliedBy(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration plusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("()Ljava/math/BigDecimal;", "private")]
	public Dova.JDK.java.math.BigDecimal toBigDecimalSeconds()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long toHours()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long toMinutes()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[47]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public static")]
	public static Dova.JDK.java.time.Duration ofMillis(long arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration withSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration withNanos(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusMillis(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration minusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration dividedBy(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Duration;)J", "public")]
	public long dividedBy(Dova.JDK.java.time.Duration arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal addTo(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal subtractFrom(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long toDaysPart()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int toHoursPart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int toMinutesPart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[66]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int toSecondsPart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int toMillisPart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[68]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int toNanosPart()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[69]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Ljava/time/Duration;", "public")]
	public Dova.JDK.java.time.Duration truncatedTo(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)Ljava/time/Duration;", "static")]
	public static Dova.JDK.java.time.Duration readExternal(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Duration>(ret);
	}

	[JniSignatureAttribute("Ljava/time/Duration$Lazy;", "private static")]
	public partial class Lazy
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static Lazy()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/Duration$Lazy;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PATTERN", "Ljava/util/regex/Pattern;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern;", "static final")]
		public static Dova.JDK.java.util.regex.Pattern PATTERN_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public Lazy(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public Lazy() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/Duration$Lazy;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}

	[JniSignatureAttribute("Ljava/time/Duration$DurationUnits;", "private static")]
	public partial class DurationUnits
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DurationUnits()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/Duration$DurationUnits;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNITS", "Ljava/util/List;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("Ljava/util/List;", "static final")]
		public static Dova.JDK.java.util.List UNITS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DurationUnits(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public DurationUnits() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/Duration$DurationUnits;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
