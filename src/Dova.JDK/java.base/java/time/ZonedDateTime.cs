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

[JniSignatureAttribute("Ljava/time/ZonedDateTime;", "public final")]
public partial class ZonedDateTime
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.time.temporal.Temporal
	, Dova.JDK.java.time.chrono.ChronoZonedDateTime
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static ZonedDateTime()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/ZonedDateTime;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dateTime", "Ljava/time/LocalDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "Ljava/time/ZoneOffset;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zone", "Ljava/time/ZoneId;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalField;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/LocalDate;Ljava/time/LocalTime;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/LocalDateTime;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(IIIIIIILjava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalUnit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalField;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "create", "(JILjava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/Clock;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNano", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonthValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHour", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinute", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecond", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getZone", "()Ljava/time/ZoneId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_2", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusNanos", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusSeconds", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusHours", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMinutes", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusHours", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMinutes", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusSeconds", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusNanos", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/DataOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalField;J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_2", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInstant", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInstant", "(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonth", "()Ljava/time/Month;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfWeek", "()Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDayOfMonth", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDayOfYear", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMonth", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withYear", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalTime", "()Ljava/time/LocalTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks", "(J)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDateTime_0", "()Ljava/time/LocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDateTime_1", "()Ljava/time/chrono/ChronoLocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withHour", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMinute", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSecond", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNano", "(I)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDate_0", "()Ljava/time/LocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDate_1", "()Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocal", "(Ljava/time/LocalDateTime;Ljava/time/ZoneId;Ljava/time/ZoneOffset;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveLocal", "(Ljava/time/LocalDateTime;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveOffset", "(Ljava/time/ZoneOffset;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveInstant", "(Ljava/time/LocalDateTime;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withZoneSameInstant_0", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withZoneSameInstant_1", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toOffsetDateTime", "()Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLenient", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withZoneSameLocal_0", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withZoneSameLocal_1", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLaterOffsetAtOverlap_0", "()Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLaterOffsetAtOverlap_1", "()Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEarlierOffsetAtOverlap_0", "()Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withEarlierOffsetAtOverlap_1", "()Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofStrict", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedOffsetZone", "()Ljava/time/ZonedDateTime;"));
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

	[JniSignatureAttribute("Ljava/time/LocalDateTime;", "private final")]
	public Dova.JDK.java.time.LocalDateTime dateTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDateTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/ZoneOffset;", "private final")]
	public Dova.JDK.java.time.ZoneOffset offset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/ZoneId;", "private final")]
	public Dova.JDK.java.time.ZoneId zone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public ZonedDateTime(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)V", "private")]
	public ZonedDateTime(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.time.ZoneId arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/ZonedDateTime;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)I", "public")]
	public int get(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
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

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)J", "public")]
	public long getLong(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.java.time.format.DateTimeFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;Ljava/time/LocalTime;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime of(Dova.JDK.java.time.LocalDate arg0, Dova.JDK.java.time.LocalTime arg1, Dova.JDK.java.time.ZoneId arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime of(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(IIIIIIILjava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.time.ZoneId arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object query(Dova.JDK.java.time.temporal.TemporalQuery arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(JILjava/time/ZoneId;)Ljava/time/ZonedDateTime;", "private static")]
	public static Dova.JDK.java.time.ZonedDateTime create(long arg0, int arg1, Dova.JDK.java.time.ZoneId arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZoneOffset;", "public")]
	public Dova.JDK.java.time.ZoneOffset getOffset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime parse(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.time.format.DateTimeFormatter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime parse(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime now()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime now(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime now(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNano()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMonthValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfMonth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHour()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinute()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSecond()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime minus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime minus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZoneId;", "public")]
	public Dova.JDK.java.time.ZoneId getZone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneId>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime plus_2(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime plus_2(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", "public")]
	public long until(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime truncatedTo(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/DataOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.DataOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/time/ZonedDateTime;", "static")]
	public static Dova.JDK.java.time.ZonedDateTime readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[56], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime with_0(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime with_1(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_2(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime with_0(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_1(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime with_2(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime ofInstant(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.time.ZoneId arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[63], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime ofInstant(Dova.JDK.java.time.Instant arg0, Dova.JDK.java.time.ZoneId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[64], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/Month;", "public")]
	public Dova.JDK.java.time.Month getMonth()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Month>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/DayOfWeek;", "public")]
	public Dova.JDK.java.time.DayOfWeek getDayOfWeek()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[67]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withDayOfMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withDayOfYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusWeeks(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusMonths(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime plusYears(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusMonths(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalTime;", "public")]
	public Dova.JDK.java.time.LocalTime toLocalTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusYears(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime minusWeeks(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[78], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalDateTime;", "public")]
	public Dova.JDK.java.time.LocalDateTime toLocalDateTime_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[79]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoLocalDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDateTime toLocalDateTime_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withHour(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withMinute(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withSecond(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withNano(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalDate;", "public")]
	public Dova.JDK.java.time.LocalDate toLocalDate_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate toLocalDate_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneId;Ljava/time/ZoneOffset;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime ofLocal(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneId arg1, Dova.JDK.java.time.ZoneOffset arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[87], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/time/ZonedDateTime;", "private")]
	public Dova.JDK.java.time.ZonedDateTime resolveLocal(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[88], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/ZonedDateTime;", "private")]
	public Dova.JDK.java.time.ZonedDateTime resolveOffset(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;)Ljava/time/ZonedDateTime;", "private")]
	public Dova.JDK.java.time.ZonedDateTime resolveInstant(Dova.JDK.java.time.LocalDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime withZoneSameInstant_0(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withZoneSameInstant_1(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime toOffsetDateTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[93]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "private static")]
	public static Dova.JDK.java.time.ZonedDateTime ofLenient(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.time.ZoneId arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[94], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime withZoneSameLocal_0(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[95], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withZoneSameLocal_1(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[96], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime withLaterOffsetAtOverlap_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[97]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withLaterOffsetAtOverlap_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[98]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoZonedDateTime;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime withEarlierOffsetAtOverlap_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[99]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withEarlierOffsetAtOverlap_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[100]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public static")]
	public static Dova.JDK.java.time.ZonedDateTime ofStrict(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1, Dova.JDK.java.time.ZoneId arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[101], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime withFixedOffsetZone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[102]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}
}
