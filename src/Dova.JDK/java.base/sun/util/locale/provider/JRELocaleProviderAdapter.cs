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

namespace Dova.JDK.sun.util.locale.provider;

[JniSignatureAttribute("Lsun/util/locale/provider/JRELocaleProviderAdapter;", "public")]
public partial class JRELocaleProviderAdapter
	: Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter
	, Dova.JDK.sun.util.locale.provider.ResourceBundleBasedAdapter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static JRELocaleProviderAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/JRELocaleProviderAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "langtagSets", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localeResourcesMap", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localeData", "Lsun/util/resources/LocaleData;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "breakIteratorProvider", "Ljava/text/spi/BreakIteratorProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "collatorProvider", "Ljava/text/spi/CollatorProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dateFormatProvider", "Ljava/text/spi/DateFormatProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "dateFormatSymbolsProvider", "Ljava/text/spi/DateFormatSymbolsProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "decimalFormatSymbolsProvider", "Ljava/text/spi/DecimalFormatSymbolsProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "numberFormatProvider", "Ljava/text/spi/NumberFormatProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "currencyNameProvider", "Ljava/util/spi/CurrencyNameProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "localeNameProvider", "Ljava/util/spi/LocaleNameProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "timeZoneNameProvider", "Ljava/util/spi/TimeZoneNameProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "calendarDataProvider", "Ljava/util/spi/CalendarDataProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "calendarNameProvider", "Ljava/util/spi/CalendarNameProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "calendarProvider", "Lsun/util/spi/CalendarProvider;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "javaTimeDateTimePatternProvider", "Lsun/text/spi/JavaTimeDateTimePatternProvider;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDateFormatProvider", "()Ljava/text/spi/DateFormatProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDateFormatSymbolsProvider", "()Ljava/text/spi/DateFormatSymbolsProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocaleData", "()Lsun/util/resources/LocaleData;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocaleResources", "(Ljava/util/Locale;)Lsun/util/locale/provider/LocaleResources;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getNumberFormatProvider", "()Ljava/text/spi/NumberFormatProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getDecimalFormatSymbolsProvider", "()Ljava/text/spi/DecimalFormatSymbolsProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getJavaTimeDateTimePatternProvider", "()Lsun/text/spi/JavaTimeDateTimePatternProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarProvider", "()Lsun/util/spi/CalendarProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLanguageTagSet", "(Ljava/lang/String;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdapterType", "()Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLanguageTagSet", "(Ljava/lang/String;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreakIteratorProvider", "()Ljava/text/spi/BreakIteratorProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDataProvider", "()Ljava/util/spi/CalendarDataProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarNameProvider", "()Ljava/util/spi/CalendarNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCollatorProvider", "()Ljava/text/spi/CollatorProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeZoneNameProvider", "()Ljava/util/spi/TimeZoneNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedProviderLocale", "(Ljava/util/Locale;Ljava/util/Set;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCurrencyNameProvider", "()Ljava/util/spi/CurrencyNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocaleNameProvider", "()Ljava/util/spi/LocaleNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createSupportedLocaleString", "(Ljava/lang/String;)Ljava/lang/String;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getLocaleServiceProvider", "(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "createAvailableLocales", "()[Ljava/util/Locale;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private final")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap langtagSets_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private final")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap localeResourcesMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/resources/LocaleData;", "private volatile")]
	public Dova.JDK.sun.util.resources.LocaleData localeData_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.resources.LocaleData>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/BreakIteratorProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.BreakIteratorProvider breakIteratorProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.BreakIteratorProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/CollatorProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.CollatorProvider collatorProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.CollatorProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/DateFormatProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.DateFormatProvider dateFormatProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[5]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[5], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/DateFormatSymbolsProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.DateFormatSymbolsProvider dateFormatSymbolsProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[6]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatSymbolsProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[6], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/DecimalFormatSymbolsProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider decimalFormatSymbolsProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[7]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[7], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/text/spi/NumberFormatProvider;", "private volatile")]
	public Dova.JDK.java.text.spi.NumberFormatProvider numberFormatProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[8]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.NumberFormatProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[8], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/spi/CurrencyNameProvider;", "private volatile")]
	public Dova.JDK.java.util.spi.CurrencyNameProvider currencyNameProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[9]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CurrencyNameProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[9], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/spi/LocaleNameProvider;", "private volatile")]
	public Dova.JDK.java.util.spi.LocaleNameProvider localeNameProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[10]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.LocaleNameProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[10], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/spi/TimeZoneNameProvider;", "protected volatile")]
	public Dova.JDK.java.util.spi.TimeZoneNameProvider timeZoneNameProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[11]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.TimeZoneNameProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[11], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/spi/CalendarDataProvider;", "protected volatile")]
	public Dova.JDK.java.util.spi.CalendarDataProvider calendarDataProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[12]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarDataProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[12], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/spi/CalendarNameProvider;", "protected volatile")]
	public Dova.JDK.java.util.spi.CalendarNameProvider calendarNameProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[13]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarNameProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[13], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/spi/CalendarProvider;", "private volatile")]
	public Dova.JDK.sun.util.spi.CalendarProvider calendarProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[14]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.spi.CalendarProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[14], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/text/spi/JavaTimeDateTimePatternProvider;", "private volatile")]
	public Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider javaTimeDateTimePatternProvider_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[15]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[15], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public JRELocaleProviderAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public JRELocaleProviderAdapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/JRELocaleProviderAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DateFormatProvider;", "public")]
	public Dova.JDK.java.text.spi.DateFormatProvider getDateFormatProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DateFormatSymbolsProvider;", "public")]
	public Dova.JDK.java.text.spi.DateFormatSymbolsProvider getDateFormatSymbolsProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatSymbolsProvider>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/resources/LocaleData;", "public")]
	public Dova.JDK.sun.util.resources.LocaleData getLocaleData()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.resources.LocaleData>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Lsun/util/locale/provider/LocaleResources;", "public")]
	public Dova.JDK.sun.util.locale.provider.LocaleResources getLocaleResources(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleResources>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/NumberFormatProvider;", "public")]
	public Dova.JDK.java.text.spi.NumberFormatProvider getNumberFormatProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.NumberFormatProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DecimalFormatSymbolsProvider;", "public")]
	public Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider getDecimalFormatSymbolsProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider>(ret);
	}

	[JniSignatureAttribute("()Lsun/text/spi/JavaTimeDateTimePatternProvider;", "public")]
	public Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider getJavaTimeDateTimePatternProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/spi/CalendarProvider;", "public")]
	public Dova.JDK.sun.util.spi.CalendarProvider getCalendarProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.spi.CalendarProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getCandidateLocales(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "protected")]
	public Dova.JDK.java.util.Set createLanguageTagSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "public")]
	public Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type getAdapterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getLanguageTagSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/BreakIteratorProvider;", "public")]
	public Dova.JDK.java.text.spi.BreakIteratorProvider getBreakIteratorProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.BreakIteratorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarDataProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarDataProvider getCalendarDataProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarDataProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarNameProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarNameProvider getCalendarNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/CollatorProvider;", "public")]
	public Dova.JDK.java.text.spi.CollatorProvider getCollatorProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.CollatorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/TimeZoneNameProvider;", "public")]
	public Dova.JDK.java.util.spi.TimeZoneNameProvider getTimeZoneNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[17]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.TimeZoneNameProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/util/Set;)Z", "public")]
	public bool isSupportedProviderLocale(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[18], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/spi/CurrencyNameProvider;", "public")]
	public Dova.JDK.java.util.spi.CurrencyNameProvider getCurrencyNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[19]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CurrencyNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/LocaleNameProvider;", "public")]
	public Dova.JDK.java.util.spi.LocaleNameProvider getLocaleNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[20]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.LocaleNameProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/lang/String;", "private static")]
	public static Dova.JDK.java.lang.String createSupportedLocaleString(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[21], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.String>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;", "public")]
	public Dova.JDK.java.lang.Object getLocaleServiceProvider(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[22], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("()[Ljava/util/Locale;", "private static")]
	public static JavaArray<Dova.JDK.java.util.Locale> createAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[23]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/JRELocaleProviderAdapter$AvailableJRELocales;", "private static")]
	public partial class AvailableJRELocales
		: Dova.JDK.java.lang.Object
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static AvailableJRELocales()
		{
			ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/locale/provider/JRELocaleProviderAdapter$AvailableJRELocales;");
			ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
			FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "localeList", "[Ljava/util/Locale;"));
			ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		}

		[JniSignatureAttribute("[Ljava/util/Locale;", "private static final")]
		public static JavaArray<Dova.JDK.java.util.Locale> localeList_Property
		{
			get
			{
				var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
				return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
			}
			set
			{
				DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
			}
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public AvailableJRELocales(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public AvailableJRELocales() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/locale/provider/JRELocaleProviderAdapter$AvailableJRELocales;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;
	}
}
