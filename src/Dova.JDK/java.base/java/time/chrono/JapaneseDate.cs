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

[JniSignatureAttribute("Ljava/time/chrono/JapaneseDate;", "public final")]
public partial class JapaneseDate
	: Dova.JDK.java.time.chrono.ChronoLocalDateImpl
	, Dova.JDK.java.time.chrono.ChronoLocalDate
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JapaneseDate()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/chrono/JapaneseDate;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isoDate", "Ljava/time/LocalDate;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "era", "Ljava/time/chrono/JapaneseEra;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "yearOfEra", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MEIJI_6_ISODATE", "Ljava/time/LocalDate;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/LocalDate;)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/chrono/JapaneseEra;ILjava/time/LocalDate;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/chrono/JapaneseEra;III)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(III)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalField;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/Clock;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/ZoneId;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/DataInput;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/time/LocalDate;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthOfMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "lengthOfYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toEpochDay", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withYear", "(I)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withYear", "(Ljava/time/chrono/JapaneseEra;I)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofYearDay", "(Ljava/time/chrono/JapaneseEra;II)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atTime", "(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra_0", "()Ljava/time/chrono/JapaneseEra;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getEra_1", "()Ljava/time/chrono/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology_0", "()Ljava/time/chrono/JapaneseChronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology_1", "()Ljava/time/chrono/Chronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears_0", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears_1", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks_0", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks_1", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "toPrivateJapaneseDate", "(Ljava/time/LocalDate;)Lsun/util/calendar/LocalGregorianCalendar$Date;"));
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

	[JniSignatureAttribute("Ljava/time/LocalDate;", "private final transient")]
	public Dova.JDK.java.time.LocalDate isoDate_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/chrono/JapaneseEra;", "private final transient")]
	public Dova.JDK.java.time.chrono.JapaneseEra era_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseEra>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("I", "private final transient")]
	public int yearOfEra_Property
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

	[JniSignatureAttribute("Ljava/time/LocalDate;", "static final")]
	public static Dova.JDK.java.time.LocalDate MEIJI_6_ISODATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDate>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JapaneseDate(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;)V", "")]
	public JapaneseDate(Dova.JDK.java.time.LocalDate arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
	{
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;ILjava/time/LocalDate;)V", "")]
	public JapaneseDate(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1, Dova.JDK.java.time.LocalDate arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/chrono/JapaneseDate;";
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

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;III)Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate of(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate of(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate now()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate now(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/JapaneseDate;", "public static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate now(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate minus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate minus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate plus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate plus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/ChronoLocalDate;)Ljava/time/chrono/ChronoPeriod;", "public")]
	public Dova.JDK.java.time.chrono.ChronoPeriod until(Dova.JDK.java.time.chrono.ChronoLocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoPeriod>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", "public volatile")]
	public long until(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusDays_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate plusDays_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusDays_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate minusDays_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/DataInput;)Ljava/time/chrono/JapaneseDate;", "static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate readExternal(Dova.JDK.java.io.DataInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate with_0(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate with_1(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_2(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_0(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate with_1(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate with_2(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;)Ljava/time/chrono/JapaneseDate;", "private")]
	public Dova.JDK.java.time.chrono.JapaneseDate with(Dova.JDK.java.time.LocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
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

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusWeeks_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate plusWeeks_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusMonths_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate plusMonths_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/chrono/JapaneseDate;", "private")]
	public Dova.JDK.java.time.chrono.JapaneseDate withYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;I)Ljava/time/chrono/JapaneseDate;", "private")]
	public Dova.JDK.java.time.chrono.JapaneseDate withYear(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;II)Ljava/time/chrono/JapaneseDate;", "static")]
	public static Dova.JDK.java.time.chrono.JapaneseDate ofYearDay(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[50], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate plusYears_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate plusYears_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusMonths_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate minusMonths_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalTime;)Ljava/time/chrono/ChronoLocalDateTime;", "public final")]
	public Dova.JDK.java.time.chrono.ChronoLocalDateTime atTime(Dova.JDK.java.time.LocalTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/JapaneseEra;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseEra getEra_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseEra>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Era;", "public volatile")]
	public Dova.JDK.java.time.chrono.Era getEra_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Era>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/JapaneseChronology;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseChronology getChronology_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseChronology>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Chronology;", "public volatile")]
	public Dova.JDK.java.time.chrono.Chronology getChronology_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusYears_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate minusYears_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "")]
	public Dova.JDK.java.time.chrono.JapaneseDate minusWeeks_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate minusWeeks_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;)Lsun/util/calendar/LocalGregorianCalendar$Date;", "private static")]
	public static Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date toPrivateJapaneseDate(Dova.JDK.java.time.LocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar.Date>(ret);
	}
}
