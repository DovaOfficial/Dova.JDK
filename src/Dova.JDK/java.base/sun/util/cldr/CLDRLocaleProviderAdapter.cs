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

namespace Dova.JDK.sun.util.cldr;

[JniSignatureAttribute("Lsun/util/cldr/CLDRLocaleProviderAdapter;", "public")]
public partial class CLDRLocaleProviderAdapter
	: Dova.JDK.sun.util.locale.provider.JRELocaleProviderAdapter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static CLDRLocaleProviderAdapter()
	{
		ClassPtr = DovaVM.Runtime.FindClass("Lsun/util/cldr/CLDRLocaleProviderAdapter;");
		ClassRefPtr = DovaVM.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "baseMetaInfo", "Lsun/util/cldr/CLDRBaseLocaleDataMetaInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetFieldId(ClassPtr, "nonBaseMetaInfo", "Lsun/util/locale/provider/LocaleDataMetaInfo;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "parentLocalesMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "langAliasesMap", "Ljava/util/Map;"));
		FieldPtrs.Add(DovaVM.Runtime.GetStaticFieldId(ClassPtr, "langAliasesCache", "Ljava/util/Map;"));
		ConstructorPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "<init>", "()V"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCandidateLocales", "(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "createLanguageTagSet", "(Ljava/lang/String;)Ljava/util/Set;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "applyAliases", "(Ljava/util/Locale;)Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "applyParentLocales", "(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getParentLocale", "(Ljava/util/Locale;)Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetStaticMethodId(ClassPtr, "getEquivalentLoc", "(Ljava/util/Locale;)Ljava/util/Locale;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getAdapterType", "()Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getBreakIteratorProvider", "()Ljava/text/spi/BreakIteratorProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarDataProvider", "()Ljava/util/spi/CalendarDataProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCalendarNameProvider", "()Ljava/util/spi/CalendarNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getCollatorProvider", "()Ljava/text/spi/CollatorProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "getTimeZoneNameProvider", "()Ljava/util/spi/TimeZoneNameProvider;"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "isSupportedProviderLocale", "(Ljava/util/Locale;Ljava/util/Set;)Z"));
		MethodPtrs.Add(DovaVM.Runtime.GetMethodId(ClassPtr, "canonicalTZID", "(Ljava/lang/String;)Ljava/util/Optional;"));
	}

	[JniSignatureAttribute("Lsun/util/cldr/CLDRBaseLocaleDataMetaInfo;", "private static final")]
	public static Dova.JDK.sun.util.cldr.CLDRBaseLocaleDataMetaInfo baseMetaInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.cldr.CLDRBaseLocaleDataMetaInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[0], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/LocaleDataMetaInfo;", "private final")]
	public Dova.JDK.sun.util.locale.provider.LocaleDataMetaInfo nonBaseMetaInfo_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleDataMetaInfo>(ret);
		}
		set
		{
			DovaVM.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static volatile")]
	public static Dova.JDK.java.util.Map parentLocalesMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static volatile")]
	public static Dova.JDK.java.util.Map langAliasesMap_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[3]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[3], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("Ljava/util/Map;", "private static final")]
	public static Dova.JDK.java.util.Map langAliasesCache_Property
	{
		get
		{
			var ret = DovaVM.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[4]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Map>(ret);
		}
		set
		{
			DovaVM.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[4], value.CurrentRefPtr);
		}
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public CLDRLocaleProviderAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public CLDRLocaleProviderAdapter() : base(DovaVM.Runtime.NewObjectA(ClassPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/cldr/CLDRLocaleProviderAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/Locale;)Ljava/util/List;", "public")]
	public Dova.JDK.java.util.List getCandidateLocales(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Set;", "protected")]
	public Dova.JDK.java.util.Set createLanguageTagSet(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/util/Locale;", "private static")]
	public static Dova.JDK.java.util.Locale applyAliases(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/String;Ljava/util/List;)Ljava/util/List;", "private")]
	public Dova.JDK.java.util.List applyParentLocales(Dova.JDK.java.lang.String arg0, Dova.JDK.java.util.List arg1)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.List>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/util/Locale;", "private static")]
	public static Dova.JDK.java.util.Locale getParentLocale(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[5], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Ljava/util/Locale;", "private static")]
	public static Dova.JDK.java.util.Locale getEquivalentLoc(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaVM.Runtime.CallStaticObjectMethodA(ClassRefPtr, MethodPtrs[6], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Locale>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "public")]
	public Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type getAdapterType()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/BreakIteratorProvider;", "public")]
	public Dova.JDK.java.text.spi.BreakIteratorProvider getBreakIteratorProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.BreakIteratorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarDataProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarDataProvider getCalendarDataProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarDataProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarNameProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarNameProvider getCalendarNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/CollatorProvider;", "public")]
	public Dova.JDK.java.text.spi.CollatorProvider getCollatorProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.CollatorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/TimeZoneNameProvider;", "public")]
	public Dova.JDK.java.util.spi.TimeZoneNameProvider getTimeZoneNameProvider()
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.TimeZoneNameProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;Ljava/util/Set;)Z", "public")]
	public bool isSupportedProviderLocale(Dova.JDK.java.util.Locale arg0, Dova.JDK.java.util.Set arg1)
	{
		var ret = DovaVM.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[13], arg0, arg1);
		return ret;
	}

	[JniSignatureAttribute("(Ljava/lang/String;)Ljava/util/Optional;", "public")]
	public Dova.JDK.java.util.Optional canonicalTZID(Dova.JDK.java.lang.String arg0)
	{
		var ret = DovaVM.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Optional>(ret);
	}
}
