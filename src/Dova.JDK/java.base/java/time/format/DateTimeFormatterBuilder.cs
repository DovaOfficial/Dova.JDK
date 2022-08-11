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

[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder;", "public final")]
public partial class DateTimeFormatterBuilder
	: Dova.JDK.java.lang.Object
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DateTimeFormatterBuilder()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "QUERY_REGION_ONLY", "Ljava/time/temporal/TemporalQuery;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "active", "Ljava/time/format/DateTimeFormatterBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "parent", "Ljava/time/format/DateTimeFormatterBuilder;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printerParsers", "Ljava/util/List;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optional", "Z"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padNextWidth", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padNextChar", "C"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "valueParserIndex", "I"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FIELD_MAP", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/DateTimeFormatterBuilder;Z)V"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "append", "(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendZoneText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendZoneText", "(Ljava/time/format/TextStyle;Ljava/util/Set;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormatter", "(Ljava/util/Locale;Ljava/time/format/ResolverStyle;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormatter", "()Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormatter", "(Ljava/time/format/ResolverStyle;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toFormatter", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendChronologyText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendPattern", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLocalized", "(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValue", "(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValue", "(Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValue", "(Ljava/time/temporal/TemporalField;I)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValue", "(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLiteral", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLiteral", "(C)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCaseInsensitive", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendOffsetId", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "optionalStart", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendFraction", "(Ljava/time/temporal/TemporalField;IIZ)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseLenient", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseStrict", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseCaseSensitive", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendZoneRegionId", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendInstant", "(I)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendInstant", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendOffset", "(Ljava/lang/String;Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendText", "(Ljava/time/temporal/TemporalField;Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendText", "(Ljava/time/temporal/TemporalField;Ljava/util/Map;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendText", "(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "optionalEnd", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "convertStyle", "(Ljava/time/format/FormatStyle;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendInternal", "(Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;)I"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parsePattern", "(Ljava/lang/String;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "padNext", "(I)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "padNext", "(IC)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseField", "(CILjava/time/temporal/TemporalField;)V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendZoneId", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendGenericZoneText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendGenericZoneText", "(Ljava/time/format/TextStyle;Ljava/util/Set;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendLocalizedOffset", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendDayPeriodText", "(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValueReduced", "(Ljava/time/temporal/TemporalField;III)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendValueReduced", "(Ljava/time/temporal/TemporalField;IILjava/time/chrono/ChronoLocalDate;)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getLocalizedDateTimePattern", "(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;Ljava/time/chrono/Chronology;Ljava/util/Locale;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseDefaulting", "(Ljava/time/temporal/TemporalField;J)Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendZoneOrOffsetId", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendChronologyId", "()Ljava/time/format/DateTimeFormatterBuilder;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "appendOptional", "(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;"));
	}

	[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "private static final")]
	public static Dova.JDK.java.time.temporal.TemporalQuery QUERY_REGION_ONLY_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder;", "private")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder active_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder;", "private final")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parent_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/List;", "private final")]
	public Dova.JDK.java.util.List printerParsers_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Z", "private final")]
	public bool optional_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[4]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[4], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int padNextWidth_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
		}
	}

	[JniSignatureAttribute("C", "private")]
	public char padNextChar_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[6]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[6], value);
		}
	}

	[JniSignatureAttribute("I", "private")]
	public int valueParserIndex_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[7]);
			return ret;
		}
		set
		{
			DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[7], value);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map FIELD_MAP_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DateTimeFormatterBuilder(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatterBuilder;Z)V", "private")]
	public DateTimeFormatterBuilder(Dova.JDK.java.time.format.DateTimeFormatterBuilder arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public DateTimeFormatterBuilder() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1]))
	{
	}

	public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder append(Dova.JDK.java.time.format.DateTimeFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendZoneText(Dova.JDK.java.time.format.TextStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;Ljava/util/Set;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendZoneText(Dova.JDK.java.time.format.TextStyle arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/time/format/ResolverStyle;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;", "private")]
	public Dova.JDK.java.time.format.DateTimeFormatter toFormatter(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.time.format.ResolverStyle arg1, Dova.JDK.java.time.chrono.Chronology arg2)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter toFormatter()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/ResolverStyle;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;", "")]
	public Dova.JDK.java.time.format.DateTimeFormatter toFormatter(Dova.JDK.java.time.format.ResolverStyle arg0, Dova.JDK.java.time.chrono.Chronology arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatter;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatter toFormatter(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendChronologyText(Dova.JDK.java.time.format.TextStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendPattern(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendLocalized(Dova.JDK.java.time.format.FormatStyle arg0, Dova.JDK.java.time.format.FormatStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValue(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;)Ljava/time/format/DateTimeFormatterBuilder;", "private")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValue(Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;I)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValue(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValue(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, Dova.JDK.java.time.format.SignStyle arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendLiteral(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(C)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendLiteral(char arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parseCaseInsensitive()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendOffsetId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder optionalStart()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[18]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IIZ)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendFraction(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, bool arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parseLenient()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parseStrict()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[21]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parseCaseSensitive()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendZoneRegionId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendInstant(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[24], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendInstant()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[25]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendOffset(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[26], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendText(Dova.JDK.java.time.temporal.TemporalField arg0, Dova.JDK.java.time.format.TextStyle arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[27], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;Ljava/util/Map;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendText(Dova.JDK.java.time.temporal.TemporalField arg0, Dova.JDK.java.util.Map arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[28], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendText(Dova.JDK.java.time.temporal.TemporalField arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[29], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder optionalEnd()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[30]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;)I", "private static")]
	public static int convertStyle(Dova.JDK.java.time.format.FormatStyle arg0)
	{
		var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[31], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;)I", "private")]
	public int appendInternal(Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser arg0)
	{
		var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[32], arg0);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)V", "private")]
	public void parsePattern(Dova.JDK.java.lang.String arg0)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[33], arg0);
	}

	[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder padNext(int arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[34], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(IC)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder padNext(int arg0, char arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[35], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(CILjava/time/temporal/TemporalField;)V", "private")]
	public void parseField(char arg0, int arg1, Dova.JDK.java.time.temporal.TemporalField arg2)
	{
		DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[36], arg0, arg1, arg2);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendZoneId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[37]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendGenericZoneText(Dova.JDK.java.time.format.TextStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[38], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;Ljava/util/Set;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendGenericZoneText(Dova.JDK.java.time.format.TextStyle arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[39], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendLocalizedOffset(Dova.JDK.java.time.format.TextStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[40], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/TextStyle;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendDayPeriodText(Dova.JDK.java.time.format.TextStyle arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[41], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;III)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValueReduced(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, int arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[42], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IILjava/time/chrono/ChronoLocalDate;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendValueReduced(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, Dova.JDK.java.time.chrono.ChronoLocalDate arg3)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[43], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;Ljava/time/chrono/Chronology;Ljava/util/Locale;)Ljava/lang/String;", "public static")]
	public static Dova.JDK.java.lang.String getLocalizedDateTimePattern(Dova.JDK.java.time.format.FormatStyle arg0, Dova.JDK.java.time.format.FormatStyle arg1, Dova.JDK.java.time.chrono.Chronology arg2, Dova.JDK.java.util.Locale arg3)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[44], arg0, arg1, arg2, arg3);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder parseDefaulting(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[45], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendZoneOrOffsetId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[46]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendChronologyId()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[47]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatter;)Ljava/time/format/DateTimeFormatterBuilder;", "public")]
	public Dova.JDK.java.time.format.DateTimeFormatterBuilder appendOptional(Dova.JDK.java.time.format.DateTimeFormatter arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[48], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder>(ret);
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "static final")]
	public partial class SettingsParser
		: Dova.JDK.java.lang.Enum
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static SettingsParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SENSITIVE", "Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSENSITIVE", "Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STRICT", "Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "LENIENT", "Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "$VALUES", "[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "values", "()[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "valueOf", "(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "$values", "()[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;"));
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser SENSITIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser INSENSITIVE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser STRICT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser LENIENT_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "private static final")]
		public static JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser> VALUES_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public SettingsParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;I)V", "private")]
		public SettingsParser(Dova.JDK.java.lang.String arg0, int arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("()[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static")]
		public static JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser> values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "public static")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser valueOf(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()[Ljava/time/format/DateTimeFormatterBuilder$SettingsParser;", "private static")]
		public static JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser> _values()
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.SettingsParser>>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;", "abstract static interface")]
	public partial interface DateTimePrinterParser
		: IJavaObject
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DateTimePrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public abstract")]
		bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public abstract")]
		int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$DefaultValueParser;", "static")]
	public partial class DefaultValueParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DefaultValueParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$DefaultValueParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/time/temporal/TemporalField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;J)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalField field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DefaultValueParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;J)V", "")]
		public DefaultValueParser(Dova.JDK.java.time.temporal.TemporalField arg0, long arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$DefaultValueParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "static")]
	public partial class NumberPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NumberPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "EXCEED_POINTS", "[J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/time/temporal/TemporalField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minWidth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "maxWidth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "signStyle", "Ljava/time/format/SignStyle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "subsequentWidth", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/time/format/DateTimePrintContext;J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/time/format/DateTimeParseContext;JII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringSize", "(J)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth", "(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedWidth", "(Ljava/time/format/DateTimeParseContext;)Z"));
		}

		[JniSignatureAttribute("[J", "static final")]
		public static JavaArray<long> EXCEED_POINTS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<long>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "final")]
		public Dova.JDK.java.time.temporal.TemporalField field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int minWidth_Property
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

		[JniSignatureAttribute("I", "final")]
		public int maxWidth_Property
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

		[JniSignatureAttribute("Ljava/time/format/SignStyle;", "private final")]
		public Dova.JDK.java.time.format.SignStyle signStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.SignStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "final")]
		public int subsequentWidth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NumberPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;)V", "")]
		public NumberPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, Dova.JDK.java.time.format.SignStyle arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IILjava/time/format/SignStyle;I)V", "protected")]
		public NumberPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, Dova.JDK.java.time.format.SignStyle arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;J)J", "")]
		public long getValue(Dova.JDK.java.time.format.DateTimePrintContext arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;JII)I", "")]
		public int setValue(Dova.JDK.java.time.format.DateTimeParseContext arg0, long arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(J)I", "private static")]
		public static int stringSize(long arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withSubsequentWidth(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withFixedWidth()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Z", "")]
		public bool isFixedWidth(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;", "static final")]
	public partial class ReducedPrinterParser
		: Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ReducedPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "BASE_DATE", "Ljava/time/LocalDate;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseValue", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "baseDate", "Ljava/time/chrono/ChronoLocalDate;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IIILjava/time/chrono/ChronoLocalDate;)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IIILjava/time/chrono/ChronoLocalDate;I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getValue", "(Ljava/time/format/DateTimePrintContext;J)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "setValue", "(Ljava/time/format/DateTimeParseContext;JII)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_0", "(I)Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_1", "(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_0", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_1", "()Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedWidth", "(Ljava/time/format/DateTimeParseContext;)Z"));
		}

		[JniSignatureAttribute("Ljava/time/LocalDate;", "static final")]
		public static Dova.JDK.java.time.LocalDate BASE_DATE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.LocalDate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int baseValue_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("Ljava/time/chrono/ChronoLocalDate;", "private final")]
		public Dova.JDK.java.time.chrono.ChronoLocalDate baseDate_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.chrono.ChronoLocalDate>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ReducedPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IIILjava/time/chrono/ChronoLocalDate;)V", "")]
		public ReducedPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, int arg3, Dova.JDK.java.time.chrono.ChronoLocalDate arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3, arg4))
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IIILjava/time/chrono/ChronoLocalDate;I)V", "private")]
		public ReducedPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, int arg3, Dova.JDK.java.time.chrono.ChronoLocalDate arg4, int arg5) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4, arg5))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;J)J", "")]
		public long getValue(Dova.JDK.java.time.format.DateTimePrintContext arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;JII)I", "")]
		public int setValue(Dova.JDK.java.time.format.DateTimeParseContext arg0, long arg1, int arg2, int arg3)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2, arg3);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.ReducedPrinterParser withSubsequentWidth_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.ReducedPrinterParser>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withSubsequentWidth_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withFixedWidth_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$ReducedPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.ReducedPrinterParser withFixedWidth_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.ReducedPrinterParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Z", "")]
		public bool isFixedWidth(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;", "static final")]
	public partial class NanosPrinterParser
		: Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NanosPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "decimalPoint", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "TENS", "[I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(IIZI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "stringSize", "(I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_0", "(I)Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_1", "(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_0", "()Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_1", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedWidth", "(Ljava/time/format/DateTimeParseContext;)Z"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool decimalPoint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("[I", "private static final")]
		public static JavaArray<int> TENS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<JavaArray<int>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NanosPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(IIZ)V", "")]
		public NanosPrinterParser(int arg0, int arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		[JniSignatureAttribute("(IIZI)V", "")]
		public NanosPrinterParser(int arg0, int arg1, bool arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(I)I", "private static")]
		public static int stringSize(int arg0)
		{
			var ret = DovaVM.Runtime.CallStaticIntMethodA(ClassRefPtr, MethodPtrs[2], arg0);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NanosPrinterParser withSubsequentWidth_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NanosPrinterParser>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withSubsequentWidth_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NanosPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NanosPrinterParser withFixedWidth_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NanosPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withFixedWidth_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Z", "")]
		public bool isFixedWidth(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;", "static final")]
	public partial class FractionPrinterParser
		: Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static FractionPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "decimalPoint", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "minBD", "Ljava/math/BigDecimal;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "rangeBD", "Ljava/math/BigDecimal;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IIZ)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;IIZI)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_0", "(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_1", "(I)Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_0", "()Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_1", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isFixedWidth", "(Ljava/time/format/DateTimeParseContext;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertToFraction", "(J)Ljava/math/BigDecimal;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "convertFromFraction", "(Ljava/math/BigDecimal;)J"));
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool decimalPoint_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("Ljava/math/BigDecimal;", "private final")]
		public Dova.JDK.java.math.BigDecimal minBD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/math/BigDecimal;", "private final")]
		public Dova.JDK.java.math.BigDecimal rangeBD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public FractionPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IIZ)V", "")]
		public FractionPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, bool arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;IIZI)V", "")]
		public FractionPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, int arg1, int arg2, bool arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withSubsequentWidth_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.FractionPrinterParser withSubsequentWidth_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.FractionPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$FractionPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.FractionPrinterParser withFixedWidth_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.FractionPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withFixedWidth_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Z", "")]
		public bool isFixedWidth(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[7], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)Ljava/math/BigDecimal;", "private")]
		public Dova.JDK.java.math.BigDecimal convertToFraction(long arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.math.BigDecimal>(ret);
		}

		[JniSignatureAttribute("(Ljava/math/BigDecimal;)J", "private")]
		public long convertFromFraction(Dova.JDK.java.math.BigDecimal arg0)
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$TextPrinterParser;", "static final")]
	public partial class TextPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static TextPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$TextPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "field", "Ljava/time/temporal/TemporalField;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textStyle", "Ljava/time/format/TextStyle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "provider", "Ljava/time/format/DateTimeTextProvider;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberPrinterParser", "Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalField;Ljava/time/format/TextStyle;Ljava/time/format/DateTimeTextProvider;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "numberPrinterParser", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalField;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalField field_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalField>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/TextStyle;", "private final")]
		public Dova.JDK.java.time.format.TextStyle textStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.TextStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeTextProvider;", "private final")]
		public Dova.JDK.java.time.format.DateTimeTextProvider provider_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeTextProvider>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "private volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser numberPrinterParser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public TextPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalField;Ljava/time/format/TextStyle;Ljava/time/format/DateTimeTextProvider;)V", "")]
		public TextPrinterParser(Dova.JDK.java.time.temporal.TemporalField arg0, Dova.JDK.java.time.format.TextStyle arg1, Dova.JDK.java.time.format.DateTimeTextProvider arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$TextPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "private")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser numberPrinterParser()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$InstantPrinterParser;", "static final")]
	public partial class InstantPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static InstantPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$InstantPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDS_PER_10000_YEARS", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "SECONDS_0000_TO_1970", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "fractionalDigits", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("J", "private static final")]
		public static long SECONDS_PER_10000_YEARS_Property
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

		[JniSignatureAttribute("J", "private static final")]
		public static long SECONDS_0000_TO_1970_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int fractionalDigits_Property
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

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public InstantPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(I)V", "")]
		public InstantPrinterParser(int arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$InstantPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;", "static final")]
	public partial class OffsetIdPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static OffsetIdPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "PATTERNS", "[Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE_ID_Z", "Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "INSTANCE_ID_ZERO", "Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "noOffsetText", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "checkPattern", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isPaddedHour", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatZeroPad", "(ZILjava/lang/StringBuilder;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isColon", "()Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseHour", "(Ljava/lang/CharSequence;Z[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseMinute", "(Ljava/lang/CharSequence;ZZ[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseSecond", "(Ljava/lang/CharSequence;ZZ[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseOptionalMinuteSecond", "(Ljava/lang/CharSequence;Z[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseVariableWidthDigits", "(Ljava/lang/CharSequence;II[I)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseDigits", "(Ljava/lang/CharSequence;ZI[I)Z"));
		}

		[JniSignatureAttribute("[Ljava/lang/String;", "static final")]
		public static JavaArray<Dova.JDK.java.lang.String> PATTERNS_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.lang.String>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;", "static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.OffsetIdPrinterParser INSTANCE_ID_Z_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.OffsetIdPrinterParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;", "static final")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.OffsetIdPrinterParser INSTANCE_ID_ZERO_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.OffsetIdPrinterParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String noOffsetText_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int type_Property
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

		[JniSignatureAttribute("I", "private final")]
		public int style_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public OffsetIdPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;)V", "")]
		public OffsetIdPrinterParser(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "private")]
		public int checkPattern(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return ret;
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isPaddedHour()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("(ZILjava/lang/StringBuilder;)V", "private")]
		public void formatZeroPad(bool arg0, int arg1, Dova.JDK.java.lang.StringBuilder arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("()Z", "private")]
		public bool isColon()
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[6]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;Z[I)V", "private")]
		public void parseHour(Dova.JDK.java.lang.CharSequence arg0, bool arg1, JavaArray<int> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[7], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;ZZ[I)V", "private")]
		public void parseMinute(Dova.JDK.java.lang.CharSequence arg0, bool arg1, bool arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[8], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;ZZ[I)V", "private")]
		public void parseSecond(Dova.JDK.java.lang.CharSequence arg0, bool arg1, bool arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;Z[I)V", "private")]
		public void parseOptionalMinuteSecond(Dova.JDK.java.lang.CharSequence arg0, bool arg1, JavaArray<int> arg2)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[10], arg0, arg1, arg2);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II[I)V", "private")]
		public void parseVariableWidthDigits(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2, JavaArray<int> arg3)
		{
			DovaVM.Runtime.CallVoidMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2, arg3);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;ZI[I)Z", "private")]
		public bool parseDigits(Dova.JDK.java.lang.CharSequence arg0, bool arg1, int arg2, JavaArray<int> arg3)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[12], arg0, arg1, arg2, arg3);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$LocalizedOffsetIdPrinterParser;", "static final")]
	public partial class LocalizedOffsetIdPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalizedOffsetIdPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$LocalizedOffsetIdPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "style", "Ljava/time/format/TextStyle;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/TextStyle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDigit", "(Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "appendHMS", "(Ljava/lang/StringBuilder;I)Ljava/lang/StringBuilder;"));
		}

		[JniSignatureAttribute("Ljava/time/format/TextStyle;", "private final")]
		public Dova.JDK.java.time.format.TextStyle style_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.TextStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalizedOffsetIdPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/TextStyle;)V", "")]
		public LocalizedOffsetIdPrinterParser(Dova.JDK.java.time.format.TextStyle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$LocalizedOffsetIdPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;I)I", "")]
		public int getDigit(Dova.JDK.java.lang.CharSequence arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/StringBuilder;I)Ljava/lang/StringBuilder;", "private static")]
		public static Dova.JDK.java.lang.StringBuilder appendHMS(Dova.JDK.java.lang.StringBuilder arg0, int arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[4], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.StringBuilder>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$ZoneIdPrinterParser;", "static")]
	public partial class ZoneIdPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ZoneIdPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$ZoneIdPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "query", "Ljava/time/temporal/TemporalQuery;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "description", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cachedPrefixTree", "Ljava/util/Map$Entry;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cachedPrefixTreeCI", "Ljava/util/Map$Entry;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/temporal/TemporalQuery;Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parseOffsetBased", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;IILjava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
		}

		[JniSignatureAttribute("Ljava/time/temporal/TemporalQuery;", "private final")]
		public Dova.JDK.java.time.temporal.TemporalQuery query_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.temporal.TemporalQuery>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String description_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map$Entry;", "private static volatile")]
		public static Dova.JDK.java.util.Map.Entry cachedPrefixTree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map$Entry;", "private static volatile")]
		public static Dova.JDK.java.util.Map.Entry cachedPrefixTreeCI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map.Entry>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ZoneIdPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/temporal/TemporalQuery;Ljava/lang/String;)V", "")]
		public ZoneIdPrinterParser(Dova.JDK.java.time.temporal.TemporalQuery arg0, Dova.JDK.java.lang.String arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$ZoneIdPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;IILjava/time/format/DateTimeFormatterBuilder$OffsetIdPrinterParser;)I", "private")]
		public int parseOffsetBased(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2, int arg3, Dova.JDK.java.time.format.DateTimeFormatterBuilder.OffsetIdPrinterParser arg4)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3, arg4);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree getTree(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$ZoneTextPrinterParser;", "static final")]
	public partial class ZoneTextPrinterParser
		: Dova.JDK.java.time.format.DateTimeFormatterBuilder.ZoneIdPrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ZoneTextPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$ZoneTextPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textStyle", "Ljava/time/format/TextStyle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "preferredZones", "Ljava/util/Set;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "isGeneric", "Z"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "UNDEFINED", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "STD", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DST", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "GENERIC", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "cache", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedTree", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "cachedTreeCI", "Ljava/util/Map;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/TextStyle;Ljava/util/Set;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDisplayName", "(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTree", "(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
		}

		[JniSignatureAttribute("Ljava/time/format/TextStyle;", "private final")]
		public Dova.JDK.java.time.format.TextStyle textStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.TextStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Set;", "private")]
		public Dova.JDK.java.util.Set preferredZones_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool isGeneric_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int UNDEFINED_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int STD_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int DST_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("I", "static final")]
		public static int GENERIC_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticIntField(ClassRefPtr, FieldPtrs[6]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetStaticIntField(ClassRefPtr, FieldPtrs[6], value);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map cache_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[7]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[7], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map cachedTree_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private final")]
		public Dova.JDK.java.util.Map cachedTreeCI_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ZoneTextPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/TextStyle;Ljava/util/Set;Z)V", "")]
		public ZoneTextPrinterParser(Dova.JDK.java.time.format.TextStyle arg0, Dova.JDK.java.util.Set arg1, bool arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$ZoneTextPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/String;ILjava/util/Locale;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getDisplayName(Dova.JDK.java.lang.String arg0, int arg1, Dova.JDK.java.util.Locale arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree getTree(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$ChronoPrinterParser;", "static final")]
	public partial class ChronoPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static ChronoPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$ChronoPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textStyle", "Ljava/time/format/TextStyle;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/TextStyle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getChronologyName", "(Ljava/time/chrono/Chronology;Ljava/util/Locale;)Ljava/lang/String;"));
		}

		[JniSignatureAttribute("Ljava/time/format/TextStyle;", "private final")]
		public Dova.JDK.java.time.format.TextStyle textStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.TextStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public ChronoPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/TextStyle;)V", "")]
		public ChronoPrinterParser(Dova.JDK.java.time.format.TextStyle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$ChronoPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/chrono/Chronology;Ljava/util/Locale;)Ljava/lang/String;", "private")]
		public Dova.JDK.java.lang.String getChronologyName(Dova.JDK.java.time.chrono.Chronology arg0, Dova.JDK.java.util.Locale arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$LocalizedPrinterParser;", "static final")]
	public partial class LocalizedPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static LocalizedPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$LocalizedPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "FORMATTER_CACHE", "Ljava/util/concurrent/ConcurrentMap;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dateStyle", "Ljava/time/format/FormatStyle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeStyle", "Ljava/time/format/FormatStyle;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "formatter", "(Ljava/util/Locale;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static final")]
		public static Dova.JDK.java.util.concurrent.ConcurrentMap FORMATTER_CACHE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/FormatStyle;", "private final")]
		public Dova.JDK.java.time.format.FormatStyle dateStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.FormatStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/FormatStyle;", "private final")]
		public Dova.JDK.java.time.format.FormatStyle timeStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.FormatStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public LocalizedPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/FormatStyle;Ljava/time/format/FormatStyle;)V", "")]
		public LocalizedPrinterParser(Dova.JDK.java.time.format.FormatStyle arg0, Dova.JDK.java.time.format.FormatStyle arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$LocalizedPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Locale;Ljava/time/chrono/Chronology;)Ljava/time/format/DateTimeFormatter;", "private")]
		public Dova.JDK.java.time.format.DateTimeFormatter formatter(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.time.chrono.Chronology arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatter>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$CharLiteralPrinterParser;", "static final")]
	public partial class CharLiteralPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CharLiteralPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$CharLiteralPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "literal", "C"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(C)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("C", "private final")]
		public char literal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CharLiteralPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(C)V", "")]
		public CharLiteralPrinterParser(char arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$CharLiteralPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$StringLiteralPrinterParser;", "static final")]
	public partial class StringLiteralPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static StringLiteralPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$StringLiteralPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "literal", "Ljava/lang/String;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "private final")]
		public Dova.JDK.java.lang.String literal_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public StringLiteralPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;)V", "")]
		public StringLiteralPrinterParser(Dova.JDK.java.lang.String arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$StringLiteralPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$DayPeriodPrinterParser;", "static final")]
	public partial class DayPeriodPrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DayPeriodPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$DayPeriodPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "textStyle", "Ljava/time/format/TextStyle;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYPERIOD_LOCALESTORE", "Ljava/util/concurrent/ConcurrentMap;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/TextStyle;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "findDayPeriodStore", "(Ljava/util/Locale;)Ljava/time/format/DateTimeTextProvider$LocaleStore;"));
		}

		[JniSignatureAttribute("Ljava/time/format/TextStyle;", "private final")]
		public Dova.JDK.java.time.format.TextStyle textStyle_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.TextStyle>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private static final")]
		public static Dova.JDK.java.util.concurrent.ConcurrentMap DAYPERIOD_LOCALESTORE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DayPeriodPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/TextStyle;)V", "")]
		public DayPeriodPrinterParser(Dova.JDK.java.time.format.TextStyle arg0) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$DayPeriodPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/format/DateTimeTextProvider$LocaleStore;", "private static")]
		public static Dova.JDK.java.time.format.DateTimeTextProvider.LocaleStore findDayPeriodStore(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeTextProvider.LocaleStore>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;", "static final")]
	public partial class CompositePrinterParser
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static CompositePrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printerParsers", "[Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "optional", "Z"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/util/List;Z)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "([Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;Z)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withOptional", "(Z)Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;"));
		}

		[JniSignatureAttribute("[Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;", "private final")]
		public JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser> printerParsers_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Z", "private final")]
		public bool optional_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetBooleanField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetBooleanField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public CompositePrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/util/List;Z)V", "")]
		public CompositePrinterParser(Dova.JDK.java.util.List arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1))
		{
		}

		[JniSignatureAttribute("([Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;Z)V", "")]
		public CompositePrinterParser(JavaArray<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser> arg0, bool arg1) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Z)Ljava/time/format/DateTimeFormatterBuilder$CompositePrinterParser;", "public")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser withOptional(bool arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.CompositePrinterParser>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;", "static final")]
	public partial class WeekBasedFieldPrinterParser
		: Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static WeekBasedFieldPrinterParser()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "chr", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "count", "I"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(CIII)V"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(CIIII)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "printerParser", "(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_0", "(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withSubsequentWidth_1", "(I)Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_0", "()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "withFixedWidth_1", "()Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;"));
		}

		[JniSignatureAttribute("C", "private")]
		public char chr_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[0]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[0], value);
			}
		}

		[JniSignatureAttribute("I", "private")]
		public int count_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public WeekBasedFieldPrinterParser(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(CIII)V", "")]
		public WeekBasedFieldPrinterParser(char arg0, int arg1, int arg2, int arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		[JniSignatureAttribute("(CIIII)V", "")]
		public WeekBasedFieldPrinterParser(char arg0, int arg1, int arg2, int arg3, int arg4) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[1], arg0, arg1, arg2, arg3, arg4))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;", "private")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser printerParser(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withSubsequentWidth_0(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("(I)Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.WeekBasedFieldPrinterParser withSubsequentWidth_1(int arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.WeekBasedFieldPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$NumberPrinterParser;", "volatile")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser withFixedWidth_0()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.NumberPrinterParser>(ret);
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$WeekBasedFieldPrinterParser;", "")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.WeekBasedFieldPrinterParser withFixedWidth_1()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.WeekBasedFieldPrinterParser>(ret);
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$PadPrinterParserDecorator;", "static final")]
	public partial class PadPrinterParserDecorator
		: Dova.JDK.java.lang.Object
		, Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PadPrinterParserDecorator()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$PadPrinterParserDecorator;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "printerParser", "Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padWidth", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "padChar", "C"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;IC)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "format", "(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "parse", "(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I"));
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;", "private final")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser printerParser_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "private final")]
		public int padWidth_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetIntField(CurrentRefPtr, FieldPtrs[1]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetIntField(CurrentRefPtr, FieldPtrs[1], value);
			}
		}

		[JniSignatureAttribute("C", "private final")]
		public char padChar_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[2]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[2], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PadPrinterParserDecorator(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeFormatterBuilder$DateTimePrinterParser;IC)V", "")]
		public PadPrinterParserDecorator(Dova.JDK.java.time.format.DateTimeFormatterBuilder.DateTimePrinterParser arg0, int arg1, char arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$PadPrinterParserDecorator;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()Ljava/lang/String;", "public")]
		public Dova.JDK.java.lang.String toString()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimePrintContext;Ljava/lang/StringBuilder;)Z", "public")]
		public bool format(Dova.JDK.java.time.format.DateTimePrintContext arg0, Dova.JDK.java.lang.StringBuilder arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;Ljava/lang/CharSequence;I)I", "public")]
		public int parse(Dova.JDK.java.time.format.DateTimeParseContext arg0, Dova.JDK.java.lang.CharSequence arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$DayPeriod;", "static final")]
	public partial class DayPeriod
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static DayPeriod()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$DayPeriod;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DAYPERIOD_CACHE", "Ljava/util/Map;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "DPCOMPARATOR", "Ljava/util/Comparator;"));
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "RULE", "Ljava/util/regex/Pattern;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "from", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "to", "J"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "index", "J"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(JJJ)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "equals", "(Ljava/lang/Object;)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toString", "()Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "mid", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "hashCode", "()I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getIndex", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "duration", "()J"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "ofLocale", "(Ljava/util/Locale;J)Ljava/time/format/DateTimeFormatterBuilder$DayPeriod;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getDayPeriodMap", "(Ljava/util/Locale;)Ljava/util/Map;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "mapToIndex", "(Ljava/lang/String;)J"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "includes", "(J)Z"));
		}

		[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
		public static Dova.JDK.java.util.Map DAYPERIOD_CACHE_Property
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

		[JniSignatureAttribute("Ljava/util/Comparator;", "private static final")]
		public static Dova.JDK.java.util.Comparator DPCOMPARATOR_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.Comparator>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/util/regex/Pattern;", "private static final")]
		public static Dova.JDK.java.util.regex.Pattern RULE_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.util.regex.Pattern>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long from_Property
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

		[JniSignatureAttribute("J", "private final")]
		public long to_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[4]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[4], value);
			}
		}

		[JniSignatureAttribute("J", "private final")]
		public long index_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetLongField(CurrentRefPtr, FieldPtrs[5]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetLongField(CurrentRefPtr, FieldPtrs[5], value);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public DayPeriod(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(JJJ)V", "private")]
		public DayPeriod(long arg0, long arg1, long arg2) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$DayPeriod;";
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

		[JniSignatureAttribute("()J", "")]
		public long mid()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[2]);
			return ret;
		}

		[JniSignatureAttribute("()I", "public")]
		public int hashCode()
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[3]);
			return ret;
		}

		[JniSignatureAttribute("()J", "")]
		public long getIndex()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[4]);
			return ret;
		}

		[JniSignatureAttribute("()J", "private")]
		public long duration()
		{
			var ret = DovaVM.Runtime.CallLongMethodA(CurrentRefPtr, MethodPtrs[5]);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/util/Locale;J)Ljava/time/format/DateTimeFormatterBuilder$DayPeriod;", "static")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.DayPeriod ofLocale(Dova.JDK.java.util.Locale arg0, long arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.DayPeriod>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/util/Map;", "static")]
		public static Dova.JDK.java.util.Map getDayPeriodMap(Dova.JDK.java.util.Locale arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)J", "static")]
		public static long mapToIndex(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallStaticLongMethodA(ClassRefPtr, MethodPtrs[8], arg0);
			return ret;
		}

		[JniSignatureAttribute("(J)Z", "")]
		public bool includes(long arg0)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0);
			return ret;
		}
	}

	[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "static")]
	public partial class PrefixTree
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static PrefixTree()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "key", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "value", "Ljava/lang/String;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "type", "I"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "c0", "C"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "child", "Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "sibling", "Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)V"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add", "(Ljava/lang/String;Ljava/lang/String;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "match", "(Ljava/lang/CharSequence;II)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newNode", "(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefixLength", "(Ljava/lang/String;)I"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEqual", "(CC)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTree", "(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "newTree", "(Ljava/util/Set;Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "toKey", "(Ljava/lang/String;)Ljava/lang/String;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "add0", "(Ljava/lang/String;Ljava/lang/String;I)Z"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "copyTree", "()Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
			MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefixOf", "(Ljava/lang/CharSequence;II)Z"));
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String key_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String value_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("I", "protected")]
		public int type_Property
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

		[JniSignatureAttribute("C", "protected")]
		public char c0_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetCharField(CurrentRefPtr, FieldPtrs[3]);
				return ret;
			}
			set
			{
				DovaVM.Runtime.SetCharField(CurrentRefPtr, FieldPtrs[3], value);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree child_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree sibling_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
			}
			set
			{
				DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public PrefixTree(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)V", "private")]
		public PrefixTree(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
		{
		}

		public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I)Z", "public")]
		public bool add(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;Ljava/text/ParsePosition;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "public")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree match(Dova.JDK.java.lang.CharSequence arg0, Dova.JDK.java.text.ParsePosition arg1)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "public")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree match(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1, arg2);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree newNode(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree arg3)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2, arg3);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)I", "private")]
		public int prefixLength(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallIntMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
			return ret;
		}

		[JniSignatureAttribute("(CC)Z", "protected")]
		public bool isEqual(char arg0, char arg1)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0, arg1);
			return ret;
		}

		[JniSignatureAttribute("(Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "public static")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree newTree(Dova.JDK.java.time.format.DateTimeParseContext arg0)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/util/Set;Ljava/time/format/DateTimeParseContext;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "public static")]
		public static Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree newTree(Dova.JDK.java.util.Set arg0, Dova.JDK.java.time.format.DateTimeParseContext arg1)
		{
			var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[7], arg0, arg1);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "protected")]
		public Dova.JDK.java.lang.String toKey(Dova.JDK.java.lang.String arg0)
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8], arg0);
			return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;I)Z", "private")]
		public bool add0(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("()Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "public")]
		public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree copyTree()
		{
			var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
		}

		[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Z", "protected")]
		public bool prefixOf(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
		{
			var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[11], arg0, arg1, arg2);
			return ret;
		}

		[JniSignatureAttribute("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree$CI;", "private static")]
		public partial class CI
			: Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree
		{
			public new static CSharpSystem.IntPtr ClassPtr { get; }
			public new static CSharpSystem.IntPtr ClassRefPtr { get; }

			private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
			private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

			static CI()
			{
				ClassPtr = DovaVM.Runtime.FindClass("Ljava/time/format/DateTimeFormatterBuilder$PrefixTree$CI;");
				ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
				ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)V"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newNode_0", "(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "newNode_1", "(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree$CI;"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isEqual", "(CC)Z"));
				MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "prefixOf", "(Ljava/lang/CharSequence;II)Z"));
			}

			[JniSignatureAttribute("(System.IntPtr)V", "public")]
			public CI(IntPtr currentRefPtr) : base(currentRefPtr)
			{
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)V", "private")]
			public CI(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree arg3) : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0], arg0, arg1, arg2, arg3))
			{
			}

			public override string GetJavaClassSignature() => "Ljava/time/format/DateTimeFormatterBuilder$PrefixTree$CI;";
			public override IntPtr GetJavaClassRaw() => ClassPtr;
			public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree;", "protected volatile")]
			public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree newNode_0(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree>(ret);
			}

			[JniSignatureAttribute("(Ljava/lang/String;Ljava/lang/String;ILjava/time/format/DateTimeFormatterBuilder$PrefixTree;)Ljava/time/format/DateTimeFormatterBuilder$PrefixTree$CI;", "protected")]
			public Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree.CI newNode_1(Dova.JDK.java.lang.String arg0, Dova.JDK.java.lang.String arg1, int arg2, Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree arg3)
			{
				var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2, arg3);
				return DovaInterfaceFactory.Get<Dova.JDK.java.time.format.DateTimeFormatterBuilder.PrefixTree.CI>(ret);
			}

			[JniSignatureAttribute("(CC)Z", "protected")]
			public bool isEqual(char arg0, char arg1)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[2], arg0, arg1);
				return ret;
			}

			[JniSignatureAttribute("(Ljava/lang/CharSequence;II)Z", "protected")]
			public bool prefixOf(Dova.JDK.java.lang.CharSequence arg0, int arg1, int arg2)
			{
				var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1, arg2);
				return ret;
			}
		}
	}
}
