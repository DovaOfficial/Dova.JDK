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

[JniSignatureAttribute("Ljava/time/chrono/JapaneseChronology;", "public final")]
public partial class JapaneseChronology
	: Dova.JDK.java.time.chrono.AbstractChronology
	, Dova.JDK.java.io.Serializable
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JapaneseChronology()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/chrono/JapaneseChronology;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "JCAL", "Lsun/util/calendar/LocalGregorianCalendar;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LOCALE", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE", "Ljava/time/chrono/JapaneseChronology;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "serialVersionUID", "J"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "readObject", "(Ljava/io/ObjectInputStream;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getId", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "writeReplace", "()Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "range", "(Ljava/time/temporal/ChronoField;)Ljava/time/temporal/ValueRange;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_0", "(Ljava/time/chrono/Era;III)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_1", "(Ljava/time/chrono/Era;III)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_0", "(III)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_1", "(III)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_0", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "date_1", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eras", "()Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isLeapYear", "(J)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eraOf_0", "(I)Ljava/time/chrono/Era;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "eraOf_1", "(I)Ljava/time/chrono/JapaneseEra;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localDateTime", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarType", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateEpochDay_0", "(J)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateEpochDay_1", "(J)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveYearOfEra", "(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveYMD", "(Ljava/time/chrono/JapaneseEra;ILjava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveYD", "(Ljava/time/chrono/JapaneseEra;ILjava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_0", "(Ljava/time/Clock;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_1", "(Ljava/time/Clock;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_0", "(Ljava/time/ZoneId;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_1", "(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_0", "()Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateNow_1", "()Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prolepticYear", "(Ljava/time/chrono/Era;I)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateYearDay_0", "(Ljava/time/chrono/Era;II)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateYearDay_1", "(Ljava/time/chrono/Era;II)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateYearDay_0", "(II)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "dateYearDay_1", "(II)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDate_0", "(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/JapaneseDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "resolveDate_1", "(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "zonedDateTime", "(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "zonedDateTime", "(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrentEra", "()Ljava/time/chrono/JapaneseEra;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prolepticYearLenient", "(Ljava/time/chrono/JapaneseEra;I)I"));
	}

	[JniSignatureAttribute("Lsun/util/calendar/LocalGregorianCalendar;", "static final")]
	public static Dova.JDK.sun.util.calendar.LocalGregorianCalendar JCAL_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.calendar.LocalGregorianCalendar>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "static final")]
	public static Dova.JDK.java.util.Locale LOCALE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/chrono/JapaneseChronology;", "public static final")]
	public static Dova.JDK.java.time.chrono.JapaneseChronology INSTANCE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseChronology>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("J", "private static final")]
	public static long serialVersionUID_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticLongField(ClassRefPtr, FieldPtrs[3]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetStaticLongField(ClassRefPtr, FieldPtrs[3], value);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JapaneseChronology(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "private")]
	public JapaneseChronology() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/chrono/JapaneseChronology;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/io/ObjectInputStream;)V", "private")]
	public void readObject(Dova.JDK.java.io.ObjectInputStream arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/Object;", "")]
	public Dova.JDK.java.lang.Object writeReplace()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/ChronoField;)Ljava/time/temporal/ValueRange;", "public")]
	public Dova.JDK.java.time.temporal.ValueRange range(Dova.JDK.java.time.temporal.ChronoField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.ValueRange>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Era;III)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate date_0(Dova.JDK.java.time.chrono.Era arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Era;III)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate date_1(Dova.JDK.java.time.chrono.Era arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate date_0(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(III)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate date_1(int arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate date_0(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate date_1(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List eras()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(J)Z", "public")]
	public bool isLeapYear(long arg0)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return ret;
	}

	[JniSignatureAttribute("(I)Ljava/time/chrono/Era;", "public volatile")]
	public Dova.JDK.java.time.chrono.Era eraOf_0(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Era>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/chrono/JapaneseEra;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseEra eraOf_1(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseEra>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoLocalDateTime;", "public")]
	public Dova.JDK.java.time.chrono.ChronoLocalDateTime localDateTime(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String getCalendarType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateEpochDay_0(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(J)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateEpochDay_1(long arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate resolveYearOfEra(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.format.ResolverStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;ILjava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "private")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate resolveYMD(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.time.format.ResolverStyle arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;ILjava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "private")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate resolveYD(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1, Dova.JDK.java.util.Map arg2, Dova.JDK.java.time.format.ResolverStyle arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateNow_0(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Clock;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateNow_1(Dova.JDK.java.time.Clock arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateNow_0(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateNow_1(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateNow_0()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateNow_1()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Era;I)I", "public")]
	public int prolepticYear(Dova.JDK.java.time.chrono.Era arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Era;II)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateYearDay_0(Dova.JDK.java.time.chrono.Era arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Era;II)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateYearDay_1(Dova.JDK.java.time.chrono.Era arg0, int arg1, int arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate dateYearDay_0(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(II)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate dateYearDay_1(int arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/JapaneseDate;", "public")]
	public Dova.JDK.java.time.chrono.JapaneseDate resolveDate_0(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.format.ResolverStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Map;Ljava/time/format/ResolverStyle;)Ljava/time/chrono/ChronoLocalDate;", "public volatile")]
	public Dova.JDK.java.time.chrono.ChronoLocalDate resolveDate_1(Dova.JDK.java.util.Map arg0, Dova.JDK.java.time.format.ResolverStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/time/chrono/ChronoZonedDateTime;", "public")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime zonedDateTime(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/Instant;Ljava/time/ZoneId;)Ljava/time/chrono/ChronoZonedDateTime;", "public")]
	public Dova.JDK.java.time.chrono.ChronoZonedDateTime zonedDateTime(Dova.JDK.java.time.Instant arg0, Dova.JDK.java.time.ZoneId arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoZonedDateTime>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/JapaneseEra;", "")]
	public Dova.JDK.java.time.chrono.JapaneseEra getCurrentEra()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[36]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.JapaneseEra>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/JapaneseEra;I)I", "private")]
	public int prolepticYearLenient(Dova.JDK.java.time.chrono.JapaneseEra arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[37], arg0, arg1);
		return ret;
	}
}
