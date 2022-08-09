/*******************************************************************
 *
 * This file was automatically generated with:
 * Dova.Tools.DefinitionGenerator (on 2022.08.09-04:27)
 *
 * For more information please visit:
 * https://github.com/DovaOfficial
 *
 ********************************************************************/

using Dova.Common;
using Dova.Common.InterfaceFactory;

using CSharpSystem = System;

namespace Dova.JDK.sun.util.locale.provider;

[JniSignatureAttribute("Lsun/util/locale/provider/AuxLocaleProviderAdapter;", "public abstract")]
public partial class AuxLocaleProviderAdapter
	: Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static AuxLocaleProviderAdapter()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/locale/provider/AuxLocaleProviderAdapter;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "providersMap", "Ljava/util/concurrent/ConcurrentMap;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "availableLocales", "[Ljava/util/Locale;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetStaticFieldId(ClassRefPtr, "NULL_PROVIDER", "Lsun/util/locale/provider/AuxLocaleProviderAdapter$NullProvider;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "AuxLocaleProviderAdapter", "()V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDateFormatProvider", "()Ljava/text/spi/DateFormatProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDateFormatSymbolsProvider", "()Ljava/text/spi/DateFormatSymbolsProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLocaleResources", "(Ljava/util/Locale;)Lsun/util/locale/provider/LocaleResources;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getNumberFormatProvider", "()Ljava/text/spi/NumberFormatProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDecimalFormatSymbolsProvider", "()Ljava/text/spi/DecimalFormatSymbolsProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getJavaTimeDateTimePatternProvider", "()Lsun/text/spi/JavaTimeDateTimePatternProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarProvider", "()Lsun/util/spi/CalendarProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getBreakIteratorProvider", "()Ljava/text/spi/BreakIteratorProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarDataProvider", "()Ljava/util/spi/CalendarDataProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCalendarNameProvider", "()Ljava/util/spi/CalendarNameProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCollatorProvider", "()Ljava/text/spi/CollatorProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTimeZoneNameProvider", "()Ljava/util/spi/TimeZoneNameProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getCurrencyNameProvider", "()Ljava/util/spi/CurrencyNameProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLocaleNameProvider", "()Ljava/util/spi/LocaleNameProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getLocaleServiceProvider", "(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "findInstalledProvider", "(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;"));
	}

	[JniSignatureAttribute("Ljava/util/concurrent/ConcurrentMap;", "private final")]
	public Dova.JDK.java.util.concurrent.ConcurrentMap providersMap_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.concurrent.ConcurrentMap>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("[Ljava/util/Locale;", "private static")]
	public static JavaArray<Dova.JDK.java.util.Locale> availableLocales_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/AuxLocaleProviderAdapter$NullProvider;", "private static final")]
	public static Dova.JDK.sun.util.locale.provider.AuxLocaleProviderAdapter.NullProvider NULL_PROVIDER_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetStaticObjectField(ClassRefPtr, FieldPtrs[2]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.AuxLocaleProviderAdapter.NullProvider>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetStaticObjectField(ClassRefPtr, FieldPtrs[2], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public AuxLocaleProviderAdapter(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("()V", "public")]
	public AuxLocaleProviderAdapter() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/AuxLocaleProviderAdapter;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DateFormatProvider;", "public")]
	public Dova.JDK.java.text.spi.DateFormatProvider getDateFormatProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DateFormatSymbolsProvider;", "public")]
	public Dova.JDK.java.text.spi.DateFormatSymbolsProvider getDateFormatSymbolsProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DateFormatSymbolsProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Lsun/util/locale/provider/LocaleResources;", "public")]
	public Dova.JDK.sun.util.locale.provider.LocaleResources getLocaleResources(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleResources>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/NumberFormatProvider;", "public")]
	public Dova.JDK.java.text.spi.NumberFormatProvider getNumberFormatProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.NumberFormatProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/DecimalFormatSymbolsProvider;", "public")]
	public Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider getDecimalFormatSymbolsProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[5]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.DecimalFormatSymbolsProvider>(ret);
	}

	[JniSignatureAttribute("()Lsun/text/spi/JavaTimeDateTimePatternProvider;", "public")]
	public Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider getJavaTimeDateTimePatternProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.text.spi.JavaTimeDateTimePatternProvider>(ret);
	}

	[JniSignatureAttribute("()Lsun/util/spi/CalendarProvider;", "public")]
	public Dova.JDK.sun.util.spi.CalendarProvider getCalendarProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[7]);
		return DovaInterfaceFactory.Get<Dova.JDK.sun.util.spi.CalendarProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/BreakIteratorProvider;", "public")]
	public Dova.JDK.java.text.spi.BreakIteratorProvider getBreakIteratorProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[8]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.BreakIteratorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarDataProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarDataProvider getCalendarDataProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[9]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarDataProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CalendarNameProvider;", "public")]
	public Dova.JDK.java.util.spi.CalendarNameProvider getCalendarNameProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[10]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CalendarNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/text/spi/CollatorProvider;", "public")]
	public Dova.JDK.java.text.spi.CollatorProvider getCollatorProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[11]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.spi.CollatorProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/TimeZoneNameProvider;", "public")]
	public Dova.JDK.java.util.spi.TimeZoneNameProvider getTimeZoneNameProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[12]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.TimeZoneNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/CurrencyNameProvider;", "public")]
	public Dova.JDK.java.util.spi.CurrencyNameProvider getCurrencyNameProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[13]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.CurrencyNameProvider>(ret);
	}

	[JniSignatureAttribute("()Ljava/util/spi/LocaleNameProvider;", "public")]
	public Dova.JDK.java.util.spi.LocaleNameProvider getLocaleNameProvider()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[14]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.spi.LocaleNameProvider>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;", "public")]
	public Dova.JDK.java.lang.Object getLocaleServiceProvider(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[15], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("(Ljava/lang/Class;)Ljava/util/spi/LocaleServiceProvider;", "protected abstract")]
	public Dova.JDK.java.lang.Object findInstalledProvider(Dova.JDK.java.lang.Class arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[16], arg0);
		return DovaInterfaceFactory.Get<Dova.JDK.java.lang.Object>(ret);
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/AuxLocaleProviderAdapter$NullProvider;", "private static")]
	public partial class NullProvider
		: Dova.JDK.java.util.spi.LocaleServiceProvider
	{
		public new static CSharpSystem.IntPtr ClassPtr { get; }
		public new static CSharpSystem.IntPtr ClassRefPtr { get; }

		private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
		private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

		static NullProvider()
		{
			ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/locale/provider/AuxLocaleProviderAdapter$NullProvider;");
			ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
			ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "NullProvider", "()V"));
			MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		}

		[JniSignatureAttribute("(System.IntPtr)V", "public")]
		public NullProvider(IntPtr currentRefPtr) : base(currentRefPtr)
		{
		}

		[JniSignatureAttribute("()V", "private")]
		public NullProvider() : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0]))
		{
		}

		public override string GetJavaClassSignature() => "Lsun/util/locale/provider/AuxLocaleProviderAdapter$NullProvider;";
		public override IntPtr GetJavaClassRaw() => ClassPtr;
		public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

		[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
		public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
		{
			var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0]);
			return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
		}
	}
}
