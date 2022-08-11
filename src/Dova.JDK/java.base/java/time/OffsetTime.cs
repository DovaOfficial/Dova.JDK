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

[JniSignatureAttribute("Ljava/time/OffsetTime;", "public final")]
public partial class OffsetTime
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

	static OffsetTime()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/OffsetTime;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MIN", "Ljava/time/OffsetTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "MAX", "Ljava/time/OffsetTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "time", "Ljava/time/LocalTime;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "offset", "Ljava/time/ZoneOffset;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "get", "(Ljava/time/temporal/TemporalField;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/lang/Object;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "compareTo", "(Ljava/time/OffsetTime;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLong", "(Ljava/time/temporal/TemporalField;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimeFormatter;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "of", "(IIIILjava/time/ZoneOffset;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "from", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalField;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupported", "(Ljava/time/temporal/TemporalUnit;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "query", "(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getOffset", "()Ljava/time/ZoneOffset;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/TemporalField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "()Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/Clock;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "now", "(Ljava/time/ZoneId;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNano", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getHour", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getMinute", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getSecond", "()I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_0", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plus_1", "(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "until", "(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusNanos", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusSeconds", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusHours", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "plusMinutes", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusHours", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusMinutes", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusSeconds", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "minusNanos", "(J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "truncatedTo", "(Ljava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeExternal", "(Ljava/io/ObjectOutput;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "readExternal", "(Ljava/io/ObjectInput;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "adjustInto", "(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_0", "(Ljava/time/temporal/TemporalField;J)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with_1", "(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "with", "(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofInstant", "(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isAfter", "(Ljava/time/OffsetTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isBefore", "(Ljava/time/OffsetTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toLocalTime", "()Ljava/time/LocalTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEqual", "(Ljava/time/OffsetTime;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toEpochSecond", "(Ljava/time/LocalDate;)J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withHour", "(I)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withMinute", "(I)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSecond", "(I)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withNano", "(I)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "atDate", "(Ljava/time/LocalDate;)Ljava/time/OffsetDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toEpochNano", "()J"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOffsetSameInstant", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOffsetSameLocal", "(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;"));
	}

	[JniSignatureAttribute("Ljava/time/OffsetTime;", "public static final")]
	public static Dova.JDK.java.time.OffsetTime MIN_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/OffsetTime;", "public static final")]
	public static Dova.JDK.java.time.OffsetTime MAX_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
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

	[JniSignatureAttribute("Ljava/time/LocalTime;", "private final")]
	public Dova.JDK.java.time.LocalTime time_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalTime>(ret);
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
	public OffsetTime(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)V", "private")]
	public OffsetTime(Dova.JDK.java.time.LocalTime arg0, Dova.JDK.java.time.ZoneOffset arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/OffsetTime;";
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

	[JniSignatureAttribute("(Ljava/time/OffsetTime;)I", "public")]
	public int compareTo(Dova.JDK.java.time.OffsetTime arg0)
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

	[JniSignatureAttribute("(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime of(Dova.JDK.java.time.LocalTime arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[8], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(IIIILjava/time/ZoneOffset;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime of(int arg0, int arg1, int arg2, int arg3, Dova.JDK.java.time.ZoneOffset arg4)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3, arg4);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime from(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Z", "public")]
	public bool isSupported(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object query(Dova.JDK.java.time.temporal.TemporalQuery arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
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

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime parse(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/time/format/DateTimeFormatter;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime parse(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.time.format.DateTimeFormatter arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime now()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime now(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime now(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("()I", "public")]
	public int getNano()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[23]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getHour()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[24]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getMinute()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[25]);
		return ret;
	}

	[JniSignatureAttribute("()I", "public")]
	public int getSecond()
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[26]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal minus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_0(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(JLjava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plus_1(long arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal plus_0(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAmount;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plus_1(Dova.JDK.java.time.temporal.TemporalAmount arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;Ljava/time/temporal/TemporalUnit;)J", "public")]
	public long until(Dova.JDK.java.time.temporal.Temporal arg0, Dova.JDK.java.time.temporal.TemporalUnit arg1)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime plusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minusHours(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minusMinutes(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minusSeconds(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime minusNanos(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalUnit;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime truncatedTo(Dova.JDK.java.time.temporal.TemporalUnit arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[44], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectOutput;)V", "")]
	public void writeExternal(Dova.JDK.java.io.ObjectOutput arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[45], arg0);
	}

	[JniSignatureAttribute("(Ljava/io/ObjectInput;)Ljava/time/OffsetTime;", "static")]
	public static Dova.JDK.java.time.OffsetTime readExternal(Dova.JDK.java.io.ObjectInput arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[46], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/Temporal;)Ljava/time/temporal/Temporal;", "public")]
	public Dova.JDK.java.time.temporal.Temporal adjustInto(Dova.JDK.java.time.temporal.Temporal arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime with_0(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAdjuster;)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_1(Dova.JDK.java.time.temporal.TemporalAdjuster arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[49], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime with_0(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[50], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/temporal/Temporal;", "public volatile")]
	public Dova.JDK.java.time.temporal.Temporal with_1(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[51], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.Temporal>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalTime;Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", "private")]
	public Dova.JDK.java.time.OffsetTime with(Dova.JDK.java.time.LocalTime arg0, Dova.JDK.java.time.ZoneOffset arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[52], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/OffsetTime;", "public static")]
	public static Dova.JDK.java.time.OffsetTime ofInstant(Dova.JDK.java.time.Instant arg0, Dova.JDK.java.time.ZoneId arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[53], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/OffsetTime;)Z", "public")]
	public bool isAfter(Dova.JDK.java.time.OffsetTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[54], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/OffsetTime;)Z", "public")]
	public bool isBefore(Dova.JDK.java.time.OffsetTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[55], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/time/LocalTime;", "public")]
	public Dova.JDK.java.time.LocalTime toLocalTime()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[56]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/OffsetTime;)Z", "public")]
	public bool isEqual(Dova.JDK.java.time.OffsetTime arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[57], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;)J", "public")]
	public long toEpochSecond(Dova.JDK.java.time.LocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[58], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withHour(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[59], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withMinute(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[60], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withSecond(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[61], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withNano(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[62], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/LocalDate;)Ljava/time/OffsetDateTime;", "public")]
	public Dova.JDK.java.time.OffsetDateTime atDate(Dova.JDK.java.time.LocalDate arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[63], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetDateTime>(ret);
	}

	[JniSignatureAttribute("()J", "private")]
	public long toEpochNano()
	{
		var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[64]);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withOffsetSameInstant(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[65], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneOffset;)Ljava/time/OffsetTime;", "public")]
	public Dova.JDK.java.time.OffsetTime withOffsetSameLocal(Dova.JDK.java.time.ZoneOffset arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[66], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.OffsetTime>(ret);
	}
}
