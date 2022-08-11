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

[JniSignatureAttribute("Ljava/time/OffsetDateTime;", "public final")]
public partial class OffsetDateTime
	: Dova.JDK.java.lang.Object
	, Dova.JDK.java.time.temporal.Temporal
	, Dova.JDK.java.time.temporal.TemporalAdjuster
	, Dova.JDK.java.lang.Comparable
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static OffsetDateTime()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/OffsetDateTime;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN", "Ljava/time/OffsetDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX", "Ljava/time/OffsetDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dateTime", "Ljava/time/LocalDateTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "Ljava/time/ZoneOffset;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalField;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/time/OffsetDateTime;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(IIIIIIILjava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/LocalDate;Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalUnit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalField;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/Clock;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/ZoneId;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNano", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toInstant", "()Ljava/time/Instant;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonthValue", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfMonth", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHour", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinute", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecond", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusNanos", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusSeconds", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusDays", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusHours", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMinutes", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusDays", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusHours", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMinutes", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusSeconds", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusNanos", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalField;J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInstant", "(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAfter", "(Ljava/time/OffsetDateTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBefore", "(Ljava/time/OffsetDateTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMonth", "()Ljava/time/Month;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfWeek", "()Ljava/time/DayOfWeek;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDayOfYear", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDayOfMonth", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDayOfYear", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusWeeks", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMonth", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMonths", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withYear", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusYears", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMonths", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalTime", "()Ljava/time/LocalTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEqual", "(Ljava/time/OffsetDateTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusYears", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusWeeks", "(J)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toEpochSecond", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "timeLineOrder", "()Ljava/util/Comparator;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDateTime", "()Ljava/time/LocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withHour", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMinute", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSecond", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNano", "(I)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalDate", "()Ljava/time/LocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toZonedDateTime", "()Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOffsetSameInstant", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "compareInstant", "(Ljava/time/OffsetDateTime;Ljava/time/OffsetDateTime;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOffsetSameLocal", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atZoneSameInstant", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atZoneSimilarLocal", "(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toOffsetTime", "()Ljava/time/OffsetTime;"));
	}

	[JniSignatureAttribute("Ljava/time/OffsetDateTime;", "public static final")]
	public static Dova.JDK.java.time.OffsetDateTime MIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/OffsetDateTime;", "public static final")]
	public static Dova.JDK.java.time.OffsetDateTime MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[2]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[2], value);
		}
	}

	[JniSignatureAttribute("Ljava/time/LocalDateTime;", "private final")]
	public Dova.JDK.java.time.LocalDateTime dateTime_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDateTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/ZoneOffset;", "private final")]
	public Dova.JDK.java.time.ZoneOffset offset_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public OffsetDateTime(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)V", "private")]
	public OffsetDateTime(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/OffsetDateTime;";
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

	[JniSignatureAttribute("(Ljava/lang/Object;)I", "public volatile")]
	public int compareTo(Dova.JDK.java.lang.Object arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/OffsetDateTime;)I", "public")]
	public int compareTo(Dova.JDK.java.time.OffsetDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)J", "public")]
	public long getLong(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.java.time.format.DateTimeFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(IIIIIIILjava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime of(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int arg6, Dova.JDK.java.time.ZoneOffset arg7)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime of(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime of(Dova.JDK.java.time.LocalDate arg0, Dova.JDK.java.time.LocalTime arg1, Dova.JDK.java.time.ZoneOffset arg2)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object query(Dova.JDK.java.time.temporal.TemporalQuery arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZoneOffset;", "public")]
	public Dova.JDK.java.time.ZoneOffset getOffset()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneOffset>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "private")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime parse(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime parse(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.time.format.DateTimeFormatter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime now(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime now(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime now()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNano()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/Instant;", "public")]
	public Dova.JDK.java.time.Instant toInstant()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Instant>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMonthValue()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfMonth()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[28]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHour()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[29]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinute()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[30]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSecond()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[31]);
		return ret;
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", "public")]
	public long until(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[40], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusDays(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime truncatedTo(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[52], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/time/OffsetDateTime;", "static")]
	public static Dova.JDK.java.time.OffsetDateTime readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal adjustInto(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDateTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "private")]
	public Dova.JDK.java.time.OffsetDateTime with(Dova.JDK.java.time.LocalDateTime arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[55], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_0(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime with_1(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[57], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_0(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime with_1(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/OffsetDateTime;", "public static")]
	public static Dova.JDK.java.time.OffsetDateTime ofInstant(Dova.JDK.java.time.Instant arg0, Dova.JDK.java.time.ZoneId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[60], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/OffsetDateTime;)Z", "public")]
	public bool isAfter(Dova.JDK.java.time.OffsetDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/OffsetDateTime;)Z", "public")]
	public bool isBefore(Dova.JDK.java.time.OffsetDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/Month;", "public")]
	public Dova.JDK.java.time.Month getMonth()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.Month>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/DayOfWeek;", "public")]
	public Dova.JDK.java.time.DayOfWeek getDayOfWeek()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[64]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.DayOfWeek>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getDayOfYear()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[65]);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withDayOfMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withDayOfYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[67], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusWeeks(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[68], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withMonth(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[69], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusMonths(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[70], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withYear(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[71], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime plusYears(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[72], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusMonths(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[73], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalTime;", "public")]
	public Dova.JDK.java.time.LocalTime toLocalTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[74]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/OffsetDateTime;)Z", "public")]
	public bool isEqual(Dova.JDK.java.time.OffsetDateTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[75], arg0);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusYears(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[76], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime minusWeeks(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[77], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()J", "public")]
	public long toEpochSecond()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[78]);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Comparator;", "public static")]
	public static Dova.JDK.java.util.Comparator timeLineOrder()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[79]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalDateTime;", "public")]
	public Dova.JDK.java.time.LocalDateTime toLocalDateTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[80]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withHour(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[81], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withMinute(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[82], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withSecond(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[83], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withNano(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[84], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/LocalDate;", "public")]
	public Dova.JDK.java.time.LocalDate toLocalDate()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[85]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime toZonedDateTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[86]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withOffsetSameInstant(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[87], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/OffsetDateTime;Ljava/time/OffsetDateTime;)I", "private static")]
	public static int compareInstant(Dova.JDK.java.time.OffsetDateTime arg0, Dova.JDK.java.time.OffsetDateTime arg1)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[88], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime withOffsetSameLocal(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[89], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime atZoneSameInstant(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[90], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/ZonedDateTime;", "public")]
	public Dova.JDK.java.time.ZonedDateTime atZoneSimilarLocal(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[91], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime toOffsetTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[92]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}
}
