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

[JniSignatureAttribute("Lsun/util/locale/provider/DateFormatProviderImpl;", "public")]
public partial class DateFormatProviderImpl
	: Dova.JDK.java.text.spi.DateFormatProvider
	, Dova.JDK.sun.util.locale.provider.AvailableLanguageTags
{
	public new static CSharpSystem.IntPtr ClassPtr { get; }
	public new static CSharpSystem.IntPtr ClassRefPtr { get; }

	private new static CSharpSystem.Collections.Generic.IList<IntPtr> FieldPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> ConstructorPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();
	private new static CSharpSystem.Collections.Generic.IList<IntPtr> MethodPtrs { get; } = new CSharpSystem.Collections.Generic.List<IntPtr>();

	static DateFormatProviderImpl()
	{
		ClassPtr = DovaJvm.Vm.Runtime.FindClass("Lsun/util/locale/provider/DateFormatProviderImpl;");
		ClassRefPtr = DovaJvm.Vm.Runtime.NewGlobalRef(ClassPtr);
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "type", "Lsun/util/locale/provider/LocaleProviderAdapter$Type;"));
		FieldPtrs.Add(DovaJvm.Vm.Runtime.GetFieldId(ClassRefPtr, "langtags", "Ljava/util/Set;"));
		ConstructorPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "DateFormatProviderImpl", "(Lsun/util/locale/provider/LocaleProviderAdapter$Type;Ljava/util/Set;)V"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDateTimeInstance", "(IILjava/util/Locale;)Ljava/text/DateFormat;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAvailableLocales", "()[Ljava/util/Locale;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getDateInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getTimeInstance", "(ILjava/util/Locale;)Ljava/text/DateFormat;"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "isSupportedLocale", "(Ljava/util/Locale;)Z"));
		MethodPtrs.Add(DovaJvm.Vm.Runtime.GetMethodId(ClassRefPtr, "getAvailableLanguageTags", "()Ljava/util/Set;"));
	}

	[JniSignatureAttribute("Lsun/util/locale/provider/LocaleProviderAdapter$Type;", "private final")]
	public Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type type_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[0]);
			return DovaInterfaceFactory.Get<Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[0], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("Ljava/util/Set;", "private final")]
	public Dova.JDK.java.util.Set langtags_Property
	{
		get
		{
			var ret = DovaJvm.Vm.Runtime.GetObjectField(CurrentRefPtr, FieldPtrs[1]);
			return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
		}
		set => DovaJvm.Vm.Runtime.SetObjectField(CurrentRefPtr, FieldPtrs[1], value.CurrentRefPtr);
	}

	[JniSignatureAttribute("(System.IntPtr)V", "public")]
	public DateFormatProviderImpl(IntPtr currentRefPtr) : base(currentRefPtr)
	{
	}

	[JniSignatureAttribute("(Lsun/util/locale/provider/LocaleProviderAdapter$Type;Ljava/util/Set;)V", "public")]
	public DateFormatProviderImpl(Dova.JDK.sun.util.locale.provider.LocaleProviderAdapter.Type arg0, Dova.JDK.java.util.Set arg1) : base(DovaJvm.Vm.Runtime.NewObjectA(ClassRefPtr, ConstructorPtrs[0], arg0, arg1))
	{
	}

	public override string GetJavaClassSignature() => "Lsun/util/locale/provider/DateFormatProviderImpl;";
	public override IntPtr GetJavaClassRaw() => ClassPtr;
	public override IntPtr GetJavaClassRefRaw() => ClassRefPtr;

	[JniSignatureAttribute("(IILjava/util/Locale;)Ljava/text/DateFormat;", "private")]
	public Dova.JDK.java.text.DateFormat getInstance(int arg0, int arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[0], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
	}

	[JniSignatureAttribute("(IILjava/util/Locale;)Ljava/text/DateFormat;", "public")]
	public Dova.JDK.java.text.DateFormat getDateTimeInstance(int arg0, int arg1, Dova.JDK.java.util.Locale arg2)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[1], arg0, arg1, arg2);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
	}

	[JniSignatureAttribute("()[Ljava/util/Locale;", "public")]
	public JavaArray<Dova.JDK.java.util.Locale> getAvailableLocales()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[2]);
		return DovaInterfaceFactory.Get<JavaArray<Dova.JDK.java.util.Locale>>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Locale;)Ljava/text/DateFormat;", "public")]
	public Dova.JDK.java.text.DateFormat getDateInstance(int arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[3], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
	}

	[JniSignatureAttribute("(ILjava/util/Locale;)Ljava/text/DateFormat;", "public")]
	public Dova.JDK.java.text.DateFormat getTimeInstance(int arg0, Dova.JDK.java.util.Locale arg1)
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[4], arg0, arg1);
		return DovaInterfaceFactory.Get<Dova.JDK.java.text.DateFormat>(ret);
	}

	[JniSignatureAttribute("(Ljava/util/Locale;)Z", "public")]
	public bool isSupportedLocale(Dova.JDK.java.util.Locale arg0)
	{
		var ret = DovaJvm.Vm.Runtime.CallBooleanMethodA(CurrentRefPtr, MethodPtrs[5], arg0);
		return ret;
	}

	[JniSignatureAttribute("()Ljava/util/Set;", "public")]
	public Dova.JDK.java.util.Set getAvailableLanguageTags()
	{
		var ret = DovaJvm.Vm.Runtime.CallObjectMethodA(CurrentRefPtr, MethodPtrs[6]);
		return DovaInterfaceFactory.Get<Dova.JDK.java.util.Set>(ret);
	}
}
