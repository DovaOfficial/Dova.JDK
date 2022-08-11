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

namespace Dova.JDK.java.time.chrono;

[JniSignatureAttribute("Ljava/time/chrono/HijrahDate;", "public final")]
public partial class HijrahDate
	: Dova.JDK.java.time.chrono.ChronoLocalDateImpl
	, Dova.JDK.java.time.chrono.ChronoLocalDate
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static HijrahDate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/chrono/HijrahDate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chrono", "Ljava/time/chrono/HijrahChronology;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "prolepticYear", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "monthOfYear", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dayOfMonth", "I"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/chrono/HijrahChronology;J)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/chrono/HijrahChronology;III)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/chrono/HijrahChronology;III)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(III)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/ZoneId;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/Clock;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays_1", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays_0", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays_1", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapYear", "()Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofEpochDay", "(Ljava/time/chrono/HijrahChronology;J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthOfMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthOfYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toEpochDay", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getProlepticMonth", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfWeek", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks_1", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths_1", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolvePreviousValid", "(III)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears_0", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears_1", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths_1", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atTime", "(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra_0", "()Ljava/time/chrono/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra_1", "()Ljava/time/chrono/HijrahEra;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology_0", "()Ljava/time/chrono/Chronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology_1", "()Ljava/time/chrono/HijrahChronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears_1", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks_0", "(J)Ljava/time/chrono/HijrahDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks_1", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEraValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withVariant", "(Ljava/time/chrono/HijrahChronology;)Ljava/time/chrono/HijrahDate;"));
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

	[JniSignatureAttribute("Ljava/time/chrono/HijrahChronology;", "private final transient")]
	public Dova.JDK.java.time.chrono.HijrahChronology chrono_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahChronology>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final transient")]
	public int prolepticYear_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("I", "private final transient")]
	public int monthOfYear_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("I", "private final transient")]
	public int dayOfMonth_Property
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
	public HijrahDate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/chrono/HijrahChronology;J)V", "private")]
	public HijrahDate(Dova.JDK.java.time.chrono.HijrahChronology arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("(Ljava/time/chrono/HijrahChronology;III)V", "private")]
	public HijrahDate(Dova.JDK.java.time.chrono.HijrahChronology arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/chrono/HijrahDate;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/lang/Object;)Z", "public")]
	public bool equals(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public volatile")]
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

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)J", "public")]
	public long getLong(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/chrono/HijrahChronology;III)Ljava/time/chrono/HijrahDate;", "static")]
	public static Dova.JDK.java.time.chrono.HijrahDate of(Dova.JDK.java.time.chrono.HijrahChronology arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/time/chrono/HijrahDate;", "public static")]
	public static Dova.JDK.java.time.chrono.HijrahDate of(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/HijrahDate;", "public static")]
	public static Dova.JDK.java.time.chrono.HijrahDate from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/HijrahDate;", "public static")]
	public static Dova.JDK.java.time.chrono.HijrahDate now(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/chrono/HijrahDate;", "public static")]
	public static Dova.JDK.java.time.chrono.HijrahDate now(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/HijrahDate;", "public static")]
	public static Dova.JDK.java.time.chrono.HijrahDate now()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate minus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate minus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate plus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate plus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod until(Dova.JDK.java.time.chrono.ChronoLocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", "public volatile")]
	public long until(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusDays_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate plusDays_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate minusDays_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusDays_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/time/chrono/HijrahDate;", "static")]
	public static Dova.JDK.java.time.chrono.HijrahDate readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[32], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate with_0(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_1(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate with_2(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate with_0(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_1(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate with_2(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("()Z", "public")]
	public bool isLeapYear()
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[39]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/chrono/HijrahChronology;J)Ljava/time/chrono/HijrahDate;", "static")]
	public static Dova.JDK.java.time.chrono.HijrahDate ofEpochDay(Dova.JDK.java.time.chrono.HijrahChronology arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthOfMonth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[41]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int lengthOfYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[42]);
		return ret;
	}

	[JniSignatureAttribute("()J", "public")]
	public long toEpochDay()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[43]);
		return ret;
	}

	[JniSignatureAttribute("()J", "private")]
	public long getProlepticMonth()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[44]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int getDayOfWeek()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[45]);
		return ret;
	}

	[JniSignatureAttribute("()I", "private")]
	public int getDayOfYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[46]);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusWeeks_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate plusWeeks_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusMonths_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate plusMonths_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/time/chrono/HijrahDate;", "private")]
	public Dova.JDK.java.time.chrono.HijrahDate resolvePreviousValid(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate plusYears_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusYears_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusMonths_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate minusMonths_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;", "public final")]
	public Dova.JDK.java.time.chrono.ChronoLocalDateTime atTime(Dova.JDK.java.time.LocalTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Era;", "public volatile")]
	public Dova.JDK.java.time.chrono.Era getEra_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Era>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/HijrahEra;", "public")]
	public Dova.JDK.java.time.chrono.HijrahEra getEra_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahEra>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Chronology;", "public volatile")]
	public Dova.JDK.java.time.chrono.Chronology getChronology_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/HijrahChronology;", "public")]
	public Dova.JDK.java.time.chrono.HijrahChronology getChronology_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahChronology>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusYears_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate minusYears_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/HijrahDate;", "")]
	public Dova.JDK.java.time.chrono.HijrahDate minusWeeks_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusWeeks_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("()I", "private")]
	public int getEraValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/chrono/HijrahChronology;)Ljava/time/chrono/HijrahDate;", "public")]
	public Dova.JDK.java.time.chrono.HijrahDate withVariant(Dova.JDK.java.time.chrono.HijrahChronology arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.HijrahDate>(ret);
	}
}
