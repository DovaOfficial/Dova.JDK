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

namespace Dova.JDK.java.time.format;

[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public final")]
public partial class DateTimeFormatter
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DateTimeFormatter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printerParser", "Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "locale", "Ljava/util/Locale;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "decimalStyle", "Ljava/time/format/DecimalStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolverStyle", "Ljava/time/format/ResolverStyle;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "resolverFields", "Ljava/util/Set;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chrono", "Ljava/time/chrono/Chronology;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "zone", "Ljava/time/ZoneId;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_LOCAL_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_OFFSET_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_LOCAL_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_OFFSET_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_LOCAL_DATE_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_OFFSET_DATE_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_ZONED_DATE_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_DATE_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_ORDINAL_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_WEEK_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "ISO_INSTANT", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASIC_ISO_DATE", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RFC_1123_DATE_TIME", "Ljava/time/format/DateTimeFormatter;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSED_EXCESS_DAYS", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PARSED_LEAP_SECOND", "Ljava/time/temporal/TemporalQuery;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;Ljava/util/Locale;Ljava/time/format/DecimalStyle;Ljava/time/format/ResolverStyle;Ljava/util/Set;Ljava/time/chrono/Chronology;Ljava/time/ZoneId;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/temporal/TemporalAccessor;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/lang/CharSequence;)Ljava/time/temporal/TemporalAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getZone", "()Ljava/time/ZoneId;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withZone", "(Ljava/time/ZoneId;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronology", "()Ljava/time/chrono/Chronology;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatTo", "(Ljava/time/temporal/TemporalAccessor;Ljava/lang/Appendable;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseResolved0", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createError", "(Ljava/lang/CharSequence;Ljava/lang/RuntimeException;)Ljava/time/format/DateTimeParseException;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseUnresolved0", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/format/DateTimeParseContext;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPattern", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofPattern", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocalizedDate", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocalizedTime", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocalizedDateTime", "(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocalizedDateTime", "(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parsedExcessDays", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "parsedLeapSecond", "()Ljava/time/temporal/TemporalQuery;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocale", "()Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withLocale", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "localizedBy", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecimalStyle", "()Ljava/time/format/DecimalStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withDecimalStyle", "(Ljava/time/format/DecimalStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withChronology", "(Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolverStyle", "()Ljava/time/format/ResolverStyle;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withResolverStyle", "(Ljava/time/format/ResolverStyle;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getResolverFields", "()Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withResolverFields", "([Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withResolverFields", "(Ljava/util/Set;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseBest", "(Ljava/lang/CharSequence;[Ljava/time/temporal/TemporalQuery;)Ljava/time/temporal/TemporalAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseUnresolved", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toPrinterParser", "(Z)Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormat", "()Ljava/text/Format;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormat", "(Ljava/time/temporal/TemporalQuery;)Ljava/text/Format;"));
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;", "private final")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser printerParser_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Locale;", "private final")]
	public Dova.JDK.java.util.Locale locale_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DecimalStyle;", "private final")]
	public Dova.JDK.java.time.format.DecimalStyle decimalStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DecimalStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/ResolverStyle;", "private final")]
	public Dova.JDK.java.time.format.ResolverStyle resolverStyle_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.ResolverStyle>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set resolverFields_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/chrono/Chronology;", "private final")]
	public Dova.JDK.java.time.chrono.Chronology chrono_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/ZoneId;", "private final")]
	public Dova.JDK.java.time.ZoneId zone_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneId>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_LOCAL_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_OFFSET_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_LOCAL_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_OFFSET_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_LOCAL_DATE_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_OFFSET_DATE_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_ZONED_DATE_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_DATE_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[16]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[16], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_ORDINAL_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[17]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[17], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_WEEK_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[18]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[18], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ISO_INSTANT_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[19]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[19], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter BASIC_ISO_DATE_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[20]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[20], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "public static final")]
	public static Dova.JDK.java.time.format.DateTimeFormatter RFC_1123_DATE_TIME_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[21]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[21], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "private static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery PARSED_EXCESS_DAYS_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[22]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[22], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "private static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery PARSED_LEAP_SECOND_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[23]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[23], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DateTimeFormatter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;Ljava/util/Locale;Ljava/time/format/DecimalStyle;Ljava/time/format/ResolverStyle;Ljava/util/Set;Ljava/time/chrono/Chronology;Ljava/time/ZoneId;)V", "")]
	public DateTimeFormatter(Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser arg0, Dova.JDK.java.util.Locale arg1, Dova.JDK.java.time.format.DecimalStyle arg2, Dova.JDK.java.time.format.ResolverStyle arg3, Dova.JDK.java.util.Set arg4, Dova.JDK.java.time.chrono.Chronology arg5, Dova.JDK.java.time.ZoneId arg6) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4, arg5, arg6))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String toString()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;)Ljava/lang/String;", "public")]
	public Dova.JDK.java.lang.String format(Dova.JDK.java.time.temporal.TemporalAccessor arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;", "public")]
	public Dova.JDK.java.time.temporal.TemporalAccessor parse(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.text.ParsePosition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/time/temporal/TemporalQuery;)Ljava/lang/Object;", "public")]
	public Dova.JDK.java.lang.Object parse(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.time.temporal.TemporalQuery arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;)Ljava/time/temporal/TemporalAccessor;", "public")]
	public Dova.JDK.java.time.temporal.TemporalAccessor parse(Dova.JDK.java.lang.CharSequence arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/ZoneId;", "public")]
	public Dova.JDK.java.time.ZoneId getZone()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.ZoneId>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/ZoneId;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withZone(Dova.JDK.java.time.ZoneId arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/chrono/Chronology;", "public")]
	public Dova.JDK.java.time.chrono.Chronology getChronology()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.Chronology>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalAccessor;Ljava/lang/Appendable;)V", "public")]
	public void formatTo(Dova.JDK.java.time.temporal.TemporalAccessor arg0, Dova.JDK.java.lang.Appendable arg1)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;", "private")]
	public Dova.JDK.java.time.temporal.TemporalAccessor parseResolved0(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.text.ParsePosition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/lang/RuntimeException;)Ljava/time/format/DateTimeParseException;", "private")]
	public Dova.JDK.java.time.format.DateTimeParseException createError(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.lang.RuntimeException arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeParseException>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/format/DateTimeParseContext;", "private")]
	public Dova.JDK.java.time.format.DateTimeParseContext parseUnresolved0(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.text.ParsePosition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeParseContext>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofPattern(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofPattern(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[13], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofLocalizedDate(Dova.JDK.java.time.format.FormatStyle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofLocalizedTime(Dova.JDK.java.time.format.FormatStyle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofLocalizedDateTime(Dova.JDK.java.time.format.FormatStyle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatter;", "public static")]
	public static Dova.JDK.java.time.format.DateTimeFormatter ofLocalizedDateTime(Dova.JDK.java.time.format.FormatStyle arg0, Dova.JDK.java.time.format.FormatStyle arg1)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[17], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery parsedExcessDays()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/temporal/TemporalQuery;", "public static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery parsedLeapSecond()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Locale;", "public")]
	public Dova.JDK.java.util.Locale getLocale()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withLocale(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter localizedBy(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DecimalStyle;", "public")]
	public Dova.JDK.java.time.format.DecimalStyle getDecimalStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DecimalStyle>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/DecimalStyle;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withDecimalStyle(Dova.JDK.java.time.format.DecimalStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withChronology(Dova.JDK.java.time.chrono.Chronology arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/ResolverStyle;", "public")]
	public Dova.JDK.java.time.format.ResolverStyle getResolverStyle()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.ResolverStyle>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/ResolverStyle;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withResolverStyle(Dova.JDK.java.time.format.ResolverStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getResolverFields()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("([Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatter;", "public transient")]
	public Dova.JDK.java.time.format.DateTimeFormatter withResolverFields(JavaArray<Dova.JDK.java.time.temporal.TemporalField> arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Set;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter withResolverFields(Dova.JDK.java.util.Set arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;[Ljava/time/temporal/TemporalQuery;)Ljava/time/temporal/TemporalAccessor;", "public transient")]
	public Dova.JDK.java.time.temporal.TemporalAccessor parseBest(Dova.JDK.java.lang.CharSequence arg0, JavaArray<Dova.JDK.java.time.temporal.TemporalQuery> arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[31], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/temporal/TemporalAccessor;", "public")]
	public Dova.JDK.java.time.temporal.TemporalAccessor parseUnresolved(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.text.ParsePosition arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[32], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalAccessor>(ret);
	}

	[JniSignatureAttribute("(Z)Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;", "")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser toPrinterParser(bool arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/Format;", "public")]
	public Dova.JDK.java.text.Format toFormat()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.Format>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;)Ljava/text/Format;", "public")]
	public Dova.JDK.java.text.Format toFormat(Dova.JDK.java.time.temporal.TemporalQuery arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.Format>(ret);
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter$ClassicFormat;", "static")]
	public partial class ClassicFormat
		: Dova.JDK.java.text.Format
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ClassicFormat()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatter$ClassicFormat;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "formatter", "Ljava/time/format/DateTimeFormatter;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parseType", "Ljava/time/temporal/TemporalQuery;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/DateTimeFormatter;Ljava/time/temporal/TemporalQuery;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseObject", "(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseObject", "(Ljava/lang/String;)Ljava/lang/Object;"));
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatter;", "private final")]
		public Dova.JDK.java.time.format.DateTimeFormatter formatter_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalQuery parseType_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ClassicFormat(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatter;Ljava/time/temporal/TemporalQuery;)V", "public")]
		public ClassicFormat(Dova.JDK.java.time.format.DateTimeFormatter arg0, Dova.JDK.java.time.temporal.TemporalQuery arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatter$ClassicFormat;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/Object;Ljava/lang/StringBuffer;Ljava/text/FieldPosition;)Ljava/lang/StringBuffer;", "public")]
		public Dova.JDK.java.lang.StringBuffer format(Dova.JDK.java.lang.Object arg0, Dova.JDK.java.lang.StringBuffer arg1, Dova.JDK.java.text.FieldPosition arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuffer>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/text/ParsePosition;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parseObject(Dova.JDK.java.lang.String arg0, Dova.JDK.java.text.ParsePosition arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/Object;", "public")]
		public Dova.JDK.java.lang.Object parseObject(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
		}
	}
}
